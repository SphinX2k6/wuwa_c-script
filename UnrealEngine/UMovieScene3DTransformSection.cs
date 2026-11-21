using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075E RID: 1886
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformSection")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class UMovieScene3DTransformSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A452 RID: 42066 RVA: 0x000F2AA5 File Offset: 0x000F0CA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DTransformSection._ClassPtr;
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x000F2AB4 File Offset: 0x000F0CB4
		public UMovieScene3DTransformSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x000F2ADC File Offset: 0x000F0CDC
		public UMovieScene3DTransformSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x000F2B10 File Offset: 0x000F0D10
		// (set) Token: 0x0600A456 RID: 42070 RVA: 0x000F2B4A File Offset: 0x000F0D4A
		public TFixedArray<FMovieSceneFloatChannel> Translation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Translation) == null)
				{
					result = (this._Translation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Translation, 3, this));
				}
				return result;
			}
			set
			{
				this.Translation.CopyAssign(value);
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x0600A457 RID: 42071 RVA: 0x000F2B58 File Offset: 0x000F0D58
		// (set) Token: 0x0600A458 RID: 42072 RVA: 0x000F2B92 File Offset: 0x000F0D92
		public TFixedArray<FMovieSceneFloatChannel> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Rotation, 3, this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x000F2BA0 File Offset: 0x000F0DA0
		// (set) Token: 0x0600A45A RID: 42074 RVA: 0x000F2BDA File Offset: 0x000F0DDA
		public TFixedArray<FMovieSceneFloatChannel> Scale
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_Scale, 3, this));
				}
				return result;
			}
			set
			{
				this.Scale.CopyAssign(value);
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x000F2BE8 File Offset: 0x000F0DE8
		// (set) Token: 0x0600A45C RID: 42076 RVA: 0x000F2C21 File Offset: 0x000F0E21
		public FMovieSceneFloatChannel ManualWeight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ManualWeight) == null)
				{
					result = (this._ManualWeight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_ManualWeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_ManualWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x000F2C42 File Offset: 0x000F0E42
		// (set) Token: 0x0600A45E RID: 42078 RVA: 0x000F2C52 File Offset: 0x000F0E52
		public unsafe bool bUseQuaternionInterpolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_bUseQuaternionInterpolation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DTransformSection.__PropertyOffset_bUseQuaternionInterpolation) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x000F2C63 File Offset: 0x000F0E63
		static UMovieScene3DTransformSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DTransformSection");
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x000F2C71 File Offset: 0x000F0E71
		protected UMovieScene3DTransformSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400460B RID: 17931
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformSection";

		// Token: 0x0400460C RID: 17932
		private static IntPtr _ClassPtr;

		// Token: 0x0400460D RID: 17933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400460E RID: 17934
		internal static int __PropertyOffset_Translation;

		// Token: 0x0400460F RID: 17935
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Translation;

		// Token: 0x04004610 RID: 17936
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04004611 RID: 17937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Rotation;

		// Token: 0x04004612 RID: 17938
		internal static int __PropertyOffset_Scale;

		// Token: 0x04004613 RID: 17939
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Scale;

		// Token: 0x04004614 RID: 17940
		internal static int __PropertyOffset_ManualWeight;

		// Token: 0x04004615 RID: 17941
		[Nullable(2)]
		private FMovieSceneFloatChannel _ManualWeight;

		// Token: 0x04004616 RID: 17942
		internal static int __PropertyOffset_bUseQuaternionInterpolation;
	}
}
