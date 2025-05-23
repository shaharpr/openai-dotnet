// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalResponsesToolChoiceObjectType : IEquatable<InternalResponsesToolChoiceObjectType>
    {
        private readonly string _value;
        private const string FunctionValue = "function";
        private const string FileSearchValue = "file_search";
        private const string WebSearchValue = "web_search_preview";
        private const string ComputerValue = "computer_use_preview";

        public InternalResponsesToolChoiceObjectType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalResponsesToolChoiceObjectType Function { get; } = new InternalResponsesToolChoiceObjectType(FunctionValue);

        public static InternalResponsesToolChoiceObjectType FileSearch { get; } = new InternalResponsesToolChoiceObjectType(FileSearchValue);

        public static InternalResponsesToolChoiceObjectType WebSearch { get; } = new InternalResponsesToolChoiceObjectType(WebSearchValue);

        public static InternalResponsesToolChoiceObjectType Computer { get; } = new InternalResponsesToolChoiceObjectType(ComputerValue);

        public static bool operator ==(InternalResponsesToolChoiceObjectType left, InternalResponsesToolChoiceObjectType right) => left.Equals(right);

        public static bool operator !=(InternalResponsesToolChoiceObjectType left, InternalResponsesToolChoiceObjectType right) => !left.Equals(right);

        public static implicit operator InternalResponsesToolChoiceObjectType(string value) => new InternalResponsesToolChoiceObjectType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalResponsesToolChoiceObjectType other && Equals(other);

        public bool Equals(InternalResponsesToolChoiceObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
