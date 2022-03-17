using System.Collections.Generic;

public enum Type
{
    Normal,
    Fighting,
    Flying,
    Poison,
    Ground,
    Rock,
    Bug,
    Ghost,
    Steel,
    Fire,
    Water,
    Grass,
    Electric,
    Psychic,
    Ice,
    Dragon,
    Dark,
    Fairy
}

public static class TypeData
{
    const float i = 0f; // Immune
    const float w = 0.5f; // Weak
    const float n = 1f; // Neutral
    const float s = 2f; // Strong
    static readonly float[,] multipliers = new float[,]
    {
        //No Fi Fl Po Gr Ro Bu Gh St Fi Wa Gr El Ps Ic Dr Da Fa
        { n, n, n, n, n, w, n, i, w, n, n, n, n, n, n, n, n, n }, // Normal
        { s, n, w, w, n, s, w, i, s, n, n, n, n, w, s, n, s, w }, // Fighting
        { n, s, n, n, n, w, s, n, w, n, n, s, w, n, n, n, n, n }, // Flying
        { n, n, n, w, w, w, n, w, i, n, n, s, n, n, n, n, n, s }, // Poison
        { n, n, i, s, n, s, w, n, s, s, n, w, s, n, n, n, n, n }, // Ground
        { n, w, s, n, w, n, s, n, w, s, n, n, n, n, s, n, n, n }, // Rock
        { n, w, w, w, n, n, n, w, w, w, n, s, n, s, n, n, s, w }, // Bug
        { i, n, n, n, n, n, n, s, n, n, n, n, n, s, n, n, w, n }, // Ghost
        { n, n, n, n, n, s, n, n, w, w, w, n, w, n, s, n, n, s }, // Steel
        { n, n, n, n, n, w, s, n, s, w, w, s, n, n, s, w, n, n }, // Fire
        { n, n, n, n, s, s, n, n, n, s, w, w, n, n, n, w, n, n }, // Water
        { n, n, w, w, s, s, w, n, w, w, s, w, n, n, n, w, n, n }, // Grass
        { n, n, s, n, i, n, n, n, n, n, s, w, w, n, n, w, n, n }, // Electric
        { n, s, n, s, n, n, n, n, w, n, n, n, n, w, n, n, i, n }, // Psychic
        { n, n, s, n, s, n, n, n, w, w, w, s, n, n, w, s, n, n }, // Ice
        { n, n, n, n, n, n, n, n, w, n, n, n, n, n, n, s, n, i }, // Dragon
        { n, w, n, n, n, n, n, s, n, n, n, n, n, s, n, n, w, w }, // Dark
        { n, s, n, w, n, n, n, n, w, w, n, n, n, n, n, s, s, n }  // Fairy
    };

    public static float GetMultiplier(Type attacking, List<Type> defending)
    {
        float multiplier = 1f;

        foreach (Type d in defending)
        {
            multiplier *= multipliers[(int)attacking, (int)d];
        }

        return multiplier;
    }
}
