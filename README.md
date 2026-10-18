# 💬 ChatHub

A real-time group chat built with **ASP.NET Core SignalR**. Messages appear instantly for everyone connected, without refreshing the page.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![SignalR](https://img.shields.io/badge/SignalR-real--time-512BD4)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?logo=javascript&logoColor=black)

## ✨ Features

- **Real-time messaging** over WebSockets through a SignalR hub
- Set your **display name** and a **profile picture URL** before sending messages
- **System notifications** when a user connects or disconnects
- Lightweight front-end: ASP.NET Core MVC view + the SignalR JavaScript client

## ⚙️ How it works

```
Browser ──invoke("SendMessage")──▶ ChatAppHub (/chathub) ──"ReceiveMessage"──▶ all connected browsers
```

- `ChatAppHub.SendMessage(userName, userProfilePic, message)` broadcasts each message to all clients.
- `OnConnectedAsync` / `OnDisconnectedAsync` send system messages when users join or leave.

## 🚀 Getting started

**Requirements:** .NET 8 SDK

```bash
git clone https://github.com/SharifovDeveloper/ChatHub-SignalR-.git
cd ChatHub-SignalR-
dotnet run --project ChatHub
```

Open the app in two browser tabs, enter a name in each and start chatting.

## 🛠️ Tech stack

ASP.NET Core 8 MVC · SignalR · JavaScript · Bootstrap
