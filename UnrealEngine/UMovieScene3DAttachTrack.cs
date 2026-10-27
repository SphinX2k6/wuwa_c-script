using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002327 RID: 8999
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DAttachTrack")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMovieScene3DAttachTrack : UMovieScene3DConstraintTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060220C3 RID: 139459 RVA: 0x00325468 File Offset: 0x00323668
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DAttachTrack._ClassPtr;
		}

		// Token: 0x060220C4 RID: 139460 RVA: 0x00325474 File Offset: 0x00323674
		public UMovieScene3DAttachTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DAttachTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220C5 RID: 139461 RVA: 0x0032549C File Offset: 0x0032369C
		[NullableContext(1)]
		public UMovieScene3DAttachTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DAttachTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060220C6 RID: 139462 RVA: 0x003254CF File Offset: 0x003236CF
		static UMovieScene3DAttachTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DAttachTrack");
		}

		// Token: 0x060220C7 RID: 139463 RVA: 0x003254DD File Offset: 0x003236DD
		protected UMovieScene3DAttachTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122AC RID: 74412
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DAttachTrack";

		// Token: 0x040122AD RID: 74413
		private static IntPtr _ClassPtr;

		// Token: 0x040122AE RID: 74414
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
