using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] Text healthText;

    int maxHP = 20;
    int currentHP = 20;
    int attack = 4;
    int defence = 0;

    public void TakeDamage(int damage)
    {
        currentHP -= (damage - defence);
        healthText.text = "HP: " + currentHP + "/" + maxHP;
    }

    public void Tackle(Pokemon target)
    {
        target.TakeDamage(attack);
    }
}
