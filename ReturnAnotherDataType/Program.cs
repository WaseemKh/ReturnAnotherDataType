
//Console.WriteLine("Start !");

var pro = new Program2();
var secondClass = new SecondClass();

var x = pro.doSomthing(secondClass);
//Console.WriteLine(x.Name); error you must cat to SecondClass Class
// Console.WriteLine(x.Id);
var Y = (SecondClass)x;
Console.WriteLine(Y.Name);
Console.WriteLine(x.Id);





/*How we can return data type differant in method return type 
 * 
 * class B has method return A data type however in actual it's return B type how do it 
 */

//1 - by inheritance B inherit from A we can retun  


public class Program2
{
  
    public FirstClass doSomthing(SecondClass B)
    {
        B.Name = "Waseem";
        B.Id = 10;
        return B;
    }
}
public  class FirstClass
{
    public  int Id { get; set; }

}
public  class SecondClass:FirstClass
{
    public string Name { get; set; }
}



//2-implicit Operator
public class FirstClass2
{
    private readonly SecondClass2 _SecondClass2;
    public FirstClass2(SecondClass2 secondClass2)
    {
        _SecondClass2 = secondClass2;
    }

    public static implicit operator FirstClass2(SecondClass2 B)
    {
        B.Name = "Waseem";
        return new FirstClass2(B);
    }
    public int Id { get; set; }

}
public class SecondClass2 
{
    public string Name { get; set; }
}


