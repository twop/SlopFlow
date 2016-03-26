using NUnit.Framework;
using Samples.Sum4Flow;

namespace Sum4Flow
{
  [TestFixture]
  public class Sum4Tests
  {
    [Test]
    public void Run_SetsValueToOutput()
    {
      var sum4 = new Sum4();
      sum4.Run(1,1,1,1);

      Assert.AreEqual(4, sum4.ResultNode_Result.Value);
    }

    [Test]
    public void Run_TriggersOutputEvent()
    {
      var sum4 = new Sum4();
      int eventValue = 0;
      sum4.ResultNode_Result.Complete += (v) => eventValue = v;

      sum4.Run(1, 1, 1, 1);

      Assert.AreEqual(4, eventValue);
    }


    [Test]
    public void SetValueToAll4Inputs_SetsValueToOutput()
    {
      var sum4 = new Sum4();
      sum4.InputNode1_Val1.SetValueDirectly(1);
      sum4.InputNode1_Val2.SetValueDirectly(1);
      sum4.InputNode2_Val1.SetValueDirectly(1);
      sum4.InputNode2_Val2.SetValueDirectly(1);

      Assert.AreEqual(4, sum4.ResultNode_Result.Value);
    }
  }
}
