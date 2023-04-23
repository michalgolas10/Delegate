namespace DelegatesPresentation;

public class ClassUsingDelegate
{    
    public ClassUsingDelegate()
    {}

    public void DoSomething(SomethingToDo somethingToDo)
    {
        somethingToDo();
    }
}

