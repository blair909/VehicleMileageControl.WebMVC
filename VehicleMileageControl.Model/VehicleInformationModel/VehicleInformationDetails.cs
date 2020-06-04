using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Model.VehicleInformation
{
    public class VehicleInformationDetails
    {
        [Display(Name = "Vehicle Information Id")]
        public int VehicleInformationId { get; set; }
        public string a;
        public string b;
        public string c;
        public string d;
        public string e;
        public string f;
        public string g;
        public string h;
        public string i;
        public string j;
        public string k;
        public string l;
        public string m;
        public string n;
        public string o;
        public string p;
        public string q;
        public string r;
        public string s;
        public string t;
        public string u;
        public string v;
        public string w;
        public string x;
        public string y;
        [Display(Name = "Oil and Oil Filter")]
        public string OilAndFilterChange // 3k - 10k
        {
            get { return a; }
            set
            {
                a =
                    "Oil change intervals vary by manufacturer and engines, so consult your owner's manual or maintenance schedule to see how often to change the oil in your vehicle and what type of oil to use. You may be surprised. We were surprised to learn that the Camry's 2.5-liter engine requires 0W20 synthetic oil, for instance. Manufacturers suggest you change oil more often for 'severe' driving conditions, such as frequent trailer towing, extensive stop-go driving or idling in traffic, driving in extreme heat or cold, or frequent short-distance driving in which the engine doesn't reach full operating temperature. \n";
            }
        }
        [Display(Name = "Tire Rotation")]
        public string TireRotation // 6k - 8k
        {
            get { return b; }
            set
            {
                b =
                    "Most vehicle manufacturers recommend that the tires be rotated on the same schedule as oil changes. In most cases that means every 7,500 miles or six months, though some have stretched the oil-change interval to 10,000 miles, such as on many Fords, Volkswagens and Toyotas. BMW allows up to 15,000 miles between oil changes, but that is too long to wait to rotate the tires. Unless you drive fewer than about 7,500 miles per year, you should probably rotate tires every six months or so. \n";
            }
        }
        [Display(Name = "Tire Alignment")]
        public string TireAlignment // 8k - 13k
        {
            get { return c; }
            set
            {
                c =
                    "Depending on the vehicle, proper wheel alignment involves setting the camber (inward or outward tilt of the wheels when looking head on), caster (wheel tilt front or back looking from the side) and toe-in or toe-out (looking down at the wheels from above). The adjustments are measured in fractions of an inch and require specialized alignment equipment. Wheel alignment isn't usually listed by vehicle manufacturers on the recommended maintenance schedule, so how often it should be done is open-ended. If your vehicle tracks as straight as an arrow, you're wheels likely are properly aligned. Even so, it's a good idea to have your alignment checked annually, such as when you have your tires rotated. \n";
            }
        }
        [Display(Name = "Engine Air Filter")]
        public string EngineAirFilterChange // 20k - 30k
        {
            get { return d; }
            set
            {
                d =
                    "Engine air filters are mounted in the air intake system to catch dirt and other particles that could damage internal engine parts. They’re usually made of paper (some are made of cotton or other materials) and should be replaced according to your manufacturer’s maintenance schedule. A dirty or clogged air filter will restrict air going into the engine, which in turn restricts the amount of fuel injected. The EPA says the main result is a loss of acceleration, with minimal impact on fuel economy. \n" +
                    "Most modern cars also have a cabin air filter that catches dirt, debris and some allergens in the air that goes through the heating, ventilation and air - conditioning systems.Cabin air filters also need periodic changing, sometimes more frequently than engine air filters. \n";
            }
        }
        [Display(Name = "Cabin Air Filter")]
        public string CabinAirFilterChange // 20k - 30k
        {
            get { return e; }
            set
            {
                e =
                    "The cabin air filter serves to clean the air drawn in by your car’s ventilation system. A car may have multiple filters to achieve different objectives, such as to limit pollen or odors, to provide sequential filtering or just for “packaging” reasons: to provide enough filtering and airflow in a tight space. \n" +
                    "Manufacturers commonly recommend filter replacement every one to two years, but it depends on the car, filter type and how dusty your environment is; check your owner’s manual for recommendations.Odors, inadequate airflow and disproportionately loud fan noise are signs that the filter needs replacement. \n";
            }
        }
        [Display(Name = "Fuel Filter")]
        public string FuelFilterChange // 30k
        {
            get { return f; }
            set
            {
                f =
                    "The fuel filter traps debris that could clog or damage the fuel injectors or engine. Fuel filters are usually located in the fuel line where it meets the fuel injection system at the engine or just in front of the rear wheels attached to the frame, but some cars use a filter only in the fuel tank itself. \n" +
                    "Manufacturers usually set a replacement interval for fuel filters, though the period can vary widely.A clogged filter can occur at any time, however, and can result in a check engine light or rough engine performance. \n";
            }
        }
        [Display(Name = "Brake Fluid")]
        public string BrakeFluidChange // 30k - 45k
        {
            get { return g; }
            set
            {
                g =
                    "Brake fluid transfers the force of your foot pressing on the brake pedal to the brakes at all four wheels. Fluid-filled, air-free channels extend from the master cylinder in the engine compartment through brake lines (rigid tubes) and flexible hoses to cylinders that activate calipers or drum brakes. In newer cars, antilock braking system hardware is an intermediate component. \n" +
                    "Brake fluid reservoirs are often constructed of translucent plastic to simplify checking the fluid level.Some cars incorporate a warning light to indicate if the level drops too low. A healthy brake system won’t lose fluid, though the level may decrease as the brake pads wear.Dramatic fluid loss is cause for investigation. \n";
            }
        }
        [Display(Name = "Transmission Fluid")]
        public string TransmissionFluidAndFilterChange // 30k - 50k
        {
            get { return h; }
            set
            {
                h =
                    "Like other vital automotive fluids, transmission fluid deteriorates over time. Hard use - such as frequent stop-and-go city driving, hauling heavy loads, trailer towing - will accelerate the deterioration. That kind of driving raises the operating temperature of the transmission, and heat puts more strain on the transmission and the fluid, which helps facilitate gear shifts, cools the transmission and lubricates moving parts. \n";
            }
        }
        [Display(Name = "Transmission Systems")]
        public string TransmissionSystemsInspection // 50k
        {
            get { return i; }
            set
            {
                i =
                    "The transmission serves three main roles: \n" +
                    "1) It connects and disconnects the motor from the rest of the drivetrain(drive shafts, axles, wheels). \n" +
                    "2) It provides gearing that allows the engine’s limited range of operation to take the car from a standstill to high speeds. \n" +
                    "3) It allows the driver to change direction from forward to backward. \n" +
                    "Additionally, transmissions can serve to hold the car in place when it’s off, either in the Park setting(automatics) or by remaining in gear(manuals). \n" +
                    "Thanks to tech advancements for both transmissions and lubricants, many of today’s transmissions require less maintenance, or less frequent maintenance, than they used to.See more detail in the automatic transmission and manual transmission entries. \n";
            }
        }
        [Display(Name = "Brake Pads")]
        public string BrakePadChange // 45k - 50k
        {
            get { return j; }
            set
            {
                j =
                    "In disc-brake systems, the brake pads are the friction material the caliper squeezes against the rotating disc, or rotor, to slow the wheel’s rotation and stop the car. In drum brakes, the pads are called shoes. \n" +
                    "Subject to tremendous friction and heat, brake pads wear down and must be replaced as part of a car’s regular maintenance. How long they last depends both on the car’s design and how it is driven. \n";
            }
        }
        [Display(Name = "Battery")]
        public string BatteryChange // 50k - 60k
        {
            get { return k; }
            set
            {
                k =
                    "If you own or lease a vehicle for more than three years, at some point you’ll have to replace the battery. Over time, a battery’s capacity to store electricity will diminish, or it will suffer physical damage such as a cracked case. \n" +
                    "How soon a battery needs replacing depends on a number of factors, such as the number of times it’s used to start the engine. Where it lives is also a factor; although battery failure is most often associated with cold weather, hot temperatures do more to shorten battery life by evaporating the fluid and destroying cells inside the battery. Whereas a battery might last three to five years in the Northeast, it could need replacing sooner in Arizona or Florida. \n" +
                    "Batteries frequently get blamed for all sorts of electrical issues, but they’re only one part of a car’s charging system.Batteries store the electrical power that starts the engine and operates accessories, such as the lights, power locks and windows, and the stereo.The battery depends on the alternator to generate electricity and a voltage regulator to control the amount of electricity generated.If either of those components becomes worn or fails, the battery won’t be fully charged and able to do its part. \n" +
                    "That’s why it pays it have the entire charging system checked before replacing a battery to make sure the problem isn’t somewhere else.Many parts stores(as well as repair shops) will check a battery’s state of charge and reserve capacity for free, but just replacing the battery won’t fix problems caused by the alternator, voltage regulator, or damaged electrical connectors or cables, or if the belt that drives the alternator is loose or worn. \n";
            }
        }
        [Display(Name = "Engine Cooling Systems")]
        public string EngineCoolingSystemInspection // 55k
        {
            get { return l; }
            set
            {
                l =
                    "A vehicle’s engine-cooling system serves not just to keep the engine cool, but to also keep its temperature warm enough to ensure efficient, clean operation. System components include a radiator to dissipate heat, a fan or fans to ensure adequate airflow for radiator cooling, a thermostat valve that opens when the desired operating temperature is reached and a water pump (or coolant pump) to circulate coolant through the engine, hoses and other components. Most vehicles now employ an expansion tank that allows the coolant to expand, and exit, the cooling circuit when hot, and to return when the car is turned off and the engine cools. \n" +
                    "The cooling system also incorporates elements of the cabin’s ventilation system, because engine heat is used to warm the car’s interior. \n";
            }
        }
        [Display(Name = "Engine Coolant")]
        public string EngineCoolantChange // 55k
        {
            get { return m; }
            set
            {
                m =
                    "Coolant, technically called engine coolant, is the liquid that circulates through your engine and radiator to maintain the desired operating temperature. Often mistakenly called antifreeze, coolant is a mixture of water and antifreeze, which is a liquid that prevents not just freezing but also boiling, either of which could cause the engine to overheat. (Coolant is not to be confused with refrigerant, the pressurized gas that allows the air conditioning to keep the cabin cool.) \n" +
                    "Engine coolant should be checked according to the manufacturer’s recommendation(check your owner’s manual) to ensure there’s enough, and that it’s in good condition. A replacement interval is also provided in the manual, and it varies with the make and model. \n";
            }
        }
        [Display(Name = "Struts")]
        public string StrutCheck // 60k
        {
            get { return n; }
            set
            {
                n =
                    "Part of a rack-and-pinion steering system, the rack is a bar parallel to the front axle that moves left or right when the steering wheel is turned, aiming the front wheels in the correct direction. The pinion is a small gear at the end of the vehicle’s steering column that engages the rack. \n" +
                    "Though steering racks are hearty, they sometimes require replacement. Signs of a failing rack include difficulty turning the steering wheel in one direction but not the other, jerkiness of motion or noises. \n";
            }
        }
        [Display(Name = "Steering Rack")]
        public string SteeringRackCheck // 60k
        {
            get { return o; }
            set
            {
                o =
                    "Part of a rack-and-pinion steering system, the rack is a bar parallel to the front axle that moves left or right when the steering wheel is turned, aiming the front wheels in the correct direction. The pinion is a small gear at the end of the vehicle’s steering column that engages the rack. \n" +
                    "Though steering racks are hearty, they sometimes require replacement. Signs of a failing rack include difficulty turning the steering wheel in one direction but not the other, jerkiness of motion or noises. \n";
            }
        }
        [Display(Name = "Brake Rotors")]
        public string BrakeRotorChange // 60k - 70k
        {
            get { return p; }
            set
            {
                p =
                    "The technical name for the disc in disc brakes, the rotor is a metal platter that’s part of the hub to which a car’s wheel attaches. It rotates with the wheel, so when the driver applies the brakes, causing the calipers to squeeze their brake pads against the rotors, the resulting friction slows the wheels’ rotation and stops the car. \n" +
                    "Rotors are durable and intended to last longer than brake pads, but they aren’t designed to last forever.When worn down, they must be replaced. If rotors become warped or pitted, sometimes they can be machined(also called “resurfaced” or “turned”), but rotor prices have come down enough that replacement is more common than it used to be. \n";
            }
        }
        [Display(Name = "Radiator Hoses")]
        public string RadiatorHoseChange // 60k - 70k
        {
            get { return q; }
            set
            {
                q =
                    "Radiator hoses are large-diameter rubber hoses that carry engine coolant between the engine and radiator and back toward the water pump. \n" +
                    "Radiator hoses should be inspected as part of routine maintenance to ensure their integrity.Signs of damage or deterioration call for a precautionary repair that’s much easier and less disruptive than the alternative. \n";
            }
        }
        [Display(Name = "Timing Belt")]
        public string TimingBeltChange // 60k - 80k
        {
            get { return r; }
            set
            {
                r =
                    "The timing belt is a notched rubber belt, sometimes called a Gilmer belt. This belt allows the crankshaft to drive the camshaft, which in turn opens and closes the valves. Without this belt, the engine can't run. \n";
            }
        }
        [Display(Name = "Fuel Tank Pressure Sensor")]
        public string FuelTankPressureSensorCheck // 70k
        {
            get { return s; }
            set
            {
                s =
                    "The fuel tank pressure sensor is part of the fuel pump assembly and is mounted on top of the tank or inside the tank. It’s part of the evaporative emissions system (commonly referred to as “EVAP”) and reads pressure in the fuel system to detect evaporative leaks, such as a loose or faulty gas cap. Fuel vapors are supposed to be contained in the EVAP system, and leaks can allow vapors to escape into the atmosphere. \n" +
                    "The sensor is connected to the engine computer, and when the sensor detects a leak, or if the sensor itself fails, it illuminates the “check engine” light.Mechanics can read a trouble code to trace it to a leak in the evaporative emissions system or the sensor. \n" +
                    "Fixing an evaporative leak may not require removing the fuel tank, but checking or replacing a faulty sensor usually does. \n";
            }
        }
        [Display(Name = "Fuel Systems")]
        public string FuelSystemsInspection // 70k
        {
            get { return t; }
            set
            {
                t =
                    "A vehicle’s fuel system comprises components that deliver fuel from the tank to the engine, including a fuel pump, fuel lines, a fuel-pressure regulator, fuel filter and fuel injectors. \n" +
                    "Fuel system components are built to last, so the fuel filter is the only part that’s likely to require replacement on a schedule. \n";
            }
        }
        [Display(Name = "PowerSteeringPump")]
        public string PowerSteeringPumpInspection // 70k
        {
            get { return u; }
            set
            {
                u =
                    "The power-steering pump pressurizes the hydraulic fluid that helps the driver turn the steering wheel. \n" +
                    "Signs of steering - pump failure include leaks, noises or decreased assistance while steering.The immediate loss of power assist is more likely a sign of a broken drive belt or the loss of steering fluid.Most vehicles employ this type of mechanical / hydraulic power steering, but because their pumps rob power and efficiency even when the car isn’t turning, a small percentage of cars use an electric pump and many new vehicles now have electric power assist. \n";
            }
        }
        [Display(Name = "Spark Plugs")]
        public string SparkPlugChange // 20k - 100k
        {
            get { return v; }
            set
            {
                v =
                    "Spark plugs, which screw into the top of an engine’s cylinders, create the electric spark required to ignite the compressed air-fuel mixture in gas-powered engines. The right type of plug and the size of the gap between the electrodes at the tip are specified by the automaker, and using the right ones are crucial to proper performance. \n" +
                    "A fouled, worn or loose plug can cause rough running or abnormal noises. Longer replacement intervals, typically around 100,000 miles in newer cars, have simplified plug maintenance, but they’ve also led manufacturers to justify making them more labor-intensive and expensive than ever to replace. \n";
            }
        }
        [Display(Name = "Drivetrain")]
        public string DriveTrainInspection // 100k
        {
            get { return w; }
            set
            {
                w =
                    "A vehicle’s drivetrain includes all the components that make it move, from the engine to the wheels. The intermediate elements are the transmission, driveshaft(s) and drive axles. The parts between the transmission and wheels, which can comprise either two- or four-wheel-drive components, are known as the driveline. \n";
            }
        }
        [Display(Name = "Alternator")]
        public string AlternatorChange // 100k - 150k
        {
            get { return x; }
            set
            {
                x =
                    "The alternator is a generator that produces electricity to power the car’s ignition system, lights and accessories. The engine drives the alternator by means of a belt, either with a dedicated belt or a belt shared with other pulley-driven components. \n" +
                    "An alternator will stop immediately if its drive belt breaks, but alternators can also fail over time and with use, requiring replacement.Failing alternators can result in repeatedly drained batteries, dimming headlights and localized noise. \n";
            }
        }
        [Display(Name = "Catalytic Converter")]
        public string CatalyticConverterCheck // 100k - 150k
        {
            get { return y; }
            set
            {
                y =
                    "The catalytic converter is located upstream of the muffler, close to the engine, and it changes environmentally damaging pollutants in the exhaust stream into more benign gases. Under extreme heat, precious metals in a honeycomb structure catalyze the chemical reactions; they make today’s vehicles dramatically cleaner than older vehicles. \n" +
                    "Catalytic converters can be both causes and victims of check engine lights. A failing “cat” can trigger a check engine light and / or produce an unpleasant exhaust odor, but converter failure is often caused by abnormal combustion and rough engine operation, sometimes accompanied by a blinking check engine light. Because of its precious metals content, converters are expensive to replace and often targeted by thieves. \n";
            }
        }
    }
}
