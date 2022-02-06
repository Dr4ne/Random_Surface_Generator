using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public static void GrassGenerator   (Vector3 TerrainSize, 
                                        float GridSize, 
                                        GameObject Slot01, 
                                        float RandomCircleSize, 
                                        float MinSize, float MaxSize, 
                                        Transform SurfaceTransform, 
                                        float MaxSpawnAngle,
                                        bool RngRotate)

    {
        Vector3 terrainSize = TerrainSize;
        float gridSize = GridSize;
        GameObject slot01 = Slot01;
        float randomCircleSize = RandomCircleSize;
        float minSize = MinSize;
        float maxSize = MaxSize;
        float randomSize;
        float randomRotation;
        bool rngRotate = RngRotate;

        float terrainGridX = TerrainSize.x; // Mathf.Sqrt(TerrainSize.x);
        float terrainGridZ = TerrainSize.z; // Mathf.Sqrt(TerrainSize.z);
        Transform surfaceTransform = SurfaceTransform;
        Vector3 point;


        //grid generation loop
        for (float iX = -terrainSize.x / 2.0f; iX < terrainSize.x / 2.0f; iX += terrainGridX * gridSize)               
        {
            for (float iZ = -terrainSize.z / 2; iZ < terrainSize.z / 2; iZ += terrainGridZ * gridSize)
            {
                float adjustedRandomX = iX + surfaceTransform.position.x + Random.Range(-randomCircleSize, randomCircleSize);
                //float adjustedRandomX = Random.Range((iX - terrainSize.x / 2 + surfaceTransform.position.x) - randomCircleSize, (iX - terrainSize.x / 2) + randomCircleSize);
                float adjutedRandomZ = iZ + surfaceTransform.position.z + Random.Range(-randomCircleSize, randomCircleSize);
                //float adjutedRandomZ = Random.Range((iZ - terrainSize.z / 2 + surfaceTransform.position.z) - randomCircleSize, (iZ - terrainSize.z / 2) + randomCircleSize);

                point = new Vector3(adjustedRandomX, TerrainSize.y, adjutedRandomZ);
                
                RaycastHit hit;
                int layerMask = 1 << 8;
                layerMask = ~layerMask;

                if (Physics.Raycast(point, Vector3.down, out hit, Mathf.Infinity, layerMask))
                {
                    point.y -= hit.distance;
                    float groundAngle = Vector3.Angle(hit.normal, Vector3.up);

                    if (groundAngle < MaxSpawnAngle) //hit.normal.y > 0.9f) //
                    {
                        //Debug.Log(groundAngle);
                        GameObject grassObject;
                        grassObject = Instantiate(slot01, point, Quaternion.LookRotation(hit.point, hit.normal));
                       
                        randomSize = Random.Range(minSize, maxSize);
                        randomRotation = Random.Range(0, 360);
                        grassObject.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
                        if(rngRotate == true)
                        {
                            grassObject.transform.rotation = Quaternion.Euler(grassObject.transform.rotation.x, grassObject.transform.rotation.y + randomRotation, grassObject.transform.rotation.z);
                        }
                    }
                    else
                    {
                        //Debug.Log(slot01.name + " won't spawn at : " + point + " because slope angle > defined angle" );
                    }


                }
                else
                {
                    Debug.Log("Did not Hit");
                }

                
            }
            
        }
        


    }




}