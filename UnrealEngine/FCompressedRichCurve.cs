using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000969 RID: 2409
	[UnrealObjectPath("/Script/Engine.CompressedRichCurve")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCompressedRichCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008803 RID: 34819 RVA: 0x000C2DF0 File Offset: 0x000C0FF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompressedRichCurve._ScriptStructPtr != 0) ? FCompressedRichCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CompressedRichCurve", ref FCompressedRichCurve._ScriptStructPtr);
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x000C2E14 File Offset: 0x000C1014
		public FCompressedRichCurve()
		{
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x000C2E1C File Offset: 0x000C101C
		protected override IntPtr GetUStructPtr()
		{
			return FCompressedRichCurve.StaticStruct();
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x000C2E28 File Offset: 0x000C1028
		[NullableContext(2)]
		public FCompressedRichCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x000C2E32 File Offset: 0x000C1032
		public FCompressedRichCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x000C2E3D File Offset: 0x000C103D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompressedRichCurve(Pointer, false, true);
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x000C2E47 File Offset: 0x000C1047
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompressedRichCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040040A9 RID: 16553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CompressedRichCurve";

		// Token: 0x040040AA RID: 16554
		private static IntPtr _ScriptStructPtr;
	}
}
