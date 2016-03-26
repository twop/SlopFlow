using System;

namespace Flow.CSharp.Core
{
  public class Output<T>
  {
    public event Action<T> Complete;

    public T Value { get; private set; }

    public void SetValue(T value)
    {
      Value = value;
      FireComplete();
    }

    private void FireComplete()
    {
      Complete?.Invoke(Value);
    }
  }
}