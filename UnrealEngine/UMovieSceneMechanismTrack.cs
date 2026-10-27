using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D2 RID: 6610
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneMechanismTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060188CB RID: 100555 RVA: 0x002426CC File Offset: 0x002408CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismTrack._ClassPtr;
		}

		// Token: 0x060188CC RID: 100556 RVA: 0x002426D8 File Offset: 0x002408D8
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneMechanismTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060188CD RID: 100557 RVA: 0x002426E0 File Offset: 0x002408E0
		public UMovieSceneMechanismTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060188CE RID: 100558 RVA: 0x00242708 File Offset: 0x00240908
		[NullableContext(1)]
		public UMovieSceneMechanismTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061DB RID: 25051
		// (get) Token: 0x060188CF RID: 100559 RVA: 0x0024273C File Offset: 0x0024093C
		// (set) Token: 0x060188D0 RID: 100560 RVA: 0x00242775 File Offset: 0x00240975
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneMechanismTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x060188D1 RID: 100561 RVA: 0x00242783 File Offset: 0x00240983
		static UMovieSceneMechanismTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack");
		}

		// Token: 0x060188D2 RID: 100562 RVA: 0x00242791 File Offset: 0x00240991
		protected UMovieSceneMechanismTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D437 RID: 54327
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400D438 RID: 54328
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack";

		// Token: 0x0400D439 RID: 54329
		private static IntPtr _ClassPtr;

		// Token: 0x0400D43A RID: 54330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D43B RID: 54331
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400D43C RID: 54332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
