using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace BigasTools{
    public class ResourceController
    {
        public const string audiosDirectory = "Audios/Sounds";
        private static AudioClip[] soundClips;
        public static void StartSets(){
            soundClips = Resources.LoadAll<AudioClip>(audiosDirectory);
        }
        public static AudioClip GetAudio(string name){
            foreach(var a in soundClips){
                if(a.name == name){
                    return a;
                }
            }
            Debug.Log("ERROR 001 : NO AUDIO FOUND WITH THIS NAME!");
            return null;
        }
    }
}
