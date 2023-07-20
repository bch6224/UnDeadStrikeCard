using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChatState
{
    None,
    Clear,
    Fail
}

[System.Serializable]
public class ChatData
{
    public List<NPCChatData> npcChatDatas;
}

[System.Serializable]
public class NPCChatData
{
    public int chatNum = 0;
    public List<string> chatStringData = new();
    public List<string> chatClearStringData = new();
    public List<string> chatFailStringData = new();
}