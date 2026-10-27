using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB6 RID: 3254
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackVectorBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UInterpTrackVectorBase : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A48F RID: 42127 RVA: 0x000EA253 File Offset: 0x000E8453
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackVectorBase._ClassPtr;
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x0600A490 RID: 42128 RVA: 0x000EA260 File Offset: 0x000E8460
		// (set) Token: 0x0600A491 RID: 42129 RVA: 0x000EA299 File Offset: 0x000E8499
		public FInterpCurveVector VectorTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._VectorTrack) == null)
				{
					result = (this._VectorTrack = new FInterpCurveVector(base.NativePtr + (IntPtr)UInterpTrackVectorBase.__PropertyOffset_VectorTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackVectorBase.__PropertyOffset_VectorTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x000EA2BA File Offset: 0x000E84BA
		// (set) Token: 0x0600A493 RID: 42131 RVA: 0x000EA2CA File Offset: 0x000E84CA
		public unsafe float CurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackVectorBase.__PropertyOffset_CurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackVectorBase.__PropertyOffset_CurveTension) = value;
			}
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x000EA2DB File Offset: 0x000E84DB
		static UInterpTrackVectorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackVectorBase");
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x000EA2EC File Offset: 0x000E84EC
		protected UInterpTrackVectorBase() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVectorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x000EA314 File Offset: 0x000E8514
		protected UInterpTrackVectorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A8F RID: 23183
		public new const string __ObjectPath = "/Script/Engine.InterpTrackVectorBase";

		// Token: 0x04005A90 RID: 23184
		private static IntPtr _ClassPtr;

		// Token: 0x04005A91 RID: 23185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A92 RID: 23186
		internal static int __PropertyOffset_VectorTrack;

		// Token: 0x04005A93 RID: 23187
		[Nullable(2)]
		private FInterpCurveVector _VectorTrack;

		// Token: 0x04005A94 RID: 23188
		internal static int __PropertyOffset_CurveTension;
	}
}
