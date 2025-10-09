using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        const int width = 80;
        const int height = 20;
        const double freq = 0.3;
        const double speed = 0.2;
        const int delay = 40; // kleinere Pause = flüssiger

        var sb = new StringBuilder(width * height + height);

        while (true)
        {
            for (int frame = 0; frame < 360; frame++)
            {
                sb.Clear();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double value = Math.Sin((x * freq) + (frame * speed));
                        int waveY = (int)((value + 1) * (height / 2.0));
                        sb.Append(y == waveY ? '*' : ' ');
                    }
                    sb.AppendLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.Write(sb.ToString());
                Thread.Sleep(delay);
            }
        }
    }
}
