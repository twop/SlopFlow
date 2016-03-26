namespace Flow.CodeGen.Models
{
  public class FlowNode
  {
    public string Name { get; }
    public string NodeType { get;}

    public FlowNode(string nodeType, string name)
    {
      NodeType = nodeType;
      Name = name;
    }
  }
}