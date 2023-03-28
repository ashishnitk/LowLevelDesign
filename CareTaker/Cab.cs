namespace Mediator.RealWorld
{
    interface ICab
    {
        string Name { get; }
        int CurrentLocation { get; }
        bool IsFree { get; }

        void Assign(string name, string address);

    }
    internal class Cab : ICab
    {
        private string _name;
        private int _location;
        private bool _isFree;

        public Cab(string v1, int v2, bool v3)
        {
            this._name = v1;
            this._location = v2;
            this._isFree = v3;
        }

        public string Name => _name;

        public int CurrentLocation => _location;

        public bool IsFree => _isFree;
        public void Assign(string name, string address) => System.Console.WriteLine($"Cab {Name} is assigned to {name}, {address}");

    }
}