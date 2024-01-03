namespace Dyrehage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var savanne = new Savannen();
            savanne.GenerateAnimal(10);

            var jæren = new Jæren();
            jæren.GenerateAnimal(10);

            var jungel = new Jungelen();
            jungel.GenerateAnimal(10);

            var zoo = new Zoo();
            zoo.AddAnimalToZoo(jungel.DyrIJungelen[5]);
            zoo.ShowZooList();
        }
    }
}
