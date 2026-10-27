using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF8 RID: 3576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMax")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionMax : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C170 RID: 49520 RVA: 0x00116A19 File Offset: 0x00114C19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMax._ClassPtr;
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x00116A28 File Offset: 0x00114C28
		public UMaterialExpressionMax() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMax.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C172 RID: 49522 RVA: 0x00116A50 File Offset: 0x00114C50
		public UMaterialExpressionMax(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMax.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600C173 RID: 49523 RVA: 0x00116A84 File Offset: 0x00114C84
		// (set) Token: 0x0600C174 RID: 49524 RVA: 0x00116ABD File Offset: 0x00114CBD
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600C175 RID: 49525 RVA: 0x00116AE0 File Offset: 0x00114CE0
		// (set) Token: 0x0600C176 RID: 49526 RVA: 0x00116B19 File Offset: 0x00114D19
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x0600C177 RID: 49527 RVA: 0x00116B3A File Offset: 0x00114D3A
		// (set) Token: 0x0600C178 RID: 49528 RVA: 0x00116B4A File Offset: 0x00114D4A
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002CF1 RID: 11505
		// (get) Token: 0x0600C179 RID: 49529 RVA: 0x00116B5B File Offset: 0x00114D5B
		// (set) Token: 0x0600C17A RID: 49530 RVA: 0x00116B6B File Offset: 0x00114D6B
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMax.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600C17B RID: 49531 RVA: 0x00116B7C File Offset: 0x00114D7C
		static UMaterialExpressionMax()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMax");
		}

		// Token: 0x0600C17C RID: 49532 RVA: 0x00116B8A File Offset: 0x00114D8A
		protected UMaterialExpressionMax(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066D9 RID: 26329
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMax";

		// Token: 0x040066DA RID: 26330
		private static IntPtr _ClassPtr;

		// Token: 0x040066DB RID: 26331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066DC RID: 26332
		internal static int __PropertyOffset_A;

		// Token: 0x040066DD RID: 26333
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040066DE RID: 26334
		internal static int __PropertyOffset_B;

		// Token: 0x040066DF RID: 26335
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040066E0 RID: 26336
		internal static int __PropertyOffset_ConstA;

		// Token: 0x040066E1 RID: 26337
		internal static int __PropertyOffset_ConstB;
	}
}
