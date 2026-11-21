using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200021B RID: 539
	[UnrealObjectPath("/Script/Engine.IndexedCurve")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FIndexedCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060024A0 RID: 9376 RVA: 0x00034C1E File Offset: 0x00032E1E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIndexedCurve._ScriptStructPtr != 0) ? FIndexedCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.IndexedCurve", ref FIndexedCurve._ScriptStructPtr);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00034C42 File Offset: 0x00032E42
		public FIndexedCurve()
		{
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00034C4A File Offset: 0x00032E4A
		protected override IntPtr GetUStructPtr()
		{
			return FIndexedCurve.StaticStruct();
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00034C56 File Offset: 0x00032E56
		[NullableContext(2)]
		public FIndexedCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00034C60 File Offset: 0x00032E60
		public FIndexedCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00034C6B File Offset: 0x00032E6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIndexedCurve(Pointer, false, true);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00034C75 File Offset: 0x00032E75
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIndexedCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04000DC2 RID: 3522
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.IndexedCurve";

		// Token: 0x04000DC3 RID: 3523
		private static IntPtr _ScriptStructPtr;
	}
}
