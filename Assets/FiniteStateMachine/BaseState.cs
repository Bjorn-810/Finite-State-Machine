public class BaseState
{
    public string name;

    protected StateMachine stateMachine;

    public BaseState(string name, StateMachine stateMachine)
    {
        this.name = name;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void BaseStateUpdate() { }
    public virtual void BaseStateFixedUpdate() { }
    public virtual void BaseStateLateUpdate() { }
    public virtual void Exit() { }
}