namespace Flow.CodeGen.Models
{
  public class FlowPort
  {
    private readonly string _friendlyName;

    public string NodeName { get; }
    public NodePort NodePort { get; set; }

    public string Name
    {
      get
      {
        if (string.IsNullOrEmpty(_friendlyName))
          return NodeName + "_" + NodePort.Name;

        return _friendlyName;
      }
    }

    public FlowPort(NodePort nodePort, string nodeName, string friendlyName = null)
    {
      NodePort = nodePort;
      NodeName = nodeName;
      _friendlyName = friendlyName;
    }
  }
}