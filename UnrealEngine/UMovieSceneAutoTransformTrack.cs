using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026E3 RID: 9955
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneAutoTransformTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneAutoTransformTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024EC6 RID: 151238 RVA: 0x00369C49 File Offset: 0x00367E49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAutoTransformTrack._ClassPtr;
		}

		// Token: 0x06024EC7 RID: 151239 RVA: 0x00369C55 File Offset: 0x00367E55
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneAutoTransformTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06024EC8 RID: 151240 RVA: 0x00369C5C File Offset: 0x00367E5C
		public UMovieSceneAutoTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAutoTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EC9 RID: 151241 RVA: 0x00369C84 File Offset: 0x00367E84
		[NullableContext(1)]
		public UMovieSceneAutoTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAutoTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E8E RID: 36494
		// (get) Token: 0x06024ECA RID: 151242 RVA: 0x00369CB8 File Offset: 0x00367EB8
		// (set) Token: 0x06024ECB RID: 151243 RVA: 0x00369CF1 File Offset: 0x00367EF1
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneAutoTransformTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06024ECC RID: 151244 RVA: 0x00369CFF File Offset: 0x00367EFF
		static UMovieSceneAutoTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneAutoTransformTrack");
		}

		// Token: 0x06024ECD RID: 151245 RVA: 0x00369D0D File Offset: 0x00367F0D
		protected UMovieSceneAutoTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E54 RID: 81492
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013E55 RID: 81493
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneAutoTransformTrack";

		// Token: 0x04013E56 RID: 81494
		private static IntPtr _ClassPtr;

		// Token: 0x04013E57 RID: 81495
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E58 RID: 81496
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013E59 RID: 81497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
