### 地圖顯示建築物
* `culling mask` 除了 `Path` 以外，其他都要勾選。
* `CameraMovement` 顧名思義，移動鏡頭用的。
* `DebugPathCamera` 取消勾選。

![image](https://user-images.githubusercontent.com/38349902/40708021-e4e2a638-6424-11e8-8335-f5da65bd6fe5.png)

### 選取建築物
* 新增`LabelCamera`在`MapCamera`下(直接從`InteractiveStyledVectorMap`複製過來)
* 在`Game Object Modifier`新增`HighlightModifier`,`ObjectInspector`,`ParkLayerModifier`
![image](https://user-images.githubusercontent.com/38349902/40709240-240a69e2-6428-11e8-871c-0e670d338821.png)



