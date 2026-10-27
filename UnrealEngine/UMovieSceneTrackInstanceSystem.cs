using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002459 RID: 9305
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstanceSystem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UMovieSceneTrackInstanceSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DE7 RID: 142823 RVA: 0x00338EDA File Offset: 0x003370DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTrackInstanceSystem._ClassPtr;
		}

		// Token: 0x06022DE8 RID: 142824 RVA: 0x00338EE8 File Offset: 0x003370E8
		public UMovieSceneTrackInstanceSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstanceSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DE9 RID: 142825 RVA: 0x00338F10 File Offset: 0x00337110
		[NullableContext(1)]
		public UMovieSceneTrackInstanceSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstanceSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008608 RID: 34312
		// (get) Token: 0x06022DEA RID: 142826 RVA: 0x00338F43 File Offset: 0x00337143
		// (set) Token: 0x06022DEB RID: 142827 RVA: 0x00338F57 File Offset: 0x00337157
		[Nullable(2)]
		public unsafe UMovieSceneTrackInstanceInstantiator Instantiator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneTrackInstanceInstantiator>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstanceSystem.__PropertyOffset_Instantiator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneTrackInstanceSystem.__PropertyOffset_Instantiator, value);
			}
		}

		// Token: 0x06022DEC RID: 142828 RVA: 0x00338F6C File Offset: 0x0033716C
		static UMovieSceneTrackInstanceSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneTrackInstanceSystem");
		}

		// Token: 0x06022DED RID: 142829 RVA: 0x00338F7A File Offset: 0x0033717A
		protected UMovieSceneTrackInstanceSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129DB RID: 76251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstanceSystem";

		// Token: 0x040129DC RID: 76252
		private static IntPtr _ClassPtr;

		// Token: 0x040129DD RID: 76253
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129DE RID: 76254
		internal static int __PropertyOffset_Instantiator;
	}
}
