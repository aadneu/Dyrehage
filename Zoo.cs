

namespace Dyrehage
{
    internal class Zoo
    {
        List<Dyr> InnsatteDyr = new List<Dyr>();

        public void ShowZooList()
        {
            foreach (var animal in InnsatteDyr)
            {
                animal.ShowAnimal();
            }
        }

       public void AddAnimalToZoo(Dyr dyr)
        {
            InnsatteDyr.Add(dyr);
        }
        
    }
}
