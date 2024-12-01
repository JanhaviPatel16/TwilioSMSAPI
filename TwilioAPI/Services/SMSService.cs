using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TwilioAPI.Entities;

namespace TwilioAPI.Services
{
    public class SMSService : ISMSService
    {
        private readonly SMSSetting _smsSetting;

        public SMSService(IOptions<SMSSetting> smsSetting)
        {
            this._smsSetting = smsSetting.Value;
        }
        public async Task<MessageResource> SendAsync(string message, string to)
        {
            TwilioClient.Init(_smsSetting.AccountSID, _smsSetting.AuthToken);

            var result = await MessageResource.CreateAsync(
              body: message,
              from: new PhoneNumber(_smsSetting.PhoneNumber),
              to: new PhoneNumber(to)
            );
            return result;
        }
    }
}