namespace ProjectStructure.Walls
{
    public class Stone
    {
        public Guid Id { get; set; }
        public string StoneType { get; set; }
        public decimal Thickness { get; set; }
        public decimal InsulationThickness { get; set; }
        public string JumperTechnology { get; set; }
        public bool IsRcFrame { get; set; }  //есть ЖБ каркас?
        public bool IsRcStaircase { get; set; }  //есть ЖБ лестница?
        public Parapet? Parapet { get; set; }
        public RcBelt? RcBelt { get; set; }   // монолитный ЖБ пояс. Только если это внешние или внутр несущие стены. Если нет ЖБ каркаса
    }
}