namespace library_system_dotnet.Models
{
    public class Product
    {
        public string id;
        public string name;
        public string description;
        public int quantity;
        public double price;

        public string Id
        {
            get => id;
            set => id = value ?? throw new ArgumentNullException(nameof(value));
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

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
