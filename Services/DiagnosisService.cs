using CaminaDog.Models;

namespace CaminaDog.Services
{
    public interface IDiagnosisService
    {
        StrategyPlan GeneratePlan(Diagnosis diagnosis);
    }

    public class DiagnosisService : IDiagnosisService
    {
        public StrategyPlan GeneratePlan(Diagnosis diagnosis)
        {
            var plan = new StrategyPlan
            {
                DogName = diagnosis.DogName,
                RoutineSteps = new List<string>(),
                CorrectionTechniques = new List<string>(),
                RecommendedVideos = new List<string>()
            };

            // Basic Analysis Logic (The "Magia")
            plan.AnalysisSummary = $"Para un {diagnosis.Breed} de {diagnosis.Age} años con energía {diagnosis.EnergyLevel}, necesitamos un enfoque estructurado.";

            // Energy Management
            if (diagnosis.EnergyLevel == "Alta")
            {
                plan.RoutineSteps.Add("Ejercicio previo: 15 minutos de juego intenso antes de salir.");
            }
            else
            {
                plan.RoutineSteps.Add("Calentamiento: 5 minutos de olfato libre antes de iniciar la marcha.");
            }

            // Leash Pulling
            if (diagnosis.PullsLeash)
            {
                plan.CorrectionTechniques.Add("Técnica del Árbol: Detente inmediatamente cuando haya tensión. No avances hasta que la correa esté floja.");
                plan.CorrectionTechniques.Add("Cambios de Dirección: Gira 180 grados si el perro se adelanta, invitándolo a seguirte.");
            }

            // Reactivity
            if (diagnosis.ReactsToDogs || diagnosis.ReactsToPeople)
            {
                plan.CorrectionTechniques.Add("Desensibilización: Mantén distancia del estímulo y premia la calma.");
                plan.CorrectionTechniques.Add("Comando 'Mírame': Entrena el contacto visual para redirigir su atención.");
            }

            // Hyperactivity
            if (diagnosis.Hyperactivity)
            {
                plan.CorrectionTechniques.Add("Ejercicio Mental: Usa juegos de olfato y rompecabezas antes del paseo para cansar su mente.");
                plan.CorrectionTechniques.Add("Protocolo de Calma: Practica 'sentado' y 'quieto' en casa antes de salir.");
                if (diagnosis.EnergyLevel == "Alta")
                {
                    plan.RoutineSteps.Insert(0, "Pre-paseo: 20-30 minutos de ejercicio intenso (correr, jugar a la pelota).");
                }
            }

            // Disobedience
            if (diagnosis.Disobedience)
            {
                plan.CorrectionTechniques.Add("Refuerzo Positivo Consistente: Premia CADA vez que obedezca, sin excepciones.");
                plan.CorrectionTechniques.Add("Comandos Básicos: Practica 'sentado', 'quieto' y 'ven' en sesiones cortas (5-10 min) diarias.");
                plan.CorrectionTechniques.Add("Ignorar Desobediencia: No regañes, simplemente retira la atención y vuelve a intentar.");
            }

            // Chews Things
            if (diagnosis.ChewsThings)
            {
                plan.CorrectionTechniques.Add("Redirección: Cuando muerda algo inapropiado, ofrece un juguete permitido inmediatamente.");
                plan.CorrectionTechniques.Add("Enriquecimiento: Proporciona juguetes tipo Kong rellenos para satisfacer su necesidad de masticar.");
                plan.CorrectionTechniques.Add("Supervisión: Limita el acceso a áreas con objetos tentadores hasta que mejore el comportamiento.");
            }

            // Jumps on People
            if (diagnosis.JumpsOnPeople)
            {
                plan.CorrectionTechniques.Add("Ignorar el Salto: Gira tu cuerpo y no hagas contacto visual cuando salte.");
                plan.CorrectionTechniques.Add("Recompensar Cuatro Patas: Solo saluda y acaricia cuando las cuatro patas estén en el suelo.");
                plan.CorrectionTechniques.Add("Comando Alternativo: Enseña 'sentado' como saludo y premia esa conducta.");
            }

            // Separation Anxiety
            if (diagnosis.SeparationAnxiety)
            {
                plan.CorrectionTechniques.Add("Desensibilización Gradual: Practica salidas cortas (1-2 min) y aumenta el tiempo progresivamente.");
                plan.CorrectionTechniques.Add("Rutina de Salida Tranquila: No hagas despedidas dramáticas, sal sin ceremonias.");
                plan.CorrectionTechniques.Add("Objeto de Confort: Deja una prenda con tu olor o un juguete interactivo.");
                plan.RoutineSteps.Add("Ejercicio Pre-Salida: Asegúrate de que esté cansado antes de dejarlo solo.");
            }

            // Noise Reactivity
            if (diagnosis.ReactsToNoise)
            {
                plan.CorrectionTechniques.Add("Desensibilización a Sonidos: Reproduce ruidos a bajo volumen y premia la calma.");
                plan.CorrectionTechniques.Add("Refugio Seguro: Crea un espacio tranquilo donde pueda esconderse si se asusta.");
            }

            // Default Routine
            plan.RoutineSteps.Add("Fase de Trabajo: 20 minutos de caminata estructurada (junto a ti).");
            plan.RoutineSteps.Add("Fase de Recreo: 10 minutos de olfato y exploración (premio).");
            plan.RoutineSteps.Add("Vuelta a la Calma: Regreso a casa tranquilo.");

            plan.DailyChecklist = "1. Collar ajustado correctamente.\\n2. Premios a la mano.\\n3. Estado mental tranquilo antes de abrir la puerta.";

            return plan;
        }
    }
}
