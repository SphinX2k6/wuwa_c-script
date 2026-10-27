using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E12 RID: 7698
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_PlayerHeadUiHandle")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_PlayerHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D602 RID: 120322 RVA: 0x002B5D1A File Offset: 0x002B3F1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_PlayerHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601D603 RID: 120323 RVA: 0x002B5D26 File Offset: 0x002B3F26
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_PlayerHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601D604 RID: 120324 RVA: 0x002B5D30 File Offset: 0x002B3F30
		public UKSC_PlayerHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_PlayerHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D605 RID: 120325 RVA: 0x002B5D58 File Offset: 0x002B3F58
		[NullableContext(1)]
		public UKSC_PlayerHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_PlayerHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D606 RID: 120326 RVA: 0x002B5D8B File Offset: 0x002B3F8B
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_PlayerHeadUiHandle.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601D607 RID: 120327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601D608 RID: 120328 RVA: 0x002B5D9A File Offset: 0x002B3F9A
		static UKSC_PlayerHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_PlayerHeadUiHandle");
		}

		// Token: 0x0601D609 RID: 120329 RVA: 0x002B5DA8 File Offset: 0x002B3FA8
		protected UKSC_PlayerHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEEC RID: 65260
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x0400FEED RID: 65261
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_PlayerHeadUiHandle";

		// Token: 0x0400FEEE RID: 65262
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEEF RID: 65263
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
