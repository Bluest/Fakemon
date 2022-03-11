using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Text healthText;

    int maxHP = 20;
    int currentHP = 20;
    public Stats stats;
    List<Move> moves = new List<Move>();
    Move selectedMove = null;

    public void SelectMove(int moveIndex)
    {
        selectedMove = moves[moveIndex];
    }

    public void SelectTarget(Pokemon target)
    {
        gameManager.PerformMove(selectedMove, this, target);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= (damage - stats.currentDefense);
        healthText.text = "HP: " + currentHP + "/" + maxHP;
    }

    public void SetHP(int hp)
    {
        currentHP = hp;
        healthText.text = "HP: " + currentHP + "/" + maxHP;
    }

    void Start()
    {
        stats.baseAttack = 4;
        stats.ResetAll();

        moves.Add(MoveList.moves["tackle"]);
        moves.Add(MoveList.moves["apologise"]);
        moves.Add(MoveList.moves["hug"]);
        moves.Add(MoveList.moves["gun"]);
    }
}
