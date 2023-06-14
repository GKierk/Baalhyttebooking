using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        private int id;
        private DateTime tidspunkt;
        private Boernegruppe boernegruppe;


        public Reservation() { }

        public Reservation(int id, DateTime dateTime, Boernegruppe boernegruppe)
        {
            this.id = id;
            tidspunkt = DateTime.Now;
            this.boernegruppe = boernegruppe;
        }

        public int ID
        { 
            get { return id; } 
        }

        public DateTime Tidspunkt
        {
            get { return tidspunkt; }
            set { tidspunkt = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Tidspunkt: {Tidspunkt} \nBøerne gruppe - {boernegruppe}\n";
        }
    }

}
