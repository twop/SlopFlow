namespace Flow.CodeGen.Models
{
  public class NodeConnector
  {
    public string FromNodeName { get; set; }
    public string FromPort { get; set; }

    public string ToNodeName { get; set; }
    public string ToPort { get; set; }

    public NodeConnector(string fromNodeName, string fromPort, string toNodeName, string toPort)
    {
      FromNodeName = fromNodeName;
      FromPort = fromPort;
      ToNodeName = toNodeName;
      ToPort = toPort;
    }
  }
}