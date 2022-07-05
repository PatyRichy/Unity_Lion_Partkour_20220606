using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ManageF : MonoBehaviour
{
    [SerializeField, Header("�e��")]
    private CanvasGroup groupFinal;
    [SerializeField, Header("�C���������D")]
    private TextMeshProUGUI textFinal;


    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// �H�J
    /// </summary>

    private void FadeIn()
    {
        groupFinal.alpha += 0.1f;
        print("�H�J");
        if (groupFinal.alpha >= 1)
        {
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
            CancelInvoke("FadeIn");
        }
    }

    /// <summary>
    /// �C���������D����r���e
    /// </summary>
    public string stringTitle;
    void Start()
    {
        

    textFinal.text = stringTitle;
        // MonoBehaviour ���O API �i�H�����ϥΦW�٩I�s
        InvokeRepeating("FadeIn", 0, 0.1f);
    }
    
    public void Replay()
    {
        SceneManager.LoadScene("�C������");
    }
   
}
