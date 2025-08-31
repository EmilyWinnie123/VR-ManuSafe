using UnityEngine;

public class PlayerA_RequestHelp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameManager.Instance.OnPlayerARequestedHelp();
        }
    }
}