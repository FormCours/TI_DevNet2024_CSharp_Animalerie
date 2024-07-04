using Exo_Animalerie.Models;
using System.Text;

namespace Exo_Animalerie.Models
{
    public class Animalerie
    {
        private List<Animal> _Animaux = new List<Animal>();

        public string Nom { get; set; }
        public IEnumerable<Animal> Animaux
        {
            get { return _Animaux.AsReadOnly(); }
        }
       

        public void AjouterAnimal(Animal animal)
        {
            _Animaux.Add(animal);
        }
        public int GetNbAnimal<TypeAnimal>()
        {
            int nbTarget = 0;
            foreach (Animal animal in Animaux)
            {
                if (animal is TypeAnimal) { nbTarget++; }
            }
            return nbTarget;
        }
        public string GetListing()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Animal animal in Animaux)
            {
                sb.AppendLine(animal.GetDescription());
            }
            return sb.ToString();
        }
        public string FairePasserUneJournee()
        {
            StringBuilder resume = new StringBuilder();

            resume.Append(EventDuMatin());
            resume.AppendLine();

            resume.Append(EventDeLaJournee());
            resume.AppendLine();

            resume.Append(EventDeLaNuit());

            return resume.ToString();
        }

        private string EventDeLaNuit()
        {
            StringBuilder resume = new StringBuilder();

            resume.AppendLine("La nuit tombe...");
            foreach (Animal animal in Animaux)
            {
                animal.PasserNuit();

                if(animal.EstMort)
                {
                    resume.AppendLine($" - {animal.Nom} est mouru");
                }
            }

            //for (int i = 0;i < _Animaux.Count; i++)
            //{
            //    if (_Animaux[i].EstMort)
            //    {
            //        _Animaux.RemoveAt(i);
            //        i--;
            //    }
            //}
            _Animaux.RemoveAll(animal => animal.EstMort);

            return resume.ToString();
        }

        private string EventDeLaJournee()
        {
            StringBuilder resume = new StringBuilder();

            resume.AppendLine("Event de la journée...");
            foreach (Animal anim in Animaux)
            {
                if (anim is Chat chat && !chat.GriffesCoupees)
                {
                    resume.AppendLine($" - {chat.Nom} griffes Jean Jean !");
                    chat.CouperGriffes();
                }

                if (anim is Oiseau)
                {
                    resume.AppendLine($" - {anim.Nom} chante : {anim.Crier()}");
                }
            }

            return resume.ToString();
        }

        private string EventDuMatin()
        {
            StringBuilder resume = new StringBuilder();

            resume.AppendLine("Population de l'animalerie (Matin) : ");
            foreach (Animal anim in Animaux)
            {
                resume.AppendLine($" - {anim.Nom}");
            }

            return resume.ToString() ;
        }
    }
}
