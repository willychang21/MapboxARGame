### Show the building
* `culling mask` except `Path` ，others need to check。
* `CameraMovement` use for moving camera(zooming & panaling)。
* `DebugPathCamera` cacel the check。

![image](https://user-images.githubusercontent.com/38349902/40708021-e4e2a638-6424-11e8-8335-f5da65bd6fe5.png)

### Select Building

* add `PoiMarkerHelper.cs` on object(spawned by `PrefabModifier.cs`) ,it will call `selector` object 


## Bug
- [x] `InteractiveSelectionCanvas`will display in `ARCamera`
- [x] Object reference not set to an instance of an object   
      Mapbox.Examples.FeatureUiMarker.Snap () (at Assets/Mapbox/Examples/Scripts/FeatureUiMarker.cs:69)
- [x] the maker will dispaly mutipule points at the same time
- [x] the marker won't change the screenpos when zooming the map(need to check on time)
- [ ] the direction & marker will display in the beginning 


### Bug Fix
* `FeatureUiMarker.cs` Modify -> change to `PoiMarkerHelper.cs`
* add image in `selector` object 
* add new `MapCam` Tag -> doesn't work but have been solved in `PoiMarkerHelper.cs`
* add `marker.cs` to check mutipule point generate 
* change `Mapcam's projection` to `Orthographic`
* `directionsfactory.cs`code`var _directionResource = new DirectionResource(wp, RoutingProfile.Driving)`Driving change to Walking

## Enhancement
- [ ] add buttom in marker's image(decide the user's destination)
- [ ] add return `Player` position Buttom after moving `MapCamera` (reference the other ar scence)
- [ ] add map marker display animation(later)
- [ ] add landmark list(how to get the object's local position ??)
- [ ] improve the road texture

## Reference

### Issue 802
#### Interactive Map In WorldScale AR 
https://github.com/mapbox/mapbox-unity-sdk/issues/802

### Issue 827
#### DirectionsFactory missing transform
https://github.com/mapbox/mapbox-unity-sdk/issues/827

### Issue 838
#### InteractiveSelectionCanvas in wrong transform
https://github.com/mapbox/mapbox-unity-sdk/issues/838

### Issue 844
#### How can I find a 3D POI Marker's longitude and latitude?
https://github.com/mapbox/mapbox-unity-sdk/issues/844

### Issue 861
#### FeatureUiMarker.cs problem
https://github.com/mapbox/mapbox-unity-sdk/issues/861

### Issue 885
#### Direction will ignore footprint 
https://github.com/mapbox/mapbox-unity-sdk/issues/885

### Issue 931
#### Arrow road in AR problem 
https://github.com/mapbox/mapbox-unity-sdk/issues/931
 


                
                  



