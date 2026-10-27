using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E00 RID: 3584
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNormalize")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionNormalize : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1D3 RID: 49619 RVA: 0x00117483 File Offset: 0x00115683
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNormalize._ClassPtr;
		}

		// Token: 0x0600C1D4 RID: 49620 RVA: 0x00117490 File Offset: 0x00115690
		public UMaterialExpressionNormalize() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNormalize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x001174B8 File Offset: 0x001156B8
		public UMaterialExpressionNormalize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNormalize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0600C1D6 RID: 49622 RVA: 0x001174EC File Offset: 0x001156EC
		// (set) Token: 0x0600C1D7 RID: 49623 RVA: 0x00117525 File Offset: 0x00115725
		public FExpressionInput VectorInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._VectorInput) == null)
				{
					result = (this._VectorInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionNormalize.__PropertyOffset_VectorInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionNormalize.__PropertyOffset_VectorInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00117546 File Offset: 0x00115746
		static UMaterialExpressionNormalize()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNormalize");
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x00117554 File Offset: 0x00115754
		protected UMaterialExpressionNormalize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400671B RID: 26395
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNormalize";

		// Token: 0x0400671C RID: 26396
		private static IntPtr _ClassPtr;

		// Token: 0x0400671D RID: 26397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400671E RID: 26398
		internal static int __PropertyOffset_VectorInput;

		// Token: 0x0400671F RID: 26399
		[Nullable(2)]
		private FExpressionInput _VectorInput;
	}
}
