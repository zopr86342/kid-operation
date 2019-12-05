using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour {
    private Animator ani;               //動畫元件
    private Rigidbody rig;              //鋼體元件
    [Header("走路速度"), Range(0f, 80f)]
    public float speed = 1.5f;
    [Header("動畫控制器:參數名稱")]
    public string parRun = "跑步開關";
    public string parAtk = "攻擊觸發";
    public string parDam = "受傷觸發";
    public string parDead = "死亡開關";
    [Header("旋轉速度"), Range(1f, 100f)]
    public float turn = 1.5f;
    [Header("血量"), Range(500, 1000)]
    public float hp = 500;
    public int MyProperty { get; set; } //可以取得 可以設定 
                                        //public int MyPro1{ get; } 唯讀
    public bool isAttack
    {
        get
        {
            return ani.GetCurrentAnimatorStateInfo(0).IsName("攻擊");
        }
    }
    public bool isDamage
    {
        get
        {
            return ani.GetCurrentAnimatorStateInfo(0).IsName("受傷");
        }
    }
    private void Start()
    {
       ani =  GetComponent<Animator>();  //取得元件 動畫元件欄位 = <泛型(所有的類型)>();
        rig = GetComponent<Rigidbody>(); //取得元件 鋼體元件欄位 = <泛型(所有的類型)>();
    }
    // FixeUpdate 1 格 執行 0.002 秒
    private void Update()
    {
        //判斷動畫狀態
        //print("是否為攻擊動畫" + isAttack);
        //print("是否為受傷動畫" + isDamage);
        if (isAttack || isDamage) return; //跳出
        Attack();
        Turn();
    }
    private void FixedUpdate()
    {
        if (isAttack || isDamage) return; //跳出
        Walk();
        
       
    }
    //觸發事件:遇到勾選Triggerq碰撞器時使用,碰撞器開始時執行一次
    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "陷阱")
        {
            Hurt();
        }
    }
    //定義方法
    //修飾詞 傳回類型 方法名稱 (參數){ 敘述 }
    //void 無回傳
    /// <summary>
    /// 走路
    /// </summary>
    private void Walk() {
        //動畫:跑步 - 按下前後鍵時 true
        ani.SetBool(parRun, Input.GetAxisRaw("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
        //rig.AddForce(0, 0, Input.GetAxisRaw("Vertical")*speed);                 //以世界座標移動
        //rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed);   //以區域座標移動
        //前方 transform.forward (0,0,1)
        //右方 transform.right   (1,0,0)
        //上方 transformup       (0,1,0)
        rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed + transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    private void Turn()
    {
        float x = Input.GetAxis("Mouse X");    //滑鼠左右 , 左-1 , 右1
        //print("玩家滑鼠 X" + x);
        //Time.deltaTime  一幀的時間
        transform.Rotate(0, x*turn*Time.deltaTime, 0);
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        ani.SetTrigger(parAtk);
    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {
        ani.SetTrigger(parDam);
        hp -= 50;
        if (hp <= 0) Dead();
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        ani.SetBool(parDead, true);
        // this 此腳本
        //enabled 啟動
        this.enabled = false;
    }
    // Use this for initialization
    
	// Update is called once per frame
	
}
