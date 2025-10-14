using MethodsOverloading77.Model;

var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2025, 4, 3));
//Overwrite month and day
medicalAppointment.Reschedule(5,1);

var medicalAppointment2 = new MedicalAppointment("Luiz");
//Optional Parameters
var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeeksFromNow = new MedicalAppointment("Margaret Smith");
