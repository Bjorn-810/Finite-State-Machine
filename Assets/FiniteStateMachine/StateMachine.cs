public class StateMachine
{
    private BaseState _currentState;

    public StateMachine() { }

    public void StateMachineUpdate()
    {
        if (_currentState != null)
            _currentState.BaseStateUpdate();
    }

    public void StateMachineLateUpdate()
    {
        // Update the statemachine physics
        if (_currentState != null)
            _currentState.BaseStateLateUpdate();
    }

    public void StateMachineFixedUpdate()
    {
        // Update the statemachine physics
        if (_currentState != null)
            _currentState.BaseStateFixedUpdate();
    }

    /// <summary>
    /// Sets the first state of the state machine
    /// </summary>
    /// <param name="initialState"></param>
    public void SetInitialState(BaseState initialState)
    {
        _currentState = initialState;
        initialState.Enter();
    }

    /// <summary>
    /// Sets a new state for the state machine
    /// </summary>
    /// <param name="newState"></param>
    public void ChangeState(BaseState newState)
    {
        if (_currentState != null)
            _currentState.Exit();

        _currentState = newState;
        newState.Enter();
    }
}