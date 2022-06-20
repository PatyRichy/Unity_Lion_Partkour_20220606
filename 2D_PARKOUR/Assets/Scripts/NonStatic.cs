using UnityEngine;


namespace Pat
{
    //非靜態 API

    public class NonStatic : MonoBehaviour
    {
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform turtle_tr;
        

        void Start()
        {
            print("忍者龜的啟動狀態： " + turtle.activeInHierarchy);
            print("忍者龜預設圖層： " + turtle.layer);


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
