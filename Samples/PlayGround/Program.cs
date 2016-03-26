using Flow.CodeGen.Models;
using Flow.CSharp.CodeGen;
using Flow.PlayGround;
using Newtonsoft.Json;

namespace PlayGround
{
  class Program
  {
    static void Main(string[] args)
    {
      var assets = new Assets("Samples.Sum4Flow");
      var csharpGen = new FlowCSharpCodeGen();

      string flow = csharpGen.GenerateFlow(assets.Sum4);
      string node = csharpGen.GenerateNode(assets.Sum);
      string nodeImpl = csharpGen.GenerateNodeImpl(assets.Sum);

      var workingFolder = @"..\..\..\Sum4Flow\";
      System.IO.File.WriteAllText($"{workingFolder}{assets.Sum4.FlowName}.cs", flow);
      System.IO.File.WriteAllText($"{workingFolder}{assets.Sum.Type}.cs", node);

      string implFullPath = $"{workingFolder}{assets.Sum.Type}Impl.cs";

      if (!System.IO.File.Exists(implFullPath))
      {
        System.IO.File.WriteAllText(implFullPath, nodeImpl);
      }

      var json = JsonConvert.SerializeObject(assets.Sum);
      var deserializedModel = JsonConvert.DeserializeObject<NodeModel>(json);
    }
  }
}
