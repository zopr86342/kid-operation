
using UnityEngine;

public class LearnCSharp : MonoBehaviour {
    [Header("分數"), Tooltip("拉拉拉拉拉")]  //tooltip是用來放長一點的解釋詞醬
    [Range(0 , 100)]   //只可用在整數與浮點數
    public int score = 10;  //修飾詞 欄位類型 欄位名稱 (指定 值)
    public Vector2 v2 = new Vector2(1, 10);  // X , Y 2軸
    public Vector3 v3 = new Vector3(1,5,10);  // X , Y , Z 3軸
    public Color yellow = Color.yellow;  //顏色
    public Color red = new Color(1, 2, 3);
    public AudioClip sound;  //音樂片段 音樂片段到座標位置這裡,除非屬性和他們一樣不然無法放置
    public Camera cam;       //相機
    public Light lit;        //燈光
    public Transform camPos; //座標位置
    public GameObject obj;   //遊戲內物件,基本上unity上的東西都可放進來
    public Debug deb;        //這個為錯誤寫法,他是屬於靜態類別(Static),無法宣告為欄位,直接在start中宣告就行


    private void Start()
    {
        //非靜態類別
        //Camera depht = 10.5f;  //錯誤寫法
        cam.depth = 10.5f;       //正確寫法
        //靜態類別
        Debug.Log("123");        //正確寫法
    }

}
