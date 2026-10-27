using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002425 RID: 9253
	[UnrealObjectPath("/Script/MovieScene.MovieSceneRestorePreAnimatedStateSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneRestorePreAnimatedStateSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022AA7 RID: 141991 RVA: 0x0033427D File Offset: 0x0033247D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneRestorePreAnimatedStateSystem._ClassPtr;
		}

		// Token: 0x06022AA8 RID: 141992 RVA: 0x0033428C File Offset: 0x0033248C
		public UMovieSceneRestorePreAnimatedStateSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneRestorePreAnimatedStateSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022AA9 RID: 141993 RVA: 0x003342B4 File Offset: 0x003324B4
		[NullableContext(1)]
		public UMovieSceneRestorePreAnimatedStateSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneRestorePreAnimatedStateSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022AAA RID: 141994 RVA: 0x003342E7 File Offset: 0x003324E7
		static UMovieSceneRestorePreAnimatedStateSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneRestorePreAnimatedStateSystem");
		}

		// Token: 0x06022AAB RID: 141995 RVA: 0x003342F5 File Offset: 0x003324F5
		protected UMovieSceneRestorePreAnimatedStateSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401284E RID: 75854
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneRestorePreAnimatedStateSystem";

		// Token: 0x0401284F RID: 75855
		private static IntPtr _ClassPtr;

		// Token: 0x04012850 RID: 75856
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
