using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F1 RID: 5361
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterInt")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UHoudiniParameterInt : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060136D2 RID: 79570 RVA: 0x001C8F96 File Offset: 0x001C7196
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterInt._ClassPtr;
		}

		// Token: 0x060136D3 RID: 79571 RVA: 0x001C8FA4 File Offset: 0x001C71A4
		public UHoudiniParameterInt() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterInt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060136D4 RID: 79572 RVA: 0x001C8FCC File Offset: 0x001C71CC
		public UHoudiniParameterInt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x060136D5 RID: 79573 RVA: 0x001C9000 File Offset: 0x001C7200
		// (set) Token: 0x060136D6 RID: 79574 RVA: 0x001C9039 File Offset: 0x001C7239
		public TArray<int> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x060136D7 RID: 79575 RVA: 0x001C9048 File Offset: 0x001C7248
		// (set) Token: 0x060136D8 RID: 79576 RVA: 0x001C9081 File Offset: 0x001C7281
		public TArray<int> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x060136D9 RID: 79577 RVA: 0x001C908F File Offset: 0x001C728F
		// (set) Token: 0x060136DA RID: 79578 RVA: 0x001C90A3 File Offset: 0x001C72A3
		public unsafe string Unit
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterInt.__PropertyOffset_Unit)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterInt.__PropertyOffset_Unit)), value);
			}
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x060136DB RID: 79579 RVA: 0x001C90B8 File Offset: 0x001C72B8
		// (set) Token: 0x060136DC RID: 79580 RVA: 0x001C90C8 File Offset: 0x001C72C8
		public unsafe bool bHasMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasMin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasMin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x060136DD RID: 79581 RVA: 0x001C90D9 File Offset: 0x001C72D9
		// (set) Token: 0x060136DE RID: 79582 RVA: 0x001C90E9 File Offset: 0x001C72E9
		public unsafe bool bHasMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x060136DF RID: 79583 RVA: 0x001C90FA File Offset: 0x001C72FA
		// (set) Token: 0x060136E0 RID: 79584 RVA: 0x001C910A File Offset: 0x001C730A
		public unsafe bool bHasUIMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasUIMin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasUIMin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x060136E1 RID: 79585 RVA: 0x001C911B File Offset: 0x001C731B
		// (set) Token: 0x060136E2 RID: 79586 RVA: 0x001C912B File Offset: 0x001C732B
		public unsafe bool bHasUIMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasUIMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bHasUIMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x060136E3 RID: 79587 RVA: 0x001C913C File Offset: 0x001C733C
		// (set) Token: 0x060136E4 RID: 79588 RVA: 0x001C914C File Offset: 0x001C734C
		public unsafe bool bIsLogarithmic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bIsLogarithmic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_bIsLogarithmic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x060136E5 RID: 79589 RVA: 0x001C915D File Offset: 0x001C735D
		// (set) Token: 0x060136E6 RID: 79590 RVA: 0x001C916D File Offset: 0x001C736D
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x060136E7 RID: 79591 RVA: 0x001C917E File Offset: 0x001C737E
		// (set) Token: 0x060136E8 RID: 79592 RVA: 0x001C918E File Offset: 0x001C738E
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x060136E9 RID: 79593 RVA: 0x001C919F File Offset: 0x001C739F
		// (set) Token: 0x060136EA RID: 79594 RVA: 0x001C91AF File Offset: 0x001C73AF
		public unsafe int UIMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_UIMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_UIMin) = value;
			}
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x060136EB RID: 79595 RVA: 0x001C91C0 File Offset: 0x001C73C0
		// (set) Token: 0x060136EC RID: 79596 RVA: 0x001C91D0 File Offset: 0x001C73D0
		public unsafe int UIMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_UIMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterInt.__PropertyOffset_UIMax) = value;
			}
		}

		// Token: 0x060136ED RID: 79597 RVA: 0x001C91E1 File Offset: 0x001C73E1
		static UHoudiniParameterInt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterInt");
		}

		// Token: 0x060136EE RID: 79598 RVA: 0x001C91EF File Offset: 0x001C73EF
		protected UHoudiniParameterInt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7F6 RID: 42998
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterInt";

		// Token: 0x0400A7F7 RID: 42999
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7F8 RID: 43000
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7F9 RID: 43001
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A7FA RID: 43002
		[Nullable(2)]
		private TArray<int> _Values;

		// Token: 0x0400A7FB RID: 43003
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A7FC RID: 43004
		[Nullable(2)]
		private TArray<int> _DefaultValues;

		// Token: 0x0400A7FD RID: 43005
		internal static int __PropertyOffset_Unit;

		// Token: 0x0400A7FE RID: 43006
		internal static int __PropertyOffset_bHasMin;

		// Token: 0x0400A7FF RID: 43007
		internal static int __PropertyOffset_bHasMax;

		// Token: 0x0400A800 RID: 43008
		internal static int __PropertyOffset_bHasUIMin;

		// Token: 0x0400A801 RID: 43009
		internal static int __PropertyOffset_bHasUIMax;

		// Token: 0x0400A802 RID: 43010
		internal static int __PropertyOffset_bIsLogarithmic;

		// Token: 0x0400A803 RID: 43011
		internal static int __PropertyOffset_Min;

		// Token: 0x0400A804 RID: 43012
		internal static int __PropertyOffset_Max;

		// Token: 0x0400A805 RID: 43013
		internal static int __PropertyOffset_UIMin;

		// Token: 0x0400A806 RID: 43014
		internal static int __PropertyOffset_UIMax;
	}
}
