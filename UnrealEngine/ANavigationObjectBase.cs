using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EDC RID: 3804
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavigationObjectBase")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public abstract class ANavigationObjectBase : AActor, IUnrealUObject, IUnrealObject, INavAgentInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600CE2F RID: 52783 RVA: 0x0012CD98 File Offset: 0x0012AF98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationObjectBase._ClassPtr;
		}

		// Token: 0x0600CE30 RID: 52784 RVA: 0x0012CDA4 File Offset: 0x0012AFA4
		int INavAgentInterface.InterfaceOffset()
		{
			return ANavigationObjectBase.__InterfaceOffset_INavAgentInterface;
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x0012CDAB File Offset: 0x0012AFAB
		// (set) Token: 0x0600CE32 RID: 52786 RVA: 0x0012CDBF File Offset: 0x0012AFBF
		public unsafe UCapsuleComponent CapsuleComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_CapsuleComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_CapsuleComponent, value);
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x0012CDD4 File Offset: 0x0012AFD4
		// (set) Token: 0x0600CE34 RID: 52788 RVA: 0x0012CDE8 File Offset: 0x0012AFE8
		public unsafe UBillboardComponent GoodSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_GoodSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_GoodSprite, value);
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600CE35 RID: 52789 RVA: 0x0012CDFD File Offset: 0x0012AFFD
		// (set) Token: 0x0600CE36 RID: 52790 RVA: 0x0012CE11 File Offset: 0x0012B011
		public unsafe UBillboardComponent BadSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_BadSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_BadSprite, value);
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600CE37 RID: 52791 RVA: 0x0012CE26 File Offset: 0x0012B026
		// (set) Token: 0x0600CE38 RID: 52792 RVA: 0x0012CE3F File Offset: 0x0012B03F
		public unsafe bool bIsPIEPlayerStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) & ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) = ((*(base.NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) & ~ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart) | (value ? ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart : 0));
			}
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x0012CE6F File Offset: 0x0012B06F
		static ANavigationObjectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationObjectBase");
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x0012CE80 File Offset: 0x0012B080
		protected ANavigationObjectBase() : this(BuiltinUtils.AllocNativeUObject(ANavigationObjectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x0012CEA8 File Offset: 0x0012B0A8
		protected ANavigationObjectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F2B RID: 28459
		internal static int __InterfaceOffset_INavAgentInterface;

		// Token: 0x04006F2C RID: 28460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationObjectBase";

		// Token: 0x04006F2D RID: 28461
		private static IntPtr _ClassPtr;

		// Token: 0x04006F2E RID: 28462
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F2F RID: 28463
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x04006F30 RID: 28464
		internal static int __PropertyOffset_GoodSprite;

		// Token: 0x04006F31 RID: 28465
		internal static int __PropertyOffset_BadSprite;

		// Token: 0x04006F32 RID: 28466
		internal static int __PropertyOffset_bIsPIEPlayerStart;

		// Token: 0x04006F33 RID: 28467
		internal static byte __PropertyMask_bIsPIEPlayerStart;
	}
}
