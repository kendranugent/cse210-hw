static class Animation
        //special animation for each activity
    {
        public static void BreathAnim(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("..");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("...");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("..");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write(".");
                Thread.Sleep(200);
                Console.Clear();
            }
        }

        public static void ReflectAnim(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("-");
                Thread.Sleep(250);
                Console.Clear();
                Console.Write("--");
                Thread.Sleep(250);
                Console.Clear();
                Console.Write("---");
                Thread.Sleep(250);
                Console.Clear();
                Console.Write("----");
                Thread.Sleep(250);
                Console.Clear();
                Console.Write("-----");
                Thread.Sleep(250);
                Console.Clear();
            }
        }
    }
