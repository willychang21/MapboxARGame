using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections;
using System.Collections.Generic;


public class test : MonoBehaviour
{

    [SerializeField]
    AbstractMap _map;

    [SerializeField]
    [Geocode]
    string[] _locationStrings;
    Vector2d[] _locations;

    int itemIndex, locationIndex;

    [SerializeField]
    float _spawnScale = 100f;

    [SerializeField]
    GameObject[] _markerPrefab;

    List<GameObject> _spawnedObjects;

    int[] pre = new int[50];        //座標亂數
    int[] pre2 = new int[50];       //物件亂數
    int iscreate = 1, iscreate2 = 1, iscreate3 = 1, iscreate4 = 1;
    string tssec_string;

    void Start()
    {
        UIManager.tmpdate = System.DateTime.Now.ToShortDateString().ToString();
        _locations = new Vector2d[_locationStrings.Length];
        _spawnedObjects = new List<GameObject>();

        for (int i = 0; i < 50; i++)        //亂數產生座標和物件存在陣列
        {
            locationIndex = Random.Range(0, _locationStrings.Length);
            pre[i] = locationIndex;
            itemIndex = Random.Range(0, _markerPrefab.Length);
            pre2[i] = itemIndex;

            for (int j = 0; j < i; j++)      //檢查是否重複
            {

                while (pre[j] == pre[i])
                {
                    locationIndex = Random.Range(0, _locationStrings.Length);
                    pre[i] = locationIndex;
                }
            }
        }

        InvokeRepeating("loadTime", 1, 5);
        InvokeRepeating("itemsbuttonclick", 1, 3);
    }

    private void Update()
    {
        #region library 倒數計時
        UIManager.ts = (UIManager.librarytargettime).Subtract(System.DateTime.Now);
        tssec_string = UIManager.ts.TotalSeconds.ToString();
        UIManager.ts_float = float.Parse(tssec_string);
        if (UIManager.ts_float <= 0)
        {
            UIManager.librarycheckstatus = true;
        }
        #endregion

    }

    void loadTime() {       //抓時間
        
        var date = System.DateTime.Now;
        if (UIManager.PickupNumber < 5)                               //TODO :改數量  (當日撿超過個數即不再顯示) 
        {
            var minutes = date.Minute.ToString();
            int min = int.Parse(minutes);

            if (min > 0 && min < 20)        //依時間顯示物件
            {
                if (iscreate == 1)
                {
                    Invoke("Spawnitems", 3);
                    iscreate = 0;
                }
            }
            else if (min > 20 && min < 40)
            {
                if (iscreate2 == 1)
                {
                    Invoke("Spawnitems2", 3);
                    iscreate2 = 0;
                }
            }
            else if (min > 40 && min < 60)
            {
                if (iscreate3 == 1)
                {
                    Invoke("Spawnitems3", 3);
                    iscreate3 = 0;
                }
            }
            else
            {
                iscreate = 1;
                iscreate2 = 1;
                iscreate3 = 1;
            }
        }
    }

    void Spawnitems()
    {

        for (int k = 0; k < 20; k++)     //存取陣列內容並印出來
        {
            var locationString = _locationStrings[pre[k]];
            _locations[pre[k]] = Conversions.StringToLatLon(locationString);

            var instance = Instantiate(_markerPrefab[pre2[k]]);

            instance.transform.localPosition = _map.GeoToWorldPosition(_locations[pre[k]], true);
            instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
            _spawnedObjects.Add(instance);
        }
    }


    void Spawnitems2()
    {

        for (int k = 10; k < 30; k++)     //存取陣列內容並印出來
        {
            var locationString = _locationStrings[pre[k]];
            _locations[pre[k]] = Conversions.StringToLatLon(locationString);

            var instance = Instantiate(_markerPrefab[pre2[k]]);

            instance.transform.localPosition = _map.GeoToWorldPosition(_locations[pre[k]], true);
            instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
            _spawnedObjects.Add(instance);
        }
    }


    void Spawnitems3()
    {

        for (int k = 20; k < 40; k++)     //存取陣列內容並印出來
        {
            var locationString = _locationStrings[pre[k]];
            _locations[pre[k]] = Conversions.StringToLatLon(locationString);

            var instance = Instantiate(_markerPrefab[pre2[k]]);

            instance.transform.localPosition = _map.GeoToWorldPosition(_locations[pre[k]], true);
            instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
            _spawnedObjects.Add(instance);
        }
    }

    void itemsbuttonclick()
    {
        if(landmark.isShow == 1 && iscreate4 == 1)
        {
            for (int k = 40; k < 50; k++)     //存取陣列內容並印出來
            {
                var locationString = _locationStrings[pre[k]];
                _locations[pre[k]] = Conversions.StringToLatLon(locationString);

                var instance = Instantiate(_markerPrefab[pre2[k]]);

                instance.transform.localPosition = _map.GeoToWorldPosition(_locations[pre[k]], true);
                instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
                _spawnedObjects.Add(instance);
            }
            iscreate4 = 0;
            landmark.isShow = 0;
        }
    }

}
