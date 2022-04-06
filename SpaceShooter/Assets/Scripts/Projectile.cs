/**** 
 * Created by: Sammy Ricketts
 * Date Created: April 6th, 2022
 * 
 * Last Edited by:  Sammy Ricketts
 * Last Edited: April 6th, 2022
 * 
 * Description: Projectile Behavior
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private BoundsCheck bndcheck;


    private void Awake()
    {
        bndcheck = GetComponent<BoundsCheck>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bndcheck.offUp)
        {
            gameObject.SetActive(false);
            bndcheck.offUp = false;

        }
    }
}
