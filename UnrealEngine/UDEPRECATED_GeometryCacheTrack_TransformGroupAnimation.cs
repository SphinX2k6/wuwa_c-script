using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001418 RID: 5144
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheTrack_TransformGroupAnimation")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation : UGeometryCacheTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012C59 RID: 76889 RVA: 0x001B9EFB File Offset: 0x001B80FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation._ClassPtr;
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x001B9F08 File Offset: 0x001B8108
		public UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012C5B RID: 76891 RVA: 0x001B9F30 File Offset: 0x001B8130
		[NullableContext(1)]
		public UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012C5C RID: 76892 RVA: 0x001B9F63 File Offset: 0x001B8163
		[NullableContext(2)]
		public void SetMesh(in FGeometryCacheMeshData NewMeshData)
		{
			UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation.__SetMesh_Internal(base.NativePtr, (NewMeshData ?? new FGeometryCacheMeshData()).NativePtr);
		}

		// Token: 0x06012C5D RID: 76893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMesh_Internal(IntPtr @this, IntPtr NewMeshData);

		// Token: 0x06012C5E RID: 76894 RVA: 0x001B9F80 File Offset: 0x001B8180
		static UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheTrack_TransformGroupAnimation");
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x001B9F8E File Offset: 0x001B818E
		protected UDEPRECATED_GeometryCacheTrack_TransformGroupAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A07E RID: 41086
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheTrack_TransformGroupAnimation";

		// Token: 0x0400A07F RID: 41087
		private static IntPtr _ClassPtr;

		// Token: 0x0400A080 RID: 41088
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
