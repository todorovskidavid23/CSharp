//ctrl+r+g
namespace StaticRecap
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Age{ get; set; }
        public static int NumberOfDevelopers { get; set; }
        //vrzuvame direktno na taa klasa
        //opsto za clasata developer, specigivno e
        //IDREKTNO ZA DADENATA CLASSA i ne mozat da se pristapat do objektite
        public Developer(string firstName,string lastName,int age)//construtkot sto gi kreira objektite
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            NumberOfDevelopers++;
        }
        public int GetNumberOfDevelopers() 
        {
            return NumberOfDevelopers;
        }

        public static void ResetNumberOfDevelipers()
        {
            NumberOfDevelopers = 0;
        }



    }
}
