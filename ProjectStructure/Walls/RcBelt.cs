namespace ProjectStructure.Walls
{
    public class RcBelt
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        private int width;
        public int Width 
        {
            get { return width; }
            set { width = value; CalculateVolume(); }
        }
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; CalculateVolume(); }
        }
        private int thickness;
        public int Thickness
        {
            get { return thickness; }
            set { thickness = value; CalculateVolume(); }
        }

        

        private int volume;
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private int summaryVolume;
        public int SummaryVolume
        {
            get { return summaryVolume; }
            set { summaryVolume = value; }
        }
        private void CalculateVolume()
        {
            summaryVolume=Quantity*length*thickness*volume;
        }
    }
}