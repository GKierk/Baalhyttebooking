namespace Baalhyttebooking
{
    public class Reservationer
    {
        int id;
        private Dictionary<int, Reservation> reservations;

        public Reservationer (int id)
        {
            ID = id;
            Reservations = new Dictionary<int, Reservation>();
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Dictionary<int, Reservation> Reservations
        {
            get { return reservations; }
            set { reservations = value; }
        }

        public void RegistrerReservation(Reservation reservation)
        {
            Reservations.Add(reservation.ID, reservation);
        }

        public void PrintReservationer()
        {
            foreach (var r in Reservations)
            {
                Console.WriteLine($"ID: {ID}, Reservations ID: {r.Key}, {r.Value}");
            }
        }

        public void FjernReservation(Reservation reservation)
        {
            Reservations.Remove(reservation.ID);
        }

        public int AntalReservationer(Boernegruppe bGruppe)
        {
            int counter = 0;

            //foreach (var r in Reservations.Values)
            //{
            //}

            return counter;
        }
    }
}
