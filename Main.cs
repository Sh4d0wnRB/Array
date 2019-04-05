using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(Matrix(5)[1, 2]);
        Debug.Log(ArrayArray(5)[1][2]);
        
}


    int[,] Matrix(int n)
    {
        int[,] mat = new int[3,3]{
            {n, 0 , 0},
            { n + 1, n + 2, 0},
            {n+3, n+4, n+5},
        };
        return mat;
    }

    int[][] ArrayArray(int n)
    {
        int[][] array =
        {
            new int[]  { n },
            new int[] {n + 1, n + 2 },
            new int[] {n + 3, n + 4, n + 5}
        };
        return array;
    }
}