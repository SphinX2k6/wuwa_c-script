using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000592 RID: 1426
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SkillComp")]
	[UnrealStructLayout(2120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2120)]
	public class UKSC_SkillComp : UKSC_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008113 RID: 33043 RVA: 0x000BE7F5 File Offset: 0x000BC9F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_SkillComp._ClassPtr;
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x000BE804 File Offset: 0x000BCA04
		public UKSC_SkillComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_SkillComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x000BE82C File Offset: 0x000BCA2C
		public UKSC_SkillComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_SkillComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x000BE85F File Offset: 0x000BCA5F
		// (set) Token: 0x06008117 RID: 33047 RVA: 0x000BE873 File Offset: 0x000BCA73
		[Nullable(2)]
		public unsafe UKSC_AttrSet AttrSet_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_AttrSet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_AttrSet_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_SkillComp.__PropertyOffset_AttrSet_, value);
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06008118 RID: 33048 RVA: 0x000BE888 File Offset: 0x000BCA88
		// (set) Token: 0x06008119 RID: 33049 RVA: 0x000BE8C1 File Offset: 0x000BCAC1
		public TMap<UKSC_DA_Skill, UKSC_Skill> SkillMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKSC_DA_Skill, UKSC_Skill> result;
				if ((result = this._SkillMap) == null)
				{
					result = (this._SkillMap = new TMap<UKSC_DA_Skill, UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_SkillMap, this));
				}
				return result;
			}
			set
			{
				this.SkillMap.CopyAssign(value);
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x000BE8D0 File Offset: 0x000BCAD0
		// (set) Token: 0x0600811B RID: 33051 RVA: 0x000BE909 File Offset: 0x000BCB09
		public TArray<UKSC_Skill> Skills_
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_Skill> result;
				if ((result = this._Skills_) == null)
				{
					result = (this._Skills_ = new TArray<UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_Skills_, this));
				}
				return result;
			}
			set
			{
				this.Skills_.CopyAssign(value);
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600811C RID: 33052 RVA: 0x000BE918 File Offset: 0x000BCB18
		// (set) Token: 0x0600811D RID: 33053 RVA: 0x000BE951 File Offset: 0x000BCB51
		public TSet<UKSC_Skill> ToActiveSkills_
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UKSC_Skill> result;
				if ((result = this._ToActiveSkills_) == null)
				{
					result = (this._ToActiveSkills_ = new TSet<UKSC_Skill>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ToActiveSkills_, this));
				}
				return result;
			}
			set
			{
				this.ToActiveSkills_.CopyAssign(value);
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600811E RID: 33054 RVA: 0x000BE960 File Offset: 0x000BCB60
		// (set) Token: 0x0600811F RID: 33055 RVA: 0x000BE999 File Offset: 0x000BCB99
		public FOnKSCBuffChange OnKSCBuffChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnKSCBuffChange result;
				if ((result = this._OnKSCBuffChange) == null)
				{
					result = (this._OnKSCBuffChange = new FOnKSCBuffChange(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_OnKSCBuffChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_OnKSCBuffChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x000BE9BC File Offset: 0x000BCBBC
		// (set) Token: 0x06008121 RID: 33057 RVA: 0x000BE9F5 File Offset: 0x000BCBF5
		public TSet<UObject> StopCastSkill
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._StopCastSkill) == null)
				{
					result = (this._StopCastSkill = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_StopCastSkill, this));
				}
				return result;
			}
			set
			{
				this.StopCastSkill.CopyAssign(value);
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x000BEA04 File Offset: 0x000BCC04
		// (set) Token: 0x06008123 RID: 33059 RVA: 0x000BEA3D File Offset: 0x000BCC3D
		public TMap<UObject, FGameplayTagContainer> InvisibleTagMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, FGameplayTagContainer> result;
				if ((result = this._InvisibleTagMap) == null)
				{
					result = (this._InvisibleTagMap = new TMap<UObject, FGameplayTagContainer>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_InvisibleTagMap, this));
				}
				return result;
			}
			set
			{
				this.InvisibleTagMap.CopyAssign(value);
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06008124 RID: 33060 RVA: 0x000BEA4C File Offset: 0x000BCC4C
		// (set) Token: 0x06008125 RID: 33061 RVA: 0x000BEA85 File Offset: 0x000BCC85
		public TSet<UObject> UnattackableSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._UnattackableSet) == null)
				{
					result = (this._UnattackableSet = new TSet<UObject>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_UnattackableSet, this));
				}
				return result;
			}
			set
			{
				this.UnattackableSet.CopyAssign(value);
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06008126 RID: 33062 RVA: 0x000BEA94 File Offset: 0x000BCC94
		// (set) Token: 0x06008127 RID: 33063 RVA: 0x000BEACD File Offset: 0x000BCCCD
		public TMap<UObject, FGameplayTagContainer> ImmuneBuffMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, FGameplayTagContainer> result;
				if ((result = this._ImmuneBuffMap) == null)
				{
					result = (this._ImmuneBuffMap = new TMap<UObject, FGameplayTagContainer>(base.NativePtr + (IntPtr)UKSC_SkillComp.__PropertyOffset_ImmuneBuffMap, this));
				}
				return result;
			}
			set
			{
				this.ImmuneBuffMap.CopyAssign(value);
			}
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x000BEADB File Offset: 0x000BCCDB
		public float GetSkillCollDown()
		{
			return UKSC_SkillComp.__GetSkillCollDown_Internal(base.NativePtr);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
		public void GetAllBuffs([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UKSC_DA_Buff, int> OutBuffs)
		{
			UKSC_SkillComp.__GetAllBuffs_Internal(base.NativePtr, (OutBuffs ?? new TMap<UKSC_DA_Buff, int>()).NativeMapPtr);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x000BEB05 File Offset: 0x000BCD05
		public void Debug_GetAllBuffInfo([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutBuffs)
		{
			UKSC_SkillComp.__Debug_GetAllBuffInfo_Internal(base.NativePtr, (OutBuffs ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0600812B RID: 33067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkillCollDown_Internal(IntPtr @this);

		// Token: 0x0600812C RID: 33068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllBuffs_Internal(IntPtr @this, IntPtr OutBuffs);

		// Token: 0x0600812D RID: 33069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Debug_GetAllBuffInfo_Internal(IntPtr @this, IntPtr OutBuffs);

		// Token: 0x0600812E RID: 33070 RVA: 0x000BEB22 File Offset: 0x000BCD22
		static UKSC_SkillComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_SkillComp");
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x000BEB30 File Offset: 0x000BCD30
		protected UKSC_SkillComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003853 RID: 14419
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SkillComp";

		// Token: 0x04003854 RID: 14420
		private static IntPtr _ClassPtr;

		// Token: 0x04003855 RID: 14421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003856 RID: 14422
		internal static int __PropertyOffset_AttrSet_;

		// Token: 0x04003857 RID: 14423
		internal static int __PropertyOffset_SkillMap;

		// Token: 0x04003858 RID: 14424
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UKSC_DA_Skill, UKSC_Skill> _SkillMap;

		// Token: 0x04003859 RID: 14425
		internal static int __PropertyOffset_Skills_;

		// Token: 0x0400385A RID: 14426
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_Skill> _Skills_;

		// Token: 0x0400385B RID: 14427
		internal static int __PropertyOffset_ToActiveSkills_;

		// Token: 0x0400385C RID: 14428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKSC_Skill> _ToActiveSkills_;

		// Token: 0x0400385D RID: 14429
		internal static int __PropertyOffset_OnKSCBuffChange;

		// Token: 0x0400385E RID: 14430
		[Nullable(2)]
		private FOnKSCBuffChange _OnKSCBuffChange;

		// Token: 0x0400385F RID: 14431
		internal static int __PropertyOffset_StopCastSkill;

		// Token: 0x04003860 RID: 14432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _StopCastSkill;

		// Token: 0x04003861 RID: 14433
		internal static int __PropertyOffset_InvisibleTagMap;

		// Token: 0x04003862 RID: 14434
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, FGameplayTagContainer> _InvisibleTagMap;

		// Token: 0x04003863 RID: 14435
		internal static int __PropertyOffset_UnattackableSet;

		// Token: 0x04003864 RID: 14436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _UnattackableSet;

		// Token: 0x04003865 RID: 14437
		internal static int __PropertyOffset_ImmuneBuffMap;

		// Token: 0x04003866 RID: 14438
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UObject, FGameplayTagContainer> _ImmuneBuffMap;
	}
}
