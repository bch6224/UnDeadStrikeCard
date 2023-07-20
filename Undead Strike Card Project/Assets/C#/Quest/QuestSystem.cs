using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IQuestAble
{
    public void GetQuest(int destroyCount);
}

public class QuestSystem : Singleton<QuestSystem>
{
    [SerializeField] protected List<Quest> currentQuestList;
    [SerializeField] protected List<ChatData> currentChatDatasList;

    public System.Func<bool> isClearFunc;

    public void AddQuest(Quest quest, ChatData chatData)
    {
        currentQuestList.Add(quest);
        currentChatDatasList.Add(chatData);
    }

    public void CheckQuest(NPC npc)
    {

    }
}