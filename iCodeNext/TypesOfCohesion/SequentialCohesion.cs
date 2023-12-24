namespace TypesOfCohesion;

file class Payment
{
    public int Id { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
}
file class PaymentsFileProcessor
{
    public void Run(string path)
    {
        try
        {
            List<Payment> payments = new List<Payment>();
            var result = ProcessPayments(payments);
            var frouds = DetectFrouds(result);
            var reports = GenerateSummaryReport(frouds);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing payments file: {ex.Message}");
        }
    }

    private List<Payment> DetectFrouds(List<Payment> payments)
    {
        return payments;
    }

    private List<Payment> ProcessPayments(List<Payment> payments)
    {
        return payments;
    }

    private List<Payment> GenerateSummaryReport(List<Payment> payments)
    {
        return payments;
    }
}
