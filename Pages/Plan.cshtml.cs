using CaminaDog.Models;
using CaminaDog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaminaDog.Pages
{
    public class PlanModel : PageModel
    {
        private readonly IDiagnosisService _diagnosisService;

        public PlanModel(IDiagnosisService diagnosisService)
        {
            _diagnosisService = diagnosisService;
        }

        public StrategyPlan StrategyPlan { get; set; } = new StrategyPlan();

        public IActionResult OnGet()
        {
            if (TempData["DiagnosisJson"] is string json)
            {
                var diagnosis = System.Text.Json.JsonSerializer.Deserialize<Diagnosis>(json);
                if (diagnosis != null)
                {
                    StrategyPlan = _diagnosisService.GeneratePlan(diagnosis);
                    return Page();
                }
            }

            return RedirectToPage("Diagnosis");
        }
    }
}
