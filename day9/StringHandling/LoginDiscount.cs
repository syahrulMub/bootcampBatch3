namespace Pelanggan;

public class Pelanggan
{
    public string name;

    public Pelanggan(string name)
    {
        this.name = name;
    }

    public string Initials()
    {
        string[] nameParts = name.Split(' ');
        string[] initials = new string[nameParts.Length];

        for (int i = 0; i < nameParts.Length; i++)
        {
            initials[i] = nameParts[i][0].ToString();
        }

        return string.Join("", initials);
    }
}