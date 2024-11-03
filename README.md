# Changelog kata

## Description
This kata is about creating a **system that handles automatically, from commits, a changelog file** for a project to track the changes
of it. This changelog file has to follow the format of [keepachangelog.com](https://keepachangelog.com/en/1.0.0/).

The system has to have the following **functionalities**:
- Create a new changelog file with the first version of the project or unreleased changes.
- Update the changelog file with new changes unreleased.
- Create a new release with unreleased changes.
- Update the changelog file with the new version and the changes of the new version aka new Release.
- [Optional] Create the changelog file with all releases created.


The automation must be done following the [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) and [Semantic Versioning](https://semver.org/).


## keepachangelog

This format has got different sections that will be explained in the following sections.

### Header

This is a fixed / No changable section at the top of the file and has the following content:

```markdown
# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
 [Semantic Versioning](https://semver.org/spec/v2.0.0.html), and
 [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/).
```

### Unreleased changes section:

This section accumulates all the changes that are **not released** yet.

It has to be the first section among sections related a changes section of changes.

The **purpose** is used to communicate how it will be the upcoming release.

The section has the following format:
```markdown
## [Unreleased]

<Changes>

```

### Version Section

This section has the changes of a specific version.
The section has the following format:
```markdown
## [Version] - YYYY-MM-DD

<Changes>
```

There will be zero, one o more than one version sections in the file.

> [!IMPORTANT]
> When there is more than one version section, the order has to be from the newest to the oldest


### Compare Section

This section has a link to compare the current version with the previous one.

For this case the are some special cases
- The first version has to compare with the previous version.
- The last version has to compare with the HEAD.
- The other versions have to compare with the previous version.

In addition, the link depends on the remote repository, so it has to be adapted to the specific one the user choose.

In the following example that shows the format of the section, the link is for a github repository:

```markdown
## Compare

[unreleased]: https://repository-url/compare/[last-version]...HEAD
[last-version]: https://repository-url/compare/[last-version]...[previous-version]
[previous-version]: https://repository-url/compare/[first-version]...[previous-version]
[first-version]: https://repository-url/releases/tag/[first-version]
```

### Changes Sections

The changes can be unreleased or versioned as previously it was mentioned.
keepachangelog classifies changes in the following types:
- **Added** for new features.
- **Changed** for changes in existing functionality.
- **Deprecated** for soon-to-be removed features.
- **Removed** for now removed features.
- **Fixed** for any bug fixes.
- **Security** in case of vulnerabilities.

these types have to follow the following format:
```markdown
### [type-of-change]
- Details about the change.
- and so on.
```
> [!IMPORTANT]
> When there are not changes of a specific type, the section has not to be created.


## Conventional Commits

The convetional commit allows classify the changes in two ways:
- How the commit wil change the current version of the project.
- What is the type of change.

So, it is a format created to standardize the commit messages and allow the automation of the versioning of the project.

The format of the commit is the following:

```markdown
<type>[optional scope]: <description>
```

For the system the type of the commit is the following:
- feat: new feature
- fix: bug fix
- docs: documentation
- style: formatting, missing semi colons, etc; no code change
- refactor: refactoring production code
- test: adding tests, refactoring test; no production code change
- chore: updating build tasks, package manager configs, etc; no production code change

The scope will not be used.

Finally, to communicate the breaking changes, the commit has to have a special format:
```markdown
<type>!: <description>
```

## Semantic Versioning

The semantic versioning is a standard to versioning the software. It has the following format:
```markdown
<major>.<minor>.<patch>
```

The version has to be calculated following the following rules:
- Major version is incremented when you make incompatible API changes.
- Minor version is incremented when you add functionality in a backwards compatible manner.
- Patch version is incremented when you make backwards compatible bug fixes.

So, the system has to calculate the next version following the commits since the last release.
The mapping between the commits and the semantic version change is the following:

| Commit Type | Version Change |
|-------------|----------------|
| feat        | Minor          |
| fix         | Patch          |
| docs        | None           |
| style       | None           |
| refactor    | None           |
| test        | None           |
| chore       | None           |
| <any>!       | Major          |


Added for new features.
Changed for changes in existing functionality.
Deprecated for soon-to-be removed features.
Removed for now removed features.
Fixed for any bug fixes.
Security in case of vulnerabilities.



## Example

The following example shows a changelog file with two versions and unreleased changes.

```markdown

# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
 [Semantic Versioning](https://semver.org/spec/v2.0.0.html), and
 [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/).

## [Unreleased]

### Added
- New feature 3
- New feature 4

### Changed
- Change 1


## [1.0.0] - 2021-01-01

### Added
- New feature 2


## [0.1.0] - 2020-12-01

### Added
- New feature 1


## Compare

[unreleased]: https://repository-url/compare/1.0.0...HEAD
[1.0.0]: https://repository-url/compare/1.0.0...0.1.0
[0.1.0]: https://repository-url/releases/tag/0.1.0

```