using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C14 RID: 3092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HapticFeedbackDetails_Curve")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FHapticFeedbackDetails_Curve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009C4F RID: 40015 RVA: 0x000DE40F File Offset: 0x000DC60F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHapticFeedbackDetails_Curve._ScriptStructPtr != 0) ? FHapticFeedbackDetails_Curve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HapticFeedbackDetails_Curve", ref FHapticFeedbackDetails_Curve._ScriptStructPtr);
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06009C50 RID: 40016 RVA: 0x000DE434 File Offset: 0x000DC634
		// (set) Token: 0x06009C51 RID: 40017 RVA: 0x000DE477 File Offset: 0x000DC677
		public FRuntimeFloatCurve Frequency
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Frequency) == null)
				{
					result = (this._Frequency = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FHapticFeedbackDetails_Curve.__PropertyOffset_Frequency, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FHapticFeedbackDetails_Curve.__PropertyOffset_Frequency, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x000DE498 File Offset: 0x000DC698
		// (set) Token: 0x06009C53 RID: 40019 RVA: 0x000DE4DB File Offset: 0x000DC6DB
		public FRuntimeFloatCurve Amplitude
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Amplitude) == null)
				{
					result = (this._Amplitude = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FHapticFeedbackDetails_Curve.__PropertyOffset_Amplitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FHapticFeedbackDetails_Curve.__PropertyOffset_Amplitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x000DE4FC File Offset: 0x000DC6FC
		public FHapticFeedbackDetails_Curve()
		{
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x000DE504 File Offset: 0x000DC704
		public FHapticFeedbackDetails_Curve(FRuntimeFloatCurve Frequency, FRuntimeFloatCurve Amplitude)
		{
			this.Frequency = Frequency;
			this.Amplitude = Amplitude;
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x000DE51A File Offset: 0x000DC71A
		protected override IntPtr GetUStructPtr()
		{
			return FHapticFeedbackDetails_Curve.StaticStruct();
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x000DE526 File Offset: 0x000DC726
		[NullableContext(2)]
		public FHapticFeedbackDetails_Curve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C58 RID: 40024 RVA: 0x000DE530 File Offset: 0x000DC730
		public FHapticFeedbackDetails_Curve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x000DE53B File Offset: 0x000DC73B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHapticFeedbackDetails_Curve(Pointer, false, true);
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x000DE545 File Offset: 0x000DC745
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHapticFeedbackDetails_Curve(Pointer, MemoryOwner);
		}

		// Token: 0x04005645 RID: 22085
		public const string __ObjectPath = "/Script/Engine.HapticFeedbackDetails_Curve";

		// Token: 0x04005646 RID: 22086
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005647 RID: 22087
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04005648 RID: 22088
		[Nullable(2)]
		private FRuntimeFloatCurve _Frequency;

		// Token: 0x04005649 RID: 22089
		internal static int __PropertyOffset_Amplitude;

		// Token: 0x0400564A RID: 22090
		[Nullable(2)]
		private FRuntimeFloatCurve _Amplitude;
	}
}
