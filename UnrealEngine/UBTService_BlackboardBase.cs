using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTService_BlackboardBase")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public abstract class UBTService_BlackboardBase : UBTService, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00022269 File Offset: 0x00020469
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService_BlackboardBase._ClassPtr;
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00022278 File Offset: 0x00020478
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x000222B1 File Offset: 0x000204B1
		public FBlackboardKeySelector BlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKey) == null)
				{
					result = (this._BlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTService_BlackboardBase.__PropertyOffset_BlackboardKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTService_BlackboardBase.__PropertyOffset_BlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000222D2 File Offset: 0x000204D2
		static UBTService_BlackboardBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService_BlackboardBase");
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000222E0 File Offset: 0x000204E0
		protected UBTService_BlackboardBase() : this(BuiltinUtils.AllocNativeUObject(UBTService_BlackboardBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00022308 File Offset: 0x00020508
		protected UBTService_BlackboardBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000573 RID: 1395
		public new const string __ObjectPath = "/Script/AIModule.BTService_BlackboardBase";

		// Token: 0x04000574 RID: 1396
		private static IntPtr _ClassPtr;

		// Token: 0x04000575 RID: 1397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000576 RID: 1398
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x04000577 RID: 1399
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKey;
	}
}
