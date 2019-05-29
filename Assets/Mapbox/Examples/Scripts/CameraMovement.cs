namespace Mapbox.Examples
{
	using UnityEngine;
	using UnityEngine.EventSystems;
	using Mapbox.Unity.Map;
    using System.Collections;

    public class CameraMovement : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		float _panSpeed = 1f;

		[SerializeField]
		float _zoomSpeed = 1f;

        [SerializeField]
        Camera _camera;

        [SerializeField]
        Transform _orient;

		Quaternion _originalRotation;
		Vector3 _origin;
		Vector3 _delta;
		bool _shouldDrag;
        public static bool updatecamerapos ;

        void HandleTouch()
		{
			float zoomFactor = 0.0f;
            //pinch to zoom. 
            switch (Input.touchCount)
			{
				case 1:
					{
						HandleMouseAndKeyBoard();
					}
					break;
				case 2:
					{
						// Store both touches.
						Touch touchZero = Input.GetTouch(0);
						Touch touchOne = Input.GetTouch(1);

						// Find the position in the previous frame of each touch.
						Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
						Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

						// Find the magnitude of the vector (the distance) between the touches in each frame.
						float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
						float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

						// Find the difference in the distances between each frame.
						zoomFactor = 0.05f * (touchDeltaMag - prevTouchDeltaMag);
					}
					ZoomMapUsingTouchOrMouse(zoomFactor);
					break;
				default:
					break;
			}
		}

		void ZoomMapUsingTouchOrMouse(float zoomFactor)
		{
			var y = zoomFactor * _zoomSpeed;
			transform.localPosition += (transform.forward * y);
		}

		void HandleMouseAndKeyBoard()
		{
			if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
			{
                
                if(_camera.isActiveAndEnabled)
                {
                    var mousePosition = Input.mousePosition;
                    mousePosition.z = _camera.transform.localPosition.y;
                    _delta = _camera.ScreenToWorldPoint(mousePosition) - _camera.transform.localPosition;
                    _delta.y = 0f;
                    if (_shouldDrag == false)
                    {
                        _shouldDrag = true;
                        _origin = _camera.ScreenToWorldPoint(mousePosition);
                    }
                }
			}
			else
			{
				_shouldDrag = false;
			}

			if (_shouldDrag == true)
			{
				var offset = _origin - _delta;
				offset.y = transform.localPosition.y;
				transform.localPosition = offset;
			}
			else
			{
				if (EventSystem.current.IsPointerOverGameObject())
				{
					return;
				}

				var x = Input.GetAxis("Horizontal");
				var z = Input.GetAxis("Vertical");
				var y = Input.GetAxis("Mouse ScrollWheel") * _zoomSpeed;
				transform.localPosition += transform.forward * y + (_originalRotation * new Vector3(x * _panSpeed, 0, z * _panSpeed));
				//_map.UpdateMap();
			}


		}

		void Awake()
		{
			_originalRotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
			if (_camera == null)
			{
                _camera = GetComponent<Camera>();
				if (_camera == null)
				{
					throw new System.Exception("You must have a reference camera assigned!");
				}
			}
            updatecamerapos = true;
            StartCoroutine(updatemap());
        }

        public IEnumerator updatemap()
        {
            while(true)
            {               
                if (updatecamerapos)
                {
                    gameObject.transform.position = new Vector3(ImmediatePositionWithLocationProvider.user_localpos.x, 600, ImmediatePositionWithLocationProvider.user_localpos.z);
                    //gameObject.transform.rotation = _orient.rotation;
                }
 
                yield return new WaitForSeconds(2);
            }
        }
            void LateUpdate()
		{

			if (Input.touchSupported && Input.touchCount > 0)
			{
				HandleTouch();
            }
			else
			{
				HandleMouseAndKeyBoard();
                
            }           
        }
    }
	}
