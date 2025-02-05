﻿namespace library_system_dotnet.Models
{
    public class Inventory
    {
        private int id;
        private string name; 
        private string description;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Description
        {
            get => description;
            set => description = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
