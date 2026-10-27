using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002344 RID: 9028
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneByteTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneByteTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022211 RID: 139793 RVA: 0x003276B5 File Offset: 0x003258B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneByteTrack._ClassPtr;
		}

		// Token: 0x06022212 RID: 139794 RVA: 0x003276C1 File Offset: 0x003258C1
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneByteTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022213 RID: 139795 RVA: 0x003276C8 File Offset: 0x003258C8
		public UMovieSceneByteTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneByteTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022214 RID: 139796 RVA: 0x003276F0 File Offset: 0x003258F0
		[NullableContext(1)]
		public UMovieSceneByteTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneByteTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083D1 RID: 33745
		// (get) Token: 0x06022215 RID: 139797 RVA: 0x00327723 File Offset: 0x00325923
		// (set) Token: 0x06022216 RID: 139798 RVA: 0x00327737 File Offset: 0x00325937
		[Nullable(2)]
		public unsafe UEnum Enum
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneByteTrack.__PropertyOffset_Enum);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneByteTrack.__PropertyOffset_Enum, value);
			}
		}

		// Token: 0x06022217 RID: 139799 RVA: 0x0032774C File Offset: 0x0032594C
		static UMovieSceneByteTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneByteTrack");
		}

		// Token: 0x06022218 RID: 139800 RVA: 0x0032775A File Offset: 0x0032595A
		protected UMovieSceneByteTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012374 RID: 74612
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012375 RID: 74613
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneByteTrack";

		// Token: 0x04012376 RID: 74614
		private static IntPtr _ClassPtr;

		// Token: 0x04012377 RID: 74615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012378 RID: 74616
		internal static int __PropertyOffset_Enum;
	}
}
