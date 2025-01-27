namespace WSConvertisseur.Models
{
    public class Devise
    {
        private int id;
        private string nomdevise;
        private double taux;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomDevise
        {
            get { return nomdevise; }
            set { nomdevise = value; }
        }

        public double Taux
        {
            get { return taux; }
            set { taux = value; }
        }
        public Devise(){ }

        public Devise(int id, string nomdevise, double taux)
        {
            this.id = id;
            this.nomdevise = nomdevise;
            this.taux = taux;
        }
    }
}
