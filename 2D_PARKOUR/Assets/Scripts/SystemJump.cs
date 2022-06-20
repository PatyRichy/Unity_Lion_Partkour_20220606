using UnityEngine;

namespace Pat
{



    public class SystemJump : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn�����
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;
        private bool groundcheck;
        [SerializeField]
        private GameObject turtle;
        #endregion

        #region �\��G ��@�Өt�Ϊ�������k

        /// <summary>
        /// ���D�\��
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

        #region �ƥ�G�{���J�f

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
