using System.Net.NetworkInformation;

namespace ProjectStructure.Walls
{
    public class Parapet
    {
        public Guid Id { get; set; }
        private int length;
        public int Length 
        {
            get { return length; }
            set { length = value; CalculateVolume(); }
        }
        private int heigh;
        public int Heigh
        {
            get { return heigh; }
            set { heigh = value; CalculateVolume(); }
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
            
            private void CalculateVolume()
        {
            volume = length * heigh * thickness;
        }
    }
}