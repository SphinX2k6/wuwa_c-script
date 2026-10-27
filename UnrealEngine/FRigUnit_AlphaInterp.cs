using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000547 RID: 1351
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AlphaInterp")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FRigUnit_AlphaInterp : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004736 RID: 18230 RVA: 0x00069C69 File Offset: 0x00067E69
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AlphaInterp._ScriptStructPtr != 0) ? FRigUnit_AlphaInterp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AlphaInterp", ref FRigUnit_AlphaInterp._ScriptStructPtr);
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06004737 RID: 18231 RVA: 0x00069C8D File Offset: 0x00067E8D
		// (set) Token: 0x06004738 RID: 18232 RVA: 0x00069C9D File Offset: 0x00067E9D
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x00069CAE File Offset: 0x00067EAE
		// (set) Token: 0x0600473A RID: 18234 RVA: 0x00069CBE File Offset: 0x00067EBE
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x00069CCF File Offset: 0x00067ECF
		// (set) Token: 0x0600473C RID: 18236 RVA: 0x00069CDF File Offset: 0x00067EDF
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x00069CF0 File Offset: 0x00067EF0
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x00069D00 File Offset: 0x00067F00
		public unsafe bool bMapRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bMapRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bMapRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x00069D14 File Offset: 0x00067F14
		// (set) Token: 0x06004740 RID: 18240 RVA: 0x00069D57 File Offset: 0x00067F57
		public FInputRange InRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._InRange) == null)
				{
					result = (this._InRange = new FInputRange(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x00069D78 File Offset: 0x00067F78
		// (set) Token: 0x06004742 RID: 18242 RVA: 0x00069DBB File Offset: 0x00067FBB
		public FInputRange OutRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._OutRange) == null)
				{
					result = (this._OutRange = new FInputRange(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_OutRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_OutRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x00069DDC File Offset: 0x00067FDC
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x00069DEC File Offset: 0x00067FEC
		public unsafe bool bClampResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bClampResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bClampResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x00069DFD File Offset: 0x00067FFD
		// (set) Token: 0x06004746 RID: 18246 RVA: 0x00069E0D File Offset: 0x0006800D
		public unsafe float ClampMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ClampMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ClampMin) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x00069E1E File Offset: 0x0006801E
		// (set) Token: 0x06004748 RID: 18248 RVA: 0x00069E2E File Offset: 0x0006802E
		public unsafe float ClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ClampMax) = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x00069E3F File Offset: 0x0006803F
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x00069E4F File Offset: 0x0006804F
		public unsafe bool bInterpResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bInterpResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_bInterpResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x00069E60 File Offset: 0x00068060
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x00069E70 File Offset: 0x00068070
		public unsafe float InterpSpeedIncreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InterpSpeedIncreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InterpSpeedIncreasing) = value;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00069E81 File Offset: 0x00068081
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x00069E91 File Offset: 0x00068091
		public unsafe float InterpSpeedDecreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InterpSpeedDecreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_InterpSpeedDecreasing) = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x00069EA2 File Offset: 0x000680A2
		// (set) Token: 0x06004750 RID: 18256 RVA: 0x00069EB2 File Offset: 0x000680B2
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x00069EC4 File Offset: 0x000680C4
		// (set) Token: 0x06004752 RID: 18258 RVA: 0x00069F07 File Offset: 0x00068107
		public FInputScaleBiasClamp ScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._ScaleBiasClamp) == null)
				{
					result = (this._ScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterp.__PropertyOffset_ScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00069F28 File Offset: 0x00068128
		public FRigUnit_AlphaInterp()
		{
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00069F30 File Offset: 0x00068130
		public FRigUnit_AlphaInterp(float Value, float Scale, float Bias, bool bMapRange, FInputRange InRange, FInputRange OutRange, bool bClampResult, float ClampMin, float ClampMax, bool bInterpResult, float InterpSpeedIncreasing, float InterpSpeedDecreasing, float Result, FInputScaleBiasClamp ScaleBiasClamp)
		{
			this.Value = Value;
			this.Scale = Scale;
			this.Bias = Bias;
			this.bMapRange = bMapRange;
			this.InRange = InRange;
			this.OutRange = OutRange;
			this.bClampResult = bClampResult;
			this.ClampMin = ClampMin;
			this.ClampMax = ClampMax;
			this.bInterpResult = bInterpResult;
			this.InterpSpeedIncreasing = InterpSpeedIncreasing;
			this.InterpSpeedDecreasing = InterpSpeedDecreasing;
			this.Result = Result;
			this.ScaleBiasClamp = ScaleBiasClamp;
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x00069FB0 File Offset: 0x000681B0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AlphaInterp.StaticStruct();
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x00069FBC File Offset: 0x000681BC
		[NullableContext(2)]
		public FRigUnit_AlphaInterp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00069FC6 File Offset: 0x000681C6
		public FRigUnit_AlphaInterp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x00069FD1 File Offset: 0x000681D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AlphaInterp(Pointer, false, true);
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00069FDB File Offset: 0x000681DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AlphaInterp(Pointer, MemoryOwner);
		}

		// Token: 0x0400229A RID: 8858
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AlphaInterp";

		// Token: 0x0400229B RID: 8859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400229C RID: 8860
		internal static int __PropertyOffset_Value;

		// Token: 0x0400229D RID: 8861
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400229E RID: 8862
		internal static int __PropertyOffset_Bias;

		// Token: 0x0400229F RID: 8863
		internal static int __PropertyOffset_bMapRange;

		// Token: 0x040022A0 RID: 8864
		internal static int __PropertyOffset_InRange;

		// Token: 0x040022A1 RID: 8865
		[Nullable(2)]
		private FInputRange _InRange;

		// Token: 0x040022A2 RID: 8866
		internal static int __PropertyOffset_OutRange;

		// Token: 0x040022A3 RID: 8867
		[Nullable(2)]
		private FInputRange _OutRange;

		// Token: 0x040022A4 RID: 8868
		internal static int __PropertyOffset_bClampResult;

		// Token: 0x040022A5 RID: 8869
		internal static int __PropertyOffset_ClampMin;

		// Token: 0x040022A6 RID: 8870
		internal static int __PropertyOffset_ClampMax;

		// Token: 0x040022A7 RID: 8871
		internal static int __PropertyOffset_bInterpResult;

		// Token: 0x040022A8 RID: 8872
		internal static int __PropertyOffset_InterpSpeedIncreasing;

		// Token: 0x040022A9 RID: 8873
		internal static int __PropertyOffset_InterpSpeedDecreasing;

		// Token: 0x040022AA RID: 8874
		internal static int __PropertyOffset_Result;

		// Token: 0x040022AB RID: 8875
		internal static int __PropertyOffset_ScaleBiasClamp;

		// Token: 0x040022AC RID: 8876
		[Nullable(2)]
		private FInputScaleBiasClamp _ScaleBiasClamp;
	}
}
