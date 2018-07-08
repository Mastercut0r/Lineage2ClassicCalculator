namespace EnhancementCalculator.Models
{
    public interface IClanArena
    {
        IScrolls Reward(int characterLevel, int bossStage);
        IScrolls Reward(int characterLevel, int startStage, int endStage);
    }
}
