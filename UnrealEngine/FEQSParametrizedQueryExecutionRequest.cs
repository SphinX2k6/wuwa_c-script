using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EQSParametrizedQueryExecutionRequest")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FEQSParametrizedQueryExecutionRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x00027EA8 File Offset: 0x000260A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEQSParametrizedQueryExecutionRequest._ScriptStructPtr != 0) ? FEQSParametrizedQueryExecutionRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EQSParametrizedQueryExecutionRequest", ref FEQSParametrizedQueryExecutionRequest._ScriptStructPtr);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00027ECC File Offset: 0x000260CC
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x00027EE0 File Offset: 0x000260E0
		[Nullable(2)]
		public unsafe UEnvQuery QueryTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQuery>(base.NativePtr / (IntPtr)sizeof(void*) + FEQSParametrizedQueryExecutionRequest.__PropertyOffset_QueryTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEQSParametrizedQueryExecutionRequest.__PropertyOffset_QueryTemplate, value);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x00027EF8 File Offset: 0x000260F8
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x00027F3B File Offset: 0x0002613B
		public TArray<FAIDynamicParam> QueryConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIDynamicParam> result;
				if ((result = this._QueryConfig) == null)
				{
					result = (this._QueryConfig = new TArray<FAIDynamicParam>(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_QueryConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QueryConfig.CopyAssign(value);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00027F4C File Offset: 0x0002614C
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x00027F8F File Offset: 0x0002618F
		public FBlackboardKeySelector EQSQueryBlackboardKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._EQSQueryBlackboardKey) == null)
				{
					result = (this._EQSQueryBlackboardKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_EQSQueryBlackboardKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_EQSQueryBlackboardKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x00027FB0 File Offset: 0x000261B0
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x00027FC4 File Offset: 0x000261C4
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvQueryRunMode> RunMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_RunMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_RunMode) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00027FD9 File Offset: 0x000261D9
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x00027FF2 File Offset: 0x000261F2
		public unsafe bool bUseBBKeyForQueryTemplate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_bUseBBKeyForQueryTemplate) & FEQSParametrizedQueryExecutionRequest.__PropertyMask_bUseBBKeyForQueryTemplate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_bUseBBKeyForQueryTemplate) = ((*(base.NativePtr + (IntPtr)FEQSParametrizedQueryExecutionRequest.__PropertyOffset_bUseBBKeyForQueryTemplate) & ~FEQSParametrizedQueryExecutionRequest.__PropertyMask_bUseBBKeyForQueryTemplate) | (value ? FEQSParametrizedQueryExecutionRequest.__PropertyMask_bUseBBKeyForQueryTemplate : 0));
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00028022 File Offset: 0x00026222
		public FEQSParametrizedQueryExecutionRequest()
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0002802A File Offset: 0x0002622A
		public FEQSParametrizedQueryExecutionRequest(UEnvQuery QueryTemplate, TArray<FAIDynamicParam> QueryConfig, FBlackboardKeySelector EQSQueryBlackboardKey, [Nullable(0)] TEnumAsByte<EEnvQueryRunMode> RunMode, bool bUseBBKeyForQueryTemplate)
		{
			this.QueryTemplate = QueryTemplate;
			this.QueryConfig = QueryConfig;
			this.EQSQueryBlackboardKey = EQSQueryBlackboardKey;
			this.RunMode = RunMode;
			this.bUseBBKeyForQueryTemplate = bUseBBKeyForQueryTemplate;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00028057 File Offset: 0x00026257
		protected override IntPtr GetUStructPtr()
		{
			return FEQSParametrizedQueryExecutionRequest.StaticStruct();
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00028063 File Offset: 0x00026263
		[NullableContext(2)]
		public FEQSParametrizedQueryExecutionRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0002806D File Offset: 0x0002626D
		public FEQSParametrizedQueryExecutionRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00028078 File Offset: 0x00026278
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEQSParametrizedQueryExecutionRequest(Pointer, false, true);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00028082 File Offset: 0x00026282
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEQSParametrizedQueryExecutionRequest(Pointer, MemoryOwner);
		}

		// Token: 0x04000871 RID: 2161
		public const string __ObjectPath = "/Script/AIModule.EQSParametrizedQueryExecutionRequest";

		// Token: 0x04000872 RID: 2162
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000873 RID: 2163
		internal static int __PropertyOffset_QueryTemplate;

		// Token: 0x04000874 RID: 2164
		internal static int __PropertyOffset_QueryConfig;

		// Token: 0x04000875 RID: 2165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIDynamicParam> _QueryConfig;

		// Token: 0x04000876 RID: 2166
		internal static int __PropertyOffset_EQSQueryBlackboardKey;

		// Token: 0x04000877 RID: 2167
		[Nullable(2)]
		private FBlackboardKeySelector _EQSQueryBlackboardKey;

		// Token: 0x04000878 RID: 2168
		internal static int __PropertyOffset_RunMode;

		// Token: 0x04000879 RID: 2169
		internal static int __PropertyOffset_bUseBBKeyForQueryTemplate;

		// Token: 0x0400087A RID: 2170
		internal static byte __PropertyMask_bUseBBKeyForQueryTemplate;
	}
}
