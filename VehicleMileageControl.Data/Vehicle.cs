using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMileageControl.Data
{
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
    public class Vehicle
    {
        [Required]
        public int RegularOilAndFilterChange { get; set; } // 3k - 4k
        [Required]
        public int SynthetiOilAndFilterChange { get; set; } // 5k - 10k
        [Required]
        public int TireRotation { get; set; } // 6k - 8k
        [Required]
        public int TireAlignment { get; set; } // 9k - 13k
        [Required]
        public int CompleteInspection { get; set; } // 15k
        [Required]
        public int EngineAirFilterChange { get; set; } // 20k - 30k
        [Required]
        public int CabinAirFilterChange { get; set; } // 20k - 30k
        [Required]
        public int CopperSparkPlugsChange { get; set; } // 20k - 30k
        [Required]
        public int FuelFilterChange { get; set; } // 30k
        [Required]
        public int BrakeFluidChange { get; set; } // 30k - 45k
        [Required]
        public int TransmissionFluidAndPanGasketAndFilterChange { get; set; } // 30k - 50k
        [Required]
        public int BrakePadChange { get; set; } // 45k - 50k
        [Required]
        public int BatteryChange { get; set; } // 50k - 60k
        [Required]
        public int EngineCoolantChange { get; set; } // 60k
        [Required]
        public int HVACInspection { get; set; } // 60k
        [Required]
        public int SuspensionComponentInspection { get; set; } // 60k
        [Required]
        public int BrakeRotorChange { get; set; } // 60k - 70k
        [Required]
        public int RadiatorHoseChange { get; set; } // 60k - 70k
        [Required]
        public int TimingBeltChange { get; set; } // 60k - 80k
        [Required]
        public int PowerSteeringFluidChange { get; set; } // 70k
        [Required]
        public int PlatinumOrIridiumSparkPlugChange { get; set; } // 90k - 100k
        [Required]
        public int CompleteRubberCrackInspection { get; set; } // 100k
    }
}
