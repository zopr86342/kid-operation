
using UnityEngine;

public class Learnrrayperation : MonoBehaviour {
    public int studentA = 10;
    public int studentB = 20;
    public int studentC = 30;
    //陣列
    public int[] student = { 10, 20, 30 };
    // Use this for initialization
    void Start () {
        //取得陣列資料
        Debug.Log(student[1]);
        //存入陣列資料
        student[1] = 25;
        //陣列數量(長度)
        Debug.Log("學生陣列的長度:" + student.Length);
        //數學運算子
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        //比較運算子(結果都是布林值)
        Debug.Log(10 > 3); //t
        Debug.Log(10 < 3); //f
        Debug.Log(10 == 3); //f
        Debug.Log(10 >= 3); //t
        Debug.Log(10 <= 3);  //f
        Debug.Log(10 != 3); //不等於 t

        //當 () 內為 true 執行
        if (student[2] >= 60)
        {
            Debug.Log("你真棒~");
        }
        else if (student[2] >= 50)
        {
            Debug.Log("補考ㄅ廢物");
        }
        else if (student[2] >= 40)
        {
            Debug.Log("下學期繳錢再會");
        }

        else
	    {
            Debug.Log("廢物");
        }




    }

    // Update is called once per frame
    void Update () {
        //兩個都可用
        //Debug.Log(Input.GetKeyDown("Space"));
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
    }
}
