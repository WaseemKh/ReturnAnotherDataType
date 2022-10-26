
//Console.WriteLine("Start !");

var pro = new Program2();
var secondClass = new SecondClass();

var x = pro.doSomthing(secondClass);
Console.WriteLine(x);
//Console.WriteLine(x.Name);




/*How we can return data type differant in method return type 
 *  class B has method return A data type howeaver  in actual it's return B type how do it
 *  1- by inhertance  B inhert from A we can retun 
 *  
 *  
 */
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