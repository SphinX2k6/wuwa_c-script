using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D82 RID: 7554
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_StopAction")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_StopAction : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CED1 RID: 118481 RVA: 0x002AC17F File Offset: 0x002AA37F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_StopAction._ClassPtr;
		}

		// Token: 0x0601CED2 RID: 118482 RVA: 0x002AC18C File Offset: 0x002AA38C
		public UKSC_DA_Buff_StopAction() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_StopAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CED3 RID: 118483 RVA: 0x002AC1B4 File Offset: 0x002AA3B4
		[NullableContext(1)]
		public UKSC_DA_Buff_StopAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_StopAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074A8 RID: 29864
		// (get) Token: 0x0601CED4 RID: 118484 RVA: 0x002AC1E7 File Offset: 0x002AA3E7
		// (set) Token: 0x0601CED5 RID: 118485 RVA: 0x002AC1F7 File Offset: 0x002AA3F7
		public unsafe EKSC_Buff_StopAction_ActionType ActionType
		{
			get
			{
				return (EKSC_Buff_StopAction_ActionType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_StopAction.__PropertyOffset_ActionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_StopAction.__PropertyOffset_ActionType) = (byte)value;
			}
		}

		// Token: 0x0601CED6 RID: 118486 RVA: 0x002AC208 File Offset: 0x002AA408
		static UKSC_DA_Buff_StopAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_StopAction");
		}

		// Token: 0x0601CED7 RID: 118487 RVA: 0x002AC216 File Offset: 0x002AA416
		protected UKSC_DA_Buff_StopAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB27 RID: 64295
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_StopAction";

		// Token: 0x0400FB28 RID: 64296
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB29 RID: 64297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB2A RID: 64298
		internal static int __PropertyOffset_ActionType;
	}
}
