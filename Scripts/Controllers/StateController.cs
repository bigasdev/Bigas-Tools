using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigasTools{
    public class StateController : MonoBehaviour
    {
        private static StateController instance;
        public static StateController Instance{
            get{
                if(instance == null){
                    instance = FindObjectOfType<StateController>();
                }
                return instance;
            }
        }
        public States currentState;
        
        public void ChangeState(States state){
            if(state == currentState){
                return;
            }
            currentState = state;
        }
        public void ReturnToInitialState(){
            currentState = States.GAME_UPDATE;
        }

    }
    public enum States{
        GAME_UPDATE,
        GAME_IDLE
    }
}
