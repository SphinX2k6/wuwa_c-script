using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E20 RID: 7712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_ClearTag")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_Responder_ClearTag : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D687 RID: 120455 RVA: 0x002B701F File Offset: 0x002B521F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_ClearTag._ClassPtr;
		}

		// Token: 0x0601D688 RID: 120456 RVA: 0x002B702C File Offset: 0x002B522C
		public UKSC_Responder_ClearTag() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_ClearTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D689 RID: 120457 RVA: 0x002B7054 File Offset: 0x002B5254
		public UKSC_Responder_ClearTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_ClearTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007690 RID: 30352
		// (get) Token: 0x0601D68A RID: 120458 RVA: 0x002B7088 File Offset: 0x002B5288
		// (set) Token: 0x0601D68B RID: 120459 RVA: 0x002B70C1 File Offset: 0x002B52C1
		public FGameplayTagContainer TagsToClear
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagsToClear) == null)
				{
					result = (this._TagsToClear = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_Responder_ClearTag.__PropertyOffset_TagsToClear, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Responder_ClearTag.__PropertyOffset_TagsToClear, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D68C RID: 120460 RVA: 0x002B70E2 File Offset: 0x002B52E2
		static UKSC_Responder_ClearTag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_ClearTag");
		}

		// Token: 0x0601D68D RID: 120461 RVA: 0x002B70F0 File Offset: 0x002B52F0
		protected UKSC_Responder_ClearTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF22 RID: 65314
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_ClearTag";

		// Token: 0x0400FF23 RID: 65315
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF24 RID: 65316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF25 RID: 65317
		internal static int __PropertyOffset_TagsToClear;

		// Token: 0x0400FF26 RID: 65318
		[Nullable(2)]
		private FGameplayTagContainer _TagsToClear;
	}
}
