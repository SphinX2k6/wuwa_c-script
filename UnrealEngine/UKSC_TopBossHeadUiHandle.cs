using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E5B RID: 7771
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_TopBossHeadUiHandle")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_TopBossHeadUiHandle : UKSC_BaseObject, IUnrealUObject, IUnrealObject, IKSC_HeadUiHandle, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D96C RID: 121196 RVA: 0x002BAFCA File Offset: 0x002B91CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_TopBossHeadUiHandle._ClassPtr;
		}

		// Token: 0x0601D96D RID: 121197 RVA: 0x002BAFD6 File Offset: 0x002B91D6
		int IKSC_HeadUiHandle.InterfaceOffset()
		{
			return UKSC_TopBossHeadUiHandle.__InterfaceOffset_IKSC_HeadUiHandle;
		}

		// Token: 0x0601D96E RID: 121198 RVA: 0x002BAFE0 File Offset: 0x002B91E0
		public UKSC_TopBossHeadUiHandle() : this(BuiltinUtils.AllocNativeUObject(UKSC_TopBossHeadUiHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D96F RID: 121199 RVA: 0x002BB008 File Offset: 0x002B9208
		[NullableContext(1)]
		public UKSC_TopBossHeadUiHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_TopBossHeadUiHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D970 RID: 121200 RVA: 0x002BB03B File Offset: 0x002B923B
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_TopBossHeadUiHandle.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601D971 RID: 121201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601D972 RID: 121202 RVA: 0x002BB04A File Offset: 0x002B924A
		static UKSC_TopBossHeadUiHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_TopBossHeadUiHandle");
		}

		// Token: 0x0601D973 RID: 121203 RVA: 0x002BB058 File Offset: 0x002B9258
		protected UKSC_TopBossHeadUiHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100A2 RID: 65698
		internal static int __InterfaceOffset_IKSC_HeadUiHandle;

		// Token: 0x040100A3 RID: 65699
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_TopBossHeadUiHandle";

		// Token: 0x040100A4 RID: 65700
		private static IntPtr _ClassPtr;

		// Token: 0x040100A5 RID: 65701
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
