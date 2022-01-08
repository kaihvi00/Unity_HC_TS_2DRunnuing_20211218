using UnityEngine; // 引用Unity 引擎 讓我們可以使用 API

// 類別 類別名稱 需大小寫一致
public class Car : MonoBehaviour
{
    //此類別內容

    #region 欄位 Field
    // ※ 欄位語法
    // 資料類型 欄位名稱 指定預設值 結尾
    // ※四大常用資料類型
    // 整  數 ing
    // 浮點數 float
    // 字  串 string
    // 布林值 bool
    // ※修飾詞
    // 私人：不給外部類別存取，不顯示 private
    // 公開：允許外部類別存取，顯示　 bublic
    public int cc = 1000; 
    public float weight = 3.5f;     // s結尾F/f
    public string brand = "賓士";   // "" 雙引號
    public bool hsaWindow = true;   // true/false s

    // *Unity內常用資料類型
    // 顏色 Color
    public Color ColorA; 
    public Color rde = Color.red; //指定
    public Color ColorB = new Color(0.8f, 1, 0.9f, 0.8f);  // +nwe R,G,B,透明度 數字0~1

    // 向量 Vector 2 ~ 4
    // 座標 X平行 Y垂直 
    public Vector2 vector2; //不指定
    public Vector2 v2Right = Vector2.right; //指定預設
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2One = Vector2.one;
    public Vector2 vector2A = new Vector2(3.5f, 9.5f); //新增新座標


    #endregion
}

//非類別類內容