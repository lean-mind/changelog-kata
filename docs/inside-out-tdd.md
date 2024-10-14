# Inside-Out TDD

The [Changelog Kata](../README.md) can be resolved using Inside-Out TDD. This approach is based on the idea of starting from the innermost part of the system and working outwards.

To resolve the kata using Inside-Out TDD, you can follow the steps below:

## Create the domain model: ConventionalCommit

To reach the domain model, the following features have to be implemented:

### Parse the Commit Messages
In the context of this kata a valid commit message is one that follows the conventional commits format. The format is as follows:

```
<type>: <description>
```

Where:

- `<type>`: The type of the commit. Possible values are: `feat`, `fix`, `docs`, `style`, `refactor`, `perf`, `test`, `build`, `ci`, `chore`, and `revert`.

- `<description>`: A short description of the commit.

The first step is to parse the commit messages and extract the type, scope, and description.

### Identify the versioning change from commit parsed

The next step is to identify the versioning change based on the type of commit. The versioning change can be one of the following:

- `minor`: When the commit type is `feat`.
- `patch`: When the commit type is `fix`.

an special case is when the commit is a BREAKING CHANGE, in this case the versioning change is `major`. In order to notify this the commit message has to include `!` as follows `<type>!: <description>`.

### Edge cases

#### Convention Commit has been not followed
If the commit message does not follow the conventional commits format, the commit should be ignored.


## Create domain model: Release 

The Release is a list of commits.

To reach the domain model, the following features have to be implemented:

### Calculate the next version

From previous version calculate the next version based on the commits. 

> Note:  The versioning change is the highest versioning change found in the commits.

### Find the Added, Changed, Deprecated, Removed, Fixed, and Security commits

From the commits, find the commits that are related to the following categories:

- `Added`: Commits with type `feat`.
- `Changed`: Commits with type `refactor`, `style`,  `docs`, `perf`, `test`, `build`, `ci`, and `chore`.
- `Deprecated`: Commits with type `refactor`, `style`,  `docs`, `perf`, `test`, `build`, `ci`, and `chore` that include `DEPRECATED` in the description.
- `Removed`: Commits with type `refactor`, `style`,  `docs`, `perf`, `test`, `build`, `ci`, and `chore` that include `REMOVED` in the description.
- `Fixed`: Commits with type `fix`.
- `Security`: Commits with type `fix` that include `SECURITY` in the description.


## Create domain model: Changelog

The Changelog is a list of Releases

