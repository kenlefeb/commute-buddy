# Data Model: Generative AI Daily Review Companion

## Entities

### User
- userId: string
- name: string
- commuteSchedule: object
- reviewHistory: array of ReviewSession

### ReviewSession
- sessionId: string
- userId: string
- date: datetime
- stepsCompleted: array of string
- notes: string
- interruptions: array of string

### ConversationLog
- logId: string
- sessionId: string
- transcript: string
- timestamps: array of datetime
- privacyStatus: string

## Relationships
- User has many ReviewSessions
- ReviewSession has one ConversationLog

## Notes
- Data model supports privacy, voice interaction, and review tracking.
- Extendable for additional features (e.g., reminders, analytics).
