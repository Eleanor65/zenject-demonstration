using Zenject;

namespace ZenjectDemonstration
{
    public class InstallerHelloWorld : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Application>().AsSingle().NonLazy();
            Container.Bind<Greeter>().AsSingle();
        }
    }
}