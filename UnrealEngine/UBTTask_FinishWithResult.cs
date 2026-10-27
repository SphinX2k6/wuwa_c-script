using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000156 RID: 342
	[UnrealObjectPath("/Script/AIModule.BTTask_FinishWithResult")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_FinishWithResult : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600179A RID: 6042 RVA: 0x00022AF1 File Offset: 0x00020CF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_FinishWithResult._ClassPtr;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00022B00 File Offset: 0x00020D00
		public UBTTask_FinishWithResult() : this(BuiltinUtils.AllocNativeUObject(UBTTask_FinishWithResult.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00022B28 File Offset: 0x00020D28
		[NullableContext(1)]
		public UBTTask_FinishWithResult(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_FinishWithResult.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00022B5B File Offset: 0x00020D5B
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x00022B6F File Offset: 0x00020D6F
		public unsafe TEnumAsByte<EBTNodeResult> Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_FinishWithResult.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_FinishWithResult.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00022B84 File Offset: 0x00020D84
		static UBTTask_FinishWithResult()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_FinishWithResult");
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00022B92 File Offset: 0x00020D92
		protected UBTTask_FinishWithResult(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400059F RID: 1439
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_FinishWithResult";

		// Token: 0x040005A0 RID: 1440
		private static IntPtr _ClassPtr;

		// Token: 0x040005A1 RID: 1441
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005A2 RID: 1442
		internal static int __PropertyOffset_Result;
	}
}
