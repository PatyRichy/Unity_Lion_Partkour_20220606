using UnityEngine; 

namespace Pat
{



    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn�����
        [SerializeField, Header("�]�t") , Range(0,10)]
        private float speedRun = 3f;
      
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �\��G ��@�Өt�Ϊ�������k

        /// <summary>
        /// �]�B�\��
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

        #region �ƥ�G�{���J�f

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
