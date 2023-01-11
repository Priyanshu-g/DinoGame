using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
    public bool active = false;
    public Animator animator;
    public int baseMovementSpeed = 5;
    int movementSpeed;
    public GameObject center;
    bool dead = false;
    int scoreInt;
    public float jumpHeight = 2.0f;
    public float smoothness = 0.01f;
    Rigidbody2D rigidbody1;
    //public DinoAgent agentScript;

    // Start is called before the first frame update
    void Start()
    {
            rigidbody1 = GetComponent<Rigidbody2D>();
            //Prigidbody = GetComponent<Rigidbody2D>();
            if (SceneManager.GetSceneByName("GameOver").isLoaded)
            {
                SceneManager.UnloadSceneAsync("GameOver");
            }
            //jump = new Vector3(0.0f, 2.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
            Adjustmovement();

            if (!active && !dead)
            {
                active = true;
            }

            if (active)
            {
                animator.SetBool("Walking", true);
                center.transform.position = center.transform.position + new Vector3(1 * movementSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                animator.SetBool("Walking", false);
            }
        if (Input.GetKeyDown("space"))
        {
            rigidbody1.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }

    }
    /*
    private void FixedUpdate()
    {
        /*
        if (agentScript.jumping && transform.position.y < -3.42f && transform.position.y > -3.43f)
            {
                rigidbody1.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            }  
        
    }
    */

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy 1" || col.gameObject.name == "Enemy 2"|| col.gameObject.name == "Enemy 3"|| col.gameObject.name == "Enemy 4")
        {
            animator.SetBool("Dead", true);
            dead = true;
            active = false;
            SceneManager.LoadSceneAsync(sceneName: "GameOver");
            /*
            if (agentScript.isTraining)
            {
                PlayerPrefs.SetString("PrefScore", "0");
                agentScript.EndEpisode();
                SceneManager.LoadSceneAsync(sceneName: "Game");
            }
            else
            {
                animator.SetBool("Dead", true);
                dead = true;
                active = false;
                SceneManager.LoadSceneAsync(sceneName: "GameOver");
            */
        }
    }
    
    void Adjustmovement()
    {
        scoreInt = Int32.Parse(PlayerPrefs.GetString("PrefScore"));
        movementSpeed = baseMovementSpeed + Convert.ToInt32(Math.Floor(scoreInt / 100.0));
        PlayerPrefs.SetInt("Level", Convert.ToInt32(Math.Floor(scoreInt / 100.0)));
    }
}