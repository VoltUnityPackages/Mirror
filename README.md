![Mirror Logo](https://i.imgur.com/we6li1x.png)

[![Build](https://img.shields.io/appveyor/ci/vis2k73562/hlapi-community-edition/Mirror.svg)](https://ci.appveyor.com/project/vis2k73562/hlapi-community-edition/branch/mirror)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=vis2k_Mirror&metric=coverage)](https://sonarcloud.io/dashboard?id=vis2k_Mirror)
[![Discord](https://img.shields.io/discord/343440455738064897.svg)](https://discordapp.com/invite/N9QVxbM)
[![release](https://img.shields.io/github/release/vis2k/Mirror.svg)](https://github.com/vis2k/Mirror/releases/latest)
[![Roadmap](https://img.shields.io/badge/roadmap-blue.svg)](https://trello.com/b/fgAE7Tud)
[![Documentation](https://img.shields.io/badge/docs-blue.svg)](https://mirror-networking.com/docs)

**Stop worrying about networking. Because we do.**

## Mirror Package
Mirror is a **high level** Networking library for Unity, compatible with different **low level** [Transports](https://github.com/vis2k/Mirror#low-level-transports).

Mirror is for small indie games & large scale [MMOs](https://www.youtube.com/watch?v=mDCNff1S9ZU), made by the developers of [uMMORPG](https://assetstore.unity.com/packages/templates/systems/ummorpg-components-edition-159401) and [Cubica](https://www.youtube.com/watch?v=D_f_MntrLVE).

Mirror is optimized for **ease of use** & **probability of success**. 

We needed a networking library that allows us to **[launch our games](https://mirror-networking.com/showcase/)** and **survive the next decade**.

This is a fork of [Mirror](https://github.com/vis2k/Mirror), adding the ability to install it via the package manager. This makes it easier to update. Updates from [upstream](https://github.com/vis2k/Mirror) are periodically merged in, this also means that this packages is always using the latest bleeding edge version of Mirror. If you want a more stable version, use the [asset store version](https://assetstore.unity.com/packages/tools/network/mirror-129321).

## Architecture
The **Server & Client** are **ONE project** in order to achieve an order of magnitude gain in productivity.

Making multiplayer games this way is fun & easy. Instead of MonoBehaviour, Mirror provides **NetworkBehaviour** components with:
* **[Server]** / **[Client]** tags for server-only / client-only code
* **[Command]** for Client->Server function calls (e.g. UseItem)
* **[ClientRpc]** / **[TargetRpc]** for Server->Client function calls (e.g. AddChatMessage)
* **[SyncVar]** / SyncList to automatically synchronize variables from Server->Client

_Note: Mirror is based on Unity's abandoned UNET Networking system. We fixed it up and pushed it to MMO Scale._

## Low Level Transports
* (Built In) [KCP](https://github.com/skywind3000/kcp): reliable UDP
* (Package) [Ignorance](https://github.com/VoltUnityPackages/Ignorance): ENET UDP

## Getting Started
1. Open up the package manager via Windows **->** Package Manager
2. Click on the little + sign **->** Add package from git URL...
3. Type `https://github.com/VoltUnityPackages/Mirror.git?path=/Assets/Mirror` and add it
4. Unity will now download and install the package

Check out our [Documentation](https://mirror-networking.com/docs/) to learn how it all works.

If you are migrating from UNET, then please check out our [Migration Guide](https://mirror-networking.com/docs/Articles/General/Migration.html).

## Made with Mirror

[Team-Capture](https://github.com/Voltstro-Studios/Team-Capture)
[![Team-Capture](https://raw.githubusercontent.com/Voltstro-Studios/Team-Capture/master/tc-logo.png)](https://github.com/Voltstro-Studios/Team-Capture)

## Funding
Mirror is free & open source software funded by Donations. If you love it, please consider supporting [Mirror on GitHub](https://github.com/sponsors/vis2k). As reward, you'll receive our [Network Profiler](https://mirror-networking.com/docs/Articles/Guides/Profiler.html?q=Profiler), priority support and more :)

## Benchmarks
* [uMMORPG 480 CCU worst case test](https://youtu.be/mDCNff1S9ZU) (everyone broadcasting to everyone else)
* [Latest Results](https://docs.google.com/document/d/1GMxcWAz3ePt3RioK8k4erpVSpujMkYje4scOuPwM8Ug/edit?usp=sharing)

## Development & Contributing
Mirror is used **in production** by games ranging from small indie projects to large scale MMOs that will run for a decade or more.

10 years from now if your players encounter a networking bug and most of our contributors already moved on, someone will need to fix it. Therefore it is of utmost importance for us to follow the [KISS principle](https://en.wikipedia.org/wiki/KISS_principle) in order for our games to survive.

Keeping the next decade in mind, contributing **fixes** / **tests** / **improvements** is highly appreciated while new features have a low probability of being merged.

_At this point, what we don't add to Mirror is more important than what we do add to it!_
