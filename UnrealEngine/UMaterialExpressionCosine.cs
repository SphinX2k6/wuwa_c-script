using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA6 RID: 3494
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCosine")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionCosine : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE35 RID: 48693 RVA: 0x001104EF File Offset: 0x0010E6EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCosine._ClassPtr;
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x001104FC File Offset: 0x0010E6FC
		public UMaterialExpressionCosine() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCosine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x00110524 File Offset: 0x0010E724
		public UMaterialExpressionCosine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCosine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600BE38 RID: 48696 RVA: 0x00110558 File Offset: 0x0010E758
		// (set) Token: 0x0600BE39 RID: 48697 RVA: 0x00110591 File Offset: 0x0010E791
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCosine.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCosine.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600BE3A RID: 48698 RVA: 0x001105B2 File Offset: 0x0010E7B2
		// (set) Token: 0x0600BE3B RID: 48699 RVA: 0x001105C2 File Offset: 0x0010E7C2
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionCosine.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionCosine.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0600BE3C RID: 48700 RVA: 0x001105D3 File Offset: 0x0010E7D3
		static UMaterialExpressionCosine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCosine");
		}

		// Token: 0x0600BE3D RID: 48701 RVA: 0x001105E1 File Offset: 0x0010E7E1
		protected UMaterialExpressionCosine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006480 RID: 25728
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCosine";

		// Token: 0x04006481 RID: 25729
		private static IntPtr _ClassPtr;

		// Token: 0x04006482 RID: 25730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006483 RID: 25731
		internal static int __PropertyOffset_Input;

		// Token: 0x04006484 RID: 25732
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006485 RID: 25733
		internal static int __PropertyOffset_Period;
	}
}
