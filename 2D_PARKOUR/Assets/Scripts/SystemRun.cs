using UnityEngine; 

namespace Pat
{



    public class SystemRun : MonoBehaviour
    {
        #region 資料：保存系統需要的資料
        [SerializeField, Header("跑速") , Range(0,10)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Range(0,1000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region 功能： 實作該系統的複雜方法

        #endregion

        #region 事件：程式入口

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Start()
        {
            print("hihihi");
        }

        private void Update()
        {
            print("<color=aqua> hi </color>" );
        }
        #endregion
    }

}
