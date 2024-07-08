namespace XpLevelCalculator.Core.Models.Requests;

public class RequestLevelUpJson
{
    public int Level { get; set; }
    public int LevelToAchieve { get; set; }
    public long XpPossessed { get; set; }
    public long XpGivenByActivity { get; set; }
}
