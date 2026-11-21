using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000142 RID: 322
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.PrimaryAssetId")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPrimaryAssetId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x0001DA16 File Offset: 0x0001BC16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetId._ScriptStructPtr != 0) ? FPrimaryAssetId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PrimaryAssetId", ref FPrimaryAssetId._ScriptStructPtr);
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0001DA7F File Offset: 0x0001BC7F
		public FPrimaryAssetType PrimaryAssetType
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetType result;
				if ((result = this._PrimaryAssetType) == null)
				{
					result = (this._PrimaryAssetType = new FPrimaryAssetType(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetType.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		public unsafe FName PrimaryAssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetName) = value;
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0001DAC9 File Offset: 0x0001BCC9
		public FPrimaryAssetId()
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0001DAD1 File Offset: 0x0001BCD1
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetId.StaticStruct();
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0001DADD File Offset: 0x0001BCDD
		[NullableContext(2)]
		public FPrimaryAssetId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0001DAE7 File Offset: 0x0001BCE7
		public FPrimaryAssetId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0001DAF2 File Offset: 0x0001BCF2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetId(Pointer, false, true);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetId(Pointer, MemoryOwner);
		}

		// Token: 0x040005D6 RID: 1494
		public const string __ObjectPath = "/Script/CoreUObject.PrimaryAssetId";

		// Token: 0x040005D7 RID: 1495
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040005D8 RID: 1496
		internal static int __PropertyOffset_PrimaryAssetType;

		// Token: 0x040005D9 RID: 1497
		[Nullable(2)]
		private FPrimaryAssetType _PrimaryAssetType;

		// Token: 0x040005DA RID: 1498
		internal static int __PropertyOffset_PrimaryAssetName;
	}
}
