using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
    [SerializeField] public Color color1;
    [SerializeField] public Color color2;
    [SerializeField] public Color color3;
    [SerializeField] public TileType tiletype;
    private SpriteRenderer myrenderer;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    void Awake()
    {
        myrenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init()
    {
        switch (tiletype)
        {
            case TileType.Grass:
                myrenderer.color = color1;
                break;
            case TileType.Stone:
                myrenderer.color = color2;
                break;
            case TileType.Rail:
                myrenderer.color = color3;
                break;
            default:
                // code block
                break;
        }
    }
}
