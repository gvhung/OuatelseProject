﻿using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
                
            //Reload items
            ReloadData();
        }

       
        private void ReloadData()
        {
            this.listView_employees.Items.Clear();
            foreach(Employee e in EmployeeManager.Instance.All()){
                ListViewItem employee = this.listView_employees.Items.Add(e.Id.ToString());
                employee.SubItems.Add(e.LastName.ToString());
                employee.SubItems.Add(e.FirstName.ToString());
                employee.SubItems.Add(e.Email.ToString());
                employee.SubItems.Add(e.Role.Name.ToString());
                employee.SubItems.Add(e.Store.City.Name.ToString());
                employee.Tag = e;
            }
        }

    }
}
