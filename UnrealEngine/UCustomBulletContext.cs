using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000332 RID: 818
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.CustomBulletContext")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UCustomBulletContext : UObject, IUnrealUObject, IUnrealObject, IBulletContext, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06005554 RID: 21844 RVA: 0x0007759D File Offset: 0x0007579D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCustomBulletContext._ClassPtr;
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x000775A9 File Offset: 0x000757A9
		int IBulletContext.InterfaceOffset()
		{
			return UCustomBulletContext.__InterfaceOffset_IBulletContext;
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x000775B0 File Offset: 0x000757B0
		public UCustomBulletContext() : this(BuiltinUtils.AllocNativeUObject(UCustomBulletContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x000775D8 File Offset: 0x000757D8
		[NullableContext(1)]
		public UCustomBulletContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCustomBulletContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x0007760B File Offset: 0x0007580B
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x0007761F File Offset: 0x0007581F
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x00077634 File Offset: 0x00075834
		// (set) Token: 0x0600555B RID: 21851 RVA: 0x00077648 File Offset: 0x00075848
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

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x0007765D File Offset: 0x0007585D
		// (set) Token: 0x0600555D RID: 21853 RVA: 0x00077671 File Offset: 0x00075871
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

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x00077686 File Offset: 0x00075886
		// (set) Token: 0x0600555F RID: 21855 RVA: 0x0007769A File Offset: 0x0007589A
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

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x000776AF File Offset: 0x000758AF
		// (set) Token: 0x06005561 RID: 21857 RVA: 0x000776C3 File Offset: 0x000758C3
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

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x000776D8 File Offset: 0x000758D8
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x000776E8 File Offset: 0x000758E8
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

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x000776F9 File Offset: 0x000758F9
		// (set) Token: 0x06005565 RID: 21861 RVA: 0x00077709 File Offset: 0x00075909
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

		// Token: 0x06005566 RID: 21862 RVA: 0x0007771A File Offset: 0x0007591A
		static UCustomBulletContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.CustomBulletContext");
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00077728 File Offset: 0x00075928
		protected UCustomBulletContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022D3 RID: 8915
		internal static int __InterfaceOffset_IBulletContext;

		// Token: 0x040022D4 RID: 8916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.CustomBulletContext";

		// Token: 0x040022D5 RID: 8917
		private static IntPtr _ClassPtr;

		// Token: 0x040022D6 RID: 8918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022D7 RID: 8919
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x040022D8 RID: 8920
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x040022D9 RID: 8921
		internal static int __PropertyOffset_TargetSocket;

		// Token: 0x040022DA RID: 8922
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x040022DB RID: 8923
		internal static int __PropertyOffset_BulletDataTable;

		// Token: 0x040022DC RID: 8924
		internal static int __PropertyOffset_Camp;

		// Token: 0x040022DD RID: 8925
		internal static int __PropertyOffset_OwnerEntityId;
	}
}
