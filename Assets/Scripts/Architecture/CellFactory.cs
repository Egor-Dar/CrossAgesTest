using DG.Tweening;
using UnityEngine;

namespace Architecture
{
    public class CellFactory : MonoBehaviour
    {
        [SerializeField] private Grid grid;
        [SerializeField] private int height;
        [SerializeField] private int width;
        [SerializeField] private Cell cellPrefab;
        private Cell[,] _cells;



        private void Awake()
        {
            _cells = new Cell[width, height];
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var cell = Instantiate(cellPrefab);
                    ;
                    cell.SetPositionCell(grid.GetCellCenterWorld(new Vector3Int(x,y,0)));
                    _cells[x, y] = cell;
                }
            }
        }
    }
}