It works really easy so I won't talk much about it:

```c#
static void Main(string[] args)
{
  try
  {
    // Whatever you need to do
  }
  catch (Exception e)
  {
    Exceptions.ExceptionSwitch.Exception(e);
  }
}
```

That's actually all.
