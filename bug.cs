public class ExampleClass{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value; 
    }

    public void MyMethod()
    {
        // Accessing a null object reference.
        Console.WriteLine(MyProperty.ToString()); 
    }
}