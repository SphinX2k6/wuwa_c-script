using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022AE RID: 8878
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneMediaTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021BFF RID: 138239 RVA: 0x0031E6B9 File Offset: 0x0031C8B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMediaTrack._ClassPtr;
		}

		// Token: 0x06021C00 RID: 138240 RVA: 0x0031E6C5 File Offset: 0x0031C8C5
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneMediaTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06021C01 RID: 138241 RVA: 0x0031E6CC File Offset: 0x0031C8CC
		public UMovieSceneMediaTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C02 RID: 138242 RVA: 0x0031E6F4 File Offset: 0x0031C8F4
		[NullableContext(1)]
		public UMovieSceneMediaTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082EC RID: 33516
		// (get) Token: 0x06021C03 RID: 138243 RVA: 0x0031E728 File Offset: 0x0031C928
		// (set) Token: 0x06021C04 RID: 138244 RVA: 0x0031E761 File Offset: 0x0031C961
		[Nullable(1)]
		public TArray<UMovieSceneSection> MediaSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._MediaSections) == null)
				{
					result = (this._MediaSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneMediaTrack.__PropertyOffset_MediaSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MediaSections.CopyAssign(value);
			}
		}

		// Token: 0x06021C05 RID: 138245 RVA: 0x0031E76F File Offset: 0x0031C96F
		static UMovieSceneMediaTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaCompositing.MovieSceneMediaTrack");
		}

		// Token: 0x06021C06 RID: 138246 RVA: 0x0031E77D File Offset: 0x0031C97D
		protected UMovieSceneMediaTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401201A RID: 73754
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0401201B RID: 73755
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaTrack";

		// Token: 0x0401201C RID: 73756
		private static IntPtr _ClassPtr;

		// Token: 0x0401201D RID: 73757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401201E RID: 73758
		internal static int __PropertyOffset_MediaSections;

		// Token: 0x0401201F RID: 73759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _MediaSections;
	}
}
