namespace ProjectStructure.Walls
{
    public class TimberWall
    {
        public Guid Id { get; set; }
        public string TimberType { get; set; }
        public int SectionHeigh { get; set; }
        public int SectionWidth { get; set; }
        public string LogTypeName { get; set; }  // тип сруба 
    }
}