using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DFA RID: 7674
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnLifeChangeDown")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Listener_OnLifeChangeDown : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D51A RID: 120090 RVA: 0x002B49D3 File Offset: 0x002B2BD3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnLifeChangeDown._ClassPtr;
		}

		// Token: 0x0601D51B RID: 120091 RVA: 0x002B49E0 File Offset: 0x002B2BE0
		public UKSC_Listener_OnLifeChangeDown() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnLifeChangeDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D51C RID: 120092 RVA: 0x002B4A08 File Offset: 0x002B2C08
		[NullableContext(1)]
		public UKSC_Listener_OnLifeChangeDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnLifeChangeDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007660 RID: 30304
		// (get) Token: 0x0601D51D RID: 120093 RVA: 0x002B4A3B File Offset: 0x002B2C3B
		// (set) Token: 0x0601D51E RID: 120094 RVA: 0x002B4A4B File Offset: 0x002B2C4B
		public unsafe float ThresholdPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnLifeChangeDown.__PropertyOffset_ThresholdPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnLifeChangeDown.__PropertyOffset_ThresholdPercent) = value;
			}
		}

		// Token: 0x0601D51F RID: 120095 RVA: 0x002B4A5C File Offset: 0x002B2C5C
		public void OnAttrChangeCallback(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Listener_OnLifeChangeDown.__OnAttrChangeCallback_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601D520 RID: 120096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChangeCallback_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601D521 RID: 120097 RVA: 0x002B4A6B File Offset: 0x002B2C6B
		static UKSC_Listener_OnLifeChangeDown()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnLifeChangeDown");
		}

		// Token: 0x0601D522 RID: 120098 RVA: 0x002B4A79 File Offset: 0x002B2C79
		protected UKSC_Listener_OnLifeChangeDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE82 RID: 65154
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnLifeChangeDown";

		// Token: 0x0400FE83 RID: 65155
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE84 RID: 65156
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE85 RID: 65157
		internal static int __PropertyOffset_ThresholdPercent;
	}
}
