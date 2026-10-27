using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002419 RID: 9241
	[UnrealObjectPath("/Script/MovieScene.MovieSceneNodeGroupCollection")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieSceneNodeGroupCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A2A RID: 141866 RVA: 0x003338A2 File Offset: 0x00331AA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNodeGroupCollection._ClassPtr;
		}

		// Token: 0x06022A2B RID: 141867 RVA: 0x003338B0 File Offset: 0x00331AB0
		public UMovieSceneNodeGroupCollection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNodeGroupCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A2C RID: 141868 RVA: 0x003338D8 File Offset: 0x00331AD8
		[NullableContext(1)]
		public UMovieSceneNodeGroupCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNodeGroupCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022A2D RID: 141869 RVA: 0x0033390B File Offset: 0x00331B0B
		static UMovieSceneNodeGroupCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneNodeGroupCollection");
		}

		// Token: 0x06022A2E RID: 141870 RVA: 0x00333919 File Offset: 0x00331B19
		protected UMovieSceneNodeGroupCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012819 RID: 75801
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneNodeGroupCollection";

		// Token: 0x0401281A RID: 75802
		private static IntPtr _ClassPtr;

		// Token: 0x0401281B RID: 75803
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
