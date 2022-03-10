using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void PerformMove(Move move, Pokemon user, Pokemon target)
    {
        move.effect(user, target);
    }
}
