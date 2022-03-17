using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public void PerformMove(Move move, Pokemon user, Pokemon target)
    {
        move.effect(user, target);
    }
}
