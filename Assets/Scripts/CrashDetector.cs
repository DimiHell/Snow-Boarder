using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float crashTime = 0.5f;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            
            Invoke("reloadCrash", crashTime);
            GetComponent<AudioSource>().Play();
        }
    }

    void reloadCrash()
    {
        SceneManager.LoadScene(0);
    }
}
