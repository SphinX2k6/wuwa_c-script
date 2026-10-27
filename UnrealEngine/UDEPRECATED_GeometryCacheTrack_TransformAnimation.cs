using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001417 RID: 5143
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheTrack_TransformAnimation")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UDEPRECATED_GeometryCacheTrack_TransformAnimation : UGeometryCacheTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012C52 RID: 76882 RVA: 0x001B9E5D File Offset: 0x001B805D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_GeometryCacheTrack_TransformAnimation._ClassPtr;
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x001B9E6C File Offset: 0x001B806C
		public UDEPRECATED_GeometryCacheTrack_TransformAnimation() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_TransformAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x001B9E94 File Offset: 0x001B8094
		[NullableContext(1)]
		public UDEPRECATED_GeometryCacheTrack_TransformAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_TransformAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x001B9EC7 File Offset: 0x001B80C7
		[NullableContext(2)]
		public void SetMesh(in FGeometryCacheMeshData NewMeshData)
		{
			UDEPRECATED_GeometryCacheTrack_TransformAnimation.__SetMesh_Internal(base.NativePtr, (NewMeshData ?? new FGeometryCacheMeshData()).NativePtr);
		}

		// Token: 0x06012C56 RID: 76886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMesh_Internal(IntPtr @this, IntPtr NewMeshData);

		// Token: 0x06012C57 RID: 76887 RVA: 0x001B9EE4 File Offset: 0x001B80E4
		static UDEPRECATED_GeometryCacheTrack_TransformAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheTrack_TransformAnimation");
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x001B9EF2 File Offset: 0x001B80F2
		protected UDEPRECATED_GeometryCacheTrack_TransformAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A07B RID: 41083
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheTrack_TransformAnimation";

		// Token: 0x0400A07C RID: 41084
		private static IntPtr _ClassPtr;

		// Token: 0x0400A07D RID: 41085
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
