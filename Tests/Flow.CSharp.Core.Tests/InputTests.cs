using NUnit.Framework;

namespace Flow.CSharp.Core.Tests
{
  [TestFixture]
  public class InputTests
  {
    [Test]
    public void SetValueDirectlye_FiresEventWithThis()
    {
      Input<int> input = new Input<int>();
      InputBase recievedInput = null;
      input.ValueRecieved += (v) => recievedInput = v;

      input.SetValueDirectly(5);

      Assert.AreEqual(5, input.Value);
      Assert.AreSame(input, recievedInput);
    }

    [Test]
    public void SetDependency_SetOutputValue_FiresEventAndSetsValue()
    {
      Output<int> output = new Output<int>();
      Input<int> input = new Input<int>();
      input.SetDependency(output);
      
      bool eventFired = false;
      input.ValueRecieved += (v) => eventFired = true;

      output.SetValue(5);

      Assert.AreEqual(5, input.Value);
      Assert.True(eventFired);
    }
  }
}
