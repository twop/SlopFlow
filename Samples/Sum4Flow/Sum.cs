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
		public readonly Input<int> Val1 = new Input<int>();
		//In
		public readonly Input<int> Val2 = new Input<int>();
		#endregion

		#region Output
		//Out
		public readonly Output<int> Result = new Output<int>();
		#endregion

		public Sum()
		{
			AddInput(Val1);
			AddInput(Val2);
		}
	}
}
