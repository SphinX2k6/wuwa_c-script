using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000163 RID: 355
	[UnrealObjectPath("/Script/AIModule.BTTask_SetTagCooldown")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UBTTask_SetTagCooldown : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x0002394D File Offset: 0x00021B4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_SetTagCooldown._ClassPtr;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0002395C File Offset: 0x00021B5C
		public UBTTask_SetTagCooldown() : this(BuiltinUtils.AllocNativeUObject(UBTTask_SetTagCooldown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00023984 File Offset: 0x00021B84
		[NullableContext(1)]
		public UBTTask_SetTagCooldown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_SetTagCooldown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x000239B7 File Offset: 0x00021BB7
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x000239CB File Offset: 0x00021BCB
		public unsafe FGameplayTag CooldownTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_CooldownTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_CooldownTag) = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x000239E0 File Offset: 0x00021BE0
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x000239F0 File Offset: 0x00021BF0
		public unsafe bool bAddToExistingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_bAddToExistingDuration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_bAddToExistingDuration) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00023A01 File Offset: 0x00021C01
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x00023A11 File Offset: 0x00021C11
		public unsafe float CooldownDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_CooldownDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_SetTagCooldown.__PropertyOffset_CooldownDuration) = value;
			}
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00023A22 File Offset: 0x00021C22
		static UBTTask_SetTagCooldown()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_SetTagCooldown");
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00023A30 File Offset: 0x00021C30
		protected UBTTask_SetTagCooldown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005FE RID: 1534
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_SetTagCooldown";

		// Token: 0x040005FF RID: 1535
		private static IntPtr _ClassPtr;

		// Token: 0x04000600 RID: 1536
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000601 RID: 1537
		internal static int __PropertyOffset_CooldownTag;

		// Token: 0x04000602 RID: 1538
		internal static int __PropertyOffset_bAddToExistingDuration;

		// Token: 0x04000603 RID: 1539
		internal static int __PropertyOffset_CooldownDuration;
	}
}
