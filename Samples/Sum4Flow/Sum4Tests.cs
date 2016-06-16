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

      Assert.AreEqual(4, sum4.Output.Value);
    }

    [Test]
    public void Run_TriggersOutputEvent()
    {
      var sum4 = new Sum4();
      int eventValue = 0;
      sum4.Output.Complete += (v) => eventValue = v;

      sum4.Run(1, 1, 1, 1);

      Assert.AreEqual(4, eventValue);
    }


    [Test]
    public void SetValueToAll4Inputs_SetsValueToOutput()
    {
      var sum4 = new Sum4();
      sum4.Input1.SetValueDirectly(1);
      sum4.Input2.SetValueDirectly(1);
      sum4.Input3.SetValueDirectly(1);
      sum4.Input4.SetValueDirectly(1);

      Assert.AreEqual(4, sum4.Output.Value);
    }
  }
}
