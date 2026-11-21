using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000768 RID: 1896
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventTrack")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMovieSceneEventTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4A4 RID: 42148 RVA: 0x000F326A File Offset: 0x000F146A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventTrack._ClassPtr;
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x000F3278 File Offset: 0x000F1478
		public UMovieSceneEventTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x000F32A0 File Offset: 0x000F14A0
		public UMovieSceneEventTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x000F32D3 File Offset: 0x000F14D3
		// (set) Token: 0x0600A4A8 RID: 42152 RVA: 0x000F32EC File Offset: 0x000F14EC
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) & UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) & ~UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards) | (value ? UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x000F331C File Offset: 0x000F151C
		// (set) Token: 0x0600A4AA RID: 42154 RVA: 0x000F3335 File Offset: 0x000F1535
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) & UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) & ~UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards) | (value ? UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x000F3368 File Offset: 0x000F1568
		// (set) Token: 0x0600A4AC RID: 42156 RVA: 0x000F33A1 File Offset: 0x000F15A1
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x000F33AF File Offset: 0x000F15AF
		static UMovieSceneEventTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventTrack");
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x000F33BD File Offset: 0x000F15BD
		protected UMovieSceneEventTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004639 RID: 17977
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventTrack";

		// Token: 0x0400463A RID: 17978
		private static IntPtr _ClassPtr;

		// Token: 0x0400463B RID: 17979
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400463C RID: 17980
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x0400463D RID: 17981
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x0400463E RID: 17982
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x0400463F RID: 17983
		internal static byte __PropertyMask_bFireEventsWhenBackwards;

		// Token: 0x04004640 RID: 17984
		internal static int __PropertyOffset_Sections;

		// Token: 0x04004641 RID: 17985
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
