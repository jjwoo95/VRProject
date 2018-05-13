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

    private bool CR_running = true;

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

    }

    void OnCollisionEnter()
    {

        if (isDestroyed == false)
        {
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            Destroy(gameObject);
            isDestroyed = true;



            StartCoroutine(TimeWait(1.4f,1, myTrack));
           // StartCoroutine(TimeWait(1.4f, 2, myTrack));




        }





    }

    IEnumerator TimeWait(float time, int track, int scene)
    {
        //print(Time.time);

        if (track == 1)
        {
            CR_running = false;
            yield return new WaitForSeconds(2f);
            LoadNewScene(scene);

        }
       

        if (track == 2)
            LoadNewScene(scene);
        //;
        //print(Time.time);
    }
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
