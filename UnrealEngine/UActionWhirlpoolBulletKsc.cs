using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171C RID: 5916
	[UnrealObjectPath("/Script/KuroBullet.ActionWhirlpoolBulletKsc")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UActionWhirlpoolBulletKsc : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015536 RID: 87350 RVA: 0x001F585E File Offset: 0x001F3A5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionWhirlpoolBulletKsc._ClassPtr;
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x001F586C File Offset: 0x001F3A6C
		public UActionWhirlpoolBulletKsc() : this(BuiltinUtils.AllocNativeUObject(UActionWhirlpoolBulletKsc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x001F5894 File Offset: 0x001F3A94
		[NullableContext(1)]
		public UActionWhirlpoolBulletKsc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionWhirlpoolBulletKsc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x06015539 RID: 87353 RVA: 0x001F58C7 File Offset: 0x001F3AC7
		// (set) Token: 0x0601553A RID: 87354 RVA: 0x001F58DB File Offset: 0x001F3ADB
		[Nullable(2)]
		public unsafe UKuroBulletLogicDataWhirlpool LogicData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletLogicDataWhirlpool>(base.NativePtr / (IntPtr)sizeof(void*) + UActionWhirlpoolBulletKsc.__PropertyOffset_LogicData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActionWhirlpoolBulletKsc.__PropertyOffset_LogicData, value);
			}
		}

		// Token: 0x0601553B RID: 87355 RVA: 0x001F58F0 File Offset: 0x001F3AF0
		static UActionWhirlpoolBulletKsc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionWhirlpoolBulletKsc");
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x001F58FE File Offset: 0x001F3AFE
		protected UActionWhirlpoolBulletKsc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9FC RID: 47612
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionWhirlpoolBulletKsc";

		// Token: 0x0400B9FD RID: 47613
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9FE RID: 47614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B9FF RID: 47615
		internal static int __PropertyOffset_LogicData;
	}
}
