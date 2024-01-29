class ProgramVehicle
{
    public static void Main(string[] args)
    {
        Boeing747 boeing747 = new Boeing747();
        HarleyDavidson harleyDavidson = new HarleyDavidson();
        MercedesBenz mercedesBenz = new MercedesBenz();

        Console.WriteLine(boeing747.GetDepartText());
        Console.WriteLine(harleyDavidson.GetDepartText());
        Console.WriteLine(mercedesBenz.GetDepartText());
    }
}