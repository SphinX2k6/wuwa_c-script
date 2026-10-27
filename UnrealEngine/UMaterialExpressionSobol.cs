using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4B RID: 3659
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSobol")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionSobol : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C44F RID: 50255 RVA: 0x0011BD4C File Offset: 0x00119F4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSobol._ClassPtr;
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x0011BD58 File Offset: 0x00119F58
		public UMaterialExpressionSobol() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSobol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x0011BD80 File Offset: 0x00119F80
		public UMaterialExpressionSobol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSobol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600C452 RID: 50258 RVA: 0x0011BDB4 File Offset: 0x00119FB4
		// (set) Token: 0x0600C453 RID: 50259 RVA: 0x0011BDED File Offset: 0x00119FED
		public FExpressionInput Cell
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Cell) == null)
				{
					result = (this._Cell = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Cell, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Cell, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600C454 RID: 50260 RVA: 0x0011BE10 File Offset: 0x0011A010
		// (set) Token: 0x0600C455 RID: 50261 RVA: 0x0011BE49 File Offset: 0x0011A049
		public FExpressionInput Index
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Index) == null)
				{
					result = (this._Index = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Index, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Index, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600C456 RID: 50262 RVA: 0x0011BE6C File Offset: 0x0011A06C
		// (set) Token: 0x0600C457 RID: 50263 RVA: 0x0011BEA5 File Offset: 0x0011A0A5
		public FExpressionInput Seed
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Seed) == null)
				{
					result = (this._Seed = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Seed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_Seed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600C458 RID: 50264 RVA: 0x0011BEC6 File Offset: 0x0011A0C6
		// (set) Token: 0x0600C459 RID: 50265 RVA: 0x0011BED6 File Offset: 0x0011A0D6
		public unsafe uint ConstIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_ConstIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_ConstIndex) = (int)value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0600C45A RID: 50266 RVA: 0x0011BEE7 File Offset: 0x0011A0E7
		// (set) Token: 0x0600C45B RID: 50267 RVA: 0x0011BEFB File Offset: 0x0011A0FB
		public unsafe FVector2D ConstSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_ConstSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSobol.__PropertyOffset_ConstSeed) = value;
			}
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x0011BF10 File Offset: 0x0011A110
		static UMaterialExpressionSobol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSobol");
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x0011BF1E File Offset: 0x0011A11E
		protected UMaterialExpressionSobol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068D0 RID: 26832
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSobol";

		// Token: 0x040068D1 RID: 26833
		private static IntPtr _ClassPtr;

		// Token: 0x040068D2 RID: 26834
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068D3 RID: 26835
		internal static int __PropertyOffset_Cell;

		// Token: 0x040068D4 RID: 26836
		[Nullable(2)]
		private FExpressionInput _Cell;

		// Token: 0x040068D5 RID: 26837
		internal static int __PropertyOffset_Index;

		// Token: 0x040068D6 RID: 26838
		[Nullable(2)]
		private FExpressionInput _Index;

		// Token: 0x040068D7 RID: 26839
		internal static int __PropertyOffset_Seed;

		// Token: 0x040068D8 RID: 26840
		[Nullable(2)]
		private FExpressionInput _Seed;

		// Token: 0x040068D9 RID: 26841
		internal static int __PropertyOffset_ConstIndex;

		// Token: 0x040068DA RID: 26842
		internal static int __PropertyOffset_ConstSeed;
	}
}
