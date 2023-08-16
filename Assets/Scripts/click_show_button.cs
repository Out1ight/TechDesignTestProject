using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click_show_button : MonoBehaviour
{
    public GameObject button;
    private void OnMouseUp()
    {
        if (button.activeSelf == false)
        {
            button.SetActive(true);
        }
        else button.SetActive(false);
    }
}
