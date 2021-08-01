
using UnityEngine;

public class Destroybricks : MonoBehaviour
{
    Destroyball script;
   
    void Start()
    {
        script = FindObjectOfType<Destroyball>();
    }

   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="ball")
        {
            Destroy(gameObject);
            script.score = script.score + 1;
           
        }
    }
}
