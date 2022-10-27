namespace DictionaryDS
{
    public partial class Dictionary<TypeKey,TypeValue>
    {
        public int KeyPosition(TypeKey key)
        {
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Key.Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
    } 
}