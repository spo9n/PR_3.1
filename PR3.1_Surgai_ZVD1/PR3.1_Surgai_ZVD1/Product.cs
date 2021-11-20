using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3._1_Surgai_ZVD1
{
    class Product
    {
        private string name;
        private int count;
        private string measure;
        private double price;
        private DateTime dateOfExpire;

        public Product() { }

        public double ExpiryDate()
        {
            return (dateOfExpire - DateTime.Now).TotalDays;
        } 

        public double getCostOfGoods(int count_)
        {
            return price * count_;
        }

        public void IncreasingPoroducts(int value)
        {
            if (value > 0)
            {
                count += value;
            }
        }
    }
}
