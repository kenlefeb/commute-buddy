# Commute Buddy Constitution

## Core Principles

### I. Library-First
Every feature starts as a standalone library. Libraries must be self-contained, independently testable, and documented. Clear purpose required—no organizational-only libraries.

### II. CLI Interface
Every library exposes functionality via CLI. Text in/out protocol: stdin/args → stdout, errors → stderr. Support JSON + human-readable formats.

### III. Test-First (NON-NEGOTIABLE)
TDD mandatory: Tests written → User approved → Tests fail → Then implement. Red-Green-Refactor cycle strictly enforced. Test approval gates required.

### IV. Integration Testing
Integration tests required for new library contracts, contract changes, inter-service communication, and shared schemas. List integration test triggers and real dependency requirements.

### V. Observability
Structured logging required. Multi-tier log streaming and performance monitoring must be included. Text I/O ensures debuggability.

### VI. Versioning & Breaking Changes
MAJOR.MINOR.BUILD format. Version increment reminders and breaking change procedures required. Migration requirements must be documented.

### VII. Simplicity
Start simple. Project count limits and pattern prohibition examples enforced. YAGNI (You Aren't Gonna Need It) principles must be followed.

## Additional Constraints
- Technology stack: .NET MAUI for cross-platform, affordable hosting, and local/cloud flexibility.
- Compliance: Privacy and safety for voice data and review logs. Data retention/deletion policy required.
- Deployment: Must support local and cloud hosting (AWS, Azure, etc.).

## Development Workflow
- Code review requirements and testing gates enforced.
- Deployment approval process required.
- All templates and documentation must reference constitution requirements.

## Governance
Constitution supersedes all other practices. Amendments require documentation, approval, and migration plan. All PRs/reviews must verify compliance. Complexity must be justified. Use project documentation for runtime development guidance.

**Version**: 2.2.0 | **Ratified**: 2025-09-16 | **Last Amended**: 2025-09-16