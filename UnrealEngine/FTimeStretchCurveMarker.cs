using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011F5 RID: 4597
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimeStretchCurveMarker")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FTimeStretchCurveMarker : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F25 RID: 69413 RVA: 0x0018E06F File Offset: 0x0018C26F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimeStretchCurveMarker._ScriptStructPtr != 0) ? FTimeStretchCurveMarker._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimeStretchCurveMarker", ref FTimeStretchCurveMarker._ScriptStructPtr);
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x06010F26 RID: 69414 RVA: 0x0018E094 File Offset: 0x0018C294
		// (set) Token: 0x06010F27 RID: 69415 RVA: 0x0018E0D8 File Offset: 0x0018C2D8
		public TFixedArray<float> Time
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new TFixedArray<float>(base.NativePtr + (IntPtr)FTimeStretchCurveMarker.__PropertyOffset_Time, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Time.CopyAssign(value);
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x06010F28 RID: 69416 RVA: 0x0018E0E6 File Offset: 0x0018C2E6
		// (set) Token: 0x06010F29 RID: 69417 RVA: 0x0018E0F6 File Offset: 0x0018C2F6
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimeStretchCurveMarker.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimeStretchCurveMarker.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x06010F2A RID: 69418 RVA: 0x0018E107 File Offset: 0x0018C307
		public FTimeStretchCurveMarker()
		{
		}

		// Token: 0x06010F2B RID: 69419 RVA: 0x0018E10F File Offset: 0x0018C30F
		public FTimeStretchCurveMarker(TFixedArray<float> Time, float Alpha)
		{
			this.Time = Time;
			this.Alpha = Alpha;
		}

		// Token: 0x06010F2C RID: 69420 RVA: 0x0018E125 File Offset: 0x0018C325
		protected override IntPtr GetUStructPtr()
		{
			return FTimeStretchCurveMarker.StaticStruct();
		}

		// Token: 0x06010F2D RID: 69421 RVA: 0x0018E131 File Offset: 0x0018C331
		[NullableContext(2)]
		public FTimeStretchCurveMarker(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F2E RID: 69422 RVA: 0x0018E13B File Offset: 0x0018C33B
		public FTimeStretchCurveMarker(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F2F RID: 69423 RVA: 0x0018E146 File Offset: 0x0018C346
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimeStretchCurveMarker(Pointer, false, true);
		}

		// Token: 0x06010F30 RID: 69424 RVA: 0x0018E150 File Offset: 0x0018C350
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimeStretchCurveMarker(Pointer, MemoryOwner);
		}

		// Token: 0x0400913A RID: 37178
		public const string __ObjectPath = "/Script/Engine.TimeStretchCurveMarker";

		// Token: 0x0400913B RID: 37179
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400913C RID: 37180
		internal static int __PropertyOffset_Time;

		// Token: 0x0400913D RID: 37181
		[Nullable(2)]
		private TFixedArray<float> _Time;

		// Token: 0x0400913E RID: 37182
		internal static int __PropertyOffset_Alpha;
	}
}
