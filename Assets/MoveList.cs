using System.Collections.Generic;
using UnityEngine;

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
                float typeMultiplier = TypeData.GetMultiplier(Type.Normal, target.types);
                target.TakeDamage(MoveEffects.CalculateDamage(user, target, power: 65, typeMultiplier));

                string message = TypeData.GetEffectivenessMessage(typeMultiplier);
                if (message != null) Debug.Log(message);

                // 30% flinch chance
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
                float typeMultiplier = TypeData.GetMultiplier(Type.Fighting, target.types);
                target.TakeDamage(MoveEffects.CalculateDamage(user, target, power: 100, typeMultiplier));
                
                string message = TypeData.GetEffectivenessMessage(typeMultiplier);
                if (message != null) Debug.Log(message);

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
                float typeMultiplier = TypeData.GetMultiplier(Type.Ground, target.types);
                target.TakeDamage(MoveEffects.CalculateDamage(user, target, power: 100, typeMultiplier));

                string message = TypeData.GetEffectivenessMessage(typeMultiplier);
                if (message != null) Debug.Log(message);
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
                float typeMultiplier = TypeData.GetMultiplier(Type.Bug, target.types);
                target.TakeDamage(MoveEffects.CalculateDamage(user, target, power: 120, typeMultiplier));

                string message = TypeData.GetEffectivenessMessage(typeMultiplier);
                if (message != null) Debug.Log(message);
            }
        });
    }
}
