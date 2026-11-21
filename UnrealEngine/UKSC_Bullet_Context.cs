using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000563 RID: 1379
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Bullet_Context")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Bullet_Context : UObject, IUnrealUObject, IUnrealObject, IBulletContext, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06007DBA RID: 32186 RVA: 0x000BA6E5 File Offset: 0x000B88E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Bullet_Context._ClassPtr;
		}

		// Token: 0x06007DBB RID: 32187 RVA: 0x000BA6F1 File Offset: 0x000B88F1
		int IBulletContext.InterfaceOffset()
		{
			return UKSC_Bullet_Context.__InterfaceOffset_IBulletContext;
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x000BA6F8 File Offset: 0x000B88F8
		public UKSC_Bullet_Context() : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet_Context.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x000BA720 File Offset: 0x000B8920
		[NullableContext(1)]
		public UKSC_Bullet_Context(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Bullet_Context.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06007DBE RID: 32190 RVA: 0x000BA753 File Offset: 0x000B8953
		// (set) Token: 0x06007DBF RID: 32191 RVA: 0x000BA767 File Offset: 0x000B8967
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

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x000BA77C File Offset: 0x000B897C
		// (set) Token: 0x06007DC1 RID: 32193 RVA: 0x000BA790 File Offset: 0x000B8990
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

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x000BA7A5 File Offset: 0x000B89A5
		// (set) Token: 0x06007DC3 RID: 32195 RVA: 0x000BA7B5 File Offset: 0x000B89B5
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

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x000BA7C6 File Offset: 0x000B89C6
		// (set) Token: 0x06007DC5 RID: 32197 RVA: 0x000BA7DA File Offset: 0x000B89DA
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

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x000BA7EF File Offset: 0x000B89EF
		// (set) Token: 0x06007DC7 RID: 32199 RVA: 0x000BA803 File Offset: 0x000B8A03
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

		// Token: 0x06007DC8 RID: 32200 RVA: 0x000BA818 File Offset: 0x000B8A18
		static UKSC_Bullet_Context()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Bullet_Context");
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x000BA826 File Offset: 0x000B8A26
		protected UKSC_Bullet_Context(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036CA RID: 14026
		internal static int __InterfaceOffset_IBulletContext;

		// Token: 0x040036CB RID: 14027
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Bullet_Context";

		// Token: 0x040036CC RID: 14028
		private static IntPtr _ClassPtr;

		// Token: 0x040036CD RID: 14029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036CE RID: 14030
		internal static int __PropertyOffset_Owner;

		// Token: 0x040036CF RID: 14031
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x040036D0 RID: 14032
		internal static int __PropertyOffset_SkillTargetEntityId;

		// Token: 0x040036D1 RID: 14033
		internal static int __PropertyOffset_SkillTargetLocation;

		// Token: 0x040036D2 RID: 14034
		internal static int __PropertyOffset_OwnerBulletDataTable;
	}
}
