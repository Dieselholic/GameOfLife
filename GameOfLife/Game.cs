using GameOfLife.Entities;

namespace GameOfLife
{
    public class Game : IGameEngine
    {
        private readonly Desk _desk;
        private bool _isActive = false;
        private bool _isPaused = false;

        public Game() : this(21, 21) { }

        public Game(int sizeY, int sizeX)
        {
            _desk = new Desk(sizeY, sizeX);
        }

        public Game(int sizeY, int sizeX, params (int posY, int posX)[] positions)
        {
            _desk = new Desk(sizeY, sizeX);
            _desk.SowCellsOnPos(positions);
        }

        public void Run()
        {
            _isActive = true;
            Render();

            while (true)
            {
                Calculation();
                Render();
                Thread.Sleep(1000);
            }
        }

        public void Pause()
        {
            _isPaused = true;
        }

        public void Stop()
        {
            _isActive = false;
        }

        private void Calculation()
        {
            var cellsThatWillChange = new HashSet<ICell>();

            //adding current active cells
            foreach (var cell in _desk.ListOfAliveCells)
            {
                cellsThatWillChange.Add(cell);
            }

            //getting neighbours from active cells
            foreach (var cell in _desk.ListOfAliveCells)
            {
                var listOfNeighbours = _desk.GetCellNeighbours(cell);
                foreach (var neighbourCell in listOfNeighbours)
                {
                    //adding neighbours to hashset
                    cellsThatWillChange.Add(neighbourCell);
                }
            }

            //going through all the cells that can change in this turn
            foreach (var cell in cellsThatWillChange)
            {
                //if current cell is alive
                if (_desk.GetCellStatement(cell))
                {
                    var count = _desk.GetCellAliveNeighboursCount(cell);
                    if (count == 2 || count == 3)
                    {
                        cellsThatWillChange.Remove(cell);
                    }
                }
                //if current cell is dead
                else
                {
                    if (_desk.GetCellAliveNeighboursCount(cell) != 3)
                    {
                        cellsThatWillChange.Remove(cell);
                    }
                }
            }

            //changing the rest of cells
            foreach (var cell in cellsThatWillChange)
            {
                _desk.ReverseCellStatement(cell);
            }
        }

        private void Render()
        {
            Console.Clear();

            foreach (var line in _desk.DeskView)
            {
                foreach (var cell in line)
                {
                    if (cell)
                    {
                        DrawAliveCell();
                    }
                    else
                    {
                        DrawDeadCell();
                    }
                }
                Console.WriteLine();
            }
        }

        private static void DrawAliveCell()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("1 ");
            Console.ResetColor();
        }

        private static void DrawDeadCell()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("0 ");
            Console.ResetColor();
        }

        ////////////////////////////////////////////////////
        protected class Desk : IDesk
        {
            private readonly int _sizeY;
            private readonly int _sizeX;
            private ICell[][] _data;
            private readonly HashSet<ICell> _aliveCells;

            public bool[][] DeskView
            {
                get
                {
                    var tmp = new bool[_sizeY][];
                    for (int i = 0; i < _sizeY; i++)
                    {
                        tmp[i] = new bool[_sizeX];
                        for (int j = 0; j < _sizeX; j++)
                        {
                            tmp[i][j] = _data[i][j].CheckStatement();
                        }
                    }

                    return tmp;
                }
            }

            public HashSet<ICell> ListOfAliveCells => _aliveCells;

            #region Ctors
            public Desk() : this(21, 21) { }

            public Desk(int sizeY, int sizeX)
            {
                _sizeY = sizeY;
                _sizeX = sizeX;
                _data = new Cell[_sizeY][];
                _aliveCells = new HashSet<ICell>();
                CreateDesk();
            }

            private void CreateDesk()
            {
                for (var i = 0; i < _sizeY; i++)
                {
                    _data[i] = new Cell[_sizeX];
                    for (int j = 0; j < _sizeX; j++)
                    {
                        _data[i][j] = new Cell(i, j);
                    }
                }
            }
            #endregion

            #region Desk
            public void FlushDesk()
            {
                if (_data != null)
                {
                    foreach (var line in _data)
                    {
                        foreach (var cell in line)
                        {
                            if (cell.CheckStatement())
                            {
                                cell.Kill();
                            }
                        }
                    }
                }
                _aliveCells.Clear();
            }

            public void ResizeDesk(int newSizeX, int newSizeY)
            {
                Array.Resize(ref _data, newSizeY);
                for (var i = 0; i < newSizeY; i++)
                {
                    Array.Resize(ref _data[i], newSizeX);
                }
            }

            public void SowCellsOnPos(params (int posY, int posX)[] positions)
            {
                foreach (var (y, x) in positions)
                {
                    _data[y][x].Revival();
                    _aliveCells.Add(_data[y][x]);
                }
            }
            #endregion

            #region Cells
            public void KillCell(int posY, int posX)
            {
                _data[posY][posX].Kill();
                if (_aliveCells.Contains(_data[posY][posX]))
                {
                    _aliveCells.Remove(_data[posY][posX]);
                }
            }

            public void KillCell(ICell cell)
            {
                cell.Kill();
                if (_aliveCells.Contains(cell))
                {
                    _aliveCells.Remove(cell);
                }
            }

            public void RevivalCell(int posY, int posX)
            {
                _data[posY][posX].Revival();
                if (!_aliveCells.Contains(_data[posY][posX]))
                {
                    _aliveCells.Add(_data[posY][posX]);
                }
            }

            public void RevivalCell(ICell cell)
            {
                cell.Revival();
                if (!_aliveCells.Contains(cell))
                {
                    _aliveCells.Add(cell);
                }
            }

            public void ReverseCellStatement(int posY, int posX)
            {
                _data[posY][posX].ReverseStatement();
                if (_data[posY][posX].CheckStatement())
                {
                    _aliveCells.Add(_data[posY][posX]);
                }
                else
                {
                    _aliveCells.Remove(_data[posY][posX]);
                }
            }

            public void ReverseCellStatement(ICell cell)
            {
                cell.ReverseStatement();
                if (cell.CheckStatement())
                {
                    _aliveCells.Add(cell);
                }
                else
                {
                    _aliveCells.Remove(cell);
                }
            }

            public bool GetCellStatement(int posY, int posX)
            {
                return _data[posY][posX].CheckStatement();
            }

            public bool GetCellStatement(ICell cell)
            {
                return cell.CheckStatement();
            }

            public ICell GetCell(int posY, int posX)
            {
                return _data[posY][posX];
            }

            public int GetCellAliveNeighboursCount(int posY, int posX)
            {
                var count = 0;

                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        //calculating neighbour position y
                        var nPosY = posY + i;
                        if (nPosY < 0)
                        {
                            nPosY = _sizeY - 1;
                        }
                        else if (nPosY >= _sizeY)
                        {
                            nPosY = 0;
                        }

                        //calculating neighbour position x
                        var nPosX = posX + j;
                        if (nPosX < 0)
                        {
                            nPosX = _sizeX - 1;
                        }
                        else if (nPosX >= _sizeX)
                        {
                            nPosX = 0;
                        }

                        //checking is neighbour == our current cell
                        if (nPosY == posY && nPosX == posX)
                        {
                            continue;
                        }

                        if (_data[nPosY][nPosX].CheckStatement())
                        {
                            count++;
                        }
                    }
                }

                return count;
            }

            public int GetCellAliveNeighboursCount(ICell cell)
            {
                var (posY, posX) = (((Cell)cell).PosY, ((Cell)cell).PosX);
                return GetCellAliveNeighboursCount(posY, posX);
            }

            public List<ICell> GetCellNeighbours(int posY, int posX)
            {
                var list = new List<ICell>();

                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        //calculating neighbour position y
                        var nPosY = posY + i;
                        if (nPosY < 0)
                        {
                            nPosY = _sizeY - 1;
                        }
                        else if (nPosY >= _sizeY)
                        {
                            nPosY = 0;
                        }

                        //calculating neighbour position x
                        var nPosX = posX + j;
                        if (nPosX < 0)
                        {
                            nPosX = _sizeX - 1;
                        }
                        else if (nPosX >= _sizeX)
                        {
                            nPosX = 0;
                        }

                        //checking is neighbour == our current cell
                        if (nPosY == posY && nPosX == posX)
                        {
                            continue;
                        }
                        list.Add(_data[nPosY][nPosX]);
                    }
                }

                return list;
            }

            public List<ICell> GetCellNeighbours(ICell cell)
            {
                var (posY, posX) = (((Cell)cell).PosY, ((Cell)cell).PosX);
                return GetCellNeighbours(posX, posY);
            }
            #endregion

            protected class Cell : ICell
            {
                private int _y;
                private int _x;
                private bool _isAlive;

                public int PosY
                {
                    get => _y;
                    set => _y = value;
                }
                public int PosX
                {
                    get => _x;
                    set => _x = value;
                }
                public bool IsAlive => _isAlive;

                public Cell(int posY, int posX, bool isAlive = false)
                {
                    _y = posY;
                    _x = posX;
                    _isAlive = isAlive;
                }

                public bool CheckStatement()
                {
                    return _isAlive;
                }

                public void Kill()
                {
                    _isAlive = false;
                }

                public void Revival()
                {
                    _isAlive = true;
                }

                public void ReverseStatement()
                {
                    _isAlive = !_isAlive;
                }
            }
        }
    }
}