namespace AllAboutClasses
{
    public class Country
    {
        public string Name{ get; set; }
        public int Population { get; set; }
        public readonly double AREA = 43443.45;

        public static readonly bool IsOnEarth; 
         //static means that it's common in all the constructor but when you use "const" it's automatically static

       
        //Default constructor
        public Country()
        {
           
        }

        
        // Parameterized constructor
        public Country(string name)
        {
           Name = name;
        }
        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;

        }

        //Static Constructor
        static Country()
        {
            IsOnEarth = true;
        }

        //Finalizer or Destructor
       /* ¬Country()
        {
            Consloe.Writeline("I'm dying...");
        }*/

    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");

        }
    }
}