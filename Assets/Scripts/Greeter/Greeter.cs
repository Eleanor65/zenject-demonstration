using UnityEngine;

namespace ZenjectDemonstration
{
    public class Greeter : IGreeter
    {
        public void Greet()
        {
            Debug.Log("Hello World!");
        }
    }
}