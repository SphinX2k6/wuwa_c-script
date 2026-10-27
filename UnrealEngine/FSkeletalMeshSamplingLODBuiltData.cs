using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001104 RID: 4356
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingLODBuiltData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FSkeletalMeshSamplingLODBuiltData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCD6 RID: 64726 RVA: 0x001756BE File Offset: 0x001738BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingLODBuiltData._ScriptStructPtr != 0) ? FSkeletalMeshSamplingLODBuiltData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingLODBuiltData", ref FSkeletalMeshSamplingLODBuiltData._ScriptStructPtr);
		}

		// Token: 0x0600FCD7 RID: 64727 RVA: 0x001756E2 File Offset: 0x001738E2
		public FSkeletalMeshSamplingLODBuiltData()
		{
		}

		// Token: 0x0600FCD8 RID: 64728 RVA: 0x001756EA File Offset: 0x001738EA
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingLODBuiltData.StaticStruct();
		}

		// Token: 0x0600FCD9 RID: 64729 RVA: 0x001756F6 File Offset: 0x001738F6
		[NullableContext(2)]
		public FSkeletalMeshSamplingLODBuiltData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCDA RID: 64730 RVA: 0x00175700 File Offset: 0x00173900
		public FSkeletalMeshSamplingLODBuiltData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCDB RID: 64731 RVA: 0x0017570B File Offset: 0x0017390B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingLODBuiltData(Pointer, false, true);
		}

		// Token: 0x0600FCDC RID: 64732 RVA: 0x00175715 File Offset: 0x00173915
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingLODBuiltData(Pointer, MemoryOwner);
		}

		// Token: 0x0400884C RID: 34892
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingLODBuiltData";

		// Token: 0x0400884D RID: 34893
		private static IntPtr _ScriptStructPtr;
	}
}
