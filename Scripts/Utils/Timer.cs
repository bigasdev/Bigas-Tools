using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Timer {
    public float elapsed;
    public float setTime;
    public bool looping;

    public event Action OnComplete = delegate { };

    public bool complete {
        get { return elapsed >= setTime; }
    }

    public Timer(float _set, bool looping = false) {
        setTime = _set;
        this.looping = looping;
    }

    public void Update() {
        elapsed += Time.deltaTime;

        if (elapsed >= setTime) {
            if(looping)Reset();
            OnComplete();
        }
        
    }

    public void Reset() {
        elapsed = 0;
    }
}
