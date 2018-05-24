using System;

namespace LightDemo
{
    class Program
    {
        LightAndState[] state1 = { new LightAndState(new Light(1), LightState.GREEN), new LightAndState(new Light(2), LightState.RED) };
        LightAndState[] state2 = { new LightAndState(new Light(1), LightState.AMBER), new LightAndState(new Light(2), LightState.RED) };
        LightAndState[] state3 = { new LightAndState(new Light(1), LightState.RED), new LightAndState(new Light(2), LightState.GREEN) };
        static void Main(string[] args)
        {
            new Program().Run();   
        }
        public void Run()
        {
            Console.WriteLine("State 1 -----");
            DoChanges(state1);
            Console.WriteLine("-------------\n\n");
            Console.WriteLine("State 2 -----");
            DoChanges(state2);
            Console.WriteLine("-------------\n\n");
            Console.WriteLine("State 3 -----");
            DoChanges(state3);
            Console.WriteLine("-------------\n\n");

            Console.Read();
        }

        public void DoChanges(LightAndState[] states)
        {
            foreach (LightAndState lightAndState in states)
            {
                Console.WriteLine("Changing light " + lightAndState.Light.LightId + " to " + lightAndState.State);
            }
        }
    }
}
