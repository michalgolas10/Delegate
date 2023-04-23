namespace DelegatesPresentation;

public class ClassUsingDelegate
{    
    public ClassUsingDelegate()
    {}

    public void DoSomething(Action somethingToDo)
    {
        somethingToDo();
    }
}

