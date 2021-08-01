
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroyball : MonoBehaviour
{
    public Transform ballposition;
    bool can_fire = true;
    bool can_respawn = true;
    GameObject reference;
    public GameObject ball;
    bool followpaddle=true;
    public Text scoretext;
    public float score = 0;
    public Text lifetext;
    float life = 3;
    public GameObject gameover;
 

   
    void Update()
    {
     
        if (can_respawn == true)
        {
            reference = Instantiate(ball, ballposition.position, transform.rotation) as GameObject;
            can_respawn = false;
        }
        if(followpaddle==true)
        {
            reference.transform.position = ballposition.position;
        }
        if (Input.GetButtonDown("Fire1") && can_fire == true)
        {
            reference.GetComponent<Rigidbody2D>().AddForce(new Vector2(100f, 100f));
            can_fire = false;
            followpaddle = false;
        }
      
        lifetext.text = " LIFE:" + life.ToString();
        scoretext.text = "SCORE:" + score.ToString();
        if(life<=0 ||score>=50)
        {
            gameover.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="ball")
        {
           
            life = life - 1;
            Destroy(reference);
            can_fire = true;
            can_respawn = true;
            followpaddle = true;
        }
    }
    public void onbuttonpressed()
    {
        SceneManager.LoadScene("Wall Breaker");
    }
}

