using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011F3 RID: 4595
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimeStretchCurve")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTimeStretchCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F0B RID: 69387 RVA: 0x0018DE72 File Offset: 0x0018C072
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimeStretchCurve._ScriptStructPtr != 0) ? FTimeStretchCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimeStretchCurve", ref FTimeStretchCurve._ScriptStructPtr);
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x06010F0C RID: 69388 RVA: 0x0018DE96 File Offset: 0x0018C096
		// (set) Token: 0x06010F0D RID: 69389 RVA: 0x0018DEA6 File Offset: 0x0018C0A6
		public unsafe float SamplingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_SamplingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_SamplingRate) = value;
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x06010F0E RID: 69390 RVA: 0x0018DEB7 File Offset: 0x0018C0B7
		// (set) Token: 0x06010F0F RID: 69391 RVA: 0x0018DEC7 File Offset: 0x0018C0C7
		public unsafe float CurveValueMinPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_CurveValueMinPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_CurveValueMinPrecision) = value;
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x06010F10 RID: 69392 RVA: 0x0018DED8 File Offset: 0x0018C0D8
		// (set) Token: 0x06010F11 RID: 69393 RVA: 0x0018DF1B File Offset: 0x0018C11B
		public TArray<FTimeStretchCurveMarker> Markers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTimeStretchCurveMarker> result;
				if ((result = this._Markers) == null)
				{
					result = (this._Markers = new TArray<FTimeStretchCurveMarker>(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_Markers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Markers.CopyAssign(value);
			}
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x06010F12 RID: 69394 RVA: 0x0018DF2C File Offset: 0x0018C12C
		// (set) Token: 0x06010F13 RID: 69395 RVA: 0x0018DF70 File Offset: 0x0018C170
		public TFixedArray<float> Sum_dT_i_by_C_i
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._Sum_dT_i_by_C_i) == null)
				{
					result = (this._Sum_dT_i_by_C_i = new TFixedArray<float>(base.NativePtr + (IntPtr)FTimeStretchCurve.__PropertyOffset_Sum_dT_i_by_C_i, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Sum_dT_i_by_C_i.CopyAssign(value);
			}
		}

		// Token: 0x06010F14 RID: 69396 RVA: 0x0018DF7E File Offset: 0x0018C17E
		public FTimeStretchCurve()
		{
		}

		// Token: 0x06010F15 RID: 69397 RVA: 0x0018DF86 File Offset: 0x0018C186
		public FTimeStretchCurve(float SamplingRate, float CurveValueMinPrecision, TArray<FTimeStretchCurveMarker> Markers, TFixedArray<float> Sum_dT_i_by_C_i)
		{
			this.SamplingRate = SamplingRate;
			this.CurveValueMinPrecision = CurveValueMinPrecision;
			this.Markers = Markers;
			this.Sum_dT_i_by_C_i = Sum_dT_i_by_C_i;
		}

		// Token: 0x06010F16 RID: 69398 RVA: 0x0018DFAB File Offset: 0x0018C1AB
		protected override IntPtr GetUStructPtr()
		{
			return FTimeStretchCurve.StaticStruct();
		}

		// Token: 0x06010F17 RID: 69399 RVA: 0x0018DFB7 File Offset: 0x0018C1B7
		[NullableContext(2)]
		public FTimeStretchCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F18 RID: 69400 RVA: 0x0018DFC1 File Offset: 0x0018C1C1
		public FTimeStretchCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F19 RID: 69401 RVA: 0x0018DFCC File Offset: 0x0018C1CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimeStretchCurve(Pointer, false, true);
		}

		// Token: 0x06010F1A RID: 69402 RVA: 0x0018DFD6 File Offset: 0x0018C1D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimeStretchCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400912F RID: 37167
		public const string __ObjectPath = "/Script/Engine.TimeStretchCurve";

		// Token: 0x04009130 RID: 37168
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009131 RID: 37169
		internal static int __PropertyOffset_SamplingRate;

		// Token: 0x04009132 RID: 37170
		internal static int __PropertyOffset_CurveValueMinPrecision;

		// Token: 0x04009133 RID: 37171
		internal static int __PropertyOffset_Markers;

		// Token: 0x04009134 RID: 37172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTimeStretchCurveMarker> _Markers;

		// Token: 0x04009135 RID: 37173
		internal static int __PropertyOffset_Sum_dT_i_by_C_i;

		// Token: 0x04009136 RID: 37174
		[Nullable(2)]
		private TFixedArray<float> _Sum_dT_i_by_C_i;
	}
}
