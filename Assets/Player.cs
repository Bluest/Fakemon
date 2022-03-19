using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Pokemon> team = new List<Pokemon>();
    public List<Pokemon> activePokemon = new List<Pokemon>();

    public void Switch(Pokemon switchingOut, Pokemon switchingIn)
    {
        activePokemon.Remove(switchingOut);
        activePokemon.Add(switchingIn);
    }

    public void AllowControl()
    {

    }
}
