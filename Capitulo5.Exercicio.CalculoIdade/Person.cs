using System;


namespace Capitulo5.Exercicio.CalculoIdade
{
    public class Person
    {
        private int yearofbirth;

        public int YearOfBirth
        {
            get { return this.yearofbirth; }
            set { this.yearofbirth = value; }
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value.ToUpper(); }
        }

        private int age;
        public int Age
        {
            get
            {
                this.CalcAge();
                return this.age;
            }

        }


        public void PrintDate()
        {
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine("Idade: " + this.Age);
            Console.WriteLine("Ano de nascimento: " + this.YearOfBirth);
        }

        private void CalcAge()
        {
            DateTime currentDate = DateTime.Now;
            this.age = currentDate.Year - this.YearOfBirth;
        }
    }
}
