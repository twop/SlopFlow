using System.Collections.Generic;

namespace Flow.CodeGen.Models
{
  public class NodeModel
  {
    public string Type { get; set; }
    public string NameSpace { get; set; }
    public readonly List<NodePort> Inputs = new List<NodePort>();
    public readonly List<NodePort> Outputs = new List<NodePort>();

    public NodeModel(string nameSpace, string type)
    {
      NameSpace = nameSpace;
      Type = type;
    }
  }
}
