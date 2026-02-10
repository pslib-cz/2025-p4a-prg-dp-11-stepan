Console.WriteLine("MODERNI KAVORAR - SIMULACE STISLU TLACITKA\n");
Console.WriteLine(new string('=', 50));

CoffeeMachine machine = new CoffeeMachine();

Console.WriteLine("\n--- SCENARIO 1: Cekani - spusteni nabidky ---, zmackni tlacitko");
Console.ReadKey();
machine.PressButton();

Console.WriteLine("\n--- SCENARIO 2: Mlicka - zruseni ---, zmackni tlacitko");
Console.ReadKey();
machine.PressButton();

Console.WriteLine("\n--- SCENARIO 3: Prechod do rezimu vareni ---, zmackni tlacitko");
Console.ReadKey();
machine.SetState(new BrewingState());
Console.WriteLine("Kavorar nyni vari. Stiskame tlacitko...");

Console.WriteLine("\n--- SCENARIO 4: Vareni - pokus o stisk (neaktivni) ---, zmackni tlacitko");
Console.ReadKey();
machine.PressButton();

Console.WriteLine("\n--- SCENARIO 5: Opakovany pokus behem vareni ---, zmackni tlacitko");
Console.ReadKey();
machine.PressButton();

Console.WriteLine("\n--- SCENARIO 6: Vareni skoncilo, navrat do cekani ---, zmackni tlacitko");
Console.ReadKey();
machine.SetState(new WaitingState());
machine.PressButton();

Console.WriteLine("\n" + new string('=', 50));
Console.WriteLine("Simulace skoncena!");
