namespace GameOfLife.Entities
{
    public interface IGameEngine
    {
        public void Run();
        public void Pause();
        public void Stop();
    }
}
