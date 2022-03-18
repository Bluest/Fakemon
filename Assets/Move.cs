using System;

public class Move
{
    public string name;
    public Type type;
    public Category category;
    public int power;
    public int? accuracy;
    public int pp;
    public Action<Pokemon, Pokemon> effect;
}
