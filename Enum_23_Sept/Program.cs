
// Enum är namn som ersätter en siffra som gör det enklare att läsa och förstå koden.
// Enum är till för att slippa skriva siffror
// Är bara till för att det ska se bättre ut i koden
// Enum är en int variabel med fasta värden
Console.WriteLine(Dagar.Onsdag);
Console.WriteLine((int)Dagar.Onsdag);

enum Color
{
    Röd = 255,
    Grön = 10,
    Blå = 150,
    Lila, // Blir = 151
}

enum Dagar
{
    Måndag = 1,
    Tisdag,
    Onsdag,
    Torsdag,
    Fredag,
    Lördag,
    Söndag
}

enum Weapon
{
    Stick,
    Stone,
    Rusty_Sword,
    Iron_Sword,
    Katana,
    Machine_Gun
}


enum PlayerStatus
{
    GameOn,
    GameOver
}


enum GameStatus
{
    KeepPlaying,
    StopPlaying
}
