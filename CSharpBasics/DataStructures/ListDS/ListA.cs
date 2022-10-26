namespace ListDS
{
    public partial class List<Type>
    {
        public void RemoveAT(int position)
        {
            for(int i=position;i<_count;i++)
            {
                _array[i]=_array[i+1];
            }
            _count--;
        }

         public int IndexOf(Type data)
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
          public void Remove(Type data)
         {
            int value=IndexOf(data);
            RemoveAT(value);
         }

         public bool Contains(Type data)
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