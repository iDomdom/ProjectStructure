namespace ProjectStructure.Walls
{
    public class LogWall
    {
        public Guid Id { get; set; }
        public decimal Diameter { get; set; }
        public string TypeName { get; set; }  // тип бревна
        public string LogTypeName { get; set; }  // тип сруба  
    }
}