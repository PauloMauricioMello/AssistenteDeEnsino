namespace AssistenteDeEnsino.Services.OpenAI;

public static class GPTModelExtensions
{
      public static string ToApiModel(this EGPTModel model)
      {
            return model switch
            {
                  EGPTModel.Gpt3_5Turbo => "gpt-3.5-turbo",
                  EGPTModel.Gpt4 => "gpt-4",
                  EGPTModel.Gpt4o => "gpt-4o",
                  _ => throw new ArgumentOutOfRangeException(nameof(model), model, null)
            };
      }
}
