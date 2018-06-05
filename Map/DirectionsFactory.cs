namespace Mapbox.Unity.MeshGeneration.Factories
{
	using UnityEngine;
	using Mapbox.Directions;
	using System.Collections.Generic;
	using System.Linq;
	using Mapbox.Unity.Map;
	using Data;
	using Modifiers;
	using Mapbox.Utils;
	using Mapbox.Unity.Utilities;

	public class DirectionsFactory : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map; //放置地圖

		[SerializeField]
		MeshModifier[] MeshModifiers;   //放置directionline & directionhight

		[SerializeField]
		Transform[] _waypoints;    //放置player位置 和 目的地為置

		[SerializeField]
		Material _material;   //路線材質

		[SerializeField]
		float _directionsLineWidth;  //路線寬度

		private Directions _directions;
		private int _counter;

		GameObject _directionsGO;

		protected virtual void Awake() //腳本並沒有被致能(enable)->沒被打勾，Awake函式依然會被執行
		{
			if (_map == null) //沒map
			{
				_map = FindObjectOfType<AbstractMap>(); //自動找有Abstractmap的物件
			}
			_directions = MapboxAccess.Instance.Directions; 
			_map.OnInitialized += Query;
			_map.OnUpdated += Query;
		}

		protected virtual void OnDestroy()
		{
			_map.OnInitialized -= Query;
			_map.OnUpdated -= Query;
		}

		void Query()
		{
			var count = _waypoints.Length;  //waypoint有幾個element
			var wp = new Vector2d[count];  
			for (int i = 0; i < count; i++)
			{
				wp[i] = _waypoints[i].GetGeoPosition(_map.CenterMercator, _map.WorldRelativeScale);
			}
			var _directionResource = new DirectionResource(wp, RoutingProfile.Driving);
			_directionResource.Steps = true;
			_directions.Query(_directionResource, HandleDirectionsResponse);
		}

		void HandleDirectionsResponse(DirectionsResponse response)
		{
			if (null == response.Routes || response.Routes.Count < 1)
			{
				return;
			}

			var meshData = new MeshData();
			var dat = new List<Vector3>();
			foreach (var point in response.Routes[0].Geometry)
			{
				dat.Add(Conversions.GeoToWorldPosition(point.x, point.y, _map.CenterMercator, _map.WorldRelativeScale).ToVector3xz());
			}

			var feat = new VectorFeatureUnity();
			feat.Points.Add(dat);

			foreach (MeshModifier mod in MeshModifiers.Where(x => x.Active))
			{
				var lineMod = mod as LineMeshModifier;
				if (lineMod != null)
				{
					lineMod.Width = _directionsLineWidth / _map.WorldRelativeScale;
				}
				mod.Run(feat, meshData, _map.WorldRelativeScale);
			}

			CreateGameObject(meshData);
		}

		GameObject CreateGameObject(MeshData data)
		{
			if (_directionsGO != null)
			{
				Destroy(_directionsGO);
			}
			_directionsGO = new GameObject("direction waypoint " + " entity");
			var mesh = _directionsGO.AddComponent<MeshFilter>().mesh;
			mesh.subMeshCount = data.Triangles.Count;

			mesh.SetVertices(data.Vertices);
			_counter = data.Triangles.Count;
			for (int i = 0; i < _counter; i++)
			{
				var triangle = data.Triangles[i];
				mesh.SetTriangles(triangle, i);
			}

			_counter = data.UV.Count;
			for (int i = 0; i < _counter; i++)
			{
				var uv = data.UV[i];
				mesh.SetUVs(i, uv);
			}

			mesh.RecalculateNormals();
			_directionsGO.AddComponent<MeshRenderer>().material = _material;
			return _directionsGO;
		}
	}

}
