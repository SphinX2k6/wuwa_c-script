using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A94 RID: 10900
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseSharedPlatformId")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseSharedPlatformId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282DD RID: 164573 RVA: 0x003D20A7 File Offset: 0x003D02A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseSharedPlatformId._ScriptStructPtr != 0) ? FWwiseSharedPlatformId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseSharedPlatformId", ref FWwiseSharedPlatformId._ScriptStructPtr);
		}

		// Token: 0x060282DE RID: 164574 RVA: 0x003D20CB File Offset: 0x003D02CB
		public FWwiseSharedPlatformId()
		{
		}

		// Token: 0x060282DF RID: 164575 RVA: 0x003D20D3 File Offset: 0x003D02D3
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseSharedPlatformId.StaticStruct();
		}

		// Token: 0x060282E0 RID: 164576 RVA: 0x003D20DF File Offset: 0x003D02DF
		[NullableContext(2)]
		public FWwiseSharedPlatformId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060282E1 RID: 164577 RVA: 0x003D20E9 File Offset: 0x003D02E9
		public FWwiseSharedPlatformId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060282E2 RID: 164578 RVA: 0x003D20F4 File Offset: 0x003D02F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseSharedPlatformId(Pointer, false, true);
		}

		// Token: 0x060282E3 RID: 164579 RVA: 0x003D20FE File Offset: 0x003D02FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseSharedPlatformId(Pointer, MemoryOwner);
		}

		// Token: 0x04016089 RID: 90249
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseSharedPlatformId";

		// Token: 0x0401608A RID: 90250
		private static IntPtr _ScriptStructPtr;
	}
}
