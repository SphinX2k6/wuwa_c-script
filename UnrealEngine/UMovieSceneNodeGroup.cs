using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002418 RID: 9240
	[UnrealObjectPath("/Script/MovieScene.MovieSceneNodeGroup")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMovieSceneNodeGroup : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A25 RID: 141861 RVA: 0x00333822 File Offset: 0x00331A22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNodeGroup._ClassPtr;
		}

		// Token: 0x06022A26 RID: 141862 RVA: 0x00333830 File Offset: 0x00331A30
		public UMovieSceneNodeGroup() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNodeGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A27 RID: 141863 RVA: 0x00333858 File Offset: 0x00331A58
		[NullableContext(1)]
		public UMovieSceneNodeGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNodeGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022A28 RID: 141864 RVA: 0x0033388B File Offset: 0x00331A8B
		static UMovieSceneNodeGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneNodeGroup");
		}

		// Token: 0x06022A29 RID: 141865 RVA: 0x00333899 File Offset: 0x00331A99
		protected UMovieSceneNodeGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012816 RID: 75798
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneNodeGroup";

		// Token: 0x04012817 RID: 75799
		private static IntPtr _ClassPtr;

		// Token: 0x04012818 RID: 75800
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
