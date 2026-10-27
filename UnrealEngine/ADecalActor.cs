using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AB RID: 2475
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DecalActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ADecalActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008BC4 RID: 35780 RVA: 0x000C8384 File Offset: 0x000C6584
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADecalActor._ClassPtr;
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x000C8390 File Offset: 0x000C6590
		public ADecalActor() : this(BuiltinUtils.AllocNativeUObject(ADecalActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x000C83B8 File Offset: 0x000C65B8
		[NullableContext(1)]
		public ADecalActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADecalActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06008BC7 RID: 35783 RVA: 0x000C83EB File Offset: 0x000C65EB
		// (set) Token: 0x06008BC8 RID: 35784 RVA: 0x000C83FF File Offset: 0x000C65FF
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

		// Token: 0x06008BC9 RID: 35785 RVA: 0x000C8414 File Offset: 0x000C6614
		public void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
		{
			ADecalActor.__SetDecalMaterial_Internal(base.NativePtr, (NewDecalMaterial != null) ? NewDecalMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x000C8431 File Offset: 0x000C6631
		public UMaterialInterface GetDecalMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(ADecalActor.__GetDecalMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x000C8443 File Offset: 0x000C6643
		public UMaterialInstanceDynamic CreateDynamicMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ADecalActor.__CreateDynamicMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x06008BCC RID: 35788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalMaterial_Internal(IntPtr @this, IntPtr NewDecalMaterial);

		// Token: 0x06008BCD RID: 35789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDecalMaterial_Internal(IntPtr @this);

		// Token: 0x06008BCE RID: 35790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDynamicMaterialInstance_Internal(IntPtr @this);

		// Token: 0x06008BCF RID: 35791 RVA: 0x000C8455 File Offset: 0x000C6655
		static ADecalActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DecalActor");
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x000C8463 File Offset: 0x000C6663
		protected ADecalActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004265 RID: 16997
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DecalActor";

		// Token: 0x04004266 RID: 16998
		private static IntPtr _ClassPtr;

		// Token: 0x04004267 RID: 16999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004268 RID: 17000
		internal static int __PropertyOffset_Decal;
	}
}
