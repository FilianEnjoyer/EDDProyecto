﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        public String Dato;
        public Nodo Sig;
        public Nodo(string dato)
        {
            Dato = dato;
            Sig = null;
        }
    }
}
