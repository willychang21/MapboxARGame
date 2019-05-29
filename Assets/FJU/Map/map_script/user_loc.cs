using Mapbox.Unity.Location;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class user_loc : MonoBehaviour {

    public static Vector2d _userloc;


    [SerializeField]
    Text _statusText;

    private AbstractLocationProvider _locationProvider = null;
    void Start()
    {
        if (null == _locationProvider)
        {
             _locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
            
        }
    }


    void Update()
    {
        Location currLoc = _locationProvider.CurrentLocation;

        if (currLoc.IsLocationServiceInitializing)
        {
            _statusText.text = "location services are initializing";
        }
        else
        {
            if (!currLoc.IsLocationServiceEnabled)
            {
                //_statusText.text = "location services not enabled";
                _userloc = currLoc.LatitudeLongitude;
                _statusText.text = string.Format("{0}", currLoc.LatitudeLongitude);
            }
            else
            {
                if (currLoc.LatitudeLongitude.Equals(Vector2d.zero))
                {
                    _statusText.text = "Waiting for location ....";
                }
                else
                {
                    _userloc = currLoc.LatitudeLongitude;
                   // _statusText.text = string.Format("{0}", currLoc.LatitudeLongitude);
                }
            }
        }

    }
}



