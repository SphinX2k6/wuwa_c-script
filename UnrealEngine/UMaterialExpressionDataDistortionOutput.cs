using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAC RID: 3500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDataDistortionOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDataDistortionOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE70 RID: 48752 RVA: 0x00110B95 File Offset: 0x0010ED95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDataDistortionOutput._ClassPtr;
		}

		// Token: 0x0600BE71 RID: 48753 RVA: 0x00110BA4 File Offset: 0x0010EDA4
		public UMaterialExpressionDataDistortionOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDataDistortionOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x00110BCC File Offset: 0x0010EDCC
		public UMaterialExpressionDataDistortionOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDataDistortionOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x00110C00 File Offset: 0x0010EE00
		// (set) Token: 0x0600BE74 RID: 48756 RVA: 0x00110C39 File Offset: 0x0010EE39
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDataDistortionOutput.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDataDistortionOutput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE75 RID: 48757 RVA: 0x00110C5A File Offset: 0x0010EE5A
		static UMaterialExpressionDataDistortionOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDataDistortionOutput");
		}

		// Token: 0x0600BE76 RID: 48758 RVA: 0x00110C68 File Offset: 0x0010EE68
		protected UMaterialExpressionDataDistortionOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064AA RID: 25770
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDataDistortionOutput";

		// Token: 0x040064AB RID: 25771
		private static IntPtr _ClassPtr;

		// Token: 0x040064AC RID: 25772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064AD RID: 25773
		internal static int __PropertyOffset_Input;

		// Token: 0x040064AE RID: 25774
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
