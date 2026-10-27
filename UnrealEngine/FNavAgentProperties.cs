using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000ECE RID: 3790
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.NavAgentProperties")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNavAgentProperties : FMovementProperties, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CD0F RID: 52495 RVA: 0x0012A9AC File Offset: 0x00128BAC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavAgentProperties._ScriptStructPtr != 0) ? FNavAgentProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavAgentProperties", ref FNavAgentProperties._ScriptStructPtr);
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600CD10 RID: 52496 RVA: 0x0012A9D0 File Offset: 0x00128BD0
		// (set) Token: 0x0600CD11 RID: 52497 RVA: 0x0012A9E0 File Offset: 0x00128BE0
		public unsafe float AgentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentRadius) = value;
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600CD12 RID: 52498 RVA: 0x0012A9F1 File Offset: 0x00128BF1
		// (set) Token: 0x0600CD13 RID: 52499 RVA: 0x0012AA01 File Offset: 0x00128C01
		public unsafe float AgentHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentHeight) = value;
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x0012AA12 File Offset: 0x00128C12
		// (set) Token: 0x0600CD15 RID: 52501 RVA: 0x0012AA22 File Offset: 0x00128C22
		public unsafe float AgentStepHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentStepHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_AgentStepHeight) = value;
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x0012AA33 File Offset: 0x00128C33
		// (set) Token: 0x0600CD17 RID: 52503 RVA: 0x0012AA43 File Offset: 0x00128C43
		public unsafe float NavWalkingSearchHeightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_NavWalkingSearchHeightScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_NavWalkingSearchHeightScale) = value;
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x0012AA54 File Offset: 0x00128C54
		// (set) Token: 0x0600CD19 RID: 52505 RVA: 0x0012AA97 File Offset: 0x00128C97
		public FSoftClassPath PreferredNavData
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._PreferredNavData) == null)
				{
					result = (this._PreferredNavData = new FSoftClassPath(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_PreferredNavData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_PreferredNavData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x0012AAB8 File Offset: 0x00128CB8
		// (set) Token: 0x0600CD1B RID: 52507 RVA: 0x0012AAC8 File Offset: 0x00128CC8
		public unsafe ENavMeshTargetPlatform TargetPlatform
		{
			get
			{
				return (ENavMeshTargetPlatform)(*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_TargetPlatform));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavAgentProperties.__PropertyOffset_TargetPlatform) = (byte)value;
			}
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x0012AAD9 File Offset: 0x00128CD9
		public FNavAgentProperties()
		{
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x0012AAE4 File Offset: 0x00128CE4
		public FNavAgentProperties(float AgentRadius, float AgentHeight, float AgentStepHeight, float NavWalkingSearchHeightScale, FSoftClassPath PreferredNavData, ENavMeshTargetPlatform TargetPlatform, bool bCanCrouch, bool bCanJump, bool bCanWalk, bool bCanSwim, bool bCanFly)
		{
			this.AgentRadius = AgentRadius;
			this.AgentHeight = AgentHeight;
			this.AgentStepHeight = AgentStepHeight;
			this.NavWalkingSearchHeightScale = NavWalkingSearchHeightScale;
			this.PreferredNavData = PreferredNavData;
			this.TargetPlatform = TargetPlatform;
			base.bCanCrouch = bCanCrouch;
			base.bCanJump = bCanJump;
			base.bCanWalk = bCanWalk;
			base.bCanSwim = bCanSwim;
			base.bCanFly = bCanFly;
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x0012AB4C File Offset: 0x00128D4C
		protected override IntPtr GetUStructPtr()
		{
			return FNavAgentProperties.StaticStruct();
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x0012AB58 File Offset: 0x00128D58
		[NullableContext(2)]
		public FNavAgentProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x0012AB62 File Offset: 0x00128D62
		public FNavAgentProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD21 RID: 52513 RVA: 0x0012AB6D File Offset: 0x00128D6D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavAgentProperties(Pointer, false, true);
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x0012AB77 File Offset: 0x00128D77
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavAgentProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04006E56 RID: 28246
		public new const string __ObjectPath = "/Script/Engine.NavAgentProperties";

		// Token: 0x04006E57 RID: 28247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E58 RID: 28248
		internal static int __PropertyOffset_AgentRadius;

		// Token: 0x04006E59 RID: 28249
		internal static int __PropertyOffset_AgentHeight;

		// Token: 0x04006E5A RID: 28250
		internal static int __PropertyOffset_AgentStepHeight;

		// Token: 0x04006E5B RID: 28251
		internal static int __PropertyOffset_NavWalkingSearchHeightScale;

		// Token: 0x04006E5C RID: 28252
		internal static int __PropertyOffset_PreferredNavData;

		// Token: 0x04006E5D RID: 28253
		[Nullable(2)]
		private FSoftClassPath _PreferredNavData;

		// Token: 0x04006E5E RID: 28254
		internal static int __PropertyOffset_TargetPlatform;
	}
}
