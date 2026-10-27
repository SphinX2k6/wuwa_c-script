using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014E4 RID: 5348
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniObjectInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FHoudiniObjectInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060135C1 RID: 79297 RVA: 0x001C77CA File Offset: 0x001C59CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniObjectInfo._ScriptStructPtr != 0) ? FHoudiniObjectInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniObjectInfo", ref FHoudiniObjectInfo._ScriptStructPtr);
		}

		// Token: 0x060135C2 RID: 79298 RVA: 0x001C77EE File Offset: 0x001C59EE
		public FHoudiniObjectInfo()
		{
		}

		// Token: 0x060135C3 RID: 79299 RVA: 0x001C77F6 File Offset: 0x001C59F6
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniObjectInfo.StaticStruct();
		}

		// Token: 0x060135C4 RID: 79300 RVA: 0x001C7802 File Offset: 0x001C5A02
		[NullableContext(2)]
		public FHoudiniObjectInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060135C5 RID: 79301 RVA: 0x001C780C File Offset: 0x001C5A0C
		public FHoudiniObjectInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060135C6 RID: 79302 RVA: 0x001C7817 File Offset: 0x001C5A17
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniObjectInfo(Pointer, false, true);
		}

		// Token: 0x060135C7 RID: 79303 RVA: 0x001C7821 File Offset: 0x001C5A21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniObjectInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A758 RID: 42840
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniObjectInfo";

		// Token: 0x0400A759 RID: 42841
		private static IntPtr _ScriptStructPtr;
	}
}
