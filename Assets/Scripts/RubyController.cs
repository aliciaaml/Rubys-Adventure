using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
  public float speed = 3.0f;

  public int maxHealth = 5;

  public int health {get {return currentHealth;}}
  int currentHealth;
  
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      float horizontal = Input.GetAxis("Horizontal");
      float vertical = Input.GetAxis("Vertical");             //El personaje es frame independent
      
      Vector2 position = rigidbody2d.position;

      position.x = position.x + speed * horizontal * Time.deltaTime;
      position.y=position.y + speed * vertical * Time.deltaTime;

      rigidbody2d.MovePosition(position);
        
    }

    public void ChangeHealth(int amount){
      currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
      Debug.Log("LIFE : " + currentHealth + "/" + maxHealth);
    }
}
