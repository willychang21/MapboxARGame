using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterWander : MonoBehaviour
{

    private GameObject playerUnit;          //獲取玩家單位
    private Animator thisAnimator;          //自身動畫組件
    private Vector3 initialPosition;            //初始位置

    public float wanderRadius;          //遊走半徑，移動狀態下，如果超出遊走半徑會返回出生位置
    public float alertRadius;         //警戒半徑，玩家進入後怪物會發出警告，並一直面朝玩家
    public float defendRadius;          //自衛半徑，玩家進入後怪物會追擊玩家，當距離<攻擊距離則會發動攻擊（或者觸發戰鬥）
    public float chaseRadius;            //追擊半徑，當怪物超出追擊半徑後會放棄追擊，返回追擊起始位置

    public float attackRange;            //攻擊距離
    public float walkSpeed;          //移動速度
    public float runSpeed;          //跑動速度
    public float turnSpeed;         //轉身速度，建議0.1

    private enum MonsterState
    {     
        WALK,       //移動
        CHASE,      //追擊玩家
        RETURN      //超出追擊範圍後返回
    }
    private MonsterState currentState = MonsterState.WALK;          

   
    public float actRestTme;            //更換待機指令的間隔時間
    private float lastActTime;          //最近一次指令時間

    private float diatanceToPlayer;         //怪物與玩家的距離
    private float diatanceToInitial;         //怪物與初始位置的距離
    private Quaternion targetRotation;         //怪物的目標朝向

    private bool is_Warned = false;
    private bool is_Running = false;

    void Start()
    {
        playerUnit = GameObject.FindGameObjectWithTag("Player");
       

        //保存初始位置信息
        initialPosition = gameObject.GetComponent<Transform>().localPosition;

        //檢查並修正怪物設置
        //1. 自衛半徑不大於警戒半徑，否則就無法觸發警戒狀態，直接開始追擊了
        defendRadius = Mathf.Min(alertRadius, defendRadius);
        //2. 攻擊距離不大於自衛半徑，否則就無法觸發追擊狀態，直接開始戰鬥了
        attackRange = Mathf.Min(defendRadius, attackRange);
        //3. 遊走半徑不大於追擊半徑，否則怪物可能剛剛開始追擊就返回出生點
        wanderRadius = Mathf.Min(chaseRadius, wanderRadius);

        //隨機一個待機動作
        WalkAction();
    }

    /// <summary>
    /// 根據權重隨機待機指令
    /// </summary>
    void WalkAction()
    {
        //更新行動時間
        lastActTime = Time.time;
        //根據權重隨機
        
            currentState = MonsterState.WALK;
            //隨機一個朝向
            targetRotation = Quaternion.Euler(0, Random.Range(1, 5) * 90, 0);
           
        
    }

    void Update()
    {
        switch (currentState)
        {
            

            //遊走，根據狀態隨機時生成的目標位置修改朝向，並向前移動
            case MonsterState.WALK:
                transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
                transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, turnSpeed);

                if (Time.time - lastActTime > actRestTme)
                {
                    WalkAction();         //隨機切換指令
                }
                //該狀態下的檢測指令
                WanderRadiusCheck();
                break;


            //追擊狀態，朝著玩家跑去
            case MonsterState.CHASE:
                if (!is_Running)
                {                    
                    is_Running = true;
                }
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
                //朝向玩家位置
                targetRotation = Quaternion.LookRotation(playerUnit.transform.position - transform.position, Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed);
                //該狀態下的檢測指令
                ChaseRadiusCheck();
                break;

            //返回狀態，超出追擊範圍後返回出生位置
            case MonsterState.RETURN:
                //朝向初始位置移動
                targetRotation = Quaternion.LookRotation(initialPosition - transform.position, Vector3.up);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, turnSpeed);
                transform.Translate(Vector3.forward * Time.deltaTime * runSpeed);
                //該狀態下的檢測指令
                Debug.Log("我回家");
                ReturnCheck();
                break;
        }
    }

 

   
    

    /// <summary>
    /// 遊走狀態檢測，檢測敵人距離及遊走是否越界
    /// </summary>
    void WanderRadiusCheck()
    {
        diatanceToPlayer = Vector3.Distance(playerUnit.transform.localPosition, transform.localPosition);
        diatanceToInitial = Vector3.Distance(transform.localPosition, initialPosition);

        if (diatanceToPlayer < attackRange)
        {
            Debug.Log("BATTLE");
        }
        else if (diatanceToPlayer < defendRadius)
        {
            currentState = MonsterState.CHASE;
        }
        

        if (diatanceToInitial > wanderRadius)
        {
            //朝向調整為初始方向
            targetRotation = Quaternion.LookRotation(initialPosition - transform.localPosition, Vector3.up);
        }
    }

    /// <summary>
    /// 追擊狀態檢測，檢測敵人是否進入攻擊範圍以及是否離開警戒範圍
    /// </summary>
    void ChaseRadiusCheck()
    {
        diatanceToPlayer = Vector3.Distance(playerUnit.transform.localPosition, transform.localPosition);
        diatanceToInitial = Vector3.Distance(transform.localPosition, initialPosition);

        if (diatanceToPlayer < attackRange)
        {
            Debug.Log("BATTLE");
        }
        //如果超出追擊範圍或者敵人的距離超出警戒距離就返回
        if (diatanceToInitial > chaseRadius || diatanceToPlayer > alertRadius)
        {
            currentState = MonsterState.RETURN;
        }
    }

    /// <summary>
    /// 超出追擊半徑，返回狀態的檢測，不再檢測敵人距離
    /// </summary>
    void ReturnCheck()
    {
        diatanceToInitial = Vector3.Distance(transform.localPosition, initialPosition);

        //如果已經接近初始位置，則隨機一個待機狀態
        
            is_Running = false;
            WalkAction();
            Debug.Log("123124324324");
        
    }

}
