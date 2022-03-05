using UnityEngine;

public class Pokemon : MonoBehaviour
{
    int maxHP = 20;
    int currentHP = 20;
    int attack = 4;
    int defence = 0;

    public void TakeDamage(int damage)
    {
        currentHP -= (damage - defence);
    }

    void Tackle(Pokemon target)
    {
        target.TakeDamage(attack);
    }
}
