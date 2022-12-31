# Getting started with Twilio

Twilio provides programmable communication tools for making and receiving phone calls, sending and receiving text messages, and performing other communication functions using its web service APIs.
<br>
**Here we will use Twilio to Rickroll you, send custom message and voice note to someone.**
<br>
<br>

> We will create this programmable API using .NET MAUI and it is also important for to create [Twilio](https://www.twilio.com/try-twilio) account and use these [docs](https://www.twilio.com/docs) to create our service.

This App takes a phone number as an input, calls them (as programmed by you) and rick rolls them using Twilio Voice.

- Use you text editor to performing in your local machine or use [Replit](https://replit.com/) for running online.
- Open the `main.cs` file and add the dependencies using `dotnet add package twilio` (**this step is must**).
- You can customize the API using the following commands given below :
- Add your SID and Authorised token to main.cs.
- Use `dotnet run` command to execute the program.

## To send custom message

Open the main.cs file and edit the following in it to send a custom message:
<br>

--

      var to = new PhoneNumber("<number to which you want to call>");
           var from = new PhoneNumber("<your active twilio number>");
           var call = CallResource.Create(to, from,
               url: new Uri("http://demo.twilio.com/docs/voice.xml"));
                  Console.WriteLine(call.Sid);

<br>
++

          var message = MessageResource.Create(
            to: new PhoneNumber("<number to which you want to send custom message>"),
            from : new PhoneNumber("<your active twilio number>"),
            body:"Write custom message here"
          );
           Console.WriteLine(message.Sid);

## To send custom message

Open the main.cs file and edit the following in it to send Voice Note :
<br>

--

      var to = new PhoneNumber("<number to which you want to call>");
           var from = new PhoneNumber("<your active twilio number>");
           var call = CallResource.Create(to, from,
               url: new Uri("http://demo.twilio.com/docs/voice.xml"));
                  Console.WriteLine(call.Sid);

<br>

++

          var call = CallResource.Create(
            to: new PhoneNumber("<number to which you want to send custom Voice Note>"),
            from : new PhoneNumber("<your active twilio number>"),
            twiml:new Twiml("<Response><Say><Your custom voice note here></Say></Response>")
          );
           Console.WriteLine(call.Sid);

## To Rickroll You

Open the main.cs file and do the following to rickroll :

++

      var to = new PhoneNumber("<number to which you want to call>");
           var from = new PhoneNumber("<your active twilio number>");
           var call = CallResource.Create(to, from,
               url: new Uri("http://demo.twilio.com/docs/voice.xml"));
                  Console.WriteLine(call.Sid);

<br>

> It is important to go through your logs of the calls and messages you make from your Twilio account so as it has not been misused by someone (if shared your details) or to check the status of of the service you performed or provided and you can check this by going to logs section of the account section.
