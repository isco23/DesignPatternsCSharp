using Newtonsoft.Json;

namespace ProtoTypeDemo
{
    public abstract class CloneablePrototype<T>
    {
        // Shallow Copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
        // Deep Copy

        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
        
    }    
}
