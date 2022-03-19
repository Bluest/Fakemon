using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    List<Player> players = new List<Player>();
    List<Player> ai = new List<Player>();
    List<Pokemon> waitingFor = new List<Pokemon>();
    List<(Move, Pokemon, Pokemon)> submittedMoves = new List<(Move, Pokemon, Pokemon)>();

    void Start()
    {
        players.Add(GameObject.Find("Player").GetComponent<Player>());
        StartNewTurn();
    }

    void StartNewTurn()
    {
        foreach (Player player in players)
        {
            foreach (Pokemon pokemon in player.activePokemon)
            {
                waitingFor.Add(pokemon);
            }
        }
    }

    public void SubmitMove(Move move, Pokemon user, Pokemon target)
    {
        submittedMoves.Add((move, user, target));
        waitingFor.Remove(user);
        if (waitingFor.Count == 0)
            PerformTurn();
    }

    void PerformTurn()
    {
        // TODO: Priority
        foreach (var move in submittedMoves)
        {
            move.Item1.effect(move.Item2, move.Item3);
        }

        submittedMoves.Clear();
        StartNewTurn();
    }
}
