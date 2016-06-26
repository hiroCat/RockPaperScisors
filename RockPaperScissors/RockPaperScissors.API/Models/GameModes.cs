namespace RockPaperScissors.API.Models
{
    public enum ClassicGameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    };

    public enum SpockGameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
        Lizard = 3,
        Spock = 4
    };

    public enum GameModes
    {
        ClassicGameMove = 0,
        SpockGameMove = 1
    }
}