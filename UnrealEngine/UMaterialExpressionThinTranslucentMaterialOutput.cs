using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6B RID: 3691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionThinTranslucentMaterialOutput")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionThinTranslucentMaterialOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C57A RID: 50554 RVA: 0x0011DEA6 File Offset: 0x0011C0A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionThinTranslucentMaterialOutput._ClassPtr;
		}

		// Token: 0x0600C57B RID: 50555 RVA: 0x0011DEB4 File Offset: 0x0011C0B4
		public UMaterialExpressionThinTranslucentMaterialOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionThinTranslucentMaterialOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C57C RID: 50556 RVA: 0x0011DEDC File Offset: 0x0011C0DC
		public UMaterialExpressionThinTranslucentMaterialOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionThinTranslucentMaterialOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600C57D RID: 50557 RVA: 0x0011DF10 File Offset: 0x0011C110
		// (set) Token: 0x0600C57E RID: 50558 RVA: 0x0011DF49 File Offset: 0x0011C149
		public FExpressionInput TransmittanceColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._TransmittanceColor) == null)
				{
					result = (this._TransmittanceColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionThinTranslucentMaterialOutput.__PropertyOffset_TransmittanceColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionThinTranslucentMaterialOutput.__PropertyOffset_TransmittanceColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x0011DF6A File Offset: 0x0011C16A
		static UMaterialExpressionThinTranslucentMaterialOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionThinTranslucentMaterialOutput");
		}

		// Token: 0x0600C580 RID: 50560 RVA: 0x0011DF78 File Offset: 0x0011C178
		protected UMaterialExpressionThinTranslucentMaterialOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400699F RID: 27039
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionThinTranslucentMaterialOutput";

		// Token: 0x040069A0 RID: 27040
		private static IntPtr _ClassPtr;

		// Token: 0x040069A1 RID: 27041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069A2 RID: 27042
		internal static int __PropertyOffset_TransmittanceColor;

		// Token: 0x040069A3 RID: 27043
		[Nullable(2)]
		private FExpressionInput _TransmittanceColor;
	}
}
