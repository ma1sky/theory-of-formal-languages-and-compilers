using lab_1.Functions;

public class LogFunction: IFunction
{
    public double execute(double primaryOperand, double secondaryOperand)
    {
        
        return Math.Log(primaryOperand + secondaryOperand);
    }
}