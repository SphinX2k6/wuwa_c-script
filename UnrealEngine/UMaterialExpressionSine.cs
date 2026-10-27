using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E41 RID: 3649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSine")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionSine : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3EB RID: 50155 RVA: 0x0011B0F1 File Offset: 0x001192F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSine._ClassPtr;
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x0011B100 File Offset: 0x00119300
		public UMaterialExpressionSine() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x0011B128 File Offset: 0x00119328
		public UMaterialExpressionSine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x0011B15C File Offset: 0x0011935C
		// (set) Token: 0x0600C3EF RID: 50159 RVA: 0x0011B195 File Offset: 0x00119395
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSine.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSine.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x0011B1B6 File Offset: 0x001193B6
		// (set) Token: 0x0600C3F1 RID: 50161 RVA: 0x0011B1C6 File Offset: 0x001193C6
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSine.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSine.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0600C3F2 RID: 50162 RVA: 0x0011B1D7 File Offset: 0x001193D7
		static UMaterialExpressionSine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSine");
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x0011B1E5 File Offset: 0x001193E5
		protected UMaterialExpressionSine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006887 RID: 26759
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSine";

		// Token: 0x04006888 RID: 26760
		private static IntPtr _ClassPtr;

		// Token: 0x04006889 RID: 26761
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400688A RID: 26762
		internal static int __PropertyOffset_Input;

		// Token: 0x0400688B RID: 26763
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400688C RID: 26764
		internal static int __PropertyOffset_Period;
	}
}
