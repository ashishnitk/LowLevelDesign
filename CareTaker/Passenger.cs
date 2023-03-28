namespace Mediator.RealWorld
{
    interface IPasseger
    {
        string Name { get; }
        string Address { get; }
        int Location { get; }
        void Acknowlged(string name);
    }

    internal class Passenger : IPasseger
    {
        private string v1;
        private string v2;
        private int v3;

        public Passenger(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string Name => v1;

        public string Address => v2;

        public int Location => v3;

        public void Acknowlged(string name)
        {
            System.Console.WriteLine($"Passenger{Name}, Cab {name}");
        }
    }
}