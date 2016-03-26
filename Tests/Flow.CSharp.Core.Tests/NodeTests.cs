using NUnit.Framework;

namespace Flow.CSharp.Core.Tests
{
  [TestFixture]
  public class NodeTests
  {
    //NOTE: Moq framework doesn't allow to call protected methods directly
    //otherwise I would use it instead
    private class PublicNode:Node
    {
      public int ExecutionCount { get; private set; }
      protected override void Execute() => ExecutionCount++;

      public void AddInputPublic(InputBase input)
      {
        AddInput(input);
      }
    }

    [Test]
    public void AddInput_SetValueToInput_CausesExecution()
    {
      var node = new PublicNode();
      var input = new Input<int>();
      node.AddInputPublic(input);

      input.SetValueDirectly(5);

      Assert.AreEqual(1, node.ExecutionCount);
    }

    [Test]
    public void AddInput_TwoInputs_NodeExecutesWithBothInputsOnly()
    {
      var node = new PublicNode();
      var inputInt = new Input<int>();
      var inputBool = new Input<bool>();
      node.AddInputPublic(inputBool);
      node.AddInputPublic(inputInt);

      inputBool.SetValueDirectly(true);
      Assert.AreEqual(0, node.ExecutionCount);

      inputInt.SetValueDirectly(5);
      Assert.AreEqual(1, node.ExecutionCount);
    }

    [Test]
    public void AddInput_TwoInputs_AfterBothInputsWillExecuteOnEverySignal()
    {
      var node = new PublicNode();
      var inputInt = new Input<int>();
      var inputBool = new Input<bool>();
      node.AddInputPublic(inputBool);
      node.AddInputPublic(inputInt);

      inputBool.SetValueDirectly(true);
      inputInt.SetValueDirectly(5);
      Assert.AreEqual(1, node.ExecutionCount);

      inputBool.SetValueDirectly(false);
      Assert.AreEqual(2, node.ExecutionCount);

      inputInt.SetValueDirectly(1);
      Assert.AreEqual(3, node.ExecutionCount);
    }

  }
}
