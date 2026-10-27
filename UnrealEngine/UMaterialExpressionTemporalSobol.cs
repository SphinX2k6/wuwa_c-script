using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5E RID: 3678
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTemporalSobol")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMaterialExpressionTemporalSobol : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C519 RID: 50457 RVA: 0x0011D4C9 File Offset: 0x0011B6C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTemporalSobol._ClassPtr;
		}

		// Token: 0x0600C51A RID: 50458 RVA: 0x0011D4D8 File Offset: 0x0011B6D8
		public UMaterialExpressionTemporalSobol() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTemporalSobol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C51B RID: 50459 RVA: 0x0011D500 File Offset: 0x0011B700
		public UMaterialExpressionTemporalSobol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTemporalSobol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600C51C RID: 50460 RVA: 0x0011D534 File Offset: 0x0011B734
		// (set) Token: 0x0600C51D RID: 50461 RVA: 0x0011D56D File Offset: 0x0011B76D
		public FExpressionInput Index
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Index) == null)
				{
					result = (this._Index = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_Index, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_Index, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600C51E RID: 50462 RVA: 0x0011D590 File Offset: 0x0011B790
		// (set) Token: 0x0600C51F RID: 50463 RVA: 0x0011D5C9 File Offset: 0x0011B7C9
		public FExpressionInput Seed
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Seed) == null)
				{
					result = (this._Seed = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_Seed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_Seed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600C520 RID: 50464 RVA: 0x0011D5EA File Offset: 0x0011B7EA
		// (set) Token: 0x0600C521 RID: 50465 RVA: 0x0011D5FA File Offset: 0x0011B7FA
		public unsafe uint ConstIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_ConstIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_ConstIndex) = (int)value;
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600C522 RID: 50466 RVA: 0x0011D60B File Offset: 0x0011B80B
		// (set) Token: 0x0600C523 RID: 50467 RVA: 0x0011D61F File Offset: 0x0011B81F
		public unsafe FVector2D ConstSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_ConstSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTemporalSobol.__PropertyOffset_ConstSeed) = value;
			}
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x0011D634 File Offset: 0x0011B834
		static UMaterialExpressionTemporalSobol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTemporalSobol");
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x0011D642 File Offset: 0x0011B842
		protected UMaterialExpressionTemporalSobol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006960 RID: 26976
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTemporalSobol";

		// Token: 0x04006961 RID: 26977
		private static IntPtr _ClassPtr;

		// Token: 0x04006962 RID: 26978
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006963 RID: 26979
		internal static int __PropertyOffset_Index;

		// Token: 0x04006964 RID: 26980
		[Nullable(2)]
		private FExpressionInput _Index;

		// Token: 0x04006965 RID: 26981
		internal static int __PropertyOffset_Seed;

		// Token: 0x04006966 RID: 26982
		[Nullable(2)]
		private FExpressionInput _Seed;

		// Token: 0x04006967 RID: 26983
		internal static int __PropertyOffset_ConstIndex;

		// Token: 0x04006968 RID: 26984
		internal static int __PropertyOffset_ConstSeed;
	}
}
