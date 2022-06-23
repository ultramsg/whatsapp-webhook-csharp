# [Ultramsg.com](https://ultramsg.com/?utm_source=github&utm_medium=csharp&utm_campaign=webhook) whatsapp-webhook-csharp

simple project to handle incoming WhatsApp message using c#.

by [Ultramsg.com](https://ultramsg.com/?utm_source=github&utm_medium=csharp&utm_campaign=webhook)

# Dependencies

for local development purposes, a tunneling service is required. This example uses ngrok , You can download ngrok from [here](https://ngrok.com/download).

# run project 
```
dotnet watch
```
# Start ngrok 
```
ngrok http https://localhost:6000
```

# set ultramsg Webhook URL 

Go to your ultramsg account for set Webhook URL after copying the ngrok url and add Route /api/ like this : 

```
https://61-44-136-9.ngrok.io/api/
```

# receive messages

You should be able to receive WhatsApp webhooks now .

# Example json response
```
{
  "event_type": "message_received",
  "instanceId": "1150",
  "id": "",
  "referenceId": "",
  "data": {
    "id": "false_10172127174@c.us_3EB02E5EB89CE03FB034",
    "from": "10172127174@c.us",
    "to": "10172127170@c.us",
    "author": "",
    "pushname": "E.St",
    "ack": "",
    "type": "chat",
    "body": "Hi",
    "media": "",
    "fromMe": false,
    "isForwarded": false,
    "isMentioned": false,
    "quotedMsg": {},
    "mentionedIds": [],
    "time": 1650002663
  }
}
```


# Support
Use **Issues** to contact me
