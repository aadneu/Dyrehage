

namespace Dyrehage
{
    internal class Jæren
    {
        public List<TamDyr> DyrPåJæren = new List<TamDyr>()
        {
            
        };

        public void ShowAnimalJæren()
        {
            foreach (var animal in DyrPåJæren)
            {
                animal.ShowAnimal();
            }
        }

        Random rand()
        {
            var rand = new Random();
            return rand;
        }

        public void GenerateAnimal(int x)
        {
            for (int i = 0; i < x; i++)
            {
                DyrPåJæren.Add(new TamDyr(ReturnType(), ReturnName(), MaleOrFemale(), rand().Next(0, 21)));
            }
        }

        string ReturnType()
        {
            int length = TypeDyrPåJæren.Count;
            var type = TypeDyrPåJæren[rand().Next(0, length)];
            return type;
        }

        string ReturnName()
        {
            int length = NavnDyrPåJæren.Count;
            var type = NavnDyrPåJæren[rand().Next(0, length)];
            return type;
        }

        bool MaleOrFemale()
        {
            int MaleOrFemale = rand().Next(0, 2);
            return MaleOrFemale == 1;
        }

        List<string> TypeDyrPåJæren = new List<string>
        {
            "Ku",
            "Gris",
            "Hest",
            "Høne",
            "Geit",
            "Sau",
            "Kylling",
            "And",
            "Hane",
            "Kalkun",
            "Katt",
            "Hund",
            "Kanin",
            "Papegøye"
        };

        List<string> NavnDyrPåJæren = new List<string>
        {
            "Berta",
            "Oskar",
            "Luna",
            "Milo",
            "Dolly",
            "Gunnar",
            "Sara",
            "Petter",
            "Emma",
            "Olaf",
            "Mia",
            "Buddy",
            "Lilly",
            "Charlie"
        };
    }
}
