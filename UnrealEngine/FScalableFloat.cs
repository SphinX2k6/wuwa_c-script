using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B2 RID: 5042
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ScalableFloat")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FScalableFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127EE RID: 75758 RVA: 0x001B30B2 File Offset: 0x001B12B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScalableFloat._ScriptStructPtr != 0) ? FScalableFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ScalableFloat", ref FScalableFloat._ScriptStructPtr);
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x060127EF RID: 75759 RVA: 0x001B30D6 File Offset: 0x001B12D6
		// (set) Token: 0x060127F0 RID: 75760 RVA: 0x001B30E6 File Offset: 0x001B12E6
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScalableFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScalableFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x060127F1 RID: 75761 RVA: 0x001B30F8 File Offset: 0x001B12F8
		// (set) Token: 0x060127F2 RID: 75762 RVA: 0x001B313B File Offset: 0x001B133B
		public FCurveTableRowHandle Curve
		{
			get
			{
				base.FastCheckIsValid();
				FCurveTableRowHandle result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FCurveTableRowHandle(base.NativePtr + (IntPtr)FScalableFloat.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCurveTableRowHandle.StaticStruct(), base.NativePtr + (IntPtr)FScalableFloat.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060127F3 RID: 75763 RVA: 0x001B315C File Offset: 0x001B135C
		public FScalableFloat()
		{
		}

		// Token: 0x060127F4 RID: 75764 RVA: 0x001B3164 File Offset: 0x001B1364
		public FScalableFloat(float Value, FCurveTableRowHandle Curve)
		{
			this.Value = Value;
			this.Curve = Curve;
		}

		// Token: 0x060127F5 RID: 75765 RVA: 0x001B317A File Offset: 0x001B137A
		protected override IntPtr GetUStructPtr()
		{
			return FScalableFloat.StaticStruct();
		}

		// Token: 0x060127F6 RID: 75766 RVA: 0x001B3186 File Offset: 0x001B1386
		[NullableContext(2)]
		public FScalableFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127F7 RID: 75767 RVA: 0x001B3190 File Offset: 0x001B1390
		public FScalableFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127F8 RID: 75768 RVA: 0x001B319B File Offset: 0x001B139B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScalableFloat(Pointer, false, true);
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x001B31A5 File Offset: 0x001B13A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScalableFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04009E53 RID: 40531
		public const string __ObjectPath = "/Script/GameplayAbilities.ScalableFloat";

		// Token: 0x04009E54 RID: 40532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E55 RID: 40533
		internal static int __PropertyOffset_Value;

		// Token: 0x04009E56 RID: 40534
		internal static int __PropertyOffset_Curve;

		// Token: 0x04009E57 RID: 40535
		[Nullable(2)]
		private FCurveTableRowHandle _Curve;
	}
}
