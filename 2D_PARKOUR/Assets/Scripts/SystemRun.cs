using UnityEngine; 

namespace Pat
{



    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn�����
        [SerializeField, Header("�]�t") , Range(0,10)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Range(0,1000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��G ��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�G�{���J�f

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
