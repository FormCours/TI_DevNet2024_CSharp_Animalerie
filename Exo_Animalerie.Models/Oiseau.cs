using System.Text;

namespace Exo_Animalerie.Models
{
    public class Oiseau: Animal
    {
        public enum HabitatEnum { Cage, Voliere }

        public string Couleur { get; set; }
        public HabitatEnum Habitat {get; set;}
        protected override double ProbaliteDeces
        {
            get { return 3; }
        }

        public override string Crier()
        {
            string cri = "Cui cui";
            int nbCri = Random.Shared.Next(1, 10);

            StringBuilder sb = new StringBuilder(cri);
            for(int i = 1; i < nbCri; i++)
            {
                sb.Append(" ").Append(cri);
            }

            return sb.ToString();
        }
        public override string GetDescription()
        {
            return "[Oiseau] " + base.GetDescription() + $", Couleur : {Couleur}, Habitat : {Habitat}";
        }
    }
}
