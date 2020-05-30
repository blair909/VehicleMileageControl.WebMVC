using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class Disclaimer
    {
        public string DisclaimerStatement = "The information provided by this app does not replace seeing a professional auto-mechanic.The creator of this app is not responsible for any damage that occurs to a vehicle based of the use of this app. Do you acknowledge this statement? Enter either 'yes' or 'no'. ";
    }
    public class Questions
    {
        public string QuestionIntro = "The following questions are important to ask yourself because they may alter when you should get certain parts of your vehicle changed/inspected. \n";
        public string QuestionOne = "What level of auto-mechanical experience do you have? Are you a beginner, at an intermediate level, or advanced level? This answer will determine whether or not you should change/inspect certain aspects of your vehicle yourself or should have a professional mechanic do it. \n";
        public string QuestionTwo = "What kind of oil do you use? Regular or Synthetic? Newer cars tend to use synthetic oil more often than regular oil. If you use synthetic oil, you will not need to get your oil changed as frequently as someone who uses regular oil in their vehicle. \n";
        public string QuestionThree = "Does the majority of your driving occur in locations with steep inclines or even ground? The answer to this question will determine how often you should change your oil, get an engine diagnstic, and inspect your transmission system because steeper inclines tend to overwork your engine, transmission system, and make you run through oil more quickly. \n";
        public string QuestionFour = "How flat or bumpy is the terrain you drive on? The answer to this question will determine how often you should check up on your suspension components and tires. If you frequently drive on bumpy,rocky ground your suspension and tires gets worn down more quickly than if you primarily drive on flat, paved roads. \n";
        public string QuestionFive = "How clean is the air in the areas you primarily drive? The answer to this question will determine how often you should change your engine air filter and cabin air filter.  If you drive in an area with poor air quality laden with dust particles then you should probably change out your air filters more frequently than if you primarily drove in areas with better air quality.\n";
        public string QuestionSix = "What kind of spark plugs do you use? Having either copper, iridium, or platinum spark plugs simply influences the mileages you should inspect/change your spark plugs. Copper spark plugs get fouled easier, are cheaper, and don't last nearly as long as iridium or platinum ones. If you use copper spark plugs you should also make it a habit to pay more attention to your starting and ignition systems. \n";
        public string QuestionSeven = "How often do you drive? How frequntly you drive is the catch all for checking up on your vehicle. If you drive 6,000 miles a year (well below average), then you wont need to maintain your car as frequently or dilligently as someone who averages 16,000 miles a year or more. \n";
    }
    public enum FrontTireChange
    {
        FrontWheelDrive, // 30k - 50k
        RearWheelDrive, // 50k - 70k
        AllWheelDrive // 50k
    }

    public enum RearTireChange
    {
        FrontWheelDrive, // 50k - 70k
        RearWheelDrive, // 30k - 50k
        AllWheelDrive, // 50k
    }
    public class VehicleInformation
    {
        public int RegularOilAndFilterChange { get; set; } // 3k - 4k
        public int SynthetiOilAndFilterChange { get; set; } // 5k - 10k
        public int TireRotation { get; set; } // 6k - 8k
        public int TireAlignment { get; set; } // 9k - 13k
        public int CompleteInspection { get; set; } // 15k
        public int EngineAirFilterChange { get; set; } // 20k - 30k
        public int CabinAirFilterChange { get; set; } // 20k - 30k
        public int CopperSparkPlugsChange { get; set; } // 20k - 30k
        public int FuelFilterChange { get; set; } // 30k
        public int BrakeFluidChange { get; set; } // 30k - 45k
        public int TransmissionFluidAndPanGasketAndFilterChange { get; set; } // 30k - 50k
        public int BrakePadChange { get; set; } // 45k - 50k
        public int BatteryChange { get; set; } // 50k - 60k
        public int EngineCoolantChange { get; set; } // 60k
        public int HVACInspection { get; set; } // 60k
        public int SuspensionComponentInspection { get; set; } // 60k
        public int SteeringSystemInspection { get; set; } // 60k
        public int BrakeRotorChange { get; set; } // 60k - 70k
        public int RadiatorHoseChange { get; set; } // 60k - 70k
        public int TimingBeltChange { get; set; } // 60k - 80k
        public int PowerSteeringFluidChange { get; set; } // 70k
        public int PlatinumOrIridiumSparkPlugChange { get; set; } // 90k - 100k
        public int CompleteRubberCrackInspection { get; set; } // 100k
        public int AlternatorChange { get; set; } // 100k - 150k
    }
}
