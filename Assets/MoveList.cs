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
            accuracy = 100,
            pp = 20,
            effect = (user, target) =>
            {
                if (!MoveEffects.SuccessfulHit(100)) return;

                float multiplier = 1f;
                if (user.types.Contains(Type.Normal)) multiplier *= 1.5f; // STAB
                multiplier *= TypeData.GetMultiplier(Type.Normal, target.types); // Type
                float damage = MoveEffects.CalculateDamage(user, target, power: 65, Category.Physical);
                target.TakeDamage((int)(damage * multiplier));

                target.ApplyStatusCondition(StatusCondition.Flinch, 30);
            }
        });
        moves.Add("hammer-arm", new Move
        {
            name = "Hammer Arm",
            type = Type.Fighting,
            category = Category.Physical,
            power = 100,
            accuracy = 90,
            pp = 10,
            effect = (user, target) =>
            {
                if (!MoveEffects.SuccessfulHit(90)) return;

                float multiplier = 1f;
                if (user.types.Contains(Type.Fighting)) multiplier *= 1.5f; // STAB
                multiplier *= TypeData.GetMultiplier(Type.Fighting, target.types); // Type
                float damage = MoveEffects.CalculateDamage(user, target, power: 100, Category.Physical);
                target.TakeDamage((int)(damage * multiplier));

                user.stats.ModifyStage(Stat.Speed, -1);
            }
        });
        moves.Add("earthquake", new Move
        {
            name = "Earthquake",
            type = Type.Ground,
            category = Category.Physical,
            power = 100,
            accuracy = 100,
            pp = 10,
            effect = (user, target) =>
            {
                if (!MoveEffects.SuccessfulHit(100)) return;

                float multiplier = 1f;
                if (user.types.Contains(Type.Ground)) multiplier *= 1.5f; // STAB
                multiplier *= TypeData.GetMultiplier(Type.Ground, target.types); // Type
                float damage = MoveEffects.CalculateDamage(user, target, power: 100, Category.Physical);
                target.TakeDamage((int)(damage * multiplier));
            }
        });
        moves.Add("megahorn", new Move
        {
            name = "Megahorn",
            type = Type.Bug,
            category = Category.Physical,
            power = 120,
            accuracy = 85,
            pp = 10,
            effect = (user, target) =>
            {
                if (!MoveEffects.SuccessfulHit(85)) return;

                float multiplier = 1f;
                if (user.types.Contains(Type.Bug)) multiplier *= 1.5f; // STAB
                multiplier *= TypeData.GetMultiplier(Type.Bug, target.types); // Type
                float damage = MoveEffects.CalculateDamage(user, target, power: 120, Category.Physical);
                target.TakeDamage((int)(damage * multiplier));
            }
        });
    }
}
