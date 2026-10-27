using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D89 RID: 3465
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArctangent2")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionArctangent2 : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD2F RID: 48431 RVA: 0x0010E7F5 File Offset: 0x0010C9F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArctangent2._ClassPtr;
		}

		// Token: 0x0600BD30 RID: 48432 RVA: 0x0010E804 File Offset: 0x0010CA04
		public UMaterialExpressionArctangent2() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD31 RID: 48433 RVA: 0x0010E82C File Offset: 0x0010CA2C
		public UMaterialExpressionArctangent2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangent2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600BD32 RID: 48434 RVA: 0x0010E860 File Offset: 0x0010CA60
		// (set) Token: 0x0600BD33 RID: 48435 RVA: 0x0010E899 File Offset: 0x0010CA99
		public FExpressionInput Y
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Y) == null)
				{
					result = (this._Y = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangent2.__PropertyOffset_Y, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangent2.__PropertyOffset_Y, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0600BD34 RID: 48436 RVA: 0x0010E8BC File Offset: 0x0010CABC
		// (set) Token: 0x0600BD35 RID: 48437 RVA: 0x0010E8F5 File Offset: 0x0010CAF5
		public FExpressionInput X
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangent2.__PropertyOffset_X, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangent2.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x0010E916 File Offset: 0x0010CB16
		static UMaterialExpressionArctangent2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArctangent2");
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x0010E924 File Offset: 0x0010CB24
		protected UMaterialExpressionArctangent2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063CE RID: 25550
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArctangent2";

		// Token: 0x040063CF RID: 25551
		private static IntPtr _ClassPtr;

		// Token: 0x040063D0 RID: 25552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063D1 RID: 25553
		internal static int __PropertyOffset_Y;

		// Token: 0x040063D2 RID: 25554
		[Nullable(2)]
		private FExpressionInput _Y;

		// Token: 0x040063D3 RID: 25555
		internal static int __PropertyOffset_X;

		// Token: 0x040063D4 RID: 25556
		[Nullable(2)]
		private FExpressionInput _X;
	}
}
