using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023BA RID: 9146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVectorSection")]
	[UnrealStructLayout(952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 952)]
	public class UMovieSceneVectorSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060226BA RID: 140986 RVA: 0x0032E745 File Offset: 0x0032C945
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneVectorSection._ClassPtr;
		}

		// Token: 0x060226BB RID: 140987 RVA: 0x0032E754 File Offset: 0x0032C954
		public UMovieSceneVectorSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVectorSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060226BC RID: 140988 RVA: 0x0032E77C File Offset: 0x0032C97C
		public UMovieSceneVectorSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVectorSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700849B RID: 33947
		// (get) Token: 0x060226BD RID: 140989 RVA: 0x0032E7B0 File Offset: 0x0032C9B0
		// (set) Token: 0x060226BE RID: 140990 RVA: 0x0032E7EA File Offset: 0x0032C9EA
		public TFixedArray<FMovieSceneFloatChannel> Curves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Curves) == null)
				{
					result = (this._Curves = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)UMovieSceneVectorSection.__PropertyOffset_Curves, 4, this));
				}
				return result;
			}
			set
			{
				this.Curves.CopyAssign(value);
			}
		}

		// Token: 0x1700849C RID: 33948
		// (get) Token: 0x060226BF RID: 140991 RVA: 0x0032E7F8 File Offset: 0x0032C9F8
		// (set) Token: 0x060226C0 RID: 140992 RVA: 0x0032E808 File Offset: 0x0032CA08
		public unsafe int ChannelsUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneVectorSection.__PropertyOffset_ChannelsUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneVectorSection.__PropertyOffset_ChannelsUsed) = value;
			}
		}

		// Token: 0x060226C1 RID: 140993 RVA: 0x0032E819 File Offset: 0x0032CA19
		static UMovieSceneVectorSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneVectorSection");
		}

		// Token: 0x060226C2 RID: 140994 RVA: 0x0032E827 File Offset: 0x0032CA27
		protected UMovieSceneVectorSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125F8 RID: 75256
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVectorSection";

		// Token: 0x040125F9 RID: 75257
		private static IntPtr _ClassPtr;

		// Token: 0x040125FA RID: 75258
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125FB RID: 75259
		internal static int __PropertyOffset_Curves;

		// Token: 0x040125FC RID: 75260
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Curves;

		// Token: 0x040125FD RID: 75261
		internal static int __PropertyOffset_ChannelsUsed;
	}
}
