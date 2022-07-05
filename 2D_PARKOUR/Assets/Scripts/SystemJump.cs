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
        private bool isground;
        private AudioSource aud;

        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 00.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;

        #endregion

        #region �\��G ��@�Өt�Ϊ�������k


        //ø�s�ϥ�
        //�s�边�����U�νu���A�Ϊ��A�C�������|�X�{

        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color = colorCheckGround;
            //2.ø�s�ϥ�
            //transform.position ��e���󧤼�
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        /// <summary>
        /// ���D�\��
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
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            isground = hit;
        }
        #endregion

        #region �ƥ�G�{���J�f

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
