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
    {   // OG maze
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
        
        // {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        // {7,4,4,4,4,3,5,3,4,4,4,3,5,4},
        // {7,4,4,4,4,3,5,4,0,0,0,4,5,4},
        // {2,5,5,5,5,5,5,3,4,4,4,3,5,3},
        // {2,5,3,4,3,5,5,5,5,5,5,5,5,5},
        // {2,5,4,0,4,5,3,4,3,5,3,3,5,3},
        // {2,5,3,4,3,5,3,4,3,5,3,3,5,4},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        // {1,2,2,2,2,1,5,3,4,4,4,3,0,4},
        // {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        // {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        // {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        // {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        // {0,0,0,0,0,0,5,0,0,0,4,0,0,0},

        // {1,2,7,2,7,2,2,2,2,2,2,2,2,7},
        // {2,5,4,0,4,5,5,5,5,5,5,5,5,4},
        // {2,5,3,4,3,5,3,4,4,4,4,3,5,4},
        // {2,5,5,5,5,5,4,3,4,3,0,4,5,4},
        // {2,5,3,4,3,5,3,3,5,3,4,3,5,3},
        // {2,5,3,4,3,5,5,5,5,5,5,5,5,5},
        // {2,5,5,5,5,5,3,4,3,5,3,4,4,4},
        // {2,5,3,3,5,5,3,4,3,5,3,4,4,3},
        // {2,5,4,4,5,5,5,5,5,5,5,5,5,4},
        // {1,2,7,7,2,1,5,3,4,4,4,3,0,4},
        // {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        // {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        // {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        // {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        // {0,0,0,0,0,0,5,0,0,0,4,0,0,0},

        // testing 3s
        // {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,2},
        // {2,5,5,3,3,5,5,5,5,3,3,5,3,7},
        // {2,5,3,3,3,3,5,5,3,3,4,5,3,7},
        // {2,5,3,3,3,3,5,5,3,3,4,5,5,1},
        // {2,5,5,3,3,5,5,5,5,3,3,5,5,5},
        // {2,5,5,5,5,5,3,4,3,5,5,5,5,5},
        // {2,5,3,3,5,5,3,4,3,5,5,5,5,3},
        // {2,5,4,4,5,5,5,5,5,5,5,5,5,4},
        // {1,2,7,7,2,1,5,3,4,4,4,3,0,4},
        // {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        // {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        // {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        // {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        // {0,0,0,0,0,0,5,0,0,0,4,0,0,0},

        // zigzag
        // {1,2,2,2,2,1,5,1,2,2,2,2,2,1},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,2},
        // {2,5,5,5,5,5,5,5,5,3,4,3,5,2},
        // {2,5,5,5,5,5,5,5,3,3,3,3,5,2},
        // {2,5,5,5,5,5,5,3,3,3,3,5,5,2},
        // {2,5,5,5,5,5,3,3,3,3,5,5,5,1},
        // {1,5,5,5,5,3,3,3,3,5,5,5,5,5},
        // {5,5,5,5,3,3,3,3,5,5,5,5,5,5},
        // {1,5,5,3,3,3,3,5,5,5,5,5,5,1},
        // {2,5,3,3,3,3,5,5,5,5,5,5,5,2},
        // {2,5,3,4,3,5,5,5,5,5,5,5,5,2},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,2},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,2},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5,2},
        // {1,2,2,2,2,1,5,5,1,2,2,2,2,1},

        // test different size
        // {1,2,2,2,2,2,2,2,2,2,2,2,7},
        // {2,5,5,5,3,3,3,3,5,5,5,5,4},
        // {2,5,5,3,3,3,3,5,5,5,5,5,4},
        // {2,5,3,3,3,3,5,5,5,5,5,5,3},
        // {2,5,3,4,3,5,5,5,5,5,5,5,5},
        // {2,5,5,5,5,5,5,5,5,5,5,5,5},
        // {2,5,5,5,5,5,5,5,5,5,5,5,2},
        // {2,5,5,5,5,5,5,5,5,5,5,5,2},
        // {1,2,2,2,2,1,5,5,1,2,2,2,1},
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
                int cell_leftUp = (row > 0 && col > 0) ? levelMap[row - 1, col - 1] : -1;
                int cell_leftDown = (row < numRows - 1 && col > 0) ? levelMap[row + 1, col - 1] : -1;
                int cell_rightUp = (row > 0 && col < numCols - 1) ? levelMap[row - 1, col + 1] : -1;
                int cell_rightDown = (row < numRows - 1 && col < numCols - 1) ? levelMap[row + 1, col + 1] : -1;

                GameObject tile = GetSegment(cell);

                if (tile != null) { // adding level_1 position to set it at global
                    Vector3 pos = level_1.transform.position + new Vector3(col, -row, 0);
                    GameObject segment = null;

                    if (cell == 2 && (cell_down == 2 || cell_up == 2 || cell_up == 1 || cell_down == 1 || cell_up == 7 || cell_down == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 2 && (cell_right == 2 || cell_left == 2 || cell_right == 1 || cell_left == 1)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_up == 5 || cell_up == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 3 && (cell_left == 5 || cell_left == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 3 && (cell_right == 4 || cell_right == 3) && (cell_down == 4 || cell_down == 3) && (cell_left == 3 || cell_left == 4) && (cell_up == 3 || cell_up == 4)) {
                        if (cell_leftUp == 5 || cell_leftUp == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                        if (cell_leftDown == 5 || cell_leftDown == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }
                        if (cell_rightUp == 5 || cell_rightUp == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_rightDown == 5 || cell_rightDown == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                    } else if (cell == 3 && (cell_left == 4 || cell_left == 3) && (cell_down == 4 || cell_down == 3)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 3 && cell_right == 4 && cell_up == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && cell_left == 4 && cell_down == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));

                    } else if (cell == 1 && ((cell_right == 7 || cell_right == 2 || cell_right == 1) && (cell_down == 7 || cell_down == 2 || cell_down == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 1 && ((cell_up == 7 || cell_up == 2 || cell_up == 1) && (cell_right == 7 || cell_right == 2 || cell_right == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 1 && ((cell_left == 7 || cell_left == 2 || cell_left == 1) && (cell_down == 7 || cell_down == 2 || cell_down == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 1 && ((cell_left == 7 || cell_left == 2 || cell_left == 1) && (cell_up == 7 || cell_up == 2 || cell_up == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 1 && cell_right <= 0) {
                        if (cell_up == 7 || cell_up == 2 || cell_up == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_down == 7 || cell_down == 2 || cell_down == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                    } else if (cell == 1 && cell_up <= 0) {
                        if (cell_right == 7 || cell_right == 2 || cell_right == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_left == 7 || cell_left == 2 || cell_left == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                    } else if (cell == 1 && cell_left <= 0) {
                        if (cell_up == 7 || cell_up == 2 || cell_up == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                        if (cell_down == 7 || cell_down == 2 || cell_down == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }
                    } else if (cell == 1 && cell_down <= 0) {
                        if (cell_right == 7 || cell_right == 2 || cell_right == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                        if (cell_left == 7 || cell_left == 2 || cell_left == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }

                    } else if (cell == 4 && (cell_up == 5 || cell_down == 5 || cell_up == 0 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 4 && (cell_left == 5 || cell_right == 5 || cell_left == 0 || cell_right == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 7 && cell_up <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 7 && cell_down <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 7 && cell_left <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 7 && cell_right <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 7 && (cell_up == 2 || cell_up == 1 || cell_up == 7 || cell_down == 2 || cell_down == 1 || cell_down == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 7 && (cell_right == 2 || cell_right == 1 || cell_right == 7 || cell_left == 2 || cell_left == 1 || cell_left == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else {
                        segment = Instantiate(tile, pos, Quaternion.identity);
                    }
                    if (segment != null) {
                        segment.transform.parent = topLeftQuad.transform;
                    }
                }            
            }
        }

        GameObject bottomLeftQuad = new GameObject("BottomLeftQuad");
        bottomLeftQuad.transform.parent = level_1.transform;
        bottomLeftQuad.transform.localPosition = Vector3.zero;

        for (int row = 0; row < numRows - 1; row++) {
            for (int col = 0; col < numCols; col++) {
                int cell = levelMap[row, col];
                int cell_right = (col < numCols - 1) ? levelMap[row, col + 1] : -1;
                int cell_left = (col > 0) ? levelMap[row, col - 1] : -1;
                int cell_down = (row < numRows - 1) ? levelMap[row + 1, col] : -1;
                int cell_up = (row > 0) ? levelMap[row - 1, col] : -1;
                int cell_leftUp = (row > 0 && col > 0) ? levelMap[row - 1, col - 1] : -1;
                int cell_leftDown = (row < numRows - 1 && col > 0) ? levelMap[row + 1, col - 1] : -1;
                int cell_rightUp = (row > 0 && col < numCols - 1) ? levelMap[row - 1, col + 1] : -1;
                int cell_rightDown = (row < numRows - 1 && col < numCols - 1) ? levelMap[row + 1, col + 1] : -1;

                GameObject tile = GetSegment(cell);

                if (tile != null) { // adding level_1 position to set it at global
                    Vector3 pos = level_1.transform.position + new Vector3(col, -row, 0);
                    GameObject segment = null;

                    if (cell == 2 && (cell_down == 2 || cell_up == 2 || cell_up == 1 || cell_down == 1 || cell_up == 7 || cell_down == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 2 && (cell_right == 2 || cell_left == 2 || cell_right == 1 || cell_left == 1)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_up == 5 || cell_up == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 3 && (cell_left == 5 || cell_left == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && (cell_right == 5 || cell_right == 0) && (cell_down == 5 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 3 && (cell_right == 4 || cell_right == 3) && (cell_down == 4 || cell_down == 3) && (cell_left == 3 || cell_left == 4) && (cell_up == 3 || cell_up == 4)) {
                        if (cell_leftUp == 5 || cell_leftUp == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                        if (cell_leftDown == 5 || cell_leftDown == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }
                        if (cell_rightUp == 5 || cell_rightUp == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_rightDown == 5 || cell_rightDown == 0) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                    } else if (cell == 3 && (cell_left == 4 || cell_left == 3) && (cell_down == 4 || cell_down == 3)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 3 && cell_right == 4 && cell_up == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 3 && cell_left == 4 && cell_down == 4) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));

                    } else if (cell == 1 && ((cell_right == 7 || cell_right == 2 || cell_right == 1) && (cell_down == 7 || cell_down == 2 || cell_down == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 1 && ((cell_up == 7 || cell_up == 2 || cell_up == 1) && (cell_right == 7 || cell_right == 2 || cell_right == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 1 && ((cell_left == 7 || cell_left == 2 || cell_left == 1) && (cell_down == 7 || cell_down == 2 || cell_down == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 1 && ((cell_left == 7 || cell_left == 2 || cell_left == 1) && (cell_up == 7 || cell_up == 2 || cell_up == 1))) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 1 && cell_right <= 0) {
                        if (cell_up == 7 || cell_up == 2 || cell_up == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_down == 7 || cell_down == 2 || cell_down == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                    } else if (cell == 1 && cell_up <= 0) {
                        if (cell_right == 7 || cell_right == 2 || cell_right == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                        }
                        if (cell_left == 7 || cell_left == 2 || cell_left == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                    } else if (cell == 1 && cell_left <= 0) {
                        if (cell_up == 7 || cell_up == 2 || cell_up == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                        }
                        if (cell_down == 7 || cell_down == 2 || cell_down == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }
                    } else if (cell == 1 && cell_down <= 0) {
                        if (cell_right == 7 || cell_right == 2 || cell_right == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                        }
                        if (cell_left == 7 || cell_left == 2 || cell_left == 1) {
                            segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                        }

                    } else if (cell == 4 && (cell_up == 5 || cell_down == 5 || cell_up == 0 || cell_down == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 4 && (cell_left == 5 || cell_right == 5 || cell_left == 0 || cell_right == 0)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 7 && cell_up <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,0));
                    } else if (cell == 7 && cell_down <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,180));
                    } else if (cell == 7 && cell_left <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 7 && cell_right <= 0) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,270));
                    } else if (cell == 7 && (cell_up == 2 || cell_up == 1 || cell_up == 7 || cell_down == 2 || cell_down == 1 || cell_down == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else if (cell == 7 && (cell_right == 2 || cell_right == 1 || cell_right == 7 || cell_left == 2 || cell_left == 1 || cell_left == 7)) {
                        segment = Instantiate(tile, pos, Quaternion.Euler(0,0,90));
                    } else {
                        segment = Instantiate(tile, pos, Quaternion.identity);
                    }
                    if (segment != null) {
                        segment.transform.parent = bottomLeftQuad.transform;
                    }
                }            
            }
        }
        if (topLeftQuad != null) {
            //topRightQuad
            GameObject topRightQuad = Instantiate(topLeftQuad);
            topRightQuad.transform.parent = level_1.transform;
            topRightQuad.name = "TopRightQuad";
            Vector3 og_pos = topLeftQuad.transform.position;
            Vector3 og_scale = topLeftQuad.transform.localScale;
            topRightQuad.transform.position = new Vector3(og_pos.x + numCols*2-1, og_pos.y, og_pos.z);
            topRightQuad.transform.localScale = new Vector3(-og_scale.x, og_scale.y, og_scale.z);

            foreach (Transform child in topRightQuad.transform) {
                if (child.gameObject.name.ToLower().Contains("pellet")) {
                    Vector3 scale = child.localScale;
                    scale.x = -scale.x;
                    child.localScale = scale;
                }
            }
        } else {
            Debug.LogError("no topLeftQad");
        }
        
        if (bottomLeftQuad != null) {
            bottomLeftQuad.transform.localScale = new Vector3(1, -1, 1);
            Vector3 mirror = bottomLeftQuad.transform.position;
            mirror.y = mirror.y - numRows*2+2;
            bottomLeftQuad.transform.position = mirror;

            foreach (Transform child in bottomLeftQuad.transform) {
                if (child.gameObject.name.ToLower().Contains("pellet")) {
                    Vector3 scale = child.localScale;
                    scale.y = -scale.y;
                    child.localScale = scale;
                }
            }

            //bottomRightQuad
            GameObject bottomRightQuad = Instantiate(bottomLeftQuad);
            bottomRightQuad.transform.parent = level_1.transform;
            bottomRightQuad.name = "BottompRightQuad";
            Vector3 og_pos = bottomLeftQuad.transform.position;
            Vector3 og_scale = bottomLeftQuad.transform.localScale;
            bottomRightQuad.transform.position = new Vector3(og_pos.x + numCols*2-1, og_pos.y, og_pos.z);
            bottomRightQuad.transform.localScale = new Vector3(-og_scale.x, og_scale.y, og_scale.z);

            foreach (Transform child in bottomRightQuad.transform) {
                if (child.gameObject.name.ToLower().Contains("pellet")) {
                    Vector3 scale = child.localScale;
                    scale.x = -scale.x;
                    child.localScale = scale;
                }
            }
        } else {
            Debug.LogError("no topLeftQad");
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