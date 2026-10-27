using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D62 RID: 7522
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Invisible")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_Invisible : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCFD RID: 118013 RVA: 0x002A9665 File Offset: 0x002A7865
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Invisible._ClassPtr;
		}

		// Token: 0x0601CCFE RID: 118014 RVA: 0x002A9674 File Offset: 0x002A7874
		public UKSC_DA_Buff_Invisible() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Invisible.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCFF RID: 118015 RVA: 0x002A969C File Offset: 0x002A789C
		public UKSC_DA_Buff_Invisible(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Invisible.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700740D RID: 29709
		// (get) Token: 0x0601CD00 RID: 118016 RVA: 0x002A96D0 File Offset: 0x002A78D0
		// (set) Token: 0x0601CD01 RID: 118017 RVA: 0x002A9709 File Offset: 0x002A7909
		public FGameplayTagContainer InvisibleTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._InvisibleTags) == null)
				{
					result = (this._InvisibleTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_Invisible.__PropertyOffset_InvisibleTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Invisible.__PropertyOffset_InvisibleTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CD02 RID: 118018 RVA: 0x002A972A File Offset: 0x002A792A
		static UKSC_DA_Buff_Invisible()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Invisible");
		}

		// Token: 0x0601CD03 RID: 118019 RVA: 0x002A9738 File Offset: 0x002A7938
		protected UKSC_DA_Buff_Invisible(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA07 RID: 64007
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Invisible";

		// Token: 0x0400FA08 RID: 64008
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA09 RID: 64009
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA0A RID: 64010
		internal static int __PropertyOffset_InvisibleTags;

		// Token: 0x0400FA0B RID: 64011
		[Nullable(2)]
		private FGameplayTagContainer _InvisibleTags;
	}
}
