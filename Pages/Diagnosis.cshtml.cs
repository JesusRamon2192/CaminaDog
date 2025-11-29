using CaminaDog.Models;
using CaminaDog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CaminaDog.Pages
{
    public class DiagnosisModel : PageModel
    {
        private readonly IDiagnosisService _diagnosisService;
        private readonly ILogger<DiagnosisModel> _logger;

        public DiagnosisModel(IDiagnosisService diagnosisService, ILogger<DiagnosisModel> logger)
        {
            _diagnosisService = diagnosisService;
            _logger = logger;
        }

        [BindProperty]
        public Diagnosis Diagnosis { get; set; } = new Diagnosis();

        public void OnGet()
        {
            _logger.LogInformation("Diagnosis page loaded");
            // Initialize with defaults
            Diagnosis = new Diagnosis();
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Diagnosis form submitted");
            
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid. Errors: {Errors}", 
                    string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                return Page();
            }

            try
            {
                // Generate plan (in a real app we might save ID and redirect, 
                // but here we can pass data via TempData or just redirect to Plan with query params
                // For simplicity/robustness, let's pass serialized data or just use TempData if it fits.
                // Better: Pass the Diagnosis object to the Plan page via TempData or a Service singleton (not recommended for multi-user).
                // Simplest for this demo: Serialize to JSON in TempData.
                
                TempData["DiagnosisJson"] = System.Text.Json.JsonSerializer.Serialize(Diagnosis);
                _logger.LogInformation("Diagnosis data serialized and stored in TempData. Redirecting to Plan page.");
                return RedirectToPage("Plan");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing diagnosis form");
                ModelState.AddModelError(string.Empty, "Ocurrió un error al procesar tu solicitud. Por favor intenta de nuevo.");
                return Page();
            }
        }
    }
}
