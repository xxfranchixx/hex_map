using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour{

    public GameObject hexPrefab;

//size of the map in terms of number of hex tiles
//this is not representative of the amount of
//world space that we're going to take up.
//(i.e. our tiles might be more or less than 1 unity world unit)
int width = 20;
int height = 20;

float xOffset = 0.882f;
float zOffsett = 0.764f;

    // use this for initialization
    void Start(){

        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){

                float xPos = x * xOffset;
                
                //Are we on an odd row?
                if( y % 2 == 1 ){
                    xPos += xOffset/2f;
                }

                Instantiate(hexPrefab, new Vector3( xPos,0, y * zOffsett ), Quaternion.identity );
                
            }
            
        }
    }

    // Update is called once per frame
    void Update(){

        
    }
}
