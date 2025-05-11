using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    public int actualScene;
    public GameObject player;

    private void Update()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < 8f)
        {
            SceneManager.LoadScene(actualScene);
        }
    }
}
