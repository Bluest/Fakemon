using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Text healthText;

    int maxHP = 20;
    int currentHP = 20;
    public int attack = 4;
    int defence = 0;
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
        currentHP -= (damage - defence);
        healthText.text = "HP: " + currentHP + "/" + maxHP;
    }

    void Start()
    {
        moves.Add(MoveList.moves["tackle"]);
        moves.Add(MoveList.moves["tackle"]);
        moves.Add(MoveList.moves["tackle"]);
        moves.Add(MoveList.moves["tackle"]);
    }
}
