# MapboxARGame
Using Unity/Mapbox/ARCore to develop Location Based AR Game

* 摘要
  * 隨著 Pokemon go 爆紅之後，擴增實境（Augmented Reality, AR）技術漸漸成為炙手可熱的技術，學力至上這款APP是基於地理位置服務(Location-Based Service，LBS 又稱適地性服務、移動定位服務、位置服務)並結合AR所製成的。APP取得使用者位置後，告知使用者輔大校園各個建築的所在位置以及路線導覽，讓使用者能快速了解自己想要前往之目的地的方向。使用者介面(User Interface)上結合AR，使得導覽的內容以更直觀的方式顯示在行動裝置的螢幕上，如此一來能夠避免傳統的地圖導覽時需一一對照地圖才能使用之不便，並且將操作方式簡化方便使用者作操作。開發平台上使用Untiy，並且結合Mapbox-unity-sdk，使得支援Android和iOS系統。


* 緒論
  * 前言
    * 傳統的導覽方式都是以圖文搭配地圖的方式在進行，當使用者對於地圖的使用不是很熟悉時，那麼導覽的效果將會大打折扣，甚至會造成一定程度的誤解。一般人在使用導覽時，其實最迫切需要的就是要知道自己在哪裡以及距離目的地的方向和距離，這些問題都是傳統紙圖導覽沒辦法解決的。而智慧型行動裝置在最近幾年逐漸發展，價格也逐漸落在一般民眾能夠接受的價位，因此智慧型行動裝置在一般社會的普及率逐漸提升。以智慧型手機為例，智慧型手機目前約佔了台灣手機市場的 30%，並且以每年 50%的成長率快速成長中，這僅是智慧型手機的資料，還不包含 PDA 以及平板電腦(例如 iPad、eeePad等等)。為了能讓使用者能夠充分運用導覽資料，本計畫選擇透過這些智慧型行動裝置提供具有互動性質以及即時性的導覽系統。擴增實境（Augmented Reality，簡稱 AR），是一種即時地計算攝影機影像的位置及角度並加上相應圖像的技術，這種技術的目標是在螢幕上把虛擬世界套在現實世界並進行互動，擴增實境於 1990 年提出。北卡大學 R. Azuma 於 1997 年提出擴增實境應包括三個方面的內容：虛擬物與現實結合、即時、三維(Azuma,1997)。由於擴增實境可以直接將資訊即時加在影像上，因此常被應用在導航導覽甚至娛樂上。本計畫也將使用擴增實境技術，直接將導覽資訊顯示在智慧型行動裝置上，使得導覽系統易於使用。但是智慧型行動裝置平台眾多，市面上常見的就有 iOS (Apple)、Android(Google)、Windows Phone (Microsoft)、BlackBerry (RIM)及 Symbian (Nokia)等(如圖1 所示)。彼此系統間互不相容，使得在開發軟體時必須依照個別系統的規格一一開發該系統的程式，造相當大的時間和人力成本。
    * 科技的發展日新月異，地圖從早期傳統的紙本：傳統的導覽方式都是以圖片和文字搭配地圖的方式在呈現，所以每當使用者對於地圖的使用不是很熟悉時，那麼導覽的功能會大大降低，甚至會造成一定程度的誤解，進而迷路等違反地圖設計之初衷的結果。其實使用者最在使用時當下最迫切需要的就是要知道自己在哪裡以及距離目的地的方向，這些問題都是傳統地圖導覽沒辦法克服級解決的。到今天，因為智慧型裝置的普及化，
  * 動機與目的
  * AR介紹
* APP說明
  * 使用之技術及語言
    * C#
  * 使用之工具
    * Unity
    * ARcore
    * ARKit
    * Mapbox studio
    * Git
    * Github
  * 功能簡介
    * 用圖講解
  * 系統架構
    ![image](https://user-images.githubusercontent.com/38349902/47492262-2bacef00-d87f-11e8-8750-39ec28a676e3.png)

      
* APP設計與實作
  * Vuforia vs ARcore  
  ![image](https://user-images.githubusercontent.com/38349902/47475190-0b643c80-d84d-11e8-8be5-9adc0e2ffdc0.png)
  ![image](https://user-images.githubusercontent.com/38349902/47475237-3cdd0800-d84d-11e8-8067-e0251f795656.png)
  

  * Mapbox React Native AR vs Mapbox Unity AR vs SceneKit AR
  * Google Map API vs Mapbox Direction API
  * Map
    * Image
    * DirectionFactory.cs
* APP成果與討論
  * 特色
* 結論
  * 總結
  * 工作分工
  * 開發心得
  * 未來展望
* 參考文獻 
  * [Embedded Virtual Views for Augmented Reality Navigation,2011](https://pdfs.semanticscholar.org/cbdb/3ee9a33331f8c4df78c355e90e640e998457.pdf)
  * [Augmented reality navigation systems,2006](https://www.researchgate.net/publication/220606626_Augmented_reality_navigation_systems)
  * [Comparative Assessment of Mobile Navigation Applications using 2D Maps and Augmented Reality Interfaces,2016](https://www.thinkmind.org/download.php?articleid=achi_2016_20_20_20279)
  http://www.tgis.org.tw/files/recruit/41_d7b0f246.pdf

  
  




