using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	void Start () {
        
        int[] c = Calc(3, 2);
        Debug.Log("Soma = " + c[0]);
        Debug.Log("Subtração = " + c[1]);
        Debug.Log("Multiplicação = " + c[2]);
        Debug.Log("Divisão = " + c[3]);
	}

	int[] Calc(int x, int y) {
        int[] c = new int[4]; 
        c[0] = x + y;
        c[1] = x - y;
        c[2] = x * y;
        c[3] = x / y;
        return c;
	}
}
