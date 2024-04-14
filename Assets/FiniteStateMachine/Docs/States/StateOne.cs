using System.Collections;
using UnityEngine;

/// <summary>
/// StateOne is the first state in the ExampleSM state machine.
/// It demonstrates internal logic for transitioning to another state after 5 seconds.
/// </summary>
[System.Serializable]
public class StateOne : BaseState
{
    private readonly ExampleSM _stateMachine;

    // Timer-related variables for managing internal state transitions.
    private float _timeToSwitch = 5f; // Time in seconds before switching to StateTwo.
    private float _time;

    /// <summary>
    /// Constructor for StateOne.
    /// </summary>
    /// <param name="statemachine">The parent state machine.</param>
    public StateOne(ExampleSM statemachine) : base("StateOne", statemachine)
    {
        _stateMachine = statemachine;
    }

    /// <summary>
    /// Called when entering StateOne.
    /// Logs the entry and initializes the state.
    /// </summary>
    public override void Enter()
    {
        base.Enter();
        Debug.Log("We have successfully entered StateOne. We will internally switch to StateTwo in 5 seconds. You can always revisit this state by pressing G.");
    }

    /// <summary>
    /// Updates the state logic to handle internal transitions.
    /// </summary>
    public override void BaseStateUpdate()
    {
        // Increment the timer for state switching logic.
        _time += Time.deltaTime;

        // If the timer exceeds the threshold, switch to StateTwo.
        if (_time > _timeToSwitch)
            _stateMachine.ChangeState(_stateMachine.SecondSwitchState);
    }
}
