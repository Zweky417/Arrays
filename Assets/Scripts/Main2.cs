using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour {

	void Start () {
        int[,] m = Matriz(1);
        int[][] n = ArrayArray(1);
        Debug.Log(n[0][0]);
        Debug.Log(m[0, 0]);
	}
	
	int[][] ArrayArray (int n) {

        int[][] arr = new int[3][];

        arr[0] = new int[] { n };
        arr[1] = new int[] { n + 1, n + 2 };
        arr[2] = new int[] { n + 3, n + 4, n + 5 };
        return arr;
	}

    int[,] Matriz(int m) {
        int[,] arr = new int[,] {
            { m, 0, 0 },
            { m+1, m+2, 0 },
            { m+3, m+4, m+5 },
        };
        return arr;
    }
}
