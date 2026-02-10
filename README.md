### State Pattern - Kávovar s Jedním Tlačítkem

State pattern je návrhový vzor, který umožňuje objektu změnit své chování v závislosti na svém vnitřním stavu.
Tento vzor je užitečný pro objekty, které mohou být ve více stavech a jejich chování se mění podle toho, v jakém stavu se nacházejí.

Přidávat nové stavy je možné za pomoci vytvoření nových tříd a není nutné upravovat vnitřní kód (kávovaru).

Při volání zmáčknutí tlačítka na stavu se předává reference na kávovar, takže stav má kompletní kontext.

Vybrali jsme state, protože je nejvhodnější pro tento problém.
