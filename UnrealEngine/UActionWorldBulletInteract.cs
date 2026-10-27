using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171D RID: 5917
	[UnrealObjectPath("/Script/KuroBullet.ActionWorldBulletInteract")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UActionWorldBulletInteract : UBulletOnHitAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601553D RID: 87357 RVA: 0x001F5907 File Offset: 0x001F3B07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionWorldBulletInteract._ClassPtr;
		}

		// Token: 0x0601553E RID: 87358 RVA: 0x001F5914 File Offset: 0x001F3B14
		public UActionWorldBulletInteract() : this(BuiltinUtils.AllocNativeUObject(UActionWorldBulletInteract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601553F RID: 87359 RVA: 0x001F593C File Offset: 0x001F3B3C
		[NullableContext(1)]
		public UActionWorldBulletInteract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionWorldBulletInteract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005442 RID: 21570
		// (get) Token: 0x06015540 RID: 87360 RVA: 0x001F596F File Offset: 0x001F3B6F
		// (set) Token: 0x06015541 RID: 87361 RVA: 0x001F5983 File Offset: 0x001F3B83
		[Nullable(2)]
		public unsafe UKuroBulletLogicDataWorldBulletInteract LogicData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletLogicDataWorldBulletInteract>(base.NativePtr / (IntPtr)sizeof(void*) + UActionWorldBulletInteract.__PropertyOffset_LogicData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActionWorldBulletInteract.__PropertyOffset_LogicData, value);
			}
		}

		// Token: 0x06015542 RID: 87362 RVA: 0x001F5998 File Offset: 0x001F3B98
		static UActionWorldBulletInteract()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionWorldBulletInteract");
		}

		// Token: 0x06015543 RID: 87363 RVA: 0x001F59A6 File Offset: 0x001F3BA6
		protected UActionWorldBulletInteract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA00 RID: 47616
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionWorldBulletInteract";

		// Token: 0x0400BA01 RID: 47617
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA02 RID: 47618
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA03 RID: 47619
		internal static int __PropertyOffset_LogicData;
	}
}
