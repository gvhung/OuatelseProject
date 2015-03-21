using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Ouatelse.Models
{
    public class Invoice : BaseModel, IModel
    {
        public DateTime Date { get; set; }
        public float DiscountPercent { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public bool IsPaid { get; set; }
        public float PaidAmount { get; set; }

        public ManyCollection<InvoiceProduct> Products;

        public Invoice()
        {
            Date = DateTime.Now;
            DiscountPercent = 0;
            Products = new ManyCollection<InvoiceProduct>(this, InvoiceProductManager.Instance, @"factures_id", @"Invoice");
        }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Date = DateTime.Parse(cursor.Read().ToString());
            this.DiscountPercent = Convert.ToSingle(cursor.Read().ToString());
            this.Employee = EmployeeManager.Instance.Find(cursor.Read().ToString());
            this.Customer = CustomerManager.Instance.Find(cursor.Read().ToString());
            this.Payment = PaymentManager.Instance.Find(cursor.Read().ToString());
            this.IsPaid = cursor.Read().ToString() == "True";
            this.PaidAmount = Convert.ToSingle(cursor.Read().ToString());
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("date", Date.ToString("yyyy-MM-dd"));
            res.Add("pourcentage_remise", DiscountPercent.ToString());
            res.Add("salaries_id", Employee.Id.ToString());
            res.Add("clients_id", Customer == null ? "0" : Customer.Id.ToString());
            res.Add("moyen_de_paiements_id", Payment.Id.ToString());
            res.Add("estPaye", IsPaid ? "1" : "0");
            res.Add("montantPaye", PaidAmount.ToString(CultureInfo.InvariantCulture));
            return res;
        }

        public void AddProduct(Product product)
        {
            InvoiceProduct invoiceProduct = new InvoiceProduct {Product = product, Quantity = 1};
            Products.Add(invoiceProduct);
        }

        // ReSharper disable once InconsistentNaming
        public double TotalHT
        {
            get
            {
                return Products.Items.Aggregate<InvoiceProduct, double>(0, (current, invoiceProduct) => current + invoiceProduct.Price);
            }
        }

        // ReSharper disable once InconsistentNaming
        public double TotalTVA
        {
            get
            {
                return Products.Items.Aggregate<InvoiceProduct, double>(0, (current, item) => current + ((item.Product.TVA/100)*item.Price));
            }
        }

        // ReSharper disable once InconsistentNaming
        public double TotalTTC
        {
            get
            {
                double total= TotalHT + TotalTVA;
                return total - ((DiscountPercent / 100) * total); 
            }
        }

        public double Reste
        {
            get { return TotalTTC - PaidAmount; }
        }

        public double Arendre
        {
            get { return PaidAmount - TotalTTC; }
        }

        public string ProductsString
        {
            get
            {
                Products.Reload();
                List<string> res = Products.Items.Select(invoiceProduct => string.Format("{0}x {1}", invoiceProduct.Quantity, invoiceProduct.Product.Name)).ToList();
                return String.Join(@", ", res);
            }
        }
    }
}
