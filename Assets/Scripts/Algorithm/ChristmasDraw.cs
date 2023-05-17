using System;
using System.Collections.Generic;
using UnityEngine;

namespace Algorithm
{
    public class ChristmasDraw : MonoBehaviour
    {
        [SerializeField] private int numParticipants = 47;

        private List<Participant> _participants;

        void Start()
        {
            _participants = new List<Participant>();
            for (int i = 1; i <= numParticipants; i++)
            {
                var participant = new Participant(Guid.NewGuid(), $"participant{i}@example.com", $"First Name {i}", $"Last Name {i}");
                _participants.Add(participant);
            }

            RunDraw();
            Debug.Log("The Christmas draw results are:");
            foreach (Participant participant in _participants)
            {
                Print(participant.FullName, participant.Receiver.FullName);
            }
        }

        private void Print(string fullNameSender, string fullNameReceiver)
        {
            Debug.Log($"Sender: {fullNameSender}, Receiver: {fullNameReceiver}");
        }

        private void RunDraw()
        {
            Shuffle(_participants);

            for (int i = 0; i < _participants.Count; i++)
            {
                var receiver = _participants[(i + 1) % _participants.Count];
                
                while (receiver == _participants[i])
                {
                    receiver = _participants[(i + 2) % _participants.Count];
                }

                _participants[i].Receiver = receiver;
            }
        }

        private void Shuffle<T>(List<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = UnityEngine.Random.Range(0, n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}