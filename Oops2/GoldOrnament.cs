using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops2
{
    internal class GoldOrnament : Ornament,IBill
    {
        public byte Purity { get; set; }
        public double Amount { get; set; }

        public override void Accept() {
            base.Accept();
            Console.WriteLine("Enter the Purity");
            Purity = Convert.ToByte(Console.ReadLine());
        }

        public void SetName(string Name)
        {
            Console.WriteLine("implicit");
        }
        void IBill.SetName(string Name)
        {
            Console.WriteLine("explicit");
        }

        public override void Show() {
            base.Show();
            Console.WriteLine($"{Purity}");
        }

        string[] _shops = new string[10];
        public string this[int index]
        {
            get
            {
                return _shops[index];
            }
            set
            {
                _shops[index] = value;
            }
        }
    }
}
