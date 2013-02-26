using Emphasize.Explicitly;
using Emphasize.Politely;

namespace Emphasize.Tests
{
    public class Demo
    {
		public void IfYouWantToTreatTheCompilerWithRespect()
		{
			var s = "";
			s = s.Please().Trim();
			s = s.Trim().Thanks();
		}

		public void IfYoureAngryWithTheCompiler()
		{
			var s = "";
			s = s.Fucking().Trim().Bitch();
		}

		public void MixAndMatch()
		{
			var s = "";
			s = s.Please().Fucking().Trim().Thanks();
		}
    }
}
