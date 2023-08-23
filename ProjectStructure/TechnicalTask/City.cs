namespace ProjectStructure.TechnicalTask
{
    public class City
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }
        public string Region { get; set; }
        public string BigRegion { get; set; }
        public double FreezingDepth { get; set; }
    }
}