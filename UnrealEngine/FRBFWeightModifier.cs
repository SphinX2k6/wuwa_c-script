using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001072 RID: 4210
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFWeightModifier")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRBFWeightModifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF89 RID: 61321 RVA: 0x001633AE File Offset: 0x001615AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFWeightModifier._ScriptStructPtr != 0) ? FRBFWeightModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFWeightModifier", ref FRBFWeightModifier._ScriptStructPtr);
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x001633D2 File Offset: 0x001615D2
		// (set) Token: 0x0600EF8B RID: 61323 RVA: 0x001633E6 File Offset: 0x001615E6
		public unsafe FName SrcWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_SrcWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_SrcWeight) = value;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600EF8C RID: 61324 RVA: 0x001633FB File Offset: 0x001615FB
		// (set) Token: 0x0600EF8D RID: 61325 RVA: 0x0016340B File Offset: 0x0016160B
		public unsafe int DstDriverIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_DstDriverIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_DstDriverIndex) = value;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600EF8E RID: 61326 RVA: 0x0016341C File Offset: 0x0016161C
		// (set) Token: 0x0600EF8F RID: 61327 RVA: 0x00163430 File Offset: 0x00161630
		public unsafe FName DstWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_DstWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_DstWeight) = value;
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600EF90 RID: 61328 RVA: 0x00163448 File Offset: 0x00161648
		// (set) Token: 0x0600EF91 RID: 61329 RVA: 0x0016348B File Offset: 0x0016168B
		public FRuntimeFloatCurve FactorCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._FactorCurve) == null)
				{
					result = (this._FactorCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_FactorCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRBFWeightModifier.__PropertyOffset_FactorCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x001634AC File Offset: 0x001616AC
		public FRBFWeightModifier()
		{
		}

		// Token: 0x0600EF93 RID: 61331 RVA: 0x001634B4 File Offset: 0x001616B4
		public FRBFWeightModifier(FName SrcWeight, int DstDriverIndex, FName DstWeight, FRuntimeFloatCurve FactorCurve)
		{
			this.SrcWeight = SrcWeight;
			this.DstDriverIndex = DstDriverIndex;
			this.DstWeight = DstWeight;
			this.FactorCurve = FactorCurve;
		}

		// Token: 0x0600EF94 RID: 61332 RVA: 0x001634D9 File Offset: 0x001616D9
		protected override IntPtr GetUStructPtr()
		{
			return FRBFWeightModifier.StaticStruct();
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x001634E5 File Offset: 0x001616E5
		[NullableContext(2)]
		public FRBFWeightModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x001634EF File Offset: 0x001616EF
		public FRBFWeightModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x001634FA File Offset: 0x001616FA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFWeightModifier(Pointer, false, true);
		}

		// Token: 0x0600EF98 RID: 61336 RVA: 0x00163504 File Offset: 0x00161704
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFWeightModifier(Pointer, MemoryOwner);
		}

		// Token: 0x0400819C RID: 33180
		public const string __ObjectPath = "/Script/Engine.RBFWeightModifier";

		// Token: 0x0400819D RID: 33181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400819E RID: 33182
		internal static int __PropertyOffset_SrcWeight;

		// Token: 0x0400819F RID: 33183
		internal static int __PropertyOffset_DstDriverIndex;

		// Token: 0x040081A0 RID: 33184
		internal static int __PropertyOffset_DstWeight;

		// Token: 0x040081A1 RID: 33185
		internal static int __PropertyOffset_FactorCurve;

		// Token: 0x040081A2 RID: 33186
		[Nullable(2)]
		private FRuntimeFloatCurve _FactorCurve;
	}
}
