using System.ComponentModel.DataAnnotations;

namespace CaminaDog.Models
{
    public class Diagnosis
    {
        [Required(ErrorMessage = "El nombre del perro es obligatorio.")]
        public string DogName { get; set; } = string.Empty;

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(0, 30, ErrorMessage = "La edad debe estar entre 0 y 30 años.")]
        public double Age { get; set; }

        [Required(ErrorMessage = "La raza es obligatoria.")]
        public string Breed { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nivel de energía es obligatorio.")]
        public string EnergyLevel { get; set; } = "Media"; // Baja, Media, Alta

        // Owner details
        [Required(ErrorMessage = "Tu experiencia es obligatoria.")]
        public string OwnerExperience { get; set; } = "Principiante"; // Principiante, Intermedio, Experto

        // Issues
        public bool PullsLeash { get; set; }
        public bool ReactsToDogs { get; set; }
        public bool ReactsToPeople { get; set; }
        public bool ReactsToNoise { get; set; }
        public bool Hyperactivity { get; set; }
        public bool Disobedience { get; set; }
        public bool ChewsThings { get; set; }
        public bool JumpsOnPeople { get; set; }
        public bool SeparationAnxiety { get; set; }
        
        public string OtherIssues { get; set; } = string.Empty;
    }
}
