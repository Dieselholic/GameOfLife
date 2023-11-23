namespace GameOfLife.Entities
{
    public interface ICell
    {
        public bool CheckStatement();
        public void Kill();
        public void Revival();
        public void ReverseStatement();
    }
}
