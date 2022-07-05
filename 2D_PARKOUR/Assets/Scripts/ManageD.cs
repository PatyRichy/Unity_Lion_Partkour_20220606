
using UnityEngine;

namespace Pat
{
    /// <summary>
    /// �޲z���`
    /// </summary>

    public class ManageD : MonoBehaviour
    {

        private AudioSource audd;
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "frog1";
        [SerializeField, Header("�����޲z��")]
        private ManageF managerFinal;
        [SerializeField, Header("CM��v�������")]
        private GameObject goCM;
        [SerializeField, Header("���`����")]
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
