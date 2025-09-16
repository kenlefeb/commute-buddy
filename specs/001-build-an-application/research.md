# Research: .NET MAUI for Generative AI Daily Review Companion

## Platform Suitability
- .NET MAUI enables cross-platform development (Windows, macOS, iOS, Android) with a single codebase.
- Supports native UI, device APIs (microphone, speech), and background tasks.
- Integrates with C# libraries for AI, voice, and cloud services.

## Generative AI Integration
- .NET MAUI can call cloud-based AI APIs (OpenAI, AWS, Azure, etc.) via REST or SDKs.
- Local inference possible with ONNX, but cloud APIs recommended for affordability and scalability.
- Voice interaction supported via platform speech APIs or third-party libraries.

## Hosting Flexibility
- App runs locally on user devices (phone, desktop, tablet).
- Backend (if needed) can be hosted on AWS, Azure, or any affordable platform; can also run locally.
- No vendor lock-in; user can choose hosting based on cost and expertise.

## Constraints & Dependencies
- Requires internet for cloud AI services.
- Privacy: Voice data and review logs must be protected; retention/deletion policy needed.
- Safety: Hands-free operation and minimal distraction are critical for driving scenarios.

## Summary
.NET MAUI is well-suited for building a generative AI companion app with voice interaction, cross-platform support, and flexible hosting. All requirements from the feature spec can be met using .NET MAUI and affordable cloud or local hosting options.
