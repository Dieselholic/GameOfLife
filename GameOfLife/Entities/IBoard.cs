namespace GameOfLife.Entities
{
    internal interface IDesk
    {
        //Manipulations with board
        public void FlushDesk();
        public void ResizeDesk(int newSizeX, int newSizeY);
        //public void UpdateDesk(params ICell[] updatedCells);
        public void SowCellsOnPos(params (int posY, int posX)[] positions);
        //Manipulations with cells on board
        public void KillCell(int posY, int posX);
        public void KillCell(ICell cell);
        public void RevivalCell(int posY, int posX);
        public void RevivalCell(ICell cell);
        public void ReverseCellStatement(int posY, int posX);
        public void ReverseCellStatement(ICell cell);
        public bool GetCellStatement(int posY, int posX);
        public bool GetCellStatement(ICell cell);
        public ICell GetCell(int posY, int posX);
        public int GetCellAliveNeighboursCount(int posY, int posX);
        public int GetCellAliveNeighboursCount(ICell cell);
        public List<ICell> GetCellNeighbours(int posY, int posX);
        public List<ICell> GetCellNeighbours(ICell cell);
    }
}
