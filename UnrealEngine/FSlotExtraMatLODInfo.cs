using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200111B RID: 4379
	[UnrealObjectPath("/Script/Engine.SlotExtraMatLODInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSlotExtraMatLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FFF8 RID: 65528 RVA: 0x00178F92 File Offset: 0x00177192
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlotExtraMatLODInfo._ScriptStructPtr != 0) ? FSlotExtraMatLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SlotExtraMatLODInfo", ref FSlotExtraMatLODInfo._ScriptStructPtr);
		}

		// Token: 0x0600FFF9 RID: 65529 RVA: 0x00178FB6 File Offset: 0x001771B6
		public FSlotExtraMatLODInfo()
		{
		}

		// Token: 0x0600FFFA RID: 65530 RVA: 0x00178FBE File Offset: 0x001771BE
		protected override IntPtr GetUStructPtr()
		{
			return FSlotExtraMatLODInfo.StaticStruct();
		}

		// Token: 0x0600FFFB RID: 65531 RVA: 0x00178FCA File Offset: 0x001771CA
		[NullableContext(2)]
		public FSlotExtraMatLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FFFC RID: 65532 RVA: 0x00178FD4 File Offset: 0x001771D4
		public FSlotExtraMatLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FFFD RID: 65533 RVA: 0x00178FDF File Offset: 0x001771DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlotExtraMatLODInfo(Pointer, false, true);
		}

		// Token: 0x0600FFFE RID: 65534 RVA: 0x00178FE9 File Offset: 0x001771E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlotExtraMatLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400898B RID: 35211
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SlotExtraMatLODInfo";

		// Token: 0x0400898C RID: 35212
		private static IntPtr _ScriptStructPtr;
	}
}
