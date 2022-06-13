
using UnityEngine;

public class API : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        print(Mathf.PI);
        print(Mathf.NegativeInfinity);
        
        Physics2D.gravity =  new Vector2 (0 , 2);



        float range = Random.Range(0, 100);

        print(range);




    }

    
   
}
