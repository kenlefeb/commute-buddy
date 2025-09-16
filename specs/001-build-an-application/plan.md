# Implementation Plan: Generative AI Daily Review Companion

**Branch**: `001-build-an-application` | **Date**: September 16, 2025 | **Spec**: [spec.md]
**Input**: Feature specification from `/specs/001-build-an-application/spec.md`

## Execution Flow (/plan command scope)
```
1. Load feature spec from Input path
   → If not found: ERROR "No feature spec at {path}"
2. Fill Technical Context (scan for NEEDS CLARIFICATION)
   → Detect Project Type from context (web=frontend+backend, mobile=app+api)
   → Set Structure Decision based on project type
3. Evaluate Constitution Check section below
   → If violations exist: Document in Complexity Tracking
   → If no justification possible: ERROR "Simplify approach first"
   → Update Progress Tracking: Initial Constitution Check
4. Execute Phase 0 → research.md
   → If NEEDS CLARIFICATION remain: ERROR "Resolve unknowns"
5. Execute Phase 1 → contracts, data-model.md, quickstart.md, agent-specific template file (e.g., `CLAUDE.md` for Claude Code, `.github/copilot-instructions.md` for GitHub Copilot, or `GEMINI.md` for Gemini CLI).
6. Re-evaluate Constitution Check section
   → If new violations: Refactor design, return to Phase 1
   → Update Progress Tracking: Post-Design Constitution Check
7. Plan Phase 2 → Describe task generation approach (DO NOT create tasks.md)
8. STOP - Ready for /tasks command
```

**IMPORTANT**: The /plan command STOPS at step 7. Phases 2-4 are executed by other commands:
- Phase 2: /tasks command creates tasks.md
- Phase 3-4: Implementation execution (manual or via tools)

## Summary
The application will use generative AI to hold a conversation with the user during their commute, guiding them through a GTD Daily Review. It will be built using .NET MAUI for cross-platform support and affordable hosting, with the ability to run locally or in the cloud. The user has expertise in .NET and AWS, but the solution should remain platform-agnostic.

## Technical Context
**Language/Version**: .NET 8 / C# 12  
**Primary Dependencies**: .NET MAUI, OpenAI API (or similar), Speech Recognition library [NEEDS CLARIFICATION: which library], Local/Cloud storage provider [NEEDS CLARIFICATION: which provider]  
**Storage**: Local file system, optional cloud storage (AWS S3, Azure Blob, etc.) [NEEDS CLARIFICATION: preferred default]  
**Testing**: xUnit, MAUI Test, integration tests  
**Target Platform**: Windows, macOS, iOS, Android, Linux (via .NET MAUI)  
**Project Type**: Mobile + API (cross-platform app with backend contracts)  
**Performance Goals**: Fast voice response (<500ms), minimal resource usage for mobile  
**Constraints**: Hands-free operation, privacy for voice data, offline-capable, affordable hosting  
**Scale/Scope**: Single user, scalable to small teams [NEEDS CLARIFICATION: multi-user support?]

## Constitution Check
*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

**Simplicity**:
- Projects: 3 (app, api, tests)
- Using framework directly? Yes (no wrappers)
- Single data model? Yes (review session, user, log)
- Avoiding patterns? Yes (no Repository/UoW unless justified)

**Architecture**:
- EVERY feature as library? Yes
- Libraries listed: review-core (logic), review-api (contracts), review-app (MAUI UI)
- CLI per library: Planned for review-core and review-api
- Library docs: llms.txt format planned

**Testing (NON-NEGOTIABLE)**:
- RED-GREEN-Refactor cycle enforced
- Git commits show tests before implementation
- Order: Contract→Integration→E2E→Unit strictly followed
- Real dependencies used (actual storage, speech)
- Integration tests for: new libraries, contract changes, shared schemas
- FORBIDDEN: Implementation before test, skipping RED phase

**Observability**:
- Structured logging included
- Frontend logs → backend (unified stream)
- Error context sufficient

**Versioning**:
- Version number assigned (1.0.0)
- BUILD increments on every change
- Breaking changes handled (parallel tests, migration plan)

## Project Structure

### Documentation (this feature)
```
specs/001-build-an-application/
├── plan.md              # This file (/plan command output)
├── research.md          # Phase 0 output (/plan command)
├── data-model.md        # Phase 1 output (/plan command)
├── quickstart.md        # Phase 1 output (/plan command)
├── contracts/           # Phase 1 output (/plan command)
└── tasks.md             # Phase 2 output (/tasks command - NOT created by /plan)
```

### Source Code (repository root)
```
app/           # .NET MAUI UI
core/          # Review logic library
api/           # Contracts and backend
cli/           # CLI interface for review-core
lib/           # Shared utilities

tests/
├── contract/
├── integration/
└── unit/
```

**Structure Decision**: Mobile + API (Option 3)

## Phase 0: Outline & Research
1. **Extract unknowns from Technical Context** above:
   - Speech Recognition library [NEEDS CLARIFICATION]
   - Storage provider [NEEDS CLARIFICATION]
   - Multi-user support [NEEDS CLARIFICATION]
2. **Generate and dispatch research agents**:
   - Task: "Research best speech recognition libraries for .NET MAUI cross-platform apps"
   - Task: "Research affordable, privacy-respecting storage providers for voice and review data"
   - Task: "Research design patterns for multi-user support in cross-platform review apps"
3. **Consolidate findings** in `research.md` using format:
   - Decision: [what was chosen]
   - Rationale: [why chosen]
   - Alternatives considered: [what else evaluated]

**Output**: research.md with all NEEDS CLARIFICATION resolved

## Phase 1: Design & Contracts
*Prerequisites: research.md complete*

1. **Extract entities from feature spec** → `data-model.md`:
   - Entity name, fields, relationships
   - Validation rules from requirements
   - State transitions if applicable
2. **Generate API contracts** from functional requirements:
   - For each user action → endpoint
   - Use standard REST/GraphQL patterns
   - Output OpenAPI/GraphQL schema to `/contracts/`
3. **Generate contract tests** from contracts:
   - One test file per endpoint
   - Assert request/response schemas
   - Tests must fail (no implementation yet)
4. **Extract test scenarios** from user stories:
   - Each story → integration test scenario
   - Quickstart test = story validation steps
5. **Update agent file incrementally** (O(1) operation):
   - Run `/scripts/powershell/update-agent-context.ps1 -AgentType copilot` for your AI assistant
   - If exists: Add only NEW tech from current plan
   - Preserve manual additions between markers
   - Update recent changes (keep last 3)
   - Keep under 150 lines for token efficiency
   - Output to repository root

**Output**: data-model.md, /contracts/*, failing tests, quickstart.md, agent-specific file

## Phase 2: Task Planning Approach
*This section describes what the /tasks command will do - DO NOT execute during /plan*

**Task Generation Strategy**:
- Load `/templates/tasks-template.md` as base
- Generate tasks from Phase 1 design docs (contracts, data model, quickstart)
- Each contract → contract test task [P]
- Each entity → model creation task [P] 
- Each user story → integration test task
- Implementation tasks to make tests pass

**Ordering Strategy**:
- TDD order: Tests before implementation 
- Dependency order: Models before services before UI
- Mark [P] for parallel execution (independent files)

**Estimated Output**: 25-30 numbered, ordered tasks in tasks.md

**IMPORTANT**: This phase is executed by the /tasks command, NOT by /plan

## Phase 3+: Future Implementation
*These phases are beyond the scope of the /plan command*

**Phase 3**: Task execution (/tasks command creates tasks.md)  
**Phase 4**: Implementation (execute tasks.md following constitutional principles)  
**Phase 5**: Validation (run tests, execute quickstart.md, performance validation)

## Complexity Tracking
*Fill ONLY if Constitution Check has violations that must be justified*

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|

## Progress Tracking
*This checklist is updated during execution flow*

**Phase Status**:
- [ ] Phase 0: Research complete (/plan command)
- [ ] Phase 1: Design complete (/plan command)
- [ ] Phase 2: Task planning complete (/plan command - describe approach only)
- [ ] Phase 3: Tasks generated (/tasks command)
- [ ] Phase 4: Implementation complete
- [ ] Phase 5: Validation passed

**Gate Status**:
- [ ] Initial Constitution Check: PASS
- [ ] Post-Design Constitution Check: PASS
- [ ] All NEEDS CLARIFICATION resolved
- [ ] Complexity deviations documented

---
*Based on Constitution v2.2.0 - See `/memory/constitution.md`*
