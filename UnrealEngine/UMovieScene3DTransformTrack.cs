using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002335 RID: 9013
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieScene3DTransformTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022168 RID: 139624 RVA: 0x0032665A File Offset: 0x0032485A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DTransformTrack._ClassPtr;
		}

		// Token: 0x06022169 RID: 139625 RVA: 0x00326668 File Offset: 0x00324868
		public UMovieScene3DTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602216A RID: 139626 RVA: 0x00326690 File Offset: 0x00324890
		[NullableContext(1)]
		public UMovieScene3DTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602216B RID: 139627 RVA: 0x003266C3 File Offset: 0x003248C3
		static UMovieScene3DTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DTransformTrack");
		}

		// Token: 0x0602216C RID: 139628 RVA: 0x003266D1 File Offset: 0x003248D1
		protected UMovieScene3DTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012319 RID: 74521
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformTrack";

		// Token: 0x0401231A RID: 74522
		private static IntPtr _ClassPtr;

		// Token: 0x0401231B RID: 74523
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
