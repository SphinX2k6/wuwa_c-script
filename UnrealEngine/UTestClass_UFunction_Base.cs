using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002746 RID: 10054
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class UTestClass_UFunction_Base : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602548E RID: 152718 RVA: 0x003753D8 File Offset: 0x003735D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Base._ClassPtr;
		}

		// Token: 0x0602548F RID: 152719 RVA: 0x003753E4 File Offset: 0x003735E4
		public UTestClass_UFunction_Base() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025490 RID: 152720 RVA: 0x0037540C File Offset: 0x0037360C
		[NullableContext(1)]
		public UTestClass_UFunction_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009018 RID: 36888
		// (get) Token: 0x06025491 RID: 152721 RVA: 0x0037543F File Offset: 0x0037363F
		// (set) Token: 0x06025492 RID: 152722 RVA: 0x0037544F File Offset: 0x0037364F
		public unsafe bool Bool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_Bool) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_Bool) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009019 RID: 36889
		// (get) Token: 0x06025493 RID: 152723 RVA: 0x00375460 File Offset: 0x00373660
		// (set) Token: 0x06025494 RID: 152724 RVA: 0x00375499 File Offset: 0x00373699
		[Nullable(1)]
		public TArray<bool> BoolArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._BoolArray) == null)
				{
					result = (this._BoolArray = new TArray<bool>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_BoolArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolArray.CopyAssign(value);
			}
		}

		// Token: 0x1700901A RID: 36890
		// (get) Token: 0x06025495 RID: 152725 RVA: 0x003754A8 File Offset: 0x003736A8
		// (set) Token: 0x06025496 RID: 152726 RVA: 0x003754E1 File Offset: 0x003736E1
		[Nullable(1)]
		public TSet<bool> BoolSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<bool> result;
				if ((result = this._BoolSet) == null)
				{
					result = (this._BoolSet = new TSet<bool>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_BoolSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolSet.CopyAssign(value);
			}
		}

		// Token: 0x1700901B RID: 36891
		// (get) Token: 0x06025497 RID: 152727 RVA: 0x003754F0 File Offset: 0x003736F0
		// (set) Token: 0x06025498 RID: 152728 RVA: 0x00375529 File Offset: 0x00373729
		[Nullable(1)]
		public TMap<bool, int> BoolMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<bool, int> result;
				if ((result = this._BoolMap) == null)
				{
					result = (this._BoolMap = new TMap<bool, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_BoolMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolMap.CopyAssign(value);
			}
		}

		// Token: 0x1700901C RID: 36892
		// (get) Token: 0x06025499 RID: 152729 RVA: 0x00375537 File Offset: 0x00373737
		// (set) Token: 0x0602549A RID: 152730 RVA: 0x00375547 File Offset: 0x00373747
		public unsafe sbyte I8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I8) = (byte)value;
			}
		}

		// Token: 0x1700901D RID: 36893
		// (get) Token: 0x0602549B RID: 152731 RVA: 0x00375558 File Offset: 0x00373758
		// (set) Token: 0x0602549C RID: 152732 RVA: 0x00375591 File Offset: 0x00373791
		[Nullable(1)]
		public TArray<sbyte> I8Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._I8Array) == null)
				{
					result = (this._I8Array = new TArray<sbyte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I8Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Array.CopyAssign(value);
			}
		}

		// Token: 0x1700901E RID: 36894
		// (get) Token: 0x0602549D RID: 152733 RVA: 0x003755A0 File Offset: 0x003737A0
		// (set) Token: 0x0602549E RID: 152734 RVA: 0x003755D9 File Offset: 0x003737D9
		[Nullable(1)]
		public TSet<sbyte> I8Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<sbyte> result;
				if ((result = this._I8Set) == null)
				{
					result = (this._I8Set = new TSet<sbyte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I8Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Set.CopyAssign(value);
			}
		}

		// Token: 0x1700901F RID: 36895
		// (get) Token: 0x0602549F RID: 152735 RVA: 0x003755E8 File Offset: 0x003737E8
		// (set) Token: 0x060254A0 RID: 152736 RVA: 0x00375621 File Offset: 0x00373821
		[Nullable(1)]
		public TMap<sbyte, int> I8Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<sbyte, int> result;
				if ((result = this._I8Map) == null)
				{
					result = (this._I8Map = new TMap<sbyte, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I8Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Map.CopyAssign(value);
			}
		}

		// Token: 0x17009020 RID: 36896
		// (get) Token: 0x060254A1 RID: 152737 RVA: 0x0037562F File Offset: 0x0037382F
		// (set) Token: 0x060254A2 RID: 152738 RVA: 0x0037563F File Offset: 0x0037383F
		public unsafe byte U8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U8) = value;
			}
		}

		// Token: 0x17009021 RID: 36897
		// (get) Token: 0x060254A3 RID: 152739 RVA: 0x00375650 File Offset: 0x00373850
		// (set) Token: 0x060254A4 RID: 152740 RVA: 0x00375689 File Offset: 0x00373889
		[Nullable(1)]
		public TArray<byte> U8Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._U8Array) == null)
				{
					result = (this._U8Array = new TArray<byte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U8Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Array.CopyAssign(value);
			}
		}

		// Token: 0x17009022 RID: 36898
		// (get) Token: 0x060254A5 RID: 152741 RVA: 0x00375698 File Offset: 0x00373898
		// (set) Token: 0x060254A6 RID: 152742 RVA: 0x003756D1 File Offset: 0x003738D1
		[Nullable(1)]
		public TSet<byte> U8Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<byte> result;
				if ((result = this._U8Set) == null)
				{
					result = (this._U8Set = new TSet<byte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U8Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Set.CopyAssign(value);
			}
		}

		// Token: 0x17009023 RID: 36899
		// (get) Token: 0x060254A7 RID: 152743 RVA: 0x003756E0 File Offset: 0x003738E0
		// (set) Token: 0x060254A8 RID: 152744 RVA: 0x00375719 File Offset: 0x00373919
		[Nullable(1)]
		public TMap<byte, int> U8Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<byte, int> result;
				if ((result = this._U8Map) == null)
				{
					result = (this._U8Map = new TMap<byte, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U8Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Map.CopyAssign(value);
			}
		}

		// Token: 0x17009024 RID: 36900
		// (get) Token: 0x060254A9 RID: 152745 RVA: 0x00375727 File Offset: 0x00373927
		// (set) Token: 0x060254AA RID: 152746 RVA: 0x00375737 File Offset: 0x00373937
		public unsafe short I16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I16) = value;
			}
		}

		// Token: 0x17009025 RID: 36901
		// (get) Token: 0x060254AB RID: 152747 RVA: 0x00375748 File Offset: 0x00373948
		// (set) Token: 0x060254AC RID: 152748 RVA: 0x00375781 File Offset: 0x00373981
		[Nullable(1)]
		public TArray<short> I16Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<short> result;
				if ((result = this._I16Array) == null)
				{
					result = (this._I16Array = new TArray<short>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I16Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Array.CopyAssign(value);
			}
		}

		// Token: 0x17009026 RID: 36902
		// (get) Token: 0x060254AD RID: 152749 RVA: 0x00375790 File Offset: 0x00373990
		// (set) Token: 0x060254AE RID: 152750 RVA: 0x003757C9 File Offset: 0x003739C9
		[Nullable(1)]
		public TSet<short> I16Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<short> result;
				if ((result = this._I16Set) == null)
				{
					result = (this._I16Set = new TSet<short>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I16Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Set.CopyAssign(value);
			}
		}

		// Token: 0x17009027 RID: 36903
		// (get) Token: 0x060254AF RID: 152751 RVA: 0x003757D8 File Offset: 0x003739D8
		// (set) Token: 0x060254B0 RID: 152752 RVA: 0x00375811 File Offset: 0x00373A11
		[Nullable(1)]
		public TMap<short, int> I16Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<short, int> result;
				if ((result = this._I16Map) == null)
				{
					result = (this._I16Map = new TMap<short, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I16Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Map.CopyAssign(value);
			}
		}

		// Token: 0x17009028 RID: 36904
		// (get) Token: 0x060254B1 RID: 152753 RVA: 0x0037581F File Offset: 0x00373A1F
		// (set) Token: 0x060254B2 RID: 152754 RVA: 0x0037582F File Offset: 0x00373A2F
		public unsafe ushort U16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U16) = (short)value;
			}
		}

		// Token: 0x17009029 RID: 36905
		// (get) Token: 0x060254B3 RID: 152755 RVA: 0x00375840 File Offset: 0x00373A40
		// (set) Token: 0x060254B4 RID: 152756 RVA: 0x00375879 File Offset: 0x00373A79
		[Nullable(1)]
		public TArray<ushort> U16Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._U16Array) == null)
				{
					result = (this._U16Array = new TArray<ushort>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U16Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Array.CopyAssign(value);
			}
		}

		// Token: 0x1700902A RID: 36906
		// (get) Token: 0x060254B5 RID: 152757 RVA: 0x00375888 File Offset: 0x00373A88
		// (set) Token: 0x060254B6 RID: 152758 RVA: 0x003758C1 File Offset: 0x00373AC1
		[Nullable(1)]
		public TSet<ushort> U16Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<ushort> result;
				if ((result = this._U16Set) == null)
				{
					result = (this._U16Set = new TSet<ushort>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U16Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Set.CopyAssign(value);
			}
		}

		// Token: 0x1700902B RID: 36907
		// (get) Token: 0x060254B7 RID: 152759 RVA: 0x003758D0 File Offset: 0x00373AD0
		// (set) Token: 0x060254B8 RID: 152760 RVA: 0x00375909 File Offset: 0x00373B09
		[Nullable(1)]
		public TMap<ushort, int> U16Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<ushort, int> result;
				if ((result = this._U16Map) == null)
				{
					result = (this._U16Map = new TMap<ushort, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U16Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Map.CopyAssign(value);
			}
		}

		// Token: 0x1700902C RID: 36908
		// (get) Token: 0x060254B9 RID: 152761 RVA: 0x00375917 File Offset: 0x00373B17
		// (set) Token: 0x060254BA RID: 152762 RVA: 0x00375927 File Offset: 0x00373B27
		public unsafe int I32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I32) = value;
			}
		}

		// Token: 0x1700902D RID: 36909
		// (get) Token: 0x060254BB RID: 152763 RVA: 0x00375938 File Offset: 0x00373B38
		// (set) Token: 0x060254BC RID: 152764 RVA: 0x00375971 File Offset: 0x00373B71
		[Nullable(1)]
		public TArray<int> I32Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._I32Array) == null)
				{
					result = (this._I32Array = new TArray<int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Array.CopyAssign(value);
			}
		}

		// Token: 0x1700902E RID: 36910
		// (get) Token: 0x060254BD RID: 152765 RVA: 0x00375980 File Offset: 0x00373B80
		// (set) Token: 0x060254BE RID: 152766 RVA: 0x003759B9 File Offset: 0x00373BB9
		[Nullable(1)]
		public TSet<int> I32Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._I32Set) == null)
				{
					result = (this._I32Set = new TSet<int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Set.CopyAssign(value);
			}
		}

		// Token: 0x1700902F RID: 36911
		// (get) Token: 0x060254BF RID: 152767 RVA: 0x003759C8 File Offset: 0x00373BC8
		// (set) Token: 0x060254C0 RID: 152768 RVA: 0x00375A01 File Offset: 0x00373C01
		[Nullable(1)]
		public TMap<int, int> I32Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._I32Map) == null)
				{
					result = (this._I32Map = new TMap<int, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Map.CopyAssign(value);
			}
		}

		// Token: 0x17009030 RID: 36912
		// (get) Token: 0x060254C1 RID: 152769 RVA: 0x00375A0F File Offset: 0x00373C0F
		// (set) Token: 0x060254C2 RID: 152770 RVA: 0x00375A1F File Offset: 0x00373C1F
		public unsafe uint U32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U32) = (int)value;
			}
		}

		// Token: 0x17009031 RID: 36913
		// (get) Token: 0x060254C3 RID: 152771 RVA: 0x00375A30 File Offset: 0x00373C30
		// (set) Token: 0x060254C4 RID: 152772 RVA: 0x00375A69 File Offset: 0x00373C69
		[Nullable(1)]
		public TArray<uint> U32Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._U32Array) == null)
				{
					result = (this._U32Array = new TArray<uint>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Array.CopyAssign(value);
			}
		}

		// Token: 0x17009032 RID: 36914
		// (get) Token: 0x060254C5 RID: 152773 RVA: 0x00375A78 File Offset: 0x00373C78
		// (set) Token: 0x060254C6 RID: 152774 RVA: 0x00375AB1 File Offset: 0x00373CB1
		[Nullable(1)]
		public TSet<uint> U32Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<uint> result;
				if ((result = this._U32Set) == null)
				{
					result = (this._U32Set = new TSet<uint>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Set.CopyAssign(value);
			}
		}

		// Token: 0x17009033 RID: 36915
		// (get) Token: 0x060254C7 RID: 152775 RVA: 0x00375AC0 File Offset: 0x00373CC0
		// (set) Token: 0x060254C8 RID: 152776 RVA: 0x00375AF9 File Offset: 0x00373CF9
		[Nullable(1)]
		public TMap<uint, int> U32Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<uint, int> result;
				if ((result = this._U32Map) == null)
				{
					result = (this._U32Map = new TMap<uint, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Map.CopyAssign(value);
			}
		}

		// Token: 0x17009034 RID: 36916
		// (get) Token: 0x060254C9 RID: 152777 RVA: 0x00375B07 File Offset: 0x00373D07
		// (set) Token: 0x060254CA RID: 152778 RVA: 0x00375B17 File Offset: 0x00373D17
		public unsafe long I64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I64) = value;
			}
		}

		// Token: 0x17009035 RID: 36917
		// (get) Token: 0x060254CB RID: 152779 RVA: 0x00375B28 File Offset: 0x00373D28
		// (set) Token: 0x060254CC RID: 152780 RVA: 0x00375B61 File Offset: 0x00373D61
		[Nullable(1)]
		public TArray<long> I64Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._I64Array) == null)
				{
					result = (this._I64Array = new TArray<long>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Array.CopyAssign(value);
			}
		}

		// Token: 0x17009036 RID: 36918
		// (get) Token: 0x060254CD RID: 152781 RVA: 0x00375B70 File Offset: 0x00373D70
		// (set) Token: 0x060254CE RID: 152782 RVA: 0x00375BA9 File Offset: 0x00373DA9
		[Nullable(1)]
		public TSet<long> I64Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<long> result;
				if ((result = this._I64Set) == null)
				{
					result = (this._I64Set = new TSet<long>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Set.CopyAssign(value);
			}
		}

		// Token: 0x17009037 RID: 36919
		// (get) Token: 0x060254CF RID: 152783 RVA: 0x00375BB8 File Offset: 0x00373DB8
		// (set) Token: 0x060254D0 RID: 152784 RVA: 0x00375BF1 File Offset: 0x00373DF1
		[Nullable(1)]
		public TMap<long, int> I64Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<long, int> result;
				if ((result = this._I64Map) == null)
				{
					result = (this._I64Map = new TMap<long, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_I64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Map.CopyAssign(value);
			}
		}

		// Token: 0x17009038 RID: 36920
		// (get) Token: 0x060254D1 RID: 152785 RVA: 0x00375BFF File Offset: 0x00373DFF
		// (set) Token: 0x060254D2 RID: 152786 RVA: 0x00375C0F File Offset: 0x00373E0F
		public unsafe ulong U64
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U64));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U64) = (long)value;
			}
		}

		// Token: 0x17009039 RID: 36921
		// (get) Token: 0x060254D3 RID: 152787 RVA: 0x00375C20 File Offset: 0x00373E20
		// (set) Token: 0x060254D4 RID: 152788 RVA: 0x00375C59 File Offset: 0x00373E59
		[Nullable(1)]
		public TArray<ulong> U64Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ulong> result;
				if ((result = this._U64Array) == null)
				{
					result = (this._U64Array = new TArray<ulong>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Array.CopyAssign(value);
			}
		}

		// Token: 0x1700903A RID: 36922
		// (get) Token: 0x060254D5 RID: 152789 RVA: 0x00375C68 File Offset: 0x00373E68
		// (set) Token: 0x060254D6 RID: 152790 RVA: 0x00375CA1 File Offset: 0x00373EA1
		[Nullable(1)]
		public TSet<ulong> U64Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<ulong> result;
				if ((result = this._U64Set) == null)
				{
					result = (this._U64Set = new TSet<ulong>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Set.CopyAssign(value);
			}
		}

		// Token: 0x1700903B RID: 36923
		// (get) Token: 0x060254D7 RID: 152791 RVA: 0x00375CB0 File Offset: 0x00373EB0
		// (set) Token: 0x060254D8 RID: 152792 RVA: 0x00375CE9 File Offset: 0x00373EE9
		[Nullable(1)]
		public TMap<ulong, int> U64Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, int> result;
				if ((result = this._U64Map) == null)
				{
					result = (this._U64Map = new TMap<ulong, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_U64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Map.CopyAssign(value);
			}
		}

		// Token: 0x1700903C RID: 36924
		// (get) Token: 0x060254D9 RID: 152793 RVA: 0x00375CF7 File Offset: 0x00373EF7
		// (set) Token: 0x060254DA RID: 152794 RVA: 0x00375D07 File Offset: 0x00373F07
		public unsafe float F32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F32) = value;
			}
		}

		// Token: 0x1700903D RID: 36925
		// (get) Token: 0x060254DB RID: 152795 RVA: 0x00375D18 File Offset: 0x00373F18
		// (set) Token: 0x060254DC RID: 152796 RVA: 0x00375D51 File Offset: 0x00373F51
		[Nullable(1)]
		public TArray<float> F32Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._F32Array) == null)
				{
					result = (this._F32Array = new TArray<float>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Array.CopyAssign(value);
			}
		}

		// Token: 0x1700903E RID: 36926
		// (get) Token: 0x060254DD RID: 152797 RVA: 0x00375D60 File Offset: 0x00373F60
		// (set) Token: 0x060254DE RID: 152798 RVA: 0x00375D99 File Offset: 0x00373F99
		[Nullable(1)]
		public TSet<float> F32Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<float> result;
				if ((result = this._F32Set) == null)
				{
					result = (this._F32Set = new TSet<float>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Set.CopyAssign(value);
			}
		}

		// Token: 0x1700903F RID: 36927
		// (get) Token: 0x060254DF RID: 152799 RVA: 0x00375DA8 File Offset: 0x00373FA8
		// (set) Token: 0x060254E0 RID: 152800 RVA: 0x00375DE1 File Offset: 0x00373FE1
		[Nullable(1)]
		public TMap<float, int> F32Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<float, int> result;
				if ((result = this._F32Map) == null)
				{
					result = (this._F32Map = new TMap<float, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Map.CopyAssign(value);
			}
		}

		// Token: 0x17009040 RID: 36928
		// (get) Token: 0x060254E1 RID: 152801 RVA: 0x00375DEF File Offset: 0x00373FEF
		// (set) Token: 0x060254E2 RID: 152802 RVA: 0x00375DFF File Offset: 0x00373FFF
		public unsafe double F64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F64) = value;
			}
		}

		// Token: 0x17009041 RID: 36929
		// (get) Token: 0x060254E3 RID: 152803 RVA: 0x00375E10 File Offset: 0x00374010
		// (set) Token: 0x060254E4 RID: 152804 RVA: 0x00375E49 File Offset: 0x00374049
		[Nullable(1)]
		public TArray<double> F64Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<double> result;
				if ((result = this._F64Array) == null)
				{
					result = (this._F64Array = new TArray<double>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Array.CopyAssign(value);
			}
		}

		// Token: 0x17009042 RID: 36930
		// (get) Token: 0x060254E5 RID: 152805 RVA: 0x00375E58 File Offset: 0x00374058
		// (set) Token: 0x060254E6 RID: 152806 RVA: 0x00375E91 File Offset: 0x00374091
		[Nullable(1)]
		public TSet<double> F64Set
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<double> result;
				if ((result = this._F64Set) == null)
				{
					result = (this._F64Set = new TSet<double>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Set.CopyAssign(value);
			}
		}

		// Token: 0x17009043 RID: 36931
		// (get) Token: 0x060254E7 RID: 152807 RVA: 0x00375EA0 File Offset: 0x003740A0
		// (set) Token: 0x060254E8 RID: 152808 RVA: 0x00375ED9 File Offset: 0x003740D9
		[Nullable(1)]
		public TMap<double, int> F64Map
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<double, int> result;
				if ((result = this._F64Map) == null)
				{
					result = (this._F64Map = new TMap<double, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Base.__PropertyOffset_F64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Map.CopyAssign(value);
			}
		}

		// Token: 0x060254E9 RID: 152809 RVA: 0x00375EE8 File Offset: 0x003740E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Set(TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Base.__SetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Set != null)
			{
				InU8Set.CopyTo(&ptr->InU8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254EA RID: 152810 RVA: 0x00375F54 File Offset: 0x00374154
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Map(TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Base.__SetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Map != null)
			{
				InU8Map.CopyTo(&ptr->InU8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254EB RID: 152811 RVA: 0x00375FC0 File Offset: 0x003741C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Array(TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Base.__SetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Array != null)
			{
				InU8Array.CopyTo(&ptr->InU8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254EC RID: 152812 RVA: 0x0037602C File Offset: 0x0037422C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8(byte InU8)
		{
			UTestClass_UFunction_Base.__SetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060254ED RID: 152813 RVA: 0x00376074 File Offset: 0x00374274
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Set(TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Base.__SetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Set != null)
			{
				InU64Set.CopyTo(&ptr->InU64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254EE RID: 152814 RVA: 0x003760E0 File Offset: 0x003742E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Map(TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Base.__SetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Map != null)
			{
				InU64Map.CopyTo(&ptr->InU64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254EF RID: 152815 RVA: 0x0037614C File Offset: 0x0037434C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Array(TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Base.__SetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Array != null)
			{
				InU64Array.CopyTo(&ptr->InU64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F0 RID: 152816 RVA: 0x003761B8 File Offset: 0x003743B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64(ulong InU64)
		{
			UTestClass_UFunction_Base.__SetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060254F1 RID: 152817 RVA: 0x00376200 File Offset: 0x00374400
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Set(TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Base.__SetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Set != null)
			{
				InU32Set.CopyTo(&ptr->InU32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F2 RID: 152818 RVA: 0x0037626C File Offset: 0x0037446C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Map(TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Base.__SetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Map != null)
			{
				InU32Map.CopyTo(&ptr->InU32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F3 RID: 152819 RVA: 0x003762D8 File Offset: 0x003744D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Array(TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Base.__SetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Array != null)
			{
				InU32Array.CopyTo(&ptr->InU32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F4 RID: 152820 RVA: 0x00376344 File Offset: 0x00374544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32(uint InU32)
		{
			UTestClass_UFunction_Base.__SetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060254F5 RID: 152821 RVA: 0x0037638C File Offset: 0x0037458C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Set(TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Base.__SetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Set != null)
			{
				InU16Set.CopyTo(&ptr->InU16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F6 RID: 152822 RVA: 0x003763F8 File Offset: 0x003745F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Map(TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Base.__SetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Map != null)
			{
				InU16Map.CopyTo(&ptr->InU16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F7 RID: 152823 RVA: 0x00376464 File Offset: 0x00374664
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Array(TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Base.__SetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Array != null)
			{
				InU16Array.CopyTo(&ptr->InU16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254F8 RID: 152824 RVA: 0x003764D0 File Offset: 0x003746D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16(ushort InU16)
		{
			UTestClass_UFunction_Base.__SetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060254F9 RID: 152825 RVA: 0x00376518 File Offset: 0x00374718
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Set(TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Base.__SetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Set != null)
			{
				InI8Set.CopyTo(&ptr->InI8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254FA RID: 152826 RVA: 0x00376584 File Offset: 0x00374784
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Map(TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Base.__SetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Map != null)
			{
				InI8Map.CopyTo(&ptr->InI8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254FB RID: 152827 RVA: 0x003765F0 File Offset: 0x003747F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Array(TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Base.__SetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Array != null)
			{
				InI8Array.CopyTo(&ptr->InI8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254FC RID: 152828 RVA: 0x0037665C File Offset: 0x0037485C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8(sbyte InI8)
		{
			UTestClass_UFunction_Base.__SetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060254FD RID: 152829 RVA: 0x003766A4 File Offset: 0x003748A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Set(TSet<long> InI64Set)
		{
			UTestClass_UFunction_Base.__SetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Set != null)
			{
				InI64Set.CopyTo(&ptr->InI64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254FE RID: 152830 RVA: 0x00376710 File Offset: 0x00374910
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Map(TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Base.__SetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Map != null)
			{
				InI64Map.CopyTo(&ptr->InI64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060254FF RID: 152831 RVA: 0x0037677C File Offset: 0x0037497C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Array(TArray<long> InI64Array)
		{
			UTestClass_UFunction_Base.__SetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Array != null)
			{
				InI64Array.CopyTo(&ptr->InI64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025500 RID: 152832 RVA: 0x003767E8 File Offset: 0x003749E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64(long InI64)
		{
			UTestClass_UFunction_Base.__SetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025501 RID: 152833 RVA: 0x00376830 File Offset: 0x00374A30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Set(TSet<int> InI32Set)
		{
			UTestClass_UFunction_Base.__SetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Set != null)
			{
				InI32Set.CopyTo(&ptr->InI32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025502 RID: 152834 RVA: 0x0037689C File Offset: 0x00374A9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Map(TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Base.__SetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Map != null)
			{
				InI32Map.CopyTo(&ptr->InI32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025503 RID: 152835 RVA: 0x00376908 File Offset: 0x00374B08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Array(TArray<int> InI32Array)
		{
			UTestClass_UFunction_Base.__SetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Array != null)
			{
				InI32Array.CopyTo(&ptr->InI32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025504 RID: 152836 RVA: 0x00376974 File Offset: 0x00374B74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32(int InI32)
		{
			UTestClass_UFunction_Base.__SetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025505 RID: 152837 RVA: 0x003769BC File Offset: 0x00374BBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Set(TSet<short> InI16Set)
		{
			UTestClass_UFunction_Base.__SetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Set != null)
			{
				InI16Set.CopyTo(&ptr->InI16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025506 RID: 152838 RVA: 0x00376A28 File Offset: 0x00374C28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Map(TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Base.__SetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Map != null)
			{
				InI16Map.CopyTo(&ptr->InI16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025507 RID: 152839 RVA: 0x00376A94 File Offset: 0x00374C94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Array(TArray<short> InI16Array)
		{
			UTestClass_UFunction_Base.__SetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Array != null)
			{
				InI16Array.CopyTo(&ptr->InI16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025508 RID: 152840 RVA: 0x00376B00 File Offset: 0x00374D00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16(short InI16)
		{
			UTestClass_UFunction_Base.__SetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025509 RID: 152841 RVA: 0x00376B48 File Offset: 0x00374D48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Set(TSet<double> InF64Set)
		{
			UTestClass_UFunction_Base.__SetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Set != null)
			{
				InF64Set.CopyTo(&ptr->InF64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602550A RID: 152842 RVA: 0x00376BB4 File Offset: 0x00374DB4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Map(TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Base.__SetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Map != null)
			{
				InF64Map.CopyTo(&ptr->InF64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602550B RID: 152843 RVA: 0x00376C20 File Offset: 0x00374E20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Array(TArray<double> InF64Array)
		{
			UTestClass_UFunction_Base.__SetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Array != null)
			{
				InF64Array.CopyTo(&ptr->InF64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602550C RID: 152844 RVA: 0x00376C8C File Offset: 0x00374E8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64(double InF64)
		{
			UTestClass_UFunction_Base.__SetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602550D RID: 152845 RVA: 0x00376CD4 File Offset: 0x00374ED4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Set(TSet<float> InF32Set)
		{
			UTestClass_UFunction_Base.__SetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Set != null)
			{
				InF32Set.CopyTo(&ptr->InF32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602550E RID: 152846 RVA: 0x00376D40 File Offset: 0x00374F40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Map(TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Base.__SetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Map != null)
			{
				InF32Map.CopyTo(&ptr->InF32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602550F RID: 152847 RVA: 0x00376DAC File Offset: 0x00374FAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Array(TArray<float> InF32Array)
		{
			UTestClass_UFunction_Base.__SetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Array != null)
			{
				InF32Array.CopyTo(&ptr->InF32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025510 RID: 152848 RVA: 0x00376E18 File Offset: 0x00375018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32(float InF32)
		{
			UTestClass_UFunction_Base.__SetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025511 RID: 152849 RVA: 0x00376E60 File Offset: 0x00375060
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolSet(TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Base.__SetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolSet != null)
			{
				InBoolSet.CopyTo(&ptr->InBoolSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025512 RID: 152850 RVA: 0x00376ECC File Offset: 0x003750CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolMap(TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Base.__SetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolMap != null)
			{
				InBoolMap.CopyTo(&ptr->InBoolMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025513 RID: 152851 RVA: 0x00376F38 File Offset: 0x00375138
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolArray(TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Base.__SetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolArray != null)
			{
				InBoolArray.CopyTo(&ptr->InBoolArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025514 RID: 152852 RVA: 0x00376FA4 File Offset: 0x003751A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBool(bool InBool)
		{
			UTestClass_UFunction_Base.__SetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025515 RID: 152853 RVA: 0x00376FEC File Offset: 0x003751EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Set(ref TSet<byte> OutU8Set)
		{
			UTestClass_UFunction_Base.__OutU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = OutU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> tset2 = OutU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025516 RID: 152854 RVA: 0x00377068 File Offset: 0x00375268
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Map(ref TMap<byte, int> OutU8Map)
		{
			UTestClass_UFunction_Base.__OutU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = OutU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> tmap2 = OutU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025517 RID: 152855 RVA: 0x003770E4 File Offset: 0x003752E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Array(ref TArray<byte> OutU8Array)
		{
			UTestClass_UFunction_Base.__OutU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = OutU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = OutU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025518 RID: 152856 RVA: 0x00377160 File Offset: 0x00375360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8(ref byte OutU8)
		{
			UTestClass_UFunction_Base.__OutU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU8 = OutU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 0);
			OutU8 = ptr->OutU8;
		}

		// Token: 0x06025519 RID: 152857 RVA: 0x003771B0 File Offset: 0x003753B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Set(ref TSet<ulong> OutU64Set)
		{
			UTestClass_UFunction_Base.__OutU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = OutU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> tset2 = OutU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602551A RID: 152858 RVA: 0x0037722C File Offset: 0x0037542C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Map(ref TMap<ulong, int> OutU64Map)
		{
			UTestClass_UFunction_Base.__OutU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = OutU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> tmap2 = OutU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602551B RID: 152859 RVA: 0x003772A8 File Offset: 0x003754A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Array(ref TArray<ulong> OutU64Array)
		{
			UTestClass_UFunction_Base.__OutU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = OutU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> tarray2 = OutU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602551C RID: 152860 RVA: 0x00377324 File Offset: 0x00375524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64(ref ulong OutU64)
		{
			UTestClass_UFunction_Base.__OutU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU64 = OutU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 0);
			OutU64 = ptr->OutU64;
		}

		// Token: 0x0602551D RID: 152861 RVA: 0x00377374 File Offset: 0x00375574
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Set(ref TSet<uint> OutU32Set)
		{
			UTestClass_UFunction_Base.__OutU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = OutU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> tset2 = OutU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602551E RID: 152862 RVA: 0x003773F0 File Offset: 0x003755F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Map(ref TMap<uint, int> OutU32Map)
		{
			UTestClass_UFunction_Base.__OutU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = OutU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> tmap2 = OutU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602551F RID: 152863 RVA: 0x0037746C File Offset: 0x0037566C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Array(ref TArray<uint> OutU32Array)
		{
			UTestClass_UFunction_Base.__OutU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = OutU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> tarray2 = OutU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025520 RID: 152864 RVA: 0x003774E8 File Offset: 0x003756E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32(ref uint OutU32)
		{
			UTestClass_UFunction_Base.__OutU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU32 = OutU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 0);
			OutU32 = ptr->OutU32;
		}

		// Token: 0x06025521 RID: 152865 RVA: 0x00377538 File Offset: 0x00375738
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Set(ref TSet<ushort> OutU16Set)
		{
			UTestClass_UFunction_Base.__OutU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = OutU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> tset2 = OutU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025522 RID: 152866 RVA: 0x003775B4 File Offset: 0x003757B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Map(ref TMap<ushort, int> OutU16Map)
		{
			UTestClass_UFunction_Base.__OutU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = OutU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> tmap2 = OutU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025523 RID: 152867 RVA: 0x00377630 File Offset: 0x00375830
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Array(ref TArray<ushort> OutU16Array)
		{
			UTestClass_UFunction_Base.__OutU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = OutU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> tarray2 = OutU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025524 RID: 152868 RVA: 0x003776AC File Offset: 0x003758AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16(ref ushort OutU16)
		{
			UTestClass_UFunction_Base.__OutU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU16 = OutU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 0);
			OutU16 = ptr->OutU16;
		}

		// Token: 0x06025525 RID: 152869 RVA: 0x003776FC File Offset: 0x003758FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Set(ref TSet<sbyte> OutI8Set)
		{
			UTestClass_UFunction_Base.__OutI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = OutI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> tset2 = OutI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025526 RID: 152870 RVA: 0x00377778 File Offset: 0x00375978
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Map(ref TMap<sbyte, int> OutI8Map)
		{
			UTestClass_UFunction_Base.__OutI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = OutI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> tmap2 = OutI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025527 RID: 152871 RVA: 0x003777F4 File Offset: 0x003759F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Array(ref TArray<sbyte> OutI8Array)
		{
			UTestClass_UFunction_Base.__OutI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = OutI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> tarray2 = OutI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025528 RID: 152872 RVA: 0x00377870 File Offset: 0x00375A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8(ref sbyte OutI8)
		{
			UTestClass_UFunction_Base.__OutI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI8 = OutI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 0);
			OutI8 = ptr->OutI8;
		}

		// Token: 0x06025529 RID: 152873 RVA: 0x003778C0 File Offset: 0x00375AC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Set(ref TSet<long> OutI64Set)
		{
			UTestClass_UFunction_Base.__OutI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = OutI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> tset2 = OutI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602552A RID: 152874 RVA: 0x0037793C File Offset: 0x00375B3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Map(ref TMap<long, int> OutI64Map)
		{
			UTestClass_UFunction_Base.__OutI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = OutI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> tmap2 = OutI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x003779B8 File Offset: 0x00375BB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Array(ref TArray<long> OutI64Array)
		{
			UTestClass_UFunction_Base.__OutI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = OutI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = OutI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602552C RID: 152876 RVA: 0x00377A34 File Offset: 0x00375C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64(ref long OutI64)
		{
			UTestClass_UFunction_Base.__OutI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI64 = OutI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 0);
			OutI64 = ptr->OutI64;
		}

		// Token: 0x0602552D RID: 152877 RVA: 0x00377A84 File Offset: 0x00375C84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Set(ref TSet<int> OutI32Set)
		{
			UTestClass_UFunction_Base.__OutI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = OutI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = OutI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x00377B00 File Offset: 0x00375D00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Map(ref TMap<int, int> OutI32Map)
		{
			UTestClass_UFunction_Base.__OutI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = OutI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = OutI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602552F RID: 152879 RVA: 0x00377B7C File Offset: 0x00375D7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Array(ref TArray<int> OutI32Array)
		{
			UTestClass_UFunction_Base.__OutI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = OutI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025530 RID: 152880 RVA: 0x00377BF8 File Offset: 0x00375DF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32(ref int OutI32)
		{
			UTestClass_UFunction_Base.__OutI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI32 = OutI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 0);
			OutI32 = ptr->OutI32;
		}

		// Token: 0x06025531 RID: 152881 RVA: 0x00377C48 File Offset: 0x00375E48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Set(ref TSet<short> OutI16Set)
		{
			UTestClass_UFunction_Base.__OutI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = OutI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> tset2 = OutI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025532 RID: 152882 RVA: 0x00377CC4 File Offset: 0x00375EC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Map(ref TMap<short, int> OutI16Map)
		{
			UTestClass_UFunction_Base.__OutI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = OutI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> tmap2 = OutI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025533 RID: 152883 RVA: 0x00377D40 File Offset: 0x00375F40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Array(ref TArray<short> OutI16Array)
		{
			UTestClass_UFunction_Base.__OutI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = OutI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> tarray2 = OutI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025534 RID: 152884 RVA: 0x00377DBC File Offset: 0x00375FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16(ref short OutI16)
		{
			UTestClass_UFunction_Base.__OutI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI16 = OutI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 0);
			OutI16 = ptr->OutI16;
		}

		// Token: 0x06025535 RID: 152885 RVA: 0x00377E0C File Offset: 0x0037600C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Set(ref TSet<double> OutF64Set)
		{
			UTestClass_UFunction_Base.__OutF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = OutF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> tset2 = OutF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025536 RID: 152886 RVA: 0x00377E88 File Offset: 0x00376088
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Map(ref TMap<double, int> OutF64Map)
		{
			UTestClass_UFunction_Base.__OutF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = OutF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> tmap2 = OutF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025537 RID: 152887 RVA: 0x00377F04 File Offset: 0x00376104
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Array(ref TArray<double> OutF64Array)
		{
			UTestClass_UFunction_Base.__OutF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = OutF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> tarray2 = OutF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025538 RID: 152888 RVA: 0x00377F80 File Offset: 0x00376180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64(ref double OutF64)
		{
			UTestClass_UFunction_Base.__OutF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF64 = OutF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 0);
			OutF64 = ptr->OutF64;
		}

		// Token: 0x06025539 RID: 152889 RVA: 0x00377FD0 File Offset: 0x003761D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Set(ref TSet<float> OutF32Set)
		{
			UTestClass_UFunction_Base.__OutF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = OutF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> tset2 = OutF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602553A RID: 152890 RVA: 0x0037804C File Offset: 0x0037624C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Map(ref TMap<float, int> OutF32Map)
		{
			UTestClass_UFunction_Base.__OutF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = OutF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> tmap2 = OutF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602553B RID: 152891 RVA: 0x003780C8 File Offset: 0x003762C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Array(ref TArray<float> OutF32Array)
		{
			UTestClass_UFunction_Base.__OutF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = OutF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray2 = OutF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602553C RID: 152892 RVA: 0x00378144 File Offset: 0x00376344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32(ref float OutF32)
		{
			UTestClass_UFunction_Base.__OutF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF32 = OutF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 0);
			OutF32 = ptr->OutF32;
		}

		// Token: 0x0602553D RID: 152893 RVA: 0x00378194 File Offset: 0x00376394
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolSet(ref TSet<bool> OutBoolSet)
		{
			UTestClass_UFunction_Base.__OutBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = OutBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> tset2 = OutBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602553E RID: 152894 RVA: 0x00378210 File Offset: 0x00376410
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolMap(ref TMap<bool, int> OutBoolMap)
		{
			UTestClass_UFunction_Base.__OutBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = OutBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> tmap2 = OutBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602553F RID: 152895 RVA: 0x0037828C File Offset: 0x0037648C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolArray(ref TArray<bool> OutBoolArray)
		{
			UTestClass_UFunction_Base.__OutBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = OutBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> tarray2 = OutBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025540 RID: 152896 RVA: 0x00378308 File Offset: 0x00376508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBool(ref bool OutBool)
		{
			UTestClass_UFunction_Base.__OutBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutBool = OutBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 0);
			OutBool = ptr->OutBool;
		}

		// Token: 0x06025541 RID: 152897 RVA: 0x00378358 File Offset: 0x00376558
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Set(in TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Base.__InU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = InU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> tset2 = InU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025542 RID: 152898 RVA: 0x003783D4 File Offset: 0x003765D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Map(in TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Base.__InU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = InU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> tmap2 = InU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025543 RID: 152899 RVA: 0x00378450 File Offset: 0x00376650
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Array(in TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Base.__InU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = InU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = InU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025544 RID: 152900 RVA: 0x003784CC File Offset: 0x003766CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8(in byte InU8)
		{
			UTestClass_UFunction_Base.__InU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025545 RID: 152901 RVA: 0x00378514 File Offset: 0x00376714
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Set(in TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Base.__InU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = InU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> tset2 = InU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025546 RID: 152902 RVA: 0x00378590 File Offset: 0x00376790
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Map(in TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Base.__InU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = InU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> tmap2 = InU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025547 RID: 152903 RVA: 0x0037860C File Offset: 0x0037680C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Array(in TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Base.__InU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = InU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> tarray2 = InU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025548 RID: 152904 RVA: 0x00378688 File Offset: 0x00376888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64(in ulong InU64)
		{
			UTestClass_UFunction_Base.__InU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025549 RID: 152905 RVA: 0x003786D0 File Offset: 0x003768D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Set(in TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Base.__InU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = InU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> tset2 = InU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602554A RID: 152906 RVA: 0x0037874C File Offset: 0x0037694C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Map(in TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Base.__InU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = InU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> tmap2 = InU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602554B RID: 152907 RVA: 0x003787C8 File Offset: 0x003769C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Array(in TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Base.__InU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = InU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> tarray2 = InU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602554C RID: 152908 RVA: 0x00378844 File Offset: 0x00376A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32(in uint InU32)
		{
			UTestClass_UFunction_Base.__InU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602554D RID: 152909 RVA: 0x0037888C File Offset: 0x00376A8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Set(in TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Base.__InU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = InU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> tset2 = InU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602554E RID: 152910 RVA: 0x00378908 File Offset: 0x00376B08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Map(in TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Base.__InU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = InU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> tmap2 = InU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602554F RID: 152911 RVA: 0x00378984 File Offset: 0x00376B84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Array(in TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Base.__InU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = InU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> tarray2 = InU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025550 RID: 152912 RVA: 0x00378A00 File Offset: 0x00376C00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16(in ushort InU16)
		{
			UTestClass_UFunction_Base.__InU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025551 RID: 152913 RVA: 0x00378A48 File Offset: 0x00376C48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Set(in TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Base.__InI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = InI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> tset2 = InI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025552 RID: 152914 RVA: 0x00378AC4 File Offset: 0x00376CC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Map(in TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Base.__InI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = InI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> tmap2 = InI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025553 RID: 152915 RVA: 0x00378B40 File Offset: 0x00376D40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Array(in TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Base.__InI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = InI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> tarray2 = InI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025554 RID: 152916 RVA: 0x00378BBC File Offset: 0x00376DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8(in sbyte InI8)
		{
			UTestClass_UFunction_Base.__InI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025555 RID: 152917 RVA: 0x00378C04 File Offset: 0x00376E04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Set(in TSet<long> InI64Set)
		{
			UTestClass_UFunction_Base.__InI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = InI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> tset2 = InI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025556 RID: 152918 RVA: 0x00378C80 File Offset: 0x00376E80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Map(in TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Base.__InI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = InI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> tmap2 = InI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025557 RID: 152919 RVA: 0x00378CFC File Offset: 0x00376EFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Array(in TArray<long> InI64Array)
		{
			UTestClass_UFunction_Base.__InI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = InI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = InI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025558 RID: 152920 RVA: 0x00378D78 File Offset: 0x00376F78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64(in long InI64)
		{
			UTestClass_UFunction_Base.__InI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025559 RID: 152921 RVA: 0x00378DC0 File Offset: 0x00376FC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Set(in TSet<int> InI32Set)
		{
			UTestClass_UFunction_Base.__InI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = InI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = InI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602555A RID: 152922 RVA: 0x00378E3C File Offset: 0x0037703C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Map(in TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Base.__InI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = InI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = InI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602555B RID: 152923 RVA: 0x00378EB8 File Offset: 0x003770B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Array(in TArray<int> InI32Array)
		{
			UTestClass_UFunction_Base.__InI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = InI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = InI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602555C RID: 152924 RVA: 0x00378F34 File Offset: 0x00377134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32(in int InI32)
		{
			UTestClass_UFunction_Base.__InI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602555D RID: 152925 RVA: 0x00378F7C File Offset: 0x0037717C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Set(in TSet<short> InI16Set)
		{
			UTestClass_UFunction_Base.__InI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = InI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> tset2 = InI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602555E RID: 152926 RVA: 0x00378FF8 File Offset: 0x003771F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Map(in TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Base.__InI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = InI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> tmap2 = InI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602555F RID: 152927 RVA: 0x00379074 File Offset: 0x00377274
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Array(in TArray<short> InI16Array)
		{
			UTestClass_UFunction_Base.__InI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = InI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> tarray2 = InI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025560 RID: 152928 RVA: 0x003790F0 File Offset: 0x003772F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16(in short InI16)
		{
			UTestClass_UFunction_Base.__InI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025561 RID: 152929 RVA: 0x00379138 File Offset: 0x00377338
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Set(in TSet<double> InF64Set)
		{
			UTestClass_UFunction_Base.__InF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = InF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> tset2 = InF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025562 RID: 152930 RVA: 0x003791B4 File Offset: 0x003773B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Map(in TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Base.__InF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = InF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> tmap2 = InF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025563 RID: 152931 RVA: 0x00379230 File Offset: 0x00377430
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Array(in TArray<double> InF64Array)
		{
			UTestClass_UFunction_Base.__InF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = InF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> tarray2 = InF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025564 RID: 152932 RVA: 0x003792AC File Offset: 0x003774AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64(in double InF64)
		{
			UTestClass_UFunction_Base.__InF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025565 RID: 152933 RVA: 0x003792F4 File Offset: 0x003774F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Set(in TSet<float> InF32Set)
		{
			UTestClass_UFunction_Base.__InF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = InF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> tset2 = InF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025566 RID: 152934 RVA: 0x00379370 File Offset: 0x00377570
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Map(in TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Base.__InF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = InF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> tmap2 = InF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025567 RID: 152935 RVA: 0x003793EC File Offset: 0x003775EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Array(in TArray<float> InF32Array)
		{
			UTestClass_UFunction_Base.__InF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = InF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray2 = InF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025568 RID: 152936 RVA: 0x00379468 File Offset: 0x00377668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32(in float InF32)
		{
			UTestClass_UFunction_Base.__InF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025569 RID: 152937 RVA: 0x003794B0 File Offset: 0x003776B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolSet(in TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Base.__InBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = InBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> tset2 = InBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602556A RID: 152938 RVA: 0x0037952C File Offset: 0x0037772C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolMap(in TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Base.__InBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = InBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> tmap2 = InBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602556B RID: 152939 RVA: 0x003795A8 File Offset: 0x003777A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolArray(in TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Base.__InBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = InBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> tarray2 = InBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602556C RID: 152940 RVA: 0x00379624 File Offset: 0x00377824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBool(in bool InBool)
		{
			UTestClass_UFunction_Base.__InBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBool_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602556D RID: 152941 RVA: 0x0037966C File Offset: 0x0037786C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<byte> GetU8Set()
		{
			UTestClass_UFunction_Base.__GetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> result = new TSet<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602556E RID: 152942 RVA: 0x003796CC File Offset: 0x003778CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<byte, int> GetU8Map()
		{
			UTestClass_UFunction_Base.__GetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> result = new TMap<byte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602556F RID: 152943 RVA: 0x0037972C File Offset: 0x0037792C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<byte> GetU8Array()
		{
			UTestClass_UFunction_Base.__GetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> result = new TArray<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025570 RID: 152944 RVA: 0x0037978C File Offset: 0x0037798C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe byte GetU8()
		{
			UTestClass_UFunction_Base.__GetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025571 RID: 152945 RVA: 0x003797D4 File Offset: 0x003779D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<ulong> GetU64Set()
		{
			UTestClass_UFunction_Base.__GetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> result = new TSet<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025572 RID: 152946 RVA: 0x00379834 File Offset: 0x00377A34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<ulong, int> GetU64Map()
		{
			UTestClass_UFunction_Base.__GetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> result = new TMap<ulong, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025573 RID: 152947 RVA: 0x00379894 File Offset: 0x00377A94
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ulong> GetU64Array()
		{
			UTestClass_UFunction_Base.__GetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> result = new TArray<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025574 RID: 152948 RVA: 0x003798F4 File Offset: 0x00377AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ulong GetU64()
		{
			UTestClass_UFunction_Base.__GetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025575 RID: 152949 RVA: 0x0037993C File Offset: 0x00377B3C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<uint> GetU32Set()
		{
			UTestClass_UFunction_Base.__GetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> result = new TSet<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025576 RID: 152950 RVA: 0x0037999C File Offset: 0x00377B9C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<uint, int> GetU32Map()
		{
			UTestClass_UFunction_Base.__GetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> result = new TMap<uint, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025577 RID: 152951 RVA: 0x003799FC File Offset: 0x00377BFC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<uint> GetU32Array()
		{
			UTestClass_UFunction_Base.__GetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> result = new TArray<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025578 RID: 152952 RVA: 0x00379A5C File Offset: 0x00377C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe uint GetU32()
		{
			UTestClass_UFunction_Base.__GetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025579 RID: 152953 RVA: 0x00379AA4 File Offset: 0x00377CA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<ushort> GetU16Set()
		{
			UTestClass_UFunction_Base.__GetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> result = new TSet<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602557A RID: 152954 RVA: 0x00379B04 File Offset: 0x00377D04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<ushort, int> GetU16Map()
		{
			UTestClass_UFunction_Base.__GetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> result = new TMap<ushort, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602557B RID: 152955 RVA: 0x00379B64 File Offset: 0x00377D64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ushort> GetU16Array()
		{
			UTestClass_UFunction_Base.__GetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> result = new TArray<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602557C RID: 152956 RVA: 0x00379BC4 File Offset: 0x00377DC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ushort GetU16()
		{
			UTestClass_UFunction_Base.__GetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602557D RID: 152957 RVA: 0x00379C0C File Offset: 0x00377E0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<sbyte> GetI8Set()
		{
			UTestClass_UFunction_Base.__GetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> result = new TSet<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602557E RID: 152958 RVA: 0x00379C6C File Offset: 0x00377E6C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<sbyte, int> GetI8Map()
		{
			UTestClass_UFunction_Base.__GetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> result = new TMap<sbyte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602557F RID: 152959 RVA: 0x00379CCC File Offset: 0x00377ECC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<sbyte> GetI8Array()
		{
			UTestClass_UFunction_Base.__GetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> result = new TArray<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025580 RID: 152960 RVA: 0x00379D2C File Offset: 0x00377F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe sbyte GetI8()
		{
			UTestClass_UFunction_Base.__GetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025581 RID: 152961 RVA: 0x00379D74 File Offset: 0x00377F74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<long> GetI64Set()
		{
			UTestClass_UFunction_Base.__GetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> result = new TSet<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025582 RID: 152962 RVA: 0x00379DD4 File Offset: 0x00377FD4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<long, int> GetI64Map()
		{
			UTestClass_UFunction_Base.__GetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> result = new TMap<long, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025583 RID: 152963 RVA: 0x00379E34 File Offset: 0x00378034
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<long> GetI64Array()
		{
			UTestClass_UFunction_Base.__GetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> result = new TArray<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025584 RID: 152964 RVA: 0x00379E94 File Offset: 0x00378094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe long GetI64()
		{
			UTestClass_UFunction_Base.__GetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025585 RID: 152965 RVA: 0x00379EDC File Offset: 0x003780DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<int> GetI32Set()
		{
			UTestClass_UFunction_Base.__GetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> result = new TSet<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025586 RID: 152966 RVA: 0x00379F3C File Offset: 0x0037813C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<int, int> GetI32Map()
		{
			UTestClass_UFunction_Base.__GetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> result = new TMap<int, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025587 RID: 152967 RVA: 0x00379F9C File Offset: 0x0037819C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<int> GetI32Array()
		{
			UTestClass_UFunction_Base.__GetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> result = new TArray<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025588 RID: 152968 RVA: 0x00379FFC File Offset: 0x003781FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetI32()
		{
			UTestClass_UFunction_Base.__GetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025589 RID: 152969 RVA: 0x0037A044 File Offset: 0x00378244
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<short> GetI16Set()
		{
			UTestClass_UFunction_Base.__GetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> result = new TSet<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602558A RID: 152970 RVA: 0x0037A0A4 File Offset: 0x003782A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<short, int> GetI16Map()
		{
			UTestClass_UFunction_Base.__GetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> result = new TMap<short, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602558B RID: 152971 RVA: 0x0037A104 File Offset: 0x00378304
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<short> GetI16Array()
		{
			UTestClass_UFunction_Base.__GetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> result = new TArray<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602558C RID: 152972 RVA: 0x0037A164 File Offset: 0x00378364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe short GetI16()
		{
			UTestClass_UFunction_Base.__GetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602558D RID: 152973 RVA: 0x0037A1AC File Offset: 0x003783AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<double> GetF64Set()
		{
			UTestClass_UFunction_Base.__GetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> result = new TSet<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602558E RID: 152974 RVA: 0x0037A20C File Offset: 0x0037840C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<double, int> GetF64Map()
		{
			UTestClass_UFunction_Base.__GetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> result = new TMap<double, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602558F RID: 152975 RVA: 0x0037A26C File Offset: 0x0037846C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<double> GetF64Array()
		{
			UTestClass_UFunction_Base.__GetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> result = new TArray<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025590 RID: 152976 RVA: 0x0037A2CC File Offset: 0x003784CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe double GetF64()
		{
			UTestClass_UFunction_Base.__GetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025591 RID: 152977 RVA: 0x0037A314 File Offset: 0x00378514
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<float> GetF32Set()
		{
			UTestClass_UFunction_Base.__GetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> result = new TSet<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025592 RID: 152978 RVA: 0x0037A374 File Offset: 0x00378574
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<float, int> GetF32Map()
		{
			UTestClass_UFunction_Base.__GetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> result = new TMap<float, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025593 RID: 152979 RVA: 0x0037A3D4 File Offset: 0x003785D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<float> GetF32Array()
		{
			UTestClass_UFunction_Base.__GetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> result = new TArray<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025594 RID: 152980 RVA: 0x0037A434 File Offset: 0x00378634
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetF32()
		{
			UTestClass_UFunction_Base.__GetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025595 RID: 152981 RVA: 0x0037A47C File Offset: 0x0037867C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<bool> GetBoolSet()
		{
			UTestClass_UFunction_Base.__GetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> result = new TSet<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025596 RID: 152982 RVA: 0x0037A4DC File Offset: 0x003786DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<bool, int> GetBoolMap()
		{
			UTestClass_UFunction_Base.__GetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> result = new TMap<bool, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025597 RID: 152983 RVA: 0x0037A53C File Offset: 0x0037873C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<bool> GetBoolArray()
		{
			UTestClass_UFunction_Base.__GetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> result = new TArray<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025598 RID: 152984 RVA: 0x0037A59C File Offset: 0x0037879C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetBool()
		{
			UTestClass_UFunction_Base.__GetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025599 RID: 152985 RVA: 0x0037A5E2 File Offset: 0x003787E2
		static UTestClass_UFunction_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Base");
		}

		// Token: 0x0602559A RID: 152986 RVA: 0x0037A5F0 File Offset: 0x003787F0
		protected UTestClass_UFunction_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040141F1 RID: 82417
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Base";

		// Token: 0x040141F2 RID: 82418
		private static IntPtr _ClassPtr;

		// Token: 0x040141F3 RID: 82419
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040141F4 RID: 82420
		internal static int __PropertyOffset_Bool;

		// Token: 0x040141F5 RID: 82421
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x040141F6 RID: 82422
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x040141F7 RID: 82423
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x040141F8 RID: 82424
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x040141F9 RID: 82425
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x040141FA RID: 82426
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x040141FB RID: 82427
		internal static int __PropertyOffset_I8;

		// Token: 0x040141FC RID: 82428
		internal static int __PropertyOffset_I8Array;

		// Token: 0x040141FD RID: 82429
		[Nullable(2)]
		private TArray<sbyte> _I8Array;

		// Token: 0x040141FE RID: 82430
		internal static int __PropertyOffset_I8Set;

		// Token: 0x040141FF RID: 82431
		[Nullable(2)]
		private TSet<sbyte> _I8Set;

		// Token: 0x04014200 RID: 82432
		internal static int __PropertyOffset_I8Map;

		// Token: 0x04014201 RID: 82433
		[Nullable(2)]
		private TMap<sbyte, int> _I8Map;

		// Token: 0x04014202 RID: 82434
		internal static int __PropertyOffset_U8;

		// Token: 0x04014203 RID: 82435
		internal static int __PropertyOffset_U8Array;

		// Token: 0x04014204 RID: 82436
		[Nullable(2)]
		private TArray<byte> _U8Array;

		// Token: 0x04014205 RID: 82437
		internal static int __PropertyOffset_U8Set;

		// Token: 0x04014206 RID: 82438
		[Nullable(2)]
		private TSet<byte> _U8Set;

		// Token: 0x04014207 RID: 82439
		internal static int __PropertyOffset_U8Map;

		// Token: 0x04014208 RID: 82440
		[Nullable(2)]
		private TMap<byte, int> _U8Map;

		// Token: 0x04014209 RID: 82441
		internal static int __PropertyOffset_I16;

		// Token: 0x0401420A RID: 82442
		internal static int __PropertyOffset_I16Array;

		// Token: 0x0401420B RID: 82443
		[Nullable(2)]
		private TArray<short> _I16Array;

		// Token: 0x0401420C RID: 82444
		internal static int __PropertyOffset_I16Set;

		// Token: 0x0401420D RID: 82445
		[Nullable(2)]
		private TSet<short> _I16Set;

		// Token: 0x0401420E RID: 82446
		internal static int __PropertyOffset_I16Map;

		// Token: 0x0401420F RID: 82447
		[Nullable(2)]
		private TMap<short, int> _I16Map;

		// Token: 0x04014210 RID: 82448
		internal static int __PropertyOffset_U16;

		// Token: 0x04014211 RID: 82449
		internal static int __PropertyOffset_U16Array;

		// Token: 0x04014212 RID: 82450
		[Nullable(2)]
		private TArray<ushort> _U16Array;

		// Token: 0x04014213 RID: 82451
		internal static int __PropertyOffset_U16Set;

		// Token: 0x04014214 RID: 82452
		[Nullable(2)]
		private TSet<ushort> _U16Set;

		// Token: 0x04014215 RID: 82453
		internal static int __PropertyOffset_U16Map;

		// Token: 0x04014216 RID: 82454
		[Nullable(2)]
		private TMap<ushort, int> _U16Map;

		// Token: 0x04014217 RID: 82455
		internal static int __PropertyOffset_I32;

		// Token: 0x04014218 RID: 82456
		internal static int __PropertyOffset_I32Array;

		// Token: 0x04014219 RID: 82457
		[Nullable(2)]
		private TArray<int> _I32Array;

		// Token: 0x0401421A RID: 82458
		internal static int __PropertyOffset_I32Set;

		// Token: 0x0401421B RID: 82459
		[Nullable(2)]
		private TSet<int> _I32Set;

		// Token: 0x0401421C RID: 82460
		internal static int __PropertyOffset_I32Map;

		// Token: 0x0401421D RID: 82461
		[Nullable(2)]
		private TMap<int, int> _I32Map;

		// Token: 0x0401421E RID: 82462
		internal static int __PropertyOffset_U32;

		// Token: 0x0401421F RID: 82463
		internal static int __PropertyOffset_U32Array;

		// Token: 0x04014220 RID: 82464
		[Nullable(2)]
		private TArray<uint> _U32Array;

		// Token: 0x04014221 RID: 82465
		internal static int __PropertyOffset_U32Set;

		// Token: 0x04014222 RID: 82466
		[Nullable(2)]
		private TSet<uint> _U32Set;

		// Token: 0x04014223 RID: 82467
		internal static int __PropertyOffset_U32Map;

		// Token: 0x04014224 RID: 82468
		[Nullable(2)]
		private TMap<uint, int> _U32Map;

		// Token: 0x04014225 RID: 82469
		internal static int __PropertyOffset_I64;

		// Token: 0x04014226 RID: 82470
		internal static int __PropertyOffset_I64Array;

		// Token: 0x04014227 RID: 82471
		[Nullable(2)]
		private TArray<long> _I64Array;

		// Token: 0x04014228 RID: 82472
		internal static int __PropertyOffset_I64Set;

		// Token: 0x04014229 RID: 82473
		[Nullable(2)]
		private TSet<long> _I64Set;

		// Token: 0x0401422A RID: 82474
		internal static int __PropertyOffset_I64Map;

		// Token: 0x0401422B RID: 82475
		[Nullable(2)]
		private TMap<long, int> _I64Map;

		// Token: 0x0401422C RID: 82476
		internal static int __PropertyOffset_U64;

		// Token: 0x0401422D RID: 82477
		internal static int __PropertyOffset_U64Array;

		// Token: 0x0401422E RID: 82478
		[Nullable(2)]
		private TArray<ulong> _U64Array;

		// Token: 0x0401422F RID: 82479
		internal static int __PropertyOffset_U64Set;

		// Token: 0x04014230 RID: 82480
		[Nullable(2)]
		private TSet<ulong> _U64Set;

		// Token: 0x04014231 RID: 82481
		internal static int __PropertyOffset_U64Map;

		// Token: 0x04014232 RID: 82482
		[Nullable(2)]
		private TMap<ulong, int> _U64Map;

		// Token: 0x04014233 RID: 82483
		internal static int __PropertyOffset_F32;

		// Token: 0x04014234 RID: 82484
		internal static int __PropertyOffset_F32Array;

		// Token: 0x04014235 RID: 82485
		[Nullable(2)]
		private TArray<float> _F32Array;

		// Token: 0x04014236 RID: 82486
		internal static int __PropertyOffset_F32Set;

		// Token: 0x04014237 RID: 82487
		[Nullable(2)]
		private TSet<float> _F32Set;

		// Token: 0x04014238 RID: 82488
		internal static int __PropertyOffset_F32Map;

		// Token: 0x04014239 RID: 82489
		[Nullable(2)]
		private TMap<float, int> _F32Map;

		// Token: 0x0401423A RID: 82490
		internal static int __PropertyOffset_F64;

		// Token: 0x0401423B RID: 82491
		internal static int __PropertyOffset_F64Array;

		// Token: 0x0401423C RID: 82492
		[Nullable(2)]
		private TArray<double> _F64Array;

		// Token: 0x0401423D RID: 82493
		internal static int __PropertyOffset_F64Set;

		// Token: 0x0401423E RID: 82494
		[Nullable(2)]
		private TSet<double> _F64Set;

		// Token: 0x0401423F RID: 82495
		internal static int __PropertyOffset_F64Map;

		// Token: 0x04014240 RID: 82496
		[Nullable(2)]
		private TMap<double, int> _F64Map;

		// Token: 0x04014241 RID: 82497
		private static IntPtr __SetU8Set_NativeFunctionPtr;

		// Token: 0x04014242 RID: 82498
		private static IntPtr __SetU8Map_NativeFunctionPtr;

		// Token: 0x04014243 RID: 82499
		private static IntPtr __SetU8Array_NativeFunctionPtr;

		// Token: 0x04014244 RID: 82500
		private static IntPtr __SetU8_NativeFunctionPtr;

		// Token: 0x04014245 RID: 82501
		private static IntPtr __SetU64Set_NativeFunctionPtr;

		// Token: 0x04014246 RID: 82502
		private static IntPtr __SetU64Map_NativeFunctionPtr;

		// Token: 0x04014247 RID: 82503
		private static IntPtr __SetU64Array_NativeFunctionPtr;

		// Token: 0x04014248 RID: 82504
		private static IntPtr __SetU64_NativeFunctionPtr;

		// Token: 0x04014249 RID: 82505
		private static IntPtr __SetU32Set_NativeFunctionPtr;

		// Token: 0x0401424A RID: 82506
		private static IntPtr __SetU32Map_NativeFunctionPtr;

		// Token: 0x0401424B RID: 82507
		private static IntPtr __SetU32Array_NativeFunctionPtr;

		// Token: 0x0401424C RID: 82508
		private static IntPtr __SetU32_NativeFunctionPtr;

		// Token: 0x0401424D RID: 82509
		private static IntPtr __SetU16Set_NativeFunctionPtr;

		// Token: 0x0401424E RID: 82510
		private static IntPtr __SetU16Map_NativeFunctionPtr;

		// Token: 0x0401424F RID: 82511
		private static IntPtr __SetU16Array_NativeFunctionPtr;

		// Token: 0x04014250 RID: 82512
		private static IntPtr __SetU16_NativeFunctionPtr;

		// Token: 0x04014251 RID: 82513
		private static IntPtr __SetI8Set_NativeFunctionPtr;

		// Token: 0x04014252 RID: 82514
		private static IntPtr __SetI8Map_NativeFunctionPtr;

		// Token: 0x04014253 RID: 82515
		private static IntPtr __SetI8Array_NativeFunctionPtr;

		// Token: 0x04014254 RID: 82516
		private static IntPtr __SetI8_NativeFunctionPtr;

		// Token: 0x04014255 RID: 82517
		private static IntPtr __SetI64Set_NativeFunctionPtr;

		// Token: 0x04014256 RID: 82518
		private static IntPtr __SetI64Map_NativeFunctionPtr;

		// Token: 0x04014257 RID: 82519
		private static IntPtr __SetI64Array_NativeFunctionPtr;

		// Token: 0x04014258 RID: 82520
		private static IntPtr __SetI64_NativeFunctionPtr;

		// Token: 0x04014259 RID: 82521
		private static IntPtr __SetI32Set_NativeFunctionPtr;

		// Token: 0x0401425A RID: 82522
		private static IntPtr __SetI32Map_NativeFunctionPtr;

		// Token: 0x0401425B RID: 82523
		private static IntPtr __SetI32Array_NativeFunctionPtr;

		// Token: 0x0401425C RID: 82524
		private static IntPtr __SetI32_NativeFunctionPtr;

		// Token: 0x0401425D RID: 82525
		private static IntPtr __SetI16Set_NativeFunctionPtr;

		// Token: 0x0401425E RID: 82526
		private static IntPtr __SetI16Map_NativeFunctionPtr;

		// Token: 0x0401425F RID: 82527
		private static IntPtr __SetI16Array_NativeFunctionPtr;

		// Token: 0x04014260 RID: 82528
		private static IntPtr __SetI16_NativeFunctionPtr;

		// Token: 0x04014261 RID: 82529
		private static IntPtr __SetF64Set_NativeFunctionPtr;

		// Token: 0x04014262 RID: 82530
		private static IntPtr __SetF64Map_NativeFunctionPtr;

		// Token: 0x04014263 RID: 82531
		private static IntPtr __SetF64Array_NativeFunctionPtr;

		// Token: 0x04014264 RID: 82532
		private static IntPtr __SetF64_NativeFunctionPtr;

		// Token: 0x04014265 RID: 82533
		private static IntPtr __SetF32Set_NativeFunctionPtr;

		// Token: 0x04014266 RID: 82534
		private static IntPtr __SetF32Map_NativeFunctionPtr;

		// Token: 0x04014267 RID: 82535
		private static IntPtr __SetF32Array_NativeFunctionPtr;

		// Token: 0x04014268 RID: 82536
		private static IntPtr __SetF32_NativeFunctionPtr;

		// Token: 0x04014269 RID: 82537
		private static IntPtr __SetBoolSet_NativeFunctionPtr;

		// Token: 0x0401426A RID: 82538
		private static IntPtr __SetBoolMap_NativeFunctionPtr;

		// Token: 0x0401426B RID: 82539
		private static IntPtr __SetBoolArray_NativeFunctionPtr;

		// Token: 0x0401426C RID: 82540
		private static IntPtr __SetBool_NativeFunctionPtr;

		// Token: 0x0401426D RID: 82541
		private static IntPtr __OutU8Set_NativeFunctionPtr;

		// Token: 0x0401426E RID: 82542
		private static IntPtr __OutU8Map_NativeFunctionPtr;

		// Token: 0x0401426F RID: 82543
		private static IntPtr __OutU8Array_NativeFunctionPtr;

		// Token: 0x04014270 RID: 82544
		private static IntPtr __OutU8_NativeFunctionPtr;

		// Token: 0x04014271 RID: 82545
		private static IntPtr __OutU64Set_NativeFunctionPtr;

		// Token: 0x04014272 RID: 82546
		private static IntPtr __OutU64Map_NativeFunctionPtr;

		// Token: 0x04014273 RID: 82547
		private static IntPtr __OutU64Array_NativeFunctionPtr;

		// Token: 0x04014274 RID: 82548
		private static IntPtr __OutU64_NativeFunctionPtr;

		// Token: 0x04014275 RID: 82549
		private static IntPtr __OutU32Set_NativeFunctionPtr;

		// Token: 0x04014276 RID: 82550
		private static IntPtr __OutU32Map_NativeFunctionPtr;

		// Token: 0x04014277 RID: 82551
		private static IntPtr __OutU32Array_NativeFunctionPtr;

		// Token: 0x04014278 RID: 82552
		private static IntPtr __OutU32_NativeFunctionPtr;

		// Token: 0x04014279 RID: 82553
		private static IntPtr __OutU16Set_NativeFunctionPtr;

		// Token: 0x0401427A RID: 82554
		private static IntPtr __OutU16Map_NativeFunctionPtr;

		// Token: 0x0401427B RID: 82555
		private static IntPtr __OutU16Array_NativeFunctionPtr;

		// Token: 0x0401427C RID: 82556
		private static IntPtr __OutU16_NativeFunctionPtr;

		// Token: 0x0401427D RID: 82557
		private static IntPtr __OutI8Set_NativeFunctionPtr;

		// Token: 0x0401427E RID: 82558
		private static IntPtr __OutI8Map_NativeFunctionPtr;

		// Token: 0x0401427F RID: 82559
		private static IntPtr __OutI8Array_NativeFunctionPtr;

		// Token: 0x04014280 RID: 82560
		private static IntPtr __OutI8_NativeFunctionPtr;

		// Token: 0x04014281 RID: 82561
		private static IntPtr __OutI64Set_NativeFunctionPtr;

		// Token: 0x04014282 RID: 82562
		private static IntPtr __OutI64Map_NativeFunctionPtr;

		// Token: 0x04014283 RID: 82563
		private static IntPtr __OutI64Array_NativeFunctionPtr;

		// Token: 0x04014284 RID: 82564
		private static IntPtr __OutI64_NativeFunctionPtr;

		// Token: 0x04014285 RID: 82565
		private static IntPtr __OutI32Set_NativeFunctionPtr;

		// Token: 0x04014286 RID: 82566
		private static IntPtr __OutI32Map_NativeFunctionPtr;

		// Token: 0x04014287 RID: 82567
		private static IntPtr __OutI32Array_NativeFunctionPtr;

		// Token: 0x04014288 RID: 82568
		private static IntPtr __OutI32_NativeFunctionPtr;

		// Token: 0x04014289 RID: 82569
		private static IntPtr __OutI16Set_NativeFunctionPtr;

		// Token: 0x0401428A RID: 82570
		private static IntPtr __OutI16Map_NativeFunctionPtr;

		// Token: 0x0401428B RID: 82571
		private static IntPtr __OutI16Array_NativeFunctionPtr;

		// Token: 0x0401428C RID: 82572
		private static IntPtr __OutI16_NativeFunctionPtr;

		// Token: 0x0401428D RID: 82573
		private static IntPtr __OutF64Set_NativeFunctionPtr;

		// Token: 0x0401428E RID: 82574
		private static IntPtr __OutF64Map_NativeFunctionPtr;

		// Token: 0x0401428F RID: 82575
		private static IntPtr __OutF64Array_NativeFunctionPtr;

		// Token: 0x04014290 RID: 82576
		private static IntPtr __OutF64_NativeFunctionPtr;

		// Token: 0x04014291 RID: 82577
		private static IntPtr __OutF32Set_NativeFunctionPtr;

		// Token: 0x04014292 RID: 82578
		private static IntPtr __OutF32Map_NativeFunctionPtr;

		// Token: 0x04014293 RID: 82579
		private static IntPtr __OutF32Array_NativeFunctionPtr;

		// Token: 0x04014294 RID: 82580
		private static IntPtr __OutF32_NativeFunctionPtr;

		// Token: 0x04014295 RID: 82581
		private static IntPtr __OutBoolSet_NativeFunctionPtr;

		// Token: 0x04014296 RID: 82582
		private static IntPtr __OutBoolMap_NativeFunctionPtr;

		// Token: 0x04014297 RID: 82583
		private static IntPtr __OutBoolArray_NativeFunctionPtr;

		// Token: 0x04014298 RID: 82584
		private static IntPtr __OutBool_NativeFunctionPtr;

		// Token: 0x04014299 RID: 82585
		private static IntPtr __InU8Set_NativeFunctionPtr;

		// Token: 0x0401429A RID: 82586
		private static IntPtr __InU8Map_NativeFunctionPtr;

		// Token: 0x0401429B RID: 82587
		private static IntPtr __InU8Array_NativeFunctionPtr;

		// Token: 0x0401429C RID: 82588
		private static IntPtr __InU8_NativeFunctionPtr;

		// Token: 0x0401429D RID: 82589
		private static IntPtr __InU64Set_NativeFunctionPtr;

		// Token: 0x0401429E RID: 82590
		private static IntPtr __InU64Map_NativeFunctionPtr;

		// Token: 0x0401429F RID: 82591
		private static IntPtr __InU64Array_NativeFunctionPtr;

		// Token: 0x040142A0 RID: 82592
		private static IntPtr __InU64_NativeFunctionPtr;

		// Token: 0x040142A1 RID: 82593
		private static IntPtr __InU32Set_NativeFunctionPtr;

		// Token: 0x040142A2 RID: 82594
		private static IntPtr __InU32Map_NativeFunctionPtr;

		// Token: 0x040142A3 RID: 82595
		private static IntPtr __InU32Array_NativeFunctionPtr;

		// Token: 0x040142A4 RID: 82596
		private static IntPtr __InU32_NativeFunctionPtr;

		// Token: 0x040142A5 RID: 82597
		private static IntPtr __InU16Set_NativeFunctionPtr;

		// Token: 0x040142A6 RID: 82598
		private static IntPtr __InU16Map_NativeFunctionPtr;

		// Token: 0x040142A7 RID: 82599
		private static IntPtr __InU16Array_NativeFunctionPtr;

		// Token: 0x040142A8 RID: 82600
		private static IntPtr __InU16_NativeFunctionPtr;

		// Token: 0x040142A9 RID: 82601
		private static IntPtr __InI8Set_NativeFunctionPtr;

		// Token: 0x040142AA RID: 82602
		private static IntPtr __InI8Map_NativeFunctionPtr;

		// Token: 0x040142AB RID: 82603
		private static IntPtr __InI8Array_NativeFunctionPtr;

		// Token: 0x040142AC RID: 82604
		private static IntPtr __InI8_NativeFunctionPtr;

		// Token: 0x040142AD RID: 82605
		private static IntPtr __InI64Set_NativeFunctionPtr;

		// Token: 0x040142AE RID: 82606
		private static IntPtr __InI64Map_NativeFunctionPtr;

		// Token: 0x040142AF RID: 82607
		private static IntPtr __InI64Array_NativeFunctionPtr;

		// Token: 0x040142B0 RID: 82608
		private static IntPtr __InI64_NativeFunctionPtr;

		// Token: 0x040142B1 RID: 82609
		private static IntPtr __InI32Set_NativeFunctionPtr;

		// Token: 0x040142B2 RID: 82610
		private static IntPtr __InI32Map_NativeFunctionPtr;

		// Token: 0x040142B3 RID: 82611
		private static IntPtr __InI32Array_NativeFunctionPtr;

		// Token: 0x040142B4 RID: 82612
		private static IntPtr __InI32_NativeFunctionPtr;

		// Token: 0x040142B5 RID: 82613
		private static IntPtr __InI16Set_NativeFunctionPtr;

		// Token: 0x040142B6 RID: 82614
		private static IntPtr __InI16Map_NativeFunctionPtr;

		// Token: 0x040142B7 RID: 82615
		private static IntPtr __InI16Array_NativeFunctionPtr;

		// Token: 0x040142B8 RID: 82616
		private static IntPtr __InI16_NativeFunctionPtr;

		// Token: 0x040142B9 RID: 82617
		private static IntPtr __InF64Set_NativeFunctionPtr;

		// Token: 0x040142BA RID: 82618
		private static IntPtr __InF64Map_NativeFunctionPtr;

		// Token: 0x040142BB RID: 82619
		private static IntPtr __InF64Array_NativeFunctionPtr;

		// Token: 0x040142BC RID: 82620
		private static IntPtr __InF64_NativeFunctionPtr;

		// Token: 0x040142BD RID: 82621
		private static IntPtr __InF32Set_NativeFunctionPtr;

		// Token: 0x040142BE RID: 82622
		private static IntPtr __InF32Map_NativeFunctionPtr;

		// Token: 0x040142BF RID: 82623
		private static IntPtr __InF32Array_NativeFunctionPtr;

		// Token: 0x040142C0 RID: 82624
		private static IntPtr __InF32_NativeFunctionPtr;

		// Token: 0x040142C1 RID: 82625
		private static IntPtr __InBoolSet_NativeFunctionPtr;

		// Token: 0x040142C2 RID: 82626
		private static IntPtr __InBoolMap_NativeFunctionPtr;

		// Token: 0x040142C3 RID: 82627
		private static IntPtr __InBoolArray_NativeFunctionPtr;

		// Token: 0x040142C4 RID: 82628
		private static IntPtr __InBool_NativeFunctionPtr;

		// Token: 0x040142C5 RID: 82629
		private static IntPtr __GetU8Set_NativeFunctionPtr;

		// Token: 0x040142C6 RID: 82630
		private static IntPtr __GetU8Map_NativeFunctionPtr;

		// Token: 0x040142C7 RID: 82631
		private static IntPtr __GetU8Array_NativeFunctionPtr;

		// Token: 0x040142C8 RID: 82632
		private static IntPtr __GetU8_NativeFunctionPtr;

		// Token: 0x040142C9 RID: 82633
		private static IntPtr __GetU64Set_NativeFunctionPtr;

		// Token: 0x040142CA RID: 82634
		private static IntPtr __GetU64Map_NativeFunctionPtr;

		// Token: 0x040142CB RID: 82635
		private static IntPtr __GetU64Array_NativeFunctionPtr;

		// Token: 0x040142CC RID: 82636
		private static IntPtr __GetU64_NativeFunctionPtr;

		// Token: 0x040142CD RID: 82637
		private static IntPtr __GetU32Set_NativeFunctionPtr;

		// Token: 0x040142CE RID: 82638
		private static IntPtr __GetU32Map_NativeFunctionPtr;

		// Token: 0x040142CF RID: 82639
		private static IntPtr __GetU32Array_NativeFunctionPtr;

		// Token: 0x040142D0 RID: 82640
		private static IntPtr __GetU32_NativeFunctionPtr;

		// Token: 0x040142D1 RID: 82641
		private static IntPtr __GetU16Set_NativeFunctionPtr;

		// Token: 0x040142D2 RID: 82642
		private static IntPtr __GetU16Map_NativeFunctionPtr;

		// Token: 0x040142D3 RID: 82643
		private static IntPtr __GetU16Array_NativeFunctionPtr;

		// Token: 0x040142D4 RID: 82644
		private static IntPtr __GetU16_NativeFunctionPtr;

		// Token: 0x040142D5 RID: 82645
		private static IntPtr __GetI8Set_NativeFunctionPtr;

		// Token: 0x040142D6 RID: 82646
		private static IntPtr __GetI8Map_NativeFunctionPtr;

		// Token: 0x040142D7 RID: 82647
		private static IntPtr __GetI8Array_NativeFunctionPtr;

		// Token: 0x040142D8 RID: 82648
		private static IntPtr __GetI8_NativeFunctionPtr;

		// Token: 0x040142D9 RID: 82649
		private static IntPtr __GetI64Set_NativeFunctionPtr;

		// Token: 0x040142DA RID: 82650
		private static IntPtr __GetI64Map_NativeFunctionPtr;

		// Token: 0x040142DB RID: 82651
		private static IntPtr __GetI64Array_NativeFunctionPtr;

		// Token: 0x040142DC RID: 82652
		private static IntPtr __GetI64_NativeFunctionPtr;

		// Token: 0x040142DD RID: 82653
		private static IntPtr __GetI32Set_NativeFunctionPtr;

		// Token: 0x040142DE RID: 82654
		private static IntPtr __GetI32Map_NativeFunctionPtr;

		// Token: 0x040142DF RID: 82655
		private static IntPtr __GetI32Array_NativeFunctionPtr;

		// Token: 0x040142E0 RID: 82656
		private static IntPtr __GetI32_NativeFunctionPtr;

		// Token: 0x040142E1 RID: 82657
		private static IntPtr __GetI16Set_NativeFunctionPtr;

		// Token: 0x040142E2 RID: 82658
		private static IntPtr __GetI16Map_NativeFunctionPtr;

		// Token: 0x040142E3 RID: 82659
		private static IntPtr __GetI16Array_NativeFunctionPtr;

		// Token: 0x040142E4 RID: 82660
		private static IntPtr __GetI16_NativeFunctionPtr;

		// Token: 0x040142E5 RID: 82661
		private static IntPtr __GetF64Set_NativeFunctionPtr;

		// Token: 0x040142E6 RID: 82662
		private static IntPtr __GetF64Map_NativeFunctionPtr;

		// Token: 0x040142E7 RID: 82663
		private static IntPtr __GetF64Array_NativeFunctionPtr;

		// Token: 0x040142E8 RID: 82664
		private static IntPtr __GetF64_NativeFunctionPtr;

		// Token: 0x040142E9 RID: 82665
		private static IntPtr __GetF32Set_NativeFunctionPtr;

		// Token: 0x040142EA RID: 82666
		private static IntPtr __GetF32Map_NativeFunctionPtr;

		// Token: 0x040142EB RID: 82667
		private static IntPtr __GetF32Array_NativeFunctionPtr;

		// Token: 0x040142EC RID: 82668
		private static IntPtr __GetF32_NativeFunctionPtr;

		// Token: 0x040142ED RID: 82669
		private static IntPtr __GetBoolSet_NativeFunctionPtr;

		// Token: 0x040142EE RID: 82670
		private static IntPtr __GetBoolMap_NativeFunctionPtr;

		// Token: 0x040142EF RID: 82671
		private static IntPtr __GetBoolArray_NativeFunctionPtr;

		// Token: 0x040142F0 RID: 82672
		private static IntPtr __GetBool_NativeFunctionPtr;

		// Token: 0x020036D3 RID: 14035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Set_FunctionParams
		{
			// Token: 0x040177FA RID: 96250
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x020036D4 RID: 14036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Map_FunctionParams
		{
			// Token: 0x040177FB RID: 96251
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x020036D5 RID: 14037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU8Array_FunctionParams
		{
			// Token: 0x040177FC RID: 96252
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x020036D6 RID: 14038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetU8_FunctionParams
		{
			// Token: 0x040177FD RID: 96253
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x020036D7 RID: 14039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Set_FunctionParams
		{
			// Token: 0x040177FE RID: 96254
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x020036D8 RID: 14040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Map_FunctionParams
		{
			// Token: 0x040177FF RID: 96255
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x020036D9 RID: 14041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU64Array_FunctionParams
		{
			// Token: 0x04017800 RID: 96256
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x020036DA RID: 14042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetU64_FunctionParams
		{
			// Token: 0x04017801 RID: 96257
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x020036DB RID: 14043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Set_FunctionParams
		{
			// Token: 0x04017802 RID: 96258
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x020036DC RID: 14044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Map_FunctionParams
		{
			// Token: 0x04017803 RID: 96259
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x020036DD RID: 14045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU32Array_FunctionParams
		{
			// Token: 0x04017804 RID: 96260
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x020036DE RID: 14046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetU32_FunctionParams
		{
			// Token: 0x04017805 RID: 96261
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x020036DF RID: 14047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Set_FunctionParams
		{
			// Token: 0x04017806 RID: 96262
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x020036E0 RID: 14048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Map_FunctionParams
		{
			// Token: 0x04017807 RID: 96263
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x020036E1 RID: 14049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU16Array_FunctionParams
		{
			// Token: 0x04017808 RID: 96264
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x020036E2 RID: 14050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetU16_FunctionParams
		{
			// Token: 0x04017809 RID: 96265
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x020036E3 RID: 14051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Set_FunctionParams
		{
			// Token: 0x0401780A RID: 96266
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x020036E4 RID: 14052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Map_FunctionParams
		{
			// Token: 0x0401780B RID: 96267
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x020036E5 RID: 14053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI8Array_FunctionParams
		{
			// Token: 0x0401780C RID: 96268
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x020036E6 RID: 14054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetI8_FunctionParams
		{
			// Token: 0x0401780D RID: 96269
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x020036E7 RID: 14055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Set_FunctionParams
		{
			// Token: 0x0401780E RID: 96270
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x020036E8 RID: 14056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Map_FunctionParams
		{
			// Token: 0x0401780F RID: 96271
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x020036E9 RID: 14057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI64Array_FunctionParams
		{
			// Token: 0x04017810 RID: 96272
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x020036EA RID: 14058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetI64_FunctionParams
		{
			// Token: 0x04017811 RID: 96273
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x020036EB RID: 14059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Set_FunctionParams
		{
			// Token: 0x04017812 RID: 96274
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x020036EC RID: 14060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Map_FunctionParams
		{
			// Token: 0x04017813 RID: 96275
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x020036ED RID: 14061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI32Array_FunctionParams
		{
			// Token: 0x04017814 RID: 96276
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x020036EE RID: 14062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetI32_FunctionParams
		{
			// Token: 0x04017815 RID: 96277
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x020036EF RID: 14063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Set_FunctionParams
		{
			// Token: 0x04017816 RID: 96278
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x020036F0 RID: 14064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Map_FunctionParams
		{
			// Token: 0x04017817 RID: 96279
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x020036F1 RID: 14065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI16Array_FunctionParams
		{
			// Token: 0x04017818 RID: 96280
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x020036F2 RID: 14066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetI16_FunctionParams
		{
			// Token: 0x04017819 RID: 96281
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x020036F3 RID: 14067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Set_FunctionParams
		{
			// Token: 0x0401781A RID: 96282
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x020036F4 RID: 14068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Map_FunctionParams
		{
			// Token: 0x0401781B RID: 96283
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x020036F5 RID: 14069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF64Array_FunctionParams
		{
			// Token: 0x0401781C RID: 96284
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x020036F6 RID: 14070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetF64_FunctionParams
		{
			// Token: 0x0401781D RID: 96285
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x020036F7 RID: 14071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Set_FunctionParams
		{
			// Token: 0x0401781E RID: 96286
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x020036F8 RID: 14072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Map_FunctionParams
		{
			// Token: 0x0401781F RID: 96287
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x020036F9 RID: 14073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF32Array_FunctionParams
		{
			// Token: 0x04017820 RID: 96288
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x020036FA RID: 14074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetF32_FunctionParams
		{
			// Token: 0x04017821 RID: 96289
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x020036FB RID: 14075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolSet_FunctionParams
		{
			// Token: 0x04017822 RID: 96290
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x020036FC RID: 14076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolMap_FunctionParams
		{
			// Token: 0x04017823 RID: 96291
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x020036FD RID: 14077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBoolArray_FunctionParams
		{
			// Token: 0x04017824 RID: 96292
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x020036FE RID: 14078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetBool_FunctionParams
		{
			// Token: 0x04017825 RID: 96293
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x020036FF RID: 14079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Set_FunctionParams
		{
			// Token: 0x04017826 RID: 96294
			[FieldOffset(0)]
			public byte OutU8Set;
		}

		// Token: 0x02003700 RID: 14080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Map_FunctionParams
		{
			// Token: 0x04017827 RID: 96295
			[FieldOffset(0)]
			public byte OutU8Map;
		}

		// Token: 0x02003701 RID: 14081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU8Array_FunctionParams
		{
			// Token: 0x04017828 RID: 96296
			[FieldOffset(0)]
			public byte OutU8Array;
		}

		// Token: 0x02003702 RID: 14082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutU8_FunctionParams
		{
			// Token: 0x04017829 RID: 96297
			[FieldOffset(0)]
			public byte OutU8;
		}

		// Token: 0x02003703 RID: 14083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Set_FunctionParams
		{
			// Token: 0x0401782A RID: 96298
			[FieldOffset(0)]
			public byte OutU64Set;
		}

		// Token: 0x02003704 RID: 14084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Map_FunctionParams
		{
			// Token: 0x0401782B RID: 96299
			[FieldOffset(0)]
			public byte OutU64Map;
		}

		// Token: 0x02003705 RID: 14085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU64Array_FunctionParams
		{
			// Token: 0x0401782C RID: 96300
			[FieldOffset(0)]
			public byte OutU64Array;
		}

		// Token: 0x02003706 RID: 14086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutU64_FunctionParams
		{
			// Token: 0x0401782D RID: 96301
			[FieldOffset(0)]
			public ulong OutU64;
		}

		// Token: 0x02003707 RID: 14087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Set_FunctionParams
		{
			// Token: 0x0401782E RID: 96302
			[FieldOffset(0)]
			public byte OutU32Set;
		}

		// Token: 0x02003708 RID: 14088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Map_FunctionParams
		{
			// Token: 0x0401782F RID: 96303
			[FieldOffset(0)]
			public byte OutU32Map;
		}

		// Token: 0x02003709 RID: 14089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU32Array_FunctionParams
		{
			// Token: 0x04017830 RID: 96304
			[FieldOffset(0)]
			public byte OutU32Array;
		}

		// Token: 0x0200370A RID: 14090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutU32_FunctionParams
		{
			// Token: 0x04017831 RID: 96305
			[FieldOffset(0)]
			public uint OutU32;
		}

		// Token: 0x0200370B RID: 14091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Set_FunctionParams
		{
			// Token: 0x04017832 RID: 96306
			[FieldOffset(0)]
			public byte OutU16Set;
		}

		// Token: 0x0200370C RID: 14092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Map_FunctionParams
		{
			// Token: 0x04017833 RID: 96307
			[FieldOffset(0)]
			public byte OutU16Map;
		}

		// Token: 0x0200370D RID: 14093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU16Array_FunctionParams
		{
			// Token: 0x04017834 RID: 96308
			[FieldOffset(0)]
			public byte OutU16Array;
		}

		// Token: 0x0200370E RID: 14094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutU16_FunctionParams
		{
			// Token: 0x04017835 RID: 96309
			[FieldOffset(0)]
			public ushort OutU16;
		}

		// Token: 0x0200370F RID: 14095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Set_FunctionParams
		{
			// Token: 0x04017836 RID: 96310
			[FieldOffset(0)]
			public byte OutI8Set;
		}

		// Token: 0x02003710 RID: 14096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Map_FunctionParams
		{
			// Token: 0x04017837 RID: 96311
			[FieldOffset(0)]
			public byte OutI8Map;
		}

		// Token: 0x02003711 RID: 14097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI8Array_FunctionParams
		{
			// Token: 0x04017838 RID: 96312
			[FieldOffset(0)]
			public byte OutI8Array;
		}

		// Token: 0x02003712 RID: 14098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutI8_FunctionParams
		{
			// Token: 0x04017839 RID: 96313
			[FieldOffset(0)]
			public sbyte OutI8;
		}

		// Token: 0x02003713 RID: 14099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Set_FunctionParams
		{
			// Token: 0x0401783A RID: 96314
			[FieldOffset(0)]
			public byte OutI64Set;
		}

		// Token: 0x02003714 RID: 14100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Map_FunctionParams
		{
			// Token: 0x0401783B RID: 96315
			[FieldOffset(0)]
			public byte OutI64Map;
		}

		// Token: 0x02003715 RID: 14101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI64Array_FunctionParams
		{
			// Token: 0x0401783C RID: 96316
			[FieldOffset(0)]
			public byte OutI64Array;
		}

		// Token: 0x02003716 RID: 14102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutI64_FunctionParams
		{
			// Token: 0x0401783D RID: 96317
			[FieldOffset(0)]
			public long OutI64;
		}

		// Token: 0x02003717 RID: 14103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Set_FunctionParams
		{
			// Token: 0x0401783E RID: 96318
			[FieldOffset(0)]
			public byte OutI32Set;
		}

		// Token: 0x02003718 RID: 14104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Map_FunctionParams
		{
			// Token: 0x0401783F RID: 96319
			[FieldOffset(0)]
			public byte OutI32Map;
		}

		// Token: 0x02003719 RID: 14105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI32Array_FunctionParams
		{
			// Token: 0x04017840 RID: 96320
			[FieldOffset(0)]
			public byte OutI32Array;
		}

		// Token: 0x0200371A RID: 14106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutI32_FunctionParams
		{
			// Token: 0x04017841 RID: 96321
			[FieldOffset(0)]
			public int OutI32;
		}

		// Token: 0x0200371B RID: 14107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Set_FunctionParams
		{
			// Token: 0x04017842 RID: 96322
			[FieldOffset(0)]
			public byte OutI16Set;
		}

		// Token: 0x0200371C RID: 14108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Map_FunctionParams
		{
			// Token: 0x04017843 RID: 96323
			[FieldOffset(0)]
			public byte OutI16Map;
		}

		// Token: 0x0200371D RID: 14109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI16Array_FunctionParams
		{
			// Token: 0x04017844 RID: 96324
			[FieldOffset(0)]
			public byte OutI16Array;
		}

		// Token: 0x0200371E RID: 14110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutI16_FunctionParams
		{
			// Token: 0x04017845 RID: 96325
			[FieldOffset(0)]
			public short OutI16;
		}

		// Token: 0x0200371F RID: 14111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Set_FunctionParams
		{
			// Token: 0x04017846 RID: 96326
			[FieldOffset(0)]
			public byte OutF64Set;
		}

		// Token: 0x02003720 RID: 14112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Map_FunctionParams
		{
			// Token: 0x04017847 RID: 96327
			[FieldOffset(0)]
			public byte OutF64Map;
		}

		// Token: 0x02003721 RID: 14113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF64Array_FunctionParams
		{
			// Token: 0x04017848 RID: 96328
			[FieldOffset(0)]
			public byte OutF64Array;
		}

		// Token: 0x02003722 RID: 14114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutF64_FunctionParams
		{
			// Token: 0x04017849 RID: 96329
			[FieldOffset(0)]
			public double OutF64;
		}

		// Token: 0x02003723 RID: 14115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Set_FunctionParams
		{
			// Token: 0x0401784A RID: 96330
			[FieldOffset(0)]
			public byte OutF32Set;
		}

		// Token: 0x02003724 RID: 14116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Map_FunctionParams
		{
			// Token: 0x0401784B RID: 96331
			[FieldOffset(0)]
			public byte OutF32Map;
		}

		// Token: 0x02003725 RID: 14117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF32Array_FunctionParams
		{
			// Token: 0x0401784C RID: 96332
			[FieldOffset(0)]
			public byte OutF32Array;
		}

		// Token: 0x02003726 RID: 14118
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutF32_FunctionParams
		{
			// Token: 0x0401784D RID: 96333
			[FieldOffset(0)]
			public float OutF32;
		}

		// Token: 0x02003727 RID: 14119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolSet_FunctionParams
		{
			// Token: 0x0401784E RID: 96334
			[FieldOffset(0)]
			public byte OutBoolSet;
		}

		// Token: 0x02003728 RID: 14120
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolMap_FunctionParams
		{
			// Token: 0x0401784F RID: 96335
			[FieldOffset(0)]
			public byte OutBoolMap;
		}

		// Token: 0x02003729 RID: 14121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutBoolArray_FunctionParams
		{
			// Token: 0x04017850 RID: 96336
			[FieldOffset(0)]
			public byte OutBoolArray;
		}

		// Token: 0x0200372A RID: 14122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutBool_FunctionParams
		{
			// Token: 0x04017851 RID: 96337
			[FieldOffset(0)]
			public bool OutBool;
		}

		// Token: 0x0200372B RID: 14123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Set_FunctionParams
		{
			// Token: 0x04017852 RID: 96338
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x0200372C RID: 14124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Map_FunctionParams
		{
			// Token: 0x04017853 RID: 96339
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x0200372D RID: 14125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU8Array_FunctionParams
		{
			// Token: 0x04017854 RID: 96340
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x0200372E RID: 14126
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InU8_FunctionParams
		{
			// Token: 0x04017855 RID: 96341
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x0200372F RID: 14127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Set_FunctionParams
		{
			// Token: 0x04017856 RID: 96342
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x02003730 RID: 14128
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Map_FunctionParams
		{
			// Token: 0x04017857 RID: 96343
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x02003731 RID: 14129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU64Array_FunctionParams
		{
			// Token: 0x04017858 RID: 96344
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x02003732 RID: 14130
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InU64_FunctionParams
		{
			// Token: 0x04017859 RID: 96345
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x02003733 RID: 14131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Set_FunctionParams
		{
			// Token: 0x0401785A RID: 96346
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x02003734 RID: 14132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Map_FunctionParams
		{
			// Token: 0x0401785B RID: 96347
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x02003735 RID: 14133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU32Array_FunctionParams
		{
			// Token: 0x0401785C RID: 96348
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x02003736 RID: 14134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InU32_FunctionParams
		{
			// Token: 0x0401785D RID: 96349
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x02003737 RID: 14135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Set_FunctionParams
		{
			// Token: 0x0401785E RID: 96350
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x02003738 RID: 14136
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Map_FunctionParams
		{
			// Token: 0x0401785F RID: 96351
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x02003739 RID: 14137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU16Array_FunctionParams
		{
			// Token: 0x04017860 RID: 96352
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x0200373A RID: 14138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InU16_FunctionParams
		{
			// Token: 0x04017861 RID: 96353
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x0200373B RID: 14139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Set_FunctionParams
		{
			// Token: 0x04017862 RID: 96354
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x0200373C RID: 14140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Map_FunctionParams
		{
			// Token: 0x04017863 RID: 96355
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x0200373D RID: 14141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI8Array_FunctionParams
		{
			// Token: 0x04017864 RID: 96356
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x0200373E RID: 14142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InI8_FunctionParams
		{
			// Token: 0x04017865 RID: 96357
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x0200373F RID: 14143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Set_FunctionParams
		{
			// Token: 0x04017866 RID: 96358
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x02003740 RID: 14144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Map_FunctionParams
		{
			// Token: 0x04017867 RID: 96359
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x02003741 RID: 14145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI64Array_FunctionParams
		{
			// Token: 0x04017868 RID: 96360
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x02003742 RID: 14146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InI64_FunctionParams
		{
			// Token: 0x04017869 RID: 96361
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x02003743 RID: 14147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Set_FunctionParams
		{
			// Token: 0x0401786A RID: 96362
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x02003744 RID: 14148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Map_FunctionParams
		{
			// Token: 0x0401786B RID: 96363
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x02003745 RID: 14149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI32Array_FunctionParams
		{
			// Token: 0x0401786C RID: 96364
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x02003746 RID: 14150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InI32_FunctionParams
		{
			// Token: 0x0401786D RID: 96365
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x02003747 RID: 14151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Set_FunctionParams
		{
			// Token: 0x0401786E RID: 96366
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x02003748 RID: 14152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Map_FunctionParams
		{
			// Token: 0x0401786F RID: 96367
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x02003749 RID: 14153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI16Array_FunctionParams
		{
			// Token: 0x04017870 RID: 96368
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x0200374A RID: 14154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InI16_FunctionParams
		{
			// Token: 0x04017871 RID: 96369
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x0200374B RID: 14155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Set_FunctionParams
		{
			// Token: 0x04017872 RID: 96370
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x0200374C RID: 14156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Map_FunctionParams
		{
			// Token: 0x04017873 RID: 96371
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x0200374D RID: 14157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF64Array_FunctionParams
		{
			// Token: 0x04017874 RID: 96372
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x0200374E RID: 14158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InF64_FunctionParams
		{
			// Token: 0x04017875 RID: 96373
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x0200374F RID: 14159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Set_FunctionParams
		{
			// Token: 0x04017876 RID: 96374
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x02003750 RID: 14160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Map_FunctionParams
		{
			// Token: 0x04017877 RID: 96375
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x02003751 RID: 14161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF32Array_FunctionParams
		{
			// Token: 0x04017878 RID: 96376
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x02003752 RID: 14162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InF32_FunctionParams
		{
			// Token: 0x04017879 RID: 96377
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x02003753 RID: 14163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolSet_FunctionParams
		{
			// Token: 0x0401787A RID: 96378
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x02003754 RID: 14164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolMap_FunctionParams
		{
			// Token: 0x0401787B RID: 96379
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x02003755 RID: 14165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InBoolArray_FunctionParams
		{
			// Token: 0x0401787C RID: 96380
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x02003756 RID: 14166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InBool_FunctionParams
		{
			// Token: 0x0401787D RID: 96381
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02003757 RID: 14167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Set_FunctionParams
		{
			// Token: 0x0401787E RID: 96382
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003758 RID: 14168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Map_FunctionParams
		{
			// Token: 0x0401787F RID: 96383
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003759 RID: 14169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU8Array_FunctionParams
		{
			// Token: 0x04017880 RID: 96384
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200375A RID: 14170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetU8_FunctionParams
		{
			// Token: 0x04017881 RID: 96385
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200375B RID: 14171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Set_FunctionParams
		{
			// Token: 0x04017882 RID: 96386
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200375C RID: 14172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Map_FunctionParams
		{
			// Token: 0x04017883 RID: 96387
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200375D RID: 14173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU64Array_FunctionParams
		{
			// Token: 0x04017884 RID: 96388
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200375E RID: 14174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetU64_FunctionParams
		{
			// Token: 0x04017885 RID: 96389
			[FieldOffset(0)]
			public ulong __Result;
		}

		// Token: 0x0200375F RID: 14175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Set_FunctionParams
		{
			// Token: 0x04017886 RID: 96390
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003760 RID: 14176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Map_FunctionParams
		{
			// Token: 0x04017887 RID: 96391
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003761 RID: 14177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU32Array_FunctionParams
		{
			// Token: 0x04017888 RID: 96392
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003762 RID: 14178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetU32_FunctionParams
		{
			// Token: 0x04017889 RID: 96393
			[FieldOffset(0)]
			public uint __Result;
		}

		// Token: 0x02003763 RID: 14179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Set_FunctionParams
		{
			// Token: 0x0401788A RID: 96394
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003764 RID: 14180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Map_FunctionParams
		{
			// Token: 0x0401788B RID: 96395
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003765 RID: 14181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU16Array_FunctionParams
		{
			// Token: 0x0401788C RID: 96396
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003766 RID: 14182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetU16_FunctionParams
		{
			// Token: 0x0401788D RID: 96397
			[FieldOffset(0)]
			public ushort __Result;
		}

		// Token: 0x02003767 RID: 14183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Set_FunctionParams
		{
			// Token: 0x0401788E RID: 96398
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003768 RID: 14184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Map_FunctionParams
		{
			// Token: 0x0401788F RID: 96399
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003769 RID: 14185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI8Array_FunctionParams
		{
			// Token: 0x04017890 RID: 96400
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200376A RID: 14186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetI8_FunctionParams
		{
			// Token: 0x04017891 RID: 96401
			[FieldOffset(0)]
			public sbyte __Result;
		}

		// Token: 0x0200376B RID: 14187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Set_FunctionParams
		{
			// Token: 0x04017892 RID: 96402
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200376C RID: 14188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Map_FunctionParams
		{
			// Token: 0x04017893 RID: 96403
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200376D RID: 14189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI64Array_FunctionParams
		{
			// Token: 0x04017894 RID: 96404
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200376E RID: 14190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetI64_FunctionParams
		{
			// Token: 0x04017895 RID: 96405
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x0200376F RID: 14191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Set_FunctionParams
		{
			// Token: 0x04017896 RID: 96406
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003770 RID: 14192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Map_FunctionParams
		{
			// Token: 0x04017897 RID: 96407
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003771 RID: 14193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI32Array_FunctionParams
		{
			// Token: 0x04017898 RID: 96408
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003772 RID: 14194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetI32_FunctionParams
		{
			// Token: 0x04017899 RID: 96409
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003773 RID: 14195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Set_FunctionParams
		{
			// Token: 0x0401789A RID: 96410
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003774 RID: 14196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Map_FunctionParams
		{
			// Token: 0x0401789B RID: 96411
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003775 RID: 14197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI16Array_FunctionParams
		{
			// Token: 0x0401789C RID: 96412
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003776 RID: 14198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetI16_FunctionParams
		{
			// Token: 0x0401789D RID: 96413
			[FieldOffset(0)]
			public short __Result;
		}

		// Token: 0x02003777 RID: 14199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Set_FunctionParams
		{
			// Token: 0x0401789E RID: 96414
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003778 RID: 14200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Map_FunctionParams
		{
			// Token: 0x0401789F RID: 96415
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003779 RID: 14201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF64Array_FunctionParams
		{
			// Token: 0x040178A0 RID: 96416
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200377A RID: 14202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetF64_FunctionParams
		{
			// Token: 0x040178A1 RID: 96417
			[FieldOffset(0)]
			public double __Result;
		}

		// Token: 0x0200377B RID: 14203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Set_FunctionParams
		{
			// Token: 0x040178A2 RID: 96418
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200377C RID: 14204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Map_FunctionParams
		{
			// Token: 0x040178A3 RID: 96419
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200377D RID: 14205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF32Array_FunctionParams
		{
			// Token: 0x040178A4 RID: 96420
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200377E RID: 14206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetF32_FunctionParams
		{
			// Token: 0x040178A5 RID: 96421
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200377F RID: 14207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolSet_FunctionParams
		{
			// Token: 0x040178A6 RID: 96422
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003780 RID: 14208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolMap_FunctionParams
		{
			// Token: 0x040178A7 RID: 96423
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003781 RID: 14209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoolArray_FunctionParams
		{
			// Token: 0x040178A8 RID: 96424
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003782 RID: 14210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetBool_FunctionParams
		{
			// Token: 0x040178A9 RID: 96425
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
