using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadTime);
        }
        
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
