using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021F5 RID: 8693
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBaseUniformData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLiveLinkBaseUniformData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602123B RID: 135739 RVA: 0x0030DDD4 File Offset: 0x0030BFD4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkBaseUniformData._ScriptStructPtr != 0) ? FLiveLinkBaseUniformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkBaseUniformData", ref FLiveLinkBaseUniformData._ScriptStructPtr);
		}

		// Token: 0x0602123C RID: 135740 RVA: 0x0030DDF8 File Offset: 0x0030BFF8
		public FLiveLinkBaseUniformData()
		{
		}

		// Token: 0x0602123D RID: 135741 RVA: 0x0030DE00 File Offset: 0x0030C000
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkBaseUniformData.StaticStruct();
		}

		// Token: 0x0602123E RID: 135742 RVA: 0x0030DE0C File Offset: 0x0030C00C
		[NullableContext(2)]
		public FLiveLinkBaseUniformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602123F RID: 135743 RVA: 0x0030DE16 File Offset: 0x0030C016
		public FLiveLinkBaseUniformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021240 RID: 135744 RVA: 0x0030DE21 File Offset: 0x0030C021
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkBaseUniformData(Pointer, false, true);
		}

		// Token: 0x06021241 RID: 135745 RVA: 0x0030DE2B File Offset: 0x0030C02B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkBaseUniformData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AF0 RID: 72432
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBaseUniformData";

		// Token: 0x04011AF1 RID: 72433
		private static IntPtr _ScriptStructPtr;
	}
}
