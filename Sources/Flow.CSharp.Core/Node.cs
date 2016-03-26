using System.Collections.Generic;
using System.Linq;

namespace Flow.CSharp.Core
{
  public abstract class Node
  {
    private readonly Dictionary<InputBase,bool> _inputs = new Dictionary<InputBase, bool>();

    protected void AddInput(InputBase input)
    {
      input.ValueRecieved += OnInputValueRecieved;
      _inputs[input] = false;
    }

    private void OnInputValueRecieved(InputBase firedInput)
    {
      _inputs[firedInput] = true;
      if (_inputs.Values.Any(fired => fired != true))
        return;

      Execute();
    }

    protected abstract void Execute();
  }
}
