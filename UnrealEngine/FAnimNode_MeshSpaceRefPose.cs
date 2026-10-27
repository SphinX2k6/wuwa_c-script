using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002E7 RID: 743
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_MeshSpaceRefPose")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimNode_MeshSpaceRefPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A3A RID: 10810 RVA: 0x000401BA File Offset: 0x0003E3BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MeshSpaceRefPose._ScriptStructPtr != 0) ? FAnimNode_MeshSpaceRefPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_MeshSpaceRefPose", ref FAnimNode_MeshSpaceRefPose._ScriptStructPtr);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000401DE File Offset: 0x0003E3DE
		public FAnimNode_MeshSpaceRefPose()
		{
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000401E6 File Offset: 0x0003E3E6
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MeshSpaceRefPose.StaticStruct();
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000401F2 File Offset: 0x0003E3F2
		[NullableContext(2)]
		public FAnimNode_MeshSpaceRefPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000401FC File Offset: 0x0003E3FC
		public FAnimNode_MeshSpaceRefPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00040207 File Offset: 0x0003E407
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MeshSpaceRefPose(Pointer, false, true);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00040211 File Offset: 0x0003E411
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MeshSpaceRefPose(Pointer, MemoryOwner);
		}

		// Token: 0x04001112 RID: 4370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_MeshSpaceRefPose";

		// Token: 0x04001113 RID: 4371
		private static IntPtr _ScriptStructPtr;
	}
}
