using System;

public class CoffeeMachine
{
    private ICoffeMachineState _currentState;

    public CoffeeMachine()
    {
        _currentState = new WaitingState();
    }

    public void SetState(ICoffeMachineState state)
    {
        _currentState = state;
    }

    public void PressButton()
    {
        Console.WriteLine($"\n[AKTUALNI STAV: {_currentState.GetState()}]");
        _currentState.OnButtonPressed(this);
    }

    public string GetCurrentState() => _currentState.GetState();
}