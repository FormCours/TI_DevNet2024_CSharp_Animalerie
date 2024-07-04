namespace Exo_Animalerie.Models
{
    public class Chat : Animal
    {
        public enum PoilEnum { Court, Long }

        public string Caractere { get; set; }
        private int TaillesGriffes { get; set; } = 0;
        public bool GriffesCoupees
        {
            get { return TaillesGriffes < 10; }
        }
        public PoilEnum Poil { get; set; }
        protected override double ProbaliteDeces
        {
            get { return 0.5; }
        }

        public override string Crier()
        {
            return "Miaou !";
        }
        private void FairePousserGriffes()
        {
            TaillesGriffes++;
        }
        public void CouperGriffes()
        {
            TaillesGriffes = 0;
        }

        
        public override string GetDescription()
        {
            // base.GetDescription() => $"{Nom} - Age : {Age}, Sexe: {Sexe}, Poids: {Poids}, Taille: {Taille}";
            return "[Chat] " + base.GetDescription() + $", Poil: {Poil}, Caractere: {Caractere}";
        }
        public override void PasserNuit()
        {
            base.PasserNuit();

            if(!EstMort)
            {
                FairePousserGriffes();
            }
        }
    }
}
