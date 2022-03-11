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
    }
}
