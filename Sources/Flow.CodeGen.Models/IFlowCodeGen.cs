namespace Flow.CodeGen.Models
{
  public interface IFlowCodeGen
  {
    string GenerateFlow(FlowModel flowModel);
    string GenerateNode(NodeModel nodeModel);
    string GenerateNodeImpl(NodeModel nodeModel);
  }
}
