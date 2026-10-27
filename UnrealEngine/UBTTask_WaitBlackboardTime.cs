using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000165 RID: 357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_WaitBlackboardTime")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UBTTask_WaitBlackboardTime : UBTTask_Wait, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x00023AFC File Offset: 0x00021CFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_WaitBlackboardTime._ClassPtr;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00023B08 File Offset: 0x00021D08
		public UBTTask_WaitBlackboardTime() : this(BuiltinUtils.AllocNativeUObject(UBTTask_WaitBlackboardTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00023B30 File Offset: 0x00021D30
		public UBTTask_WaitBlackboardTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_WaitBlackboardTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00023B64 File Offset: 0x00021D64
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x00023B9D File Offset: 0x00021D9D
		public FBlackboardKeySelector BlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKey) == null)
				{
					result = (this._BlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTTask_WaitBlackboardTime.__PropertyOffset_BlackboardKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTTask_WaitBlackboardTime.__PropertyOffset_BlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00023BBE File Offset: 0x00021DBE
		static UBTTask_WaitBlackboardTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_WaitBlackboardTime");
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00023BCC File Offset: 0x00021DCC
		protected UBTTask_WaitBlackboardTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000609 RID: 1545
		public new const string __ObjectPath = "/Script/AIModule.BTTask_WaitBlackboardTime";

		// Token: 0x0400060A RID: 1546
		private static IntPtr _ClassPtr;

		// Token: 0x0400060B RID: 1547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400060C RID: 1548
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x0400060D RID: 1549
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKey;
	}
}
