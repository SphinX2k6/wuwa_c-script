using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200077C RID: 1916
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBoolSection")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UMovieSceneBoolSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A599 RID: 42393 RVA: 0x000F4985 File Offset: 0x000F2B85
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBoolSection._ClassPtr;
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x000F4994 File Offset: 0x000F2B94
		public UMovieSceneBoolSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x000F49BC File Offset: 0x000F2BBC
		public UMovieSceneBoolSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x0600A59C RID: 42396 RVA: 0x000F49EF File Offset: 0x000F2BEF
		// (set) Token: 0x0600A59D RID: 42397 RVA: 0x000F49FF File Offset: 0x000F2BFF
		public unsafe bool DefaultValue_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneBoolSection.__PropertyOffset_DefaultValue_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneBoolSection.__PropertyOffset_DefaultValue_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600A59E RID: 42398 RVA: 0x000F4A10 File Offset: 0x000F2C10
		// (set) Token: 0x0600A59F RID: 42399 RVA: 0x000F4A49 File Offset: 0x000F2C49
		public FMovieSceneBoolChannel BoolCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneBoolChannel result;
				if ((result = this._BoolCurve) == null)
				{
					result = (this._BoolCurve = new FMovieSceneBoolChannel(base.NativePtr + (IntPtr)UMovieSceneBoolSection.__PropertyOffset_BoolCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneBoolChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneBoolSection.__PropertyOffset_BoolCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x000F4A6A File Offset: 0x000F2C6A
		static UMovieSceneBoolSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBoolSection");
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x000F4A78 File Offset: 0x000F2C78
		protected UMovieSceneBoolSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046E1 RID: 18145
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBoolSection";

		// Token: 0x040046E2 RID: 18146
		private static IntPtr _ClassPtr;

		// Token: 0x040046E3 RID: 18147
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040046E4 RID: 18148
		internal static int __PropertyOffset_DefaultValue_DEPRECATED;

		// Token: 0x040046E5 RID: 18149
		internal static int __PropertyOffset_BoolCurve;

		// Token: 0x040046E6 RID: 18150
		[Nullable(2)]
		private FMovieSceneBoolChannel _BoolCurve;
	}
}
