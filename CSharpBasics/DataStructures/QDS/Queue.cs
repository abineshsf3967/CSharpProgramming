namespace QDS
{
    public class Queue<Type>
    {
        private int _count;
        public int Count { get{return _count;}}
        private int _head;
        private int _tail;
        private int _capacity;
        private Type[] _array;


        public Queue()
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=4;
            _array=new Type[_capacity];
        }

        public Queue(int size)
        {
            _count=0;
            _tail=0;
            _head=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Enqueue(Type data)
        {
            if(_tail==_capacity)
            {
                GrowSize();
            }
            _array[_tail]=data;
            _tail++;
            _count++;
        }

        public void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=_head;i<_tail;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

         public Type Peek()
        {
            Type temp=default(Type);
            {
                temp=_array[_head];
                return temp;
            }
        }
        public Type Dequeue()
        {
            Type temp=default (Type);
            if(_tail!=_head)
            {
                temp=_array[_head];
                _head++;
                _count--;
                return temp ;
            }
            else
            {
                System.Console.WriteLine("Queue is empty");
                return temp;
            }
        }

        public bool Contains(Type data)
        {
            int flag=0;
            for(int i=_head;i<_tail;i++)
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
                return true ;
            }
        }
       
    }
}