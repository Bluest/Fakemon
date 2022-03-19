using UnityEngine;

public static class MoveEffects
{
    public static bool SuccessfulHit(int accuracy)
    {
        return Random.Range(0f, 100f) < accuracy ? true : false;
    }

    public static int CalculateDamage(Pokemon user, Pokemon target, int power, float multiplier)
    {
        return (int)(power / 10 * multiplier);
    }
}
