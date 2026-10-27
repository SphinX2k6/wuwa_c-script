using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001505 RID: 5381
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniStaticMeshComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UHoudiniStaticMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013919 RID: 80153 RVA: 0x001CBF0B File Offset: 0x001CA10B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniStaticMeshComponent._ClassPtr;
		}

		// Token: 0x0601391A RID: 80154 RVA: 0x001CBF18 File Offset: 0x001CA118
		public UHoudiniStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601391B RID: 80155 RVA: 0x001CBF40 File Offset: 0x001CA140
		[NullableContext(1)]
		public UHoudiniStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x0601391C RID: 80156 RVA: 0x001CBF73 File Offset: 0x001CA173
		// (set) Token: 0x0601391D RID: 80157 RVA: 0x001CBF87 File Offset: 0x001CA187
		public unsafe UHoudiniStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniStaticMeshComponent.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniStaticMeshComponent.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x0601391E RID: 80158 RVA: 0x001CBF9C File Offset: 0x001CA19C
		// (set) Token: 0x0601391F RID: 80159 RVA: 0x001CBFB0 File Offset: 0x001CA1B0
		public unsafe FBox LocalBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMeshComponent.__PropertyOffset_LocalBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMeshComponent.__PropertyOffset_LocalBounds) = value;
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x06013920 RID: 80160 RVA: 0x001CBFC5 File Offset: 0x001CA1C5
		// (set) Token: 0x06013921 RID: 80161 RVA: 0x001CBFD5 File Offset: 0x001CA1D5
		public unsafe bool bHoudiniIconVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniStaticMeshComponent.__PropertyOffset_bHoudiniIconVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniStaticMeshComponent.__PropertyOffset_bHoudiniIconVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013922 RID: 80162 RVA: 0x001CBFE6 File Offset: 0x001CA1E6
		public void SetMesh(UHoudiniStaticMesh InMesh)
		{
			UHoudiniStaticMeshComponent.__SetMesh_Internal(base.NativePtr, (InMesh != null) ? InMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06013923 RID: 80163 RVA: 0x001CC003 File Offset: 0x001CA203
		public void SetHoudiniIconVisible(bool bInHoudiniIconVisible)
		{
			UHoudiniStaticMeshComponent.__SetHoudiniIconVisible_Internal(base.NativePtr, bInHoudiniIconVisible);
		}

		// Token: 0x06013924 RID: 80164 RVA: 0x001CC011 File Offset: 0x001CA211
		public void NotifyMeshUpdated()
		{
			UHoudiniStaticMeshComponent.__NotifyMeshUpdated_Internal(base.NativePtr);
		}

		// Token: 0x06013925 RID: 80165 RVA: 0x001CC01E File Offset: 0x001CA21E
		public bool IsHoudiniIconVisible()
		{
			return UHoudiniStaticMeshComponent.__IsHoudiniIconVisible_Internal(base.NativePtr);
		}

		// Token: 0x06013926 RID: 80166 RVA: 0x001CC02B File Offset: 0x001CA22B
		public UHoudiniStaticMesh GetMesh()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UHoudiniStaticMesh>(UHoudiniStaticMeshComponent.__GetMesh_Internal(base.NativePtr));
		}

		// Token: 0x06013927 RID: 80167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMesh_Internal(IntPtr @this, IntPtr InMesh);

		// Token: 0x06013928 RID: 80168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoudiniIconVisible_Internal(IntPtr @this, bool bInHoudiniIconVisible);

		// Token: 0x06013929 RID: 80169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyMeshUpdated_Internal(IntPtr @this);

		// Token: 0x0601392A RID: 80170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHoudiniIconVisible_Internal(IntPtr @this);

		// Token: 0x0601392B RID: 80171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMesh_Internal(IntPtr @this);

		// Token: 0x0601392C RID: 80172 RVA: 0x001CC03D File Offset: 0x001CA23D
		static UHoudiniStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniStaticMeshComponent");
		}

		// Token: 0x0601392D RID: 80173 RVA: 0x001CC04B File Offset: 0x001CA24B
		protected UHoudiniStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A926 RID: 43302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniStaticMeshComponent";

		// Token: 0x0400A927 RID: 43303
		private static IntPtr _ClassPtr;

		// Token: 0x0400A928 RID: 43304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A929 RID: 43305
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400A92A RID: 43306
		internal static int __PropertyOffset_LocalBounds;

		// Token: 0x0400A92B RID: 43307
		internal static int __PropertyOffset_bHoudiniIconVisible;
	}
}
