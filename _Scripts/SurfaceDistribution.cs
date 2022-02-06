using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceDistribution : MonoBehaviour
{
    private Vector3 terrainSize;
    Transform SurfaceTransform;

    [Header("Slot 01")]
    public bool isActive01;
    public GameObject slot01;
    [Range(0.0001f, 2f)]
    public float gridSize01 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize01 = 1;
    public float slot01MinSize = 0.5f;
    public float slot01MaxSize = 1.5f;
    public bool RandomRotateS01 = false;
    public float MaxSpawnAngle01 = 15;

    [Header("Slot 02")]
    public bool isActive02;
    public GameObject slot02;
    [Range(0.0001f, 2f)]
    public float gridSize02 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize02 = 1;
    public float slot02MinSize = 0.5f;
    public float slot02MaxSize = 1.5f;
    public bool RandomRotateS02 = false;
    public float MaxSpawnAngle02 = 15;

    [Header("Slot 03")]
    public bool isActive03;
    public GameObject slot03;
    [Range(0.0001f, 2f)]
    public float gridSize03 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize03 = 1;
    public float slot03MinSize = 0.5f;
    public float slot03MaxSize = 1.5f;
    public bool RandomRotateS03 = false;
    public float MaxSpawnAngle03 = 15;

    [Header("Slot 04")]
    public bool isActive04;
    public GameObject slot04;
    [Range(0.0001f, 2f)]
    public float gridSize04 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize04 = 1;
    public float slot04MinSize = 0.5f;
    public float slot04MaxSize = 1.5f;
    public bool RandomRotateS04 = false;
    public float MaxSpawnAngle04 = 15;

    [Header("Slot 05")]
    public bool isActive05;
    public GameObject slot05;
    [Range(0.0001f, 2f)]
    public float gridSize05 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize05 = 1;
    public float slot05MinSize = 0.5f;
    public float slot05MaxSize = 1.5f;
    public bool RandomRotateS05 = false;
    public float MaxSpawnAngle05 = 15;

    [Header("Slot 06")]
    public bool isActive06;
    public GameObject slot06;
    [Range(0.0001f, 2f)]
    public float gridSize06 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize06 = 1;
    public float slot06MinSize = 0.5f;
    public float slot06MaxSize = 1.5f;
    public bool RandomRotateS06 = false;
    public float MaxSpawnAngle06 = 15;

    [Header("Slot 07")]
    public bool isActive07;
    public GameObject slot07;
    [Range(0.0001f, 2f)]
    public float gridSize07 = Mathf.Clamp(1f, 0.0001f, 2f);
    public float randomCircleSize07 = 1;
    public float slot07MinSize = 0.5f;
    public float slot07MaxSize = 1.5f;
    public bool RandomRotateS07 = false;
    public float MaxSpawnAngle07 = 15;


    void Awake()
    {
        terrainSize = GetComponent<Collider>().bounds.size;
        SurfaceTransform = GetComponent<Transform>();
    }
    

    void Start()
    {
        if (slot01 != null && isActive01 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize01, slot01, randomCircleSize01, slot01MinSize, slot01MaxSize, SurfaceTransform, MaxSpawnAngle01, RandomRotateS01);
        }
        if (slot02 != null && isActive02 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize02, slot02, randomCircleSize02, slot02MinSize, slot02MaxSize, SurfaceTransform, MaxSpawnAngle02, RandomRotateS02);
        }
        if (slot03 != null && isActive03 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize03, slot03, randomCircleSize03, slot03MinSize, slot03MaxSize, SurfaceTransform, MaxSpawnAngle03, RandomRotateS03);
        }
        if (slot04 != null && isActive04 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize04, slot04, randomCircleSize04, slot04MinSize, slot04MaxSize, SurfaceTransform, MaxSpawnAngle04, RandomRotateS04);
        }
        if (slot05 != null && isActive05 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize05, slot05, randomCircleSize05, slot05MinSize, slot05MaxSize, SurfaceTransform, MaxSpawnAngle05, RandomRotateS05);
        }
        if (slot06 != null && isActive06 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize06, slot06, randomCircleSize06, slot06MinSize, slot06MaxSize, SurfaceTransform, MaxSpawnAngle06, RandomRotateS06);
        }
        if (slot07 != null && isActive07 == true)
        {
            Grass.GrassGenerator(terrainSize, gridSize07, slot07, randomCircleSize07, slot07MinSize, slot07MaxSize, SurfaceTransform, MaxSpawnAngle07, RandomRotateS07);
        }
    }



}
