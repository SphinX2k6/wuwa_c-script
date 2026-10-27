using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D88 RID: 3464
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArctangent")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArctangent : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD28 RID: 48424 RVA: 0x0010E719 File Offset: 0x0010C919
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArctangent._ClassPtr;
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x0010E728 File Offset: 0x0010C928
		public UMaterialExpressionArctangent() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x0010E750 File Offset: 0x0010C950
		public UMaterialExpressionArctangent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600BD2B RID: 48427 RVA: 0x0010E784 File Offset: 0x0010C984
		// (set) Token: 0x0600BD2C RID: 48428 RVA: 0x0010E7BD File Offset: 0x0010C9BD
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangent.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangent.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD2D RID: 48429 RVA: 0x0010E7DE File Offset: 0x0010C9DE
		static UMaterialExpressionArctangent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArctangent");
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x0010E7EC File Offset: 0x0010C9EC
		protected UMaterialExpressionArctangent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063C9 RID: 25545
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArctangent";

		// Token: 0x040063CA RID: 25546
		private static IntPtr _ClassPtr;

		// Token: 0x040063CB RID: 25547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063CC RID: 25548
		internal static int __PropertyOffset_Input;

		// Token: 0x040063CD RID: 25549
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
