using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void LapDissolve(string part_name)
    {
        Application.LoadLevel(part_name);
    }
    public void Quit()
    {
        Application.Quit();
    }
}