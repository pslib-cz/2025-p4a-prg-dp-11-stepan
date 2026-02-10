** State Pattern - Kávovar s Jedním Tlaèítkem

State pattern je návrhový vzor, který umožòuje objektu zmìnit své chování v závislosti na svém vnitøním stavu.
Tento vzor je užiteèný pro objekty, které mohou být ve více stavech a jejich chování se mìní podle toho, v jakém stavu se nacházejí.

Pøidávat nové stavy je možné za pomoci vytvoøení nových tøíd a není nutné upravovat vnitøní kód (kávovaru).

Pøi volání zmáèknutí tlaèítka na stavu se pøedává reference na kávovar, takže stav má kompletní kontext.

Vybrali jsme state, protože je nejvhodnìjší pro tento problém.