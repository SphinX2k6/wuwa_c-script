using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE4 RID: 7652
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_EventListener")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UKSC_EventListener : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D3D4 RID: 119764 RVA: 0x002B2E2C File Offset: 0x002B102C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_EventListener._ClassPtr;
		}

		// Token: 0x1700760D RID: 30221
		// (get) Token: 0x0601D3D5 RID: 119765 RVA: 0x002B2E38 File Offset: 0x002B1038
		// (set) Token: 0x0601D3D6 RID: 119766 RVA: 0x002B2E48 File Offset: 0x002B1048
		public unsafe EKSC_ListenerTarget ListenTarget
		{
			get
			{
				return (EKSC_ListenerTarget)(*(base.NativePtr + (IntPtr)UKSC_EventListener.__PropertyOffset_ListenTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_EventListener.__PropertyOffset_ListenTarget) = (byte)value;
			}
		}

		// Token: 0x1700760E RID: 30222
		// (get) Token: 0x0601D3D7 RID: 119767 RVA: 0x002B2E59 File Offset: 0x002B1059
		// (set) Token: 0x0601D3D8 RID: 119768 RVA: 0x002B2E69 File Offset: 0x002B1069
		public unsafe bool bCheckOnBeginBuff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_EventListener.__PropertyOffset_bCheckOnBeginBuff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_EventListener.__PropertyOffset_bCheckOnBeginBuff) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700760F RID: 30223
		// (get) Token: 0x0601D3D9 RID: 119769 RVA: 0x002B2E7A File Offset: 0x002B107A
		// (set) Token: 0x0601D3DA RID: 119770 RVA: 0x002B2E8E File Offset: 0x002B108E
		[Nullable(2)]
		public unsafe UKSC_Buff_EventHandler Handler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Buff_EventHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_EventListener.__PropertyOffset_Handler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_EventListener.__PropertyOffset_Handler, value);
			}
		}

		// Token: 0x0601D3DB RID: 119771 RVA: 0x002B2EA3 File Offset: 0x002B10A3
		static UKSC_EventListener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_EventListener");
		}

		// Token: 0x0601D3DC RID: 119772 RVA: 0x002B2EB4 File Offset: 0x002B10B4
		protected UKSC_EventListener() : this(BuiltinUtils.AllocNativeUObject(UKSC_EventListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D3DD RID: 119773 RVA: 0x002B2EDC File Offset: 0x002B10DC
		protected UKSC_EventListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDDC RID: 64988
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_EventListener";

		// Token: 0x0400FDDD RID: 64989
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDDE RID: 64990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDDF RID: 64991
		internal static int __PropertyOffset_ListenTarget;

		// Token: 0x0400FDE0 RID: 64992
		internal static int __PropertyOffset_bCheckOnBeginBuff;

		// Token: 0x0400FDE1 RID: 64993
		internal static int __PropertyOffset_Handler;
	}
}
