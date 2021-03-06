using System;


namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Class People
            People currentPeople = new People(20, "Igmar Jovan", "Hernández", DateTime.Now);
            Console.WriteLine(currentPeople.ShowProperties());

            // Object Class Doctor
            Doctor currentDoctor = new Doctor(40, "Name Doctor", "ApP Doctor", DateTime.Now, "Nefrolología");

            // Method Public from People to Doctor
            Console.WriteLine(currentDoctor.ShowProperties());

            // Method Protected from People to Doctor
            //Console.WriteLine(currentDoctor);

            // Method public from Doctor
            Console.WriteLine(currentDoctor.GetData());

            Developer dev = new Developer(25, "Igmar", "Hernandez", DateTime.Now, "C#");
            Console.WriteLine(dev.getInfoDeveloper());
            
        }

        class People 
        {
            private int _age;
            private string _name;
            private string _lastName;
            private DateTime _dateOfBirth;

            public People(int age, string name, string lastName, DateTime dateOfBirth) 
            {
                this._age = age;
                this._name = name;
                this._lastName = lastName;
                this._dateOfBirth = dateOfBirth;
            }

            public string ShowProperties()
            {
                return "Hola, mi nombre es " + _lastName + " " + _name + "  nací el  " + _dateOfBirth + " por lo tanto tengo " + _age + " años ";
            }

            protected string ShowSomeProperties() 
            {
                return "Info => " + _name + " " + _lastName + " " + _age; 
            }

            private string ShowOnlyOnePropertie() 
            {
                return "This a propertie " + _name;
            }
        }

        class Developer : People {
            private string _languaje;
            public Developer(int age, string name, string lastName, DateTime dateBirth, string languaje) : base(age, name, lastName, dateBirth) {
                _languaje = languaje;
            }

            public string getInfoDeveloper() {
                return ShowProperties() + " me gusta programar en " + _languaje;
            }
        }

        class Doctor : People 
        {
            private string _Speciality;
            public Doctor(int age, string name, string lastName, DateTime dateOfBirth, string speciality) : base(age, name, lastName, dateOfBirth) {

                // Access to method only oin this class
                //string resultMethod = ShowSomeProperties();
                _Speciality = speciality;
            }

            public string GetData() { 
                return ShowSomeProperties() + " Especiality" + _Speciality;
            }
        }
    }
}
