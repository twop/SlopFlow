namespace Flow.CodeGen.Models
{
  public class NodePort
  {
    public string Name { get; set; }
    public string Type { get; set; }

    public NodePort(string name, string type)
    {
      Name = name;
      Type = type;
    }

    public static NodePort Create<T>(string name) => new NodePort(name, typeof (T).FullName);

    public override string ToString()
    {
      return $"{Name}: {Type}";
    }
  }
}