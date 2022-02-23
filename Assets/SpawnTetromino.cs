using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] Tetrominoes;

    void Start()
    {
        
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}


//EXTRA CODE
/* 
        public Material BaseColor;
        
        Colors[Random.Range(0, Colors.Length)],
        
        Color[] colors = new Color [7];
        colors[0] = new Color32(75, 0, 130, 255);          //Indigo
        colors[1] = new Color32(215, 59, 62, 255);        //Jasper
        colors[2] = new Color32(255, 247, 0, 255);       //Lemon
        colors[3] = new Color32(53, 56, 57, 255);       //Onyx
        colors[4] = new Color32(0, 198, 36, 255);      //Sentaicar
        colors[5] = new Color32(219, 215, 210, 255);  //Timberwolf
        colors[6] = new Color32(0, 20, 168, 255);    //Zaffre

        BaseColor.color = colors[Random.Range(0,colors.Length)];

*/