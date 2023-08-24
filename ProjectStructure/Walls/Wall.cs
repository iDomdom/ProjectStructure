using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.Walls
{
    public class Wall
    {
        public Guid Id { get; set; }
        public string Purpose { get; set; }
        public Frame? Frame { get; set; }
        public Stone? Stone { get; set; }
        public LogWall? LogWall { get; set; }
        public TimberWall? TimberWall { get; set; }
    }
}
