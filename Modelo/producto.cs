﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class producto
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public fabricante fabricante { get; set; }
        public List<object> productos { get; set; }
    }
}
