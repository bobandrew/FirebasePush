namespace FirebasePush
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;

    using FirebaseAdmin;
    using FirebaseAdmin.Messaging;

    using Google.Apis.Auth.OAuth2;

    using Newtonsoft.Json.Linq;

    public class PushHelper
    {
        private const string OpenAppId = "fitness365";

        private FirebaseApp firebaseApp;
        private FirebaseMessaging messaging;

        public PushHelper(string projectId)
        {
            firebaseApp = FirebaseApp.GetInstance(OpenAppId);
            if (firebaseApp == null)
            {
                //var jsonCredentials = new byte[] { };//Resources.ResourceManager.GetObject("softpulse_b1020_a868aa6d8b00") as byte[];
                //using var stream = new MemoryStream(jsonCredentials);
                //using var reader = new StreamReader(stream);
                var googleCredential = GoogleCredential.FromJson(File.ReadAllText($"{projectId}.json"));
                firebaseApp = FirebaseApp.Create(new AppOptions() { Credential = googleCredential }, OpenAppId);
            }

            messaging = FirebaseMessaging.GetMessaging(firebaseApp);
        }

        public async void Send(string subject, string description, string imageUrl, string token)
        {
            var res = await messaging.SendAsync(new Message()
            {
                Notification = new Notification()
                {
                    Title = subject,
                    Body = description,
                    ImageUrl = imageUrl,
                },

                Token = token,
                //Data = new ReadOnlyDictionary<string, string>(data)
            });
            Console.WriteLine(res);
        }

        public string Send(Message message)
        {
            return messaging.SendAsync(message).Result;
        }

        //public static void SendDelivery(this PushMessage pushMessage, List<Person> persons)
        //{
        //	if (pushMessage == null || !persons.Any())
        //	{
        //		return;
        //	}

        //	foreach (var person in persons)
        //	{
        //		if (person.User == null)
        //		{
        //			continue;
        //		}

        //		var push = new PushMessage(pushMessage.Session)
        //		{
        //			Contact = pushMessage.Session.GetObjectByKey<Person>(person.Oid),
        //			Subject = pushMessage.Subject,
        //			Description = pushMessage.Description,
        //			ImageUrl = pushMessage.ImageUrl,
        //			DocumentType = pushMessage.DocumentType
        //		};
        //		push.SendPushMessage();
        //	}
        //}
    }
}
