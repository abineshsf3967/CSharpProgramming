using System;
namespace ListArray
{
    public partial class ArrayList
    {
        private int _count;
        public int Count { get{return _count;}}
        private int _capacity;
        public int Capacity { get{return _capacity;}}
        private dynamic[] _array;
        public dynamic this[int i] { get{return _array[i];} set{_array[i]=value;} }


        public ArrayList()
        {
            _count=0;
            _capacity=4;
            _array=new dynamic[_capacity];
        }

        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new dynamic[_capacity];
        }

        public void Add(dynamic data)
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
            dynamic[] temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        public void AddRange(ArrayList list)
        {
            _capacity=_count+list.Count;
            dynamic[] temp = new dynamic[_capacity];
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

        public void Insert(int position,dynamic data)
        {
            _capacity*=2;
            _count++;
            dynamic[] temp=new dynamic[_capacity];
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
         public void RemoveAT(int position)
         {
            for(int i=position;i<_count;i++)
            {
                _array[i]=_array[i+1];
            }
            _count--;
         }


         public int IndexOf(dynamic data)
         {
            int flag=0;
            int i=0;
            for(i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    flag=0;
                    break;
                }
                else
                {
                    flag=1;
                }
            }
            if(flag==1)
            {
                return 0;
            }
            else
            {
                return i;
            }
         }

         public void Remove(dynamic data)
         {
            int value=IndexOf(data);
            RemoveAT(value);
         }

         public bool Contains(dynamic data)
         {
            int flag=0;
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    flag=0;
                    break;
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

         public void ToArray()
         {
            for(int i=0;i<_count;i++)
            {
               System.Console.WriteLine(_array[i]);
            }
         }
    }
}