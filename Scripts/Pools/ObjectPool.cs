using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BigasTools{
    public class ObjectPool : MonoBehaviour
    {
        public string objectId;
        public GameObject objectPrefab;
        private Queue<GameObject> avaliableObjects = new Queue<GameObject>();
        [SerializeField] int maxPlayerCapacity;
        public virtual void Start() {
            GrowPool();
            PoolsManager.Instance.AddToPool(this);
        }
        public virtual GameObject GetFromPool(Vector2 pos){
            if(avaliableObjects.Count == 0){
                GrowPool();
            }
            var instance = avaliableObjects.Dequeue();
            instance.SetActive(true);
            instance.transform.position = pos;
            return instance;
        }    
        public virtual void GrowPool()
        {
            for(int i = 0; i < maxPlayerCapacity; i++){
                var instanceToAdd = Instantiate(objectPrefab);
                instanceToAdd.transform.SetParent(transform);
                AddToPool(instanceToAdd);
            }
        }
        public virtual void AddToPool(GameObject instance){
            instance.SetActive(false);
            avaliableObjects.Enqueue(instance);
        }
    }
}
