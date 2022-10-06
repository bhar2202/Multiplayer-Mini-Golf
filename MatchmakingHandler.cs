using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchmakingHandler : MonoBehaviour
{
     void Start()
    {
        //websocket startup
        WebSocketService.Instance.init();
    }

    public void exitMatchmaking()
    {
        SceneManager.LoadScene("Level_00");
    }
}
