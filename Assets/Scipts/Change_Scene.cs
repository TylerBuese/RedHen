using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    public void loanScene(string sceneName)
    {
        HttpClient client = new HttpClient();
        var responseString = client.GetStringAsync("http://google.com");
        Debug.Log(responseString.Result);

        SceneManager.LoadScene(sceneName);
    }
}
