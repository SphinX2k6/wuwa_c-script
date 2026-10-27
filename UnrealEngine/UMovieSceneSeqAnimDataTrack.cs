using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026FE RID: 9982
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneSeqAnimDataTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06025057 RID: 151639 RVA: 0x0036C4E2 File Offset: 0x0036A6E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSeqAnimDataTrack._ClassPtr;
		}

		// Token: 0x06025058 RID: 151640 RVA: 0x0036C4EE File Offset: 0x0036A6EE
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneSeqAnimDataTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06025059 RID: 151641 RVA: 0x0036C4F8 File Offset: 0x0036A6F8
		public UMovieSceneSeqAnimDataTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602505A RID: 151642 RVA: 0x0036C520 File Offset: 0x0036A720
		[NullableContext(1)]
		public UMovieSceneSeqAnimDataTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSeqAnimDataTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EEC RID: 36588
		// (get) Token: 0x0602505B RID: 151643 RVA: 0x0036C554 File Offset: 0x0036A754
		// (set) Token: 0x0602505C RID: 151644 RVA: 0x0036C58D File Offset: 0x0036A78D
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSeqAnimDataTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0602505D RID: 151645 RVA: 0x0036C59B File Offset: 0x0036A79B
		static UMovieSceneSeqAnimDataTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack");
		}

		// Token: 0x0602505E RID: 151646 RVA: 0x0036C5A9 File Offset: 0x0036A7A9
		protected UMovieSceneSeqAnimDataTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F2D RID: 81709
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013F2E RID: 81710
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneSeqAnimDataTrack";

		// Token: 0x04013F2F RID: 81711
		private static IntPtr _ClassPtr;

		// Token: 0x04013F30 RID: 81712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F31 RID: 81713
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013F32 RID: 81714
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
