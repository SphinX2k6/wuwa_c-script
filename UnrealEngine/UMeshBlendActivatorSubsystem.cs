using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022BB RID: 8891
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActivatorSubsystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMeshBlendActivatorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C6F RID: 138351 RVA: 0x0031F008 File Offset: 0x0031D208
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshBlendActivatorSubsystem._ClassPtr;
		}

		// Token: 0x06021C70 RID: 138352 RVA: 0x0031F014 File Offset: 0x0031D214
		public UMeshBlendActivatorSubsystem() : this(BuiltinUtils.AllocNativeUObject(UMeshBlendActivatorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C71 RID: 138353 RVA: 0x0031F03C File Offset: 0x0031D23C
		[NullableContext(1)]
		public UMeshBlendActivatorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshBlendActivatorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008306 RID: 33542
		// (get) Token: 0x06021C72 RID: 138354 RVA: 0x0031F06F File Offset: 0x0031D26F
		// (set) Token: 0x06021C73 RID: 138355 RVA: 0x0031F083 File Offset: 0x0031D283
		public unsafe UMeshBlendActivatorLogic MeshBlendActivatorLogic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMeshBlendActivatorLogic>(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendActivatorSubsystem.__PropertyOffset_MeshBlendActivatorLogic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMeshBlendActivatorSubsystem.__PropertyOffset_MeshBlendActivatorLogic, value);
			}
		}

		// Token: 0x17008307 RID: 33543
		// (get) Token: 0x06021C74 RID: 138356 RVA: 0x0031F098 File Offset: 0x0031D298
		// (set) Token: 0x06021C75 RID: 138357 RVA: 0x0031F0A8 File Offset: 0x0031D2A8
		public unsafe bool CachedCVarMeshBlendEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMeshBlendActivatorSubsystem.__PropertyOffset_CachedCVarMeshBlendEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMeshBlendActivatorSubsystem.__PropertyOffset_CachedCVarMeshBlendEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021C76 RID: 138358 RVA: 0x0031F0B9 File Offset: 0x0031D2B9
		public void RefreshActor(AActor Actor, bool bSoftReset)
		{
			UMeshBlendActivatorSubsystem.__RefreshActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bSoftReset);
		}

		// Token: 0x06021C77 RID: 138359 RVA: 0x0031F0D7 File Offset: 0x0031D2D7
		public static UMeshBlendActivatorSubsystem GetInstance(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshBlendActivatorSubsystem>(UMeshBlendActivatorSubsystem.__GetInstance_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06021C78 RID: 138360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshActor_Internal(IntPtr @this, IntPtr Actor, bool bSoftReset);

		// Token: 0x06021C79 RID: 138361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal(IntPtr World);

		// Token: 0x06021C7A RID: 138362 RVA: 0x0031F0F3 File Offset: 0x0031D2F3
		static UMeshBlendActivatorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.MeshBlendActivatorSubsystem");
		}

		// Token: 0x06021C7B RID: 138363 RVA: 0x0031F101 File Offset: 0x0031D301
		protected UMeshBlendActivatorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012067 RID: 73831
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshBlend.MeshBlendActivatorSubsystem";

		// Token: 0x04012068 RID: 73832
		private static IntPtr _ClassPtr;

		// Token: 0x04012069 RID: 73833
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401206A RID: 73834
		internal static int __PropertyOffset_MeshBlendActivatorLogic;

		// Token: 0x0401206B RID: 73835
		internal static int __PropertyOffset_CachedCVarMeshBlendEnable;
	}
}
