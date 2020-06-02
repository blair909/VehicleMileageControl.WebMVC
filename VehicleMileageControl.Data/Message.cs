using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public Guid MessageOwnerId { get; set; }
        public string MessageOne
        {
            get { return MessageOne; }
            set { MessageOne = "Every 3,000 miles. It's probably time to change your oil and oil filter (regular oil). \n"; }
        }
        public string MessageTwo
        {
            get { return MessageTwo; }
            set { MessageTwo = "Every 6,000 miles. It's probably time for a tire rotation. \n"; }
        }
        public string MessageThree
        {
            get { return MessageThree; }
            set { MessageThree = "Every 7,000 miles. Consider changing your oil and oil filter (synthetic oil). \n"; }
        }
        public string MessageFour
        {
            get { return MessageFour; }
            set { MessageFour = "Every 9,000 miles. Based on your mileage it could be time for a tire aligment. \n"; }
        }
        public string MessageFive
        {
            get { return MessageFive; }
            set { MessageFive = "Every 15,000 miles. It's time for a complete vehicle inspection. \n"; }
        }
        public string MessageSix
        {
            get { return MessageSix; }
            set { MessageSix = "Every 20,000 miles. It's possible you need to change out your engine air filter. \n"; }
        }
        public string MessageSeven
        {
            get { return MessageSeven; }
            set { MessageSeven = "Every 20,000 miles. It's possible you need to change out your cabin air filter. \n"; }
        }
        public string MessageEight
        {
            get { return MessageEight; }
            set { MessageEight = "Every 20,000 miles. It's probably time to get your spark plugs changed (copper). \n"; }
        }
        public string MessageNine
        {
            get { return MessageNine; }
            set { MessageNine = "Every 30,000 miles. Based on your mileage you should consider getting your fuel filter changed out. \n"; }
        }
        public string MessageTen
        {
            get { return MessageTen; }
            set { MessageTen = "Every 35,000 miles. It's about time to change your brake fluid. \n"; }
        }
        public string MessageEleven
        {
            get { return MessageEleven; }
            set { MessageEleven = "Every 40,000 miles. Around this mileage people normally change their transmission fluid and transmission filter. \n"; }
        }
        public string MessageTwelve
        {
            get { return MessageTwelve; }
            set { MessageTwelve = "Every 45,000 miles. It's time to get your brake pads looked at and get a full brake system inspection. \n"; }
        }
        public string MessageThirteen
        {
            get { return MessageThirteen; }
            set { MessageThirteen = "Every 50,000 miles. At your current mileage your battery may need to be replaced. You could also get an electrical/lighting systems inspection. \n"; }
        }
        public string MessageFourteen
        {
            get { return MessageFourteen; }
            set { MessageFourteen = "Every 55,000 miles. You could get your engine coolant levels assesed and/or changed. You could also get a cooling systems inspection. \n"; }
        }
        public string MessageFifteen
        {
            get { return MessageFifteen; }
            set { MessageFifteen = "Every 60,000 miles. It's probably time for a complete HVAC inspection. \n"; }
        }
        public string MessageSixteen
        {
            get { return MessageSixteen; }
            set { MessageSixteen = "Every 60,000 miles. At your mileage people often get a complete suspension component inspection and complete steering system inspection. \n"; }
        }
        public string MessageSeventeen
        {
            get { return MessageSeventeen; }
            set { MessageSeventeen = "Every 60,000 miles. You should consider getting your brake rotors assesed and changed. \n"; }
        }
        public string MessageEighteen
        {
            get { return MessageEighteen; }
            set { MessageEighteen = "Every 60,000 miles. It's probably time for a radiatior hose inspection and/or change. \n"; }
        }
        public string MessageNineteen
        {
            get { return MessageNineteen; }
            set { MessageNineteen = "Every 70,000 miles. You should consider getting your timing belt checked out for signs of wear and tear. While you're at it you could get a full engine inspection/tune-up. \n"; }
        }
        public string MessageTwenty
        {
            get { return MessageTwenty; }
            set { MessageTwenty = "Every 70,000 miles. It could be about time to change/flush your power steering fluid. \n"; }
        }
        public string MessageTwentyone
        {
            get { return MessageTwentyone; }
            set { MessageTwentyone = "Every 80,000 miles. It's most likely time to get your spark plugs changed (platinum or iridium). \n"; }
        }
        public string MessageTwentytwo
        {
            get { return MessageTwentytwo; }
            set { MessageTwentytwo = "Every 100,000 miles. At this high mileage people can check their rubber hoses and fixtures for signs of cracking and damage. You could also get your drive-train systems inspected. \n"; }
        }
        public string MessageTwentythree
        {
            get { return MessageTwentythree; }
            set { MessageTwentythree = "Every 40,000 miles. If you have a front-wheel drive train (FWD) it may be time to get new front tires. If you have a rear-wheel drive train (RWD) it is time to get new rear tires. \n"; }
        }
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
        public string MessageTwentysix
        {
            get { return MessageTwentysix; }
            set { MessageTwentysix = "Every 125,000 miles. Your alternator may need to be changed soon. \n"; }
        }
        public string MessageTwentyseven
        {
            get { return MessageTwentyseven; }
            set { MessageTwentyseven = "Every 50,000 miles. If you have an all-wheel drive train (AWD) it may be time to get a complete set of new tires. \n"; }
        }
        public string MessageTwentyeight
        {
            get { return MessageTwentyeight; }
            set { MessageTwentyeight = "Every 70,000 miles. You should get an exhaust/emissions systems inspection. "; }
        }
    }
}
