using System.Collections.Generic;

public static class TypeData
{
    static readonly List<List<float>> multipliers = new List<List<float>>();
    const float i = 0f; // Immune
    const float w = 0.5f; // Weak
    const float n = 1f; // Neutral
    const float s = 2f; // Strong

    static TypeData()
    {
        multipliers.Add(new List<float>{n,n,n,n,n,w,n,i,w,n,n,n,n,n,n,n,n,n});
        multipliers.Add(new List<float>{s,n,w,w,n,s,w,i,s,n,n,n,n,w,s,n,s,w});
        multipliers.Add(new List<float>{n,s,n,n,n,w,s,n,w,n,n,s,w,n,n,n,n,n});
        multipliers.Add(new List<float>{n,n,n,w,w,w,n,w,i,n,n,s,n,n,n,n,n,s});
        multipliers.Add(new List<float>{n,n,i,s,n,s,w,n,s,s,n,w,s,n,n,n,n,n});
        multipliers.Add(new List<float>{n,w,s,n,w,n,s,n,w,s,n,n,n,n,s,n,n,n});
        multipliers.Add(new List<float>{n,w,w,w,n,n,n,w,w,w,n,s,n,s,n,n,s,w});
        multipliers.Add(new List<float>{i,n,n,n,n,n,n,s,n,n,n,n,n,s,n,n,w,n});
        multipliers.Add(new List<float>{n,n,n,n,n,s,n,n,w,w,w,n,w,n,s,n,n,s});
        multipliers.Add(new List<float>{n,n,n,n,n,w,s,n,s,w,w,s,n,n,s,w,n,n});
        multipliers.Add(new List<float>{n,n,n,n,s,s,n,n,n,s,w,w,n,n,n,w,n,n});
        multipliers.Add(new List<float>{n,n,w,w,s,s,w,n,w,w,s,w,n,n,n,w,n,n});
        multipliers.Add(new List<float>{n,n,s,n,i,n,n,n,n,n,s,w,w,n,n,w,n,n});
        multipliers.Add(new List<float>{n,s,n,s,n,n,n,n,w,n,n,n,n,w,n,n,i,n});
        multipliers.Add(new List<float>{n,n,s,n,s,n,n,n,w,w,w,s,n,n,w,s,n,n});
        multipliers.Add(new List<float>{n,n,n,n,n,n,n,n,w,n,n,n,n,n,n,s,n,i});
        multipliers.Add(new List<float>{n,w,n,n,n,n,n,s,n,n,n,n,n,s,n,n,w,w});
        multipliers.Add(new List<float>{n,s,n,w,n,n,n,n,w,w,n,n,n,n,n,s,s,n});
    }

    public static float GetMultiplier(Type attacking, List<Type> defending)
    {
        float multiplier = 1f;

        foreach (Type type in defending)
        {
            multiplier *= multipliers[(int)attacking][(int)type];
        }

        return multiplier;
    }
}
