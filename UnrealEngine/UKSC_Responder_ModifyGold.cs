using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E22 RID: 7714
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_ModifyGold")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Responder_ModifyGold : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D699 RID: 120473 RVA: 0x002B71ED File Offset: 0x002B53ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_ModifyGold._ClassPtr;
		}

		// Token: 0x0601D69A RID: 120474 RVA: 0x002B71FC File Offset: 0x002B53FC
		public UKSC_Responder_ModifyGold() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_ModifyGold.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D69B RID: 120475 RVA: 0x002B7224 File Offset: 0x002B5424
		[NullableContext(1)]
		public UKSC_Responder_ModifyGold(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_ModifyGold.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007694 RID: 30356
		// (get) Token: 0x0601D69C RID: 120476 RVA: 0x002B7257 File Offset: 0x002B5457
		// (set) Token: 0x0601D69D RID: 120477 RVA: 0x002B7267 File Offset: 0x002B5467
		public unsafe int GoldValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_ModifyGold.__PropertyOffset_GoldValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_ModifyGold.__PropertyOffset_GoldValue) = value;
			}
		}

		// Token: 0x0601D69E RID: 120478 RVA: 0x002B7278 File Offset: 0x002B5478
		static UKSC_Responder_ModifyGold()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_ModifyGold");
		}

		// Token: 0x0601D69F RID: 120479 RVA: 0x002B7286 File Offset: 0x002B5486
		protected UKSC_Responder_ModifyGold(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF2D RID: 65325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_ModifyGold";

		// Token: 0x0400FF2E RID: 65326
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF2F RID: 65327
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF30 RID: 65328
		internal static int __PropertyOffset_GoldValue;
	}
}
