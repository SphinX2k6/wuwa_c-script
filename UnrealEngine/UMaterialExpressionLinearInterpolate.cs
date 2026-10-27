using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DEF RID: 3567
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLinearInterpolate")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionLinearInterpolate : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0E7 RID: 49383 RVA: 0x0011574E File Offset: 0x0011394E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLinearInterpolate._ClassPtr;
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x0011575C File Offset: 0x0011395C
		public UMaterialExpressionLinearInterpolate() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLinearInterpolate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x00115784 File Offset: 0x00113984
		public UMaterialExpressionLinearInterpolate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLinearInterpolate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x001157B8 File Offset: 0x001139B8
		// (set) Token: 0x0600C0EB RID: 49387 RVA: 0x001157F1 File Offset: 0x001139F1
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x00115814 File Offset: 0x00113A14
		// (set) Token: 0x0600C0ED RID: 49389 RVA: 0x0011584D File Offset: 0x00113A4D
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x00115870 File Offset: 0x00113A70
		// (set) Token: 0x0600C0EF RID: 49391 RVA: 0x001158A9 File Offset: 0x00113AA9
		public FExpressionInput Alpha
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Alpha) == null)
				{
					result = (this._Alpha = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_Alpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_Alpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x001158CA File Offset: 0x00113ACA
		// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x001158DA File Offset: 0x00113ADA
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x001158EB File Offset: 0x00113AEB
		// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x001158FB File Offset: 0x00113AFB
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x0011590C File Offset: 0x00113B0C
		// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x0011591C File Offset: 0x00113B1C
		public unsafe float ConstAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLinearInterpolate.__PropertyOffset_ConstAlpha) = value;
			}
		}

		// Token: 0x0600C0F6 RID: 49398 RVA: 0x0011592D File Offset: 0x00113B2D
		static UMaterialExpressionLinearInterpolate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLinearInterpolate");
		}

		// Token: 0x0600C0F7 RID: 49399 RVA: 0x0011593B File Offset: 0x00113B3B
		protected UMaterialExpressionLinearInterpolate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400666B RID: 26219
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLinearInterpolate";

		// Token: 0x0400666C RID: 26220
		private static IntPtr _ClassPtr;

		// Token: 0x0400666D RID: 26221
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400666E RID: 26222
		internal static int __PropertyOffset_A;

		// Token: 0x0400666F RID: 26223
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x04006670 RID: 26224
		internal static int __PropertyOffset_B;

		// Token: 0x04006671 RID: 26225
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x04006672 RID: 26226
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04006673 RID: 26227
		[Nullable(2)]
		private FExpressionInput _Alpha;

		// Token: 0x04006674 RID: 26228
		internal static int __PropertyOffset_ConstA;

		// Token: 0x04006675 RID: 26229
		internal static int __PropertyOffset_ConstB;

		// Token: 0x04006676 RID: 26230
		internal static int __PropertyOffset_ConstAlpha;
	}
}
