using System;
using UnityEngine;
using System.Collections;

public static class GameProperties
{
    public static float EnemySpawnerExponent { get { return 2.5f * (float)(Math.Sqrt(Difficulty)); } }
    public static float EnemySpawnerMaxTime { get { return 2.5f / (float)(Math.Sqrt(Difficulty)); } }

    public static float Difficulty { get; set; }    // easy 0.75, normal 1, hard 1.5

}
