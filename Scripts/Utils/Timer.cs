using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using BigasMath;
public class Timer {
    public float elapsed;
    public float setTime;
    public bool looping;
    public bool paused = false;

    public event Action OnComplete = delegate { };
    public event Action OnPause = delegate { };

    public bool complete {
        get { return elapsed >= setTime; }
    }
    
    public float reverseElaped{
        get {return setTime - elapsed; }
    }

    public Timer(float _set, bool looping = false) {
        setTime = _set;
        this.looping = looping;
    }

    public void Update() {
        if(paused)return;
        elapsed += Time.deltaTime;

        if (elapsed >= setTime) {
            if(looping)Reset();
            OnComplete();
        }
        
    }

    public void Pause(){
        OnPause();
        paused = !paused;
    }

    public void Reset() {
        elapsed = 0;
    }
}
