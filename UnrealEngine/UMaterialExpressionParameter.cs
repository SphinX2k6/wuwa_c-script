using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E08 RID: 3592
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParameter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMaterialExpressionParameter : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C20D RID: 49677 RVA: 0x00117AD1 File Offset: 0x00115CD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParameter._ClassPtr;
		}

		// Token: 0x0600C20E RID: 49678 RVA: 0x00117AE0 File Offset: 0x00115CE0
		public UMaterialExpressionParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C20F RID: 49679 RVA: 0x00117B08 File Offset: 0x00115D08
		[NullableContext(1)]
		public UMaterialExpressionParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600C210 RID: 49680 RVA: 0x00117B3B File Offset: 0x00115D3B
		// (set) Token: 0x0600C211 RID: 49681 RVA: 0x00117B4F File Offset: 0x00115D4F
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600C212 RID: 49682 RVA: 0x00117B64 File Offset: 0x00115D64
		// (set) Token: 0x0600C213 RID: 49683 RVA: 0x00117B78 File Offset: 0x00115D78
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionParameter.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionParameter.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x00117B8D File Offset: 0x00115D8D
		static UMaterialExpressionParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParameter");
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x00117B9B File Offset: 0x00115D9B
		protected UMaterialExpressionParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006741 RID: 26433
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParameter";

		// Token: 0x04006742 RID: 26434
		private static IntPtr _ClassPtr;

		// Token: 0x04006743 RID: 26435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006744 RID: 26436
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04006745 RID: 26437
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
