using Flow.CodeGen.Models;

namespace Flow.PlayGround
{
  public class Assets
  {
    public NodeModel Sum { get; }

    public FlowModel Sum4 { get; }

    public Assets(string nameSpace)
    {
      const string sumNodeType = nameof(Sum);
      Sum = new NodeModel(nameSpace, sumNodeType);

      const string val1 = "Val1";
      const string val2 = "Val2";
      const string result = "Result";

      NodePort nodePortInput1 = NodePort.Create<int>(val1);
      NodePort nodePortInput2 = NodePort.Create<int>(val2);
      NodePort nodePortResult = NodePort.Create<int>(result);

      Sum.Inputs.Add(nodePortInput1);
      Sum.Inputs.Add(nodePortInput2);
      Sum.Outputs.Add(nodePortResult);


      const string inputNode1 = "InputNode1";
      const string inputNode2 = "InputNode2";
      const string resulNode = "ResultNode";

      Sum4 = new FlowModel(nameof(Sum4), nameSpace);

      Sum4.FlowNodes.Add(new FlowNode(sumNodeType, inputNode1));
      Sum4.FlowNodes.Add(new FlowNode(sumNodeType, inputNode2));
      Sum4.FlowNodes.Add(new FlowNode(sumNodeType, resulNode));

      Sum4.NodeConnectors.Add(new NodeConnector(inputNode1, result, resulNode, val1));
      Sum4.NodeConnectors.Add(new NodeConnector(inputNode2, result, resulNode, val2));

      Sum4.Inputs.Add(new FlowPort(nodePortInput1, inputNode1));
      Sum4.Inputs.Add(new FlowPort(nodePortInput2, inputNode1));
      Sum4.Inputs.Add(new FlowPort(nodePortInput1, inputNode2));
      Sum4.Inputs.Add(new FlowPort(nodePortInput2, inputNode2));

      Sum4.Outputs.Add(new FlowPort(nodePortResult, resulNode));
    }
  }
}
