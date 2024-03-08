
namespace TestForTopic6;

[TestClass]
public class UnitTestForTopic6
{
    /* 
        Здесь сделал название методов в виде метаморфозы Snake & Pascal case
        Потому что так проще понять что там написано в терминале..
    */

    [DataTestMethod]
    [DataRow("texttext", -1, 0)]
    [DataRow("text{fiftext", -1, 0)]
    [DataRow("text{{{{{fiftext", -1, 0)]
    [DataRow("t}ext}fift}ext}}}", -1, 0)]
    [DataRow("}}}}}}}", -1, 0)]
    [DataRow("{{{{{", -1, 0)]
    public void Test_Method_Answer_Not_Found(string inputStr, int answerStartStr, int answerLenStr)
    {
        int startStr;
        int lenStr;
        Assert.IsFalse(HW6_3.Program.FindStaples(inputStr, out startStr, out lenStr));
        Assert.AreEqual(answerStartStr, startStr);
        Assert.AreEqual(answerLenStr, lenStr);
    }

    [DataTestMethod]
    [DataRow("program{find}", 7, 6)]
    [DataRow("{fi}texttext", 0, 4)]
    [DataRow("text{fif}text", 4, 5)]
    [DataRow("text{dd{dd{fif}dd}dd}text", 4, 17)]
    [DataRow("{{{fif}dd}dd}text", 0, 13)]
    [DataRow("{dddddddddddd{{d}dd}dd}", 0, 23)]
    [DataRow("{  {{  } }    }", 0, 15)]
    public void Test_Method_Answer_Found(string inputStr, int answerStartStr, int answerLenStr)
    {
        int startStr;
        int lenStr;
        Assert.IsTrue(HW6_3.Program.FindStaples(inputStr, out startStr, out lenStr));
        Assert.AreEqual(answerStartStr, startStr);
        Assert.AreEqual(answerLenStr, lenStr);
    }
}