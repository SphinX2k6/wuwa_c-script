using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D41 RID: 7489
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Bullet_Context")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Bullet_Context : UObject, IUnrealUObject, IUnrealObject, IBulletContext, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601CAF9 RID: 117497 RVA: 0x002A6816 File Offset: 0x002A4A16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Bullet_Context._ClassPtr;
		}

		// Token: 0x0601CAFA RID: 117498 RVA: 0x002A6822 File Offset: 0x002A4A22
		int IBulletContext.InterfaceOffset()
		{
			return UKSC_Bullet_Context.__InterfaceOffset_IBulletContext;
		}

		// Token: 0x0601CAFB RID: 117499 RVA: 0x002A682C File Offset: 0x002A4A2C
		public UKSC_Bullet_Context() : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet_Context.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAFC RID: 117500 RVA: 0x002A6854 File Offset: 0x002A4A54
		[NullableContext(1)]
		public UKSC_Bullet_Context(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet_Context.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007361 RID: 29537
		// (get) Token: 0x0601CAFD RID: 117501 RVA: 0x002A6887 File Offset: 0x002A4A87
		// (set) Token: 0x0601CAFE RID: 117502 RVA: 0x002A689B File Offset: 0x002A4A9B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKSC_Entity> Owner
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_Owner);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_Owner) = value;
			}
		}

		// Token: 0x17007362 RID: 29538
		// (get) Token: 0x0601CAFF RID: 117503 RVA: 0x002A68B0 File Offset: 0x002A4AB0
		// (set) Token: 0x0601CB00 RID: 117504 RVA: 0x002A68C4 File Offset: 0x002A4AC4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKSC_Entity> SkillTarget
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTarget);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTarget) = value;
			}
		}

		// Token: 0x17007363 RID: 29539
		// (get) Token: 0x0601CB01 RID: 117505 RVA: 0x002A68D9 File Offset: 0x002A4AD9
		// (set) Token: 0x0601CB02 RID: 117506 RVA: 0x002A68E9 File Offset: 0x002A4AE9
		public unsafe int SkillTargetEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTargetEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTargetEntityId) = value;
			}
		}

		// Token: 0x17007364 RID: 29540
		// (get) Token: 0x0601CB03 RID: 117507 RVA: 0x002A68FA File Offset: 0x002A4AFA
		// (set) Token: 0x0601CB04 RID: 117508 RVA: 0x002A690E File Offset: 0x002A4B0E
		public unsafe FVectorDouble SkillTargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Bullet_Context.__PropertyOffset_SkillTargetLocation) = value;
			}
		}

		// Token: 0x17007365 RID: 29541
		// (get) Token: 0x0601CB05 RID: 117509 RVA: 0x002A6923 File Offset: 0x002A4B23
		// (set) Token: 0x0601CB06 RID: 117510 RVA: 0x002A6937 File Offset: 0x002A4B37
		[Nullable(2)]
		public unsafe UDataTable OwnerBulletDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet_Context.__PropertyOffset_OwnerBulletDataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Bullet_Context.__PropertyOffset_OwnerBulletDataTable, value);
			}
		}

		// Token: 0x0601CB07 RID: 117511 RVA: 0x002A694C File Offset: 0x002A4B4C
		static UKSC_Bullet_Context()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Bullet_Context");
		}

		// Token: 0x0601CB08 RID: 117512 RVA: 0x002A695A File Offset: 0x002A4B5A
		protected UKSC_Bullet_Context(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8D6 RID: 63702
		internal static int __InterfaceOffset_IBulletContext;

		// Token: 0x0400F8D7 RID: 63703
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Bullet_Context";

		// Token: 0x0400F8D8 RID: 63704
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8D9 RID: 63705
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8DA RID: 63706
		internal static int __PropertyOffset_Owner;

		// Token: 0x0400F8DB RID: 63707
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x0400F8DC RID: 63708
		internal static int __PropertyOffset_SkillTargetEntityId;

		// Token: 0x0400F8DD RID: 63709
		internal static int __PropertyOffset_SkillTargetLocation;

		// Token: 0x0400F8DE RID: 63710
		internal static int __PropertyOffset_OwnerBulletDataTable;
	}
}
