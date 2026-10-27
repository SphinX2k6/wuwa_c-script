using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3C RID: 3644
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionShaderStageSwitch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionShaderStageSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3C2 RID: 50114 RVA: 0x0011ABDA File Offset: 0x00118DDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionShaderStageSwitch._ClassPtr;
		}

		// Token: 0x0600C3C3 RID: 50115 RVA: 0x0011ABE8 File Offset: 0x00118DE8
		public UMaterialExpressionShaderStageSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShaderStageSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3C4 RID: 50116 RVA: 0x0011AC10 File Offset: 0x00118E10
		public UMaterialExpressionShaderStageSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShaderStageSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x0600C3C5 RID: 50117 RVA: 0x0011AC44 File Offset: 0x00118E44
		// (set) Token: 0x0600C3C6 RID: 50118 RVA: 0x0011AC7D File Offset: 0x00118E7D
		public FExpressionInput PixelShader
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._PixelShader) == null)
				{
					result = (this._PixelShader = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionShaderStageSwitch.__PropertyOffset_PixelShader, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionShaderStageSwitch.__PropertyOffset_PixelShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x0600C3C7 RID: 50119 RVA: 0x0011ACA0 File Offset: 0x00118EA0
		// (set) Token: 0x0600C3C8 RID: 50120 RVA: 0x0011ACD9 File Offset: 0x00118ED9
		public FExpressionInput VertexShader
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._VertexShader) == null)
				{
					result = (this._VertexShader = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionShaderStageSwitch.__PropertyOffset_VertexShader, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionShaderStageSwitch.__PropertyOffset_VertexShader, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x0011ACFA File Offset: 0x00118EFA
		static UMaterialExpressionShaderStageSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionShaderStageSwitch");
		}

		// Token: 0x0600C3CA RID: 50122 RVA: 0x0011AD08 File Offset: 0x00118F08
		protected UMaterialExpressionShaderStageSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006869 RID: 26729
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionShaderStageSwitch";

		// Token: 0x0400686A RID: 26730
		private static IntPtr _ClassPtr;

		// Token: 0x0400686B RID: 26731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400686C RID: 26732
		internal static int __PropertyOffset_PixelShader;

		// Token: 0x0400686D RID: 26733
		[Nullable(2)]
		private FExpressionInput _PixelShader;

		// Token: 0x0400686E RID: 26734
		internal static int __PropertyOffset_VertexShader;

		// Token: 0x0400686F RID: 26735
		[Nullable(2)]
		private FExpressionInput _VertexShader;
	}
}
