using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200269B RID: 9883
	[UnrealObjectPath("/Script/Renderer.TransvoxelCollisionMeshComponent")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class UTransvoxelCollisionMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06024B43 RID: 150339 RVA: 0x003655F2 File Offset: 0x003637F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelCollisionMeshComponent._ClassPtr;
		}

		// Token: 0x06024B44 RID: 150340 RVA: 0x003655FE File Offset: 0x003637FE
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UTransvoxelCollisionMeshComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x06024B45 RID: 150341 RVA: 0x00365608 File Offset: 0x00363808
		public UTransvoxelCollisionMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelCollisionMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B46 RID: 150342 RVA: 0x00365630 File Offset: 0x00363830
		[NullableContext(1)]
		public UTransvoxelCollisionMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelCollisionMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D9F RID: 36255
		// (get) Token: 0x06024B47 RID: 150343 RVA: 0x00365663 File Offset: 0x00363863
		// (set) Token: 0x06024B48 RID: 150344 RVA: 0x00365677 File Offset: 0x00363877
		[Nullable(2)]
		public unsafe UBodySetup MeshBodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelCollisionMeshComponent.__PropertyOffset_MeshBodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelCollisionMeshComponent.__PropertyOffset_MeshBodySetup, value);
			}
		}

		// Token: 0x06024B49 RID: 150345 RVA: 0x0036568C File Offset: 0x0036388C
		static UTransvoxelCollisionMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.TransvoxelCollisionMeshComponent");
		}

		// Token: 0x06024B4A RID: 150346 RVA: 0x0036569A File Offset: 0x0036389A
		protected UTransvoxelCollisionMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013BB8 RID: 80824
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04013BB9 RID: 80825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.TransvoxelCollisionMeshComponent";

		// Token: 0x04013BBA RID: 80826
		private static IntPtr _ClassPtr;

		// Token: 0x04013BBB RID: 80827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013BBC RID: 80828
		internal static int __PropertyOffset_MeshBodySetup;
	}
}
