namespace MyTests.Run
{
    using System.Linq;
    
    class StartUp
    {
        static void Main()
        {
            var assemblies = AssemblyLoader.Load().SelectMany(a => a.GetTypes());
                

            
        }
    }
}
