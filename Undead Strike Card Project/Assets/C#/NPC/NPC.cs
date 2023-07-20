using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class NPC : MonoBehaviour, IQuestAble
{
    private ChatState chatState;
    public ChatState ChatState => chatState;

    [SerializeField] protected ChatData chatDatas;

    [SerializeField] private float detectionRange;

    private void Start()
    {
        //UIManager.Instance.GiveBtnAddListener(() => QuestSystem.Instance.CheckQuest();
    }

    private void Update()
    {
        CheckPlayerDetection();
    }

    #region Quest
    public void GetQuest(int destroyCount)
    {
        throw new System.NotImplementedException();
    }


    private void ActiveNPCChat()
    {
        UIManager.Instance.NPCTextActiveSystem();
        UIManager.Instance.NPCBtnSystem();
        UIManager.Instance.NPCText(ReturnNPCChatData().chatStringData[^1]);
    }
    #endregion

    #region CheckPlayerDetection
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
#endif

    private void CheckPlayerDetection()
    {
        Collider2D[] checkPlayer = Physics2D.OverlapCircleAll(transform.position, detectionRange, LayerMask.GetMask("Player"));

        foreach (var hit in checkPlayer)
        {
            hit.TryGetComponent(out Player player);

            if (player && Input.GetKeyDown(KeyCode.E))
            {
                ActiveNPCChat();
            }
        }
    }
    #endregion

    private NPCChatData ReturnNPCChatData()
    {
        NPCChatData resultChatData = null;

        foreach (var npcChatData in chatDatas.npcChatDatas)
        {
            resultChatData = npcChatData;
        }
        return resultChatData;
    }

}
