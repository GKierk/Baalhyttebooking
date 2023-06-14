using Baalhyttebooking;

class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        string navn;
        Reservationer reservationer = new Reservationer(1);

        string aldersGruppe = rand.Next(0,18).ToString();
        int antalDeltagere = rand.Next(0, 30);
        Boernegruppe gruppe1 = new Boernegruppe("1", "Ulve Flokken", aldersGruppe, antalDeltagere);

        aldersGruppe = rand.Next(0, 18).ToString();
        antalDeltagere = rand.Next(0, 30);

        aldersGruppe = rand.Next(0, 18).ToString();
        antalDeltagere = rand.Next(0, 30);
        Boernegruppe gruppe2 = new Boernegruppe("2", "De Røde Fugle", aldersGruppe, antalDeltagere);
        Boernegruppe gruppe3 = new Boernegruppe("3", "Ravnene", aldersGruppe, antalDeltagere);

        Console.WriteLine(gruppe1);
        Console.WriteLine(gruppe2);
        Console.WriteLine(gruppe3);

        Reservation resevation1 = new Reservation(1, DateTime.Now, gruppe1);
        Reservation resevation2 = new Reservation(2, DateTime.Now, gruppe2);
        Reservation resevation3 = new Reservation(3, DateTime.Now, gruppe3);

        reservationer.RegistrerReservation(resevation1);
        reservationer.RegistrerReservation(resevation2);
        reservationer.RegistrerReservation(resevation3);
        reservationer.PrintReservationer();
        reservationer.FjernReservation(resevation2);
        reservationer.PrintReservationer();

        Console.WriteLine(reservationer.AntalReservationer(gruppe1));
    }
}