using Zenject;

namespace ZenjectDemonstration
{
    // The injection happens in the order:
    // 1. Constructor
    // 2. Fields
    // 3. Properties
    // 4. Methods
    public class InjectionWays
    {
        public InjectionWays(ConstructorDependency constructorDependency)
        {
            
        }

        [Inject]
        private FieldDependency field;
        
        [Inject]
        private PropertyDependency Property { get; set; }

        [Inject]
        private void InjectMethod(MethodDependency methodDependency)
        {
            
        }
    }
}