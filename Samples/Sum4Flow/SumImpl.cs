using Flow.CSharp;

// ------------------------------------------------------------------------------
// TODO implement your node here. NOTE: please set value to outputs here
// ------------------------------------------------------------------------------
namespace Samples.Sum4Flow
{
	partial class Sum
	{
		protected override void Execute()
		{
			Result.SetValue(Val1.Value + Val2.Value);
		}
	}
}
