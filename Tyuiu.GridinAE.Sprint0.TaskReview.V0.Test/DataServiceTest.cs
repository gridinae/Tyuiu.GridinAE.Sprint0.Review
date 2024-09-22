namespace Tyuiu.GridinAE.Sprint0.TaskReview.V0.Test;
using Tyuiu.GridinAE.Sprint0.TaskReview.V0.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckCalc()
    {
        var dataService = new DataService();
        Assert.AreEqual((1+2+3)*5, dataService.Calc(1, 2, 3));
    }
}