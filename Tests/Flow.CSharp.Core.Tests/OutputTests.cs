using NUnit.Framework;

namespace Flow.CSharp.Core.Tests
{
  [TestFixture]
  public class OutputTests
  {
    [Test]
    public void SetValue_FiresEventWithThis()
    {
      Output<int> output = new Output<int>();
      int recievedValue = 0;
      output.Complete += (v) => recievedValue = v;

      output.SetValue(5);

      Assert.AreEqual(5, output.Value);
      Assert.AreEqual(output.Value, recievedValue);
    }
  }
}
