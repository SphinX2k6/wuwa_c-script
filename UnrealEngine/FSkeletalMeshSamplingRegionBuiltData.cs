using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001107 RID: 4359
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingRegionBuiltData")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FSkeletalMeshSamplingRegionBuiltData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCFD RID: 64765 RVA: 0x00175A1E File Offset: 0x00173C1E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingRegionBuiltData._ScriptStructPtr != 0) ? FSkeletalMeshSamplingRegionBuiltData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingRegionBuiltData", ref FSkeletalMeshSamplingRegionBuiltData._ScriptStructPtr);
		}

		// Token: 0x0600FCFE RID: 64766 RVA: 0x00175A42 File Offset: 0x00173C42
		public FSkeletalMeshSamplingRegionBuiltData()
		{
		}

		// Token: 0x0600FCFF RID: 64767 RVA: 0x00175A4A File Offset: 0x00173C4A
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingRegionBuiltData.StaticStruct();
		}

		// Token: 0x0600FD00 RID: 64768 RVA: 0x00175A56 File Offset: 0x00173C56
		[NullableContext(2)]
		public FSkeletalMeshSamplingRegionBuiltData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FD01 RID: 64769 RVA: 0x00175A60 File Offset: 0x00173C60
		public FSkeletalMeshSamplingRegionBuiltData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FD02 RID: 64770 RVA: 0x00175A6B File Offset: 0x00173C6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingRegionBuiltData(Pointer, false, true);
		}

		// Token: 0x0600FD03 RID: 64771 RVA: 0x00175A75 File Offset: 0x00173C75
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingRegionBuiltData(Pointer, MemoryOwner);
		}

		// Token: 0x0400885F RID: 34911
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingRegionBuiltData";

		// Token: 0x04008860 RID: 34912
		private static IntPtr _ScriptStructPtr;
	}
}
