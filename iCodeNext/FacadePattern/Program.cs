file class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("Subsystem A operation.");
    }
}
file class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("Subsystem B operation.");
    }
}
file class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("Subsystem C operation.");
    }
}

file class Facade
{
    private readonly SubsystemA subsystemA;
    private readonly SubsystemB subsystemB;
    private readonly SubsystemC subsystemC;
    public Facade()
    {
        subsystemA = new SubsystemA();
        subsystemB = new SubsystemB();
        subsystemC = new SubsystemC();
    }

    public void PerformOperation()
    {
        subsystemA.OperationA();
      
        //
        subsystemB.OperationB();

        //
        subsystemC.OperationC();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Facade Façade = new Facade();
        Façade.PerformOperation();
    }
}