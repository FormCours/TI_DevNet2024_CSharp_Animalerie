namespace Exo_Animalerie.Models
{
    public class Chien : Animal
    {
        public string CouleurCollier { get; set; }
        public bool EstDresse { get; set; }
        public string Race { get; set; }
        protected override double ProbaliteDeces
        {
            get { return 1; }
        }

        public override string Crier()
        {
            return "Wouf !";
        }
        public override string GetDescription()
        {
            string desc = "[Chien] " + base.GetDescription() + $", Race: {Race}";
            if (EstDresse)
            {
                desc += ", a été dressé";
            }
            return desc;
        }
    }
}
