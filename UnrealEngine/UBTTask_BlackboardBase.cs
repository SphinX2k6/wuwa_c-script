using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000154 RID: 340
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_BlackboardBase")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public abstract class UBTTask_BlackboardBase : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x000227D5 File Offset: 0x000209D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_BlackboardBase._ClassPtr;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x000227E4 File Offset: 0x000209E4
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0002281D File Offset: 0x00020A1D
		public FBlackboardKeySelector BlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKey) == null)
				{
					result = (this._BlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTTask_BlackboardBase.__PropertyOffset_BlackboardKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTTask_BlackboardBase.__PropertyOffset_BlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0002283E File Offset: 0x00020A3E
		static UBTTask_BlackboardBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_BlackboardBase");
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0002284C File Offset: 0x00020A4C
		protected UBTTask_BlackboardBase() : this(BuiltinUtils.AllocNativeUObject(UBTTask_BlackboardBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00022874 File Offset: 0x00020A74
		protected UBTTask_BlackboardBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000591 RID: 1425
		public new const string __ObjectPath = "/Script/AIModule.BTTask_BlackboardBase";

		// Token: 0x04000592 RID: 1426
		private static IntPtr _ClassPtr;

		// Token: 0x04000593 RID: 1427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000594 RID: 1428
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x04000595 RID: 1429
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKey;
	}
}
