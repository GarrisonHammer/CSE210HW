using System;
using System.Threading;

// Calls from the base class
class Breathing : Base
{
    public Breathing() : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") { }

    // Runs the breathing activity, alternating between breathe in and out
    protected override void Run()
    {
        int elapsed = 10;
        while (elapsed < Duration) // Continue until input is met
        {
            AnimateBreath("Breathe in...", true);  // Animate inhale
            AnimateBreath("Breathe out...", false); // Animate exhale
            elapsed += 3; // Each cycle takes about 3 seconds
        }
    }

    // Animates the breathing effect by gradually expanding and shrinking text
    private void AnimateBreath(string message, bool isInhale)
    {
        Console.Clear(); // Clears console
        Console.WriteLine(message);

        int maxSize = 5; // Maximum text expansion size

        for (int i = 1; i <= maxSize; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine(new string('*', isInhale ? i : maxSize - i)); // Expanding or contracting effect

            // **New dramatic slowdown effect**
            int delay = (int)(500 + 1500 * Math.Pow((double)i / maxSize, 2)); // Speed changes quadratically
            Thread.Sleep(delay); 
        }
    }
}
