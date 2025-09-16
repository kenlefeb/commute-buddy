# Tasks: Generative AI Daily Review Companion

**Input**: Design documents from `/specs/001-build-an-application/`
**Prerequisites**: plan.md (required), research.md, data-model.md, contracts/

## Execution Flow (main)
```
1. Load plan.md from feature directory
2. Load optional design documents: data-model.md, contracts/, research.md, quickstart.md
3. Generate tasks by category: Setup, Tests, Core, Integration, Polish
4. Apply task rules: [P] for parallel, sequential for same file
5. Number tasks sequentially (T001, T002...)
6. Generate dependency graph
7. Create parallel execution examples
8. Validate task completeness
9. Return: SUCCESS (tasks ready for execution)
```

## Phase 1: Setup
- [ ] T001 Create .NET MAUI project structure in `src/`
- [ ] T002 Initialize .NET MAUI project with dependencies in `src/`
- [ ] T003 [P] Configure linting and formatting tools in `src/`

## Phase 2: Tests First (TDD)
- [ ] T004 [P] Contract test for API endpoints in `tests/contract/test_api_endpoints.cs`
- [ ] T005 [P] Contract test for voice interaction in `tests/contract/test_voice_interaction.cs`
- [ ] T006 [P] Contract test for review session workflow in `tests/contract/test_review_session.cs`
- [ ] T007 [P] Model test for User entity in `tests/model/test_user.cs`
- [ ] T008 [P] Model test for ReviewSession entity in `tests/model/test_review_session.cs`
- [ ] T009 [P] Model test for ConversationLog entity in `tests/model/test_conversation_log.cs`
- [ ] T010 [P] Integration test for Daily Review user story in `tests/integration/test_daily_review.cs`

## Phase 3: Core Implementation
- [ ] T011 [P] Implement User model in `src/models/User.cs`
- [ ] T012 [P] Implement ReviewSession model in `src/models/ReviewSession.cs`
- [ ] T013 [P] Implement ConversationLog model in `src/models/ConversationLog.cs`
- [ ] T014 Implement ReviewSession service in `src/services/ReviewSessionService.cs`
- [ ] T015 Implement ConversationLog service in `src/services/ConversationLogService.cs`
- [ ] T016 Implement API endpoints in `src/api/ReviewSessionApi.cs`
- [ ] T017 Implement voice interaction logic in `src/voice/VoiceInteraction.cs`
- [ ] T018 Implement review session workflow in `src/workflows/ReviewSessionWorkflow.cs`

## Phase 4: Integration
- [ ] T019 Integrate generative AI API in `src/ai/GenerativeAiService.cs`
- [ ] T020 Integrate platform speech APIs in `src/voice/SpeechApiIntegration.cs`
- [ ] T021 Connect services to local/cloud backend in `src/backend/BackendIntegration.cs`
- [ ] T022 Implement privacy controls in `src/privacy/PrivacyService.cs`

## Phase 5: Polish
- [ ] T023 [P] Unit tests for privacy and safety in `tests/unit/test_privacy_safety.cs`
- [ ] T024 [P] Performance tests in `tests/performance/test_performance.cs`
- [ ] T025 [P] Update documentation in `specs/001-build-an-application/quickstart.md`
- [ ] T026 Manual testing and stakeholder review in `specs/001-build-an-application/manual-testing.md`

## Parallel Execution Example
```
# Launch T004-T010 together:
Task: "Contract test for API endpoints in tests/contract/test_api_endpoints.cs"
Task: "Contract test for voice interaction in tests/contract/test_voice_interaction.cs"
Task: "Contract test for review session workflow in tests/contract/test_review_session.cs"
Task: "Model test for User entity in tests/model/test_user.cs"
Task: "Model test for ReviewSession entity in tests/model/test_review_session.cs"
Task: "Model test for ConversationLog entity in tests/model/test_conversation_log.cs"
Task: "Integration test for Daily Review user story in tests/integration/test_daily_review.cs"
```

## Dependencies
- Setup (T001-T003) before everything
- Tests (T004-T010) before implementation (T011-T018)
- Models (T011-T013) before services (T014-T015)
- Services before endpoints and workflows (T016-T018)
- Core before integration (T019-T022)
- Everything before polish (T023-T026)

## Validation Checklist
- [x] All contracts have corresponding tests
- [x] All entities have model tasks
- [x] All tests come before implementation
- [x] Parallel tasks truly independent
- [x] Each task specifies exact file path
- [x] No task modifies same file as another [P] task
