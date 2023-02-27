namespace PSolving
{
    public interface IExecutableCode
    {
        protected string Pattern();
        protected string Problem();
        protected void MainBruteForceWay();
        protected void MainByPattern();
        public void Execute()
        {
            Console.WriteLine(Pattern());
            Console.WriteLine(Problem());
            Console.WriteLine("Main Brute Force Way");
            MainBruteForceWay();
            Console.WriteLine("Main By Pattern Way");
            MainByPattern();
        }
    }
}