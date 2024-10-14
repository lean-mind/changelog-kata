# changelog kata

## Description
This kata is about creating a changelog file for a project to track the changes 
of a project automatically by versioning following [Semantic Versioning](https://semver.org/) and [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/). The changelog file should be in the format of [keepachangelog.com](https://keepachangelog.com/en/1.0.0/).

## Requirements

### Calculate next version from Release Candidate a Current Release
A set of commits, since last Release, represents a Release Candidate.

From the Release Candidate and Current Release, calculate the next version following [Semantic Versioning](https://semver.org/).

for example:
```
from Current Release v1.0.0

Release Candidate:
[
    Commit{type: "feat", description: "add new feature"},
    Commit{type: "fix", description: "fix bug"}
]

calculateNextRelease(Release Candidate, Current Release) -> v1.1.0
```

### Generate/Update changelog
Using the release candidate and the current release, generate or update the changelog file in the format of [keepachangelog.com](https://keepachangelog.com/en/1.0.0/).

```markdow
# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Version] - YYYY-MM-DD
### Added
- Details about new features or important additions.

### Changed
- Changes to existing features, performance improvements, or UI updates.

### Deprecated
- Features that are still functional but are marked for removal in future releases.

### Removed
- Features that have been removed from the software.

### Fixed
- Bug fixes or error corrections.

### Security
- Security-related changes (such as vulnerability patches or security improvements).

## [Unreleased]
- A list of future changes that have not yet been released.

## Compare
You can compare this version with the previous one or any other version using a version control link:
- [v1.0.0...v1.1.0](https://repository-url/compare/v1.0.0...v1.1.0)

```

## How to resolve the kata
s
No matter the language you choose, but you can select some of the approaches below:
- [Inside-Out TDD](/docs/inside-out-tdd.md)
- [Outside-In TDD](/docs/outside-in-tdd.md) 



## Acceptance Criteria
- The changelog file should be in the format of [keepachangelog.com](https://keepachangelog.com/en/1.0.0/).
- The changelog file should be generated or updated with the release candidate and the current release.
- The version should be calculated following [Semantic Versioning](https://semver.org/).
- The changelog file should have a section for each type of commit: Added, Changed, Deprecated, Removed, Fixed, Security.
- The changelog file should have a section for unreleased changes.
- The changelog file should have a section to compare the current version with the previous one.
- The changelog file should have a link to compare the current version with the previous one.


## References
- [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/)
- [Semantic Versioning](https://semver.org/)
- [keepachangelog.com](https://keepachangelog.com/en/1.0.0/)