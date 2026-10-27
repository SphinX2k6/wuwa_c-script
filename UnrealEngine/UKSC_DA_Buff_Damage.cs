using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5B RID: 7515
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Damage")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKSC_DA_Buff_Damage : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC9C RID: 117916 RVA: 0x002A8C6B File Offset: 0x002A6E6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Damage._ClassPtr;
		}

		// Token: 0x0601CC9D RID: 117917 RVA: 0x002A8C78 File Offset: 0x002A6E78
		public UKSC_DA_Buff_Damage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Damage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC9E RID: 117918 RVA: 0x002A8CA0 File Offset: 0x002A6EA0
		public UKSC_DA_Buff_Damage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Damage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073EE RID: 29678
		// (get) Token: 0x0601CC9F RID: 117919 RVA: 0x002A8CD3 File Offset: 0x002A6ED3
		// (set) Token: 0x0601CCA0 RID: 117920 RVA: 0x002A8CE3 File Offset: 0x002A6EE3
		public unsafe int Probability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_Probability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_Probability) = value;
			}
		}

		// Token: 0x170073EF RID: 29679
		// (get) Token: 0x0601CCA1 RID: 117921 RVA: 0x002A8CF4 File Offset: 0x002A6EF4
		// (set) Token: 0x0601CCA2 RID: 117922 RVA: 0x002A8D2D File Offset: 0x002A6F2D
		public FKSCDamage Damage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._Damage) == null)
				{
					result = (this._Damage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_Damage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_Damage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073F0 RID: 29680
		// (get) Token: 0x0601CCA3 RID: 117923 RVA: 0x002A8D4E File Offset: 0x002A6F4E
		// (set) Token: 0x0601CCA4 RID: 117924 RVA: 0x002A8D5E File Offset: 0x002A6F5E
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x170073F1 RID: 29681
		// (get) Token: 0x0601CCA5 RID: 117925 RVA: 0x002A8D6F File Offset: 0x002A6F6F
		// (set) Token: 0x0601CCA6 RID: 117926 RVA: 0x002A8D7F File Offset: 0x002A6F7F
		public unsafe bool bCheckSpTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_bCheckSpTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_bCheckSpTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x170073F2 RID: 29682
		// (get) Token: 0x0601CCA7 RID: 117927 RVA: 0x002A8D90 File Offset: 0x002A6F90
		// (set) Token: 0x0601CCA8 RID: 117928 RVA: 0x002A8DC9 File Offset: 0x002A6FC9
		public FKSC_TagFilter SpTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._SpTagFilter) == null)
				{
					result = (this._SpTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073F3 RID: 29683
		// (get) Token: 0x0601CCA9 RID: 117929 RVA: 0x002A8DEC File Offset: 0x002A6FEC
		// (set) Token: 0x0601CCAA RID: 117930 RVA: 0x002A8E25 File Offset: 0x002A7025
		public FKSCDamage SpDamage
		{
			get
			{
				base.FastCheckIsValid();
				FKSCDamage result;
				if ((result = this._SpDamage) == null)
				{
					result = (this._SpDamage = new FKSCDamage(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpDamage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSCDamage.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpDamage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170073F4 RID: 29684
		// (get) Token: 0x0601CCAB RID: 117931 RVA: 0x002A8E46 File Offset: 0x002A7046
		// (set) Token: 0x0601CCAC RID: 117932 RVA: 0x002A8E56 File Offset: 0x002A7056
		public unsafe int SpDamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpDamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Damage.__PropertyOffset_SpDamageID) = value;
			}
		}

		// Token: 0x0601CCAD RID: 117933 RVA: 0x002A8E67 File Offset: 0x002A7067
		static UKSC_DA_Buff_Damage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Damage");
		}

		// Token: 0x0601CCAE RID: 117934 RVA: 0x002A8E75 File Offset: 0x002A7075
		protected UKSC_DA_Buff_Damage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9C7 RID: 63943
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Damage";

		// Token: 0x0400F9C8 RID: 63944
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9C9 RID: 63945
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9CA RID: 63946
		internal static int __PropertyOffset_Probability;

		// Token: 0x0400F9CB RID: 63947
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400F9CC RID: 63948
		[Nullable(2)]
		private FKSCDamage _Damage;

		// Token: 0x0400F9CD RID: 63949
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400F9CE RID: 63950
		internal static int __PropertyOffset_bCheckSpTarget;

		// Token: 0x0400F9CF RID: 63951
		internal static int __PropertyOffset_SpTagFilter;

		// Token: 0x0400F9D0 RID: 63952
		[Nullable(2)]
		private FKSC_TagFilter _SpTagFilter;

		// Token: 0x0400F9D1 RID: 63953
		internal static int __PropertyOffset_SpDamage;

		// Token: 0x0400F9D2 RID: 63954
		[Nullable(2)]
		private FKSCDamage _SpDamage;

		// Token: 0x0400F9D3 RID: 63955
		internal static int __PropertyOffset_SpDamageID;
	}
}
