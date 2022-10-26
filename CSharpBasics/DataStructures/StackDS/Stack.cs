namespace StackDS
{
    public class Stack<Type>
    {
        private int _count;
        public int Count { get{return _count;}} 
        private int _capacity;
        private Type[] _array;

        public Stack()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Push(Type data)
        { 
            if(_count==_capacity)
            {
            GrowSize();
            }
            _array[_count]=data;
             _count++;
            
        }

        public void GrowSize()
        {
                _capacity*=2;
                Type[] temp=new Type[_capacity];
               for(int i=0;i<_count;i++)
                {
                    temp[i]=_array[i];
                }
                _array=temp;
        }

        public Type Peek()
        {
            Type temp=default(Type);
            int top=_count;
            if(_count>0)
            {
                temp=_array[--top];
                return temp;
            }
            else
            {
                System.Console.WriteLine("Stack is empty");
                return temp;
            }

        }

        public Type Pop()
        {
             Type temp=default(Type);
            if(_count>0)
            {
                temp=_array[_count];
                _count--;
                return temp;
            }
            else
            {
                System.Console.WriteLine("Stack is empty");
                return temp;
            }
        }

        public bool Contains(Type data)
        {
            int flag=0;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    flag=0;
                    return true;
                }
                else
                {
                    flag=1;
                }
            }
            if(flag==1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}