public class BrewingState : ICoffeMachineState
{
    public void OnButtonPressed(CoffeeMachine machine)
    {
        Console.WriteLine("Vareni: TLACITKO JE NEAKTIVNI! Hrozi nebezpeci!");
        Console.WriteLine("   Vareni pokracuje, cekejte...");
    }

    public string GetState() => "Brewing";
}