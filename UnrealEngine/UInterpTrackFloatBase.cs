using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C93 RID: 3219
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackFloatBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UInterpTrackFloatBase : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A358 RID: 41816 RVA: 0x000E823D File Offset: 0x000E643D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFloatBase._ClassPtr;
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0600A359 RID: 41817 RVA: 0x000E824C File Offset: 0x000E644C
		// (set) Token: 0x0600A35A RID: 41818 RVA: 0x000E8285 File Offset: 0x000E6485
		public FInterpCurveFloat FloatTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveFloat result;
				if ((result = this._FloatTrack) == null)
				{
					result = (this._FloatTrack = new FInterpCurveFloat(base.NativePtr + (IntPtr)UInterpTrackFloatBase.__PropertyOffset_FloatTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackFloatBase.__PropertyOffset_FloatTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x0600A35B RID: 41819 RVA: 0x000E82A6 File Offset: 0x000E64A6
		// (set) Token: 0x0600A35C RID: 41820 RVA: 0x000E82B6 File Offset: 0x000E64B6
		public unsafe float CurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatBase.__PropertyOffset_CurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatBase.__PropertyOffset_CurveTension) = value;
			}
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x000E82C7 File Offset: 0x000E64C7
		static UInterpTrackFloatBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFloatBase");
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x000E82D8 File Offset: 0x000E64D8
		protected UInterpTrackFloatBase() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x000E8300 File Offset: 0x000E6500
		protected UInterpTrackFloatBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059C0 RID: 22976
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFloatBase";

		// Token: 0x040059C1 RID: 22977
		private static IntPtr _ClassPtr;

		// Token: 0x040059C2 RID: 22978
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059C3 RID: 22979
		internal static int __PropertyOffset_FloatTrack;

		// Token: 0x040059C4 RID: 22980
		[Nullable(2)]
		private FInterpCurveFloat _FloatTrack;

		// Token: 0x040059C5 RID: 22981
		internal static int __PropertyOffset_CurveTension;
	}
}
