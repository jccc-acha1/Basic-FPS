using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)) {
                Transform objectHit = hit.transform;
                MonoBehaviour[] mono;
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();
                
                foreach (MonoBehaviour item in mono) {
                    if (item is IDamage) {
                        IDamage temp = item as IDamage;
                        temp.TakeDamage();
                        return;
                    }
                }
                Debug.Log(objectHit.name);
            }
        }
    }
}
