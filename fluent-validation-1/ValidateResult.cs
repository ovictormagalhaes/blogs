using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace fluent_validation_1
{
    public interface IValidable
    {
        void Validate();
    }


    public record FieldValue(string Field, string Value);
    public class CustomValidationResult
    {
        public IList<FieldValue> Errors { get; init; }

        public CustomValidationResult(string field, string value)
        {
            Errors = new List<FieldValue>() { new FieldValue(field, value) };
        }

        public CustomValidationResult(FluentValidation.Results.ValidationResult result)
        {
            if (result is not null)
                Errors = result.Errors.Select(e => new FieldValue(e.PropertyName, e.ErrorMessage)).ToList();
        }

        public void Add(string field, string value)
        {
            Errors.Add(new FieldValue(field, value));
        }
    }
}
