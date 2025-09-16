# API Contract: Review Session

## Endpoint: /api/review-session
- POST: Start new review session
- GET: Retrieve review session details
- PATCH: Update review session (notes, interruptions)

## Request/Response Examples
- POST: { userId, commuteStatus }
- Response: { sessionId, status }

---

# API Contract: Conversation Log

## Endpoint: /api/conversation-log
- POST: Add new conversation log
- GET: Retrieve logs for session

## Request/Response Examples
- POST: { sessionId, transcript }
- Response: { logId, status }
