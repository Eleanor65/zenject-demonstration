using System;
using Zenject;

namespace ZenjectDemonstration
{
    public class ZenjectInterfaces : IInitializable, ITickable, ILateTickable, IDisposable
    {
        // Is called on Context Initialisation
        public void Initialize()
        {
            
        }
        
        // Is called every frame (during Update)
        public void Tick()
        {
            
        }

        // Is called every frame (during LateUpdate)
        public void LateTick()
        {
            
        }

        // Is called on Context Disposal
        public void Dispose()
        {
            
        }
    }
}