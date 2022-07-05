using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ManageF : MonoBehaviour
{
    [SerializeField, Header("畫布")]
    private CanvasGroup groupFinal;
    [SerializeField, Header("遊戲結束標題")]
    private TextMeshProUGUI textFinal;


    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// 淡入
    /// </summary>

    private void FadeIn()
    {
        groupFinal.alpha += 0.1f;
        print("淡入");
        if (groupFinal.alpha >= 1)
        {
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
            CancelInvoke("FadeIn");
        }
    }

    /// <summary>
    /// 遊戲結束標題的文字內容
    /// </summary>
    public string stringTitle;
    void Start()
    {
        

    textFinal.text = stringTitle;
        // MonoBehaviour 類別 API 可以直接使用名稱呼叫
        InvokeRepeating("FadeIn", 0, 0.1f);
    }
    
    public void Replay()
    {
        SceneManager.LoadScene("遊戲場景");
    }
   
}
