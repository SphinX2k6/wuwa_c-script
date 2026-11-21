using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DB RID: 731
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BTTask_RunBehaviorWithDelegate")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UBTTask_RunBehaviorWithDelegate : UBTTask_RunBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004ED2 RID: 20178 RVA: 0x0006E1CD File Offset: 0x0006C3CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunBehaviorWithDelegate._ClassPtr;
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public UBTTask_RunBehaviorWithDelegate() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorWithDelegate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0006E204 File Offset: 0x0006C404
		public UBTTask_RunBehaviorWithDelegate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorWithDelegate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x0006E238 File Offset: 0x0006C438
		// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x0006E271 File Offset: 0x0006C471
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

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x0006E294 File Offset: 0x0006C494
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x0006E2CD File Offset: 0x0006C4CD
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

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0006E2EE File Offset: 0x0006C4EE
		static UBTTask_RunBehaviorWithDelegate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTTask_RunBehaviorWithDelegate");
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x0006E2FC File Offset: 0x0006C4FC
		protected UBTTask_RunBehaviorWithDelegate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F87 RID: 8071
		public new const string __ObjectPath = "/Script/KuroAI.BTTask_RunBehaviorWithDelegate";

		// Token: 0x04001F88 RID: 8072
		private static IntPtr _ClassPtr;

		// Token: 0x04001F89 RID: 8073
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F8A RID: 8074
		internal static int __PropertyOffset_OnAfterExecuteDelegate;

		// Token: 0x04001F8B RID: 8075
		[Nullable(2)]
		private FOnAfterExecuteRunBehaviorDynamic _OnAfterExecuteDelegate;

		// Token: 0x04001F8C RID: 8076
		internal static int __PropertyOffset_OnSubtreeDeactivatedDelegate;

		// Token: 0x04001F8D RID: 8077
		[Nullable(2)]
		private FOnSubtreeDeactivatedDynamic _OnSubtreeDeactivatedDelegate;
	}
}
