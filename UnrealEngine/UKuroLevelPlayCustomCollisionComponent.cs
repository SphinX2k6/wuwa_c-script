using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E7 RID: 6375
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayCustomCollisionComponent")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UKuroLevelPlayCustomCollisionComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IKuroLevelPlayInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06017A35 RID: 96821 RVA: 0x0022A4C1 File Offset: 0x002286C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayCustomCollisionComponent._ClassPtr;
		}

		// Token: 0x06017A36 RID: 96822 RVA: 0x0022A4CD File Offset: 0x002286CD
		int IKuroLevelPlayInterface.InterfaceOffset()
		{
			return UKuroLevelPlayCustomCollisionComponent.__InterfaceOffset_IKuroLevelPlayInterface;
		}

		// Token: 0x06017A37 RID: 96823 RVA: 0x0022A4D4 File Offset: 0x002286D4
		public UKuroLevelPlayCustomCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCustomCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017A38 RID: 96824 RVA: 0x0022A4FC File Offset: 0x002286FC
		[NullableContext(1)]
		public UKuroLevelPlayCustomCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCustomCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x06017A39 RID: 96825 RVA: 0x0022A530 File Offset: 0x00228730
		// (set) Token: 0x06017A3A RID: 96826 RVA: 0x0022A569 File Offset: 0x00228769
		[Nullable(1)]
		public FCollisionProfileName CollisionProfileName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._CollisionProfileName) == null)
				{
					result = (this._CollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_CollisionProfileName, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_CollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x06017A3B RID: 96827 RVA: 0x0022A58A File Offset: 0x0022878A
		// (set) Token: 0x06017A3C RID: 96828 RVA: 0x0022A59E File Offset: 0x0022879E
		public unsafe FVector WaterStaticMeshNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_WaterStaticMeshNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_WaterStaticMeshNormal) = value;
			}
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x06017A3D RID: 96829 RVA: 0x0022A5B3 File Offset: 0x002287B3
		// (set) Token: 0x06017A3E RID: 96830 RVA: 0x0022A5C7 File Offset: 0x002287C7
		public unsafe FVector WaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_WaterNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_WaterNormal) = value;
			}
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x06017A3F RID: 96831 RVA: 0x0022A5DC File Offset: 0x002287DC
		// (set) Token: 0x06017A40 RID: 96832 RVA: 0x0022A5F0 File Offset: 0x002287F0
		[Nullable(2)]
		public unsafe UBodySetup BodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_BodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayCustomCollisionComponent.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x06017A41 RID: 96833 RVA: 0x0022A605 File Offset: 0x00228805
		public bool CanEnableCollision()
		{
			return UKuroLevelPlayCustomCollisionComponent.__CanEnableCollision_Internal(base.NativePtr);
		}

		// Token: 0x06017A42 RID: 96834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanEnableCollision_Internal(IntPtr @this);

		// Token: 0x06017A43 RID: 96835 RVA: 0x0022A612 File Offset: 0x00228812
		static UKuroLevelPlayCustomCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayCustomCollisionComponent");
		}

		// Token: 0x06017A44 RID: 96836 RVA: 0x0022A620 File Offset: 0x00228820
		protected UKuroLevelPlayCustomCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CD70 RID: 52592
		internal static int __InterfaceOffset_IKuroLevelPlayInterface;

		// Token: 0x0400CD71 RID: 52593
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayCustomCollisionComponent";

		// Token: 0x0400CD72 RID: 52594
		private static IntPtr _ClassPtr;

		// Token: 0x0400CD73 RID: 52595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CD74 RID: 52596
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x0400CD75 RID: 52597
		[Nullable(2)]
		private FCollisionProfileName _CollisionProfileName;

		// Token: 0x0400CD76 RID: 52598
		internal static int __PropertyOffset_WaterStaticMeshNormal;

		// Token: 0x0400CD77 RID: 52599
		internal static int __PropertyOffset_WaterNormal;

		// Token: 0x0400CD78 RID: 52600
		internal static int __PropertyOffset_BodySetup;
	}
}
