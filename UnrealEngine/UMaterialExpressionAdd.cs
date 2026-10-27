using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D81 RID: 3457
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAdd")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionAdd : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCED RID: 48365 RVA: 0x0010E032 File Offset: 0x0010C232
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAdd._ClassPtr;
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x0010E040 File Offset: 0x0010C240
		public UMaterialExpressionAdd() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAdd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x0010E068 File Offset: 0x0010C268
		public UMaterialExpressionAdd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAdd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600BCF0 RID: 48368 RVA: 0x0010E09C File Offset: 0x0010C29C
		// (set) Token: 0x0600BCF1 RID: 48369 RVA: 0x0010E0D5 File Offset: 0x0010C2D5
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0600BCF2 RID: 48370 RVA: 0x0010E0F8 File Offset: 0x0010C2F8
		// (set) Token: 0x0600BCF3 RID: 48371 RVA: 0x0010E131 File Offset: 0x0010C331
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0600BCF4 RID: 48372 RVA: 0x0010E152 File Offset: 0x0010C352
		// (set) Token: 0x0600BCF5 RID: 48373 RVA: 0x0010E162 File Offset: 0x0010C362
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0600BCF6 RID: 48374 RVA: 0x0010E173 File Offset: 0x0010C373
		// (set) Token: 0x0600BCF7 RID: 48375 RVA: 0x0010E183 File Offset: 0x0010C383
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionAdd.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x0010E194 File Offset: 0x0010C394
		static UMaterialExpressionAdd()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAdd");
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x0010E1A2 File Offset: 0x0010C3A2
		protected UMaterialExpressionAdd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063A0 RID: 25504
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAdd";

		// Token: 0x040063A1 RID: 25505
		private static IntPtr _ClassPtr;

		// Token: 0x040063A2 RID: 25506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063A3 RID: 25507
		internal static int __PropertyOffset_A;

		// Token: 0x040063A4 RID: 25508
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040063A5 RID: 25509
		internal static int __PropertyOffset_B;

		// Token: 0x040063A6 RID: 25510
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040063A7 RID: 25511
		internal static int __PropertyOffset_ConstA;

		// Token: 0x040063A8 RID: 25512
		internal static int __PropertyOffset_ConstB;
	}
}
