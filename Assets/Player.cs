using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Pokemon> team = new List<Pokemon>();
    public List<Pokemon> activePokemon = new List<Pokemon>();

    public void AddToTeam(Pokemon pokemon)
    {
        team.Add(pokemon);
    }

    public void SendOut(int numberOfPokemon)
    {
        Debug.Assert(activePokemon.Count == 0);

        int n = numberOfPokemon < team.Count ? numberOfPokemon : team.Count;
        for (int i = 0; i < n; ++i)
        {
            activePokemon.Add(team[i]);
        }
    }

    public void Switch(Pokemon switchingOut, Pokemon switchingIn)
    {
        activePokemon.Remove(switchingOut);
        activePokemon.Add(switchingIn);
    }

    public void AllowControl()
    {

    }
}
