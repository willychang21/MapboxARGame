using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backlocation : MonoBehaviour
{
    [SerializeField]
    Camera _camera;


    public void OnBtn()
    {

        if (_camera.isActiveAndEnabled)
        {
            _camera.transform.position = new Vector3(ImmediatePositionWithLocationProvider.user_localpos.x,600, ImmediatePositionWithLocationProvider.user_localpos.z);
        }
    }
}
