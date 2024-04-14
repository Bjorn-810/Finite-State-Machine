using System.Collections;
using UnityEngine;

/// <summary>
/// StateTwo is the second state in the ExampleSM state machine.
/// It does not implement internal switching logic, relying solely on external input to transition.
/// </summary>
[System.Serializable]
public class StateTwo : BaseState
{
    private readonly ExampleSM _stateMachine;

    /// <summary>
    /// Constructor for StateTwo.
    /// </summary>
    /// <param name="statemachine">The parent state machine.</param>
    public StateTwo(ExampleSM statemachine) : base("StateTwo", statemachine)
    {
        _stateMachine = statemachine;
    }

    /// <summary>
    /// Called when entering StateTwo.
    /// Logs the entry and notes that this state relies on external transitions.
    /// </summary>
    public override void Enter()
    {
        base.Enter();
        Debug.Log("We have successfully entered StateTwo. This state has no internal switch, so the only way you can exit is by pressing G.");
    }

    /// <summary>
    /// Updates the state logic. This state does not handle internal transitions.
    /// </summary>
    public override void BaseStateUpdate()
    {
        // This state implements no switching behavior and thus relies on the state machine's external logic
        // to transition to another state.
    }
}
