namespace _2_3_Switch_Oppgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvilken dag er det i dag?");

            int value = 4;

            switch (value)
            {
                case 1:
                    Console.WriteLine("Det er mandag.");
                    break;
                case 2:
                    Console.WriteLine("Det er tirsdag.");
                    break;
                case 3:
                    Console.WriteLine("Det er onsdag.");
                    break;
                case 4:
                    Console.WriteLine("Det er torsdag.");
                    break;
                case 5:
                    Console.WriteLine("Det er fredag.");
                    break;
                case 6:
                    Console.WriteLine("Det er lørdag.");
                    break;
                case 7:
                    Console.WriteLine("Det er søndag.");
                    break;
                default:
                    Console.WriteLine("Ugyldig dag. Du lever i et annet univers.");
                    break;
            }
        }
    }
}
