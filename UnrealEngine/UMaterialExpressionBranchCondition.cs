using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D93 RID: 3475
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBranchCondition")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UMaterialExpressionBranchCondition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD89 RID: 48521 RVA: 0x0010F2D2 File Offset: 0x0010D4D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBranchCondition._ClassPtr;
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0600BD8A RID: 48522 RVA: 0x0010F2E0 File Offset: 0x0010D4E0
		// (set) Token: 0x0600BD8B RID: 48523 RVA: 0x0010F319 File Offset: 0x0010D519
		public TArray<FExpressionInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExpressionInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionBranchCondition.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x0010F327 File Offset: 0x0010D527
		static UMaterialExpressionBranchCondition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBranchCondition");
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x0010F338 File Offset: 0x0010D538
		protected UMaterialExpressionBranchCondition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBranchCondition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x0010F360 File Offset: 0x0010D560
		protected UMaterialExpressionBranchCondition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400640F RID: 25615
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBranchCondition";

		// Token: 0x04006410 RID: 25616
		private static IntPtr _ClassPtr;

		// Token: 0x04006411 RID: 25617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006412 RID: 25618
		internal static int __PropertyOffset_Inputs;

		// Token: 0x04006413 RID: 25619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExpressionInput> _Inputs;
	}
}
