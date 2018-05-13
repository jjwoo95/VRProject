using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Collections;

public class DestructibleScript : MonoBehaviour
{

    public GameObject replacement;
    bool isDestroyed = false;
    public bool isHouse;
    public bool isWall;
    public int myTrack;

    private static bool CR_running = true;

    public GameObject crumble;
    AudioSource crumbleSound;

    public GameObject explosion;
    AudioSource explosionSound;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(CR_running == false)
        LoadNewScene(myTrack);
    }

    void OnCollisionEnter()
    {

        if (isDestroyed == false)
        {
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
            isDestroyed = true;



            StartCoroutine(TimeWait(1.4f));
            // StartCoroutine(TimeWait(1.4f, 2, myTrack));

            if (myTrack == 1)
            {

                SceneManager.LoadScene("ChangePlayerSizeLevel", LoadSceneMode.Single);
            }

            else if (myTrack == 2)
            {

                SceneManager.LoadScene("FlashlightLevel");
            }

            else if (myTrack == 3)
            {

                SceneManager.LoadScene("TiltBoardLevel");
            }


        }





    }

    IEnumerator TimeWait(float time)
    {
        //print(Time.time);

     

            yield return new WaitForSeconds(2f);
        CR_running = false;
    }
       


        //;
        //print(Time.time);

    void LoadNewScene(int scene)
    {
        if (CR_running == false)
        {
            if (scene == 1)
            {
                
                SceneManager.LoadScene("ChangePlayerSizeLevel", LoadSceneMode.Single);
            }

            else if (scene == 2)
            {

                SceneManager.LoadScene("FlashlightLevel");
            }

            else if (scene == 3)
            {

                SceneManager.LoadScene("TiltBoardLevel");
            }

        }
    }

    
}
