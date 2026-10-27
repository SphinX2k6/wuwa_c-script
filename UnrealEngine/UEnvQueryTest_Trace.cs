using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B3 RID: 435
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Trace")]
	[UnrealStructLayout(856, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 856)]
	public class UEnvQueryTest_Trace : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A81 RID: 6785 RVA: 0x000276BE File Offset: 0x000258BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Trace._ClassPtr;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000276CC File Offset: 0x000258CC
		public UEnvQueryTest_Trace() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Trace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000276F4 File Offset: 0x000258F4
		public UEnvQueryTest_Trace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Trace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00027728 File Offset: 0x00025928
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00027761 File Offset: 0x00025961
		public FEnvTraceData TraceData
		{
			get
			{
				base.FastCheckIsValid();
				FEnvTraceData result;
				if ((result = this._TraceData) == null)
				{
					result = (this._TraceData = new FEnvTraceData(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_TraceData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvTraceData.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_TraceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00027784 File Offset: 0x00025984
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x000277BD File Offset: 0x000259BD
		public FAIDataProviderBoolValue TraceFromContext
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderBoolValue result;
				if ((result = this._TraceFromContext) == null)
				{
					result = (this._TraceFromContext = new FAIDataProviderBoolValue(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_TraceFromContext, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderBoolValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_TraceFromContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x000277E0 File Offset: 0x000259E0
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00027819 File Offset: 0x00025A19
		public FAIDataProviderFloatValue ItemHeightOffset
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ItemHeightOffset) == null)
				{
					result = (this._ItemHeightOffset = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_ItemHeightOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_ItemHeightOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0002783C File Offset: 0x00025A3C
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00027875 File Offset: 0x00025A75
		public FAIDataProviderFloatValue ContextHeightOffset
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ContextHeightOffset) == null)
				{
					result = (this._ContextHeightOffset = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_ContextHeightOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_ContextHeightOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00027896 File Offset: 0x00025A96
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x000278AA File Offset: 0x00025AAA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> Context
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_Context);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Trace.__PropertyOffset_Context) = value;
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000278BF File Offset: 0x00025ABF
		static UEnvQueryTest_Trace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Trace");
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000278CD File Offset: 0x00025ACD
		protected UEnvQueryTest_Trace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400080C RID: 2060
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Trace";

		// Token: 0x0400080D RID: 2061
		private static IntPtr _ClassPtr;

		// Token: 0x0400080E RID: 2062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400080F RID: 2063
		internal static int __PropertyOffset_TraceData;

		// Token: 0x04000810 RID: 2064
		[Nullable(2)]
		private FEnvTraceData _TraceData;

		// Token: 0x04000811 RID: 2065
		internal static int __PropertyOffset_TraceFromContext;

		// Token: 0x04000812 RID: 2066
		[Nullable(2)]
		private FAIDataProviderBoolValue _TraceFromContext;

		// Token: 0x04000813 RID: 2067
		internal static int __PropertyOffset_ItemHeightOffset;

		// Token: 0x04000814 RID: 2068
		[Nullable(2)]
		private FAIDataProviderFloatValue _ItemHeightOffset;

		// Token: 0x04000815 RID: 2069
		internal static int __PropertyOffset_ContextHeightOffset;

		// Token: 0x04000816 RID: 2070
		[Nullable(2)]
		private FAIDataProviderFloatValue _ContextHeightOffset;

		// Token: 0x04000817 RID: 2071
		internal static int __PropertyOffset_Context;
	}
}
