using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200073A RID: 1850
	[UnrealObjectPath("/Script/LGUI.UITransitionBase")]
	[UnrealStructLayout(744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 744)]
	public abstract class UUITransitionBase : UUISelectableTransitionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A146 RID: 41286 RVA: 0x000EE7FB File Offset: 0x000EC9FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITransitionBase._ClassPtr;
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x000EE807 File Offset: 0x000ECA07
		static UUITransitionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITransitionBase");
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x000EE818 File Offset: 0x000ECA18
		protected UUITransitionBase() : this(BuiltinUtils.AllocNativeUObject(UUITransitionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x000EE840 File Offset: 0x000ECA40
		protected UUITransitionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004516 RID: 17686
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITransitionBase";

		// Token: 0x04004517 RID: 17687
		private static IntPtr _ClassPtr;

		// Token: 0x04004518 RID: 17688
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
