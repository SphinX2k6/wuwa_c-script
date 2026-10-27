using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBD RID: 3517
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDynamicParameter")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMaterialExpressionDynamicParameter : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEF9 RID: 48889 RVA: 0x00111B9D File Offset: 0x0010FD9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDynamicParameter._ClassPtr;
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x00111BAC File Offset: 0x0010FDAC
		public UMaterialExpressionDynamicParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDynamicParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x00111BD4 File Offset: 0x0010FDD4
		public UMaterialExpressionDynamicParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDynamicParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0600BEFC RID: 48892 RVA: 0x00111C08 File Offset: 0x0010FE08
		// (set) Token: 0x0600BEFD RID: 48893 RVA: 0x00111C41 File Offset: 0x0010FE41
		public TArray<string> ParamNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ParamNames) == null)
				{
					result = (this._ParamNames = new TArray<string>(base.NativePtr + (IntPtr)UMaterialExpressionDynamicParameter.__PropertyOffset_ParamNames, this));
				}
				return result;
			}
			set
			{
				this.ParamNames.CopyAssign(value);
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x00111C4F File Offset: 0x0010FE4F
		// (set) Token: 0x0600BEFF RID: 48895 RVA: 0x00111C63 File Offset: 0x0010FE63
		public unsafe FLinearColor DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDynamicParameter.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDynamicParameter.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0600BF00 RID: 48896 RVA: 0x00111C78 File Offset: 0x0010FE78
		// (set) Token: 0x0600BF01 RID: 48897 RVA: 0x00111C88 File Offset: 0x0010FE88
		public unsafe uint ParameterIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDynamicParameter.__PropertyOffset_ParameterIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDynamicParameter.__PropertyOffset_ParameterIndex) = (int)value;
			}
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x00111C99 File Offset: 0x0010FE99
		static UMaterialExpressionDynamicParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDynamicParameter");
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x00111CA7 File Offset: 0x0010FEA7
		protected UMaterialExpressionDynamicParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006509 RID: 25865
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDynamicParameter";

		// Token: 0x0400650A RID: 25866
		private static IntPtr _ClassPtr;

		// Token: 0x0400650B RID: 25867
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400650C RID: 25868
		internal static int __PropertyOffset_ParamNames;

		// Token: 0x0400650D RID: 25869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ParamNames;

		// Token: 0x0400650E RID: 25870
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x0400650F RID: 25871
		internal static int __PropertyOffset_ParameterIndex;
	}
}
