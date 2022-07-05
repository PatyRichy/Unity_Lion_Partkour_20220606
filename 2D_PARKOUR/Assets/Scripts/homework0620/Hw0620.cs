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
        //���D1�G���o��v���`��
        print("��v�����`�׬O�G " + Camera.main.depth);

        //���D2�G ���o�y��I�����b�|
        print("�y��I�����b�|�O�G " + spherecollide.radius);

        //���D3�G ��v�����I���C����w���H���C��
        cam.backgroundColor = Random.ColorHSV();
        print("��v�����I���C�⬰�G " + cam.backgroundColor);

        //���D4�G ���n��ؤo�אּ 3, 2, 1

        
        capsule.transform.localScale = new Vector3(3, 2, 1);





    }


    void Update()
    {
        //���D5�G���ߤ���ݵ۲y�����

        sphereRotate.RotateAround(sphere.transform.position, Vector3.up, 100 * Time.deltaTime);
        cube.transform.LookAt(sphere.transform.position, Vector3.right);
    }
}
