using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Program
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        TwilioClient.Init(accountSid, authToken);

        var to = new PhoneNumber("<number to which you want to call>");
        var from = new PhoneNumber("<your active twilio number>");
        var call = CallResource.Create(to, from,
            url: new Uri("http://demo.twilio.com/docs/voice.xml"));

        Console.WriteLine(call.Sid);
    }
}