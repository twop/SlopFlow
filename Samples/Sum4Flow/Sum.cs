using Flow.CSharp.Core;

// ------------------------------------------------------------------------------
// Auto-generated
// ------------------------------------------------------------------------------
namespace Samples.Sum4Flow
{
	partial class Sum: Node
	{
		#region Input
		//In
		public readonly Input<System.Int32> Val1 = new Input<System.Int32>();
		//In
		public readonly Input<System.Int32> Val2 = new Input<System.Int32>();
		#endregion

		#region Output
		//Out
		public readonly Output<System.Int32> Result = new Output<System.Int32>();
		#endregion

		public Sum()
		{
			AddInput(Val1);
			AddInput(Val2);
		}
	}
}
