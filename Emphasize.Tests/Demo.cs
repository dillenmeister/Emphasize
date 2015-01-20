using Emphasize.Explicitly;
using Emphasize.Politely;
using Emphasize.Yanbos;

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

        public void AddSomeYanbo()
        {
            var s = "";
            s = s.Trim().Chashaofan();
        }

        public void AddSomeYanboExplicitSwedish()
        {
            var s = "";
            s = s.Trim().SomFan();
        }
    }
}
