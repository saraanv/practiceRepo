using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Person
{
    public string  Name { get; set; }
    public int Age  { get; set; }
    public int NationalId { get; set; }

    public void GetDetails()
    {
        Console.WriteLine($"Name : {Name} , Age : {Age} , NationalId : {NationalId}");
    }
}
class Patient : Person
{
    public int PatientId { get; set; }
    public List<string> MedicalHistory = new List<string>();

    public void AddToMedicalHistory(string disease)
    {
        MedicalHistory.Add( disease );
    }

    public void GetDetails()
    {
        Console.WriteLine($"Name : {Name} , Age : {Age} , NationalId : {NationalId} " +
            $", Patient ID: {PatientId}");
        Console.WriteLine("Medical History:");
        foreach (var disease in MedicalHistory)
        {
            Console.WriteLine($"- {disease}");
        }
    }
}

class Doctor : Person
{
    public int DoctorId { get; set; }
    public string Specialization { get; set; }

    public void Diagnose(Patient patient , string diagnosis)
    {
        patient.AddToMedicalHistory( diagnosis );
    }
    public void GetDetails()
    {
        Console.WriteLine($"Name : {Name} , Age : {Age} , NationalId : {NationalId} " +
            $", Doctor ID : {DoctorId}, Specialization : {Specialization}");
    }
}
class Room
{
    public int RoomNumber  { get; set; }
    public int Capacity { get; set; }
    public List<Patient> Patients = new List<Patient>();

    public void AssignPatient(Patient patient)
    {
        if (Patients.Count >= Capacity )
        {
            throw new InvalidOperationException($"Room {RoomNumber} is full.");
        }
        else
        {
            Patients.Add(patient);
        }
    }
    public void RemovePatient(Patient patient)
    {
        Patients.Remove(patient);
    }
    public void GetDetails()
    {
        Console.WriteLine($"Room Number = {RoomNumber} , Capacity = {Capacity} , Current Patients = {Patients.Count}");

        foreach (var patient in Patients)
        {
            patient.GetDetails();
        }

    }
}



class Hospital
{
    public List<Doctor> Doctors = new List<Doctor>();
    public List<Room> Rooms = new List<Room>();

    public void AdmitPatient(Patient patient)
    {
        foreach (Room room in Rooms)
        {
            if (room.Capacity > room.Patients.Count)
            {
                room.AssignPatient(patient);
                Console.WriteLine($"Patient {patient.Name} added to room {room.RoomNumber} ");
                return;
            }
            else
            {
                Console.WriteLine("No available room");
            }
        }
    }
    public void DischargePatient(Patient patient)
    {
        foreach (Room room in Rooms)
        {
            if (room.Patients.Contains(patient))
            {
                room.RemovePatient(patient);
                Console.WriteLine($" Patient {patient} removed from {room.RoomNumber}");
                return;
            }
            else
            {
                Console.WriteLine($" Patient {patient} not found!");
            }
        }
    }
    public void PrintHospitalDetails()
    {
        Console.WriteLine("======== HOSPITAL DETAILS ========");

        Console.WriteLine("\n--- Doctors ---");
        foreach (var doctor in Doctors)
        {
            doctor.GetDetails();
        }

        Console.WriteLine("\n--- Rooms ---");
        foreach (var room in Rooms)
        {
            room.GetDetails();
        }

        Console.WriteLine("\n--- Patients in Hospital ---");
        foreach (var room in Rooms)
        {
            foreach (var patient in room.Patients)
            {
                patient.GetDetails();
            }
        }

        Console.WriteLine("==================================");
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();


            hospital.Doctors.Add(new Doctor { Name = "Rana", NationalId = 123, DoctorId = 1, Age = 27, Specialization = "MD" });
            hospital.Doctors.Add(new Doctor { Name = "Mahdi", NationalId = 234, DoctorId = 2, Age = 47, Specialization = "MD" });
            

            hospital.Rooms.Add(new Room { RoomNumber = 1, Capacity = 3 });
            hospital.Rooms.Add(new Room { RoomNumber = 2, Capacity = 2 });

            Patient patient1 = new Patient { Name = "Sara", NationalId = 123, PatientId = 1 , Age = 21 };
            patient1.AddToMedicalHistory("Cold");
            hospital.AdmitPatient(patient1);

            Patient patient2 = new Patient { Name = "Ali", NationalId = 1234, PatientId = 2 , Age = 22};
            patient2.AddToMedicalHistory("Corona");
            hospital.AdmitPatient(patient2);


            hospital.PrintHospitalDetails();    

    }
    }
