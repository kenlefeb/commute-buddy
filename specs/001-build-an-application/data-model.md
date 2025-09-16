# Data Model for Generative AI Daily Review Companion

## Entities

### User
- Attributes: userId, name, commuteSchedule, reviewHistory
- Relationships: Has many ReviewSessions

### ReviewSession
- Attributes: sessionId, userId, date, stepsCompleted, notes, interruptions
- Relationships: Belongs to User; Has many ConversationLogs

### ConversationLog
- Attributes: logId, sessionId, transcript, timestamps, privacyStatus
- Relationships: Belongs to ReviewSession

## Validation Rules
- User must have a unique userId
- ReviewSession must be linked to a valid User
- ConversationLog must be linked to a valid ReviewSession
- PrivacyStatus must comply with retention/deletion policy [NEEDS CLARIFICATION]

## State Transitions
- ReviewSession: Created → InProgress → Completed → Interrupted
- ConversationLog: Created → Updated → Archived
