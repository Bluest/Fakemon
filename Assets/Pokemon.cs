using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] BattleManager battleManager; // TODO: This can be moved to Player along with SelectMove & SelectTarget, I think
    [SerializeField] Text hpText;

    public string nickname;
    public List<Type> types = new List<Type>();
    int level = 50;
    int maxHP;
    int currentHP;
    public BattleStats stats;
    List<Move> moves = new List<Move>();
    Move selectedMove = null;

    public void SetSpecies(Species species)
    {
        nickname = species.name;
        types.Add(Type.Ground);
        types.Add(Type.Rock);
        maxHP = currentHP = 100;
        stats = new BattleStats(species.stats);
        moves.Add(MoveList.moves["stomp"]);
        moves.Add(MoveList.moves["hammer-arm"]);
        moves.Add(MoveList.moves["earthquake"]);
        moves.Add(MoveList.moves["megahorn"]);
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
    }
}
