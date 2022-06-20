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
        private bool groundcheck;
        [SerializeField]
        private GameObject turtle;
        #endregion

        #region 功能： 實作該系統的複雜方法

        /// <summary>
        /// 跳躍功能
        /// </summary>
        /// 

        void OnCollisionExit2D(Collision2D selfbodyexit)
        {
            if (turtle.gameObject.tag == "ground")
                groundcheck = false;
        }
        private void groundClick()
        {
            if (turtle.gameObject.tag == "ground") 
            {

                groundcheck = true;
            }

        }
        private void JumpClick()
        {

            
             if (Input.GetKeyDown(KeyCode.UpArrow) && groundcheck)
                {

                    clickjump = true;
                }
                
            

        }

        private void Jump()
        {
            if (clickjump)
            {
                rig.AddForce(new Vector2(0 , heightJump));
                clickjump = false;
                groundcheck = false;
            }
        }
        #endregion

        #region 事件：程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            



        }

        private void FixedUpdate()
        {
            groundClick();
                Jump();
            
        }

        private void Update()
        {
            JumpClick();
        }
        #endregion
    }

}
