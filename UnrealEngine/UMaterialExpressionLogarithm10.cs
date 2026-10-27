using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF0 RID: 3568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLogarithm10")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionLogarithm10 : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0F8 RID: 49400 RVA: 0x00115944 File Offset: 0x00113B44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLogarithm10._ClassPtr;
		}

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x00115950 File Offset: 0x00113B50
		public UMaterialExpressionLogarithm10() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLogarithm10.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0FA RID: 49402 RVA: 0x00115978 File Offset: 0x00113B78
		public UMaterialExpressionLogarithm10(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLogarithm10.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600C0FB RID: 49403 RVA: 0x001159AC File Offset: 0x00113BAC
		// (set) Token: 0x0600C0FC RID: 49404 RVA: 0x001159E5 File Offset: 0x00113BE5
		public FExpressionInput X
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLogarithm10.__PropertyOffset_X, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLogarithm10.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C0FD RID: 49405 RVA: 0x00115A06 File Offset: 0x00113C06
		static UMaterialExpressionLogarithm10()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLogarithm10");
		}

		// Token: 0x0600C0FE RID: 49406 RVA: 0x00115A14 File Offset: 0x00113C14
		protected UMaterialExpressionLogarithm10(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006677 RID: 26231
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLogarithm10";

		// Token: 0x04006678 RID: 26232
		private static IntPtr _ClassPtr;

		// Token: 0x04006679 RID: 26233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400667A RID: 26234
		internal static int __PropertyOffset_X;

		// Token: 0x0400667B RID: 26235
		[Nullable(2)]
		private FExpressionInput _X;
	}
}
