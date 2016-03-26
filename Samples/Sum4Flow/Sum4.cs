using Flow.CSharp.Core;

// ------------------------------------------------------------------------------
// Auto-generated
// ------------------------------------------------------------------------------
namespace Samples.Sum4Flow
{
	public class Sum4
	{
		#region Nodes
		private readonly Sum InputNode1 = new Sum();
		private readonly Sum InputNode2 = new Sum();
		private readonly Sum ResultNode = new Sum();
		#endregion

		#region Input
		//In
		public Input<System.Int32> InputNode1_Val1 => InputNode1.Val1;
		//In
		public Input<System.Int32> InputNode1_Val2 => InputNode1.Val2;
		//In
		public Input<System.Int32> InputNode2_Val1 => InputNode2.Val1;
		//In
		public Input<System.Int32> InputNode2_Val2 => InputNode2.Val2;
		#endregion
	
		#region Output
		//Out
		public Output<System.Int32> ResultNode_Result => ResultNode.Result;
		#endregion

		public Sum4()
		{
			ResultNode.Val1.SetDependency(InputNode1.Result);
			ResultNode.Val2.SetDependency(InputNode2.Result);
		}

		public void Run ( System.Int32 argInputNode1_Val1, System.Int32 argInputNode1_Val2, System.Int32 argInputNode2_Val1, System.Int32 argInputNode2_Val2 )
		{
			InputNode1.Val1.SetValueDirectly(argInputNode1_Val1);
			InputNode1.Val2.SetValueDirectly(argInputNode1_Val2);
			InputNode2.Val1.SetValueDirectly(argInputNode2_Val1);
			InputNode2.Val2.SetValueDirectly(argInputNode2_Val2);
		}
	}	
}
