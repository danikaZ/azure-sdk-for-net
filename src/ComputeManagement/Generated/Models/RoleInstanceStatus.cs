// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The current status of a role instance.
    /// </summary>
    public static partial class RoleInstanceStatus
    {
        /// <summary>
        /// The role state is currently unknown. The state should automatically
        /// be resolved once the role state is detected, so no action is
        /// required.
        /// </summary>
        public const string RoleStateUnknown = "RoleStateUnknown";
        
        /// <summary>
        /// The host agent is currently creating resources for the Virtual
        /// Machine.
        /// </summary>
        public const string CreatingVM = "CreatingVM";
        
        /// <summary>
        /// The host agent is starting the Virtual Machine.
        /// </summary>
        public const string StartingVM = "StartingVM";
        
        /// <summary>
        /// Azure is creating resources for the role.
        /// </summary>
        public const string CreatingRole = "CreatingRole";
        
        /// <summary>
        /// Azure is starting the role.
        /// </summary>
        public const string StartingRole = "StartingRole";
        
        /// <summary>
        /// The role instance has started and is ready to be used.
        /// </summary>
        public const string ReadyRole = "ReadyRole";
        
        /// <summary>
        /// The role instance is unavailable for requests. This state is
        /// usually generated while the role is being created or stopped.
        /// </summary>
        public const string BusyRole = "BusyRole";
        
        /// <summary>
        /// Azure is stopping the role.
        /// </summary>
        public const string StoppingRole = "StoppingRole";
        
        /// <summary>
        /// The host agent is stopping the Virtual Machine. This status also
        /// indicates that the role has already been stopped.
        /// </summary>
        public const string StoppingVM = "StoppingVM";
        
        /// <summary>
        /// The Virtual Machine is being deleted by the host agent.
        /// </summary>
        public const string DeletingVM = "DeletingVM";
        
        /// <summary>
        /// The Virtual Machine is not running. This is the final state of the
        /// shutdown process, and no other status messages should be received
        /// after StoppedVM.
        /// </summary>
        public const string StoppedVM = "StoppedVM";
        
        /// <summary>
        /// The role has unexpectedly stopped or has failed to start. This
        /// status indicates that there is a problem with the role that is
        /// causing it to crash or is preventing it from starting, which must
        /// be corrected before the role can be started. The
        /// InstanceStateDetails and InstanceErrorCode fields can hold
        /// information about the role error that caused this state, which may
        /// be useful for identifying and debugging the problem.
        /// </summary>
        public const string RestartingRole = "RestartingRole";
        
        /// <summary>
        /// The role has continually crashed after being started by Azure. This
        /// status indicates that there is a problem with the role that
        /// prevents it from starting, and may be generated after the
        /// StartingRole and ReadyRole statuses are received. The problem in
        /// the role must be found and corrected before the role can be
        /// started. The InstanceStateDetails and InstanceErrorCode fields can
        /// hold information about the role error that caused this state,
        /// which may be useful for identifying and debugging the problem.
        /// </summary>
        public const string CyclingRole = "CyclingRole";
        
        /// <summary>
        /// The role has continually failed to start. This status indicates
        /// that there is a problem with the role that prevents it from
        /// starting, and may be generated after the process returns
        /// StartingRole. The problem in the role must be found and corrected
        /// before the role can be started. The InstanceStateDetails and
        /// InstanceErrorCode fields can hold information about the role error
        /// that caused this state, which may be useful for identifying and
        /// debugging the problem.
        /// </summary>
        public const string FailedStartingRole = "FailedStartingRole";
        
        /// <summary>
        /// An Azure or container error is preventing the Virtual Machine from
        /// starting. This status is generated by Azure, and does not indicate
        /// an error with the role. It may be generated after the StartingRole
        /// state.
        /// </summary>
        public const string FailedStartingVM = "FailedStartingVM";
        
        /// <summary>
        /// The role has timed out before receiving a status message and is not
        /// responding to requests.
        /// </summary>
        public const string UnresponsiveRole = "UnresponsiveRole";
    }
}
