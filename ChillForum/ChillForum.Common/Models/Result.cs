namespace ChillForum.Common.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    public class Result
    {
        private readonly List<string> errors;

        internal Result(bool succeeded, List<string> errors)
        {
            this.Succeeded = succeeded;
            this.errors = errors;
        }

        public bool Succeeded { get; }

        public List<string> Errors
            => this.Succeeded
                ? new List<string>()
                : this.errors;

        public static Result Success
            => new Result(true, new List<string>());

        public static Result Failure(string error) => error;

        public static Result Failure(IEnumerable<string> errors)
            => new Result(false, errors.ToList());

        public static implicit operator Result(string error)
            => Failure(new List<string> { error });

        public static implicit operator Result(List<string> errors)
            => Failure(errors.ToList());

        public static implicit operator Result(bool success)
            => success ? Success : Failure(new[] { "Unsuccessful operation." });

        public static implicit operator bool(Result result)
            => result.Succeeded;

        public static implicit operator ActionResult(Result result)
        {
            if (!result.Succeeded)
            {
                return new BadRequestObjectResult(result.Errors);
            }

            return new OkResult();
        }
    }
}
