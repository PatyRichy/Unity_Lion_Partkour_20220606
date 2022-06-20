
using UnityEngine;

public class API : MonoBehaviour
{
    private Vector3 a = new Vector3(1, 1, 1);
    private Vector3 b = new Vector3(22, 22, 22);

    // Start is called before the first frame update
    private void Start()
    {
        print("所有攝影機數量： " + Camera.allCamerasCount);
        print("目前平台： " + Application.platform);
        Physics.sleepThreshold = 10;
        print("睡眠臨界值： " + Physics.sleepThreshold);
        Time.timeScale = 0.5f;
        print("時間大小： " + Time.timeScale);

        print("9.999 去掉小數點" + Mathf.Round(9.999f));

        float distance = Vector3.Distance(a, b);
        print("<color=yellow>距離： " + distance + "</color>");
        Application.OpenURL("https://unity.com/");

    }
    private void Update()
    {
        print("是否按下任意鍵： " + Input.anyKey);
        print("遊戲經過時間： " + Time.timeSinceLevelLoad);

        print("<color=red>是否按下空白鍵： " + Input.GetKeyDown(KeyCode.Space) + "</color>");

    }


}
