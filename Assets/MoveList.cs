using System.Collections.Generic;

public static class MoveList
{
    public static readonly Dictionary<string, Move> moves = new Dictionary<string, Move>();

    static MoveList()
    {
        moves.Add("tackle", new Move
        {
            name = "Tackle",
            type = Type.Normal,
            effect = (user, target) =>
            {
                target.TakeDamage(user.stats.currentAttack);
            }
        });
        moves.Add("apologise", new Move
        {
            name = "Apologise",
            type = Type.Normal,
            effect = (user, target) =>
            {
                target.TakeDamage(-1);
            }
        });
        moves.Add("hug", new Move
        {
            name = "Hug",
            type = Type.Normal,
            effect = (user, target) =>
            {
                target.SetHP(20);
            }
        });
        moves.Add("gun", new Move
        {
            name = "Gun",
            type = Type.Normal,
            effect = (user, target) =>
            {
                target.TakeDamage(999);
            }
        });
    }
}
