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
        Species rhydon = new Species();
        rhydon.name = "Rhydon";
        rhydon.types = new List<Type>();
        rhydon.types.Add(Type.Ground);
        rhydon.types.Add(Type.Rock);
        rhydon.hp = 190;
        rhydon.stats.attack = 160;
        rhydon.stats.defense = 150;
        rhydon.stats.specialAttack = 80;
        rhydon.stats.specialDefense = 80;
        rhydon.stats.speed = 70;
        rhydon.moves = new List<Move>();
        rhydon.moves.Add(MoveList.moves["stomp"]);
        rhydon.moves.Add(MoveList.moves["hammer-arm"]);
        rhydon.moves.Add(MoveList.moves["earthquake"]);
        rhydon.moves.Add(MoveList.moves["megahorn"]);

        Pokemon pokemon1 = GameObject.Find("Pokemon1").GetComponent<Pokemon>();
        pokemon1.SetSpecies(rhydon);
        
        Player player = GameObject.Find("Player").GetComponent<Player>();
        player.AddToTeam(pokemon1);
        player.SendOut(1);
        players.Add(player);

        Pokemon pokemon2 = GameObject.Find("Pokemon2").GetComponent<Pokemon>();
        pokemon2.SetSpecies(rhydon);

        Player testAI = GameObject.Find("TestAI").GetComponent<Player>();
        testAI.AddToTeam(pokemon2);
        testAI.SendOut(1);
        ai.Add(testAI);

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
        {
            PerformAI();
            PerformTurn();
        }
    }

    void PerformAI()
    {
        foreach (Player aiTrainer in ai)
        {
            foreach (Pokemon pokemon in aiTrainer.activePokemon)
            {
                pokemon.SelectMove(Random.Range(0, 4));
                Player targetPlayer = players[Random.Range(0, players.Count)];
                Pokemon targetPokemon = targetPlayer.activePokemon[Random.Range(0, targetPlayer.activePokemon.Count)];
                submittedMoves.Add((pokemon.selectedMove, pokemon, targetPokemon));
            }
        }
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
