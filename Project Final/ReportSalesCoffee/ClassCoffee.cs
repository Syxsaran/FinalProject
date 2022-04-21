using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSalesCoffee
{
    internal class ClassCoffee
    {
        private string _num;
        private string _name;
        private string _amount;
        private string _date;

        public ClassCoffee(string num, string name, string amount, string date)
        {
            this._num = num;
            this._name = name;
            this._amount = amount;
            this._date = date;
        }
        public string getNum()
        {
            return _num;
        }
        public string getName()
        {
            return _name;
        }
        public string getAmount()
        {
            return _amount;
        }
        public string getDate()
        {
            return _date;
        }
    }
}
