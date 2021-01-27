using System;
using System.Collections.Generic;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital myHospital = new Hospital();

            myHospital.AddPatientToQueue("Alex");
            myHospital.AddPatientToQueue("Diana");
            myHospital.AddPatientToQueue("Lili");
            myHospital.AddPatientToQueue("Mariela");
            myHospital.AddPatientToQueue("Roxy");

            myHospital.RemovePatientFromTheQueue();
            myHospital.ShowMeThePatientsPending();

        }
    }


    public class Hospital
    {
        private Queue<string> waitingQueue = new Queue<string>();
        private Queue<string> attendedQueue = new Queue<string>();

        public void AddPatientToQueue(string nameOfPatient)
        {
            waitingQueue.Enqueue(nameOfPatient);
        }

        public void HowManyPatientsDoWeHaveInTheQueue()
        {
            Console.WriteLine("The hosptial has: " + waitingQueue.Count + " in the waiting room.");
        }

        public void RemovePatientFromTheQueue()
        {
            string patient = waitingQueue.Dequeue();
            attendedQueue.Enqueue(patient);
        }

        public void ShowMeThePatientsPending()
        {
            foreach (var patient in waitingQueue)
            {
                Console.WriteLine("These are the patients left: " + patient);
            }
        }
    }
}
