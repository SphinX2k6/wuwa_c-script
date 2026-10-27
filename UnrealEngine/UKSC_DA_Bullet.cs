using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D88 RID: 7560
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Bullet")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKSC_DA_Bullet : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF21 RID: 118561 RVA: 0x002AC8F7 File Offset: 0x002AAAF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Bullet._ClassPtr;
		}

		// Token: 0x0601CF22 RID: 118562 RVA: 0x002AC904 File Offset: 0x002AAB04
		public UKSC_DA_Bullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Bullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF23 RID: 118563 RVA: 0x002AC92C File Offset: 0x002AAB2C
		[NullableContext(1)]
		public UKSC_DA_Bullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Bullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074C1 RID: 29889
		// (get) Token: 0x0601CF24 RID: 118564 RVA: 0x002AC95F File Offset: 0x002AAB5F
		// (set) Token: 0x0601CF25 RID: 118565 RVA: 0x002AC973 File Offset: 0x002AAB73
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Bullet> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x170074C2 RID: 29890
		// (get) Token: 0x0601CF26 RID: 118566 RVA: 0x002AC988 File Offset: 0x002AAB88
		// (set) Token: 0x0601CF27 RID: 118567 RVA: 0x002AC99C File Offset: 0x002AAB9C
		[Nullable(2)]
		public unsafe UKSC_DA_FX FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_FX>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Bullet.__PropertyOffset_FX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Bullet.__PropertyOffset_FX, value);
			}
		}

		// Token: 0x170074C3 RID: 29891
		// (get) Token: 0x0601CF28 RID: 118568 RVA: 0x002AC9B1 File Offset: 0x002AABB1
		// (set) Token: 0x0601CF29 RID: 118569 RVA: 0x002AC9C1 File Offset: 0x002AABC1
		public unsafe EKSC_FXUpdateType UpdateType
		{
			get
			{
				return (EKSC_FXUpdateType)(*(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_UpdateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_UpdateType) = (byte)value;
			}
		}

		// Token: 0x170074C4 RID: 29892
		// (get) Token: 0x0601CF2A RID: 118570 RVA: 0x002AC9D2 File Offset: 0x002AABD2
		// (set) Token: 0x0601CF2B RID: 118571 RVA: 0x002AC9E2 File Offset: 0x002AABE2
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Bullet.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x0601CF2C RID: 118572 RVA: 0x002AC9F3 File Offset: 0x002AABF3
		static UKSC_DA_Bullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Bullet");
		}

		// Token: 0x0601CF2D RID: 118573 RVA: 0x002ACA01 File Offset: 0x002AAC01
		protected UKSC_DA_Bullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB58 RID: 64344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Bullet";

		// Token: 0x0400FB59 RID: 64345
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB5A RID: 64346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB5B RID: 64347
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FB5C RID: 64348
		internal static int __PropertyOffset_FX;

		// Token: 0x0400FB5D RID: 64349
		internal static int __PropertyOffset_UpdateType;

		// Token: 0x0400FB5E RID: 64350
		internal static int __PropertyOffset_Speed;
	}
}
