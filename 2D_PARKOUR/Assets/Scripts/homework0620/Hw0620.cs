using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hw0620 : MonoBehaviour
{

    public GameObject sphere;
    public SphereCollider spherecollide;
    public Camera cam;
    public GameObject capsule;
    public GameObject cube;
    private Transform sphereRotate;

    // Start is called before the first frame update
    void Start()
    {
        //習題1：取得攝影機深度
        print("攝影機的深度是： " + Camera.main.depth);

        //習題2： 取得球體碰撞器半徑
        print("球體碰撞器半徑是： " + spherecollide.radius);

        //習題3： 攝影機的背景顏色指定為隨機顏色
        cam.backgroundColor = Random.ColorHSV();
        print("攝影機的背景顏色為： " + cam.backgroundColor);

        //習題4： 膠囊體尺寸改為 3, 2, 1

        
        capsule.transform.localScale = new Vector3(3, 2, 1);





    }


    void Update()
    {
        //習題5：讓立方體看著球體旋轉

        sphereRotate.RotateAround(sphere.transform.position, Vector3.up, 100 * Time.deltaTime);
        cube.transform.LookAt(sphere.transform.position, Vector3.right);
    }
}
