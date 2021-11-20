using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3._1_Surgai_ZVD3
{
    class Magazine : Printing
    {
        private long publicationNumber;

        public Magazine() { }

        public Magazine(string _name, int _year, int _numberOfCopiesInLibrary, int _numberOfCopiesTakenByReaders, long _publicationNumber)
            : base(_name, _year, _numberOfCopiesInLibrary, _numberOfCopiesInLibrary)
        {
            publicationNumber = _publicationNumber;
        }
    }
}
