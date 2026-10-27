using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002368 RID: 9064
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEnumTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneEnumTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022385 RID: 140165 RVA: 0x00329ABD File Offset: 0x00327CBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEnumTrack._ClassPtr;
		}

		// Token: 0x06022386 RID: 140166 RVA: 0x00329AC9 File Offset: 0x00327CC9
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneEnumTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022387 RID: 140167 RVA: 0x00329AD0 File Offset: 0x00327CD0
		public UMovieSceneEnumTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEnumTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022388 RID: 140168 RVA: 0x00329AF8 File Offset: 0x00327CF8
		[NullableContext(1)]
		public UMovieSceneEnumTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEnumTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008415 RID: 33813
		// (get) Token: 0x06022389 RID: 140169 RVA: 0x00329B2B File Offset: 0x00327D2B
		// (set) Token: 0x0602238A RID: 140170 RVA: 0x00329B3F File Offset: 0x00327D3F
		[Nullable(2)]
		public unsafe UEnum Enum
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEnumTrack.__PropertyOffset_Enum);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneEnumTrack.__PropertyOffset_Enum, value);
			}
		}

		// Token: 0x0602238B RID: 140171 RVA: 0x00329B54 File Offset: 0x00327D54
		static UMovieSceneEnumTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEnumTrack");
		}

		// Token: 0x0602238C RID: 140172 RVA: 0x00329B62 File Offset: 0x00327D62
		protected UMovieSceneEnumTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012444 RID: 74820
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012445 RID: 74821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEnumTrack";

		// Token: 0x04012446 RID: 74822
		private static IntPtr _ClassPtr;

		// Token: 0x04012447 RID: 74823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012448 RID: 74824
		internal static int __PropertyOffset_Enum;
	}
}
