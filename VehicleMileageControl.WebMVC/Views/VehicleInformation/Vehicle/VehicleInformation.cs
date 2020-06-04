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
        public string DisclaimerStatement = "The information provided by this app does not replace seeing a professional auto-mechanic. The creator of this app is not responsible for any damage that occurs to a vehicle based of the use of this app. \n";
    }
    public class Questions
    {
        public string QuestionIntro = "The following questions are important to ask yourself because they may alter when you should get certain parts of your vehicle changed/inspected. \n";
        public string QuestionOne = "What level of auto-mechanical experience do you have? Are you a beginner, at an stringermediate level, or advanced level? This answer will determine whether or not you should change/inspect certain aspects of your vehicle yourself or should have a professional mechanic do it. \n";
        public string QuestionTwo = "What kind of oil do you use? Regular or Synthetic? Newer cars tend to use synthetic oil more often than regular oil. If you use synthetic oil, you will not need to get your oil changed as frequently as someone who uses regular oil in their vehicle. \n";
        public string QuestionThree = "Does the majority of your driving occur in locations with steep inclines or even ground? The answer to this question will determine how often you should change your oil, get an engine diagnstic, and inspect your transmission system because steeper inclines tend to overwork your engine, transmission system, and make you run through oil more quickly. \n";
        public string QuestionFour = "How flat or bumpy is the terrain you drive on? The answer to this question will determine how often you should check up on your suspension components and tires. If you frequently drive on bumpy,rocky ground your suspension and tires gets worn down more quickly than if you primarily drive on flat, paved roads. \n";
        public string QuestionFive = "How clean is the air in the areas you primarily drive? The answer to this question will determine how often you should change your engine air filter and cabin air filter.  If you drive in an area with poor air quality laden with dust particles then you should probably change out your air filters more frequently than if you primarily drove in areas with better air quality.\n";
        public string QuestionSix = "What kind of spark plugs do you use? Having either copper, iridium, or platinum spark plugs simply influences the mileages you should inspect/change your spark plugs. Copper spark plugs get fouled easier, are cheaper, and don't last nearly as long as iridium or platinum ones. If you use copper spark plugs you should also make it a habit to pay more attention to your starting and ignition systems. \n";
        public string QuestionSeven = "How often do you drive? How frequntly you drive is the catch all for checking up on your vehicle. If you drive 6,000 miles a year (well below average), then you wont need to mastringain your car as frequently or dilligently as someone who averages 16,000 miles a year or more. \n";
    }
    public class VehicleInformation
    {
        [Key]
        public int VehicleInformationId { get; set; }
        [Required]
        public Guid VehicleInformationOwnerId { get; set; }
        
        public string NewVehicleInformation { get; set; }
        public string OilAndFilterChange
        {
            get { return OilAndFilterChange; }
            set
            {
                OilAndFilterChange =
                    "Oil change intervals vary by manufacturer and engines, so consult your owner's manual or maintenance schedule to see how often to change the oil in your vehicle and what type of oil to use. You may be surprised. We were surprised to learn that the Camry's 2.5-liter engine requires 0W20 synthetic oil, for instance. Manufacturers suggest you change oil more often for 'severe' driving conditions, such as frequent trailer towing, extensive stop-go driving or idling in traffic, driving in extreme heat or cold, or frequent short-distance driving in which the engine doesn't reach full operating temperature. \n";
            }
        } // 3k - 10k
        public string TireRotation // 6k - 8k
        {
            get { return TireRotation; }
            set
            {
                TireRotation =
                    "Most vehicle manufacturers recommend that the tires be rotated on the same schedule as oil changes. In most cases that means every 7,500 miles or six months, though some have stretched the oil-change interval to 10,000 miles, such as on many Fords, Volkswagens and Toyotas. BMW allows up to 15,000 miles between oil changes, but that is too long to wait to rotate the tires. Unless you drive fewer than about 7,500 miles per year, you should probably rotate tires every six months or so. \n";
            }
        }
        public string TireAlignment // 8k - 13k
        {
            get { return TireAlignment; }
            set
            {
                TireAlignment =
                    "Depending on the vehicle, proper wheel alignment involves setting the camber (inward or outward tilt of the wheels when looking head on), caster (wheel tilt front or back looking from the side) and toe-in or toe-out (looking down at the wheels from above). The adjustments are measured in fractions of an inch and require specialized alignment equipment. Wheel alignment isn't usually listed by vehicle manufacturers on the recommended maintenance schedule, so how often it should be done is open-ended. If your vehicle tracks as straight as an arrow, you're wheels likely are properly aligned. Even so, it's a good idea to have your alignment checked annually, such as when you have your tires rotated. \n";
            }
        }
        public string EngineAirFilterChange // 20k - 30k
        {
            get { return EngineAirFilterChange; }
            set
            {
                EngineAirFilterChange =
                    "Engine air filters are mounted in the air intake system to catch dirt and other particles that could damage internal engine parts. They’re usually made of paper (some are made of cotton or other materials) and should be replaced according to your manufacturer’s maintenance schedule. A dirty or clogged air filter will restrict air going into the engine, which in turn restricts the amount of fuel injected. The EPA says the main result is a loss of acceleration, with minimal impact on fuel economy. \n" +
                    "Most modern cars also have a cabin air filter that catches dirt, debris and some allergens in the air that goes through the heating, ventilation and air - conditioning systems.Cabin air filters also need periodic changing, sometimes more frequently than engine air filters. \n";
            }
        }
        public string CabinAirFilterChange // 20k - 30k
        {
            get { return CabinAirFilterChange; }
            set
            {
                CabinAirFilterChange =
                    "The cabin air filter serves to clean the air drawn in by your car’s ventilation system. A car may have multiple filters to achieve different objectives, such as to limit pollen or odors, to provide sequential filtering or just for “packaging” reasons: to provide enough filtering and airflow in a tight space. \n" +
                    "Manufacturers commonly recommend filter replacement every one to two years, but it depends on the car, filter type and how dusty your environment is; check your owner’s manual for recommendations.Odors, inadequate airflow and disproportionately loud fan noise are signs that the filter needs replacement. \n";
            }
        }
        public string FuelFilterChange // 30k
        {
            get { return FuelFilterChange; }
            set
            {
                FuelFilterChange =
                    "The fuel filter traps debris that could clog or damage the fuel injectors or engine. Fuel filters are usually located in the fuel line where it meets the fuel injection system at the engine or just in front of the rear wheels attached to the frame, but some cars use a filter only in the fuel tank itself. \n" +
                    "Manufacturers usually set a replacement interval for fuel filters, though the period can vary widely.A clogged filter can occur at any time, however, and can result in a check engine light or rough engine performance. \n";
            }
        }
        public string BrakeFluidChange // 30k - 45k
        {
            get { return BrakeFluidChange; }
            set
            {
                BrakeFluidChange =
                    "Brake fluid transfers the force of your foot pressing on the brake pedal to the brakes at all four wheels. Fluid-filled, air-free channels extend from the master cylinder in the engine compartment through brake lines (rigid tubes) and flexible hoses to cylinders that activate calipers or drum brakes. In newer cars, antilock braking system hardware is an intermediate component. \n" +
                    "Brake fluid reservoirs are often constructed of translucent plastic to simplify checking the fluid level.Some cars incorporate a warning light to indicate if the level drops too low. A healthy brake system won’t lose fluid, though the level may decrease as the brake pads wear.Dramatic fluid loss is cause for investigation. \n";
            }
        }
        public string TransmissionFluidAndFilterChange // 30k - 50k
        {
            get { return TransmissionFluidAndFilterChange; }
            set
            {
                TransmissionFluidAndFilterChange =
                    "Like other vital automotive fluids, transmission fluid deteriorates over time. Hard use - such as frequent stop-and-go city driving, hauling heavy loads, trailer towing - will accelerate the deterioration. That kind of driving raises the operating temperature of the transmission, and heat puts more strain on the transmission and the fluid, which helps facilitate gear shifts, cools the transmission and lubricates moving parts. \n";
            }
        }
        public string TransmissionSystemsInspection // 50k
        {
            get { return TransmissionSystemsInspection; }
            set
            {
                TransmissionSystemsInspection =
                    "The transmission serves three main roles: \n" +
                    "1) It connects and disconnects the motor from the rest of the drivetrain(drive shafts, axles, wheels). \n" +
                    "2) It provides gearing that allows the engine’s limited range of operation to take the car from a standstill to high speeds. \n" +
                    "3) It allows the driver to change direction from forward to backward. \n" +
                    "Additionally, transmissions can serve to hold the car in place when it’s off, either in the Park setting(automatics) or by remaining in gear(manuals). \n" +
                    "Thanks to tech advancements for both transmissions and lubricants, many of today’s transmissions require less maintenance, or less frequent maintenance, than they used to.See more detail in the automatic transmission and manual transmission entries. \n";
            }
        }
        public string BrakePadChange // 45k - 50k
        {
            get { return BrakePadChange; }
            set
            {
                BrakePadChange =
                    "In disc-brake systems, the brake pads are the friction material the caliper squeezes against the rotating disc, or rotor, to slow the wheel’s rotation and stop the car. In drum brakes, the pads are called shoes. \n" +
                    "Subject to tremendous friction and heat, brake pads wear down and must be replaced as part of a car’s regular maintenance. How long they last depends both on the car’s design and how it is driven. \n";
            }
        }
        public string BatteryChange // 50k - 60k
        {
            get { return BatteryChange; }
            set
            {
                BatteryChange =
                    "If you own or lease a vehicle for more than three years, at some point you’ll have to replace the battery. Over time, a battery’s capacity to store electricity will diminish, or it will suffer physical damage such as a cracked case. \n" +
                    "How soon a battery needs replacing depends on a number of factors, such as the number of times it’s used to start the engine. Where it lives is also a factor; although battery failure is most often associated with cold weather, hot temperatures do more to shorten battery life by evaporating the fluid and destroying cells inside the battery. Whereas a battery might last three to five years in the Northeast, it could need replacing sooner in Arizona or Florida. \n" +
                    "Batteries frequently get blamed for all sorts of electrical issues, but they’re only one part of a car’s charging system.Batteries store the electrical power that starts the engine and operates accessories, such as the lights, power locks and windows, and the stereo.The battery depends on the alternator to generate electricity and a voltage regulator to control the amount of electricity generated.If either of those components becomes worn or fails, the battery won’t be fully charged and able to do its part. \n" +
                    "That’s why it pays it have the entire charging system checked before replacing a battery to make sure the problem isn’t somewhere else.Many parts stores(as well as repair shops) will check a battery’s state of charge and reserve capacity for free, but just replacing the battery won’t fix problems caused by the alternator, voltage regulator, or damaged electrical connectors or cables, or if the belt that drives the alternator is loose or worn. \n";
            }
        }
        public string EngineCoolingSystemInspection // 55k
        {
            get { return EngineCoolingSystemInspection; }
            set
            {
                EngineCoolingSystemInspection =
                    "A vehicle’s engine-cooling system serves not just to keep the engine cool, but to also keep its temperature warm enough to ensure efficient, clean operation. System components include a radiator to dissipate heat, a fan or fans to ensure adequate airflow for radiator cooling, a thermostat valve that opens when the desired operating temperature is reached and a water pump (or coolant pump) to circulate coolant through the engine, hoses and other components. Most vehicles now employ an expansion tank that allows the coolant to expand, and exit, the cooling circuit when hot, and to return when the car is turned off and the engine cools. \n" +
                    "The cooling system also incorporates elements of the cabin’s ventilation system, because engine heat is used to warm the car’s interior. \n";
            }
        }
        public string EngineCoolantChange // 55k
        {
            get { return EngineCoolantChange; }
            set
            {
                EngineCoolantChange =
                    "Coolant, technically called engine coolant, is the liquid that circulates through your engine and radiator to maintain the desired operating temperature. Often mistakenly called antifreeze, coolant is a mixture of water and antifreeze, which is a liquid that prevents not just freezing but also boiling, either of which could cause the engine to overheat. (Coolant is not to be confused with refrigerant, the pressurized gas that allows the air conditioning to keep the cabin cool.) \n" +
                    "Engine coolant should be checked according to the manufacturer’s recommendation(check your owner’s manual) to ensure there’s enough, and that it’s in good condition. A replacement interval is also provided in the manual, and it varies with the make and model. \n";
            }
        }
        public string StrutCheck // 60k
        {
            get { return StrutCheck; }
            set
            {
                StrutCheck =
                    "Part of a rack-and-pinion steering system, the rack is a bar parallel to the front axle that moves left or right when the steering wheel is turned, aiming the front wheels in the correct direction. The pinion is a small gear at the end of the vehicle’s steering column that engages the rack. \n" +
                    "Though steering racks are hearty, they sometimes require replacement. Signs of a failing rack include difficulty turning the steering wheel in one direction but not the other, jerkiness of motion or noises. \n";
            }
        }
        public string SteeringRackCheck // 60k
        {
            get { return SteeringRackCheck; }
            set
            {
                SteeringRackCheck =
                    "Part of a rack-and-pinion steering system, the rack is a bar parallel to the front axle that moves left or right when the steering wheel is turned, aiming the front wheels in the correct direction. The pinion is a small gear at the end of the vehicle’s steering column that engages the rack. \n" +
                    "Though steering racks are hearty, they sometimes require replacement. Signs of a failing rack include difficulty turning the steering wheel in one direction but not the other, jerkiness of motion or noises. \n";
            }
        }
        public string BrakeRotorChange // 60k - 70k
        {
            get { return BrakeRotorChange; }
            set
            {
                BrakeRotorChange =
                    "The technical name for the disc in disc brakes, the rotor is a metal platter that’s part of the hub to which a car’s wheel attaches. It rotates with the wheel, so when the driver applies the brakes, causing the calipers to squeeze their brake pads against the rotors, the resulting friction slows the wheels’ rotation and stops the car. \n" +
                    "Rotors are durable and intended to last longer than brake pads, but they aren’t designed to last forever.When worn down, they must be replaced. If rotors become warped or pitted, sometimes they can be machined(also called “resurfaced” or “turned”), but rotor prices have come down enough that replacement is more common than it used to be. \n";
            }
        }
        public string RadiatorHoseChange // 60k - 70k
        {
            get { return RadiatorHoseChange; }
            set
            {
                RadiatorHoseChange =
                    "Radiator hoses are large-diameter rubber hoses that carry engine coolant between the engine and radiator and back toward the water pump. \n" +
                    "Radiator hoses should be inspected as part of routine maintenance to ensure their integrity.Signs of damage or deterioration call for a precautionary repair that’s much easier and less disruptive than the alternative. \n";
            }
        }
        public string TimingBeltChange // 60k - 80k
        {
            get { return TimingBeltChange; }
            set
            {
                TimingBeltChange =
                    "The timing belt is a notched rubber belt, sometimes called a Gilmer belt. This belt allows the crankshaft to drive the camshaft, which in turn opens and closes the valves. Without this belt, the engine can't run. \n";
            }
        }
        public string FuelTankPressureSensorCheck // 70k
        {
            get { return FuelTankPressureSensorCheck; }
            set
            {
                FuelTankPressureSensorCheck =
                    "The fuel tank pressure sensor is part of the fuel pump assembly and is mounted on top of the tank or inside the tank. It’s part of the evaporative emissions system (commonly referred to as “EVAP”) and reads pressure in the fuel system to detect evaporative leaks, such as a loose or faulty gas cap. Fuel vapors are supposed to be contained in the EVAP system, and leaks can allow vapors to escape into the atmosphere. \n" +
                    "The sensor is connected to the engine computer, and when the sensor detects a leak, or if the sensor itself fails, it illuminates the “check engine” light.Mechanics can read a trouble code to trace it to a leak in the evaporative emissions system or the sensor. \n" +
                    "Fixing an evaporative leak may not require removing the fuel tank, but checking or replacing a faulty sensor usually does. \n";
            }
        }
        public string FuelSystemsInspection // 70k
        {
            get { return FuelSystemsInspection; }
            set
            {
                FuelSystemsInspection =
                    "A vehicle’s fuel system comprises components that deliver fuel from the tank to the engine, including a fuel pump, fuel lines, a fuel-pressure regulator, fuel filter and fuel injectors. \n" +
                    "Fuel system components are built to last, so the fuel filter is the only part that’s likely to require replacement on a schedule. \n";
            }
        }
        public string PowerSteeringPumpInspection // 70k
        {
            get { return PowerSteeringPumpInspection; }
            set
            {
                PowerSteeringPumpInspection =
                    "The power-steering pump pressurizes the hydraulic fluid that helps the driver turn the steering wheel. \n" +
                    "Signs of steering - pump failure include leaks, noises or decreased assistance while steering.The immediate loss of power assist is more likely a sign of a broken drive belt or the loss of steering fluid.Most vehicles employ this type of mechanical / hydraulic power steering, but because their pumps rob power and efficiency even when the car isn’t turning, a small percentage of cars use an electric pump and many new vehicles now have electric power assist. \n";
            }
        }
        public string SparkPlugChange // 20k - 100k
        {
            get { return SparkPlugChange; }
            set
            {
                SparkPlugChange =
                    "Spark plugs, which screw into the top of an engine’s cylinders, create the electric spark required to ignite the compressed air-fuel mixture in gas-powered engines. The right type of plug and the size of the gap between the electrodes at the tip are specified by the automaker, and using the right ones are crucial to proper performance. \n" +
                    "A fouled, worn or loose plug can cause rough running or abnormal noises. Longer replacement intervals, typically around 100,000 miles in newer cars, have simplified plug maintenance, but they’ve also led manufacturers to justify making them more labor-intensive and expensive than ever to replace. \n";
            }
        }
        public string DriveTrainInspection // 100k
        {
            get { return DriveTrainInspection; }
            set
            {
                DriveTrainInspection =
                    "A vehicle’s drivetrain includes all the components that make it move, from the engine to the wheels. The intermediate elements are the transmission, driveshaft(s) and drive axles. The parts between the transmission and wheels, which can comprise either two- or four-wheel-drive components, are known as the driveline. \n";
            }
        }
        public string AlternatorChange // 100k - 150k
        {
            get { return AlternatorChange; }
            set
            {
                AlternatorChange =
                    "The alternator is a generator that produces electricity to power the car’s ignition system, lights and accessories. The engine drives the alternator by means of a belt, either with a dedicated belt or a belt shared with other pulley-driven components. \n" +
                    "An alternator will stop immediately if its drive belt breaks, but alternators can also fail over time and with use, requiring replacement.Failing alternators can result in repeatedly drained batteries, dimming headlights and localized noise. \n";
            }
        }
        public string CatalyticConverterCheck // 100k - 150k
        {
            get { return CatalyticConverterCheck; }
            set
            {
                CatalyticConverterCheck =
                    "The catalytic converter is located upstream of the muffler, close to the engine, and it changes environmentally damaging pollutants in the exhaust stream into more benign gases. Under extreme heat, precious metals in a honeycomb structure catalyze the chemical reactions; they make today’s vehicles dramatically cleaner than older vehicles. \n" +
                    "Catalytic converters can be both causes and victims of check engine lights. A failing “cat” can trigger a check engine light and / or produce an unpleasant exhaust odor, but converter failure is often caused by abnormal combustion and rough engine operation, sometimes accompanied by a blinking check engine light. Because of its precious metals content, converters are expensive to replace and often targeted by thieves. \n";
            }
        }
    }
}