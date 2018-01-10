namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DeleteProjectColumn
    /// </summary>
    public class DeleteProjectColumnPayload : QueryEntity
    {
        public DeleteProjectColumnPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The deleted column ID.
        /// </summary>
        public string DeletedColumnId { get; }

        /// <summary>
        /// The project the deleted column was in.
        /// </summary>
        public Project Project => this.CreateProperty(x => x.Project, Octokit.GraphQL.Model.Project.Create);

        internal static DeleteProjectColumnPayload Create(IQueryProvider provider, Expression expression)
        {
            return new DeleteProjectColumnPayload(provider, expression);
        }
    }
}