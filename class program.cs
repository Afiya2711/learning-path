using System.Collections.Generic;  
  
public class HashSetExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a set of strings  
        var names = new HashSet<string>();  
        names.Add("mem1");  
        names.Add("mem2");  
        names.Add("mem3");  
        names.Add("mem4");  
        names.Add("mem5");//will not be added  
          
        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  
