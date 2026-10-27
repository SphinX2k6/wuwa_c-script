using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237D RID: 9085
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFloatSection")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UMovieSceneFloatSection : UMovieSceneSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022445 RID: 140357 RVA: 0x0032ACF2 File Offset: 0x00328EF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFloatSection._ClassPtr;
		}

		// Token: 0x06022446 RID: 140358 RVA: 0x0032ACFE File Offset: 0x00328EFE
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneFloatSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x06022447 RID: 140359 RVA: 0x0032AD08 File Offset: 0x00328F08
		public UMovieSceneFloatSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022448 RID: 140360 RVA: 0x0032AD30 File Offset: 0x00328F30
		[NullableContext(1)]
		public UMovieSceneFloatSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008431 RID: 33841
		// (get) Token: 0x06022449 RID: 140361 RVA: 0x0032AD64 File Offset: 0x00328F64
		// (set) Token: 0x0602244A RID: 140362 RVA: 0x0032AD9D File Offset: 0x00328F9D
		[Nullable(1)]
		public FMovieSceneFloatChannel FloatCurve
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneFloatSection.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602244B RID: 140363 RVA: 0x0032ADBE File Offset: 0x00328FBE
		static UMovieSceneFloatSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFloatSection");
		}

		// Token: 0x0602244C RID: 140364 RVA: 0x0032ADCC File Offset: 0x00328FCC
		protected UMovieSceneFloatSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124AF RID: 74927
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x040124B0 RID: 74928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFloatSection";

		// Token: 0x040124B1 RID: 74929
		private static IntPtr _ClassPtr;

		// Token: 0x040124B2 RID: 74930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124B3 RID: 74931
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x040124B4 RID: 74932
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatCurve;
	}
}
