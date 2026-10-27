using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002988 RID: 10632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MovieSceneMarginSection")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class UMovieSceneMarginSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027599 RID: 161177 RVA: 0x003BFC96 File Offset: 0x003BDE96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMarginSection._ClassPtr;
		}

		// Token: 0x0602759A RID: 161178 RVA: 0x003BFCA4 File Offset: 0x003BDEA4
		public UMovieSceneMarginSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMarginSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602759B RID: 161179 RVA: 0x003BFCCC File Offset: 0x003BDECC
		public UMovieSceneMarginSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMarginSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009739 RID: 38713
		// (get) Token: 0x0602759C RID: 161180 RVA: 0x003BFD00 File Offset: 0x003BDF00
		// (set) Token: 0x0602759D RID: 161181 RVA: 0x003BFD39 File Offset: 0x003BDF39
		public FMovieSceneFloatChannel TopCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._TopCurve) == null)
				{
					result = (this._TopCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_TopCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_TopCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700973A RID: 38714
		// (get) Token: 0x0602759E RID: 161182 RVA: 0x003BFD5C File Offset: 0x003BDF5C
		// (set) Token: 0x0602759F RID: 161183 RVA: 0x003BFD95 File Offset: 0x003BDF95
		public FMovieSceneFloatChannel LeftCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._LeftCurve) == null)
				{
					result = (this._LeftCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_LeftCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_LeftCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700973B RID: 38715
		// (get) Token: 0x060275A0 RID: 161184 RVA: 0x003BFDB8 File Offset: 0x003BDFB8
		// (set) Token: 0x060275A1 RID: 161185 RVA: 0x003BFDF1 File Offset: 0x003BDFF1
		public FMovieSceneFloatChannel RightCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RightCurve) == null)
				{
					result = (this._RightCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_RightCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_RightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700973C RID: 38716
		// (get) Token: 0x060275A2 RID: 161186 RVA: 0x003BFE14 File Offset: 0x003BE014
		// (set) Token: 0x060275A3 RID: 161187 RVA: 0x003BFE4D File Offset: 0x003BE04D
		public FMovieSceneFloatChannel BottomCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._BottomCurve) == null)
				{
					result = (this._BottomCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_BottomCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneMarginSection.__PropertyOffset_BottomCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060275A4 RID: 161188 RVA: 0x003BFE6E File Offset: 0x003BE06E
		static UMovieSceneMarginSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieSceneMarginSection");
		}

		// Token: 0x060275A5 RID: 161189 RVA: 0x003BFE7C File Offset: 0x003BE07C
		protected UMovieSceneMarginSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159B4 RID: 88500
		public new const string __ObjectPath = "/Script/UMG.MovieSceneMarginSection";

		// Token: 0x040159B5 RID: 88501
		private static IntPtr _ClassPtr;

		// Token: 0x040159B6 RID: 88502
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159B7 RID: 88503
		internal static int __PropertyOffset_TopCurve;

		// Token: 0x040159B8 RID: 88504
		[Nullable(2)]
		private FMovieSceneFloatChannel _TopCurve;

		// Token: 0x040159B9 RID: 88505
		internal static int __PropertyOffset_LeftCurve;

		// Token: 0x040159BA RID: 88506
		[Nullable(2)]
		private FMovieSceneFloatChannel _LeftCurve;

		// Token: 0x040159BB RID: 88507
		internal static int __PropertyOffset_RightCurve;

		// Token: 0x040159BC RID: 88508
		[Nullable(2)]
		private FMovieSceneFloatChannel _RightCurve;

		// Token: 0x040159BD RID: 88509
		internal static int __PropertyOffset_BottomCurve;

		// Token: 0x040159BE RID: 88510
		[Nullable(2)]
		private FMovieSceneFloatChannel _BottomCurve;
	}
}
