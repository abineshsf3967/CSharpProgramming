namespace TestProject;
[TestFixture]
public class Tests
{
    Maths operation=null;
    
    [SetUp]
    public void Setup()
    {
        operation=new Maths();
    }

    [Test]
    public void Test1()
    {
       int result= operation.Add(10,11);
        Assert.That(result,Is.EqualTo(21));
    }
    [TestCase(10,20,30)]
    [TestCase(5,5,10)]
    public void IsAdditionOK(int value1,int value2,int result)
    {
        int output=operation.Add(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase(1.2,2.5,3.7)]
    [TestCase(10.5,20.5,31.0)]
    public void IsAdditionOK(double value1,double value2,double result)
    {
        double output=operation.Add(value1,value2);
        Assert.AreEqual(output,result);

    }
    [TestCase("Ravi","Chandran","RaviChandran")]
    [TestCase("Abinesh","palanisamy","Abineshpalanisamy")]
    public void IsAdditionOK(string value1,string value2,string result)
    {
        string output=operation.Add(value1,value2);
        Assert.AreEqual(output,result);
    }

}