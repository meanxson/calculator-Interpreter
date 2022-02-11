namespace CalculatorInterpretator.Controller
{
    public interface IController
    {
        public string UserInput { get; set; }
        public string UserOutput { get; set; }
        
        void Execute();

        double Calculate(string input);
    }
}