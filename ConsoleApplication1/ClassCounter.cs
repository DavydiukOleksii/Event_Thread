namespace ConsoleApplication1
{
    public class ClassCounter
    {
        public delegate void MethodForHandler();

        public event MethodForHandler onCount;

        public void Counter()
        {
            for (int i = 1; i < 20; i++)
            {
                if (i%2 != 0)
                {
                    if (onCount != null)
                    {
                        onCount();
                    }
                }
            }
        }
    }
}
