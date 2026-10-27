using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D32 RID: 7474
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_RemoveBuffByTags")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_RemoveBuffByTags : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA7F RID: 117375 RVA: 0x002A5CCF File Offset: 0x002A3ECF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_RemoveBuffByTags._ClassPtr;
		}

		// Token: 0x0601CA80 RID: 117376 RVA: 0x002A5CDC File Offset: 0x002A3EDC
		public UKSC_Buff_RemoveBuffByTags() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_RemoveBuffByTags.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA81 RID: 117377 RVA: 0x002A5D04 File Offset: 0x002A3F04
		[NullableContext(1)]
		public UKSC_Buff_RemoveBuffByTags(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_RemoveBuffByTags.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734C RID: 29516
		// (get) Token: 0x0601CA82 RID: 117378 RVA: 0x002A5D37 File Offset: 0x002A3F37
		// (set) Token: 0x0601CA83 RID: 117379 RVA: 0x002A5D4B File Offset: 0x002A3F4B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_RemoveBuffByTags DaBuff_RemoveBuffByTag_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_RemoveBuffByTags>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_RemoveBuffByTags.__PropertyOffset_DaBuff_RemoveBuffByTag_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_RemoveBuffByTags.__PropertyOffset_DaBuff_RemoveBuffByTag_, value);
			}
		}

		// Token: 0x0601CA84 RID: 117380 RVA: 0x002A5D60 File Offset: 0x002A3F60
		static UKSC_Buff_RemoveBuffByTags()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_RemoveBuffByTags");
		}

		// Token: 0x0601CA85 RID: 117381 RVA: 0x002A5D6E File Offset: 0x002A3F6E
		protected UKSC_Buff_RemoveBuffByTags(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F890 RID: 63632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_RemoveBuffByTags";

		// Token: 0x0400F891 RID: 63633
		private static IntPtr _ClassPtr;

		// Token: 0x0400F892 RID: 63634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F893 RID: 63635
		internal static int __PropertyOffset_DaBuff_RemoveBuffByTag_;
	}
}
