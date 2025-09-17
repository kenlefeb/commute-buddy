# Tasks: Generative AI Daily Review Companion

**Input**: Design documents from `/specs/001-build-an-application/`
**Prerequisites**: plan.md (required), research.md, data-model.md

## Execution Flow (main)
```
1. Load plan.md from feature directory
2. Load optional design documents: data-model.md, research.md, quickstart.md
3. Generate tasks by category: Setup, Tests, Core, Integration, Polish
4. Apply task rules: [P] for parallel, sequential for same file
5. Number tasks sequentially (T001, T002...)
6. Generate dependency graph
7. Create parallel execution examples
8. Validate task completeness
9. Return: SUCCESS (tasks ready for execution)
```

## Phase 3.1: Setup
- [x] T001 Create project structure per implementation plan (app/, core/, api/, cli/, lib/, tests/) in repo root
- [x] T002 Initialize .NET MAUI project in app/ and supporting .NET libraries in core/, api/, cli/
- [x] T003 [P] Configure linting and formatting tools for .NET (e.g., dotnet-format) in all projects

## Phase 3.2: Tests First (TDD)
**CRITICAL: These tests MUST be written and MUST FAIL before ANY implementation**
- [x] T004 [P] Contract test for ReviewSession model in tests/contract/test_review_session.cs
- [x] T005 [P] Contract test for User model in tests/contract/test_user.cs
- [x] T006 [P] Contract test for ConversationLog model in tests/contract/test_conversation_log.cs
- [x] T007 [P] Integration test for Daily Review flow in tests/integration/test_daily_review_flow.cs
- [x] T008 [P] Integration test for hands-free voice interaction in tests/integration/test_voice_interaction.cs
- [x] T009 [P] Integration test for review session summary and storage in tests/integration/test_review_storage.cs

## Phase 3.3: Core Implementation (ONLY after tests are failing)
- [ ] T010 [P] Implement User model in core/models/User.cs
- [ ] T011 [P] Implement ReviewSession model in core/models/ReviewSession.cs
- [ ] T012 [P] Implement ConversationLog model in core/models/ConversationLog.cs
- [ ] T013 Implement Review logic service in core/services/ReviewService.cs
- [ ] T014 Implement voice interaction service in core/services/VoiceService.cs
- [ ] T015 Implement review summary and storage logic in core/services/StorageService.cs

## Phase 3.4: Integration
- [ ] T016 Integrate ReviewService with VoiceService in core/services/
- [ ] T017 Integrate StorageService with local and cloud providers in core/services/
- [ ] T018 Implement privacy and data retention options in core/services/StorageService.cs
- [ ] T019 Implement logging and error handling in all services

## Phase 3.5: Polish
- [ ] T020 [P] Unit tests for all models and services in tests/unit/
- [ ] T021 [P] Performance tests for voice response and resource usage in tests/performance/
- [ ] T022 [P] Update documentation in specs/001-build-an-application/quickstart.md and README.md
- [ ] T023 Manual testing following quickstart.md

## Dependencies
- Setup (T001-T003) before everything
- Tests (T004-T009) before implementation (T010-T015)
- Models (T010-T012) before services (T013-T015)
- Services before integration (T016-T019)
- Implementation before polish (T020-T023)

## Parallel Example
```
# Launch T004-T009 together:
Task: "Contract test for ReviewSession model in tests/contract/test_review_session.cs"
Task: "Contract test for User model in tests/contract/test_user.cs"
Task: "Contract test for ConversationLog model in tests/contract/test_conversation_log.cs"
Task: "Integration test for Daily Review flow in tests/integration/test_daily_review_flow.cs"
Task: "Integration test for hands-free voice interaction in tests/integration/test_voice_interaction.cs"
Task: "Integration test for review session summary and storage in tests/integration/test_review_storage.cs"
```

## Notes
- [P] tasks = different files, no dependencies
- Verify tests fail before implementing
- Commit after each task
- Avoid: vague tasks, same file conflicts

## Validation Checklist
- [x] All entities have model tasks
- [x] All tests come before implementation
- [x] Parallel tasks truly independent
- [x] Each task specifies exact file path
- [x] No task modifies same file as another [P] task
