using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5.Exercicio.QuantidadeDePets
{
    public class Animal
    {
        private string _name;

        public string Name
        {
            get { return this._name; }
            set { this._name = value.ToUpper(); }
        }

        private string _animalType;

        public string AnimalType
        {
            get { return this._animalType; }
            set
            {
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                    this._animalType = value;
                else
                    this._animalType = "Peixe";
            }
        }



    }
}
