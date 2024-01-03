

namespace Dyrehage
{
    internal class Jungelen
    {
        public List<VillDyr> DyrIJungelen = new List<VillDyr>();

        public void ShowAnimalJungle()
        {
            foreach (var animal in DyrIJungelen)
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
                DyrIJungelen.Add(new VillDyr(ReturnType(), ReturnName(), MaleOrFemale(), rand().Next(0, 21)));
            }
        }

        string ReturnType()
        {
            int length = TypeDyrIJungelen.Count;
            var type = TypeDyrIJungelen[rand().Next(0, length)];
            return type;
        }

        string ReturnName()
        {
            int length = NavnDyrIJungelen.Count;
            var type = NavnDyrIJungelen[rand().Next(0, length)];
            return type;
        }

        bool MaleOrFemale()
        {
            int MaleOrFemale = rand().Next(0, 2);
            return MaleOrFemale == 1;
        }

        List<string> TypeDyrIJungelen = new List<string>
        {
            "Sjimpanse",
            "Gorilla",
            "Tiger",
            "Elefant",
            "Slange",
            "Ape",
            "Krokodille",
            "Papegøye",
            "Jaguar",
            "Flaggermus",
            "Panda",
            "Kameleoner",
            "Koala",
            "Villsvin",
            "Orangutang",
            "Frosk",
            "Tarantella",
            "Tukan"
        };

        private List<string> NavnDyrIJungelen = new List<string>
        {
            "Coco",
            "Banjo",
            "Mango",
            "Bella",
            "Jungle",
            "Kai",
            "Ziggy",
            "Kala",
            "Raja",
            "Chico",
            "Luna",
            "Rio",
            "Sasha",
            "Mowgli",
            "Nina",
            "Jungle",
            "Ziggy",
        };

    }


}
