namespace Exo_Animalerie.Models
{
    public class Animal
    {
        public enum SexeEnum { M, F }

        public string Nom { get; set; }
        public double Poids { get; set; }
        public double Taille { get; set; }
        public SexeEnum Sexe { get; set; }
        public int Age { get; set; }
        public DateTime DateArrive { get; set; }
        public bool EstMort { get; private set; } = false;

        protected virtual double ProbaliteDeces 
        { 
            get { return 100; } 
        }

        public virtual string Crier()
        {
            return "N/A";
        }

        public virtual string GetDescription()
        {
            return $"{Nom} - Age : {Age}, Sexe: {Sexe}, Poids: {Poids}, Taille: {Taille}";
        }

        public virtual void PasserNuit()
        {
            if (EstMort) return;

            double chance = Math.Round(Random.Shared.NextDouble() * 100, 1);

            if(chance <= ProbaliteDeces)
            {
                EstMort = true;
            }
        }
    }
}
