using PSolving;
using PSolving.SlidingWindowProblems;
using System.Reflection;
using System.Threading.Channels;

var digits=new int[] { 1, 2, 3, 5, 8, 13, 21, 34 };
int[] res = new int[8];
Solve(0,0);
void Solve(int pos,int cn)
{
    if (pos==digits.Length)
    {
        if (cn==6)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write(res[i]);
            }
            Console.WriteLine(); 
        }
    }
    else
    {
        res[cn] = digits[pos];
        // pick
       Solve(pos+1, cn+1);
       // leave
       Solve(pos+1, cn);
    }
}


//var instances = Assembly.GetExecutingAssembly().GetTypes()
//    .Where(t => t.GetInterfaces().Contains(typeof(IExecutableCode))
//                && t.GetConstructor(new Type[0]) != null)
//    .Select(t => (IExecutableCode)Activator.CreateInstance(t));

//foreach (var instance in instances)
//{
//    instance.Execute();
//}
