using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF1 RID: 3569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLogarithm2")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionLogarithm2 : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0FF RID: 49407 RVA: 0x00115A1D File Offset: 0x00113C1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLogarithm2._ClassPtr;
		}

		// Token: 0x0600C100 RID: 49408 RVA: 0x00115A2C File Offset: 0x00113C2C
		public UMaterialExpressionLogarithm2() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLogarithm2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C101 RID: 49409 RVA: 0x00115A54 File Offset: 0x00113C54
		public UMaterialExpressionLogarithm2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLogarithm2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600C102 RID: 49410 RVA: 0x00115A88 File Offset: 0x00113C88
		// (set) Token: 0x0600C103 RID: 49411 RVA: 0x00115AC1 File Offset: 0x00113CC1
		public FExpressionInput X
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLogarithm2.__PropertyOffset_X, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLogarithm2.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C104 RID: 49412 RVA: 0x00115AE2 File Offset: 0x00113CE2
		static UMaterialExpressionLogarithm2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLogarithm2");
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x00115AF0 File Offset: 0x00113CF0
		protected UMaterialExpressionLogarithm2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400667C RID: 26236
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLogarithm2";

		// Token: 0x0400667D RID: 26237
		private static IntPtr _ClassPtr;

		// Token: 0x0400667E RID: 26238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400667F RID: 26239
		internal static int __PropertyOffset_X;

		// Token: 0x04006680 RID: 26240
		[Nullable(2)]
		private FExpressionInput _X;
	}
}
