namespace ProjectStructure.Walls
{
    public class Frame
    {
        public Guid Id { get; set; }
        public decimal BoardSectionHeight { get; set; }
        public decimal BoardSectionWidth { get; set; }
        public bool IsCrossInsulation { get; set; }
    }
}