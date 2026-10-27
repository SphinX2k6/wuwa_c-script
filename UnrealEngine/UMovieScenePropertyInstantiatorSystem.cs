using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A0 RID: 9120
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePropertyInstantiatorSystem")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UMovieScenePropertyInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject, IMovieScenePreAnimatedStateSystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602258D RID: 140685 RVA: 0x0032CBB7 File Offset: 0x0032ADB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePropertyInstantiatorSystem._ClassPtr;
		}

		// Token: 0x0602258E RID: 140686 RVA: 0x0032CBC3 File Offset: 0x0032ADC3
		int IMovieScenePreAnimatedStateSystemInterface.InterfaceOffset()
		{
			return UMovieScenePropertyInstantiatorSystem.__InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;
		}

		// Token: 0x0602258F RID: 140687 RVA: 0x0032CBCC File Offset: 0x0032ADCC
		public UMovieScenePropertyInstantiatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePropertyInstantiatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022590 RID: 140688 RVA: 0x0032CBF4 File Offset: 0x0032ADF4
		[NullableContext(1)]
		public UMovieScenePropertyInstantiatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePropertyInstantiatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022591 RID: 140689 RVA: 0x0032CC27 File Offset: 0x0032AE27
		static UMovieScenePropertyInstantiatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePropertyInstantiatorSystem");
		}

		// Token: 0x06022592 RID: 140690 RVA: 0x0032CC35 File Offset: 0x0032AE35
		protected UMovieScenePropertyInstantiatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401255C RID: 75100
		internal static int __InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;

		// Token: 0x0401255D RID: 75101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePropertyInstantiatorSystem";

		// Token: 0x0401255E RID: 75102
		private static IntPtr _ClassPtr;

		// Token: 0x0401255F RID: 75103
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
