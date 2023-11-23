using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{
    static ButtonController invoker;
    static UnityAction<int> listener;

    public static void AddEventInvoker(ButtonController script) 
    {
        invoker = script;   
        if(listener != null) 
        {
            invoker.AddPointsAddedEventListener(listener);
        }
    }
    public static void AddEventListener(UnityAction<int> handler) 
    {
        listener = handler;   
        if(invoker != null) 
        {
            invoker.AddPointsAddedEventListener(listener);
        }
    }
}
