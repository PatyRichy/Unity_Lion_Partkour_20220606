using UnityEngine;

namespace Pat
{
    public class Manage : MonoBehaviour
    {

        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "frog1";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump SystemJump;
        [SerializeField, Header("�����޲z��")]
        private ManageF managerFinal;
        /// <summary>
        /// �޲z�����e�� �L���P����
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
                managerFinal.stringTitle = "���ߧA�L��~";
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