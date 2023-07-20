using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    [Header("����Ʈ ����")]
    public List<Contents> Contents;

    [Header("����Ʈ ����")]
    public List<Reward> Reward;

    public int QuestCount;
}

[System.Serializable]
public class Reward
{
    public List<GameObject> RewardItemList;
}

[System.Serializable]
public class Contents
{
    public List<GameObject> ContentsItems;
}