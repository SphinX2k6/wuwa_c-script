using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5D RID: 3677
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTangentOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionTangentOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C512 RID: 50450 RVA: 0x0011D3EE File Offset: 0x0011B5EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTangentOutput._ClassPtr;
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x0011D3FC File Offset: 0x0011B5FC
		public UMaterialExpressionTangentOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTangentOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x0011D424 File Offset: 0x0011B624
		public UMaterialExpressionTangentOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTangentOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600C515 RID: 50453 RVA: 0x0011D458 File Offset: 0x0011B658
		// (set) Token: 0x0600C516 RID: 50454 RVA: 0x0011D491 File Offset: 0x0011B691
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTangentOutput.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTangentOutput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x0011D4B2 File Offset: 0x0011B6B2
		static UMaterialExpressionTangentOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTangentOutput");
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x0011D4C0 File Offset: 0x0011B6C0
		protected UMaterialExpressionTangentOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400695B RID: 26971
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTangentOutput";

		// Token: 0x0400695C RID: 26972
		private static IntPtr _ClassPtr;

		// Token: 0x0400695D RID: 26973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400695E RID: 26974
		internal static int __PropertyOffset_Input;

		// Token: 0x0400695F RID: 26975
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
