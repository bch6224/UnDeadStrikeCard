using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimerSystem : Singleton<TimerSystem>
{
    private HashSet<TimeAgent> timeAgentHashSet = new();
    private HashSet<TimeAgent> delTimeAgentHashSet = new();

    public void AddTimeAgent(TimeAgent agent)
    {
        timeAgentHashSet.Add(agent);
    }

    private void Update()
    {
        foreach (var agent in timeAgentHashSet)
        {
            agent.UpdateTime();
            if (agent.IsOverTime())
            {
                delTimeAgentHashSet.Add(agent);
            }
        }
        foreach (var delAgent in delTimeAgentHashSet)
        {
            delAgent.timeDissableAction?.Invoke(delAgent);
            timeAgentHashSet.Remove(delAgent);
        }
        delTimeAgentHashSet.Clear();
    }
}

public class TimeAgent
{
    public float CurrentTime { get; private set; }

    private readonly float time;

    public Action<TimeAgent> timeUpdateAction { get; private set; }
    public Action<TimeAgent> timeDissableAction { get; private set; }

    public TimeAgent(float time, Action<TimeAgent> timeUpdateAction = null, Action<TimeAgent> timeDissableAction = null)
    {
        this.time = time;
        this.timeUpdateAction = timeUpdateAction;
        this.timeDissableAction = timeDissableAction;
    }

    public void UpdateTime()
    {
        timeUpdateAction?.Invoke(this);
        CurrentTime += Time.deltaTime;
    }

    public bool IsOverTime()
    {
        return CurrentTime >= time;
    }
}
