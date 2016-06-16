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
		public Input<int> Input1 => InputNode1.Val1;
		//In
		public Input<int> Input2 => InputNode1.Val2;
		//In
		public Input<int> Input3 => InputNode2.Val1;
		//In
		public Input<int> Input4 => InputNode2.Val2;
		#endregion
	
		#region Output
		//Out
		public Output<int> Output => ResultNode.Result;
		#endregion

		public Sum4()
		{
			ResultNode.Val1.SetDependency(InputNode1.Result);
			ResultNode.Val2.SetDependency(InputNode2.Result);
		}

		public void Run ( int argInput1, int argInput2, int argInput3, int argInput4 )
		{
			InputNode1.Val1.SetValueDirectly(argInput1);
			InputNode1.Val2.SetValueDirectly(argInput2);
			InputNode2.Val1.SetValueDirectly(argInput3);
			InputNode2.Val2.SetValueDirectly(argInput4);
		}
	}	
}
