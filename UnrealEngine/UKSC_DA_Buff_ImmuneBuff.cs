using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D61 RID: 7521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ImmuneBuff")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_ImmuneBuff : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCF6 RID: 118006 RVA: 0x002A9589 File Offset: 0x002A7789
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ImmuneBuff._ClassPtr;
		}

		// Token: 0x0601CCF7 RID: 118007 RVA: 0x002A9598 File Offset: 0x002A7798
		public UKSC_DA_Buff_ImmuneBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ImmuneBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCF8 RID: 118008 RVA: 0x002A95C0 File Offset: 0x002A77C0
		public UKSC_DA_Buff_ImmuneBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ImmuneBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700740C RID: 29708
		// (get) Token: 0x0601CCF9 RID: 118009 RVA: 0x002A95F4 File Offset: 0x002A77F4
		// (set) Token: 0x0601CCFA RID: 118010 RVA: 0x002A962D File Offset: 0x002A782D
		public FGameplayTagContainer ImmuneBuffTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ImmuneBuffTags) == null)
				{
					result = (this._ImmuneBuffTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_ImmuneBuff.__PropertyOffset_ImmuneBuffTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ImmuneBuff.__PropertyOffset_ImmuneBuffTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CCFB RID: 118011 RVA: 0x002A964E File Offset: 0x002A784E
		static UKSC_DA_Buff_ImmuneBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ImmuneBuff");
		}

		// Token: 0x0601CCFC RID: 118012 RVA: 0x002A965C File Offset: 0x002A785C
		protected UKSC_DA_Buff_ImmuneBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA02 RID: 64002
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ImmuneBuff";

		// Token: 0x0400FA03 RID: 64003
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA04 RID: 64004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA05 RID: 64005
		internal static int __PropertyOffset_ImmuneBuffTags;

		// Token: 0x0400FA06 RID: 64006
		[Nullable(2)]
		private FGameplayTagContainer _ImmuneBuffTags;
	}
}
