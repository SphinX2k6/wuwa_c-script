using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078D RID: 1933
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSignedObject")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UMovieSceneSignedObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A72D RID: 42797 RVA: 0x000F6C11 File Offset: 0x000F4E11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSignedObject._ClassPtr;
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x000F6C20 File Offset: 0x000F4E20
		public UMovieSceneSignedObject() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSignedObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x000F6C48 File Offset: 0x000F4E48
		[NullableContext(1)]
		public UMovieSceneSignedObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSignedObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600A730 RID: 42800 RVA: 0x000F6C7B File Offset: 0x000F4E7B
		// (set) Token: 0x0600A731 RID: 42801 RVA: 0x000F6C8F File Offset: 0x000F4E8F
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

		// Token: 0x0600A732 RID: 42802 RVA: 0x000F6CA4 File Offset: 0x000F4EA4
		static UMovieSceneSignedObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSignedObject");
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x000F6CB2 File Offset: 0x000F4EB2
		protected UMovieSceneSignedObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004793 RID: 18323
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSignedObject";

		// Token: 0x04004794 RID: 18324
		private static IntPtr _ClassPtr;

		// Token: 0x04004795 RID: 18325
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004796 RID: 18326
		internal static int __PropertyOffset_Signature;
	}
}
