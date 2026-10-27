using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000141 RID: 321
	[UnrealObjectPath("/Script/AIModule.BTDecorator_Cooldown")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBTDecorator_Cooldown : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x0002101D File Offset: 0x0001F21D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_Cooldown._ClassPtr;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0002102C File Offset: 0x0001F22C
		public UBTDecorator_Cooldown() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Cooldown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00021054 File Offset: 0x0001F254
		[NullableContext(1)]
		public UBTDecorator_Cooldown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Cooldown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00021087 File Offset: 0x0001F287
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00021097 File Offset: 0x0001F297
		public unsafe float CoolDownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Cooldown.__PropertyOffset_CoolDownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Cooldown.__PropertyOffset_CoolDownTime) = value;
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000210A8 File Offset: 0x0001F2A8
		static UBTDecorator_Cooldown()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_Cooldown");
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000210B6 File Offset: 0x0001F2B6
		protected UBTDecorator_Cooldown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000516 RID: 1302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_Cooldown";

		// Token: 0x04000517 RID: 1303
		private static IntPtr _ClassPtr;

		// Token: 0x04000518 RID: 1304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000519 RID: 1305
		internal static int __PropertyOffset_CoolDownTime;
	}
}
