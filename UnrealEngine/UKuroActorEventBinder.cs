using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CA RID: 1482
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroActorEventBinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroActorEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083BB RID: 33723 RVA: 0x000C3128 File Offset: 0x000C1328
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorEventBinder._ClassPtr;
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x000C3134 File Offset: 0x000C1334
		public UKuroActorEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroActorEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x000C315C File Offset: 0x000C135C
		public UKuroActorEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x000C3190 File Offset: 0x000C1390
		// (set) Token: 0x060083BF RID: 33727 RVA: 0x000C31C9 File Offset: 0x000C13C9
		public FOnActorEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FOnActorEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FOnActorEventTrigger(base.NativePtr + (IntPtr)UKuroActorEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x000C31EA File Offset: 0x000C13EA
		static UKuroActorEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorEventBinder");
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x000C31F8 File Offset: 0x000C13F8
		protected UKuroActorEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400397F RID: 14719
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorEventBinder";

		// Token: 0x04003980 RID: 14720
		private static IntPtr _ClassPtr;

		// Token: 0x04003981 RID: 14721
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003982 RID: 14722
		internal static int __PropertyOffset_Callback;

		// Token: 0x04003983 RID: 14723
		[Nullable(2)]
		private FOnActorEventTrigger _Callback;
	}
}
