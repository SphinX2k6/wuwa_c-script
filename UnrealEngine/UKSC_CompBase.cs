using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D42 RID: 7490
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_CompBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKSC_CompBase : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB09 RID: 117513 RVA: 0x002A6963 File Offset: 0x002A4B63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_CompBase._ClassPtr;
		}

		// Token: 0x0601CB0A RID: 117514 RVA: 0x002A696F File Offset: 0x002A4B6F
		static UKSC_CompBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_CompBase");
		}

		// Token: 0x0601CB0B RID: 117515 RVA: 0x002A6980 File Offset: 0x002A4B80
		protected UKSC_CompBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_CompBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB0C RID: 117516 RVA: 0x002A69A8 File Offset: 0x002A4BA8
		protected UKSC_CompBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8DF RID: 63711
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_CompBase";

		// Token: 0x0400F8E0 RID: 63712
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8E1 RID: 63713
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
