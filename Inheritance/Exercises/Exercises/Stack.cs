namespace Exercises
{
    public class Stack
    {
        public int stackSize { get { return stack.Count; } }

        List<object> stack { get; set; }

        public Stack() : this(0)
        {

        }

        public Stack(int stackSize)
        {
            this.stack = new List<object>(stackSize);
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("The object is null, cannot be added.");
            }
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            var lastObject = stack[stack.Count - 1];
            stack.Remove(lastObject);
            return lastObject;
        }

        public void Clear()
        {
            while (stack.Count > 0)
            {
                stack.RemoveAt(0);
            }
        }
    }
}