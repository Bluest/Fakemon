using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] BattleManager battleManager; // TODO: This can be moved to Player along with SelectMove & SelectTarget
    [SerializeField] Text hpText;

    // TODO: Level is implied to be 50 in damage calculations
    public string nickname;
    public List<Type> types = new List<Type>();
    int maxHP;
    int currentHP;
    List<StatusCondition> statusConditions = new List<StatusCondition>();
    public BattleStats stats;
    List<Move> moves = new List<Move>();
    public Move selectedMove = null; // TODO: Only public for rough AI implementation

    public void SetSpecies(Species species)
    {
        nickname = species.name;
        types.Add(Type.Ground);
        types.Add(Type.Rock);
        maxHP = currentHP = species.hp;
        stats = new BattleStats(species.stats);
        moves.Add(MoveList.moves["stomp"]);
        moves.Add(MoveList.moves["hammer-arm"]);
        moves.Add(MoveList.moves["earthquake"]);
        moves.Add(MoveList.moves["megahorn"]);

        hpText.text = "HP: " + currentHP + "/" + maxHP;
    }

    public void SelectMove(int moveIndex)
    {
        selectedMove = moves[moveIndex];
    }

    public void SelectTarget(Pokemon target)
    {
        battleManager.SubmitMove(selectedMove, this, target);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        hpText.text = "HP: " + currentHP + "/" + maxHP;
        Debug.Log(nickname + " takes " + damage + " damage");
    }

    public void ApplyStatusCondition(StatusCondition statusCondition, int percentageChance)
    {
        if (statusConditions.Contains(statusCondition)) return;
        
        if (Random.Range(0f, 100f) < percentageChance)
        {
            statusConditions.Add(statusCondition);
        }
    }

    public void RemoveStatusCondition(StatusCondition statusCondition)
    {
        statusConditions.Remove(statusCondition);
    }

    public bool HasStatusCondition(StatusCondition statusCondition)
    {
        return statusConditions.Contains(statusCondition);
    }
}
