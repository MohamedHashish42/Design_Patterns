using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.MediatorDP
{
    public class Chatroom : IChatroom
    {
        private List<Participant> ParticipantsList = new List<Participant>();
        public void RegisterUser(Participant participant)
        {
            ParticipantsList.Add(participant);
        }



        public void SendMessage(string message, Participant participant)
        {
            foreach (var Participant in ParticipantsList)
            {

                if (Participant != participant)
                {
                    Participant.Receive(message);
                }
            }
        }

     
    }
}
