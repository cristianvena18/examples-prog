namespace Ejercicio5.Entities
{
    public class Persona
    {
        private string Name;
        private string Surname;
        private double Heigth;
        private int Age;

        public Persona(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string getName()
        {
            return this.Name;
        }

        public Persona setName(string name)
        {
            this.Name = name;
            return this;
        }

        public string getSurname()
        {
            return this.Surname;
        }

        public Persona setSurname(string surname)
        {
            this.Surname = surname;
            return this;
        }


        public double getHeigth()
        {
            return this.Heigth;
        }

        public Persona setHeigth(double heigth)
        {
            this.Heigth = heigth;
            return this;
        }

        public int getAge()
        {
            return this.Age;
        }

        public Persona setAge(int age)
        {
            this.Age = age;
            return this;
        }

        public string Mostrar()
        {
            string serializated = string.Empty;

            serializated += string.Format("Nombre: {0}\nApellido: {1}\n", this.Name, this.Surname);

            if(this.Heigth != 0) {
                serializated += string.Format("Altura: {0}\n", this.Heigth);
            } 

            if(this.Age != 0) {
                serializated += string.Format("Edad: {0}\n", this.Age);
            }

            return serializated;
        }
    }
}