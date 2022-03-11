public struct Stats
{
    public int baseAttack;
    public int baseDefense;
    public int baseSpecialAttack;
    public int baseSpecialDefense;
    public int baseSpeed;
    public int currentAttack;
    public int currentDefense;
    public int currentSpecialAttack;
    public int currentSpecialDefense;
    public int currentSpeed;

    public void ResetAll()
    {
        currentAttack = baseAttack;
        currentDefense = baseDefense;
        currentSpecialAttack = baseSpecialAttack;
        currentSpecialDefense = baseSpecialDefense;
        currentSpeed = baseSpeed;
    }
}
