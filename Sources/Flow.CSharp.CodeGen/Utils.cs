using System;
using Flow.CodeGen.Models;

namespace Flow.CSharp.CodeGen
{
  public static class Utils
  {
    public static string GetNodePortType(this NodePort nodePort)
    {
      if (!nodePort.PredefinedType.HasValue)
        return nodePort.TypeStr;

      switch (nodePort.PredefinedType.Value)
      {
        case PredefinedType.String:
          return "string";
        case PredefinedType.Integer:
          return "int";
        case PredefinedType.Float:
          return "float";
        case PredefinedType.Boolean:
          return "bool";
      }

      throw new Exception("Undefined NodePortType");
    }
  }
}
