using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct CardStat
{
    public float upgradeMuti;
}

public enum CardType
{
    Resource,
    Defense
}

public enum ResourceType
{
    Wood,
    Stone,
    Iron
}

public class CardSystem : MonoBehaviour
{
    [SerializeField] protected List<GameObject> myResourceList = new();
    [SerializeField] protected List<GameObject> mySkillList = new();

    CardStat cardStat;

    private void Start()
    {
        cardStat.upgradeMuti = 1.0f;
    }

    #region GetSetResource
    public virtual void SetResource(GameObject setItem, CardType cardType, int resourceCount)
    {
        if (cardType == CardType.Resource)
        {
            for (int i = 0; i < resourceCount; i++)
            {
                myResourceList.Add(setItem);
            }
        }
        else
        {
            mySkillList.Add(setItem);
        }
    }

    public virtual List<GameObject> GetResourceAll()
    {
        return myResourceList;
    }

    //public virtual List<GameObject> GetResource()
    //{
    //    foreach (var item in myResourceList)
    //    {
    //        return item;
    //    }
    //}
    #endregion

    public virtual void DestroyResource(GameObject setItem, CardType cardType, int destroyResourceCount)
    {
        if (cardType == CardType.Resource)
        {
            if (myResourceList.Count - destroyResourceCount >= 0)
            {
                for (int i = 0; i < destroyResourceCount; i++)
                {
                    myResourceList.RemoveAt(destroyResourceCount);
                }
            }
            else
            {
                TimeAgent agent = new(1.5f, timeDissableAction: (destroy) => UIManager.Instance.NPCTextActiveSystem());
            }
        }
        else
        {
            mySkillList.Remove(setItem);
        }
    }

    public virtual void UpgradeCard()
    {
        cardStat.upgradeMuti *= 1.2f;
    }
}
