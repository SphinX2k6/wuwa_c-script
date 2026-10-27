using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015FB RID: 5627
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BTTask_RunBehaviorWithDelegate")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UBTTask_RunBehaviorWithDelegate : UBTTask_RunBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014411 RID: 82961 RVA: 0x001DBD53 File Offset: 0x001D9F53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunBehaviorWithDelegate._ClassPtr;
		}

		// Token: 0x06014412 RID: 82962 RVA: 0x001DBD60 File Offset: 0x001D9F60
		public UBTTask_RunBehaviorWithDelegate() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorWithDelegate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014413 RID: 82963 RVA: 0x001DBD88 File Offset: 0x001D9F88
		public UBTTask_RunBehaviorWithDelegate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorWithDelegate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06014414 RID: 82964 RVA: 0x001DBDBC File Offset: 0x001D9FBC
		// (set) Token: 0x06014415 RID: 82965 RVA: 0x001DBDF5 File Offset: 0x001D9FF5
		public FOnAfterExecuteRunBehaviorDynamic OnAfterExecuteDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnAfterExecuteRunBehaviorDynamic result;
				if ((result = this._OnAfterExecuteDelegate) == null)
				{
					result = (this._OnAfterExecuteDelegate = new FOnAfterExecuteRunBehaviorDynamic(base.NativePtr + (IntPtr)UBTTask_RunBehaviorWithDelegate.__PropertyOffset_OnAfterExecuteDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBTTask_RunBehaviorWithDelegate.__PropertyOffset_OnAfterExecuteDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06014416 RID: 82966 RVA: 0x001DBE18 File Offset: 0x001DA018
		// (set) Token: 0x06014417 RID: 82967 RVA: 0x001DBE51 File Offset: 0x001DA051
		public FOnSubtreeDeactivatedDynamic OnSubtreeDeactivatedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnSubtreeDeactivatedDynamic result;
				if ((result = this._OnSubtreeDeactivatedDelegate) == null)
				{
					result = (this._OnSubtreeDeactivatedDelegate = new FOnSubtreeDeactivatedDynamic(base.NativePtr + (IntPtr)UBTTask_RunBehaviorWithDelegate.__PropertyOffset_OnSubtreeDeactivatedDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UBTTask_RunBehaviorWithDelegate.__PropertyOffset_OnSubtreeDeactivatedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06014418 RID: 82968 RVA: 0x001DBE72 File Offset: 0x001DA072
		static UBTTask_RunBehaviorWithDelegate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTTask_RunBehaviorWithDelegate");
		}

		// Token: 0x06014419 RID: 82969 RVA: 0x001DBE80 File Offset: 0x001DA080
		protected UBTTask_RunBehaviorWithDelegate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B04C RID: 45132
		public new const string __ObjectPath = "/Script/KuroAI.BTTask_RunBehaviorWithDelegate";

		// Token: 0x0400B04D RID: 45133
		private static IntPtr _ClassPtr;

		// Token: 0x0400B04E RID: 45134
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B04F RID: 45135
		internal static int __PropertyOffset_OnAfterExecuteDelegate;

		// Token: 0x0400B050 RID: 45136
		[Nullable(2)]
		private FOnAfterExecuteRunBehaviorDynamic _OnAfterExecuteDelegate;

		// Token: 0x0400B051 RID: 45137
		internal static int __PropertyOffset_OnSubtreeDeactivatedDelegate;

		// Token: 0x0400B052 RID: 45138
		[Nullable(2)]
		private FOnSubtreeDeactivatedDynamic _OnSubtreeDeactivatedDelegate;
	}
}
