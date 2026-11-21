using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000336 RID: 822
	[UnrealObjectPath("/Script/KuroBullet.WorldBulletComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UWorldBulletComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005583 RID: 21891 RVA: 0x00077939 File Offset: 0x00075B39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldBulletComponent._ClassPtr;
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00077948 File Offset: 0x00075B48
		public UWorldBulletComponent() : this(BuiltinUtils.AllocNativeUObject(UWorldBulletComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00077970 File Offset: 0x00075B70
		[NullableContext(1)]
		public UWorldBulletComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldBulletComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06005586 RID: 21894 RVA: 0x000779A3 File Offset: 0x00075BA3
		// (set) Token: 0x06005587 RID: 21895 RVA: 0x000779B3 File Offset: 0x00075BB3
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x000779C4 File Offset: 0x00075BC4
		// (set) Token: 0x06005589 RID: 21897 RVA: 0x000779D4 File Offset: 0x00075BD4
		public unsafe EWorldBulletType WorldBulletType
		{
			get
			{
				return (EWorldBulletType)(*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_WorldBulletType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldBulletComponent.__PropertyOffset_WorldBulletType) = (byte)value;
			}
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x000779E5 File Offset: 0x00075BE5
		static UWorldBulletComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.WorldBulletComponent");
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x000779F3 File Offset: 0x00075BF3
		protected UWorldBulletComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022F1 RID: 8945
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.WorldBulletComponent";

		// Token: 0x040022F2 RID: 8946
		private static IntPtr _ClassPtr;

		// Token: 0x040022F3 RID: 8947
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022F4 RID: 8948
		internal static int __PropertyOffset_bEnable;

		// Token: 0x040022F5 RID: 8949
		internal static int __PropertyOffset_WorldBulletType;
	}
}
