using System.Collections.Generic;
using System.Linq;

namespace Flow.CodeGen.Models
{
  public class FlowModel
  {
    public string FlowName { get; set; }
    public string NameSpace { get; set; }

    public List<FlowNode> FlowNodes = new List<FlowNode>();

    public List<NodeConnector> NodeConnectors = new List<NodeConnector>();

    public List<FlowPort> Inputs = new List<FlowPort>();
    public List<FlowPort> Outputs = new List<FlowPort>();

    public FlowModel(string flowName, string nameSpace)
    {
      FlowName = flowName;
      NameSpace = nameSpace;
    }
  }
}
