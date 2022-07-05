using UnityEngine;

namespace Pat
{
    public class Manage : MonoBehaviour
    {

        [SerializeField, Header("目標名稱")]
        private string nameTarget = "frog1";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump SystemJump;
        [SerializeField, Header("結束管理器")]
        private ManageF managerFinal;
        /// <summary>
        /// 管理結束畫面 過關與失敗
        /// </summary>
        /// 


        private void OnTriggerEnter2D(Collider2D collision)
        {

            print(collision.name);
            if (collision.name.Contains(nameTarget))
            {

                systemRun.enabled = false;
                SystemJump.enabled = false;
                managerFinal.enabled = true;
                managerFinal.stringTitle = "恭喜你過關~";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {

        }
        private void OnTriggerStay2D(Collider2D collision)
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {

        }

       
    }
}