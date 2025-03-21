using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Table table = new Table();
            Faker testUsers = new Faker("pt_PT");
            Faker testJobs = new Faker();

            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name"));
            table.AddColumn(new TableColumn("Job"));

            foreach (int i in args[0])
            {
                table.AddRow(i, testUsers, testJobs);
            }
            
            AnsiConsole.Write(table);
        }
    }
}
