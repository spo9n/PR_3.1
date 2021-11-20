using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3._1_Surgai_ZVD4
{
    class CarInfo
    {
        public string Number;
        string Model;
        string Color;

        string OwnersFirstName;
        string OwnersLastName;

        public CarInfo(string number, string model, string color, string fname, string lname)
        {
            Number = number;
            Model = model;
            Color = color;
            OwnersFirstName = fname;
            OwnersLastName = lname;
        }
    }
}
