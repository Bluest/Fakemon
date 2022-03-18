using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;
    [SerializeField] Text healthText;

    List<Type> types = new List<Type>();
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
        battleManager.PerformMove(selectedMove, this, target);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= (int)(damage * TypeData.GetMultiplier(Type.Normal, types) - stats.currentDefense);
        healthText.text = "HP: " + currentHP + "/" + maxHP;
    }

    void Start()
    {
        types.Add(Type.Ground);
        types.Add(Type.Rock);

        stats.baseAttack = 4;
        stats.ResetAll();

        moves.Add(MoveList.moves["stomp"]);
        moves.Add(MoveList.moves["hammer-arm"]);
        moves.Add(MoveList.moves["earthquake"]);
        moves.Add(MoveList.moves["megahorn"]);
    }
}
