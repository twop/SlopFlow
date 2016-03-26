using System.Collections.Generic;
using Flow.CodeGen.Models;

namespace Flow.CSharp.CodeGen
{
  public class FlowCSharpCodeGen: IFlowCodeGen
  {
    public string GenerateFlow(FlowModel flowModel)
    {
      var template = new FlowTemplate() { Session = new Dictionary<string, object> { { "model", flowModel } } };
      template.Initialize();

      return template.TransformText();
    }

    public string GenerateNode(NodeModel nodeModel)
    {
      var template = new NodeTemplate() { Session = new Dictionary<string, object> { { "model", nodeModel } } };
      template.Initialize();

      return template.TransformText();
    }

    public string GenerateNodeImpl(NodeModel nodeModel)
    {
      var template = new NodeImplTemplate() { Session = new Dictionary<string, object> { { "model", nodeModel } } };
      template.Initialize();

      return template.TransformText();
    }
  }
}
