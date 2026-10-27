using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000152 RID: 338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTService_RunEQS")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UBTService_RunEQS : UBTService_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001761 RID: 5985 RVA: 0x0002261B File Offset: 0x0002081B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService_RunEQS._ClassPtr;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00022628 File Offset: 0x00020828
		public UBTService_RunEQS() : this(BuiltinUtils.AllocNativeUObject(UBTService_RunEQS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00022650 File Offset: 0x00020850
		public UBTService_RunEQS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTService_RunEQS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00022684 File Offset: 0x00020884
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x000226BD File Offset: 0x000208BD
		public FEQSParametrizedQueryExecutionRequest EQSRequest
		{
			get
			{
				base.FastCheckIsValid();
				FEQSParametrizedQueryExecutionRequest result;
				if ((result = this._EQSRequest) == null)
				{
					result = (this._EQSRequest = new FEQSParametrizedQueryExecutionRequest(base.NativePtr + (IntPtr)UBTService_RunEQS.__PropertyOffset_EQSRequest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEQSParametrizedQueryExecutionRequest.StaticStruct(), base.NativePtr + (IntPtr)UBTService_RunEQS.__PropertyOffset_EQSRequest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000226DE File Offset: 0x000208DE
		static UBTService_RunEQS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService_RunEQS");
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000226EC File Offset: 0x000208EC
		protected UBTService_RunEQS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000585 RID: 1413
		public new const string __ObjectPath = "/Script/AIModule.BTService_RunEQS";

		// Token: 0x04000586 RID: 1414
		private static IntPtr _ClassPtr;

		// Token: 0x04000587 RID: 1415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000588 RID: 1416
		internal static int __PropertyOffset_EQSRequest;

		// Token: 0x04000589 RID: 1417
		[Nullable(2)]
		private FEQSParametrizedQueryExecutionRequest _EQSRequest;
	}
}
