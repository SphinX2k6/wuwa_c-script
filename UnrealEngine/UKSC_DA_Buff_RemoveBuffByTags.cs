using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7C RID: 7548
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_RemoveBuffByTags")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_RemoveBuffByTags : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE8C RID: 118412 RVA: 0x002ABB56 File Offset: 0x002A9D56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_RemoveBuffByTags._ClassPtr;
		}

		// Token: 0x0601CE8D RID: 118413 RVA: 0x002ABB64 File Offset: 0x002A9D64
		public UKSC_DA_Buff_RemoveBuffByTags() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_RemoveBuffByTags.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE8E RID: 118414 RVA: 0x002ABB8C File Offset: 0x002A9D8C
		public UKSC_DA_Buff_RemoveBuffByTags(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_RemoveBuffByTags.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007494 RID: 29844
		// (get) Token: 0x0601CE8F RID: 118415 RVA: 0x002ABBC0 File Offset: 0x002A9DC0
		// (set) Token: 0x0601CE90 RID: 118416 RVA: 0x002ABBF9 File Offset: 0x002A9DF9
		public FGameplayTagContainer ToCheckTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ToCheckTags) == null)
				{
					result = (this._ToCheckTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_RemoveBuffByTags.__PropertyOffset_ToCheckTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_RemoveBuffByTags.__PropertyOffset_ToCheckTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CE91 RID: 118417 RVA: 0x002ABC1A File Offset: 0x002A9E1A
		static UKSC_DA_Buff_RemoveBuffByTags()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_RemoveBuffByTags");
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x002ABC28 File Offset: 0x002A9E28
		protected UKSC_DA_Buff_RemoveBuffByTags(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAFD RID: 64253
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_RemoveBuffByTags";

		// Token: 0x0400FAFE RID: 64254
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAFF RID: 64255
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB00 RID: 64256
		internal static int __PropertyOffset_ToCheckTags;

		// Token: 0x0400FB01 RID: 64257
		[Nullable(2)]
		private FGameplayTagContainer _ToCheckTags;
	}
}
