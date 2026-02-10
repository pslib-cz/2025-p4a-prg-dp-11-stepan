public class WaitingState : ICoffeMachineState
{
    public void OnButtonPressed(CoffeeMachine machine)
    {
        Console.WriteLine("Cekani: Zobrazuji nabidku napoju...");
        Console.WriteLine("   Vyberte napoj: 1-Espresso, 2-Cappuccino, 3-Americano");
        machine.SetState(new GrindingState());
    }

    public string GetState() => "Waiting";
}