
using UnityEngine;

public class API : MonoBehaviour
{
    private Vector3 a = new Vector3(1, 1, 1);
    private Vector3 b = new Vector3(22, 22, 22);

    // Start is called before the first frame update
    private void Start()
    {
        print("�Ҧ���v���ƶq�G " + Camera.allCamerasCount);
        print("�ثe���x�G " + Application.platform);
        Physics.sleepThreshold = 10;
        print("�ίv�{�ɭȡG " + Physics.sleepThreshold);
        Time.timeScale = 0.5f;
        print("�ɶ��j�p�G " + Time.timeScale);

        print("9.999 �h���p���I" + Mathf.Round(9.999f));

        float distance = Vector3.Distance(a, b);
        print("<color=yellow>�Z���G " + distance + "</color>");
        Application.OpenURL("https://unity.com/");

    }
    private void Update()
    {
        print("�O�_���U���N��G " + Input.anyKey);
        print("�C���g�L�ɶ��G " + Time.timeSinceLevelLoad);

        print("<color=red>�O�_���U�ť���G " + Input.GetKeyDown(KeyCode.Space) + "</color>");

    }


}
