namespace SearchPath.Classes
{
    public class Place(string name, int importance, double time)
    {
        public string Name { get; set; } = name;
        public int Importance { get; set; } = importance;
        public double Time { get; set; } = time;
    }
}