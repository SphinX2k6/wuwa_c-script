using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014C3 RID: 5315
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniGeoInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FHoudiniGeoInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060133BE RID: 78782 RVA: 0x001C494C File Offset: 0x001C2B4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniGeoInfo._ScriptStructPtr != 0) ? FHoudiniGeoInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniGeoInfo", ref FHoudiniGeoInfo._ScriptStructPtr);
		}

		// Token: 0x060133BF RID: 78783 RVA: 0x001C4970 File Offset: 0x001C2B70
		public FHoudiniGeoInfo()
		{
		}

		// Token: 0x060133C0 RID: 78784 RVA: 0x001C4978 File Offset: 0x001C2B78
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniGeoInfo.StaticStruct();
		}

		// Token: 0x060133C1 RID: 78785 RVA: 0x001C4984 File Offset: 0x001C2B84
		[NullableContext(2)]
		public FHoudiniGeoInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060133C2 RID: 78786 RVA: 0x001C498E File Offset: 0x001C2B8E
		public FHoudiniGeoInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060133C3 RID: 78787 RVA: 0x001C4999 File Offset: 0x001C2B99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniGeoInfo(Pointer, false, true);
		}

		// Token: 0x060133C4 RID: 78788 RVA: 0x001C49A3 File Offset: 0x001C2BA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniGeoInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A62A RID: 42538
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniGeoInfo";

		// Token: 0x0400A62B RID: 42539
		private static IntPtr _ScriptStructPtr;
	}
}
