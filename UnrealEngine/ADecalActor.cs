using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C6 RID: 454
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DecalActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ADecalActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600211E RID: 8478 RVA: 0x00030B23 File Offset: 0x0002ED23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADecalActor._ClassPtr;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00030B30 File Offset: 0x0002ED30
		public ADecalActor() : this(BuiltinUtils.AllocNativeUObject(ADecalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00030B58 File Offset: 0x0002ED58
		[NullableContext(1)]
		public ADecalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADecalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x00030B8B File Offset: 0x0002ED8B
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x00030B9F File Offset: 0x0002ED9F
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADecalActor.__PropertyOffset_Decal);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADecalActor.__PropertyOffset_Decal, value);
			}
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00030BB4 File Offset: 0x0002EDB4
		public void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
		{
			ADecalActor.__SetDecalMaterial_Internal(base.NativePtr, (NewDecalMaterial != null) ? NewDecalMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00030BD1 File Offset: 0x0002EDD1
		public UMaterialInterface GetDecalMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(ADecalActor.__GetDecalMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00030BE3 File Offset: 0x0002EDE3
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ADecalActor.__CreateDynamicMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x06002126 RID: 8486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalMaterial_Internal(IntPtr @this, IntPtr NewDecalMaterial);

		// Token: 0x06002127 RID: 8487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDecalMaterial_Internal(IntPtr @this);

		// Token: 0x06002128 RID: 8488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this);

		// Token: 0x06002129 RID: 8489 RVA: 0x00030BF5 File Offset: 0x0002EDF5
		static ADecalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DecalActor");
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00030C03 File Offset: 0x0002EE03
		protected ADecalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B0D RID: 2829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DecalActor";

		// Token: 0x04000B0E RID: 2830
		private static IntPtr _ClassPtr;

		// Token: 0x04000B0F RID: 2831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B10 RID: 2832
		internal static int __PropertyOffset_Decal;
	}
}
