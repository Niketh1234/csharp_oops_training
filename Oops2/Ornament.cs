using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops2
{
    abstract class Ornament
    {
        string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public OrnamentType Type { get; set; }
        public double Weight { get; set; }
        public virtual void Accept()
        {
            Console.WriteLine("Enter the Name of the Ornament : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Weight of the Ornament : ");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the Ornament type : 1.Chain 2.Bracelet 3.Anklet 4.Ring 5.Bangle 6.EarRings 7.Necklace");
            switch (Convert.ToByte(Console.ReadLine())) { 
                case 1:
                    Type = OrnamentType.Chain; break;
                case 2:
                    Type = OrnamentType.Bracelet; break;
                case 3:
                    Type = OrnamentType.Anklet; break;
                case 4:
                    Type = OrnamentType.Ring; break;
                case 5:
                    Type = OrnamentType.Bangle; break;
                case 6:
                    Type = OrnamentType.EarRings; break;
                case 7:
                    Type = OrnamentType.Necklace; break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
        public virtual void Show()
        {
            Console.WriteLine($"{Name}, {Weight}, {Type}");
        }
    }
    public enum OrnamentType
    {
        Chain=1,Bracelet, Anklet, Ring,Bangle, EarRings, Necklace
    }
}
