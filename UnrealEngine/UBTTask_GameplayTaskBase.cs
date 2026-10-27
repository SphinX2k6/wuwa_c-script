using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000157 RID: 343
	[UnrealObjectPath("/Script/AIModule.BTTask_GameplayTaskBase")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UBTTask_GameplayTaskBase : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x00022B9B File Offset: 0x00020D9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_GameplayTaskBase._ClassPtr;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00022BA7 File Offset: 0x00020DA7
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00022BC0 File Offset: 0x00020DC0
		public unsafe bool bWaitForGameplayTask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_GameplayTaskBase.__PropertyOffset_bWaitForGameplayTask) & UBTTask_GameplayTaskBase.__PropertyMask_bWaitForGameplayTask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_GameplayTaskBase.__PropertyOffset_bWaitForGameplayTask) = ((*(base.NativePtr + (IntPtr)UBTTask_GameplayTaskBase.__PropertyOffset_bWaitForGameplayTask) & ~UBTTask_GameplayTaskBase.__PropertyMask_bWaitForGameplayTask) | (value ? UBTTask_GameplayTaskBase.__PropertyMask_bWaitForGameplayTask : 0));
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00022BF0 File Offset: 0x00020DF0
		static UBTTask_GameplayTaskBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_GameplayTaskBase");
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00022C00 File Offset: 0x00020E00
		protected UBTTask_GameplayTaskBase() : this(BuiltinUtils.AllocNativeUObject(UBTTask_GameplayTaskBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00022C28 File Offset: 0x00020E28
		protected UBTTask_GameplayTaskBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005A3 RID: 1443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_GameplayTaskBase";

		// Token: 0x040005A4 RID: 1444
		private static IntPtr _ClassPtr;

		// Token: 0x040005A5 RID: 1445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005A6 RID: 1446
		internal static int __PropertyOffset_bWaitForGameplayTask;

		// Token: 0x040005A7 RID: 1447
		internal static byte __PropertyMask_bWaitForGameplayTask;
	}
}
