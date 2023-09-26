using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject tile_1;
    public GameObject tile_2;
    public GameObject tile_3;
    public GameObject tile_4;
    public GameObject tile_5;
    public GameObject tile_6;
    public GameObject tile_7;
    
    private int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };
    private int numRows;
    private int numCols;

    void Start()
    {
        GameObject level01 = GameObject.Find("Level01");
        if (level01 != null)
        {
            Destroy(level01);
        }
        numRows = levelMap.GetLength(0);
        numCols = levelMap.GetLength(1);
        GenerateLevel();
    }

    void GenerateLevel()
    {
        for (int row = 0; row < numRows; row++) {
            for (int col = 0; col < numCols; col++) {
                int cell = levelMap[row, col];



            }
        }
    }

    GameObject GetSegment(int cell) {
        switch (cell) {
            case 1: return tile_1;
            case 2: return tile_2;
            case 3: return tile_3;
            case 4: return tile_4;
            case 5: return tile_5;
            case 6: return tile_6;
            case 7: return tile_7;
            default: return null;
        }
    }
}