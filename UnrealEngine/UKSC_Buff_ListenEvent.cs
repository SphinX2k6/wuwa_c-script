using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1D RID: 7453
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ListenEvent")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKSC_Buff_ListenEvent : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9D8 RID: 117208 RVA: 0x002A4D44 File Offset: 0x002A2F44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ListenEvent._ClassPtr;
		}

		// Token: 0x0601C9D9 RID: 117209 RVA: 0x002A4D50 File Offset: 0x002A2F50
		public UKSC_Buff_ListenEvent() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ListenEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9DA RID: 117210 RVA: 0x002A4D78 File Offset: 0x002A2F78
		[NullableContext(1)]
		public UKSC_Buff_ListenEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ListenEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700732F RID: 29487
		// (get) Token: 0x0601C9DB RID: 117211 RVA: 0x002A4DAB File Offset: 0x002A2FAB
		// (set) Token: 0x0601C9DC RID: 117212 RVA: 0x002A4DBF File Offset: 0x002A2FBF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ListenEvent DaBuffListenEvent_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ListenEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenEvent.__PropertyOffset_DaBuffListenEvent_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenEvent.__PropertyOffset_DaBuffListenEvent_, value);
			}
		}

		// Token: 0x0601C9DD RID: 117213 RVA: 0x002A4DD4 File Offset: 0x002A2FD4
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_ListenEvent.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601C9DE RID: 117214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601C9DF RID: 117215 RVA: 0x002A4DE3 File Offset: 0x002A2FE3
		static UKSC_Buff_ListenEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ListenEvent");
		}

		// Token: 0x0601C9E0 RID: 117216 RVA: 0x002A4DF1 File Offset: 0x002A2FF1
		protected UKSC_Buff_ListenEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F831 RID: 63537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ListenEvent";

		// Token: 0x0400F832 RID: 63538
		private static IntPtr _ClassPtr;

		// Token: 0x0400F833 RID: 63539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F834 RID: 63540
		internal static int __PropertyOffset_DaBuffListenEvent_;
	}
}
