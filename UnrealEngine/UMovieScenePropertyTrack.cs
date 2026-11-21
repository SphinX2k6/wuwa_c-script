using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000770 RID: 1904
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePropertyTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public abstract class UMovieScenePropertyTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4EC RID: 42220 RVA: 0x000F39CD File Offset: 0x000F1BCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePropertyTrack._ClassPtr;
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x0600A4ED RID: 42221 RVA: 0x000F39D9 File Offset: 0x000F1BD9
		// (set) Token: 0x0600A4EE RID: 42222 RVA: 0x000F39ED File Offset: 0x000F1BED
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

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x0600A4EF RID: 42223 RVA: 0x000F3A04 File Offset: 0x000F1C04
		// (set) Token: 0x0600A4F0 RID: 42224 RVA: 0x000F3A3D File Offset: 0x000F1C3D
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

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x000F3A4B File Offset: 0x000F1C4B
		static UMovieScenePropertyTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePropertyTrack");
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x000F3A5C File Offset: 0x000F1C5C
		protected UMovieScenePropertyTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePropertyTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x000F3A84 File Offset: 0x000F1C84
		protected UMovieScenePropertyTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004666 RID: 18022
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePropertyTrack";

		// Token: 0x04004667 RID: 18023
		private static IntPtr _ClassPtr;

		// Token: 0x04004668 RID: 18024
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004669 RID: 18025
		internal static int __PropertyOffset_SectionToKey;

		// Token: 0x0400466A RID: 18026
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400466B RID: 18027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
