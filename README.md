# changelog kata

## Description
This kata is about creating a changelog file for a project to track the changes 
of a project automatically by versioning following [Semantic Versioning](https://semver.org/) and [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/). The changelog file should be in the format of [keepachangelog.com](https://keepachangelog.com/en/1.0.0/).

## Requirements

### Parse commits
for example:
```
feat: add new feature -> Commit{type: "feat", description: "add new feature"}
```

### Calculate next version from Release Candidate
for example:
```
from v1.0.0
[
    Commit{type: "feat", description: "add new feature"},
    Commit{type: "fix", description: "fix bug"}
]

execute -> v1.1.0
```

### Generate/Update changelog
for example:

From:
```markdown
# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- v1.1 Spanish translation.

### Changed

- Use frontmatter title & description in each language version template

### Removed

- Trademark sign previously shown after the project description in version 
0.3.0

## [1.1.1] - 2023-03-05

### Added

- v1.1 French translation.

- Centralize all links into `/data/links.json` so they can be updated easily.

### Fixed

- Various broken links, page versions, and indentations.

### Changed

- Upgrade dependencies: Ruby 3.2.1, Middleman, etc.

### Removed

- Unused normalize.css file.

```

To:
```markdown



## References
- [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/)
- [Semantic Versioning](https://semver.org/)
- [keepachangelog.com](https://keepachangelog.com/en/1.0.0/)