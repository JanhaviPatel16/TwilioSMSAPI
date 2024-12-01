# TwilioSMSAPI
This project demonstrates how to build an SMS sending service using the Twilio API and the .NET 8 Web API framework. The primary goal is to create an API that allows users to
send SMS messages programmatically through Twilio’s communication platform. By using .NET 8, this project leverages the latest features and enhancements in performance, security, 
and functionality.

## Key Components:
* Twilio API: Twilio is a cloud communications platform that enables developers to send and receive text messages, make phone calls, and more. It provides an easy-to-use
  API for sending SMS messages.
* .NET 8 Web API: The API is built using the .NET 8 Web API framework. This allows for a fast, efficient, and scalable solution that can be used in production environments.

## Prerequisites:
* Twilio Account: You need to have a Twilio account to get the Account SID and Auth Token, which are required to authenticate API requests.
* .NET 8 SDK: Install .NET 8 SDK for building and running the application.
* IDE: Visual Studio Code/ Visual Studio

* Set Up the Twilio Account
   - Go to the Twilio website, sign up, and create a new account if you haven't already.
   - Obtain the Account SID and Auth Token from the Twilio Console.
   - Get a Twilio phone number capable of sending SMS messages.

* Create a New .NET 8 Web API Project
   - Open Visual Studio code or your preferred IDE.
   - Create a new ASP.NET Core Web API project targeting .NET 8.
   - Install necessary packages:
      Twilio for integrating with Twilio API.
     ```
     dotnet add package Twilio
     ```
* Configure the Application
   In the appsettings.json file, store your Twilio credentials and settings securely:
   ```
   {
    "TwilioSettings": {
      "AccountSid": "your_twilio_account_sid",
      "AuthToken": "your_twilio_auth_token",
      "PhoneNumber": "your_twilio_phone_number"
    }
  }
  ```
* Testing the API
  Run the application and test it with an HTTP client like Postman or Swagger.

  POST /api/sms/send
  Request Body (JSON):

  ```
  {
    "to": "+1234567890",
    "message": "Hello from .NET 8 and Twilio API!"
  }
  ```
 If successful, you should receive a message and response as following
<img width="996" alt="Screen Shot 2024-12-01 at 12 36 39 PM" src="https://github.com/user-attachments/assets/271357d9-752f-4e30-b3cb-0c670ff1e696">

## Conclusion:
This project illustrates how to integrate Twilio's SMS service with .NET 8 Web API, providing a simple yet powerful solution to send SMS messages programmatically. 

You can further expand this project to include features like:

* Message history tracking.
* Sending SMS in bulk.
* Integrating other Twilio services like whatsapp messages, voice or email.

