namespace Footballer;
public class Player
{
    // properti kelas
    private string _playerName;
    private int _age;
    private string _club;
    //constructior adalah suatu method yang memberikan nilai awal pada objek yang dibuat
    public Player(string name, int age, string club)
    {
        _playerName = name;
        _age = age;
        _club = club;
    }
    public string GetName()
    {
        return _playerName;
    }
    public int GetUmur()
    {
        return _age;
    }
    public string GetClub()
    {
        return _club;
    }
}