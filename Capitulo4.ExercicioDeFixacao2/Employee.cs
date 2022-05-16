namespace Capitulo4.ExercicioDeFixacao2
{
    internal class Employee
    {
        public string Name { get; protected set; }
        public double GrossSalary { get; protected set; }
        public double Tax { get; protected set; }

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }
        public void IncreaseSalary(double value)
        {
            GrossSalary += (GrossSalary * value) / 100;

        }
        public void ChangeGrossSalary(double value)
        {
            GrossSalary = value;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeTax(double tax)
        {
            Tax = tax;
        }

        public override string ToString()
        {
            return Name + ", $ "
                        + NetSalary().ToString("F2");
        }
    }
}
