using UnityEngine;

public static class MoveEffects
{
    public static bool SuccessfulHit(int accuracy)
    {
        float roll = Random.Range(0f, 100f);
        if (roll < accuracy) Debug.Log("HIT - " + roll + " < " + accuracy);
        else Debug.Log("MISS - " + roll + " > " + accuracy);
        return roll < accuracy ? true : false;
    }

    public static int CalculateDamage(Pokemon user, Pokemon target, int power, float multiplier)
    {
        return (int)(power / 10 * multiplier);
    }
}
