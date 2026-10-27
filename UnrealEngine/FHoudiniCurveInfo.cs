using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014BE RID: 5310
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniCurveInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FHoudiniCurveInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013382 RID: 78722 RVA: 0x001C44C7 File Offset: 0x001C26C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniCurveInfo._ScriptStructPtr != 0) ? FHoudiniCurveInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniCurveInfo", ref FHoudiniCurveInfo._ScriptStructPtr);
		}

		// Token: 0x06013383 RID: 78723 RVA: 0x001C44EB File Offset: 0x001C26EB
		public FHoudiniCurveInfo()
		{
		}

		// Token: 0x06013384 RID: 78724 RVA: 0x001C44F3 File Offset: 0x001C26F3
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniCurveInfo.StaticStruct();
		}

		// Token: 0x06013385 RID: 78725 RVA: 0x001C44FF File Offset: 0x001C26FF
		[NullableContext(2)]
		public FHoudiniCurveInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013386 RID: 78726 RVA: 0x001C4509 File Offset: 0x001C2709
		public FHoudiniCurveInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013387 RID: 78727 RVA: 0x001C4514 File Offset: 0x001C2714
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniCurveInfo(Pointer, false, true);
		}

		// Token: 0x06013388 RID: 78728 RVA: 0x001C451E File Offset: 0x001C271E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniCurveInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400A610 RID: 42512
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniCurveInfo";

		// Token: 0x0400A611 RID: 42513
		private static IntPtr _ScriptStructPtr;
	}
}
