
using UnityEngine;

namespace Pat
{
    /// <summary>
    /// 管理死亡
    /// </summary>

    public class ManageD : MonoBehaviour
    {

        private AudioSource audd;
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "frog1";
        [SerializeField, Header("結束管理器")]
        private ManageF managerFinal;
        [SerializeField, Header("CM攝影機控制物件")]
        private GameObject goCM;
        [SerializeField, Header("死亡音效")]
        private AudioClip soundDead;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                managerFinal.stringTitle = "Gameover";
                managerFinal.enabled = true;
                goCM.SetActive(false);
                audd.PlayOneShot(soundDead, 1);
            }

        }
        private void Awake()
        {
            
            audd = GetComponent<AudioSource>();
        }
    }
}
