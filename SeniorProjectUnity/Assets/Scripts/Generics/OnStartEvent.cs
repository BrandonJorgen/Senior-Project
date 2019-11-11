﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnStartEvent : MonoBehaviour
{
    
    public UnityEvent startEvent;

    void Start()
    {
        startEvent.Invoke();
    }
}