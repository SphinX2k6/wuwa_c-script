using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F7 RID: 5111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UGameplayTask_TimeLimitedExecution : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A9E RID: 76446 RVA: 0x001B77EC File Offset: 0x001B59EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTask_TimeLimitedExecution._ClassPtr;
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x001B77F8 File Offset: 0x001B59F8
		public UGameplayTask_TimeLimitedExecution() : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_TimeLimitedExecution.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x001B7820 File Offset: 0x001B5A20
		public UGameplayTask_TimeLimitedExecution(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTask_TimeLimitedExecution.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x06012AA1 RID: 76449 RVA: 0x001B7854 File Offset: 0x001B5A54
		// (set) Token: 0x06012AA2 RID: 76450 RVA: 0x001B788D File Offset: 0x001B5A8D
		public FTaskFinishDelegate OnFinished
		{
			get
			{
				base.FastCheckIsValid();
				FTaskFinishDelegate result;
				if ((result = this._OnFinished) == null)
				{
					result = (this._OnFinished = new FTaskFinishDelegate(base.NativePtr + (IntPtr)UGameplayTask_TimeLimitedExecution.__PropertyOffset_OnFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_TimeLimitedExecution.__PropertyOffset_OnFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x06012AA3 RID: 76451 RVA: 0x001B78B0 File Offset: 0x001B5AB0
		// (set) Token: 0x06012AA4 RID: 76452 RVA: 0x001B78E9 File Offset: 0x001B5AE9
		public FTaskFinishDelegate OnTimeExpired
		{
			get
			{
				base.FastCheckIsValid();
				FTaskFinishDelegate result;
				if ((result = this._OnTimeExpired) == null)
				{
					result = (this._OnTimeExpired = new FTaskFinishDelegate(base.NativePtr + (IntPtr)UGameplayTask_TimeLimitedExecution.__PropertyOffset_OnTimeExpired, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameplayTask_TimeLimitedExecution.__PropertyOffset_OnTimeExpired, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012AA5 RID: 76453 RVA: 0x001B790A File Offset: 0x001B5B0A
		static UGameplayTask_TimeLimitedExecution()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTask_TimeLimitedExecution");
		}

		// Token: 0x06012AA6 RID: 76454 RVA: 0x001B7918 File Offset: 0x001B5B18
		protected UGameplayTask_TimeLimitedExecution(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F98 RID: 40856
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTask_TimeLimitedExecution";

		// Token: 0x04009F99 RID: 40857
		private static IntPtr _ClassPtr;

		// Token: 0x04009F9A RID: 40858
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F9B RID: 40859
		public static IntPtr __TaskFinishDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04009F9C RID: 40860
		internal static int __PropertyOffset_OnFinished;

		// Token: 0x04009F9D RID: 40861
		[Nullable(2)]
		private FTaskFinishDelegate _OnFinished;

		// Token: 0x04009F9E RID: 40862
		internal static int __PropertyOffset_OnTimeExpired;

		// Token: 0x04009F9F RID: 40863
		[Nullable(2)]
		private FTaskFinishDelegate _OnTimeExpired;
	}
}
