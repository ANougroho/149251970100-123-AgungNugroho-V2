using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
        Debug.Log("Created by Agung Nugroho - 149251970100-123 ");
    }
}