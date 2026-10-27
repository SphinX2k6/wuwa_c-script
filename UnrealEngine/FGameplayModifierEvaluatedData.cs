using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001397 RID: 5015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayModifierEvaluatedData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FGameplayModifierEvaluatedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126AC RID: 75436 RVA: 0x001B1298 File Offset: 0x001AF498
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayModifierEvaluatedData._ScriptStructPtr != 0) ? FGameplayModifierEvaluatedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayModifierEvaluatedData", ref FGameplayModifierEvaluatedData._ScriptStructPtr);
		}

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x060126AD RID: 75437 RVA: 0x001B12BC File Offset: 0x001AF4BC
		// (set) Token: 0x060126AE RID: 75438 RVA: 0x001B12FF File Offset: 0x001AF4FF
		public FGameplayAttribute Attribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._Attribute) == null)
				{
					result = (this._Attribute = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Attribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Attribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x060126AF RID: 75439 RVA: 0x001B1320 File Offset: 0x001AF520
		// (set) Token: 0x060126B0 RID: 75440 RVA: 0x001B1334 File Offset: 0x001AF534
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayModOp> ModifierOp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_ModifierOp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_ModifierOp) = value;
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x060126B1 RID: 75441 RVA: 0x001B1349 File Offset: 0x001AF549
		// (set) Token: 0x060126B2 RID: 75442 RVA: 0x001B1359 File Offset: 0x001AF559
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x060126B3 RID: 75443 RVA: 0x001B136C File Offset: 0x001AF56C
		// (set) Token: 0x060126B4 RID: 75444 RVA: 0x001B13AF File Offset: 0x001AF5AF
		public FActiveGameplayEffectHandle Handle
		{
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayEffectHandle result;
				if ((result = this._Handle) == null)
				{
					result = (this._Handle = new FActiveGameplayEffectHandle(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Handle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActiveGameplayEffectHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_Handle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x060126B5 RID: 75445 RVA: 0x001B13D0 File Offset: 0x001AF5D0
		// (set) Token: 0x060126B6 RID: 75446 RVA: 0x001B13E0 File Offset: 0x001AF5E0
		public new unsafe bool IsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_IsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayModifierEvaluatedData.__PropertyOffset_IsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x060126B7 RID: 75447 RVA: 0x001B13F1 File Offset: 0x001AF5F1
		public FGameplayModifierEvaluatedData()
		{
		}

		// Token: 0x060126B8 RID: 75448 RVA: 0x001B13F9 File Offset: 0x001AF5F9
		public FGameplayModifierEvaluatedData(FGameplayAttribute Attribute, [Nullable(0)] TEnumAsByte<EGameplayModOp> ModifierOp, float Magnitude, FActiveGameplayEffectHandle Handle, bool IsValid)
		{
			this.Attribute = Attribute;
			this.ModifierOp = ModifierOp;
			this.Magnitude = Magnitude;
			this.Handle = Handle;
			this.IsValid = IsValid;
		}

		// Token: 0x060126B9 RID: 75449 RVA: 0x001B1426 File Offset: 0x001AF626
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayModifierEvaluatedData.StaticStruct();
		}

		// Token: 0x060126BA RID: 75450 RVA: 0x001B1432 File Offset: 0x001AF632
		[NullableContext(2)]
		public FGameplayModifierEvaluatedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060126BB RID: 75451 RVA: 0x001B143C File Offset: 0x001AF63C
		public FGameplayModifierEvaluatedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126BC RID: 75452 RVA: 0x001B1447 File Offset: 0x001AF647
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayModifierEvaluatedData(Pointer, false, true);
		}

		// Token: 0x060126BD RID: 75453 RVA: 0x001B1451 File Offset: 0x001AF651
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayModifierEvaluatedData(Pointer, MemoryOwner);
		}

		// Token: 0x04009DCD RID: 40397
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayModifierEvaluatedData";

		// Token: 0x04009DCE RID: 40398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DCF RID: 40399
		internal static int __PropertyOffset_Attribute;

		// Token: 0x04009DD0 RID: 40400
		[Nullable(2)]
		private FGameplayAttribute _Attribute;

		// Token: 0x04009DD1 RID: 40401
		internal static int __PropertyOffset_ModifierOp;

		// Token: 0x04009DD2 RID: 40402
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009DD3 RID: 40403
		internal static int __PropertyOffset_Handle;

		// Token: 0x04009DD4 RID: 40404
		[Nullable(2)]
		private FActiveGameplayEffectHandle _Handle;

		// Token: 0x04009DD5 RID: 40405
		internal static int __PropertyOffset_IsValid;
	}
}
