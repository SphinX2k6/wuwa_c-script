using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD5 RID: 3541
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionIfCondition")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMaterialExpressionIfCondition : UMaterialExpressionBranchCondition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFEF RID: 49135 RVA: 0x001138A4 File Offset: 0x00111AA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionIfCondition._ClassPtr;
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x001138B0 File Offset: 0x00111AB0
		public UMaterialExpressionIfCondition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionIfCondition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x001138D8 File Offset: 0x00111AD8
		public UMaterialExpressionIfCondition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionIfCondition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x0011390C File Offset: 0x00111B0C
		// (set) Token: 0x0600BFF3 RID: 49139 RVA: 0x00113945 File Offset: 0x00111B45
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0600BFF4 RID: 49140 RVA: 0x00113968 File Offset: 0x00111B68
		// (set) Token: 0x0600BFF5 RID: 49141 RVA: 0x001139A1 File Offset: 0x00111BA1
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0600BFF6 RID: 49142 RVA: 0x001139C2 File Offset: 0x00111BC2
		// (set) Token: 0x0600BFF7 RID: 49143 RVA: 0x001139D2 File Offset: 0x00111BD2
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionIfCondition.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600BFF8 RID: 49144 RVA: 0x001139E3 File Offset: 0x00111BE3
		static UMaterialExpressionIfCondition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionIfCondition");
		}

		// Token: 0x0600BFF9 RID: 49145 RVA: 0x001139F1 File Offset: 0x00111BF1
		protected UMaterialExpressionIfCondition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065B7 RID: 26039
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionIfCondition";

		// Token: 0x040065B8 RID: 26040
		private static IntPtr _ClassPtr;

		// Token: 0x040065B9 RID: 26041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065BA RID: 26042
		internal static int __PropertyOffset_A;

		// Token: 0x040065BB RID: 26043
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040065BC RID: 26044
		internal static int __PropertyOffset_B;

		// Token: 0x040065BD RID: 26045
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040065BE RID: 26046
		internal static int __PropertyOffset_ConstB;
	}
}
