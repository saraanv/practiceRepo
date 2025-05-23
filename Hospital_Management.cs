using System;
using System.Collections.Generic;

class RoomFullException : Exception
{
    public RoomFullException(string message) : base(message) { }
}

public interface IDiagnosisStrategy
{
    void Diagnose(Patient patient, string diagnosis);
}

class GeneralDiagnosis : IDiagnosisStrategy
{
    public void Diagnose(Patient patient, string diagnosis)
    {
        patient.AddToMedicalHistory("General: " + diagnosis);
    }
}

class SpecialistDiagnosis : IDiagnosisStrategy
{
    public void Diagnose(Patient patient, string diagnosis)
    {
        patient.AddToMedicalHistory("Specialist: " + diagnosis);
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NationalId { get; set; }
    public virtual void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, NationalId: {NationalId}");
    }
}

public class Patient : Person
{
    public int PatientId { get; set; }
    public List<string> MedicalHistory = new List<string>();
    public void AddToMedicalHistory(string disease)
    {
        MedicalHistory.Add(disease);
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, NationalId: {NationalId}, Patient ID: {PatientId}");
        Console.WriteLine("Medical History:");
        foreach (var d in MedicalHistory)
        {
            Console.WriteLine($"- {d}");
        }
    }
}

public class Doctor : Person
{
    public int DoctorId { get; set; }
    public string Specialization { get; set; }
    public IDiagnosisStrategy DiagnosisStrategy { get; set; }
    public Doctor()
    {
        DiagnosisStrategy = new GeneralDiagnosis();
    }
    public void Diagnose(Patient patient, string diagnosis)
    {
        DiagnosisStrategy.Diagnose(patient, diagnosis);
    }
    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, NationalId: {NationalId}, Doctor ID: {DoctorId}, Specialization: {Specialization}");
    }
}

class Room
{
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }
    public List<Patient> Patients = new List<Patient>();
    public void AssignPatient(Patient patient)
    {
        if (Patients.Count >= Capacity)
        {
            throw new RoomFullException($"Room {RoomNumber} is full.");
        }
        Patients.Add(patient);
    }
    public void RemovePatient(Patient patient)
    {
        Patients.Remove(patient);
    }
    public void GetDetails()
    {
        Console.WriteLine($"Room Number: {RoomNumber}, Capacity: {Capacity}, Current Patients: {Patients.Count}");
        foreach (var p in Patients)
        {
            p.GetDetails();
        }
    }
}

public static class PersonFactory
{
    public static Person CreatePerson(string type, string name, int nationalId, int id, int age = 0, string specialization = "")
    {
        if (type == "Patient")
        {
            return new Patient { Name = name, NationalId = nationalId, PatientId = id, Age = age };
        }
        else if (type == "Doctor")
        {
            var doc = new Doctor { Name = name, NationalId = nationalId, DoctorId = id, Age = age, Specialization = specialization };
            if (specialization == "Specialist")
            {
                doc.DiagnosisStrategy = new SpecialistDiagnosis();
            }
            return doc;
        }
        else
        {
            throw new ArgumentException("Unknown person type.");
        }
    }
}

class Hospital
{
    private static Hospital _instance;
    public List<Doctor> Doctors = new List<Doctor>();
    public List<Room> Rooms = new List<Room>();
    private Hospital() { }
    public static Hospital GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Hospital();
        }
        return _instance;
    }
    public void AdmitPatient(Patient patient)
    {
        foreach (var r in Rooms)
        {
            if (r.Patients.Count < r.Capacity)
            {
                r.AssignPatient(patient);
                Console.WriteLine($"Patient {patient.Name} added to room {r.RoomNumber}");
                return;
            }
        }
        Console.WriteLine("No available room.");
    }
    public void DischargePatient(Patient patient)
    {
        foreach (var r in Rooms)
        {
            if (r.Patients.Contains(patient))
            {
                r.RemovePatient(patient);
                Console.WriteLine($"Patient {patient.Name} removed from room {r.RoomNumber}");
                return;
            }
        }
        Console.WriteLine($"Patient {patient.Name} not found.");
    }
    public void GetDetails()
    {
        Console.WriteLine("Doctors:");
        foreach (var d in Doctors)
        {
            d.GetDetails();
        }
        Console.WriteLine("Rooms:");
        foreach (var r in Rooms)
        {
            r.GetDetails();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var hospital = Hospital.GetInstance();

        var patient1 = (Patient)PersonFactory.CreatePerson("Patient", "Sara", 123, 1, 25);
        var patient2 = (Patient)PersonFactory.CreatePerson("Patient", "Ali", 124, 2, 30);

        var doctor1 = (Doctor)PersonFactory.CreatePerson("Doctor", "Rana", 223, 1, 40, "General");
        var doctor2 = (Doctor)PersonFactory.CreatePerson("Doctor", "Mahdi", 224, 2, 50, "Specialist");

        hospital.Doctors.Add(doctor1);
        hospital.Doctors.Add(doctor2);

        var room1 = new Room { RoomNumber = 1, Capacity = 2 };
        var room2 = new Room { RoomNumber = 2, Capacity = 2 };

        hospital.Rooms.Add(room1);
        hospital.Rooms.Add(room2);

        try
        {
            hospital.AdmitPatient(patient1);
            hospital.AdmitPatient(patient2);
        }
        catch (RoomFullException ex)
        {
            Console.WriteLine(ex.Message);
        }

        doctor1.Diagnose(patient1, "Cold");
        doctor2.Diagnose(patient2, "Flu");

        hospital.GetDetails();

        hospital.DischargePatient(patient2);
        hospital.GetDetails();
    }
}
