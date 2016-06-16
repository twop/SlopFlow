namespace Flow.CodeGen.Models
{
  public class NodePort
  {
    public string Name { get; set; }
    public string TypeStr { get; set; }
    public PredefinedType? PredefinedType { get; set; }

    public static NodePort Create(string name, PredefinedType type) => new NodePort() {Name = name, PredefinedType = type};
    public static NodePort Create(string name, string typeStr) => new NodePort() { Name = name, TypeStr = typeStr};

    public override string ToString()
    {
      return $"{Name}: {TypeStr}";
    }
  }
}