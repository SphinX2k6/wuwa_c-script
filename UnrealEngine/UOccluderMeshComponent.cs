using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EFE RID: 3838
	[UnrealObjectPath("/Script/Engine.OccluderMeshComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UOccluderMeshComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFE1 RID: 53217 RVA: 0x0012F39A File Offset: 0x0012D59A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOccluderMeshComponent._ClassPtr;
		}

		// Token: 0x0600CFE2 RID: 53218 RVA: 0x0012F3A8 File Offset: 0x0012D5A8
		public UOccluderMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UOccluderMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFE3 RID: 53219 RVA: 0x0012F3D0 File Offset: 0x0012D5D0
		[NullableContext(1)]
		public UOccluderMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOccluderMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x0012F403 File Offset: 0x0012D603
		// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x0012F417 File Offset: 0x0012D617
		[Nullable(2)]
		public unsafe UStaticMesh OccluderMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UOccluderMeshComponent.__PropertyOffset_OccluderMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UOccluderMeshComponent.__PropertyOffset_OccluderMesh, value);
			}
		}

		// Token: 0x0600CFE6 RID: 53222 RVA: 0x0012F42C File Offset: 0x0012D62C
		static UOccluderMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.OccluderMeshComponent");
		}

		// Token: 0x0600CFE7 RID: 53223 RVA: 0x0012F43A File Offset: 0x0012D63A
		protected UOccluderMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007010 RID: 28688
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.OccluderMeshComponent";

		// Token: 0x04007011 RID: 28689
		private static IntPtr _ClassPtr;

		// Token: 0x04007012 RID: 28690
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007013 RID: 28691
		internal static int __PropertyOffset_OccluderMesh;
	}
}
