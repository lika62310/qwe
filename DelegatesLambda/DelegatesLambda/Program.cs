namespace DelegatesLambda
{
    internal class Program
    {

        public delegate void ActDel(int num);
        public delegate void FuncDel();
        public delegate void PredDel();


        double Calculate(string expression);
        int CompareTo(int other);
        int Factorial(int n);
        void Delete(int index)
        {

        }
        bool Exist(int id);
        string GetUserChoice();
        int Fibonacci(int n);
        void NotifySubscribers(string message);
        string GetAllPets();
        bool IsMatchesFinished();
        void ShowScore(string tournamentName);
        bool Contains(int id);

        static void Main(string[] args)
        {
            ActDel actionDel = Delete;

        }
    }
}
