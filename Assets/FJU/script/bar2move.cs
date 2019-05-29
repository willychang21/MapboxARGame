using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar2move : MonoBehaviour {
	static public  int num = 0;    // 總經驗值
    private float barmax = 5;
    static public int n1 = 0, n2 = 0, n3 = 0;
	public Image bar;
	public Text leveltext;
    public Text addtext1;
    public Text addtext2;
    public Text addtext3;
    public Image addimage;
    public Image addimage2;
    public Image addimage3;
    static public int LV=1 ;    // TODO: 目前先測試 之後要改回來
    int i=255,j=255,k=255,p=255,delay=16;
    bool checkexp = false;
    bool checkone = false, checktwo = false, checkthree = false;


    // Use this for initialization
    void Start () {
      //  PlayerPrefs.DeleteAll();      //清除物件紀錄

        n1 = PlayerPrefs.GetInt("n1");
        n2 = PlayerPrefs.GetInt("n2");
        n3 = PlayerPrefs.GetInt("n3");
        num = PlayerPrefs.GetInt("num");
        bar.fillAmount = num * (1 / barmax);
        //LV = PlayerPrefs.GetInt("LV")+1;
        leveltext.text = LV + "";
    }

    #region 撿東西獲得提示
    /// <summary>
    /// Exp text fadeout
    /// </summary>
    /// <returns></returns>
    IEnumerator Exptextfadeout()
    {
        yield return new WaitForSeconds(0.1f);
        if (checkexp == true)
        {
            if (i>10)
            {
                i-=2;
                addtext1.text = "EXP + 1";
                addtext1.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, i / 255f);
            }
            if(i<=10)
            {
                i = 255;
                addtext1.text = "";
                checkexp = false;
            }
        }

    }

    /// <summary>
    /// Object text fadeout
    /// </summary>
    /// <returns></returns>
    IEnumerator Objecttextfadeout()
    {
        yield return new WaitForSeconds(0.1f);
        if (checkone == true)
        {
            addimage.color= new Color(1, 1, 1, 1);
            addimage.sprite = Resources.Load<Sprite>("未命名");
            if (j > 10)
            {
                j-=2;
                addtext2.text = "+ 1";
                addtext2.color = new Color(85/255f, 243 / 255f, 68 / 255f, j / 255f);
                addimage.color = new Color(1, 1, 1, j / 255f);

            }
            if (j <= 10)
            {
                j = 255;
                addtext2.text = "";
                addimage.color = new Color(1, 1, 1, 0);
                checkone = false;
                addimage.sprite = null;
                addimage2.sprite = null;
            }
        }
        else if (checktwo == true)
        {
            addimage.color = new Color(1, 1, 1, 1);
            addimage.sprite = Resources.Load<Sprite>("未命名-6");
            if (k > 10)
            {
                k-=2;
                addtext2.text = "+ 1";
                addtext2.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, k / 255f);
                addimage.color = new Color(1, 1, 1, k / 255f);
            }
            if (k <= 10)
            {
                k = 255;
                addtext2.text = "";
                addimage.color = new Color(1, 1, 1, 0);
                checktwo = false;
                addimage.sprite = null;
                addimage2.sprite = null;
            }
        }
        else if (checkthree == true)
        {
            addimage.color = new Color(1, 1, 1, 1);
            addimage.sprite = Resources.Load<Sprite>("未命名-4");
            if (p > 10)
            {
                p-=2;
                addtext2.text = "+ 1";
                addtext2.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, p / 255f);
                addimage.color = new Color(1, 1, 1, p / 255f);
            }
            if (p <= 10)
            {
                p = 255;
                addtext2.text = "";
                addimage.color = new Color(1, 1, 1, 0);
                checkthree = false;
                addimage.sprite = null;
                addimage2.sprite = null;
            }
        }

    }
    #endregion

    #region Restaurant交換物品獲得提示
    IEnumerator restObjectfadeout(string addimg, string addtxt, string subimg, string subtxt)
    {
        yield return new WaitForSeconds(0.1f);
        if (UIManager.resttxtcheckstatus == true)
        {
            Debug.Log(delay);
            addimage.sprite = Resources.Load<Sprite>(addimg);
            addtext1.text = addtxt;
            addimage2.sprite = Resources.Load<Sprite>(subimg);
            addtext2.text = subtxt;
            addtext1.color = new Color(0,0,0,0);
            addtext2.color = new Color(0, 0, 0, 0);
            if (delay < 10)
            {
                if (j > 10)
                {
                    j -= 2;
                    addtext1.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, j / 255f);
                    addimage.color = new Color(1, 1, 1, j / 255f);
                    addtext2.color = new Color(255 / 255f, 28 / 255f, 28 / 255f, j / 255f);
                    addimage2.color = new Color(1, 1, 1, j / 255f);

                }
                if (j <= 10)
                {
                    j = 255;
                    addtext1.text = "";
                    addimage.color = new Color(1, 1, 1, 0);
                    addtext2.text = "";
                    addimage2.color = new Color(1, 1, 1, 0);
                    addimage.sprite = null;
                    addimage2.sprite = null;
                    UIManager.resttxtcheckstatus = false;
                    delay = 16;
                }
            }
            else
            {
                delay--;
            }
            

        }
    }
    #endregion

    #region 圖書館BOUNS獲得提示
    IEnumerator libraryObjectfadeout(int nn1,int nn2,int nn3)
    {
        yield return new WaitForSeconds(0.1f); 
        if (UIManager.librarytxtcheckstatus == true)
        {
            Debug.Log(delay);
            addimage.sprite = Resources.Load<Sprite>("未命名");
            addtext1.text = "+ " + nn1;
            addimage2.sprite = Resources.Load<Sprite>("未命名-6");
            addtext2.text = "+ " + nn2;
            addimage3.sprite = Resources.Load<Sprite>("未命名-4");
            addtext3.text = "+ " + nn3;
            addtext1.color = new Color(0, 0, 0, 0);
            addtext2.color = new Color(0, 0, 0, 0);
            addtext3.color = new Color(0, 0, 0, 0);
            if (delay < 10)
            {
                if (j > 10)
                {
                    j -= 2;
                    addtext1.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, j / 255f);
                    addimage.color = new Color(1, 1, 1, j / 255f);
                    addtext2.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, j / 255f);
                    addimage2.color = new Color(1, 1, 1, j / 255f);
                    addtext3.color = new Color(85 / 255f, 243 / 255f, 68 / 255f, j / 255f);
                    addimage3.color = new Color(1, 1, 1, j / 255f);

                }
                if (j <= 10)
                {
                    j = 255;
                    addtext1.text = "";
                    addimage.color = new Color(1, 1, 1, 0);
                    addtext2.text = "";
                    addimage2.color = new Color(1, 1, 1, 0);
                    addtext3.text = "";
                    addimage3.color = new Color(1, 1, 1, 0);
                    addimage.sprite = null;
                    addimage2.sprite = null;
                    addimage3.sprite = null;
                    UIManager.librarytxtcheckstatus = false;
                    delay = 16;
                }
            }
            else
            {
                delay--;
            }


        }
    }
    #endregion


    // Update is called once per frame
    void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit,40f)){
				if(hit.transform != null){
					if (gameObject != null) {
						if (hit.transform.name == "Eraser(Clone)"||hit.transform.name == "Calculator 1(Clone)"||hit.transform.name == "Stapler black(Clone)") {
                            num++;
                            PlayerPrefs.SetInt("num", num);

                            switch (hit.transform.name)     //個別物件記數
                            {
                                case "Eraser(Clone)":        //圖片 : 未命名
                                    n1++;
                                    PlayerPrefs.SetInt("n1", n1);
                                    Debug.Log("n1 = " + n1);
                                    UIManager.PickupNumber++;
                                    checkone = true;
                                    
                                    break;
                                case "Calculator 1(Clone)":   //圖片 : 未命名-6
                                    n2++;
                                    PlayerPrefs.SetInt("n2", n2);
                                    Debug.Log("n2 = " + n2);
                                    UIManager.PickupNumber++;
                                    checktwo = true;

                                    break;
                                case "Stapler black(Clone)":     //圖片 : 未命名-4
                                    n3++;
                                    PlayerPrefs.SetInt("n3", n3);
                                    Debug.Log("n3 = " + n3);
                                    UIManager.PickupNumber++;
                                    checkthree = true;
                                    break;
                            }

                            checkexp = true;
                        }
					}
				}
			}
		}
        StartCoroutine(Exptextfadeout());
        StartCoroutine(Objecttextfadeout());
        StartCoroutine(restObjectfadeout(restScript.addimg, restScript.addtxt, restScript.subimg, restScript.subtxt));
        StartCoroutine(libraryObjectfadeout(librarytime.nn1, librarytime.nn2, librarytime.nn3));
        //經驗條隨等級成長
        if (num < barmax)
        {
            bar.fillAmount = num * (1 / barmax);
        }
        else
        {
            bar.fillAmount = 0f;
            num = 0;
            PlayerPrefs.SetInt("num", num);
            LV++;
            PlayerPrefs.SetInt("LV", LV - 1);
            leveltext.text = LV + "";
            barmax = barmax * 1.2f;
            /*1,1.2,1.44,1.728,2.07,2.488*/
        }
    }
    

}
