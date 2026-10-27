using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E33 RID: 7731
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_Shape2D_DamageTotalInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D754 RID: 120660 RVA: 0x002B8162 File Offset: 0x002B6362
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr != 0) ? FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo", ref FKSC_Shape2D_DamageTotalInfo._ScriptStructPtr);
		}

		// Token: 0x170076BB RID: 30395
		// (get) Token: 0x0601D755 RID: 120661 RVA: 0x002B8186 File Offset: 0x002B6386
		// (set) Token: 0x0601D756 RID: 120662 RVA: 0x002B8196 File Offset: 0x002B6396
		public unsafe int SourceEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_SourceEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_SourceEntityId) = value;
			}
		}

		// Token: 0x170076BC RID: 30396
		// (get) Token: 0x0601D757 RID: 120663 RVA: 0x002B81A7 File Offset: 0x002B63A7
		// (set) Token: 0x0601D758 RID: 120664 RVA: 0x002B81B7 File Offset: 0x002B63B7
		public unsafe int TargetEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_TargetEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_TargetEntityId) = value;
			}
		}

		// Token: 0x170076BD RID: 30397
		// (get) Token: 0x0601D759 RID: 120665 RVA: 0x002B81C8 File Offset: 0x002B63C8
		// (set) Token: 0x0601D75A RID: 120666 RVA: 0x002B81D8 File Offset: 0x002B63D8
		public unsafe int DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageId) = value;
			}
		}

		// Token: 0x170076BE RID: 30398
		// (get) Token: 0x0601D75B RID: 120667 RVA: 0x002B81E9 File Offset: 0x002B63E9
		// (set) Token: 0x0601D75C RID: 120668 RVA: 0x002B81F9 File Offset: 0x002B63F9
		public unsafe int DamageValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Shape2D_DamageTotalInfo.__PropertyOffset_DamageValue) = value;
			}
		}

		// Token: 0x0601D75D RID: 120669 RVA: 0x002B820A File Offset: 0x002B640A
		public FKSC_Shape2D_DamageTotalInfo()
		{
		}

		// Token: 0x0601D75E RID: 120670 RVA: 0x002B8212 File Offset: 0x002B6412
		public FKSC_Shape2D_DamageTotalInfo(int SourceEntityId, int TargetEntityId, int DamageId, int DamageValue)
		{
			this.SourceEntityId = SourceEntityId;
			this.TargetEntityId = TargetEntityId;
			this.DamageId = DamageId;
			this.DamageValue = DamageValue;
		}

		// Token: 0x0601D75F RID: 120671 RVA: 0x002B8237 File Offset: 0x002B6437
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Shape2D_DamageTotalInfo.StaticStruct();
		}

		// Token: 0x0601D760 RID: 120672 RVA: 0x002B8243 File Offset: 0x002B6443
		[NullableContext(2)]
		public FKSC_Shape2D_DamageTotalInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D761 RID: 120673 RVA: 0x002B824D File Offset: 0x002B644D
		public FKSC_Shape2D_DamageTotalInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D762 RID: 120674 RVA: 0x002B8258 File Offset: 0x002B6458
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Shape2D_DamageTotalInfo(Pointer, false, true);
		}

		// Token: 0x0601D763 RID: 120675 RVA: 0x002B8262 File Offset: 0x002B6462
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Shape2D_DamageTotalInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400FF8E RID: 65422
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_DamageTotalInfo";

		// Token: 0x0400FF8F RID: 65423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FF90 RID: 65424
		internal static int __PropertyOffset_SourceEntityId;

		// Token: 0x0400FF91 RID: 65425
		internal static int __PropertyOffset_TargetEntityId;

		// Token: 0x0400FF92 RID: 65426
		internal static int __PropertyOffset_DamageId;

		// Token: 0x0400FF93 RID: 65427
		internal static int __PropertyOffset_DamageValue;
	}
}
