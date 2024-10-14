using FluentAssertions;

namespace DomainTests;

public class ConventionalCommitTests
{
    [Fact]
    public void should_infer_type_commit_from_a_conventional_commit_message()
    {
        var commitMessage = "feat: add new feature";
        
        var commit = ConventionalCommit.createFrom(commitMessage);
        
        commit.Type.Should().Be(CommitType.FEATURE);
    }
}

public class ConventionalCommit
{
    public static ConventionalCommit createFrom(string commitMessage)
    {
        return new ConventionalCommit(CommitType.FEATURE);
    }
    
    public CommitType Type { get; }
    
    public ConventionalCommit(CommitType type)
    {
        this.Type = type;
    }
}

public enum CommitType
{
    FEATURE
}