using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other){
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null){ // Check if it's the player and not an NPS
                controller.ChangeHealth(-1);          
        }
    }
}
