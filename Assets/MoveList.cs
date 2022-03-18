using System.Collections.Generic;

public static class MoveList
{
    public static readonly Dictionary<string, Move> moves = new Dictionary<string, Move>();

    static MoveList()
    {
        moves.Add("stomp", new Move
        {
            name = "Stomp",
            type = Type.Normal,
            category = Category.Physical,
            power = 65,
            accuracy = 1f,
            pp = 20,
            effect = (user, target) =>
            {
                target.TakeDamage(user.stats.currentAttack);
            }
        });
        moves.Add("hammer-arm", new Move
        {
            name = "Hammer Arm",
            type = Type.Fighting,
            category = Category.Physical,
            power = 100,
            accuracy = 0.9f,
            pp = 10,
            effect = (user, target) =>
            {
                target.TakeDamage(user.stats.currentAttack);
            }
        });
        moves.Add("earthquake", new Move
        {
            name = "Earthquake",
            type = Type.Ground,
            category = Category.Physical,
            power = 100,
            accuracy = 1f,
            pp = 10,
            effect = (user, target) =>
            {
                target.TakeDamage(user.stats.currentAttack);
            }
        });
        moves.Add("megahorn", new Move
        {
            name = "Megahorn",
            type = Type.Bug,
            category = Category.Physical,
            power = 120,
            accuracy = 0.85f,
            pp = 10,
            effect = (user, target) =>
            {
                target.TakeDamage(user.stats.currentAttack);
            }
        });
    }
}
