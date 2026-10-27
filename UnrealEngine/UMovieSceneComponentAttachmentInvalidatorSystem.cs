using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200235E RID: 9054
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentAttachmentInvalidatorSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneComponentAttachmentInvalidatorSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602233A RID: 140090 RVA: 0x0032938B File Offset: 0x0032758B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentAttachmentInvalidatorSystem._ClassPtr;
		}

		// Token: 0x0602233B RID: 140091 RVA: 0x00329398 File Offset: 0x00327598
		public UMovieSceneComponentAttachmentInvalidatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentAttachmentInvalidatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602233C RID: 140092 RVA: 0x003293C0 File Offset: 0x003275C0
		[NullableContext(1)]
		public UMovieSceneComponentAttachmentInvalidatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentAttachmentInvalidatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602233D RID: 140093 RVA: 0x003293F3 File Offset: 0x003275F3
		static UMovieSceneComponentAttachmentInvalidatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentAttachmentInvalidatorSystem");
		}

		// Token: 0x0602233E RID: 140094 RVA: 0x00329401 File Offset: 0x00327601
		protected UMovieSceneComponentAttachmentInvalidatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401241B RID: 74779
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentAttachmentInvalidatorSystem";

		// Token: 0x0401241C RID: 74780
		private static IntPtr _ClassPtr;

		// Token: 0x0401241D RID: 74781
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
