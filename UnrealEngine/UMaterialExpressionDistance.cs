using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB7 RID: 3511
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDistance")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionDistance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEC7 RID: 48839 RVA: 0x0011157E File Offset: 0x0010F77E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDistance._ClassPtr;
		}

		// Token: 0x0600BEC8 RID: 48840 RVA: 0x0011158C File Offset: 0x0010F78C
		public UMaterialExpressionDistance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x001115B4 File Offset: 0x0010F7B4
		public UMaterialExpressionDistance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0600BECA RID: 48842 RVA: 0x001115E8 File Offset: 0x0010F7E8
		// (set) Token: 0x0600BECB RID: 48843 RVA: 0x00111621 File Offset: 0x0010F821
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDistance.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDistance.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00111644 File Offset: 0x0010F844
		// (set) Token: 0x0600BECD RID: 48845 RVA: 0x0011167D File Offset: 0x0010F87D
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDistance.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDistance.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BECE RID: 48846 RVA: 0x0011169E File Offset: 0x0010F89E
		static UMaterialExpressionDistance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDistance");
		}

		// Token: 0x0600BECF RID: 48847 RVA: 0x001116AC File Offset: 0x0010F8AC
		protected UMaterialExpressionDistance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064E5 RID: 25829
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDistance";

		// Token: 0x040064E6 RID: 25830
		private static IntPtr _ClassPtr;

		// Token: 0x040064E7 RID: 25831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064E8 RID: 25832
		internal static int __PropertyOffset_A;

		// Token: 0x040064E9 RID: 25833
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040064EA RID: 25834
		internal static int __PropertyOffset_B;

		// Token: 0x040064EB RID: 25835
		[Nullable(2)]
		private FExpressionInput _B;
	}
}
