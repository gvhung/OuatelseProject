﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ouatelse.Models
{
    public class Gender : BaseModel, IModel
    {
        public string Name { get; set; }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.Name = cursor.Read().ToString();
        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string> {{"nom", Name}};
            return res;
        }
    }
}
