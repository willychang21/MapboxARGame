using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIntroduct : MonoBehaviour
{
    public Sprite[] image;
    public Image im;
    int cnt = 0;
    public GameObject panel;

    public void OnBtnShowClick()
    {
        panel.SetActive(true);
    }

    public void paneloff()
    {
        panel.SetActive(false);
    }

    public void changImageRight()
    {
        if (cnt < 3)
        {
            cnt++;
            im.GetComponent<Image>().sprite = image[cnt];
        }
    }

    public void changImageLeft()
    {
        if (cnt > 0)
        {
            cnt--;
            im.GetComponent<Image>().sprite = image[cnt];
        }
    }

}
