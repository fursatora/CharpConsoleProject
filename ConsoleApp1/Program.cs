using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*bool b=true;
        byte bt = 0;
        //short s =1;
        int i=0;
        float f=0f;*/

        Console.WriteLine($"byte {sizeof(byte)} min:{byte.MinValue} max: {byte.MaxValue} ");
        Console.WriteLine($"short {sizeof(short)} min:{short.MinValue} max: {short.MaxValue}");
        Console.WriteLine($"int {sizeof(int)} min:{int.MinValue} max: {int.MaxValue}");

        /*char c='e';
        string s ="abcd";
        s=s.Insert(0, "f");

         Console.WriteLine($"{s}");*/


         /*long l=int.MaxValue;
         //l=i;
         i=(int)l;

         object o=0;

         Console.WriteLine($"{i}");
         Func (0f);
         Func ("dhhhh");
         Func (163);

         //GC.Collect();*/

        int i =0;
        object o=i;
        object o1=i;
        
        Func (out o);
        Console.WriteLine(o1);

        


    }
     public static void Func( out object  o)
     {
           o=5;
     }

}