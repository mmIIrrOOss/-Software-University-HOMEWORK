﻿namespace _06.Food_Shortage
{
    public class Pet : IBIrthdate
    {
        private string name;
        private string birthdate;
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Name { get => this.name; private set => this.name = value; }
        public string Birthdate { get => this.birthdate; private set => this.birthdate = value; }
    }
}
