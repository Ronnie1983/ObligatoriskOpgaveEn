using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveEtLib.Model
{
    public class Cykel
    {
        private int _id;
        private string _farve;
        private int _price;
        private int _gear;

        public Cykel(int id, string farve, int price, int gear)
        {
            Id = id;
            Farve = farve;
            Price = price;
            Gear = gear;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Farve
        {
            get => _farve;
            set
            {
                if (value.Length>1)
                {
                    _farve = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Minimum et tegn");
                }
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value>0)
                {
                   _price = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Pris skal være større en nul");
                }
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (value >= 3 && value <= 32)
                {
                    _gear = value;
                } else
                {
                    throw new ArgumentOutOfRangeException("Tallet skal være mellem 3 og 32");
                }
            }
        }

        public override string ToString()
        {
            return $"cykel med {Gear} gear til {Price}";
        }
    }
}
