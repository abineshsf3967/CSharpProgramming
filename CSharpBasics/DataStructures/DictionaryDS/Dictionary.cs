namespace DictionaryDS
{
    public partial class Dictionary<TypeKey,TypeValue>
    {
        private int _count;
        public int Count { get{return _count;} }
        private int _capacity;
        public int Capacity { get{return _capacity;}}
        private KeyValuePair<TypeKey,TypeValue>[] _array;
        
        public TypeValue this[TypeKey key]
        {
            get
            {
                TypeValue value=default(TypeValue);
                if(IsKeyPresent(key,out value))
                {
                    return value;
                }
                else
                {
                    return value;
                }
            }
            set
            {
                int position=KeyPosition(key);
                if(position>=0)
                {
                    _array[position].Value=value;
                }
            }
        }

        public Dictionary()
        {
            _count=0;
            _capacity=4;
            _array=new KeyValuePair<TypeKey,TypeValue>[_capacity];
        }

        public Dictionary(int size)
        {
            _count=0;
            _capacity=size;
            _array=new KeyValuePair<TypeKey,TypeValue>[_capacity];
        }

        public void Add(TypeKey key,TypeValue value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            KeyValuePair<TypeKey,TypeValue> data=new KeyValuePair<TypeKey, TypeValue>();
            if(!IsKeyPresent(key,out TypeValue value1))
            {
                data.Key=key;
                data.Value=value;
                _array[_count]=data;
                _count++;
            }
            else
            {
                System.Console.WriteLine("case already present");
            }
        }

        public void GrowSize()
        {
            _capacity*=2;
            KeyValuePair<TypeKey,TypeValue>[] temp=new KeyValuePair<TypeKey, TypeValue>[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        public bool IsKeyPresent(TypeKey key,out TypeValue value)
        {
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {
                    value=_array[i].Value;
                    return true;
                }
            }
            value=default(TypeValue);
            return false;
        }
         public bool ContainsKey(TypeKey key)
        {
           return IsKeyPresent(key,out TypeValue value);
        }
         public bool ContainsValue(TypeValue value)
        {
            bool flag=false;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Value.Equals(value))
                {
                    return true;
                }
            }
            return flag;
        }

    }
}