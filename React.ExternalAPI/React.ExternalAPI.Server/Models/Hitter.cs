namespace React.ExternalAPI.Server.Models;

public class Hitter
{
	public long Id { get; set; }
	public string ImageUrl { get; set; }
	public double BattingAverage {  get; set; }
	public int HomeRuns { get; set; }
	public int RunsBattedIn { get; set; }
	public double OnBasePercentage { get; set; }
	public double SluggingPercentage { get; set; }
}
