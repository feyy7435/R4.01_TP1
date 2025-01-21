namespace WSConvertisseur.Models
{
    public class Devise
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int nomdevise;

        public int NomDevise
        {
            get { return nomdevise; }
            set { nomdevise = value; }
        }

        private int taux;

        public int Taux
        {
            get { return taux; }
            set { taux = value; }
        }
        public Devise(){ }

        public Devise(int id, int nomdevise, int taux)
        {
            this.id = id;
            this.nomdevise = nomdevise;
            this.taux = taux;
        }
    }
}
