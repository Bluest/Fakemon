using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;
    [SerializeField] Text hpText;

    Species _species;
    public List<Type> types = new List<Type>();
    int maxHP;
    int currentHP;
    public BattleStats stats;
    List<Move> moves = new List<Move>();
    Move selectedMove = null;

    public void SetSpecies(Species species)
    {
        _species = species;
        stats = new BattleStats(species.baseStats);
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

    void Start()
    {
        types.Add(Type.Ground);
        types.Add(Type.Rock);

        maxHP = currentHP = 100;

        moves.Add(MoveList.moves["stomp"]);
        moves.Add(MoveList.moves["hammer-arm"]);
        moves.Add(MoveList.moves["earthquake"]);
        moves.Add(MoveList.moves["megahorn"]);
    }
}
