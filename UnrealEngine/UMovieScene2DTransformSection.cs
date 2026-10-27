using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002986 RID: 10630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MovieScene2DTransformSection")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class UMovieScene2DTransformSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06027584 RID: 161156 RVA: 0x003BF9FE File Offset: 0x003BDBFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene2DTransformSection._ClassPtr;
		}

		// Token: 0x06027585 RID: 161157 RVA: 0x003BFA0A File Offset: 0x003BDC0A
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieScene2DTransformSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06027586 RID: 161158 RVA: 0x003BFA14 File Offset: 0x003BDC14
		public UMovieScene2DTransformSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027587 RID: 161159 RVA: 0x003BFA3C File Offset: 0x003BDC3C
		public UMovieScene2DTransformSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009734 RID: 38708
		// (get) Token: 0x06027588 RID: 161160 RVA: 0x003BFA70 File Offset: 0x003BDC70
		// (set) Token: 0x06027589 RID: 161161 RVA: 0x003BFAA9 File Offset: 0x003BDCA9
		public FMovieScene2DTransformMask TransformMask
		{
			get
			{
				base.FastCheckIsValid();
				FMovieScene2DTransformMask result;
				if ((result = this._TransformMask) == null)
				{
					result = (this._TransformMask = new FMovieScene2DTransformMask(base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_TransformMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieScene2DTransformMask.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_TransformMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009735 RID: 38709
		// (get) Token: 0x0602758A RID: 161162 RVA: 0x003BFACC File Offset: 0x003BDCCC
		// (set) Token: 0x0602758B RID: 161163 RVA: 0x003BFB06 File Offset: 0x003BDD06
		public TFixedArray<FMovieSceneFloatChannel> Translation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Translation) == null)
				{
					result = (this._Translation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_Translation, 2, this));
				}
				return result;
			}
			set
			{
				this.Translation.CopyAssign(value);
			}
		}

		// Token: 0x17009736 RID: 38710
		// (get) Token: 0x0602758C RID: 161164 RVA: 0x003BFB14 File Offset: 0x003BDD14
		// (set) Token: 0x0602758D RID: 161165 RVA: 0x003BFB4D File Offset: 0x003BDD4D
		public FMovieSceneFloatChannel Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009737 RID: 38711
		// (get) Token: 0x0602758E RID: 161166 RVA: 0x003BFB70 File Offset: 0x003BDD70
		// (set) Token: 0x0602758F RID: 161167 RVA: 0x003BFBAA File Offset: 0x003BDDAA
		public TFixedArray<FMovieSceneFloatChannel> Scale
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_Scale, 2, this));
				}
				return result;
			}
			set
			{
				this.Scale.CopyAssign(value);
			}
		}

		// Token: 0x17009738 RID: 38712
		// (get) Token: 0x06027590 RID: 161168 RVA: 0x003BFBB8 File Offset: 0x003BDDB8
		// (set) Token: 0x06027591 RID: 161169 RVA: 0x003BFBF2 File Offset: 0x003BDDF2
		public TFixedArray<FMovieSceneFloatChannel> Shear
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Shear) == null)
				{
					result = (this._Shear = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene2DTransformSection.__PropertyOffset_Shear, 2, this));
				}
				return result;
			}
			set
			{
				this.Shear.CopyAssign(value);
			}
		}

		// Token: 0x06027592 RID: 161170 RVA: 0x003BFC00 File Offset: 0x003BDE00
		static UMovieScene2DTransformSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieScene2DTransformSection");
		}

		// Token: 0x06027593 RID: 161171 RVA: 0x003BFC0E File Offset: 0x003BDE0E
		protected UMovieScene2DTransformSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159A3 RID: 88483
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x040159A4 RID: 88484
		public new const string __ObjectPath = "/Script/UMG.MovieScene2DTransformSection";

		// Token: 0x040159A5 RID: 88485
		private static IntPtr _ClassPtr;

		// Token: 0x040159A6 RID: 88486
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040159A7 RID: 88487
		internal static int __PropertyOffset_TransformMask;

		// Token: 0x040159A8 RID: 88488
		[Nullable(2)]
		private FMovieScene2DTransformMask _TransformMask;

		// Token: 0x040159A9 RID: 88489
		internal static int __PropertyOffset_Translation;

		// Token: 0x040159AA RID: 88490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Translation;

		// Token: 0x040159AB RID: 88491
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040159AC RID: 88492
		[Nullable(2)]
		private FMovieSceneFloatChannel _Rotation;

		// Token: 0x040159AD RID: 88493
		internal static int __PropertyOffset_Scale;

		// Token: 0x040159AE RID: 88494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Scale;

		// Token: 0x040159AF RID: 88495
		internal static int __PropertyOffset_Shear;

		// Token: 0x040159B0 RID: 88496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Shear;
	}
}
