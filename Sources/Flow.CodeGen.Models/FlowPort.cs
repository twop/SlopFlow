namespace Flow.CodeGen.Models
{
  public class FlowPort
  {
    public NodePort NodePort { get; set; }
    public string NodeName { get; set; }

    public FlowPort(NodePort nodePort, string nodeName)
    {
      NodePort = nodePort;
      NodeName = nodeName;
    }
  }
}