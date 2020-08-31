using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum JobTypes
{
    fortification,
    intervention,
    research,
    transportation
}

public enum ValubalTypes
{
    bad,
    normal,
    good,
    verygood
}

public enum RankTypes
{
    rank0,
    rank1,
    rank2,
    rank3
}

[System.Serializable]
public class Portrait
{
    // Boss
    public string Name;
    public Sprite portraitImage;

    // Job
    public JobTypes jobType;
    public Sprite JobsTextImage;
    public Sprite JobsIcon;

    // Rank
    public RankTypes rankType;
    public bool isCaptain = false;

    // Reward
    public string RewardDescription;
    public string RewardSpriteName;

    // Valuable
    public ValubalTypes valuableType;
    public Sprite valuableBackground;

}
