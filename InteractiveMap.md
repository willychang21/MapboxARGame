### 地圖顯示建築物
* `culling mask` 除了 `Path` 以外，其他都要勾選。
* `CameraMovement` 顧名思義，移動鏡頭用的。
* `DebugPathCamera` 取消勾選。

![image](https://user-images.githubusercontent.com/38349902/40708021-e4e2a638-6424-11e8-8335-f5da65bd6fe5.png)

### 選取建築物
* 新增`LabelCamera`在`MapCamera`下(直接從`InteractiveStyledVectorMap`複製過來)
* 在`Game Object Modifier`新增`HighlightModifier`,`ObjectInspector`,`ParkLayerModifier`

![image](https://user-images.githubusercontent.com/38349902/40709596-204ef448-6429-11e8-9c68-51bd2298b49c.png)

## Bug
- [ ] `InteractiveSelectionCanvas`會顯示在`ARCamera`裡
- [ ] 在Map介面選物件賄選到AR的物件

## Enhancement
- [ ] 移動`MapCamera`後，回到`Player`位置的Buttom

## Reference
### Map
https://github.com/mapbox/mapbox-unity-sdk/issues/792      
https://github.com/mapbox/mapbox-unity-sdk/pull/704  
### UI  
https://github.com/mapbox/mapbox-unity-sdk/issues/123  
https://github.com/playtradev/UI-addons-messaround?files=1
                
                  



