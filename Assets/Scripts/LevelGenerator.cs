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
        Vector3 startPos = new Vector3(-15f,10f,0.0f);
        GameObject level_1 = new GameObject("Level01_Generated");
        level_1.transform.position = startPos;
        GameObject topLeftQuad = new GameObject("TopLeftQuad");
        topLeftQuad.transform.parent = level_1.transform;
        topLeftQuad.transform.localPosition = Vector3.zero;

        for (int row = 0; row < numRows; row++) {
            for (int col = 0; col < numCols; col++) {
                int cell = levelMap[row, col];
                int cell_right = (col < numCols - 1) ? levelMap[row, col + 1] : -1;
                int cell_left = (col > 0) ? levelMap[row, col - 1] : -1;
                int cell_down = (row < numRows - 1) ? levelMap[row + 1, col] : -1;
                int cell_up = (row > 0) ? levelMap[row - 1, col] : -1;
                GameObject tile = GetSegment(cell);

                if (tile != null) { // adding level_1 position to set it at global
                    Vector3 pos = level_1.transform.position + new Vector3(col, -row, 0);
                    GameObject segment;

                    if (cell == 2 && (cell_down == 2 || cell_up == 2)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 2 && (cell_right == 2 || cell_left == 2)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_up == 5 || cell_up == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 3 && (cell_left == 5 || cell_left == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 3 && cell_right == 4 && cell_down == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 3 && cell_right == 4 && cell_up == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && cell_left == 4 && cell_down == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 1 && cell_up == 2 && cell_left == 2) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 1 && cell_down == 2 && cell_left == 2) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 4 && (cell_up == 5 || cell_down == 5 || cell_up == 0 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 4 && (cell_left == 5 || cell_right == 5 || cell_left == 0 || cell_right == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 1 && cell_up == 2 && cell_right == 2) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else {
                        segment = Instantiate(tile, pos, Quaternion.identity);
                    }
                    segment.transform.parent = topLeftQuad.transform;
                }
            
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