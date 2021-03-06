// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about a Task running on a Compute Node.
    /// </summary>
    public partial class TaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the TaskInformation class.
        /// </summary>
        public TaskInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskInformation class.
        /// </summary>
        /// <param name="taskState">The current state of the Task.</param>
        /// <param name="taskUrl">The URL of the Task.</param>
        /// <param name="jobId">The ID of the Job to which the Task
        /// belongs.</param>
        /// <param name="taskId">The ID of the Task.</param>
        /// <param name="subtaskId">The ID of the subtask if the Task is a
        /// multi-instance Task.</param>
        /// <param name="executionInfo">Information about the execution of the
        /// Task.</param>
        public TaskInformation(TaskState taskState, string taskUrl = default(string), string jobId = default(string), string taskId = default(string), int? subtaskId = default(int?), TaskExecutionInformation executionInfo = default(TaskExecutionInformation))
        {
            TaskUrl = taskUrl;
            JobId = jobId;
            TaskId = taskId;
            SubtaskId = subtaskId;
            TaskState = taskState;
            ExecutionInfo = executionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the Task.
        /// </summary>
        [JsonProperty(PropertyName = "taskUrl")]
        public string TaskUrl { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Job to which the Task belongs.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Task.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the subtask if the Task is a multi-instance
        /// Task.
        /// </summary>
        [JsonProperty(PropertyName = "subtaskId")]
        public int? SubtaskId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Task.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "taskState")]
        public TaskState TaskState { get; set; }

        /// <summary>
        /// Gets or sets information about the execution of the Task.
        /// </summary>
        [JsonProperty(PropertyName = "executionInfo")]
        public TaskExecutionInformation ExecutionInfo { get; set; }

    }
}
