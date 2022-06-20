using UnityEngine; 

namespace Pat
{



    public class SystemRun : MonoBehaviour
    {
        #region 資料：保存系統需要的資料
        [SerializeField, Header("跑速") , Range(0,10)]
        private float speedRun = 3f;
      
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 功能： 實作該系統的複雜方法

        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            rig.velocity = new Vector2(speedRun, rig.velocity.y);

        }
        private void Run_b()
        {
            rig.velocity = new Vector2(-speedRun, rig.velocity.y);

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
            //print("hihihi");

          

        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
                Run();
            if (Input.GetKey(KeyCode.LeftArrow))
                Run_b();
          
            //print("<color=aqua> hi </color>" );
        }
        #endregion
    }

}
