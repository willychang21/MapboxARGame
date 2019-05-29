using Mapbox.Directions;
using Mapbox.Geocoding;
using Mapbox.Json;
using Mapbox.Unity;
using Mapbox.Unity.Location;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using Mapbox.Utils.JsonConverters;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class time_dis : MonoBehaviour {

    [SerializeField]
    Text _resultsText;

    [SerializeField]
    Text desname;

    Directions _directions;

    Vector2d[] _coordinates;

    DirectionResource _directionResource;

    private CultureInfo _invariantCulture = CultureInfo.InvariantCulture;

    public static string _dnameforglobal; //全域給其他script改目的地用
    string _dnameforlocal;

   
    void Update()
    {
        if(_dnameforglobal != null)
        {
           // Debug.Log("目的地存在");
            if(_dnameforglobal != _dnameforlocal)
            {
             //   Debug.Log("目的地已改變");
                _dnameforlocal = _dnameforglobal;
                desname.text = "目的地 : "+ _dnameforlocal;
                StartCoroutine(QueryTimer());
            }
        }
        else
        {
            desname.text = "白癡喔你還沒選啦";
            _resultsText.text = "沒時間沒距離";
        }
        
    }

    public IEnumerator QueryTimer()
    {
        while (true)
        {
            TimeDistance();
            Debug.Log("測試計時器");
            yield return new WaitForSeconds(5);
        }
    }

        void TimeDistance()
    {
        _directions = MapboxAccess.Instance.Directions;

        _coordinates = new Vector2d[2];

        _directionResource = new DirectionResource(_coordinates, RoutingProfile.Walking);
        _directionResource.Steps = true;

        _coordinates[0] = user_loc._userloc;
        switch (_dnameforlocal)
        {
            #region 主要大樓
            case "國璽樓(MD)":
                _coordinates[1] = Conversions.StringToLatLon("25.0386,121.431261");
                break;
            case "倬章樓(DG)":
                _coordinates[1] = Conversions.StringToLatLon("25.038228,121.431186");
                break;
            case "進修部大樓(ES)":
                _coordinates[1] = Conversions.StringToLatLon("25.037726,121.430395");
                break;
            case "積健樓(LP)":
                _coordinates[1] = Conversions.StringToLatLon("25.037832,121.432627");
                break;
            case "利瑪竇大樓(LM)":
                _coordinates[1] = Conversions.StringToLatLon("25.037315,121.431348");
                break;
            case "伯達樓(BS)":
                _coordinates[1] = Conversions.StringToLatLon("25.036858,121.431713");
                break;
            case "羅耀拉大樓(SL)":
                _coordinates[1] = Conversions.StringToLatLon("25.036418,121.430858");
                break;
            case "樹德樓(LW)":
                _coordinates[1] = Conversions.StringToLatLon("25.036386,121.431684");
                break;
            case "文開樓(LE)":
                _coordinates[1] = Conversions.StringToLatLon("25.037226,121.433736");
                break;
            case "文友樓(LF)":
                _coordinates[1] = Conversions.StringToLatLon("25.036873,121.4337");
                break;
            case "文華樓(LI)":
                _coordinates[1] = Conversions.StringToLatLon("25.036425,121.433644");
                break;
            case "藝術學院(AG)":
                _coordinates[1] = Conversions.StringToLatLon("25.036506,121.435094");
                break;
            case "聖言樓(SF)":
                _coordinates[1] = Conversions.StringToLatLon("25.035491,121.431641");
                break;
            case "外語學院(FG,AV,LA,LB)":
                _coordinates[1] = Conversions.StringToLatLon("25.034853,121.432382");
                break;
            case "理工綜合教室(LH)":
                _coordinates[1] = Conversions.StringToLatLon("25.034254,121.432002");
                break;
            case "耕莘樓(A)":
                _coordinates[1] = Conversions.StringToLatLon("25.0337,121.433278");
                break;
            case "朝橒樓(TC)":
                _coordinates[1] = Conversions.StringToLatLon("25.035232,121.433521");
                break;
            case "秉雅樓(NF)":
                _coordinates[1] = Conversions.StringToLatLon("25.035479,121.434237");
                break;
            case "舒德樓":
                _coordinates[1] = Conversions.StringToLatLon("25.033958,121.434072");
                break;
            case "野聲樓(YP)":
                _coordinates[1] = Conversions.StringToLatLon("25.033348,121.434593");
                break;
            #endregion
            #region 特殊景點
            case "中美堂":
                _coordinates[1] = Conversions.StringToLatLon("25.03814,121.431889");
                break;
            case "淨心堂":
                _coordinates[1] = Conversions.StringToLatLon("25.035893,121.432332");
                break;
            case "情人坡":
                _coordinates[1] = Conversions.StringToLatLon("25.034759,121.431549");
                break;
            case "食科冰淇淋":
                _coordinates[1] = Conversions.StringToLatLon("25.034631,121.434518");
                break;
            case "真善美聖":
                _coordinates[1] = Conversions.StringToLatLon("25.032916,121.434046");
                break;
            #endregion
            #region 餐廳
            case "心園":
                _coordinates[1] = Conversions.StringToLatLon("25.036877,121.429806");
                break;
            case "仁園":
                _coordinates[1] = Conversions.StringToLatLon("25.03636,121.429709");
                break;
            case "理園":
                _coordinates[1] = Conversions.StringToLatLon("25.035401,121.430849");
                break;
            case "文園":
                _coordinates[1] = Conversions.StringToLatLon("25.037108,121.433175");
                break;
            case "輔園":
                _coordinates[1] = Conversions.StringToLatLon("25.034355,121.434209");
                break;
            #endregion
            #region 圖書館
            case "濟時樓圖書館":
                _coordinates[1] = Conversions.StringToLatLon("25.035943,121.430172");
                break;
            case "國璽樓圖書館":
                _coordinates[1] = Conversions.StringToLatLon("25.038886,121.43128");
                break;
            case "公博樓圖書館":
                _coordinates[1] = Conversions.StringToLatLon("25.036455,121.434507");
                break;
                #endregion
        }
        Route();
    }
    void Route()
    {
        _directionResource.Coordinates = _coordinates;
        _directions.Query(_directionResource, HandleDirectionsResponse);
    }

    void HandleDirectionsResponse(DirectionsResponse res)
    {
        var data = JsonConvert.SerializeObject(res, Formatting.Indented, JsonConverters.Converters);
        string sub = data.Substring(0, data.Length > 5000 ? data.Length : data.Length) + "\n. . . ";
        int summary_index;
        string _summary;

        summary_index = sub.IndexOf("summary");
        _summary = sub.Substring(summary_index + 10, 60);

        int duration_index;
        int distance_index;
        string _duration;
        string _distance;

        duration_index = _summary.IndexOf("duration");
        distance_index = _summary.IndexOf("distance");
        _duration = _summary.Substring(duration_index+10 , 4);
        _distance = _summary.Substring(distance_index+10 , 4);

        int _durationnum;
        _durationnum = int.Parse(_duration);
        _durationnum = _durationnum / 60;
        _duration = _durationnum.ToString();
       
        _resultsText.text =  "時間: "+ _duration +" mins(分鐘)" + "\n"+ "距離:"+ _distance +" m(公尺)"  ;
    }


}
