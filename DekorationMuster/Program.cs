using System;

namespace DekorationMuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto my_Porsche_911 = new Porsche();

            my_Porsche_911 = new Ledersitze(my_Porsche_911);

             my_Porsche_911 = new Radio(my_Porsche_911);
            my_Porsche_911 = new RoteBel(my_Porsche_911);
            my_Porsche_911 = new AluFelgen(my_Porsche_911);


            Console.WriteLine("Ihre Porsche ist {0} und kostet  {1} Euro", my_Porsche_911.getAustattung(),my_Porsche_911.getPreis());
            Console.WriteLine("---------------------------------------------------------------------------------------");
        
            Auto my_Audi_R8 = new Audi();

            my_Audi_R8 = new Ledersitze(my_Audi_R8);

            my_Audi_R8 = new Radio(my_Audi_R8);
            my_Audi_R8 = new AluFelgen(my_Audi_R8);

            Console.WriteLine("Ihre Audi ist {0} und kostet  {1}  Euro", my_Audi_R8.getAustattung(), my_Audi_R8.getPreis());
            Console.ReadKey();
        }
    }
}
