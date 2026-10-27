using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014A RID: 330
	[UnrealObjectPath("/Script/AIModule.BTDecorator_TagCooldown")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UBTDecorator_TagCooldown : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016CE RID: 5838 RVA: 0x000219E5 File Offset: 0x0001FBE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_TagCooldown._ClassPtr;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000219F4 File Offset: 0x0001FBF4
		public UBTDecorator_TagCooldown() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_TagCooldown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00021A1C File Offset: 0x0001FC1C
		[NullableContext(1)]
		public UBTDecorator_TagCooldown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_TagCooldown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00021A4F File Offset: 0x0001FC4F
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x00021A63 File Offset: 0x0001FC63
		public unsafe FGameplayTag CooldownTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_CooldownTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_CooldownTag) = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00021A78 File Offset: 0x0001FC78
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00021A88 File Offset: 0x0001FC88
		public unsafe float CooldownDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_CooldownDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_CooldownDuration) = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00021A99 File Offset: 0x0001FC99
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00021AA9 File Offset: 0x0001FCA9
		public unsafe bool bAddToExistingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_bAddToExistingDuration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_bAddToExistingDuration) = (value ? 1 : 0);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00021ABA File Offset: 0x0001FCBA
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00021ACA File Offset: 0x0001FCCA
		public unsafe bool bActivatesCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_bActivatesCooldown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_TagCooldown.__PropertyOffset_bActivatesCooldown) = (value ? 1 : 0);
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00021ADB File Offset: 0x0001FCDB
		static UBTDecorator_TagCooldown()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_TagCooldown");
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00021AE9 File Offset: 0x0001FCE9
		protected UBTDecorator_TagCooldown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000554 RID: 1364
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_TagCooldown";

		// Token: 0x04000555 RID: 1365
		private static IntPtr _ClassPtr;

		// Token: 0x04000556 RID: 1366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000557 RID: 1367
		internal static int __PropertyOffset_CooldownTag;

		// Token: 0x04000558 RID: 1368
		internal static int __PropertyOffset_CooldownDuration;

		// Token: 0x04000559 RID: 1369
		internal static int __PropertyOffset_bAddToExistingDuration;

		// Token: 0x0400055A RID: 1370
		internal static int __PropertyOffset_bActivatesCooldown;
	}
}
