# Snake
Gra oparta na marnej imitacji Unity własnego pomysłu wykonana z pomocą C# i formularzy windowsa (przestrzeń nazw System.Windows.Forms).

Projekt składa się z 3 głównych elementów (.csproj) - FakeUnity, SnakeObjs oraz Snake.

--Fake Unity
"Biblioteka" imitująca działanie silnika Unity. Posiada najbardziej podstawowe elementy jak GameObject, Component czy Collider oraz własną pętlę którą należy odpowiednio podpiąć do formularza.

--SnakeObjs
Kolejna "biblioteka" imitująca pisanie skryptów w Unity. Dziedziczymy z odpowiednika klasy MonoBehaviour. Główna wada - własnoręcznie trzeba dodawać/ usuwać obiekty do/ z aktywnej sceny (są do tego udostępnione odpowiednie metody wewnątrz klasy GameLoop z projektu FakeUnity).

--Snake
Właściwa część projektu. Tutaj zdefiniowane są okienka imitujące ekrany z odpowiednią zawartością (takie jak panel z opcjami czy panel z pauzą).

Komentarze do kodu są work in progress...
