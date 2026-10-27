using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DFD RID: 7677
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnWorldAttrChange")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_Listener_OnWorldAttrChange : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D547 RID: 120135 RVA: 0x002B4D6E File Offset: 0x002B2F6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnWorldAttrChange._ClassPtr;
		}

		// Token: 0x0601D548 RID: 120136 RVA: 0x002B4D7C File Offset: 0x002B2F7C
		public UKSC_Listener_OnWorldAttrChange() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnWorldAttrChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D549 RID: 120137 RVA: 0x002B4DA4 File Offset: 0x002B2FA4
		[NullableContext(1)]
		public UKSC_Listener_OnWorldAttrChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnWorldAttrChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700766A RID: 30314
		// (get) Token: 0x0601D54A RID: 120138 RVA: 0x002B4DD7 File Offset: 0x002B2FD7
		// (set) Token: 0x0601D54B RID: 120139 RVA: 0x002B4DE7 File Offset: 0x002B2FE7
		public unsafe EKSC_WorldAttrType ListenWorldAttr
		{
			get
			{
				return (EKSC_WorldAttrType)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnWorldAttrChange.__PropertyOffset_ListenWorldAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnWorldAttrChange.__PropertyOffset_ListenWorldAttr) = (byte)value;
			}
		}

		// Token: 0x0601D54C RID: 120140 RVA: 0x002B4DF8 File Offset: 0x002B2FF8
		public void OnWorldAttrChangeCallback(EKSC_WorldAttrType AttrType, int OldValue, int NewValue)
		{
			UKSC_Listener_OnWorldAttrChange.__OnWorldAttrChangeCallback_Internal(base.NativePtr, AttrType, OldValue, NewValue);
		}

		// Token: 0x0601D54D RID: 120141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWorldAttrChangeCallback_Internal(IntPtr @this, EKSC_WorldAttrType AttrType, int OldValue, int NewValue);

		// Token: 0x0601D54E RID: 120142 RVA: 0x002B4E08 File Offset: 0x002B3008
		static UKSC_Listener_OnWorldAttrChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnWorldAttrChange");
		}

		// Token: 0x0601D54F RID: 120143 RVA: 0x002B4E16 File Offset: 0x002B3016
		protected UKSC_Listener_OnWorldAttrChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE96 RID: 65174
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnWorldAttrChange";

		// Token: 0x0400FE97 RID: 65175
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE98 RID: 65176
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE99 RID: 65177
		internal static int __PropertyOffset_ListenWorldAttr;
	}
}
