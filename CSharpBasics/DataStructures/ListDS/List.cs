namespace ListDS
{
    public partial class List<Type>
    {
        private int _count;
        public int Count { get{return _count;}}
        private int _capacity;
        public int Capacity { get{return _capacity;}}
        private Type[] _array;
        public Type this[int i] { get{return _array[i];} set{_array[i]=value;} }

        public List()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }

        public List(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }

        public void Add(Type data)
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

        public void AddRange(List<Type>list)
        {
            _capacity=_count+list.Count;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=0;i<list.Count;i++)
            {
                temp[i+_count]=list._array[i];
            }
            _array=temp;
            _count+=list.Count;
        }

        public void Insert(int position,Type data)
        {
            _capacity*=2;
            _count++;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                if(i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=data;
                }
                else
                {
                    temp[i]=_array[i-1];
                }

            }
            _array=temp;
        }
    }
}