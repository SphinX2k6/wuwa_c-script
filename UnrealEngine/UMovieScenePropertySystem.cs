using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A1 RID: 9121
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePropertySystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UMovieScenePropertySystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022593 RID: 140691 RVA: 0x0032CC3E File Offset: 0x0032AE3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePropertySystem._ClassPtr;
		}

		// Token: 0x17008458 RID: 33880
		// (get) Token: 0x06022594 RID: 140692 RVA: 0x0032CC4A File Offset: 0x0032AE4A
		// (set) Token: 0x06022595 RID: 140693 RVA: 0x0032CC5E File Offset: 0x0032AE5E
		[Nullable(2)]
		public unsafe UMovieScenePropertyInstantiatorSystem InstantiatorSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScenePropertyInstantiatorSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScenePropertySystem.__PropertyOffset_InstantiatorSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieScenePropertySystem.__PropertyOffset_InstantiatorSystem, value);
			}
		}

		// Token: 0x06022596 RID: 140694 RVA: 0x0032CC73 File Offset: 0x0032AE73
		static UMovieScenePropertySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePropertySystem");
		}

		// Token: 0x06022597 RID: 140695 RVA: 0x0032CC84 File Offset: 0x0032AE84
		protected UMovieScenePropertySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePropertySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022598 RID: 140696 RVA: 0x0032CCAC File Offset: 0x0032AEAC
		protected UMovieScenePropertySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012560 RID: 75104
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePropertySystem";

		// Token: 0x04012561 RID: 75105
		private static IntPtr _ClassPtr;

		// Token: 0x04012562 RID: 75106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012563 RID: 75107
		internal static int __PropertyOffset_InstantiatorSystem;
	}
}
