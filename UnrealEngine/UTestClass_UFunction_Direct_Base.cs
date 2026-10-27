using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002747 RID: 10055
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class UTestClass_UFunction_Direct_Base : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602559B RID: 152987 RVA: 0x0037A5F9 File Offset: 0x003787F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Base._ClassPtr;
		}

		// Token: 0x0602559C RID: 152988 RVA: 0x0037A608 File Offset: 0x00378808
		public UTestClass_UFunction_Direct_Base() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602559D RID: 152989 RVA: 0x0037A630 File Offset: 0x00378830
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009044 RID: 36932
		// (get) Token: 0x0602559E RID: 152990 RVA: 0x0037A663 File Offset: 0x00378863
		// (set) Token: 0x0602559F RID: 152991 RVA: 0x0037A673 File Offset: 0x00378873
		public unsafe bool Bool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_Bool) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_Bool) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009045 RID: 36933
		// (get) Token: 0x060255A0 RID: 152992 RVA: 0x0037A684 File Offset: 0x00378884
		// (set) Token: 0x060255A1 RID: 152993 RVA: 0x0037A6BD File Offset: 0x003788BD
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
					result = (this._BoolArray = new TArray<bool>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_BoolArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolArray.CopyAssign(value);
			}
		}

		// Token: 0x17009046 RID: 36934
		// (get) Token: 0x060255A2 RID: 152994 RVA: 0x0037A6CC File Offset: 0x003788CC
		// (set) Token: 0x060255A3 RID: 152995 RVA: 0x0037A705 File Offset: 0x00378905
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
					result = (this._BoolSet = new TSet<bool>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_BoolSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolSet.CopyAssign(value);
			}
		}

		// Token: 0x17009047 RID: 36935
		// (get) Token: 0x060255A4 RID: 152996 RVA: 0x0037A714 File Offset: 0x00378914
		// (set) Token: 0x060255A5 RID: 152997 RVA: 0x0037A74D File Offset: 0x0037894D
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
					result = (this._BoolMap = new TMap<bool, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_BoolMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoolMap.CopyAssign(value);
			}
		}

		// Token: 0x17009048 RID: 36936
		// (get) Token: 0x060255A6 RID: 152998 RVA: 0x0037A75B File Offset: 0x0037895B
		// (set) Token: 0x060255A7 RID: 152999 RVA: 0x0037A76B File Offset: 0x0037896B
		public unsafe sbyte I8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I8) = (byte)value;
			}
		}

		// Token: 0x17009049 RID: 36937
		// (get) Token: 0x060255A8 RID: 153000 RVA: 0x0037A77C File Offset: 0x0037897C
		// (set) Token: 0x060255A9 RID: 153001 RVA: 0x0037A7B5 File Offset: 0x003789B5
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
					result = (this._I8Array = new TArray<sbyte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I8Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Array.CopyAssign(value);
			}
		}

		// Token: 0x1700904A RID: 36938
		// (get) Token: 0x060255AA RID: 153002 RVA: 0x0037A7C4 File Offset: 0x003789C4
		// (set) Token: 0x060255AB RID: 153003 RVA: 0x0037A7FD File Offset: 0x003789FD
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
					result = (this._I8Set = new TSet<sbyte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I8Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Set.CopyAssign(value);
			}
		}

		// Token: 0x1700904B RID: 36939
		// (get) Token: 0x060255AC RID: 153004 RVA: 0x0037A80C File Offset: 0x00378A0C
		// (set) Token: 0x060255AD RID: 153005 RVA: 0x0037A845 File Offset: 0x00378A45
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
					result = (this._I8Map = new TMap<sbyte, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I8Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I8Map.CopyAssign(value);
			}
		}

		// Token: 0x1700904C RID: 36940
		// (get) Token: 0x060255AE RID: 153006 RVA: 0x0037A853 File Offset: 0x00378A53
		// (set) Token: 0x060255AF RID: 153007 RVA: 0x0037A863 File Offset: 0x00378A63
		public unsafe byte U8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U8) = value;
			}
		}

		// Token: 0x1700904D RID: 36941
		// (get) Token: 0x060255B0 RID: 153008 RVA: 0x0037A874 File Offset: 0x00378A74
		// (set) Token: 0x060255B1 RID: 153009 RVA: 0x0037A8AD File Offset: 0x00378AAD
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
					result = (this._U8Array = new TArray<byte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U8Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Array.CopyAssign(value);
			}
		}

		// Token: 0x1700904E RID: 36942
		// (get) Token: 0x060255B2 RID: 153010 RVA: 0x0037A8BC File Offset: 0x00378ABC
		// (set) Token: 0x060255B3 RID: 153011 RVA: 0x0037A8F5 File Offset: 0x00378AF5
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
					result = (this._U8Set = new TSet<byte>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U8Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Set.CopyAssign(value);
			}
		}

		// Token: 0x1700904F RID: 36943
		// (get) Token: 0x060255B4 RID: 153012 RVA: 0x0037A904 File Offset: 0x00378B04
		// (set) Token: 0x060255B5 RID: 153013 RVA: 0x0037A93D File Offset: 0x00378B3D
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
					result = (this._U8Map = new TMap<byte, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U8Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U8Map.CopyAssign(value);
			}
		}

		// Token: 0x17009050 RID: 36944
		// (get) Token: 0x060255B6 RID: 153014 RVA: 0x0037A94B File Offset: 0x00378B4B
		// (set) Token: 0x060255B7 RID: 153015 RVA: 0x0037A95B File Offset: 0x00378B5B
		public unsafe short I16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I16) = value;
			}
		}

		// Token: 0x17009051 RID: 36945
		// (get) Token: 0x060255B8 RID: 153016 RVA: 0x0037A96C File Offset: 0x00378B6C
		// (set) Token: 0x060255B9 RID: 153017 RVA: 0x0037A9A5 File Offset: 0x00378BA5
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
					result = (this._I16Array = new TArray<short>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I16Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Array.CopyAssign(value);
			}
		}

		// Token: 0x17009052 RID: 36946
		// (get) Token: 0x060255BA RID: 153018 RVA: 0x0037A9B4 File Offset: 0x00378BB4
		// (set) Token: 0x060255BB RID: 153019 RVA: 0x0037A9ED File Offset: 0x00378BED
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
					result = (this._I16Set = new TSet<short>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I16Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Set.CopyAssign(value);
			}
		}

		// Token: 0x17009053 RID: 36947
		// (get) Token: 0x060255BC RID: 153020 RVA: 0x0037A9FC File Offset: 0x00378BFC
		// (set) Token: 0x060255BD RID: 153021 RVA: 0x0037AA35 File Offset: 0x00378C35
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
					result = (this._I16Map = new TMap<short, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I16Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I16Map.CopyAssign(value);
			}
		}

		// Token: 0x17009054 RID: 36948
		// (get) Token: 0x060255BE RID: 153022 RVA: 0x0037AA43 File Offset: 0x00378C43
		// (set) Token: 0x060255BF RID: 153023 RVA: 0x0037AA53 File Offset: 0x00378C53
		public unsafe ushort U16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U16) = (short)value;
			}
		}

		// Token: 0x17009055 RID: 36949
		// (get) Token: 0x060255C0 RID: 153024 RVA: 0x0037AA64 File Offset: 0x00378C64
		// (set) Token: 0x060255C1 RID: 153025 RVA: 0x0037AA9D File Offset: 0x00378C9D
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
					result = (this._U16Array = new TArray<ushort>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U16Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Array.CopyAssign(value);
			}
		}

		// Token: 0x17009056 RID: 36950
		// (get) Token: 0x060255C2 RID: 153026 RVA: 0x0037AAAC File Offset: 0x00378CAC
		// (set) Token: 0x060255C3 RID: 153027 RVA: 0x0037AAE5 File Offset: 0x00378CE5
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
					result = (this._U16Set = new TSet<ushort>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U16Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Set.CopyAssign(value);
			}
		}

		// Token: 0x17009057 RID: 36951
		// (get) Token: 0x060255C4 RID: 153028 RVA: 0x0037AAF4 File Offset: 0x00378CF4
		// (set) Token: 0x060255C5 RID: 153029 RVA: 0x0037AB2D File Offset: 0x00378D2D
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
					result = (this._U16Map = new TMap<ushort, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U16Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U16Map.CopyAssign(value);
			}
		}

		// Token: 0x17009058 RID: 36952
		// (get) Token: 0x060255C6 RID: 153030 RVA: 0x0037AB3B File Offset: 0x00378D3B
		// (set) Token: 0x060255C7 RID: 153031 RVA: 0x0037AB4B File Offset: 0x00378D4B
		public unsafe int I32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I32) = value;
			}
		}

		// Token: 0x17009059 RID: 36953
		// (get) Token: 0x060255C8 RID: 153032 RVA: 0x0037AB5C File Offset: 0x00378D5C
		// (set) Token: 0x060255C9 RID: 153033 RVA: 0x0037AB95 File Offset: 0x00378D95
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
					result = (this._I32Array = new TArray<int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Array.CopyAssign(value);
			}
		}

		// Token: 0x1700905A RID: 36954
		// (get) Token: 0x060255CA RID: 153034 RVA: 0x0037ABA4 File Offset: 0x00378DA4
		// (set) Token: 0x060255CB RID: 153035 RVA: 0x0037ABDD File Offset: 0x00378DDD
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
					result = (this._I32Set = new TSet<int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Set.CopyAssign(value);
			}
		}

		// Token: 0x1700905B RID: 36955
		// (get) Token: 0x060255CC RID: 153036 RVA: 0x0037ABEC File Offset: 0x00378DEC
		// (set) Token: 0x060255CD RID: 153037 RVA: 0x0037AC25 File Offset: 0x00378E25
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
					result = (this._I32Map = new TMap<int, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I32Map.CopyAssign(value);
			}
		}

		// Token: 0x1700905C RID: 36956
		// (get) Token: 0x060255CE RID: 153038 RVA: 0x0037AC33 File Offset: 0x00378E33
		// (set) Token: 0x060255CF RID: 153039 RVA: 0x0037AC43 File Offset: 0x00378E43
		public unsafe uint U32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U32) = (int)value;
			}
		}

		// Token: 0x1700905D RID: 36957
		// (get) Token: 0x060255D0 RID: 153040 RVA: 0x0037AC54 File Offset: 0x00378E54
		// (set) Token: 0x060255D1 RID: 153041 RVA: 0x0037AC8D File Offset: 0x00378E8D
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
					result = (this._U32Array = new TArray<uint>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Array.CopyAssign(value);
			}
		}

		// Token: 0x1700905E RID: 36958
		// (get) Token: 0x060255D2 RID: 153042 RVA: 0x0037AC9C File Offset: 0x00378E9C
		// (set) Token: 0x060255D3 RID: 153043 RVA: 0x0037ACD5 File Offset: 0x00378ED5
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
					result = (this._U32Set = new TSet<uint>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Set.CopyAssign(value);
			}
		}

		// Token: 0x1700905F RID: 36959
		// (get) Token: 0x060255D4 RID: 153044 RVA: 0x0037ACE4 File Offset: 0x00378EE4
		// (set) Token: 0x060255D5 RID: 153045 RVA: 0x0037AD1D File Offset: 0x00378F1D
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
					result = (this._U32Map = new TMap<uint, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U32Map.CopyAssign(value);
			}
		}

		// Token: 0x17009060 RID: 36960
		// (get) Token: 0x060255D6 RID: 153046 RVA: 0x0037AD2B File Offset: 0x00378F2B
		// (set) Token: 0x060255D7 RID: 153047 RVA: 0x0037AD3B File Offset: 0x00378F3B
		public unsafe long I64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I64) = value;
			}
		}

		// Token: 0x17009061 RID: 36961
		// (get) Token: 0x060255D8 RID: 153048 RVA: 0x0037AD4C File Offset: 0x00378F4C
		// (set) Token: 0x060255D9 RID: 153049 RVA: 0x0037AD85 File Offset: 0x00378F85
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
					result = (this._I64Array = new TArray<long>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Array.CopyAssign(value);
			}
		}

		// Token: 0x17009062 RID: 36962
		// (get) Token: 0x060255DA RID: 153050 RVA: 0x0037AD94 File Offset: 0x00378F94
		// (set) Token: 0x060255DB RID: 153051 RVA: 0x0037ADCD File Offset: 0x00378FCD
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
					result = (this._I64Set = new TSet<long>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Set.CopyAssign(value);
			}
		}

		// Token: 0x17009063 RID: 36963
		// (get) Token: 0x060255DC RID: 153052 RVA: 0x0037ADDC File Offset: 0x00378FDC
		// (set) Token: 0x060255DD RID: 153053 RVA: 0x0037AE15 File Offset: 0x00379015
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
					result = (this._I64Map = new TMap<long, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_I64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.I64Map.CopyAssign(value);
			}
		}

		// Token: 0x17009064 RID: 36964
		// (get) Token: 0x060255DE RID: 153054 RVA: 0x0037AE23 File Offset: 0x00379023
		// (set) Token: 0x060255DF RID: 153055 RVA: 0x0037AE33 File Offset: 0x00379033
		public unsafe ulong U64
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U64));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U64) = (long)value;
			}
		}

		// Token: 0x17009065 RID: 36965
		// (get) Token: 0x060255E0 RID: 153056 RVA: 0x0037AE44 File Offset: 0x00379044
		// (set) Token: 0x060255E1 RID: 153057 RVA: 0x0037AE7D File Offset: 0x0037907D
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
					result = (this._U64Array = new TArray<ulong>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Array.CopyAssign(value);
			}
		}

		// Token: 0x17009066 RID: 36966
		// (get) Token: 0x060255E2 RID: 153058 RVA: 0x0037AE8C File Offset: 0x0037908C
		// (set) Token: 0x060255E3 RID: 153059 RVA: 0x0037AEC5 File Offset: 0x003790C5
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
					result = (this._U64Set = new TSet<ulong>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Set.CopyAssign(value);
			}
		}

		// Token: 0x17009067 RID: 36967
		// (get) Token: 0x060255E4 RID: 153060 RVA: 0x0037AED4 File Offset: 0x003790D4
		// (set) Token: 0x060255E5 RID: 153061 RVA: 0x0037AF0D File Offset: 0x0037910D
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
					result = (this._U64Map = new TMap<ulong, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_U64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.U64Map.CopyAssign(value);
			}
		}

		// Token: 0x17009068 RID: 36968
		// (get) Token: 0x060255E6 RID: 153062 RVA: 0x0037AF1B File Offset: 0x0037911B
		// (set) Token: 0x060255E7 RID: 153063 RVA: 0x0037AF2B File Offset: 0x0037912B
		public unsafe float F32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F32) = value;
			}
		}

		// Token: 0x17009069 RID: 36969
		// (get) Token: 0x060255E8 RID: 153064 RVA: 0x0037AF3C File Offset: 0x0037913C
		// (set) Token: 0x060255E9 RID: 153065 RVA: 0x0037AF75 File Offset: 0x00379175
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
					result = (this._F32Array = new TArray<float>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F32Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Array.CopyAssign(value);
			}
		}

		// Token: 0x1700906A RID: 36970
		// (get) Token: 0x060255EA RID: 153066 RVA: 0x0037AF84 File Offset: 0x00379184
		// (set) Token: 0x060255EB RID: 153067 RVA: 0x0037AFBD File Offset: 0x003791BD
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
					result = (this._F32Set = new TSet<float>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F32Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Set.CopyAssign(value);
			}
		}

		// Token: 0x1700906B RID: 36971
		// (get) Token: 0x060255EC RID: 153068 RVA: 0x0037AFCC File Offset: 0x003791CC
		// (set) Token: 0x060255ED RID: 153069 RVA: 0x0037B005 File Offset: 0x00379205
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
					result = (this._F32Map = new TMap<float, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F32Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F32Map.CopyAssign(value);
			}
		}

		// Token: 0x1700906C RID: 36972
		// (get) Token: 0x060255EE RID: 153070 RVA: 0x0037B013 File Offset: 0x00379213
		// (set) Token: 0x060255EF RID: 153071 RVA: 0x0037B023 File Offset: 0x00379223
		public unsafe double F64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F64) = value;
			}
		}

		// Token: 0x1700906D RID: 36973
		// (get) Token: 0x060255F0 RID: 153072 RVA: 0x0037B034 File Offset: 0x00379234
		// (set) Token: 0x060255F1 RID: 153073 RVA: 0x0037B06D File Offset: 0x0037926D
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
					result = (this._F64Array = new TArray<double>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F64Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Array.CopyAssign(value);
			}
		}

		// Token: 0x1700906E RID: 36974
		// (get) Token: 0x060255F2 RID: 153074 RVA: 0x0037B07C File Offset: 0x0037927C
		// (set) Token: 0x060255F3 RID: 153075 RVA: 0x0037B0B5 File Offset: 0x003792B5
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
					result = (this._F64Set = new TSet<double>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F64Set, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Set.CopyAssign(value);
			}
		}

		// Token: 0x1700906F RID: 36975
		// (get) Token: 0x060255F4 RID: 153076 RVA: 0x0037B0C4 File Offset: 0x003792C4
		// (set) Token: 0x060255F5 RID: 153077 RVA: 0x0037B0FD File Offset: 0x003792FD
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
					result = (this._F64Map = new TMap<double, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Base.__PropertyOffset_F64Map, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.F64Map.CopyAssign(value);
			}
		}

		// Token: 0x060255F6 RID: 153078 RVA: 0x0037B10C File Offset: 0x0037930C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Set(TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Set != null)
			{
				InU8Set.CopyTo(&ptr->InU8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255F7 RID: 153079 RVA: 0x0037B178 File Offset: 0x00379378
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Map(TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Map != null)
			{
				InU8Map.CopyTo(&ptr->InU8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255F8 RID: 153080 RVA: 0x0037B1E4 File Offset: 0x003793E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8Array(TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Array != null)
			{
				InU8Array.CopyTo(&ptr->InU8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255F9 RID: 153081 RVA: 0x0037B250 File Offset: 0x00379450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU8(byte InU8)
		{
			UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060255FA RID: 153082 RVA: 0x0037B298 File Offset: 0x00379498
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Set(TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Set != null)
			{
				InU64Set.CopyTo(&ptr->InU64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255FB RID: 153083 RVA: 0x0037B304 File Offset: 0x00379504
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Map(TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Map != null)
			{
				InU64Map.CopyTo(&ptr->InU64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255FC RID: 153084 RVA: 0x0037B370 File Offset: 0x00379570
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64Array(TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Array != null)
			{
				InU64Array.CopyTo(&ptr->InU64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255FD RID: 153085 RVA: 0x0037B3DC File Offset: 0x003795DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU64(ulong InU64)
		{
			UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060255FE RID: 153086 RVA: 0x0037B424 File Offset: 0x00379624
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Set(TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Set != null)
			{
				InU32Set.CopyTo(&ptr->InU32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060255FF RID: 153087 RVA: 0x0037B490 File Offset: 0x00379690
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Map(TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Map != null)
			{
				InU32Map.CopyTo(&ptr->InU32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025600 RID: 153088 RVA: 0x0037B4FC File Offset: 0x003796FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32Array(TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Array != null)
			{
				InU32Array.CopyTo(&ptr->InU32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025601 RID: 153089 RVA: 0x0037B568 File Offset: 0x00379768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU32(uint InU32)
		{
			UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025602 RID: 153090 RVA: 0x0037B5B0 File Offset: 0x003797B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Set(TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Set != null)
			{
				InU16Set.CopyTo(&ptr->InU16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025603 RID: 153091 RVA: 0x0037B61C File Offset: 0x0037981C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Map(TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Map != null)
			{
				InU16Map.CopyTo(&ptr->InU16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025604 RID: 153092 RVA: 0x0037B688 File Offset: 0x00379888
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16Array(TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Array != null)
			{
				InU16Array.CopyTo(&ptr->InU16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025605 RID: 153093 RVA: 0x0037B6F4 File Offset: 0x003798F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetU16(ushort InU16)
		{
			UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025606 RID: 153094 RVA: 0x0037B73C File Offset: 0x0037993C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Set(TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Set != null)
			{
				InI8Set.CopyTo(&ptr->InI8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025607 RID: 153095 RVA: 0x0037B7A8 File Offset: 0x003799A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Map(TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Map != null)
			{
				InI8Map.CopyTo(&ptr->InI8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025608 RID: 153096 RVA: 0x0037B814 File Offset: 0x00379A14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8Array(TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Array != null)
			{
				InI8Array.CopyTo(&ptr->InI8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025609 RID: 153097 RVA: 0x0037B880 File Offset: 0x00379A80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI8(sbyte InI8)
		{
			UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602560A RID: 153098 RVA: 0x0037B8C8 File Offset: 0x00379AC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Set(TSet<long> InI64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Set != null)
			{
				InI64Set.CopyTo(&ptr->InI64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602560B RID: 153099 RVA: 0x0037B934 File Offset: 0x00379B34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Map(TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Map != null)
			{
				InI64Map.CopyTo(&ptr->InI64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602560C RID: 153100 RVA: 0x0037B9A0 File Offset: 0x00379BA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64Array(TArray<long> InI64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Array != null)
			{
				InI64Array.CopyTo(&ptr->InI64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602560D RID: 153101 RVA: 0x0037BA0C File Offset: 0x00379C0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI64(long InI64)
		{
			UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602560E RID: 153102 RVA: 0x0037BA54 File Offset: 0x00379C54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Set(TSet<int> InI32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Set != null)
			{
				InI32Set.CopyTo(&ptr->InI32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602560F RID: 153103 RVA: 0x0037BAC0 File Offset: 0x00379CC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Map(TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Map != null)
			{
				InI32Map.CopyTo(&ptr->InI32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025610 RID: 153104 RVA: 0x0037BB2C File Offset: 0x00379D2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32Array(TArray<int> InI32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Array != null)
			{
				InI32Array.CopyTo(&ptr->InI32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025611 RID: 153105 RVA: 0x0037BB98 File Offset: 0x00379D98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI32(int InI32)
		{
			UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025612 RID: 153106 RVA: 0x0037BBE0 File Offset: 0x00379DE0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Set(TSet<short> InI16Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Set != null)
			{
				InI16Set.CopyTo(&ptr->InI16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025613 RID: 153107 RVA: 0x0037BC4C File Offset: 0x00379E4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Map(TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Map != null)
			{
				InI16Map.CopyTo(&ptr->InI16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025614 RID: 153108 RVA: 0x0037BCB8 File Offset: 0x00379EB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16Array(TArray<short> InI16Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Array != null)
			{
				InI16Array.CopyTo(&ptr->InI16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025615 RID: 153109 RVA: 0x0037BD24 File Offset: 0x00379F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetI16(short InI16)
		{
			UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025616 RID: 153110 RVA: 0x0037BD6C File Offset: 0x00379F6C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Set(TSet<double> InF64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Set != null)
			{
				InF64Set.CopyTo(&ptr->InF64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025617 RID: 153111 RVA: 0x0037BDD8 File Offset: 0x00379FD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Map(TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Map != null)
			{
				InF64Map.CopyTo(&ptr->InF64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025618 RID: 153112 RVA: 0x0037BE44 File Offset: 0x0037A044
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64Array(TArray<double> InF64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Array != null)
			{
				InF64Array.CopyTo(&ptr->InF64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025619 RID: 153113 RVA: 0x0037BEB0 File Offset: 0x0037A0B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF64(double InF64)
		{
			UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602561A RID: 153114 RVA: 0x0037BEF8 File Offset: 0x0037A0F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Set(TSet<float> InF32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Set != null)
			{
				InF32Set.CopyTo(&ptr->InF32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602561B RID: 153115 RVA: 0x0037BF64 File Offset: 0x0037A164
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Map(TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Map != null)
			{
				InF32Map.CopyTo(&ptr->InF32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602561C RID: 153116 RVA: 0x0037BFD0 File Offset: 0x0037A1D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32Array(TArray<float> InF32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Array != null)
			{
				InF32Array.CopyTo(&ptr->InF32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602561D RID: 153117 RVA: 0x0037C03C File Offset: 0x0037A23C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetF32(float InF32)
		{
			UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602561E RID: 153118 RVA: 0x0037C084 File Offset: 0x0037A284
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolSet(TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolSet != null)
			{
				InBoolSet.CopyTo(&ptr->InBoolSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602561F RID: 153119 RVA: 0x0037C0F0 File Offset: 0x0037A2F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolMap(TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolMap != null)
			{
				InBoolMap.CopyTo(&ptr->InBoolMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025620 RID: 153120 RVA: 0x0037C15C File Offset: 0x0037A35C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBoolArray(TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolArray != null)
			{
				InBoolArray.CopyTo(&ptr->InBoolArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025621 RID: 153121 RVA: 0x0037C1C8 File Offset: 0x0037A3C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetBool(bool InBool)
		{
			UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025622 RID: 153122 RVA: 0x0037C210 File Offset: 0x0037A410
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Set(ref TSet<byte> OutU8Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = OutU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> tset2 = OutU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025623 RID: 153123 RVA: 0x0037C28C File Offset: 0x0037A48C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Map(ref TMap<byte, int> OutU8Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = OutU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> tmap2 = OutU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025624 RID: 153124 RVA: 0x0037C308 File Offset: 0x0037A508
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8Array(ref TArray<byte> OutU8Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = OutU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = OutU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025625 RID: 153125 RVA: 0x0037C384 File Offset: 0x0037A584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU8(ref byte OutU8)
		{
			UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU8 = OutU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 0);
			OutU8 = ptr->OutU8;
		}

		// Token: 0x06025626 RID: 153126 RVA: 0x0037C3D4 File Offset: 0x0037A5D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Set(ref TSet<ulong> OutU64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = OutU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> tset2 = OutU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025627 RID: 153127 RVA: 0x0037C450 File Offset: 0x0037A650
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Map(ref TMap<ulong, int> OutU64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = OutU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> tmap2 = OutU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025628 RID: 153128 RVA: 0x0037C4CC File Offset: 0x0037A6CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64Array(ref TArray<ulong> OutU64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = OutU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> tarray2 = OutU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025629 RID: 153129 RVA: 0x0037C548 File Offset: 0x0037A748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU64(ref ulong OutU64)
		{
			UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU64 = OutU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 0);
			OutU64 = ptr->OutU64;
		}

		// Token: 0x0602562A RID: 153130 RVA: 0x0037C598 File Offset: 0x0037A798
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Set(ref TSet<uint> OutU32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = OutU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> tset2 = OutU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602562B RID: 153131 RVA: 0x0037C614 File Offset: 0x0037A814
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Map(ref TMap<uint, int> OutU32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = OutU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> tmap2 = OutU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602562C RID: 153132 RVA: 0x0037C690 File Offset: 0x0037A890
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32Array(ref TArray<uint> OutU32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = OutU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> tarray2 = OutU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602562D RID: 153133 RVA: 0x0037C70C File Offset: 0x0037A90C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU32(ref uint OutU32)
		{
			UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU32 = OutU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 0);
			OutU32 = ptr->OutU32;
		}

		// Token: 0x0602562E RID: 153134 RVA: 0x0037C75C File Offset: 0x0037A95C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Set(ref TSet<ushort> OutU16Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = OutU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> tset2 = OutU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602562F RID: 153135 RVA: 0x0037C7D8 File Offset: 0x0037A9D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Map(ref TMap<ushort, int> OutU16Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = OutU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> tmap2 = OutU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025630 RID: 153136 RVA: 0x0037C854 File Offset: 0x0037AA54
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16Array(ref TArray<ushort> OutU16Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = OutU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> tarray2 = OutU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025631 RID: 153137 RVA: 0x0037C8D0 File Offset: 0x0037AAD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutU16(ref ushort OutU16)
		{
			UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU16 = OutU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 0);
			OutU16 = ptr->OutU16;
		}

		// Token: 0x06025632 RID: 153138 RVA: 0x0037C920 File Offset: 0x0037AB20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Set(ref TSet<sbyte> OutI8Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = OutI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> tset2 = OutI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025633 RID: 153139 RVA: 0x0037C99C File Offset: 0x0037AB9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Map(ref TMap<sbyte, int> OutI8Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = OutI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> tmap2 = OutI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025634 RID: 153140 RVA: 0x0037CA18 File Offset: 0x0037AC18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8Array(ref TArray<sbyte> OutI8Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = OutI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> tarray2 = OutI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025635 RID: 153141 RVA: 0x0037CA94 File Offset: 0x0037AC94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI8(ref sbyte OutI8)
		{
			UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI8 = OutI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 0);
			OutI8 = ptr->OutI8;
		}

		// Token: 0x06025636 RID: 153142 RVA: 0x0037CAE4 File Offset: 0x0037ACE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Set(ref TSet<long> OutI64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = OutI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> tset2 = OutI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025637 RID: 153143 RVA: 0x0037CB60 File Offset: 0x0037AD60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Map(ref TMap<long, int> OutI64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = OutI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> tmap2 = OutI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025638 RID: 153144 RVA: 0x0037CBDC File Offset: 0x0037ADDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64Array(ref TArray<long> OutI64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = OutI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = OutI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025639 RID: 153145 RVA: 0x0037CC58 File Offset: 0x0037AE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI64(ref long OutI64)
		{
			UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI64 = OutI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 0);
			OutI64 = ptr->OutI64;
		}

		// Token: 0x0602563A RID: 153146 RVA: 0x0037CCA8 File Offset: 0x0037AEA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Set(ref TSet<int> OutI32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = OutI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = OutI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602563B RID: 153147 RVA: 0x0037CD24 File Offset: 0x0037AF24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Map(ref TMap<int, int> OutI32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = OutI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = OutI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602563C RID: 153148 RVA: 0x0037CDA0 File Offset: 0x0037AFA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32Array(ref TArray<int> OutI32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = OutI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602563D RID: 153149 RVA: 0x0037CE1C File Offset: 0x0037B01C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI32(ref int OutI32)
		{
			UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI32 = OutI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 0);
			OutI32 = ptr->OutI32;
		}

		// Token: 0x0602563E RID: 153150 RVA: 0x0037CE6C File Offset: 0x0037B06C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Set(ref TSet<short> OutI16Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = OutI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> tset2 = OutI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602563F RID: 153151 RVA: 0x0037CEE8 File Offset: 0x0037B0E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Map(ref TMap<short, int> OutI16Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = OutI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> tmap2 = OutI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025640 RID: 153152 RVA: 0x0037CF64 File Offset: 0x0037B164
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16Array(ref TArray<short> OutI16Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = OutI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> tarray2 = OutI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025641 RID: 153153 RVA: 0x0037CFE0 File Offset: 0x0037B1E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutI16(ref short OutI16)
		{
			UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI16 = OutI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 0);
			OutI16 = ptr->OutI16;
		}

		// Token: 0x06025642 RID: 153154 RVA: 0x0037D030 File Offset: 0x0037B230
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Set(ref TSet<double> OutF64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = OutF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> tset2 = OutF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025643 RID: 153155 RVA: 0x0037D0AC File Offset: 0x0037B2AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Map(ref TMap<double, int> OutF64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = OutF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> tmap2 = OutF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025644 RID: 153156 RVA: 0x0037D128 File Offset: 0x0037B328
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64Array(ref TArray<double> OutF64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = OutF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> tarray2 = OutF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025645 RID: 153157 RVA: 0x0037D1A4 File Offset: 0x0037B3A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF64(ref double OutF64)
		{
			UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF64 = OutF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 0);
			OutF64 = ptr->OutF64;
		}

		// Token: 0x06025646 RID: 153158 RVA: 0x0037D1F4 File Offset: 0x0037B3F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Set(ref TSet<float> OutF32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = OutF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> tset2 = OutF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025647 RID: 153159 RVA: 0x0037D270 File Offset: 0x0037B470
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Map(ref TMap<float, int> OutF32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = OutF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> tmap2 = OutF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025648 RID: 153160 RVA: 0x0037D2EC File Offset: 0x0037B4EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32Array(ref TArray<float> OutF32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = OutF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray2 = OutF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025649 RID: 153161 RVA: 0x0037D368 File Offset: 0x0037B568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutF32(ref float OutF32)
		{
			UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF32 = OutF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 0);
			OutF32 = ptr->OutF32;
		}

		// Token: 0x0602564A RID: 153162 RVA: 0x0037D3B8 File Offset: 0x0037B5B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolSet(ref TSet<bool> OutBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = OutBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> tset2 = OutBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602564B RID: 153163 RVA: 0x0037D434 File Offset: 0x0037B634
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolMap(ref TMap<bool, int> OutBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = OutBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> tmap2 = OutBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602564C RID: 153164 RVA: 0x0037D4B0 File Offset: 0x0037B6B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBoolArray(ref TArray<bool> OutBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = OutBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> tarray2 = OutBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602564D RID: 153165 RVA: 0x0037D52C File Offset: 0x0037B72C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutBool(ref bool OutBool)
		{
			UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutBool = OutBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 0);
			OutBool = ptr->OutBool;
		}

		// Token: 0x0602564E RID: 153166 RVA: 0x0037D57C File Offset: 0x0037B77C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Set(in TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = InU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> tset2 = InU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602564F RID: 153167 RVA: 0x0037D5F8 File Offset: 0x0037B7F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Map(in TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = InU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> tmap2 = InU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025650 RID: 153168 RVA: 0x0037D674 File Offset: 0x0037B874
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8Array(in TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = InU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = InU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025651 RID: 153169 RVA: 0x0037D6F0 File Offset: 0x0037B8F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU8(in byte InU8)
		{
			UTestClass_UFunction_Direct_Base.__InU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025652 RID: 153170 RVA: 0x0037D738 File Offset: 0x0037B938
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Set(in TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = InU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> tset2 = InU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025653 RID: 153171 RVA: 0x0037D7B4 File Offset: 0x0037B9B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Map(in TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = InU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> tmap2 = InU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025654 RID: 153172 RVA: 0x0037D830 File Offset: 0x0037BA30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64Array(in TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = InU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> tarray2 = InU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025655 RID: 153173 RVA: 0x0037D8AC File Offset: 0x0037BAAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU64(in ulong InU64)
		{
			UTestClass_UFunction_Direct_Base.__InU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025656 RID: 153174 RVA: 0x0037D8F4 File Offset: 0x0037BAF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Set(in TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = InU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> tset2 = InU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025657 RID: 153175 RVA: 0x0037D970 File Offset: 0x0037BB70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Map(in TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = InU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> tmap2 = InU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025658 RID: 153176 RVA: 0x0037D9EC File Offset: 0x0037BBEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32Array(in TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = InU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> tarray2 = InU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025659 RID: 153177 RVA: 0x0037DA68 File Offset: 0x0037BC68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU32(in uint InU32)
		{
			UTestClass_UFunction_Direct_Base.__InU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602565A RID: 153178 RVA: 0x0037DAB0 File Offset: 0x0037BCB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Set(in TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = InU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> tset2 = InU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602565B RID: 153179 RVA: 0x0037DB2C File Offset: 0x0037BD2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Map(in TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = InU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> tmap2 = InU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602565C RID: 153180 RVA: 0x0037DBA8 File Offset: 0x0037BDA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16Array(in TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = InU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> tarray2 = InU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602565D RID: 153181 RVA: 0x0037DC24 File Offset: 0x0037BE24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InU16(in ushort InU16)
		{
			UTestClass_UFunction_Direct_Base.__InU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602565E RID: 153182 RVA: 0x0037DC6C File Offset: 0x0037BE6C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Set(in TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = InI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> tset2 = InI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602565F RID: 153183 RVA: 0x0037DCE8 File Offset: 0x0037BEE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Map(in TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = InI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> tmap2 = InI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025660 RID: 153184 RVA: 0x0037DD64 File Offset: 0x0037BF64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8Array(in TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = InI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> tarray2 = InI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025661 RID: 153185 RVA: 0x0037DDE0 File Offset: 0x0037BFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI8(in sbyte InI8)
		{
			UTestClass_UFunction_Direct_Base.__InI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025662 RID: 153186 RVA: 0x0037DE28 File Offset: 0x0037C028
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Set(in TSet<long> InI64Set)
		{
			UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = InI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> tset2 = InI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025663 RID: 153187 RVA: 0x0037DEA4 File Offset: 0x0037C0A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Map(in TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = InI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> tmap2 = InI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025664 RID: 153188 RVA: 0x0037DF20 File Offset: 0x0037C120
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64Array(in TArray<long> InI64Array)
		{
			UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = InI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = InI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025665 RID: 153189 RVA: 0x0037DF9C File Offset: 0x0037C19C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI64(in long InI64)
		{
			UTestClass_UFunction_Direct_Base.__InI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025666 RID: 153190 RVA: 0x0037DFE4 File Offset: 0x0037C1E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Set(in TSet<int> InI32Set)
		{
			UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = InI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> tset2 = InI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025667 RID: 153191 RVA: 0x0037E060 File Offset: 0x0037C260
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Map(in TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = InI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = InI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025668 RID: 153192 RVA: 0x0037E0DC File Offset: 0x0037C2DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32Array(in TArray<int> InI32Array)
		{
			UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = InI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = InI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025669 RID: 153193 RVA: 0x0037E158 File Offset: 0x0037C358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI32(in int InI32)
		{
			UTestClass_UFunction_Direct_Base.__InI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602566A RID: 153194 RVA: 0x0037E1A0 File Offset: 0x0037C3A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Set(in TSet<short> InI16Set)
		{
			UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = InI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> tset2 = InI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602566B RID: 153195 RVA: 0x0037E21C File Offset: 0x0037C41C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Map(in TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = InI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> tmap2 = InI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602566C RID: 153196 RVA: 0x0037E298 File Offset: 0x0037C498
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16Array(in TArray<short> InI16Array)
		{
			UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = InI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> tarray2 = InI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602566D RID: 153197 RVA: 0x0037E314 File Offset: 0x0037C514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InI16(in short InI16)
		{
			UTestClass_UFunction_Direct_Base.__InI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602566E RID: 153198 RVA: 0x0037E35C File Offset: 0x0037C55C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Set(in TSet<double> InF64Set)
		{
			UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = InF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> tset2 = InF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602566F RID: 153199 RVA: 0x0037E3D8 File Offset: 0x0037C5D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Map(in TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = InF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> tmap2 = InF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025670 RID: 153200 RVA: 0x0037E454 File Offset: 0x0037C654
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64Array(in TArray<double> InF64Array)
		{
			UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = InF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> tarray2 = InF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025671 RID: 153201 RVA: 0x0037E4D0 File Offset: 0x0037C6D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF64(in double InF64)
		{
			UTestClass_UFunction_Direct_Base.__InF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025672 RID: 153202 RVA: 0x0037E518 File Offset: 0x0037C718
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Set(in TSet<float> InF32Set)
		{
			UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = InF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> tset2 = InF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025673 RID: 153203 RVA: 0x0037E594 File Offset: 0x0037C794
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Map(in TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = InF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> tmap2 = InF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025674 RID: 153204 RVA: 0x0037E610 File Offset: 0x0037C810
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32Array(in TArray<float> InF32Array)
		{
			UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = InF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray2 = InF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025675 RID: 153205 RVA: 0x0037E68C File Offset: 0x0037C88C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InF32(in float InF32)
		{
			UTestClass_UFunction_Direct_Base.__InF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025676 RID: 153206 RVA: 0x0037E6D4 File Offset: 0x0037C8D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolSet(in TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = InBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> tset2 = InBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025677 RID: 153207 RVA: 0x0037E750 File Offset: 0x0037C950
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolMap(in TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = InBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> tmap2 = InBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025678 RID: 153208 RVA: 0x0037E7CC File Offset: 0x0037C9CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBoolArray(in TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = InBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> tarray2 = InBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025679 RID: 153209 RVA: 0x0037E848 File Offset: 0x0037CA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InBool(in bool InBool)
		{
			UTestClass_UFunction_Direct_Base.__InBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBool_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602567A RID: 153210 RVA: 0x0037E890 File Offset: 0x0037CA90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<byte> GetU8Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<byte> result = new TSet<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602567B RID: 153211 RVA: 0x0037E8F0 File Offset: 0x0037CAF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<byte, int> GetU8Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<byte, int> result = new TMap<byte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602567C RID: 153212 RVA: 0x0037E950 File Offset: 0x0037CB50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<byte> GetU8Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> result = new TArray<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602567D RID: 153213 RVA: 0x0037E9B0 File Offset: 0x0037CBB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe byte GetU8()
		{
			UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602567E RID: 153214 RVA: 0x0037E9F8 File Offset: 0x0037CBF8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<ulong> GetU64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ulong> result = new TSet<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602567F RID: 153215 RVA: 0x0037EA58 File Offset: 0x0037CC58
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<ulong, int> GetU64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ulong, int> result = new TMap<ulong, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025680 RID: 153216 RVA: 0x0037EAB8 File Offset: 0x0037CCB8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ulong> GetU64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ulong> result = new TArray<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025681 RID: 153217 RVA: 0x0037EB18 File Offset: 0x0037CD18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ulong GetU64()
		{
			UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025682 RID: 153218 RVA: 0x0037EB60 File Offset: 0x0037CD60
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<uint> GetU32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<uint> result = new TSet<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025683 RID: 153219 RVA: 0x0037EBC0 File Offset: 0x0037CDC0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<uint, int> GetU32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<uint, int> result = new TMap<uint, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025684 RID: 153220 RVA: 0x0037EC20 File Offset: 0x0037CE20
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<uint> GetU32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<uint> result = new TArray<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025685 RID: 153221 RVA: 0x0037EC80 File Offset: 0x0037CE80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe uint GetU32()
		{
			UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025686 RID: 153222 RVA: 0x0037ECC8 File Offset: 0x0037CEC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<ushort> GetU16Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<ushort> result = new TSet<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025687 RID: 153223 RVA: 0x0037ED28 File Offset: 0x0037CF28
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<ushort, int> GetU16Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<ushort, int> result = new TMap<ushort, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025688 RID: 153224 RVA: 0x0037ED88 File Offset: 0x0037CF88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ushort> GetU16Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ushort> result = new TArray<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025689 RID: 153225 RVA: 0x0037EDE8 File Offset: 0x0037CFE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ushort GetU16()
		{
			UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602568A RID: 153226 RVA: 0x0037EE30 File Offset: 0x0037D030
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<sbyte> GetI8Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<sbyte> result = new TSet<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602568B RID: 153227 RVA: 0x0037EE90 File Offset: 0x0037D090
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<sbyte, int> GetI8Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<sbyte, int> result = new TMap<sbyte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602568C RID: 153228 RVA: 0x0037EEF0 File Offset: 0x0037D0F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<sbyte> GetI8Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<sbyte> result = new TArray<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602568D RID: 153229 RVA: 0x0037EF50 File Offset: 0x0037D150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe sbyte GetI8()
		{
			UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602568E RID: 153230 RVA: 0x0037EF98 File Offset: 0x0037D198
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<long> GetI64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<long> result = new TSet<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602568F RID: 153231 RVA: 0x0037EFF8 File Offset: 0x0037D1F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<long, int> GetI64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<long, int> result = new TMap<long, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025690 RID: 153232 RVA: 0x0037F058 File Offset: 0x0037D258
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<long> GetI64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> result = new TArray<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025691 RID: 153233 RVA: 0x0037F0B8 File Offset: 0x0037D2B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe long GetI64()
		{
			UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025692 RID: 153234 RVA: 0x0037F100 File Offset: 0x0037D300
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<int> GetI32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<int> result = new TSet<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025693 RID: 153235 RVA: 0x0037F160 File Offset: 0x0037D360
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<int, int> GetI32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> result = new TMap<int, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025694 RID: 153236 RVA: 0x0037F1C0 File Offset: 0x0037D3C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<int> GetI32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> result = new TArray<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025695 RID: 153237 RVA: 0x0037F220 File Offset: 0x0037D420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetI32()
		{
			UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025696 RID: 153238 RVA: 0x0037F268 File Offset: 0x0037D468
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<short> GetI16Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<short> result = new TSet<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025697 RID: 153239 RVA: 0x0037F2C8 File Offset: 0x0037D4C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<short, int> GetI16Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<short, int> result = new TMap<short, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025698 RID: 153240 RVA: 0x0037F328 File Offset: 0x0037D528
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<short> GetI16Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<short> result = new TArray<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025699 RID: 153241 RVA: 0x0037F388 File Offset: 0x0037D588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe short GetI16()
		{
			UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602569A RID: 153242 RVA: 0x0037F3D0 File Offset: 0x0037D5D0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<double> GetF64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<double> result = new TSet<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602569B RID: 153243 RVA: 0x0037F430 File Offset: 0x0037D630
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<double, int> GetF64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<double, int> result = new TMap<double, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602569C RID: 153244 RVA: 0x0037F490 File Offset: 0x0037D690
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<double> GetF64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<double> result = new TArray<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602569D RID: 153245 RVA: 0x0037F4F0 File Offset: 0x0037D6F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe double GetF64()
		{
			UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602569E RID: 153246 RVA: 0x0037F538 File Offset: 0x0037D738
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<float> GetF32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 0);
			TSet<float> result = new TSet<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602569F RID: 153247 RVA: 0x0037F598 File Offset: 0x0037D798
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<float, int> GetF32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 0);
			TMap<float, int> result = new TMap<float, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256A0 RID: 153248 RVA: 0x0037F5F8 File Offset: 0x0037D7F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<float> GetF32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> result = new TArray<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256A1 RID: 153249 RVA: 0x0037F658 File Offset: 0x0037D858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetF32()
		{
			UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060256A2 RID: 153250 RVA: 0x0037F6A0 File Offset: 0x0037D8A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<bool> GetBoolSet()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<bool> result = new TSet<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256A3 RID: 153251 RVA: 0x0037F700 File Offset: 0x0037D900
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<bool, int> GetBoolMap()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<bool, int> result = new TMap<bool, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256A4 RID: 153252 RVA: 0x0037F760 File Offset: 0x0037D960
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<bool> GetBoolArray()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<bool> result = new TArray<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256A5 RID: 153253 RVA: 0x0037F7C0 File Offset: 0x0037D9C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetBool()
		{
			UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060256A6 RID: 153254 RVA: 0x0037F806 File Offset: 0x0037DA06
		static UTestClass_UFunction_Direct_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Base");
		}

		// Token: 0x060256A7 RID: 153255 RVA: 0x0037F814 File Offset: 0x0037DA14
		protected UTestClass_UFunction_Direct_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040142F1 RID: 82673
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Base";

		// Token: 0x040142F2 RID: 82674
		private static IntPtr _ClassPtr;

		// Token: 0x040142F3 RID: 82675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040142F4 RID: 82676
		internal static int __PropertyOffset_Bool;

		// Token: 0x040142F5 RID: 82677
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x040142F6 RID: 82678
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x040142F7 RID: 82679
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x040142F8 RID: 82680
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x040142F9 RID: 82681
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x040142FA RID: 82682
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x040142FB RID: 82683
		internal static int __PropertyOffset_I8;

		// Token: 0x040142FC RID: 82684
		internal static int __PropertyOffset_I8Array;

		// Token: 0x040142FD RID: 82685
		[Nullable(2)]
		private TArray<sbyte> _I8Array;

		// Token: 0x040142FE RID: 82686
		internal static int __PropertyOffset_I8Set;

		// Token: 0x040142FF RID: 82687
		[Nullable(2)]
		private TSet<sbyte> _I8Set;

		// Token: 0x04014300 RID: 82688
		internal static int __PropertyOffset_I8Map;

		// Token: 0x04014301 RID: 82689
		[Nullable(2)]
		private TMap<sbyte, int> _I8Map;

		// Token: 0x04014302 RID: 82690
		internal static int __PropertyOffset_U8;

		// Token: 0x04014303 RID: 82691
		internal static int __PropertyOffset_U8Array;

		// Token: 0x04014304 RID: 82692
		[Nullable(2)]
		private TArray<byte> _U8Array;

		// Token: 0x04014305 RID: 82693
		internal static int __PropertyOffset_U8Set;

		// Token: 0x04014306 RID: 82694
		[Nullable(2)]
		private TSet<byte> _U8Set;

		// Token: 0x04014307 RID: 82695
		internal static int __PropertyOffset_U8Map;

		// Token: 0x04014308 RID: 82696
		[Nullable(2)]
		private TMap<byte, int> _U8Map;

		// Token: 0x04014309 RID: 82697
		internal static int __PropertyOffset_I16;

		// Token: 0x0401430A RID: 82698
		internal static int __PropertyOffset_I16Array;

		// Token: 0x0401430B RID: 82699
		[Nullable(2)]
		private TArray<short> _I16Array;

		// Token: 0x0401430C RID: 82700
		internal static int __PropertyOffset_I16Set;

		// Token: 0x0401430D RID: 82701
		[Nullable(2)]
		private TSet<short> _I16Set;

		// Token: 0x0401430E RID: 82702
		internal static int __PropertyOffset_I16Map;

		// Token: 0x0401430F RID: 82703
		[Nullable(2)]
		private TMap<short, int> _I16Map;

		// Token: 0x04014310 RID: 82704
		internal static int __PropertyOffset_U16;

		// Token: 0x04014311 RID: 82705
		internal static int __PropertyOffset_U16Array;

		// Token: 0x04014312 RID: 82706
		[Nullable(2)]
		private TArray<ushort> _U16Array;

		// Token: 0x04014313 RID: 82707
		internal static int __PropertyOffset_U16Set;

		// Token: 0x04014314 RID: 82708
		[Nullable(2)]
		private TSet<ushort> _U16Set;

		// Token: 0x04014315 RID: 82709
		internal static int __PropertyOffset_U16Map;

		// Token: 0x04014316 RID: 82710
		[Nullable(2)]
		private TMap<ushort, int> _U16Map;

		// Token: 0x04014317 RID: 82711
		internal static int __PropertyOffset_I32;

		// Token: 0x04014318 RID: 82712
		internal static int __PropertyOffset_I32Array;

		// Token: 0x04014319 RID: 82713
		[Nullable(2)]
		private TArray<int> _I32Array;

		// Token: 0x0401431A RID: 82714
		internal static int __PropertyOffset_I32Set;

		// Token: 0x0401431B RID: 82715
		[Nullable(2)]
		private TSet<int> _I32Set;

		// Token: 0x0401431C RID: 82716
		internal static int __PropertyOffset_I32Map;

		// Token: 0x0401431D RID: 82717
		[Nullable(2)]
		private TMap<int, int> _I32Map;

		// Token: 0x0401431E RID: 82718
		internal static int __PropertyOffset_U32;

		// Token: 0x0401431F RID: 82719
		internal static int __PropertyOffset_U32Array;

		// Token: 0x04014320 RID: 82720
		[Nullable(2)]
		private TArray<uint> _U32Array;

		// Token: 0x04014321 RID: 82721
		internal static int __PropertyOffset_U32Set;

		// Token: 0x04014322 RID: 82722
		[Nullable(2)]
		private TSet<uint> _U32Set;

		// Token: 0x04014323 RID: 82723
		internal static int __PropertyOffset_U32Map;

		// Token: 0x04014324 RID: 82724
		[Nullable(2)]
		private TMap<uint, int> _U32Map;

		// Token: 0x04014325 RID: 82725
		internal static int __PropertyOffset_I64;

		// Token: 0x04014326 RID: 82726
		internal static int __PropertyOffset_I64Array;

		// Token: 0x04014327 RID: 82727
		[Nullable(2)]
		private TArray<long> _I64Array;

		// Token: 0x04014328 RID: 82728
		internal static int __PropertyOffset_I64Set;

		// Token: 0x04014329 RID: 82729
		[Nullable(2)]
		private TSet<long> _I64Set;

		// Token: 0x0401432A RID: 82730
		internal static int __PropertyOffset_I64Map;

		// Token: 0x0401432B RID: 82731
		[Nullable(2)]
		private TMap<long, int> _I64Map;

		// Token: 0x0401432C RID: 82732
		internal static int __PropertyOffset_U64;

		// Token: 0x0401432D RID: 82733
		internal static int __PropertyOffset_U64Array;

		// Token: 0x0401432E RID: 82734
		[Nullable(2)]
		private TArray<ulong> _U64Array;

		// Token: 0x0401432F RID: 82735
		internal static int __PropertyOffset_U64Set;

		// Token: 0x04014330 RID: 82736
		[Nullable(2)]
		private TSet<ulong> _U64Set;

		// Token: 0x04014331 RID: 82737
		internal static int __PropertyOffset_U64Map;

		// Token: 0x04014332 RID: 82738
		[Nullable(2)]
		private TMap<ulong, int> _U64Map;

		// Token: 0x04014333 RID: 82739
		internal static int __PropertyOffset_F32;

		// Token: 0x04014334 RID: 82740
		internal static int __PropertyOffset_F32Array;

		// Token: 0x04014335 RID: 82741
		[Nullable(2)]
		private TArray<float> _F32Array;

		// Token: 0x04014336 RID: 82742
		internal static int __PropertyOffset_F32Set;

		// Token: 0x04014337 RID: 82743
		[Nullable(2)]
		private TSet<float> _F32Set;

		// Token: 0x04014338 RID: 82744
		internal static int __PropertyOffset_F32Map;

		// Token: 0x04014339 RID: 82745
		[Nullable(2)]
		private TMap<float, int> _F32Map;

		// Token: 0x0401433A RID: 82746
		internal static int __PropertyOffset_F64;

		// Token: 0x0401433B RID: 82747
		internal static int __PropertyOffset_F64Array;

		// Token: 0x0401433C RID: 82748
		[Nullable(2)]
		private TArray<double> _F64Array;

		// Token: 0x0401433D RID: 82749
		internal static int __PropertyOffset_F64Set;

		// Token: 0x0401433E RID: 82750
		[Nullable(2)]
		private TSet<double> _F64Set;

		// Token: 0x0401433F RID: 82751
		internal static int __PropertyOffset_F64Map;

		// Token: 0x04014340 RID: 82752
		[Nullable(2)]
		private TMap<double, int> _F64Map;

		// Token: 0x04014341 RID: 82753
		private static IntPtr __SetU8Set_NativeFunctionPtr;

		// Token: 0x04014342 RID: 82754
		private static IntPtr __SetU8Map_NativeFunctionPtr;

		// Token: 0x04014343 RID: 82755
		private static IntPtr __SetU8Array_NativeFunctionPtr;

		// Token: 0x04014344 RID: 82756
		private static IntPtr __SetU8_NativeFunctionPtr;

		// Token: 0x04014345 RID: 82757
		private static IntPtr __SetU64Set_NativeFunctionPtr;

		// Token: 0x04014346 RID: 82758
		private static IntPtr __SetU64Map_NativeFunctionPtr;

		// Token: 0x04014347 RID: 82759
		private static IntPtr __SetU64Array_NativeFunctionPtr;

		// Token: 0x04014348 RID: 82760
		private static IntPtr __SetU64_NativeFunctionPtr;

		// Token: 0x04014349 RID: 82761
		private static IntPtr __SetU32Set_NativeFunctionPtr;

		// Token: 0x0401434A RID: 82762
		private static IntPtr __SetU32Map_NativeFunctionPtr;

		// Token: 0x0401434B RID: 82763
		private static IntPtr __SetU32Array_NativeFunctionPtr;

		// Token: 0x0401434C RID: 82764
		private static IntPtr __SetU32_NativeFunctionPtr;

		// Token: 0x0401434D RID: 82765
		private static IntPtr __SetU16Set_NativeFunctionPtr;

		// Token: 0x0401434E RID: 82766
		private static IntPtr __SetU16Map_NativeFunctionPtr;

		// Token: 0x0401434F RID: 82767
		private static IntPtr __SetU16Array_NativeFunctionPtr;

		// Token: 0x04014350 RID: 82768
		private static IntPtr __SetU16_NativeFunctionPtr;

		// Token: 0x04014351 RID: 82769
		private static IntPtr __SetI8Set_NativeFunctionPtr;

		// Token: 0x04014352 RID: 82770
		private static IntPtr __SetI8Map_NativeFunctionPtr;

		// Token: 0x04014353 RID: 82771
		private static IntPtr __SetI8Array_NativeFunctionPtr;

		// Token: 0x04014354 RID: 82772
		private static IntPtr __SetI8_NativeFunctionPtr;

		// Token: 0x04014355 RID: 82773
		private static IntPtr __SetI64Set_NativeFunctionPtr;

		// Token: 0x04014356 RID: 82774
		private static IntPtr __SetI64Map_NativeFunctionPtr;

		// Token: 0x04014357 RID: 82775
		private static IntPtr __SetI64Array_NativeFunctionPtr;

		// Token: 0x04014358 RID: 82776
		private static IntPtr __SetI64_NativeFunctionPtr;

		// Token: 0x04014359 RID: 82777
		private static IntPtr __SetI32Set_NativeFunctionPtr;

		// Token: 0x0401435A RID: 82778
		private static IntPtr __SetI32Map_NativeFunctionPtr;

		// Token: 0x0401435B RID: 82779
		private static IntPtr __SetI32Array_NativeFunctionPtr;

		// Token: 0x0401435C RID: 82780
		private static IntPtr __SetI32_NativeFunctionPtr;

		// Token: 0x0401435D RID: 82781
		private static IntPtr __SetI16Set_NativeFunctionPtr;

		// Token: 0x0401435E RID: 82782
		private static IntPtr __SetI16Map_NativeFunctionPtr;

		// Token: 0x0401435F RID: 82783
		private static IntPtr __SetI16Array_NativeFunctionPtr;

		// Token: 0x04014360 RID: 82784
		private static IntPtr __SetI16_NativeFunctionPtr;

		// Token: 0x04014361 RID: 82785
		private static IntPtr __SetF64Set_NativeFunctionPtr;

		// Token: 0x04014362 RID: 82786
		private static IntPtr __SetF64Map_NativeFunctionPtr;

		// Token: 0x04014363 RID: 82787
		private static IntPtr __SetF64Array_NativeFunctionPtr;

		// Token: 0x04014364 RID: 82788
		private static IntPtr __SetF64_NativeFunctionPtr;

		// Token: 0x04014365 RID: 82789
		private static IntPtr __SetF32Set_NativeFunctionPtr;

		// Token: 0x04014366 RID: 82790
		private static IntPtr __SetF32Map_NativeFunctionPtr;

		// Token: 0x04014367 RID: 82791
		private static IntPtr __SetF32Array_NativeFunctionPtr;

		// Token: 0x04014368 RID: 82792
		private static IntPtr __SetF32_NativeFunctionPtr;

		// Token: 0x04014369 RID: 82793
		private static IntPtr __SetBoolSet_NativeFunctionPtr;

		// Token: 0x0401436A RID: 82794
		private static IntPtr __SetBoolMap_NativeFunctionPtr;

		// Token: 0x0401436B RID: 82795
		private static IntPtr __SetBoolArray_NativeFunctionPtr;

		// Token: 0x0401436C RID: 82796
		private static IntPtr __SetBool_NativeFunctionPtr;

		// Token: 0x0401436D RID: 82797
		private static IntPtr __OutU8Set_NativeFunctionPtr;

		// Token: 0x0401436E RID: 82798
		private static IntPtr __OutU8Map_NativeFunctionPtr;

		// Token: 0x0401436F RID: 82799
		private static IntPtr __OutU8Array_NativeFunctionPtr;

		// Token: 0x04014370 RID: 82800
		private static IntPtr __OutU8_NativeFunctionPtr;

		// Token: 0x04014371 RID: 82801
		private static IntPtr __OutU64Set_NativeFunctionPtr;

		// Token: 0x04014372 RID: 82802
		private static IntPtr __OutU64Map_NativeFunctionPtr;

		// Token: 0x04014373 RID: 82803
		private static IntPtr __OutU64Array_NativeFunctionPtr;

		// Token: 0x04014374 RID: 82804
		private static IntPtr __OutU64_NativeFunctionPtr;

		// Token: 0x04014375 RID: 82805
		private static IntPtr __OutU32Set_NativeFunctionPtr;

		// Token: 0x04014376 RID: 82806
		private static IntPtr __OutU32Map_NativeFunctionPtr;

		// Token: 0x04014377 RID: 82807
		private static IntPtr __OutU32Array_NativeFunctionPtr;

		// Token: 0x04014378 RID: 82808
		private static IntPtr __OutU32_NativeFunctionPtr;

		// Token: 0x04014379 RID: 82809
		private static IntPtr __OutU16Set_NativeFunctionPtr;

		// Token: 0x0401437A RID: 82810
		private static IntPtr __OutU16Map_NativeFunctionPtr;

		// Token: 0x0401437B RID: 82811
		private static IntPtr __OutU16Array_NativeFunctionPtr;

		// Token: 0x0401437C RID: 82812
		private static IntPtr __OutU16_NativeFunctionPtr;

		// Token: 0x0401437D RID: 82813
		private static IntPtr __OutI8Set_NativeFunctionPtr;

		// Token: 0x0401437E RID: 82814
		private static IntPtr __OutI8Map_NativeFunctionPtr;

		// Token: 0x0401437F RID: 82815
		private static IntPtr __OutI8Array_NativeFunctionPtr;

		// Token: 0x04014380 RID: 82816
		private static IntPtr __OutI8_NativeFunctionPtr;

		// Token: 0x04014381 RID: 82817
		private static IntPtr __OutI64Set_NativeFunctionPtr;

		// Token: 0x04014382 RID: 82818
		private static IntPtr __OutI64Map_NativeFunctionPtr;

		// Token: 0x04014383 RID: 82819
		private static IntPtr __OutI64Array_NativeFunctionPtr;

		// Token: 0x04014384 RID: 82820
		private static IntPtr __OutI64_NativeFunctionPtr;

		// Token: 0x04014385 RID: 82821
		private static IntPtr __OutI32Set_NativeFunctionPtr;

		// Token: 0x04014386 RID: 82822
		private static IntPtr __OutI32Map_NativeFunctionPtr;

		// Token: 0x04014387 RID: 82823
		private static IntPtr __OutI32Array_NativeFunctionPtr;

		// Token: 0x04014388 RID: 82824
		private static IntPtr __OutI32_NativeFunctionPtr;

		// Token: 0x04014389 RID: 82825
		private static IntPtr __OutI16Set_NativeFunctionPtr;

		// Token: 0x0401438A RID: 82826
		private static IntPtr __OutI16Map_NativeFunctionPtr;

		// Token: 0x0401438B RID: 82827
		private static IntPtr __OutI16Array_NativeFunctionPtr;

		// Token: 0x0401438C RID: 82828
		private static IntPtr __OutI16_NativeFunctionPtr;

		// Token: 0x0401438D RID: 82829
		private static IntPtr __OutF64Set_NativeFunctionPtr;

		// Token: 0x0401438E RID: 82830
		private static IntPtr __OutF64Map_NativeFunctionPtr;

		// Token: 0x0401438F RID: 82831
		private static IntPtr __OutF64Array_NativeFunctionPtr;

		// Token: 0x04014390 RID: 82832
		private static IntPtr __OutF64_NativeFunctionPtr;

		// Token: 0x04014391 RID: 82833
		private static IntPtr __OutF32Set_NativeFunctionPtr;

		// Token: 0x04014392 RID: 82834
		private static IntPtr __OutF32Map_NativeFunctionPtr;

		// Token: 0x04014393 RID: 82835
		private static IntPtr __OutF32Array_NativeFunctionPtr;

		// Token: 0x04014394 RID: 82836
		private static IntPtr __OutF32_NativeFunctionPtr;

		// Token: 0x04014395 RID: 82837
		private static IntPtr __OutBoolSet_NativeFunctionPtr;

		// Token: 0x04014396 RID: 82838
		private static IntPtr __OutBoolMap_NativeFunctionPtr;

		// Token: 0x04014397 RID: 82839
		private static IntPtr __OutBoolArray_NativeFunctionPtr;

		// Token: 0x04014398 RID: 82840
		private static IntPtr __OutBool_NativeFunctionPtr;

		// Token: 0x04014399 RID: 82841
		private static IntPtr __InU8Set_NativeFunctionPtr;

		// Token: 0x0401439A RID: 82842
		private static IntPtr __InU8Map_NativeFunctionPtr;

		// Token: 0x0401439B RID: 82843
		private static IntPtr __InU8Array_NativeFunctionPtr;

		// Token: 0x0401439C RID: 82844
		private static IntPtr __InU8_NativeFunctionPtr;

		// Token: 0x0401439D RID: 82845
		private static IntPtr __InU64Set_NativeFunctionPtr;

		// Token: 0x0401439E RID: 82846
		private static IntPtr __InU64Map_NativeFunctionPtr;

		// Token: 0x0401439F RID: 82847
		private static IntPtr __InU64Array_NativeFunctionPtr;

		// Token: 0x040143A0 RID: 82848
		private static IntPtr __InU64_NativeFunctionPtr;

		// Token: 0x040143A1 RID: 82849
		private static IntPtr __InU32Set_NativeFunctionPtr;

		// Token: 0x040143A2 RID: 82850
		private static IntPtr __InU32Map_NativeFunctionPtr;

		// Token: 0x040143A3 RID: 82851
		private static IntPtr __InU32Array_NativeFunctionPtr;

		// Token: 0x040143A4 RID: 82852
		private static IntPtr __InU32_NativeFunctionPtr;

		// Token: 0x040143A5 RID: 82853
		private static IntPtr __InU16Set_NativeFunctionPtr;

		// Token: 0x040143A6 RID: 82854
		private static IntPtr __InU16Map_NativeFunctionPtr;

		// Token: 0x040143A7 RID: 82855
		private static IntPtr __InU16Array_NativeFunctionPtr;

		// Token: 0x040143A8 RID: 82856
		private static IntPtr __InU16_NativeFunctionPtr;

		// Token: 0x040143A9 RID: 82857
		private static IntPtr __InI8Set_NativeFunctionPtr;

		// Token: 0x040143AA RID: 82858
		private static IntPtr __InI8Map_NativeFunctionPtr;

		// Token: 0x040143AB RID: 82859
		private static IntPtr __InI8Array_NativeFunctionPtr;

		// Token: 0x040143AC RID: 82860
		private static IntPtr __InI8_NativeFunctionPtr;

		// Token: 0x040143AD RID: 82861
		private static IntPtr __InI64Set_NativeFunctionPtr;

		// Token: 0x040143AE RID: 82862
		private static IntPtr __InI64Map_NativeFunctionPtr;

		// Token: 0x040143AF RID: 82863
		private static IntPtr __InI64Array_NativeFunctionPtr;

		// Token: 0x040143B0 RID: 82864
		private static IntPtr __InI64_NativeFunctionPtr;

		// Token: 0x040143B1 RID: 82865
		private static IntPtr __InI32Set_NativeFunctionPtr;

		// Token: 0x040143B2 RID: 82866
		private static IntPtr __InI32Map_NativeFunctionPtr;

		// Token: 0x040143B3 RID: 82867
		private static IntPtr __InI32Array_NativeFunctionPtr;

		// Token: 0x040143B4 RID: 82868
		private static IntPtr __InI32_NativeFunctionPtr;

		// Token: 0x040143B5 RID: 82869
		private static IntPtr __InI16Set_NativeFunctionPtr;

		// Token: 0x040143B6 RID: 82870
		private static IntPtr __InI16Map_NativeFunctionPtr;

		// Token: 0x040143B7 RID: 82871
		private static IntPtr __InI16Array_NativeFunctionPtr;

		// Token: 0x040143B8 RID: 82872
		private static IntPtr __InI16_NativeFunctionPtr;

		// Token: 0x040143B9 RID: 82873
		private static IntPtr __InF64Set_NativeFunctionPtr;

		// Token: 0x040143BA RID: 82874
		private static IntPtr __InF64Map_NativeFunctionPtr;

		// Token: 0x040143BB RID: 82875
		private static IntPtr __InF64Array_NativeFunctionPtr;

		// Token: 0x040143BC RID: 82876
		private static IntPtr __InF64_NativeFunctionPtr;

		// Token: 0x040143BD RID: 82877
		private static IntPtr __InF32Set_NativeFunctionPtr;

		// Token: 0x040143BE RID: 82878
		private static IntPtr __InF32Map_NativeFunctionPtr;

		// Token: 0x040143BF RID: 82879
		private static IntPtr __InF32Array_NativeFunctionPtr;

		// Token: 0x040143C0 RID: 82880
		private static IntPtr __InF32_NativeFunctionPtr;

		// Token: 0x040143C1 RID: 82881
		private static IntPtr __InBoolSet_NativeFunctionPtr;

		// Token: 0x040143C2 RID: 82882
		private static IntPtr __InBoolMap_NativeFunctionPtr;

		// Token: 0x040143C3 RID: 82883
		private static IntPtr __InBoolArray_NativeFunctionPtr;

		// Token: 0x040143C4 RID: 82884
		private static IntPtr __InBool_NativeFunctionPtr;

		// Token: 0x040143C5 RID: 82885
		private static IntPtr __GetU8Set_NativeFunctionPtr;

		// Token: 0x040143C6 RID: 82886
		private static IntPtr __GetU8Map_NativeFunctionPtr;

		// Token: 0x040143C7 RID: 82887
		private static IntPtr __GetU8Array_NativeFunctionPtr;

		// Token: 0x040143C8 RID: 82888
		private static IntPtr __GetU8_NativeFunctionPtr;

		// Token: 0x040143C9 RID: 82889
		private static IntPtr __GetU64Set_NativeFunctionPtr;

		// Token: 0x040143CA RID: 82890
		private static IntPtr __GetU64Map_NativeFunctionPtr;

		// Token: 0x040143CB RID: 82891
		private static IntPtr __GetU64Array_NativeFunctionPtr;

		// Token: 0x040143CC RID: 82892
		private static IntPtr __GetU64_NativeFunctionPtr;

		// Token: 0x040143CD RID: 82893
		private static IntPtr __GetU32Set_NativeFunctionPtr;

		// Token: 0x040143CE RID: 82894
		private static IntPtr __GetU32Map_NativeFunctionPtr;

		// Token: 0x040143CF RID: 82895
		private static IntPtr __GetU32Array_NativeFunctionPtr;

		// Token: 0x040143D0 RID: 82896
		private static IntPtr __GetU32_NativeFunctionPtr;

		// Token: 0x040143D1 RID: 82897
		private static IntPtr __GetU16Set_NativeFunctionPtr;

		// Token: 0x040143D2 RID: 82898
		private static IntPtr __GetU16Map_NativeFunctionPtr;

		// Token: 0x040143D3 RID: 82899
		private static IntPtr __GetU16Array_NativeFunctionPtr;

		// Token: 0x040143D4 RID: 82900
		private static IntPtr __GetU16_NativeFunctionPtr;

		// Token: 0x040143D5 RID: 82901
		private static IntPtr __GetI8Set_NativeFunctionPtr;

		// Token: 0x040143D6 RID: 82902
		private static IntPtr __GetI8Map_NativeFunctionPtr;

		// Token: 0x040143D7 RID: 82903
		private static IntPtr __GetI8Array_NativeFunctionPtr;

		// Token: 0x040143D8 RID: 82904
		private static IntPtr __GetI8_NativeFunctionPtr;

		// Token: 0x040143D9 RID: 82905
		private static IntPtr __GetI64Set_NativeFunctionPtr;

		// Token: 0x040143DA RID: 82906
		private static IntPtr __GetI64Map_NativeFunctionPtr;

		// Token: 0x040143DB RID: 82907
		private static IntPtr __GetI64Array_NativeFunctionPtr;

		// Token: 0x040143DC RID: 82908
		private static IntPtr __GetI64_NativeFunctionPtr;

		// Token: 0x040143DD RID: 82909
		private static IntPtr __GetI32Set_NativeFunctionPtr;

		// Token: 0x040143DE RID: 82910
		private static IntPtr __GetI32Map_NativeFunctionPtr;

		// Token: 0x040143DF RID: 82911
		private static IntPtr __GetI32Array_NativeFunctionPtr;

		// Token: 0x040143E0 RID: 82912
		private static IntPtr __GetI32_NativeFunctionPtr;

		// Token: 0x040143E1 RID: 82913
		private static IntPtr __GetI16Set_NativeFunctionPtr;

		// Token: 0x040143E2 RID: 82914
		private static IntPtr __GetI16Map_NativeFunctionPtr;

		// Token: 0x040143E3 RID: 82915
		private static IntPtr __GetI16Array_NativeFunctionPtr;

		// Token: 0x040143E4 RID: 82916
		private static IntPtr __GetI16_NativeFunctionPtr;

		// Token: 0x040143E5 RID: 82917
		private static IntPtr __GetF64Set_NativeFunctionPtr;

		// Token: 0x040143E6 RID: 82918
		private static IntPtr __GetF64Map_NativeFunctionPtr;

		// Token: 0x040143E7 RID: 82919
		private static IntPtr __GetF64Array_NativeFunctionPtr;

		// Token: 0x040143E8 RID: 82920
		private static IntPtr __GetF64_NativeFunctionPtr;

		// Token: 0x040143E9 RID: 82921
		private static IntPtr __GetF32Set_NativeFunctionPtr;

		// Token: 0x040143EA RID: 82922
		private static IntPtr __GetF32Map_NativeFunctionPtr;

		// Token: 0x040143EB RID: 82923
		private static IntPtr __GetF32Array_NativeFunctionPtr;

		// Token: 0x040143EC RID: 82924
		private static IntPtr __GetF32_NativeFunctionPtr;

		// Token: 0x040143ED RID: 82925
		private static IntPtr __GetBoolSet_NativeFunctionPtr;

		// Token: 0x040143EE RID: 82926
		private static IntPtr __GetBoolMap_NativeFunctionPtr;

		// Token: 0x040143EF RID: 82927
		private static IntPtr __GetBoolArray_NativeFunctionPtr;

		// Token: 0x040143F0 RID: 82928
		private static IntPtr __GetBool_NativeFunctionPtr;

		// Token: 0x02003783 RID: 14211
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Set_FunctionParams
		{
			// Token: 0x040178AA RID: 96426
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x02003784 RID: 14212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Map_FunctionParams
		{
			// Token: 0x040178AB RID: 96427
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x02003785 RID: 14213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU8Array_FunctionParams
		{
			// Token: 0x040178AC RID: 96428
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x02003786 RID: 14214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetU8_FunctionParams
		{
			// Token: 0x040178AD RID: 96429
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x02003787 RID: 14215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Set_FunctionParams
		{
			// Token: 0x040178AE RID: 96430
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x02003788 RID: 14216
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Map_FunctionParams
		{
			// Token: 0x040178AF RID: 96431
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x02003789 RID: 14217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU64Array_FunctionParams
		{
			// Token: 0x040178B0 RID: 96432
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x0200378A RID: 14218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetU64_FunctionParams
		{
			// Token: 0x040178B1 RID: 96433
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x0200378B RID: 14219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Set_FunctionParams
		{
			// Token: 0x040178B2 RID: 96434
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x0200378C RID: 14220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Map_FunctionParams
		{
			// Token: 0x040178B3 RID: 96435
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x0200378D RID: 14221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU32Array_FunctionParams
		{
			// Token: 0x040178B4 RID: 96436
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x0200378E RID: 14222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetU32_FunctionParams
		{
			// Token: 0x040178B5 RID: 96437
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x0200378F RID: 14223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Set_FunctionParams
		{
			// Token: 0x040178B6 RID: 96438
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x02003790 RID: 14224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Map_FunctionParams
		{
			// Token: 0x040178B7 RID: 96439
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x02003791 RID: 14225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU16Array_FunctionParams
		{
			// Token: 0x040178B8 RID: 96440
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x02003792 RID: 14226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetU16_FunctionParams
		{
			// Token: 0x040178B9 RID: 96441
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x02003793 RID: 14227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Set_FunctionParams
		{
			// Token: 0x040178BA RID: 96442
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x02003794 RID: 14228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Map_FunctionParams
		{
			// Token: 0x040178BB RID: 96443
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x02003795 RID: 14229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI8Array_FunctionParams
		{
			// Token: 0x040178BC RID: 96444
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x02003796 RID: 14230
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetI8_FunctionParams
		{
			// Token: 0x040178BD RID: 96445
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x02003797 RID: 14231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Set_FunctionParams
		{
			// Token: 0x040178BE RID: 96446
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x02003798 RID: 14232
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Map_FunctionParams
		{
			// Token: 0x040178BF RID: 96447
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x02003799 RID: 14233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI64Array_FunctionParams
		{
			// Token: 0x040178C0 RID: 96448
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x0200379A RID: 14234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetI64_FunctionParams
		{
			// Token: 0x040178C1 RID: 96449
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x0200379B RID: 14235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Set_FunctionParams
		{
			// Token: 0x040178C2 RID: 96450
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x0200379C RID: 14236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Map_FunctionParams
		{
			// Token: 0x040178C3 RID: 96451
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x0200379D RID: 14237
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI32Array_FunctionParams
		{
			// Token: 0x040178C4 RID: 96452
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x0200379E RID: 14238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetI32_FunctionParams
		{
			// Token: 0x040178C5 RID: 96453
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x0200379F RID: 14239
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Set_FunctionParams
		{
			// Token: 0x040178C6 RID: 96454
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x020037A0 RID: 14240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Map_FunctionParams
		{
			// Token: 0x040178C7 RID: 96455
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x020037A1 RID: 14241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI16Array_FunctionParams
		{
			// Token: 0x040178C8 RID: 96456
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x020037A2 RID: 14242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetI16_FunctionParams
		{
			// Token: 0x040178C9 RID: 96457
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x020037A3 RID: 14243
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Set_FunctionParams
		{
			// Token: 0x040178CA RID: 96458
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x020037A4 RID: 14244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Map_FunctionParams
		{
			// Token: 0x040178CB RID: 96459
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x020037A5 RID: 14245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF64Array_FunctionParams
		{
			// Token: 0x040178CC RID: 96460
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x020037A6 RID: 14246
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetF64_FunctionParams
		{
			// Token: 0x040178CD RID: 96461
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x020037A7 RID: 14247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Set_FunctionParams
		{
			// Token: 0x040178CE RID: 96462
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x020037A8 RID: 14248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Map_FunctionParams
		{
			// Token: 0x040178CF RID: 96463
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x020037A9 RID: 14249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF32Array_FunctionParams
		{
			// Token: 0x040178D0 RID: 96464
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x020037AA RID: 14250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetF32_FunctionParams
		{
			// Token: 0x040178D1 RID: 96465
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x020037AB RID: 14251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolSet_FunctionParams
		{
			// Token: 0x040178D2 RID: 96466
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x020037AC RID: 14252
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolMap_FunctionParams
		{
			// Token: 0x040178D3 RID: 96467
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x020037AD RID: 14253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBoolArray_FunctionParams
		{
			// Token: 0x040178D4 RID: 96468
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x020037AE RID: 14254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetBool_FunctionParams
		{
			// Token: 0x040178D5 RID: 96469
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x020037AF RID: 14255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Set_FunctionParams
		{
			// Token: 0x040178D6 RID: 96470
			[FieldOffset(0)]
			public byte OutU8Set;
		}

		// Token: 0x020037B0 RID: 14256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Map_FunctionParams
		{
			// Token: 0x040178D7 RID: 96471
			[FieldOffset(0)]
			public byte OutU8Map;
		}

		// Token: 0x020037B1 RID: 14257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU8Array_FunctionParams
		{
			// Token: 0x040178D8 RID: 96472
			[FieldOffset(0)]
			public byte OutU8Array;
		}

		// Token: 0x020037B2 RID: 14258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutU8_FunctionParams
		{
			// Token: 0x040178D9 RID: 96473
			[FieldOffset(0)]
			public byte OutU8;
		}

		// Token: 0x020037B3 RID: 14259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Set_FunctionParams
		{
			// Token: 0x040178DA RID: 96474
			[FieldOffset(0)]
			public byte OutU64Set;
		}

		// Token: 0x020037B4 RID: 14260
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Map_FunctionParams
		{
			// Token: 0x040178DB RID: 96475
			[FieldOffset(0)]
			public byte OutU64Map;
		}

		// Token: 0x020037B5 RID: 14261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU64Array_FunctionParams
		{
			// Token: 0x040178DC RID: 96476
			[FieldOffset(0)]
			public byte OutU64Array;
		}

		// Token: 0x020037B6 RID: 14262
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutU64_FunctionParams
		{
			// Token: 0x040178DD RID: 96477
			[FieldOffset(0)]
			public ulong OutU64;
		}

		// Token: 0x020037B7 RID: 14263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Set_FunctionParams
		{
			// Token: 0x040178DE RID: 96478
			[FieldOffset(0)]
			public byte OutU32Set;
		}

		// Token: 0x020037B8 RID: 14264
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Map_FunctionParams
		{
			// Token: 0x040178DF RID: 96479
			[FieldOffset(0)]
			public byte OutU32Map;
		}

		// Token: 0x020037B9 RID: 14265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU32Array_FunctionParams
		{
			// Token: 0x040178E0 RID: 96480
			[FieldOffset(0)]
			public byte OutU32Array;
		}

		// Token: 0x020037BA RID: 14266
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutU32_FunctionParams
		{
			// Token: 0x040178E1 RID: 96481
			[FieldOffset(0)]
			public uint OutU32;
		}

		// Token: 0x020037BB RID: 14267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Set_FunctionParams
		{
			// Token: 0x040178E2 RID: 96482
			[FieldOffset(0)]
			public byte OutU16Set;
		}

		// Token: 0x020037BC RID: 14268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Map_FunctionParams
		{
			// Token: 0x040178E3 RID: 96483
			[FieldOffset(0)]
			public byte OutU16Map;
		}

		// Token: 0x020037BD RID: 14269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU16Array_FunctionParams
		{
			// Token: 0x040178E4 RID: 96484
			[FieldOffset(0)]
			public byte OutU16Array;
		}

		// Token: 0x020037BE RID: 14270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutU16_FunctionParams
		{
			// Token: 0x040178E5 RID: 96485
			[FieldOffset(0)]
			public ushort OutU16;
		}

		// Token: 0x020037BF RID: 14271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Set_FunctionParams
		{
			// Token: 0x040178E6 RID: 96486
			[FieldOffset(0)]
			public byte OutI8Set;
		}

		// Token: 0x020037C0 RID: 14272
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Map_FunctionParams
		{
			// Token: 0x040178E7 RID: 96487
			[FieldOffset(0)]
			public byte OutI8Map;
		}

		// Token: 0x020037C1 RID: 14273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI8Array_FunctionParams
		{
			// Token: 0x040178E8 RID: 96488
			[FieldOffset(0)]
			public byte OutI8Array;
		}

		// Token: 0x020037C2 RID: 14274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutI8_FunctionParams
		{
			// Token: 0x040178E9 RID: 96489
			[FieldOffset(0)]
			public sbyte OutI8;
		}

		// Token: 0x020037C3 RID: 14275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Set_FunctionParams
		{
			// Token: 0x040178EA RID: 96490
			[FieldOffset(0)]
			public byte OutI64Set;
		}

		// Token: 0x020037C4 RID: 14276
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Map_FunctionParams
		{
			// Token: 0x040178EB RID: 96491
			[FieldOffset(0)]
			public byte OutI64Map;
		}

		// Token: 0x020037C5 RID: 14277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI64Array_FunctionParams
		{
			// Token: 0x040178EC RID: 96492
			[FieldOffset(0)]
			public byte OutI64Array;
		}

		// Token: 0x020037C6 RID: 14278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutI64_FunctionParams
		{
			// Token: 0x040178ED RID: 96493
			[FieldOffset(0)]
			public long OutI64;
		}

		// Token: 0x020037C7 RID: 14279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Set_FunctionParams
		{
			// Token: 0x040178EE RID: 96494
			[FieldOffset(0)]
			public byte OutI32Set;
		}

		// Token: 0x020037C8 RID: 14280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Map_FunctionParams
		{
			// Token: 0x040178EF RID: 96495
			[FieldOffset(0)]
			public byte OutI32Map;
		}

		// Token: 0x020037C9 RID: 14281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI32Array_FunctionParams
		{
			// Token: 0x040178F0 RID: 96496
			[FieldOffset(0)]
			public byte OutI32Array;
		}

		// Token: 0x020037CA RID: 14282
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutI32_FunctionParams
		{
			// Token: 0x040178F1 RID: 96497
			[FieldOffset(0)]
			public int OutI32;
		}

		// Token: 0x020037CB RID: 14283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Set_FunctionParams
		{
			// Token: 0x040178F2 RID: 96498
			[FieldOffset(0)]
			public byte OutI16Set;
		}

		// Token: 0x020037CC RID: 14284
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Map_FunctionParams
		{
			// Token: 0x040178F3 RID: 96499
			[FieldOffset(0)]
			public byte OutI16Map;
		}

		// Token: 0x020037CD RID: 14285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI16Array_FunctionParams
		{
			// Token: 0x040178F4 RID: 96500
			[FieldOffset(0)]
			public byte OutI16Array;
		}

		// Token: 0x020037CE RID: 14286
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutI16_FunctionParams
		{
			// Token: 0x040178F5 RID: 96501
			[FieldOffset(0)]
			public short OutI16;
		}

		// Token: 0x020037CF RID: 14287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Set_FunctionParams
		{
			// Token: 0x040178F6 RID: 96502
			[FieldOffset(0)]
			public byte OutF64Set;
		}

		// Token: 0x020037D0 RID: 14288
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Map_FunctionParams
		{
			// Token: 0x040178F7 RID: 96503
			[FieldOffset(0)]
			public byte OutF64Map;
		}

		// Token: 0x020037D1 RID: 14289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF64Array_FunctionParams
		{
			// Token: 0x040178F8 RID: 96504
			[FieldOffset(0)]
			public byte OutF64Array;
		}

		// Token: 0x020037D2 RID: 14290
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutF64_FunctionParams
		{
			// Token: 0x040178F9 RID: 96505
			[FieldOffset(0)]
			public double OutF64;
		}

		// Token: 0x020037D3 RID: 14291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Set_FunctionParams
		{
			// Token: 0x040178FA RID: 96506
			[FieldOffset(0)]
			public byte OutF32Set;
		}

		// Token: 0x020037D4 RID: 14292
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Map_FunctionParams
		{
			// Token: 0x040178FB RID: 96507
			[FieldOffset(0)]
			public byte OutF32Map;
		}

		// Token: 0x020037D5 RID: 14293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF32Array_FunctionParams
		{
			// Token: 0x040178FC RID: 96508
			[FieldOffset(0)]
			public byte OutF32Array;
		}

		// Token: 0x020037D6 RID: 14294
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutF32_FunctionParams
		{
			// Token: 0x040178FD RID: 96509
			[FieldOffset(0)]
			public float OutF32;
		}

		// Token: 0x020037D7 RID: 14295
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolSet_FunctionParams
		{
			// Token: 0x040178FE RID: 96510
			[FieldOffset(0)]
			public byte OutBoolSet;
		}

		// Token: 0x020037D8 RID: 14296
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolMap_FunctionParams
		{
			// Token: 0x040178FF RID: 96511
			[FieldOffset(0)]
			public byte OutBoolMap;
		}

		// Token: 0x020037D9 RID: 14297
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutBoolArray_FunctionParams
		{
			// Token: 0x04017900 RID: 96512
			[FieldOffset(0)]
			public byte OutBoolArray;
		}

		// Token: 0x020037DA RID: 14298
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutBool_FunctionParams
		{
			// Token: 0x04017901 RID: 96513
			[FieldOffset(0)]
			public bool OutBool;
		}

		// Token: 0x020037DB RID: 14299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Set_FunctionParams
		{
			// Token: 0x04017902 RID: 96514
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x020037DC RID: 14300
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Map_FunctionParams
		{
			// Token: 0x04017903 RID: 96515
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x020037DD RID: 14301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU8Array_FunctionParams
		{
			// Token: 0x04017904 RID: 96516
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x020037DE RID: 14302
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InU8_FunctionParams
		{
			// Token: 0x04017905 RID: 96517
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x020037DF RID: 14303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Set_FunctionParams
		{
			// Token: 0x04017906 RID: 96518
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x020037E0 RID: 14304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Map_FunctionParams
		{
			// Token: 0x04017907 RID: 96519
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x020037E1 RID: 14305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU64Array_FunctionParams
		{
			// Token: 0x04017908 RID: 96520
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x020037E2 RID: 14306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InU64_FunctionParams
		{
			// Token: 0x04017909 RID: 96521
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x020037E3 RID: 14307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Set_FunctionParams
		{
			// Token: 0x0401790A RID: 96522
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x020037E4 RID: 14308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Map_FunctionParams
		{
			// Token: 0x0401790B RID: 96523
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x020037E5 RID: 14309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU32Array_FunctionParams
		{
			// Token: 0x0401790C RID: 96524
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x020037E6 RID: 14310
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InU32_FunctionParams
		{
			// Token: 0x0401790D RID: 96525
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x020037E7 RID: 14311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Set_FunctionParams
		{
			// Token: 0x0401790E RID: 96526
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x020037E8 RID: 14312
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Map_FunctionParams
		{
			// Token: 0x0401790F RID: 96527
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x020037E9 RID: 14313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU16Array_FunctionParams
		{
			// Token: 0x04017910 RID: 96528
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x020037EA RID: 14314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InU16_FunctionParams
		{
			// Token: 0x04017911 RID: 96529
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x020037EB RID: 14315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Set_FunctionParams
		{
			// Token: 0x04017912 RID: 96530
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x020037EC RID: 14316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Map_FunctionParams
		{
			// Token: 0x04017913 RID: 96531
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x020037ED RID: 14317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI8Array_FunctionParams
		{
			// Token: 0x04017914 RID: 96532
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x020037EE RID: 14318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InI8_FunctionParams
		{
			// Token: 0x04017915 RID: 96533
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x020037EF RID: 14319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Set_FunctionParams
		{
			// Token: 0x04017916 RID: 96534
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x020037F0 RID: 14320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Map_FunctionParams
		{
			// Token: 0x04017917 RID: 96535
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x020037F1 RID: 14321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI64Array_FunctionParams
		{
			// Token: 0x04017918 RID: 96536
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x020037F2 RID: 14322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InI64_FunctionParams
		{
			// Token: 0x04017919 RID: 96537
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x020037F3 RID: 14323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Set_FunctionParams
		{
			// Token: 0x0401791A RID: 96538
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x020037F4 RID: 14324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Map_FunctionParams
		{
			// Token: 0x0401791B RID: 96539
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x020037F5 RID: 14325
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI32Array_FunctionParams
		{
			// Token: 0x0401791C RID: 96540
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x020037F6 RID: 14326
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InI32_FunctionParams
		{
			// Token: 0x0401791D RID: 96541
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x020037F7 RID: 14327
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Set_FunctionParams
		{
			// Token: 0x0401791E RID: 96542
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x020037F8 RID: 14328
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Map_FunctionParams
		{
			// Token: 0x0401791F RID: 96543
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x020037F9 RID: 14329
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI16Array_FunctionParams
		{
			// Token: 0x04017920 RID: 96544
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x020037FA RID: 14330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InI16_FunctionParams
		{
			// Token: 0x04017921 RID: 96545
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x020037FB RID: 14331
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Set_FunctionParams
		{
			// Token: 0x04017922 RID: 96546
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x020037FC RID: 14332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Map_FunctionParams
		{
			// Token: 0x04017923 RID: 96547
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x020037FD RID: 14333
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF64Array_FunctionParams
		{
			// Token: 0x04017924 RID: 96548
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x020037FE RID: 14334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InF64_FunctionParams
		{
			// Token: 0x04017925 RID: 96549
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x020037FF RID: 14335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Set_FunctionParams
		{
			// Token: 0x04017926 RID: 96550
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x02003800 RID: 14336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Map_FunctionParams
		{
			// Token: 0x04017927 RID: 96551
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x02003801 RID: 14337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF32Array_FunctionParams
		{
			// Token: 0x04017928 RID: 96552
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x02003802 RID: 14338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InF32_FunctionParams
		{
			// Token: 0x04017929 RID: 96553
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x02003803 RID: 14339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolSet_FunctionParams
		{
			// Token: 0x0401792A RID: 96554
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x02003804 RID: 14340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolMap_FunctionParams
		{
			// Token: 0x0401792B RID: 96555
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x02003805 RID: 14341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InBoolArray_FunctionParams
		{
			// Token: 0x0401792C RID: 96556
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x02003806 RID: 14342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InBool_FunctionParams
		{
			// Token: 0x0401792D RID: 96557
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02003807 RID: 14343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Set_FunctionParams
		{
			// Token: 0x0401792E RID: 96558
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003808 RID: 14344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Map_FunctionParams
		{
			// Token: 0x0401792F RID: 96559
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003809 RID: 14345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU8Array_FunctionParams
		{
			// Token: 0x04017930 RID: 96560
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200380A RID: 14346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetU8_FunctionParams
		{
			// Token: 0x04017931 RID: 96561
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200380B RID: 14347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Set_FunctionParams
		{
			// Token: 0x04017932 RID: 96562
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200380C RID: 14348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Map_FunctionParams
		{
			// Token: 0x04017933 RID: 96563
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200380D RID: 14349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU64Array_FunctionParams
		{
			// Token: 0x04017934 RID: 96564
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200380E RID: 14350
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetU64_FunctionParams
		{
			// Token: 0x04017935 RID: 96565
			[FieldOffset(0)]
			public ulong __Result;
		}

		// Token: 0x0200380F RID: 14351
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Set_FunctionParams
		{
			// Token: 0x04017936 RID: 96566
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003810 RID: 14352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Map_FunctionParams
		{
			// Token: 0x04017937 RID: 96567
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003811 RID: 14353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU32Array_FunctionParams
		{
			// Token: 0x04017938 RID: 96568
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003812 RID: 14354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetU32_FunctionParams
		{
			// Token: 0x04017939 RID: 96569
			[FieldOffset(0)]
			public uint __Result;
		}

		// Token: 0x02003813 RID: 14355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Set_FunctionParams
		{
			// Token: 0x0401793A RID: 96570
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003814 RID: 14356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Map_FunctionParams
		{
			// Token: 0x0401793B RID: 96571
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003815 RID: 14357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU16Array_FunctionParams
		{
			// Token: 0x0401793C RID: 96572
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003816 RID: 14358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetU16_FunctionParams
		{
			// Token: 0x0401793D RID: 96573
			[FieldOffset(0)]
			public ushort __Result;
		}

		// Token: 0x02003817 RID: 14359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Set_FunctionParams
		{
			// Token: 0x0401793E RID: 96574
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003818 RID: 14360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Map_FunctionParams
		{
			// Token: 0x0401793F RID: 96575
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003819 RID: 14361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI8Array_FunctionParams
		{
			// Token: 0x04017940 RID: 96576
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200381A RID: 14362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetI8_FunctionParams
		{
			// Token: 0x04017941 RID: 96577
			[FieldOffset(0)]
			public sbyte __Result;
		}

		// Token: 0x0200381B RID: 14363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Set_FunctionParams
		{
			// Token: 0x04017942 RID: 96578
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200381C RID: 14364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Map_FunctionParams
		{
			// Token: 0x04017943 RID: 96579
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200381D RID: 14365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI64Array_FunctionParams
		{
			// Token: 0x04017944 RID: 96580
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200381E RID: 14366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetI64_FunctionParams
		{
			// Token: 0x04017945 RID: 96581
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x0200381F RID: 14367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Set_FunctionParams
		{
			// Token: 0x04017946 RID: 96582
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003820 RID: 14368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Map_FunctionParams
		{
			// Token: 0x04017947 RID: 96583
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003821 RID: 14369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI32Array_FunctionParams
		{
			// Token: 0x04017948 RID: 96584
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003822 RID: 14370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetI32_FunctionParams
		{
			// Token: 0x04017949 RID: 96585
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003823 RID: 14371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Set_FunctionParams
		{
			// Token: 0x0401794A RID: 96586
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003824 RID: 14372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Map_FunctionParams
		{
			// Token: 0x0401794B RID: 96587
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003825 RID: 14373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI16Array_FunctionParams
		{
			// Token: 0x0401794C RID: 96588
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003826 RID: 14374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetI16_FunctionParams
		{
			// Token: 0x0401794D RID: 96589
			[FieldOffset(0)]
			public short __Result;
		}

		// Token: 0x02003827 RID: 14375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Set_FunctionParams
		{
			// Token: 0x0401794E RID: 96590
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003828 RID: 14376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Map_FunctionParams
		{
			// Token: 0x0401794F RID: 96591
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003829 RID: 14377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF64Array_FunctionParams
		{
			// Token: 0x04017950 RID: 96592
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200382A RID: 14378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetF64_FunctionParams
		{
			// Token: 0x04017951 RID: 96593
			[FieldOffset(0)]
			public double __Result;
		}

		// Token: 0x0200382B RID: 14379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Set_FunctionParams
		{
			// Token: 0x04017952 RID: 96594
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200382C RID: 14380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Map_FunctionParams
		{
			// Token: 0x04017953 RID: 96595
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200382D RID: 14381
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF32Array_FunctionParams
		{
			// Token: 0x04017954 RID: 96596
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200382E RID: 14382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetF32_FunctionParams
		{
			// Token: 0x04017955 RID: 96597
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x0200382F RID: 14383
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolSet_FunctionParams
		{
			// Token: 0x04017956 RID: 96598
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003830 RID: 14384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolMap_FunctionParams
		{
			// Token: 0x04017957 RID: 96599
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003831 RID: 14385
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoolArray_FunctionParams
		{
			// Token: 0x04017958 RID: 96600
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003832 RID: 14386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetBool_FunctionParams
		{
			// Token: 0x04017959 RID: 96601
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
