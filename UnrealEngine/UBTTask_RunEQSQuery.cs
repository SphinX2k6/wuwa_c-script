using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000162 RID: 354
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_RunEQSQuery")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UBTTask_RunEQSQuery : UBTTask_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001810 RID: 6160 RVA: 0x00023715 File Offset: 0x00021915
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunEQSQuery._ClassPtr;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00023724 File Offset: 0x00021924
		public UBTTask_RunEQSQuery() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunEQSQuery.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0002374C File Offset: 0x0002194C
		public UBTTask_RunEQSQuery(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunEQSQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0002377F File Offset: 0x0002197F
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x00023793 File Offset: 0x00021993
		[Nullable(2)]
		public unsafe UEnvQuery QueryTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQuery>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunEQSQuery.__PropertyOffset_QueryTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunEQSQuery.__PropertyOffset_QueryTemplate, value);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000237A8 File Offset: 0x000219A8
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x000237E1 File Offset: 0x000219E1
		public TArray<FEnvNamedValue> QueryParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEnvNamedValue> result;
				if ((result = this._QueryParams) == null)
				{
					result = (this._QueryParams = new TArray<FEnvNamedValue>(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_QueryParams, this));
				}
				return result;
			}
			set
			{
				this.QueryParams.CopyAssign(value);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000237F0 File Offset: 0x000219F0
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x00023829 File Offset: 0x00021A29
		public TArray<FAIDynamicParam> QueryConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIDynamicParam> result;
				if ((result = this._QueryConfig) == null)
				{
					result = (this._QueryConfig = new TArray<FAIDynamicParam>(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_QueryConfig, this));
				}
				return result;
			}
			set
			{
				this.QueryConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00023837 File Offset: 0x00021A37
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x0002384B File Offset: 0x00021A4B
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvQueryRunMode> RunMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_RunMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_RunMode) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00023860 File Offset: 0x00021A60
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00023899 File Offset: 0x00021A99
		public FBlackboardKeySelector EQSQueryBlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._EQSQueryBlackboardKey) == null)
				{
					result = (this._EQSQueryBlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_EQSQueryBlackboardKey, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_EQSQueryBlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000238BA File Offset: 0x00021ABA
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x000238CA File Offset: 0x00021ACA
		public unsafe bool bUseBBKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_bUseBBKey) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_bUseBBKey) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000238DC File Offset: 0x00021ADC
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00023915 File Offset: 0x00021B15
		public FEQSParametrizedQueryExecutionRequest EQSRequest
		{
			get
			{
				base.FastCheckIsValid();
				FEQSParametrizedQueryExecutionRequest result;
				if ((result = this._EQSRequest) == null)
				{
					result = (this._EQSRequest = new FEQSParametrizedQueryExecutionRequest(base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_EQSRequest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEQSParametrizedQueryExecutionRequest.StaticStruct(), base.NativePtr + (IntPtr)UBTTask_RunEQSQuery.__PropertyOffset_EQSRequest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00023936 File Offset: 0x00021B36
		static UBTTask_RunEQSQuery()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_RunEQSQuery");
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00023944 File Offset: 0x00021B44
		protected UBTTask_RunEQSQuery(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005F0 RID: 1520
		public new const string __ObjectPath = "/Script/AIModule.BTTask_RunEQSQuery";

		// Token: 0x040005F1 RID: 1521
		private static IntPtr _ClassPtr;

		// Token: 0x040005F2 RID: 1522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005F3 RID: 1523
		internal static int __PropertyOffset_QueryTemplate;

		// Token: 0x040005F4 RID: 1524
		internal static int __PropertyOffset_QueryParams;

		// Token: 0x040005F5 RID: 1525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEnvNamedValue> _QueryParams;

		// Token: 0x040005F6 RID: 1526
		internal static int __PropertyOffset_QueryConfig;

		// Token: 0x040005F7 RID: 1527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIDynamicParam> _QueryConfig;

		// Token: 0x040005F8 RID: 1528
		internal static int __PropertyOffset_RunMode;

		// Token: 0x040005F9 RID: 1529
		internal static int __PropertyOffset_EQSQueryBlackboardKey;

		// Token: 0x040005FA RID: 1530
		[Nullable(2)]
		private FBlackboardKeySelector _EQSQueryBlackboardKey;

		// Token: 0x040005FB RID: 1531
		internal static int __PropertyOffset_bUseBBKey;

		// Token: 0x040005FC RID: 1532
		internal static int __PropertyOffset_EQSRequest;

		// Token: 0x040005FD RID: 1533
		[Nullable(2)]
		private FEQSParametrizedQueryExecutionRequest _EQSRequest;
	}
}
