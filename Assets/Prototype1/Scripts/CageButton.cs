using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageButton : MonoBehaviour
{
    [SerializeField]
    private GameObject winningText;

    private void OnCollisionEnter(Collision collision)
    {
        if (winningText == null)
        {
            return;
        }
        winningText.SetActive(true);
        Time.timeScale = 0f;
    }
}
