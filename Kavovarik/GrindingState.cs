using System;

public class GrindingState : ICoffeMachineState
{
    public void OnButtonPressed(CoffeeMachine machine)
    {
        Console.WriteLine("Mlicka: ZRUSUJE PROCES MLETI!");
        Console.WriteLine("   Mlynek se zastavuje...");
        machine.SetState(new WaitingState());
    }

    public string GetState() => "Grinding";
}