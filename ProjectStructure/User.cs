namespace ProjectStructure
{
    public class User
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public DateTime SubsDate { get; set; }
    }
}