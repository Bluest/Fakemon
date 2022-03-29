using UnityEngine;

public static class MoveEffects
{
    public static bool SuccessfulHit(int accuracy)
    {
        return Random.Range(0f, 100f) < accuracy ? true : false;
    }

    public static float CalculateDamage(Pokemon user, Pokemon target, int power, Category category)
    {
        float statModifier = 1f;

        if (category == Category.Physical)
        {
            statModifier = user.stats.GetStat(Stat.Attack) / target.stats.GetStat(Stat.Defense);
        }
        else if (category == Category.Special)
        {
            statModifier = user.stats.GetStat(Stat.SpecialAttack) / target.stats.GetStat(Stat.SpecialDefense);
        }

        return 0.44f * power * statModifier + 2;
    }
}
