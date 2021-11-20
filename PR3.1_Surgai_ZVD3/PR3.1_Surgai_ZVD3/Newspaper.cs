﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3._1_Surgai_ZVD3
{
    class Newspaper : Printing
    {
        private DateTime dateOfPublication;

        public Newspaper() { }

        public Newspaper(string _name, int _year, int _numberOfCopiesInLibrary, int _numberOfCopiesTakenByReaders, DateTime _dateOfPublication)
            : base(_name, _year, _numberOfCopiesInLibrary, _numberOfCopiesTakenByReaders)
        {
            dateOfPublication = _dateOfPublication;
        }
    }
}
