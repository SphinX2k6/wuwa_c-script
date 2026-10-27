using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A2 RID: 9122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePropertyTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public abstract class UMovieScenePropertyTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022599 RID: 140697 RVA: 0x0032CCB5 File Offset: 0x0032AEB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePropertyTrack._ClassPtr;
		}

		// Token: 0x17008459 RID: 33881
		// (get) Token: 0x0602259A RID: 140698 RVA: 0x0032CCC1 File Offset: 0x0032AEC1
		// (set) Token: 0x0602259B RID: 140699 RVA: 0x0032CCD5 File Offset: 0x0032AED5
		[Nullable(2)]
		public unsafe UMovieSceneSection SectionToKey
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScenePropertyTrack.__PropertyOffset_SectionToKey);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScenePropertyTrack.__PropertyOffset_SectionToKey, value);
			}
		}

		// Token: 0x1700845A RID: 33882
		// (get) Token: 0x0602259C RID: 140700 RVA: 0x0032CCEC File Offset: 0x0032AEEC
		// (set) Token: 0x0602259D RID: 140701 RVA: 0x0032CD25 File Offset: 0x0032AF25
		public FMovieScenePropertyBinding PropertyBinding
		{
			get
			{
				base.FastCheckIsValid();
				FMovieScenePropertyBinding result;
				if ((result = this._PropertyBinding) == null)
				{
					result = (this._PropertyBinding = new FMovieScenePropertyBinding(base.NativePtr + (IntPtr)UMovieScenePropertyTrack.__PropertyOffset_PropertyBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieScenePropertyBinding.StaticStruct(), base.NativePtr + (IntPtr)UMovieScenePropertyTrack.__PropertyOffset_PropertyBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700845B RID: 33883
		// (get) Token: 0x0602259E RID: 140702 RVA: 0x0032CD48 File Offset: 0x0032AF48
		// (set) Token: 0x0602259F RID: 140703 RVA: 0x0032CD81 File Offset: 0x0032AF81
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieScenePropertyTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x060225A0 RID: 140704 RVA: 0x0032CD8F File Offset: 0x0032AF8F
		static UMovieScenePropertyTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePropertyTrack");
		}

		// Token: 0x060225A1 RID: 140705 RVA: 0x0032CDA0 File Offset: 0x0032AFA0
		protected UMovieScenePropertyTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePropertyTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225A2 RID: 140706 RVA: 0x0032CDC8 File Offset: 0x0032AFC8
		protected UMovieScenePropertyTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012564 RID: 75108
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePropertyTrack";

		// Token: 0x04012565 RID: 75109
		private static IntPtr _ClassPtr;

		// Token: 0x04012566 RID: 75110
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012567 RID: 75111
		internal static int __PropertyOffset_SectionToKey;

		// Token: 0x04012568 RID: 75112
		internal static int __PropertyOffset_PropertyBinding;

		// Token: 0x04012569 RID: 75113
		[Nullable(2)]
		private FMovieScenePropertyBinding _PropertyBinding;

		// Token: 0x0401256A RID: 75114
		internal static int __PropertyOffset_Sections;

		// Token: 0x0401256B RID: 75115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
