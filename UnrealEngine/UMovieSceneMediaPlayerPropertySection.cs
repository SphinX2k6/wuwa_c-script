using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A8 RID: 8872
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneMediaPlayerPropertySection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021BAD RID: 138157 RVA: 0x0031DED5 File Offset: 0x0031C0D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMediaPlayerPropertySection._ClassPtr;
		}

		// Token: 0x06021BAE RID: 138158 RVA: 0x0031DEE4 File Offset: 0x0031C0E4
		public UMovieSceneMediaPlayerPropertySection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaPlayerPropertySection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BAF RID: 138159 RVA: 0x0031DF0C File Offset: 0x0031C10C
		[NullableContext(1)]
		public UMovieSceneMediaPlayerPropertySection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaPlayerPropertySection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082D7 RID: 33495
		// (get) Token: 0x06021BB0 RID: 138160 RVA: 0x0031DF3F File Offset: 0x0031C13F
		// (set) Token: 0x06021BB1 RID: 138161 RVA: 0x0031DF53 File Offset: 0x0031C153
		[Nullable(2)]
		public unsafe UMediaSource MediaSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaPlayerPropertySection.__PropertyOffset_MediaSource);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMediaPlayerPropertySection.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x170082D8 RID: 33496
		// (get) Token: 0x06021BB2 RID: 138162 RVA: 0x0031DF68 File Offset: 0x0031C168
		// (set) Token: 0x06021BB3 RID: 138163 RVA: 0x0031DF78 File Offset: 0x0031C178
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneMediaPlayerPropertySection.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneMediaPlayerPropertySection.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021BB4 RID: 138164 RVA: 0x0031DF89 File Offset: 0x0031C189
		static UMovieSceneMediaPlayerPropertySection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection");
		}

		// Token: 0x06021BB5 RID: 138165 RVA: 0x0031DF97 File Offset: 0x0031C197
		protected UMovieSceneMediaPlayerPropertySection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FEF RID: 73711
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaPlayerPropertySection";

		// Token: 0x04011FF0 RID: 73712
		private static IntPtr _ClassPtr;

		// Token: 0x04011FF1 RID: 73713
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FF2 RID: 73714
		internal static int __PropertyOffset_MediaSource;

		// Token: 0x04011FF3 RID: 73715
		internal static int __PropertyOffset_bLoop;
	}
}
