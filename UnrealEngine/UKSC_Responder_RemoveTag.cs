using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E24 RID: 7716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_RemoveTag")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_Responder_RemoveTag : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6A9 RID: 120489 RVA: 0x002B7358 File Offset: 0x002B5558
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_RemoveTag._ClassPtr;
		}

		// Token: 0x0601D6AA RID: 120490 RVA: 0x002B7364 File Offset: 0x002B5564
		public UKSC_Responder_RemoveTag() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_RemoveTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6AB RID: 120491 RVA: 0x002B738C File Offset: 0x002B558C
		public UKSC_Responder_RemoveTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_RemoveTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007697 RID: 30359
		// (get) Token: 0x0601D6AC RID: 120492 RVA: 0x002B73C0 File Offset: 0x002B55C0
		// (set) Token: 0x0601D6AD RID: 120493 RVA: 0x002B73F9 File Offset: 0x002B55F9
		public FGameplayTagContainer TagsToRemove
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagsToRemove) == null)
				{
					result = (this._TagsToRemove = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_Responder_RemoveTag.__PropertyOffset_TagsToRemove, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Responder_RemoveTag.__PropertyOffset_TagsToRemove, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D6AE RID: 120494 RVA: 0x002B741A File Offset: 0x002B561A
		static UKSC_Responder_RemoveTag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_RemoveTag");
		}

		// Token: 0x0601D6AF RID: 120495 RVA: 0x002B7428 File Offset: 0x002B5628
		protected UKSC_Responder_RemoveTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF36 RID: 65334
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_RemoveTag";

		// Token: 0x0400FF37 RID: 65335
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF38 RID: 65336
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF39 RID: 65337
		internal static int __PropertyOffset_TagsToRemove;

		// Token: 0x0400FF3A RID: 65338
		[Nullable(2)]
		private FGameplayTagContainer _TagsToRemove;
	}
}
