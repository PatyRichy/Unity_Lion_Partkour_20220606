using UnityEngine;

namespace Pat
{

    

    
    public class SystemJump : MonoBehaviour
    {
       
       


        #region 資料：保存系統需要的資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;
        private bool isground;
        private AudioSource aud;

        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 00.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;

        #endregion

        #region 功能： 實作該系統的複雜方法


        //繪製圖示
        //編輯器內輔助用線條，形狀，遊戲內不會出現

        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color = colorCheckGround;
            //2.繪製圖示
            //transform.position 當前物件坐標
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        /// <summary>
        /// 跳躍功能
        /// </summary>
        /// 



        private void JumpClick()
        { 

            
             if (Input.GetKeyDown(KeyCode.UpArrow) )
                {

                    clickjump = true;
                }
                
            

        }

        private void Jump()
        {
            if (clickjump && isground)
            {
                rig.AddForce(new Vector2(0 , heightJump));
                clickjump = false;
                aud.PlayOneShot(soundJump,1);
     
            }
        }

        /// <summary>
        /// 檢查是否碰到地板
        /// </summary>
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            isground = hit;
        }
        #endregion

        #region 事件：程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }

        private void Start()
        {

          


        }
        
        
        private void Update()
        {
            JumpClick();
            CheckGround();
        }


        private void FixedUpdate()
        {


       

            Jump();
            
        }

       
        #endregion
    }

}
