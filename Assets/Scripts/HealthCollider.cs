using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null){ // Check if it's the player or an NPS
            if(controller.health < controller.maxHealth){
                controller.ChangeHealth(1);
                Destroy(gameObject);                
            }
        }
    }
}
