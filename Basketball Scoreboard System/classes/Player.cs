namespace Basketball_Scoreboard_System.classes
{
    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Assists { get; set; }
        public int Blocks { get; set; }
        public int Steals { get; set; }
        public int Turnovers { get; set; }
        public int TotalShots { get; set; }
        public int ShotsMade { get; set; }

        public Player(int Number, string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}