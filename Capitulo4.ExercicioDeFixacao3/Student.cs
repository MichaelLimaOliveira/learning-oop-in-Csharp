namespace Capitulo4.ExercicioDeFixacao3
{
    internal class Student
    {
        public string Name { get; protected set; }
        public double FirstTrimester { get; protected set; }
        public double SecondTrimester { get; protected set; }
        public double ThirdTrimester { get; protected set; }

        public double FinalGrade()
        {
            return FirstTrimester + SecondTrimester + ThirdTrimester;
        }

        public void Result()
        {
            if (FinalGrade() > 60.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                double missed = 60.0 - FinalGrade();
                Console.WriteLine($"Faltaram {missed:F2} Pontos");
            }
        }

        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeFirstTrimester(double value)
        {
            FirstTrimester = value;
        }
        public void ChangeSecondTrimester(double value)
        {
            SecondTrimester = value;
        }
        public void ChangeThirdTrimester(double value)
        {
            ThirdTrimester = value;
        }
    }
}
