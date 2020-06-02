using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.MessageModel
{
    public class MessageDetails
    {
        [Display(Name = "Message Id")]
        public int MessageId { get; set; }
        [Display(Name = "Regular Oil")]
        public string MessageOne
        {
            get { return MessageOne; }
            set { MessageOne = "Every 3,000 miles. It's probably time to change your oil and oil filter (regular oil). \n"; }
        }
        [Display(Name ="Tire Rotation")]
        public string MessageTwo
        {
            get { return MessageTwo; }
            set { MessageTwo = "Every 6,000 miles. It's probably time for a tire rotation. \n"; }
        }
        [Display(Name = "Synthetic Oil")]
        public string MessageThree
        {
            get { return MessageThree; }
            set { MessageThree = "Every 7,000 miles. Consider changing your oil and oil filter (synthetic oil). \n"; }
        }
        [Display(Name = "Tire Alignment")]
        public string MessageFour
        {
            get { return MessageFour; }
            set { MessageFour = "Every 9,000 miles. Based on your mileage it could be time for a tire aligment. \n"; }
        }
        [Display(Name = "Complete Vehicle Inspection")]
        public string MessageFive
        {
            get { return MessageFive; }
            set { MessageFive = "Every 15,000 miles. It's time for a complete vehicle inspection. \n"; }
        }
        [Display(Name = "Engine Air Filter")]
        public string MessageSix
        {
            get { return MessageSix; }
            set { MessageSix = "Every 20,000 miles. It's possible you need to change out your engine air filter. \n"; }
        }
        [Display(Name = "Cabin Air Filter")]
        public string MessageSeven
        {
            get { return MessageSeven; }
            set { MessageSeven = "Every 20,000 miles. It's possible you need to change out your cabin air filter. \n"; }
        }
        [Display(Name = "Copper Spark Plugs")]
        public string MessageEight
        {
            get { return MessageEight; }
            set { MessageEight = "Every 20,000 miles. It's probably time to get your spark plugs changed (copper). \n"; }
        }
        [Display(Name = "Fuel Filter")]
        public string MessageNine
        {
            get { return MessageNine; }
            set { MessageNine = "Every 30,000 miles. Based on your mileage you should consider getting your fuel filter changed out. \n"; }
        }
        [Display(Name = "Brake Fluid")]
        public string MessageTen
        {
            get { return MessageTen; }
            set { MessageTen = "Every 35,000 miles. It's about time to change your brake fluid. \n"; }
        }
        [Display(Name = "Transmission Components")]
        public string MessageEleven
        {
            get { return MessageEleven; }
            set { MessageEleven = "Every 40,000 miles. Around this mileage people normally change their transmission fluid, transmission filter, and transmission pan gasket. \n"; }
        }
        [Display(Name = "Brake Pads")]
        public string MessageTwelve
        {
            get { return MessageTwelve; }
            set { MessageTwelve = "Every 45000 miles. It's time to get your brake pads looked at. \n"; }
        }
        [Display(Name = "Battery")]
        public string MessageThirteen
        {
            get { return MessageThirteen; }
            set { MessageThirteen = "Every 50,000 miles. At your current mileage your battery may need to be replaced. \n"; }
        }
        [Display(Name = "Engine Coolant")]
        public string MessageFourteen
        {
            get { return MessageFourteen; }
            set { MessageFourteen = "Every 55,000 miles. You could get your engine coolant levels assesed and/or changed. \n"; }
        }
        [Display(Name = "HVAC Inspection")]
        public string MessageFifteen
        {
            get { return MessageFifteen; }
            set { MessageFifteen = "Every 60,000 miles. It's probably time for a complete HVAC inspection. \n"; }
        }
        [Display(Name = "Suspension Components And Steering System")]
        public string MessageSixteen
        {
            get { return MessageSixteen; }
            set { MessageSixteen = "Every 60,000 miles. At your mileage people often get a complete suspension component inspection and complete steering system inspection. \n"; }
        }
        [Display(Name = "Brake Rotors")]
        public string MessageSeventeen
        {
            get { return MessageSeventeen; }
            set { MessageSeventeen = "Every 60,000 miles. You should consider getting your brake rotors assesed and changed. \n"; }
        }
        [Display(Name = "Radiator Hoses")]
        public string MessageEighteen
        {
            get { return MessageEighteen; }
            set { MessageEighteen = "Every 60,000 miles. It's probably time for a radiator hose inspection and/or change. \n"; }
        }
        [Display(Name = "Timing Belt")]
        public string MessageNineteen
        {
            get { return MessageNineteen; }
            set { MessageNineteen = "Every 70,000 miles. You should consider getting your timing belt checked out for signs of wear and tear.  If it snaps while the engine is running catastrophic engine failure could occur. \n"; }
        }
        [Display(Name = "Power Steering Fluid")]
        public string MessageTwenty
        {
            get { return MessageTwenty; }
            set { MessageTwenty = "Every 70,000 miles. It could be about time to change/flush your power steering fluid. \n"; }
        }
        [Display(Name = "Platinum/Iridium Spark Plugs")]
        public string MessageTwentyone
        {
            get { return MessageTwentyone; }
            set { MessageTwentyone = "Every 80,000 miles. It's most likely time to get your spark plugs changed (platinum or iridium). \n"; }
        }
        [Display(Name = "Rubber Hoses/Fixtures")]
        public string MessageTwentytwo
        {
            get { return MessageTwentytwo; }
            set { MessageTwentytwo = "Every 100,000 miles. At this high mileage people can check their rubber hoses and fixtures for signs of cracking and damage. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentythree
        {
            get { return MessageTwentythree; }
            set { MessageTwentythree = "Every 40,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new front tires. If you have a rear-wheel drive train (RWD) it is time to get new rear tires. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentyfour
        {
            get { return MessageTwentyfour; }
            set { MessageTwentyfour = "Every 60,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new rear tires. If you have a rear-wheel drive train (RWD) it is time to get new front tires. \n"; }
        }
        public string MessageTwentyfive
        {
            get { return MessageTwentyfive; }
            set { MessageTwentyfive = "Sorry, that input is invalid. \n"; }
        }
        [Display(Name = "Alternator")]
        public string MessageTwentysix
        {
            get { return MessageTwentysix; }
            set { MessageTwentysix = "Every 125,000 miles. Your alternator may need to be changed soon. \n"; }
        }
        [Display(Name = "Tires")]
        public string MessageTwentyseven
        {
            get { return MessageTwentyseven; }
            set { MessageTwentyseven = "Every 50,000 miles. If you have an all-wheel drive train (AWD) it may be time to get a complete set of new tires. "; }
        }
    }
}
