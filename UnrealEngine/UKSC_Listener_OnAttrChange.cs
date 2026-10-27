using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF2 RID: 7666
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnAttrChange")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_Listener_OnAttrChange : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4CA RID: 120010 RVA: 0x002B4220 File Offset: 0x002B2420
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnAttrChange._ClassPtr;
		}

		// Token: 0x0601D4CB RID: 120011 RVA: 0x002B422C File Offset: 0x002B242C
		public UKSC_Listener_OnAttrChange() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnAttrChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4CC RID: 120012 RVA: 0x002B4254 File Offset: 0x002B2454
		public UKSC_Listener_OnAttrChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnAttrChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007654 RID: 30292
		// (get) Token: 0x0601D4CD RID: 120013 RVA: 0x002B4288 File Offset: 0x002B2488
		// (set) Token: 0x0601D4CE RID: 120014 RVA: 0x002B42C1 File Offset: 0x002B24C1
		public FKSC_ListenAttrEventBuff ListenConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_ListenAttrEventBuff result;
				if ((result = this._ListenConfig) == null)
				{
					result = (this._ListenConfig = new FKSC_ListenAttrEventBuff(base.NativePtr + (IntPtr)UKSC_Listener_OnAttrChange.__PropertyOffset_ListenConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_ListenAttrEventBuff.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Listener_OnAttrChange.__PropertyOffset_ListenConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D4CF RID: 120015 RVA: 0x002B42E2 File Offset: 0x002B24E2
		public void OnAttrChangeCallback(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Listener_OnAttrChange.__OnAttrChangeCallback_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601D4D0 RID: 120016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChangeCallback_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601D4D1 RID: 120017 RVA: 0x002B42F1 File Offset: 0x002B24F1
		static UKSC_Listener_OnAttrChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnAttrChange");
		}

		// Token: 0x0601D4D2 RID: 120018 RVA: 0x002B42FF File Offset: 0x002B24FF
		protected UKSC_Listener_OnAttrChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE5A RID: 65114
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnAttrChange";

		// Token: 0x0400FE5B RID: 65115
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE5C RID: 65116
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE5D RID: 65117
		internal static int __PropertyOffset_ListenConfig;

		// Token: 0x0400FE5E RID: 65118
		[Nullable(2)]
		private FKSC_ListenAttrEventBuff _ListenConfig;
	}
}
