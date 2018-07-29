namespace EnhancementCalculator.Models
{
    /// <summary>
    /// Interface IScrolls represents container for experience scrolls rewarded for completion of an instance
    /// </summary>
    public interface IScrolls
    {
        /// <summary>
        /// Gets the ten kk scroll count.
        /// </summary>
        /// <value>The ten kk scroll count.</value>
        int TenKkScrollCount { get; }
        /// <summary>
        /// Gets the fifty kk scroll count.
        /// </summary>
        /// <value>The fifty kk scroll count.</value>
        int FiftyKkScrollCount { get; }
        /// <summary>
        /// Gets the hundred kk scroll count.
        /// </summary>
        /// <value>The hundred kk scroll count.</value>
        int HundredKkScrollCount { get; }
        /// <summary>
        /// Gets the total exp.
        /// </summary>
        /// <value>The total exp.</value>
        ulong TotalExp { get; }
        /// <summary>
        /// Gets the total money.
        /// </summary>
        /// <value>The total money.</value>
        ulong TotalMoney { get; }
    }
}
