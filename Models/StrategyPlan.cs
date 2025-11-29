namespace CaminaDog.Models
{
    public class StrategyPlan
    {
        public string DogName { get; set; } = string.Empty;
        public string AnalysisSummary { get; set; } = string.Empty;
        public List<string> RoutineSteps { get; set; } = new List<string>();
        public List<string> CorrectionTechniques { get; set; } = new List<string>();
        public List<string> RecommendedVideos { get; set; } = new List<string>();
        public string DailyChecklist { get; set; } = string.Empty;
    }
}
