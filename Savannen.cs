

namespace Dyrehage
{
    internal class Savannen : IAnimalConstructor
    {
        public List<VillDyr> DyrISavannen = new List<VillDyr>();

        public void ShowAnimalSavanna()
        {
            foreach (var animal in DyrISavannen)
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
                DyrISavannen.Add(new VillDyr(ReturnType(), ReturnName(), MaleOrFemale(), rand().Next(0, 21)));
            } 
        }
        
        string ReturnType()
        { 
            int length = TypeDyrISavannen.Count;
            var type = TypeDyrISavannen[rand().Next(0,length)];
            return type;
        }

        string ReturnName()
        {
            int length = NavnDyrISavannen.Count;
            var type = NavnDyrISavannen[rand().Next(0, length)];
            return type;
        }

        bool MaleOrFemale()
        {
            int MaleOrFemale = rand().Next(0, 2);
            return MaleOrFemale == 1;
        }

        List<string> TypeDyrISavannen = new List<string>
        {
            "Løve",
            "Elefant",
            "Giraff",
            "Bøffel",
            "Flodhest",
            "Sjiraff",
            "Zebra",
            "Leopard",
            "Gepard",
            "Hyene",
            "Antilope",
            "Nesehorn",
        };
        List<string> NavnDyrISavannen = new List<string>
        {
            "Simba",
            "Nala",
            "Tumbo",
            "Zara",
            "Kito",
            "Sarabi",
            "Jambo",
            "Malaika",
            "Kofi",
            "Zuri",
            "Shani",
            "Kali",
            "Jabari",
            "Safari",
            "Kiara",
            "Bakari",
            "Taji",
            "Imani",
            "Kwame",
            
        };


     
    }
}
