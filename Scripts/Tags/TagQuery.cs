using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace BigasTools{
    public static class TagQuery
    {
        private static Dictionary<string, GameObject> cachedObjects = new Dictionary<string, GameObject>();

        public static GameObject FindObject(string name){
            GameObject obj;
            if(cachedObjects.TryGetValue(name, out obj)){
                return obj;
            }else{
                var o = Object.FindObjectsOfType<Tag>();
                foreach(var g in o){
                    cachedObjects.Add(g.tagName, g.gameObject);
                    if(g.tagName == name)return g.gameObject;
                }
            }
            return null;
        }
        public static void DisposeCache(){
            cachedObjects.Clear();
        }
    }
}
