
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 touchposition;
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Moved)
        {
            touchposition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchposition.x * 10f * Time.deltaTime, 0,0 );
        }
        transform.Translate(Input.GetAxis("Horizontal") * 10f * Time.deltaTime, 0, 0);
        transform.position=new Vector3( Mathf.Clamp(transform.position.x, -1.84f, 1.84f), transform.position.y, 0);
    }
}
