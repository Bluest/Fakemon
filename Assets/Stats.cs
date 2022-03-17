public struct Stats
{
    public int baseAttack;
    public int attackStage;
    public int currentAttack;
    public int baseDefense;
    public int defenseStage;
    public int currentDefense;
    public int baseSpecialAttack;
    public int specialAttackStage;
    public int currentSpecialAttack;
    public int baseSpecialDefense;
    public int specialDefenseStage;
    public int currentSpecialDefense;
    public int baseSpeed;
    public int speedStage;
    public int currentSpeed;

    public void ResetAll()
    {
        attackStage = 0;
        defenseStage = 0;
        specialAttackStage = 0;
        specialDefenseStage = 0;
        speedStage = 0;
        currentAttack = baseAttack;
        currentDefense = baseDefense;
        currentSpecialAttack = baseSpecialAttack;
        currentSpecialDefense = baseSpecialDefense;
        currentSpeed = baseSpeed;
    }
}
