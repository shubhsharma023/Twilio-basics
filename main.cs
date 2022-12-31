using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Program
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "AC72be60b8db893d0ac1822c167e77da4a";
        const string authToken = "3870557a8a6fcdbf9e0b72e7bb37aa04";
        TwilioClient.Init(accountSid, authToken);

        var to = new PhoneNumber("+917004480112");
        var from = new PhoneNumber("+13049697369");
        var call = CallResource.Create(to, from,
            url: new Uri("http://demo.twilio.com/docs/voice.xml"));

        Console.WriteLine(call.Sid);
    }
}