using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023D8 RID: 9176
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBlenderSystem")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public abstract class UMovieSceneBlenderSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022773 RID: 141171 RVA: 0x0032F8EA File Offset: 0x0032DAEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBlenderSystem._ClassPtr;
		}

		// Token: 0x06022774 RID: 141172 RVA: 0x0032F8F6 File Offset: 0x0032DAF6
		static UMovieSceneBlenderSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBlenderSystem");
		}

		// Token: 0x06022775 RID: 141173 RVA: 0x0032F904 File Offset: 0x0032DB04
		protected UMovieSceneBlenderSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBlenderSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022776 RID: 141174 RVA: 0x0032F92C File Offset: 0x0032DB2C
		protected UMovieSceneBlenderSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126BE RID: 75454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBlenderSystem";

		// Token: 0x040126BF RID: 75455
		private static IntPtr _ClassPtr;

		// Token: 0x040126C0 RID: 75456
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
