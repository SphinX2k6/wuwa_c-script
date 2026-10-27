using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C9 RID: 5833
	[UnrealObjectPath("/Script/KuroBulletCore.BulletKFCComponent")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UBulletKFCComponent : UObject, IUnrealUObject, IUnrealObject, IKuroFastCollisionInterface_Shape, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060151E3 RID: 86499 RVA: 0x001F0D3E File Offset: 0x001EEF3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletKFCComponent._ClassPtr;
		}

		// Token: 0x060151E4 RID: 86500 RVA: 0x001F0D4A File Offset: 0x001EEF4A
		int IKuroFastCollisionInterface_Shape.InterfaceOffset()
		{
			return UBulletKFCComponent.__InterfaceOffset_IKuroFastCollisionInterface_Shape;
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x001F0D54 File Offset: 0x001EEF54
		public UBulletKFCComponent() : this(BuiltinUtils.AllocNativeUObject(UBulletKFCComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151E6 RID: 86502 RVA: 0x001F0D7C File Offset: 0x001EEF7C
		[NullableContext(1)]
		public UBulletKFCComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletKFCComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005380 RID: 21376
		// (get) Token: 0x060151E7 RID: 86503 RVA: 0x001F0DAF File Offset: 0x001EEFAF
		// (set) Token: 0x060151E8 RID: 86504 RVA: 0x001F0DC3 File Offset: 0x001EEFC3
		[Nullable(2)]
		public unsafe UBulletEntity BulletEntity
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletEntity>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletKFCComponent.__PropertyOffset_BulletEntity);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletKFCComponent.__PropertyOffset_BulletEntity, value);
			}
		}

		// Token: 0x060151E9 RID: 86505 RVA: 0x001F0DD8 File Offset: 0x001EEFD8
		static UBulletKFCComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletKFCComponent");
		}

		// Token: 0x060151EA RID: 86506 RVA: 0x001F0DE6 File Offset: 0x001EEFE6
		protected UBulletKFCComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7E9 RID: 47081
		internal static int __InterfaceOffset_IKuroFastCollisionInterface_Shape;

		// Token: 0x0400B7EA RID: 47082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletKFCComponent";

		// Token: 0x0400B7EB RID: 47083
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7EC RID: 47084
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B7ED RID: 47085
		internal static int __PropertyOffset_BulletEntity;
	}
}
