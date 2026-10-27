using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001195 RID: 4501
	[UnrealObjectPath("/Script/Engine.StaticMeshComponentLODInfo")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FStaticMeshComponentLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601094D RID: 67917 RVA: 0x00185A30 File Offset: 0x00183C30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshComponentLODInfo._ScriptStructPtr != 0) ? FStaticMeshComponentLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshComponentLODInfo", ref FStaticMeshComponentLODInfo._ScriptStructPtr);
		}

		// Token: 0x0601094E RID: 67918 RVA: 0x00185A54 File Offset: 0x00183C54
		public FStaticMeshComponentLODInfo()
		{
		}

		// Token: 0x0601094F RID: 67919 RVA: 0x00185A5C File Offset: 0x00183C5C
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshComponentLODInfo.StaticStruct();
		}

		// Token: 0x06010950 RID: 67920 RVA: 0x00185A68 File Offset: 0x00183C68
		[NullableContext(2)]
		public FStaticMeshComponentLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010951 RID: 67921 RVA: 0x00185A72 File Offset: 0x00183C72
		public FStaticMeshComponentLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010952 RID: 67922 RVA: 0x00185A7D File Offset: 0x00183C7D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshComponentLODInfo(Pointer, false, true);
		}

		// Token: 0x06010953 RID: 67923 RVA: 0x00185A87 File Offset: 0x00183C87
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshComponentLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008DEE RID: 36334
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StaticMeshComponentLODInfo";

		// Token: 0x04008DEF RID: 36335
		private static IntPtr _ScriptStructPtr;
	}
}
