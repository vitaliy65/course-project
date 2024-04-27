namespace Курсовая_работа.model
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstLastName { get; set; }
        public string? FilePathimageProfile { get; set; }
        public string gmail { get; set; } = null!;
        public string password { get; set; } = null!;
        public string phone { get; set; } = null!;
        public bool RememberMeFlag { get; set; } = false;

        // Свойства для хранения координат
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string country { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }

        public Customer() { }

        public Customer(string gmail, string password, string phone)
        {
            this.gmail = gmail;
            this.password = password;
            this.phone = phone;
        }
    }
}
