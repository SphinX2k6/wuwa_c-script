using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A92 RID: 10898
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseSharedGroupValueKey")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseSharedGroupValueKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282CC RID: 164556 RVA: 0x003D1FB7 File Offset: 0x003D01B7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseSharedGroupValueKey._ScriptStructPtr != 0) ? FWwiseSharedGroupValueKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseSharedGroupValueKey", ref FWwiseSharedGroupValueKey._ScriptStructPtr);
		}

		// Token: 0x060282CD RID: 164557 RVA: 0x003D1FDB File Offset: 0x003D01DB
		public FWwiseSharedGroupValueKey()
		{
		}

		// Token: 0x060282CE RID: 164558 RVA: 0x003D1FE3 File Offset: 0x003D01E3
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseSharedGroupValueKey.StaticStruct();
		}

		// Token: 0x060282CF RID: 164559 RVA: 0x003D1FEF File Offset: 0x003D01EF
		[NullableContext(2)]
		public FWwiseSharedGroupValueKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060282D0 RID: 164560 RVA: 0x003D1FF9 File Offset: 0x003D01F9
		public FWwiseSharedGroupValueKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060282D1 RID: 164561 RVA: 0x003D2004 File Offset: 0x003D0204
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseSharedGroupValueKey(Pointer, false, true);
		}

		// Token: 0x060282D2 RID: 164562 RVA: 0x003D200E File Offset: 0x003D020E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseSharedGroupValueKey(Pointer, MemoryOwner);
		}

		// Token: 0x04016084 RID: 90244
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseSharedGroupValueKey";

		// Token: 0x04016085 RID: 90245
		private static IntPtr _ScriptStructPtr;
	}
}
