using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026ED RID: 9965
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueStateTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneDialogueStateTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024F54 RID: 151380 RVA: 0x0036A9AD File Offset: 0x00368BAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueStateTrack._ClassPtr;
		}

		// Token: 0x06024F55 RID: 151381 RVA: 0x0036A9B9 File Offset: 0x00368BB9
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneDialogueStateTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06024F56 RID: 151382 RVA: 0x0036A9C0 File Offset: 0x00368BC0
		public UMovieSceneDialogueStateTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F57 RID: 151383 RVA: 0x0036A9E8 File Offset: 0x00368BE8
		[NullableContext(1)]
		public UMovieSceneDialogueStateTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EB3 RID: 36531
		// (get) Token: 0x06024F58 RID: 151384 RVA: 0x0036AA1C File Offset: 0x00368C1C
		// (set) Token: 0x06024F59 RID: 151385 RVA: 0x0036AA55 File Offset: 0x00368C55
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneDialogueStateTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06024F5A RID: 151386 RVA: 0x0036AA63 File Offset: 0x00368C63
		static UMovieSceneDialogueStateTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueStateTrack");
		}

		// Token: 0x06024F5B RID: 151387 RVA: 0x0036AA71 File Offset: 0x00368C71
		protected UMovieSceneDialogueStateTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EA3 RID: 81571
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04013EA4 RID: 81572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueStateTrack";

		// Token: 0x04013EA5 RID: 81573
		private static IntPtr _ClassPtr;

		// Token: 0x04013EA6 RID: 81574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EA7 RID: 81575
		internal static int __PropertyOffset_Sections;

		// Token: 0x04013EA8 RID: 81576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
