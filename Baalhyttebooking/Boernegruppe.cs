namespace Baalhyttebooking
{
    public class Boernegruppe
    {
        private string id;
        private string navn;
        private string aldersgruppe;
        private int antalDeltagere;

        public Boernegruppe(string id, string navn, string aldersggruppe, int antalDeltagere)
        {
            this.id = id;
            this.navn = navn;
            this.aldersgruppe = aldersggruppe;
            this.antalDeltagere = antalDeltagere;
        }

        public string ID
        {
            get { return id; }
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public string Aldersgruppe
        {
            get { return aldersgruppe; }
            set { aldersgruppe = value; }
        }



        public int AntalDeltagere
        {
            get { return antalDeltagere; }
            set { antalDeltagere = value; }
        }

        public override string ToString()
        {
            return ($"ID: {ID}, Navn: {Navn}, Alders Gruppe: {Aldersgruppe} Antal Deltager: {AntalDeltagere}\n");
        }
    }
}
