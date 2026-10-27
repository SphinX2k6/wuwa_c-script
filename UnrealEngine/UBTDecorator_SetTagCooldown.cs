using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000149 RID: 329
	[UnrealObjectPath("/Script/AIModule.BTDecorator_SetTagCooldown")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UBTDecorator_SetTagCooldown : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x000218FA File Offset: 0x0001FAFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_SetTagCooldown._ClassPtr;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00021908 File Offset: 0x0001FB08
		public UBTDecorator_SetTagCooldown() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_SetTagCooldown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00021930 File Offset: 0x0001FB30
		[NullableContext(1)]
		public UBTDecorator_SetTagCooldown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_SetTagCooldown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00021963 File Offset: 0x0001FB63
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x00021977 File Offset: 0x0001FB77
		public unsafe FGameplayTag CooldownTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_CooldownTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_CooldownTag) = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0002198C File Offset: 0x0001FB8C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0002199C File Offset: 0x0001FB9C
		public unsafe float CooldownDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_CooldownDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_CooldownDuration) = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000219AD File Offset: 0x0001FBAD
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x000219BD File Offset: 0x0001FBBD
		public unsafe bool bAddToExistingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_bAddToExistingDuration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_SetTagCooldown.__PropertyOffset_bAddToExistingDuration) = (value ? 1 : 0);
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000219CE File Offset: 0x0001FBCE
		static UBTDecorator_SetTagCooldown()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_SetTagCooldown");
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000219DC File Offset: 0x0001FBDC
		protected UBTDecorator_SetTagCooldown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400054E RID: 1358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_SetTagCooldown";

		// Token: 0x0400054F RID: 1359
		private static IntPtr _ClassPtr;

		// Token: 0x04000550 RID: 1360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000551 RID: 1361
		internal static int __PropertyOffset_CooldownTag;

		// Token: 0x04000552 RID: 1362
		internal static int __PropertyOffset_CooldownDuration;

		// Token: 0x04000553 RID: 1363
		internal static int __PropertyOffset_bAddToExistingDuration;
	}
}
