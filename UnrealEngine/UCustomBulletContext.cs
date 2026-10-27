using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001721 RID: 5921
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.CustomBulletContext")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UCustomBulletContext : UObject, IUnrealUObject, IUnrealObject, IBulletContext, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06015585 RID: 87429 RVA: 0x001F5DF6 File Offset: 0x001F3FF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCustomBulletContext._ClassPtr;
		}

		// Token: 0x06015586 RID: 87430 RVA: 0x001F5E02 File Offset: 0x001F4002
		int IBulletContext.InterfaceOffset()
		{
			return UCustomBulletContext.__InterfaceOffset_IBulletContext;
		}

		// Token: 0x06015587 RID: 87431 RVA: 0x001F5E0C File Offset: 0x001F400C
		public UCustomBulletContext() : this(BuiltinUtils.AllocNativeUObject(UCustomBulletContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015588 RID: 87432 RVA: 0x001F5E34 File Offset: 0x001F4034
		[NullableContext(1)]
		public UCustomBulletContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCustomBulletContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x06015589 RID: 87433 RVA: 0x001F5E67 File Offset: 0x001F4067
		// (set) Token: 0x0601558A RID: 87434 RVA: 0x001F5E7B File Offset: 0x001F407B
		public unsafe AActor OwnerActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_OwnerActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_OwnerActor, value);
			}
		}

		// Token: 0x1700544E RID: 21582
		// (get) Token: 0x0601558B RID: 87435 RVA: 0x001F5E90 File Offset: 0x001F4090
		// (set) Token: 0x0601558C RID: 87436 RVA: 0x001F5EA4 File Offset: 0x001F40A4
		public unsafe AActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_TargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x1700544F RID: 21583
		// (get) Token: 0x0601558D RID: 87437 RVA: 0x001F5EB9 File Offset: 0x001F40B9
		// (set) Token: 0x0601558E RID: 87438 RVA: 0x001F5ECD File Offset: 0x001F40CD
		public unsafe FName TargetSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_TargetSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_TargetSocket) = value;
			}
		}

		// Token: 0x17005450 RID: 21584
		// (get) Token: 0x0601558F RID: 87439 RVA: 0x001F5EE2 File Offset: 0x001F40E2
		// (set) Token: 0x06015590 RID: 87440 RVA: 0x001F5EF6 File Offset: 0x001F40F6
		public unsafe FVectorDouble TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x17005451 RID: 21585
		// (get) Token: 0x06015591 RID: 87441 RVA: 0x001F5F0B File Offset: 0x001F410B
		// (set) Token: 0x06015592 RID: 87442 RVA: 0x001F5F1F File Offset: 0x001F411F
		public unsafe UDataTable BulletDataTable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_BulletDataTable);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCustomBulletContext.__PropertyOffset_BulletDataTable, value);
			}
		}

		// Token: 0x17005452 RID: 21586
		// (get) Token: 0x06015593 RID: 87443 RVA: 0x001F5F34 File Offset: 0x001F4134
		// (set) Token: 0x06015594 RID: 87444 RVA: 0x001F5F44 File Offset: 0x001F4144
		public unsafe int Camp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_Camp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_Camp) = value;
			}
		}

		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06015595 RID: 87445 RVA: 0x001F5F55 File Offset: 0x001F4155
		// (set) Token: 0x06015596 RID: 87446 RVA: 0x001F5F65 File Offset: 0x001F4165
		public unsafe int OwnerEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_OwnerEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCustomBulletContext.__PropertyOffset_OwnerEntityId) = value;
			}
		}

		// Token: 0x06015597 RID: 87447 RVA: 0x001F5F76 File Offset: 0x001F4176
		static UCustomBulletContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.CustomBulletContext");
		}

		// Token: 0x06015598 RID: 87448 RVA: 0x001F5F84 File Offset: 0x001F4184
		protected UCustomBulletContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA17 RID: 47639
		internal static int __InterfaceOffset_IBulletContext;

		// Token: 0x0400BA18 RID: 47640
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.CustomBulletContext";

		// Token: 0x0400BA19 RID: 47641
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA1A RID: 47642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA1B RID: 47643
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x0400BA1C RID: 47644
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0400BA1D RID: 47645
		internal static int __PropertyOffset_TargetSocket;

		// Token: 0x0400BA1E RID: 47646
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x0400BA1F RID: 47647
		internal static int __PropertyOffset_BulletDataTable;

		// Token: 0x0400BA20 RID: 47648
		internal static int __PropertyOffset_Camp;

		// Token: 0x0400BA21 RID: 47649
		internal static int __PropertyOffset_OwnerEntityId;
	}
}
