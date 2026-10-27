using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243C RID: 9276
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSignedObject")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UMovieSceneSignedObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022C85 RID: 142469 RVA: 0x00336DB7 File Offset: 0x00334FB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSignedObject._ClassPtr;
		}

		// Token: 0x06022C86 RID: 142470 RVA: 0x00336DC4 File Offset: 0x00334FC4
		public UMovieSceneSignedObject() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSignedObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022C87 RID: 142471 RVA: 0x00336DEC File Offset: 0x00334FEC
		[NullableContext(1)]
		public UMovieSceneSignedObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSignedObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085BD RID: 34237
		// (get) Token: 0x06022C88 RID: 142472 RVA: 0x00336E1F File Offset: 0x0033501F
		// (set) Token: 0x06022C89 RID: 142473 RVA: 0x00336E33 File Offset: 0x00335033
		public unsafe FGuid Signature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSignedObject.__PropertyOffset_Signature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSignedObject.__PropertyOffset_Signature) = value;
			}
		}

		// Token: 0x06022C8A RID: 142474 RVA: 0x00336E48 File Offset: 0x00335048
		static UMovieSceneSignedObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSignedObject");
		}

		// Token: 0x06022C8B RID: 142475 RVA: 0x00336E56 File Offset: 0x00335056
		protected UMovieSceneSignedObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012923 RID: 76067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSignedObject";

		// Token: 0x04012924 RID: 76068
		private static IntPtr _ClassPtr;

		// Token: 0x04012925 RID: 76069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012926 RID: 76070
		internal static int __PropertyOffset_Signature;
	}
}
