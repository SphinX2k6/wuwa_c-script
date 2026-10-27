using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1E RID: 7710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_AddTag")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_Responder_AddTag : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D679 RID: 120441 RVA: 0x002B6EA2 File Offset: 0x002B50A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_AddTag._ClassPtr;
		}

		// Token: 0x0601D67A RID: 120442 RVA: 0x002B6EB0 File Offset: 0x002B50B0
		public UKSC_Responder_AddTag() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D67B RID: 120443 RVA: 0x002B6ED8 File Offset: 0x002B50D8
		public UKSC_Responder_AddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700768E RID: 30350
		// (get) Token: 0x0601D67C RID: 120444 RVA: 0x002B6F0C File Offset: 0x002B510C
		// (set) Token: 0x0601D67D RID: 120445 RVA: 0x002B6F45 File Offset: 0x002B5145
		public FGameplayTagContainer TagsToAdd
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagsToAdd) == null)
				{
					result = (this._TagsToAdd = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_Responder_AddTag.__PropertyOffset_TagsToAdd, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Responder_AddTag.__PropertyOffset_TagsToAdd, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D67E RID: 120446 RVA: 0x002B6F66 File Offset: 0x002B5166
		static UKSC_Responder_AddTag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_AddTag");
		}

		// Token: 0x0601D67F RID: 120447 RVA: 0x002B6F74 File Offset: 0x002B5174
		protected UKSC_Responder_AddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF19 RID: 65305
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_AddTag";

		// Token: 0x0400FF1A RID: 65306
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF1B RID: 65307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF1C RID: 65308
		internal static int __PropertyOffset_TagsToAdd;

		// Token: 0x0400FF1D RID: 65309
		[Nullable(2)]
		private FGameplayTagContainer _TagsToAdd;
	}
}
