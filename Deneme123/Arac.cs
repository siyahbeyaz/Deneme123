﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme123
{
    class Arac
    {

        // Marka Bilgisi
        private string _marka;

        public string Marka
        {
            get { return  _marka; }
            set { string _marka = value; }
        }


        private int _model;

        public int Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}
