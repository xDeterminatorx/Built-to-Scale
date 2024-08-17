using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Grid level;
    [SerializeField] public GridTile _tilePrefab;
    [SerializeField] public Transform _camera;

    // Start is called before the first frame update
    void Start()
    {
        this.level = Grid.generateTestLevel();
        generateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateGrid()
    {
        for (int x = 0; x < level.width; x++)
        {
            for (int y = 0; y < level.height; y++)
            {
                var newtile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                newtile.tiletype = level.tiles[x,y];
                newtile.init();
            }
        }

        _camera.transform.position = new Vector3((float)this.level.width / 2 - 0.5f, (float)this.level.height / 2 - 0.5f, -10f);
    }
}
