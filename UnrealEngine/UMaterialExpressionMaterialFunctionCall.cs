using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF5 RID: 3573
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMaterialFunctionCall")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMaterialExpressionMaterialFunctionCall : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C159 RID: 49497 RVA: 0x00116760 File Offset: 0x00114960
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMaterialFunctionCall._ClassPtr;
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x0011676C File Offset: 0x0011496C
		public UMaterialExpressionMaterialFunctionCall() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialFunctionCall.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x00116794 File Offset: 0x00114994
		public UMaterialExpressionMaterialFunctionCall(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialFunctionCall.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600C15C RID: 49500 RVA: 0x001167C7 File Offset: 0x001149C7
		// (set) Token: 0x0600C15D RID: 49501 RVA: 0x001167DB File Offset: 0x001149DB
		[Nullable(2)]
		public unsafe UMaterialFunctionInterface MaterialFunction
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialFunctionInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionMaterialFunctionCall.__PropertyOffset_MaterialFunction);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionMaterialFunctionCall.__PropertyOffset_MaterialFunction, value);
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600C15E RID: 49502 RVA: 0x001167F0 File Offset: 0x001149F0
		// (set) Token: 0x0600C15F RID: 49503 RVA: 0x00116829 File Offset: 0x00114A29
		public FMaterialParameterInfo FunctionParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._FunctionParameterInfo) == null)
				{
					result = (this._FunctionParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)UMaterialExpressionMaterialFunctionCall.__PropertyOffset_FunctionParameterInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMaterialFunctionCall.__PropertyOffset_FunctionParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x0011684A File Offset: 0x00114A4A
		static UMaterialExpressionMaterialFunctionCall()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMaterialFunctionCall");
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x00116858 File Offset: 0x00114A58
		protected UMaterialExpressionMaterialFunctionCall(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066C9 RID: 26313
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMaterialFunctionCall";

		// Token: 0x040066CA RID: 26314
		private static IntPtr _ClassPtr;

		// Token: 0x040066CB RID: 26315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066CC RID: 26316
		internal static int __PropertyOffset_MaterialFunction;

		// Token: 0x040066CD RID: 26317
		internal static int __PropertyOffset_FunctionParameterInfo;

		// Token: 0x040066CE RID: 26318
		[Nullable(2)]
		private FMaterialParameterInfo _FunctionParameterInfo;
	}
}
