using System;

namespace Flow.CSharp.Core
{
  public abstract class InputBase
  {
    public event Action<InputBase> ValueRecieved;

    protected void InvokeValueRecieved()
    {
      ValueRecieved?.Invoke(this);
    }
  }

  public class Input<T> : InputBase
  {
    public T Value { get; private set; }

    public void SetValueDirectly (T value)
    {
      Value = value;
      InvokeValueRecieved();
    }

    public void SetDependency(Output<T> output )
    {
      output.Complete += ValueRecievedFromOutuput;
    }

    private void ValueRecievedFromOutuput(T value)
    {
      Value = value;
      InvokeValueRecieved();
    }
  }
}
