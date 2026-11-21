using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076C RID: 1900
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFloatSection")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UMovieSceneFloatSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4C6 RID: 42182 RVA: 0x000F366E File Offset: 0x000F186E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFloatSection._ClassPtr;
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x000F367C File Offset: 0x000F187C
		public UMovieSceneFloatSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x000F36A4 File Offset: 0x000F18A4
		public UMovieSceneFloatSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x0600A4C9 RID: 42185 RVA: 0x000F36D8 File Offset: 0x000F18D8
		// (set) Token: 0x0600A4CA RID: 42186 RVA: 0x000F3711 File Offset: 0x000F1911
		public FMovieSceneFloatChannel FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneFloatSection.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneFloatSection.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x000F3732 File Offset: 0x000F1932
		static UMovieSceneFloatSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFloatSection");
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x000F3740 File Offset: 0x000F1940
		protected UMovieSceneFloatSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004652 RID: 18002
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFloatSection";

		// Token: 0x04004653 RID: 18003
		private static IntPtr _ClassPtr;

		// Token: 0x04004654 RID: 18004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004655 RID: 18005
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x04004656 RID: 18006
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatCurve;
	}
}
