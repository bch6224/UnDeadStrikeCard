using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [Space]
    [SerializeField] private Button giveBtn;
    [SerializeField] private Button notGiveBtn;

    [Space]
    [SerializeField] private TMP_Text npcTxt;

    [Space]
    [SerializeField] private Image npcTextImage;

    #region NPCText
    public void NPCText(string text)
    {
        npcTxt.text = $"{text}";
    }

    public void NPCTextActiveSystem()
    {
        npcTextImage.gameObject.SetActive(!npcTextImage.gameObject.activeSelf);
    }
    #endregion

    #region NPCBtn
    public void NPCBtnSystem()
    {
        giveBtn.gameObject.SetActive(!giveBtn.gameObject.activeSelf);
        notGiveBtn.gameObject.SetActive(!notGiveBtn.gameObject.activeSelf);
    }

    public void GiveBtnAddListener(UnityAction giveAction)
    {
        giveBtn.onClick.AddListener(giveAction);
    }
    #endregion

    #region ElementsActive
    public void ElementsSystem()
    {
        //CardSystem.Instance.GetResource().ToString();
    }
    #endregion
}
