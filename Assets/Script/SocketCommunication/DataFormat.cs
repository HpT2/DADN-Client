using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SendFormat<T>
{
    public string state = GameManager.instance.state.ToString();
    public T data;
    public SendFormat(T data)
    {
        this.data = data;
    }
}

[Serializable]
public class EventName
{
    public string event_name;
}

[Serializable]
public class Test : EventName
{
    public Test() { event_name = "Test"; }
}
