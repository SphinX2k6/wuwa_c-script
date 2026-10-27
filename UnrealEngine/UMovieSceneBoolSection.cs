using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023DA RID: 9178
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBoolSection")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneBoolSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022787 RID: 141191 RVA: 0x0032FAA2 File Offset: 0x0032DCA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBoolSection._ClassPtr;
		}

		// Token: 0x06022788 RID: 141192 RVA: 0x0032FAB0 File Offset: 0x0032DCB0
		public UMovieSceneBoolSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022789 RID: 141193 RVA: 0x0032FAD8 File Offset: 0x0032DCD8
		public UMovieSceneBoolSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBoolSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084C6 RID: 33990
		// (get) Token: 0x0602278A RID: 141194 RVA: 0x0032FB0B File Offset: 0x0032DD0B
		// (set) Token: 0x0602278B RID: 141195 RVA: 0x0032FB1B File Offset: 0x0032DD1B
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

		// Token: 0x170084C7 RID: 33991
		// (get) Token: 0x0602278C RID: 141196 RVA: 0x0032FB2C File Offset: 0x0032DD2C
		// (set) Token: 0x0602278D RID: 141197 RVA: 0x0032FB65 File Offset: 0x0032DD65
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

		// Token: 0x0602278E RID: 141198 RVA: 0x0032FB86 File Offset: 0x0032DD86
		static UMovieSceneBoolSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBoolSection");
		}

		// Token: 0x0602278F RID: 141199 RVA: 0x0032FB94 File Offset: 0x0032DD94
		protected UMovieSceneBoolSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126C9 RID: 75465
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBoolSection";

		// Token: 0x040126CA RID: 75466
		private static IntPtr _ClassPtr;

		// Token: 0x040126CB RID: 75467
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126CC RID: 75468
		internal static int __PropertyOffset_DefaultValue_DEPRECATED;

		// Token: 0x040126CD RID: 75469
		internal static int __PropertyOffset_BoolCurve;

		// Token: 0x040126CE RID: 75470
		[Nullable(2)]
		private FMovieSceneBoolChannel _BoolCurve;
	}
}
