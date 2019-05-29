using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible : MonoBehaviour {
    // Use this for initialization


	void Start () {
        InvokeRepeating("loadTime", 1, 5);
    }

    void loadTime()         //抓時間
    {
        var date = System.DateTime.Now;
       /* if (UIManager.PickupNumber < 5)　　　　　　　　　　　 //TODO :改數量  (當日撿超過個數即不再顯示) 
        {*/
            var minutes = date.Minute.ToString();
            int min = int.Parse(minutes);

            if (min == 0 || min == 20 || min == 40)       //0、20、40分物件消失
            {
                Destroy(gameObject);
            }
       /* }
        else
        {
            Destroy(gameObject);           
        }
        if (UIManager.tmpdate != date.ToShortDateString().ToString())
        {
            UIManager.PickupNumber = 0;
            UIManager.tmpdate = date.ToShortDateString().ToString();
        }
        */
    }

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit,40f)){
				if(hit.transform != null ){
					if (gameObject != null ) {
						if (hit.transform.name == "Eraser(Clone)"||hit.transform.name == "Calculator 1(Clone)"||hit.transform.name == "Stapler black(Clone)") {
							Debug.Log (hit.transform.name + "被點擊刪除在" + hit.transform.position);
							Destroy (hit.collider.gameObject);
                        }
                        
					}
				}
			}
		}
	}
}
