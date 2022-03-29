public class BattleStats
{
    Stats _base;
    Stats _stages = new Stats();

    public BattleStats(Stats baseStats)
    {
        _base = baseStats;
        ResetStages();
    }

    public void ResetStages()
    {
        _stages.attack = 0;
        _stages.defense = 0;
        _stages.specialAttack = 0;
        _stages.specialDefense = 0;
        _stages.speed = 0;
    }

    int CalculateCurrentStatValue(int baseValue, int stage)
    {
        return baseValue + stage * baseValue / 2;
    }

    public int GetStat(Stat stat)
    {
        switch (stat)
        {
            case Stat.Attack: return CalculateCurrentStatValue(_base.attack, _stages.attack);
            case Stat.Defense: return CalculateCurrentStatValue(_base.defense, _stages.defense);
            case Stat.SpecialAttack: return CalculateCurrentStatValue(_base.specialAttack, _stages.specialAttack);
            case Stat.SpecialDefense: return CalculateCurrentStatValue(_base.specialDefense, _stages.specialDefense);
            case Stat.Speed: return CalculateCurrentStatValue(_base.speed, _stages.speed);
            default: return 0;
        }
    }

    public void ModifyStage(Stat stat, int value)
    {
        switch (stat)
        {
            case Stat.Attack: _stages.attack += value; break;
            case Stat.Defense: _stages.defense += value; break;
            case Stat.SpecialAttack: _stages.specialAttack += value; break;
            case Stat.SpecialDefense: _stages.specialDefense += value; break;
            case Stat.Speed: _stages.speed += value; break;
        }
    }
}
