﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Bomy.Model
{
    public class Expediente
    {
        public int Index { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public double Total { get; set; }
    }
}
