using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F8 RID: 9976
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneQteTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602500B RID: 151563 RVA: 0x0036BDE4 File Offset: 0x00369FE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteTrack._ClassPtr;
		}

		// Token: 0x0602500C RID: 151564 RVA: 0x0036BDF0 File Offset: 0x00369FF0
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneQteTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602500D RID: 151565 RVA: 0x0036BDF8 File Offset: 0x00369FF8
		public UMovieSceneQteTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602500E RID: 151566 RVA: 0x0036BE20 File Offset: 0x0036A020
		[NullableContext(1)]
		public UMovieSceneQteTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EE3 RID: 36579
		// (get) Token: 0x0602500F RID: 151567 RVA: 0x0036BE54 File Offset: 0x0036A054
		// (set) Token: 0x06025010 RID: 151568 RVA: 0x0036BE8D File Offset: 0x0036A08D
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneQteTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06025011 RID: 151569 RVA: 0x0036BE9B File Offset: 0x0036A09B
		static UMovieSceneQteTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteTrack");
		}

		// Token: 0x06025012 RID: 151570 RVA: 0x0036BEA9 File Offset: 0x0036A0A9
		protected UMovieSceneQteTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F0B RID: 81675
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013F0C RID: 81676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTrack";

		// Token: 0x04013F0D RID: 81677
		private static IntPtr _ClassPtr;

		// Token: 0x04013F0E RID: 81678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F0F RID: 81679
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013F10 RID: 81680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
