using PSolving;
using PSolving.SlidingWindowProblems;
using System.Reflection;

var instances = Assembly.GetExecutingAssembly().GetTypes()
    .Where(t => t.GetInterfaces().Contains(typeof(IExecutableCode))
                && t.GetConstructor(new Type[0]) != null)
    .Select(t => (IExecutableCode)Activator.CreateInstance(t));

foreach (var instance in instances)
{
    instance.Execute();
}
