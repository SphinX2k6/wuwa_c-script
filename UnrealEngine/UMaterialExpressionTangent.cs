using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5C RID: 3676
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTangent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionTangent : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C509 RID: 50441 RVA: 0x0011D2F3 File Offset: 0x0011B4F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTangent._ClassPtr;
		}

		// Token: 0x0600C50A RID: 50442 RVA: 0x0011D300 File Offset: 0x0011B500
		public UMaterialExpressionTangent() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTangent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C50B RID: 50443 RVA: 0x0011D328 File Offset: 0x0011B528
		public UMaterialExpressionTangent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTangent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x0011D35C File Offset: 0x0011B55C
		// (set) Token: 0x0600C50D RID: 50445 RVA: 0x0011D395 File Offset: 0x0011B595
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTangent.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTangent.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600C50E RID: 50446 RVA: 0x0011D3B6 File Offset: 0x0011B5B6
		// (set) Token: 0x0600C50F RID: 50447 RVA: 0x0011D3C6 File Offset: 0x0011B5C6
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTangent.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTangent.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0600C510 RID: 50448 RVA: 0x0011D3D7 File Offset: 0x0011B5D7
		static UMaterialExpressionTangent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTangent");
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x0011D3E5 File Offset: 0x0011B5E5
		protected UMaterialExpressionTangent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006955 RID: 26965
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTangent";

		// Token: 0x04006956 RID: 26966
		private static IntPtr _ClassPtr;

		// Token: 0x04006957 RID: 26967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006958 RID: 26968
		internal static int __PropertyOffset_Input;

		// Token: 0x04006959 RID: 26969
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400695A RID: 26970
		internal static int __PropertyOffset_Period;
	}
}
