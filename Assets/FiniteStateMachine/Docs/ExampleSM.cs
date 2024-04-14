using UnityEngine;

/// <summary>
/// ExampleSM demonstrates a state machine in Unity that supports two ways of state transitions:
/// 1. States can request transitions themselves (internal logic).
/// 2. External systems or scripts can override the current state at any time (external logic).
/// </summary>
public class ExampleSM : StateMachine
{
    [Header("Variables")]
    // Time in seconds before transitioning to the InternalSwitchState as an example of state overriding.
    public float FirstSwitchTime = 5; // We will wait 5 seconds before switching to the external switch state.

    // Internal timer used for demonstration purposes to show how states can be overridden.
    private float _time;

    [Header("States")]
    // A state accessible externally, allowing dynamic state switching by external systems.
    [HideInInspector] public StateOne FirstSwitchState;

    // The second state that the state machine transitions to after the internal logic completes.
    [HideInInspector] public StateTwo SecondSwitchState;

    /// <summary>
    /// Unity's Awake method initializes the state machine and sets the initial state.
    /// </summary>
    private void Awake()
    {
        // Initialize the states and pass this state machine instance for context.
        // This is necessary for the state machine to function correctly.
        FirstSwitchState = new StateOne(this);
        SecondSwitchState = new StateTwo(this);

        // Set the initial state to FirstState, which determines the behavior at the start.
        SetInitialState(FirstSwitchState);
    }

    /// <summary>
    /// Unity's Update method demonstrates how to override the current state based on external logic.
    /// </summary>
    public void Update()
    {
        // Check if the 'G' key is pressed to trigger an external override.
        if (Input.GetKeyDown(KeyCode.G))
        {
            /* 
             * Demonstrates external state switching:
             * - This state machine supports overriding the current state from outside.
             * - For example, a timer or other system can force a state change.
             * - To handle such transitions in any state, the logic should be implemented here in this script.
             */
            ChangeState(FirstSwitchState);
        }
    }
}
