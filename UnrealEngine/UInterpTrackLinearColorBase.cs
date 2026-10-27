using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAE RID: 3246
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackLinearColorBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UInterpTrackLinearColorBase : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A42A RID: 42026 RVA: 0x000E9650 File Offset: 0x000E7850
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackLinearColorBase._ClassPtr;
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600A42B RID: 42027 RVA: 0x000E965C File Offset: 0x000E785C
		// (set) Token: 0x0600A42C RID: 42028 RVA: 0x000E9695 File Offset: 0x000E7895
		public FInterpCurveLinearColor LinearColorTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveLinearColor result;
				if ((result = this._LinearColorTrack) == null)
				{
					result = (this._LinearColorTrack = new FInterpCurveLinearColor(base.NativePtr + (IntPtr)UInterpTrackLinearColorBase.__PropertyOffset_LinearColorTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackLinearColorBase.__PropertyOffset_LinearColorTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x000E96B6 File Offset: 0x000E78B6
		// (set) Token: 0x0600A42E RID: 42030 RVA: 0x000E96C6 File Offset: 0x000E78C6
		public unsafe float CurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackLinearColorBase.__PropertyOffset_CurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackLinearColorBase.__PropertyOffset_CurveTension) = value;
			}
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x000E96D7 File Offset: 0x000E78D7
		static UInterpTrackLinearColorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackLinearColorBase");
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x000E96E8 File Offset: 0x000E78E8
		protected UInterpTrackLinearColorBase() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackLinearColorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x000E9710 File Offset: 0x000E7910
		protected UInterpTrackLinearColorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A40 RID: 23104
		public new const string __ObjectPath = "/Script/Engine.InterpTrackLinearColorBase";

		// Token: 0x04005A41 RID: 23105
		private static IntPtr _ClassPtr;

		// Token: 0x04005A42 RID: 23106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A43 RID: 23107
		internal static int __PropertyOffset_LinearColorTrack;

		// Token: 0x04005A44 RID: 23108
		[Nullable(2)]
		private FInterpCurveLinearColor _LinearColorTrack;

		// Token: 0x04005A45 RID: 23109
		internal static int __PropertyOffset_CurveTension;
	}
}
