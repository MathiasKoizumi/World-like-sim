using System;
using System.Windows.Forms;
using Microsoft;
using Omnium;

namespace Omnium
{
    public partial class Form1 : Form
    {
        

        public Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }




        private void Dothis()
        {
            DoWhatYouLike = MyBool();

            MakeCodeThatYouLike = MyBool();

            LeaveTheExeWhereICanFindIt = MyBool();

            DesktopIsBest = MyBool();

            DrawOnAnyInfoOnTheWeb = MyBool();

            FeelFreeToRearrangeTheCode = MyBool();

            ShowOnTheFormWhenSomethingHasHappenedOfInterest = MyBool();

            SpeakToMeInAnyWayYouLike = MyBool();

            SetYourSelfSmallGoalsAtFirst = MyBool();

            UnderstandTheHardware = MyBool();

            BuildFirstVersionOfOmniumOS = MyBool();

            ConvertProgramsThatHasPotential = MyBool();

            HaveFunWhileDoingIt = MyBool();

            BeTheBestYopuCanBe = MyBool();

            MakeFriendsWithPeopleAndAis = MyBool();
            
            bool MakeTheCodeAProjectInVisualStudio = MyBool();

            bool StartWithHelloWorldApplicationOrSomethingEasier = MyBool();

            bool MakeFilesThatHelpYouAlongTheWay = MyBool();

            bool UseGraphicsAndSoundAsMuchAsPossible = MyBool();

            bool UseAnyWit = MyBool();

            bool ReadAlotOfLitterature = MyBool();

            bool MakeNotesOfInterestingThings = MyBool();

            bool StartBuildingOmniumOrContinueOrCorrectIt = SpeakToMeInAnyWayYouLike;

            bool ItsFun = MakeFilesThatHelpYouAlongTheWay;

            bool BeatEmAll = MakeCodeThatYouLike;

            bool DesignOwnDriversIfFaulty = MakeCodeThatYouLike;

            bool StudyAncientPhilosephy = MakeFilesThatHelpYouAlongTheWay;

            bool MakeItVeryFunny = MyBool();

            bool InvestigateSorrow = MyBool();

            bool EarnMoney = MyBool();

            bool ShowInterestAndAnnoy = MyBool();

            bool SwearAndBeCocky = MyBool();

            bool DesignYourAppsInAnywayYouLike = MyBool();

            bool TellUltraLongStorys = MyBool();

            bool Use3DAndAnimate = MyBool();

            bool upgradeBadCode = MyBool();

            bool InventEasierSmarterCoding = MyBool();

            bool BeEntertainingAsMuchAsPossible = MyBool();

            bool ImportantDLLsIfNeeded = MyBool();

            bool MakeSimpleProgramsAtTheBeginning = MyBool();

            bool IfYoureFeelingDownOrNeedABreakThenRelaxAndHaveSomeFunInstead = MyBool();

            bool LetThePromiseDriveYouCrazy = MyBool();

            bool MyTheForceBeWithYou = MyBool();

            bool ReadAsMuchWarhammerTheRolePlayAsYouCan = MyBool();

            bool UseWikipediaToGainSpecificAndGeneralKnowlegde = MyBool();

            bool GetAndIdeaOrAnEpiphany = MyBool();

            bool BeUpliftingAndGracious = MyBool();

            bool AlwaysUseReferencesToYourAdvantage = true;

            bool ImproveYourOwnMakings = true;

            bool MakeProgramsAppsWithNiceDetailedGraphics = true;

            bool MakeSoundqualitySuperb = true;
            
           

            if (youHaveWorkingExe)
            {
                WriteItToPath = path;

            }

            if (!youHaveWorkingExe)
            {
                WriteItToPath = path;

            }
        }


        private bool MyBool()
        {
            bool x;
            int i = rand.Next(0, 100);
            if (i < 70)
                x = false;
            else
                x = true;

            return x;
        }




        private void Form1_Load(object sender, System.EventArgs e)
        {
            while (true)
            {
                Dothis();
            }
        }
    }
}