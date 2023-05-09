using UnityEngine;

namespace ZenjectDemonstration
{
    public class ApplicationMonoBehaviour : MonoBehaviour
    {
        private void Start()
        {
            var greeter = new Greeter();
            greeter.Greet();
        }
    }
}