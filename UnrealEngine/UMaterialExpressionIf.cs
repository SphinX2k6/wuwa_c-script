using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD4 RID: 3540
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionIf")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UMaterialExpressionIf : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFDA RID: 49114 RVA: 0x001135F5 File Offset: 0x001117F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionIf._ClassPtr;
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x00113604 File Offset: 0x00111804
		public UMaterialExpressionIf() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionIf.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x0011362C File Offset: 0x0011182C
		public UMaterialExpressionIf(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionIf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x0600BFDD RID: 49117 RVA: 0x00113660 File Offset: 0x00111860
		// (set) Token: 0x0600BFDE RID: 49118 RVA: 0x00113699 File Offset: 0x00111899
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600BFDF RID: 49119 RVA: 0x001136BC File Offset: 0x001118BC
		// (set) Token: 0x0600BFE0 RID: 49120 RVA: 0x001136F5 File Offset: 0x001118F5
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600BFE1 RID: 49121 RVA: 0x00113718 File Offset: 0x00111918
		// (set) Token: 0x0600BFE2 RID: 49122 RVA: 0x00113751 File Offset: 0x00111951
		public FExpressionInput AGreaterThanB
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._AGreaterThanB) == null)
				{
					result = (this._AGreaterThanB = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_AGreaterThanB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_AGreaterThanB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x00113774 File Offset: 0x00111974
		// (set) Token: 0x0600BFE4 RID: 49124 RVA: 0x001137AD File Offset: 0x001119AD
		public FExpressionInput AEqualsB
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._AEqualsB) == null)
				{
					result = (this._AEqualsB = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_AEqualsB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_AEqualsB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x001137D0 File Offset: 0x001119D0
		// (set) Token: 0x0600BFE6 RID: 49126 RVA: 0x00113809 File Offset: 0x00111A09
		public FExpressionInput ALessThanB
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ALessThanB) == null)
				{
					result = (this._ALessThanB = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ALessThanB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ALessThanB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600BFE7 RID: 49127 RVA: 0x0011382A File Offset: 0x00111A2A
		// (set) Token: 0x0600BFE8 RID: 49128 RVA: 0x0011383A File Offset: 0x00111A3A
		public unsafe float EqualsThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_EqualsThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_EqualsThreshold) = value;
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0600BFE9 RID: 49129 RVA: 0x0011384B File Offset: 0x00111A4B
		// (set) Token: 0x0600BFEA RID: 49130 RVA: 0x0011385B File Offset: 0x00111A5B
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0600BFEB RID: 49131 RVA: 0x0011386C File Offset: 0x00111A6C
		// (set) Token: 0x0600BFEC RID: 49132 RVA: 0x0011387C File Offset: 0x00111A7C
		public unsafe float ConstAEqualsB_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ConstAEqualsB_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionIf.__PropertyOffset_ConstAEqualsB_DEPRECATED) = value;
			}
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x0011388D File Offset: 0x00111A8D
		static UMaterialExpressionIf()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionIf");
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x0011389B File Offset: 0x00111A9B
		protected UMaterialExpressionIf(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065A7 RID: 26023
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionIf";

		// Token: 0x040065A8 RID: 26024
		private static IntPtr _ClassPtr;

		// Token: 0x040065A9 RID: 26025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065AA RID: 26026
		internal static int __PropertyOffset_A;

		// Token: 0x040065AB RID: 26027
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040065AC RID: 26028
		internal static int __PropertyOffset_B;

		// Token: 0x040065AD RID: 26029
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040065AE RID: 26030
		internal static int __PropertyOffset_AGreaterThanB;

		// Token: 0x040065AF RID: 26031
		[Nullable(2)]
		private FExpressionInput _AGreaterThanB;

		// Token: 0x040065B0 RID: 26032
		internal static int __PropertyOffset_AEqualsB;

		// Token: 0x040065B1 RID: 26033
		[Nullable(2)]
		private FExpressionInput _AEqualsB;

		// Token: 0x040065B2 RID: 26034
		internal static int __PropertyOffset_ALessThanB;

		// Token: 0x040065B3 RID: 26035
		[Nullable(2)]
		private FExpressionInput _ALessThanB;

		// Token: 0x040065B4 RID: 26036
		internal static int __PropertyOffset_EqualsThreshold;

		// Token: 0x040065B5 RID: 26037
		internal static int __PropertyOffset_ConstB;

		// Token: 0x040065B6 RID: 26038
		internal static int __PropertyOffset_ConstAEqualsB_DEPRECATED;
	}
}
