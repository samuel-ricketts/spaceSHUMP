/**** 
 * Created by: Sammy Ricketts
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Sammy Ricketts
 * Last Edited: April 6, 2022
 * 
 * Description: Returns objects back to pool
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL;
        
    }

    // Update is called once per frame
    private void OnDisable()
    {
        if (pool != null)
        {
            pool.ReturnObjects(this.gameObject);
        }
    }
}
