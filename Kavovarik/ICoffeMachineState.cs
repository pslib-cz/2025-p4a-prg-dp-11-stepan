using System;

public interface ICoffeMachineState
{
    void OnButtonPressed(CoffeeMachine machine);
    string GetState();
}