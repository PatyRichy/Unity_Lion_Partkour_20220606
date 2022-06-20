using UnityEngine;


namespace Pat
{
    //�D�R�A API

    public class NonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform turtle_tr;
        

        void Start()
        {
            print("�Ԫ��t���Ұʪ��A�G " + turtle.activeInHierarchy);
            print("�Ԫ��t�w�]�ϼh�G " + turtle.layer);


            turtle.tag = "Player";
            turtle.layer = 4;
            turtle_tr.position = new Vector3(-8.53f, 0.41f, 0);
        }

     
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow) == true)
                turtle_tr.Translate(-0.03f,0,0);
            if (Input.GetKey(KeyCode.RightArrow) == true)
                turtle_tr.Translate(0.03f, 0, 0);
            if (Input.GetKeyDown(KeyCode.UpArrow) == true)
                turtle_tr.Translate(0, 0.06f, 0);




        }
    }
}
