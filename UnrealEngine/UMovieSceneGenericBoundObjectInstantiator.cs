using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200240D RID: 9229
	[UnrealObjectPath("/Script/MovieScene.MovieSceneGenericBoundObjectInstantiator")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneGenericBoundObjectInstantiator : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060229CC RID: 141772 RVA: 0x003330CE File Offset: 0x003312CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneGenericBoundObjectInstantiator._ClassPtr;
		}

		// Token: 0x060229CD RID: 141773 RVA: 0x003330DC File Offset: 0x003312DC
		public UMovieSceneGenericBoundObjectInstantiator() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGenericBoundObjectInstantiator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060229CE RID: 141774 RVA: 0x00333104 File Offset: 0x00331304
		[NullableContext(1)]
		public UMovieSceneGenericBoundObjectInstantiator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGenericBoundObjectInstantiator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060229CF RID: 141775 RVA: 0x00333137 File Offset: 0x00331337
		static UMovieSceneGenericBoundObjectInstantiator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneGenericBoundObjectInstantiator");
		}

		// Token: 0x060229D0 RID: 141776 RVA: 0x00333145 File Offset: 0x00331345
		protected UMovieSceneGenericBoundObjectInstantiator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127ED RID: 75757
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneGenericBoundObjectInstantiator";

		// Token: 0x040127EE RID: 75758
		private static IntPtr _ClassPtr;

		// Token: 0x040127EF RID: 75759
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
