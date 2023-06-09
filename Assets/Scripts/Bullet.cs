
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float speed = 500.0f; 
   public float maxlifetime = 10.0f;
    private Rigidbody2D  _rigidbody;

    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Project(Vector2 direction){
        _rigidbody.AddForce(direction * speed);
        Destroy(gameObject, maxlifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
    }
}
