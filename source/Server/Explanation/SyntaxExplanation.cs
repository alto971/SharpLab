using SourcePath.CSharp;

namespace SharpLab.Server.Explanation {
    public class SyntaxExplanation {
        public SyntaxExplanation(SyntaxPath path, string name, string text, string link) {
            Path = Argument.NotNull(nameof(path), path);
            Name = Argument.NotNullOrEmpty(nameof(name), name);
            Text = Argument.NotNullOrEmpty(nameof(text), text);
            Link = link;
        }

        public SyntaxPath Path { get; }
        public string Name { get; }
        public string Text { get; }
        public string Link { get; }
    }
}