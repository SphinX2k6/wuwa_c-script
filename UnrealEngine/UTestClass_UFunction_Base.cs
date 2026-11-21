using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FA RID: 2042
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class UTestClass_UFunction_Base : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AF6B RID: 44907 RVA: 0x00104D65 File Offset: 0x00102F65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Base._ClassPtr;
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x00104D74 File Offset: 0x00102F74
		public UTestClass_UFunction_Base() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x00104D9C File Offset: 0x00102F9C
		[NullableContext(1)]
		public UTestClass_UFunction_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x00104DCF File Offset: 0x00102FCF
		// (set) Token: 0x0600AF6F RID: 44911 RVA: 0x00104DDF File Offset: 0x00102FDF
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600AF70 RID: 44912 RVA: 0x00104DF0 File Offset: 0x00102FF0
		// (set) Token: 0x0600AF71 RID: 44913 RVA: 0x00104E29 File Offset: 0x00103029
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

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x00104E38 File Offset: 0x00103038
		// (set) Token: 0x0600AF73 RID: 44915 RVA: 0x00104E71 File Offset: 0x00103071
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

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x00104E80 File Offset: 0x00103080
		// (set) Token: 0x0600AF75 RID: 44917 RVA: 0x00104EB9 File Offset: 0x001030B9
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

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x00104EC7 File Offset: 0x001030C7
		// (set) Token: 0x0600AF77 RID: 44919 RVA: 0x00104ED7 File Offset: 0x001030D7
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

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x00104EE8 File Offset: 0x001030E8
		// (set) Token: 0x0600AF79 RID: 44921 RVA: 0x00104F21 File Offset: 0x00103121
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

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x00104F30 File Offset: 0x00103130
		// (set) Token: 0x0600AF7B RID: 44923 RVA: 0x00104F69 File Offset: 0x00103169
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

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x00104F78 File Offset: 0x00103178
		// (set) Token: 0x0600AF7D RID: 44925 RVA: 0x00104FB1 File Offset: 0x001031B1
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

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x00104FBF File Offset: 0x001031BF
		// (set) Token: 0x0600AF7F RID: 44927 RVA: 0x00104FCF File Offset: 0x001031CF
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

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600AF80 RID: 44928 RVA: 0x00104FE0 File Offset: 0x001031E0
		// (set) Token: 0x0600AF81 RID: 44929 RVA: 0x00105019 File Offset: 0x00103219
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

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x00105028 File Offset: 0x00103228
		// (set) Token: 0x0600AF83 RID: 44931 RVA: 0x00105061 File Offset: 0x00103261
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

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x00105070 File Offset: 0x00103270
		// (set) Token: 0x0600AF85 RID: 44933 RVA: 0x001050A9 File Offset: 0x001032A9
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

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x001050B7 File Offset: 0x001032B7
		// (set) Token: 0x0600AF87 RID: 44935 RVA: 0x001050C7 File Offset: 0x001032C7
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

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x001050D8 File Offset: 0x001032D8
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x00105111 File Offset: 0x00103311
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

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600AF8A RID: 44938 RVA: 0x00105120 File Offset: 0x00103320
		// (set) Token: 0x0600AF8B RID: 44939 RVA: 0x00105159 File Offset: 0x00103359
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

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x00105168 File Offset: 0x00103368
		// (set) Token: 0x0600AF8D RID: 44941 RVA: 0x001051A1 File Offset: 0x001033A1
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

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600AF8E RID: 44942 RVA: 0x001051AF File Offset: 0x001033AF
		// (set) Token: 0x0600AF8F RID: 44943 RVA: 0x001051BF File Offset: 0x001033BF
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

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600AF90 RID: 44944 RVA: 0x001051D0 File Offset: 0x001033D0
		// (set) Token: 0x0600AF91 RID: 44945 RVA: 0x00105209 File Offset: 0x00103409
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

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600AF92 RID: 44946 RVA: 0x00105218 File Offset: 0x00103418
		// (set) Token: 0x0600AF93 RID: 44947 RVA: 0x00105251 File Offset: 0x00103451
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

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x0600AF94 RID: 44948 RVA: 0x00105260 File Offset: 0x00103460
		// (set) Token: 0x0600AF95 RID: 44949 RVA: 0x00105299 File Offset: 0x00103499
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

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x0600AF96 RID: 44950 RVA: 0x001052A7 File Offset: 0x001034A7
		// (set) Token: 0x0600AF97 RID: 44951 RVA: 0x001052B7 File Offset: 0x001034B7
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

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x001052C8 File Offset: 0x001034C8
		// (set) Token: 0x0600AF99 RID: 44953 RVA: 0x00105301 File Offset: 0x00103501
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

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x0600AF9A RID: 44954 RVA: 0x00105310 File Offset: 0x00103510
		// (set) Token: 0x0600AF9B RID: 44955 RVA: 0x00105349 File Offset: 0x00103549
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

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x00105358 File Offset: 0x00103558
		// (set) Token: 0x0600AF9D RID: 44957 RVA: 0x00105391 File Offset: 0x00103591
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

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x0010539F File Offset: 0x0010359F
		// (set) Token: 0x0600AF9F RID: 44959 RVA: 0x001053AF File Offset: 0x001035AF
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

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600AFA0 RID: 44960 RVA: 0x001053C0 File Offset: 0x001035C0
		// (set) Token: 0x0600AFA1 RID: 44961 RVA: 0x001053F9 File Offset: 0x001035F9
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

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600AFA2 RID: 44962 RVA: 0x00105408 File Offset: 0x00103608
		// (set) Token: 0x0600AFA3 RID: 44963 RVA: 0x00105441 File Offset: 0x00103641
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

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x00105450 File Offset: 0x00103650
		// (set) Token: 0x0600AFA5 RID: 44965 RVA: 0x00105489 File Offset: 0x00103689
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

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x00105497 File Offset: 0x00103697
		// (set) Token: 0x0600AFA7 RID: 44967 RVA: 0x001054A7 File Offset: 0x001036A7
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

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600AFA8 RID: 44968 RVA: 0x001054B8 File Offset: 0x001036B8
		// (set) Token: 0x0600AFA9 RID: 44969 RVA: 0x001054F1 File Offset: 0x001036F1
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

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x00105500 File Offset: 0x00103700
		// (set) Token: 0x0600AFAB RID: 44971 RVA: 0x00105539 File Offset: 0x00103739
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

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x00105548 File Offset: 0x00103748
		// (set) Token: 0x0600AFAD RID: 44973 RVA: 0x00105581 File Offset: 0x00103781
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

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x0010558F File Offset: 0x0010378F
		// (set) Token: 0x0600AFAF RID: 44975 RVA: 0x0010559F File Offset: 0x0010379F
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

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x001055B0 File Offset: 0x001037B0
		// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x001055E9 File Offset: 0x001037E9
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

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x001055F8 File Offset: 0x001037F8
		// (set) Token: 0x0600AFB3 RID: 44979 RVA: 0x00105631 File Offset: 0x00103831
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

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x00105640 File Offset: 0x00103840
		// (set) Token: 0x0600AFB5 RID: 44981 RVA: 0x00105679 File Offset: 0x00103879
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

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x00105687 File Offset: 0x00103887
		// (set) Token: 0x0600AFB7 RID: 44983 RVA: 0x00105697 File Offset: 0x00103897
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

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x001056A8 File Offset: 0x001038A8
		// (set) Token: 0x0600AFB9 RID: 44985 RVA: 0x001056E1 File Offset: 0x001038E1
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

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600AFBA RID: 44986 RVA: 0x001056F0 File Offset: 0x001038F0
		// (set) Token: 0x0600AFBB RID: 44987 RVA: 0x00105729 File Offset: 0x00103929
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

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600AFBC RID: 44988 RVA: 0x00105738 File Offset: 0x00103938
		// (set) Token: 0x0600AFBD RID: 44989 RVA: 0x00105771 File Offset: 0x00103971
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

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x0010577F File Offset: 0x0010397F
		// (set) Token: 0x0600AFBF RID: 44991 RVA: 0x0010578F File Offset: 0x0010398F
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

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x001057A0 File Offset: 0x001039A0
		// (set) Token: 0x0600AFC1 RID: 44993 RVA: 0x001057D9 File Offset: 0x001039D9
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

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x001057E8 File Offset: 0x001039E8
		// (set) Token: 0x0600AFC3 RID: 44995 RVA: 0x00105821 File Offset: 0x00103A21
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

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600AFC4 RID: 44996 RVA: 0x00105830 File Offset: 0x00103A30
		// (set) Token: 0x0600AFC5 RID: 44997 RVA: 0x00105869 File Offset: 0x00103A69
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

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x00105878 File Offset: 0x00103A78
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Set(TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Base.__SetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Set != null)
			{
				InU8Set.CopyTo(&ptr->InU8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x001058E4 File Offset: 0x00103AE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Map(TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Base.__SetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Map != null)
			{
				InU8Map.CopyTo(&ptr->InU8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x00105950 File Offset: 0x00103B50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Array(TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Base.__SetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Array != null)
			{
				InU8Array.CopyTo(&ptr->InU8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x001059BC File Offset: 0x00103BBC
		[SkipLocalsInit]
		public unsafe void SetU8(byte InU8)
		{
			UTestClass_UFunction_Base.__SetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x00105A04 File Offset: 0x00103C04
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Set(TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Base.__SetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Set != null)
			{
				InU64Set.CopyTo(&ptr->InU64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x00105A70 File Offset: 0x00103C70
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Map(TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Base.__SetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Map != null)
			{
				InU64Map.CopyTo(&ptr->InU64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x00105ADC File Offset: 0x00103CDC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Array(TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Base.__SetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Array != null)
			{
				InU64Array.CopyTo(&ptr->InU64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x00105B48 File Offset: 0x00103D48
		[SkipLocalsInit]
		public unsafe void SetU64(ulong InU64)
		{
			UTestClass_UFunction_Base.__SetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x00105B90 File Offset: 0x00103D90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Set(TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Base.__SetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Set != null)
			{
				InU32Set.CopyTo(&ptr->InU32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x00105BFC File Offset: 0x00103DFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Map(TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Base.__SetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Map != null)
			{
				InU32Map.CopyTo(&ptr->InU32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x00105C68 File Offset: 0x00103E68
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Array(TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Base.__SetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Array != null)
			{
				InU32Array.CopyTo(&ptr->InU32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x00105CD4 File Offset: 0x00103ED4
		[SkipLocalsInit]
		public unsafe void SetU32(uint InU32)
		{
			UTestClass_UFunction_Base.__SetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x00105D1C File Offset: 0x00103F1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Set(TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Base.__SetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Set != null)
			{
				InU16Set.CopyTo(&ptr->InU16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x00105D88 File Offset: 0x00103F88
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Map(TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Base.__SetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Map != null)
			{
				InU16Map.CopyTo(&ptr->InU16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x00105DF4 File Offset: 0x00103FF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Array(TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Base.__SetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Array != null)
			{
				InU16Array.CopyTo(&ptr->InU16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x00105E60 File Offset: 0x00104060
		[SkipLocalsInit]
		public unsafe void SetU16(ushort InU16)
		{
			UTestClass_UFunction_Base.__SetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetU16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x00105EA8 File Offset: 0x001040A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Set(TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Base.__SetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Set != null)
			{
				InI8Set.CopyTo(&ptr->InI8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x00105F14 File Offset: 0x00104114
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Map(TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Base.__SetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Map != null)
			{
				InI8Map.CopyTo(&ptr->InI8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x00105F80 File Offset: 0x00104180
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Array(TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Base.__SetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Array != null)
			{
				InI8Array.CopyTo(&ptr->InI8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x00105FEC File Offset: 0x001041EC
		[SkipLocalsInit]
		public unsafe void SetI8(sbyte InI8)
		{
			UTestClass_UFunction_Base.__SetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x00106034 File Offset: 0x00104234
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Set(TSet<long> InI64Set)
		{
			UTestClass_UFunction_Base.__SetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Set != null)
			{
				InI64Set.CopyTo(&ptr->InI64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x001060A0 File Offset: 0x001042A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Map(TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Base.__SetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Map != null)
			{
				InI64Map.CopyTo(&ptr->InI64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x0010610C File Offset: 0x0010430C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Array(TArray<long> InI64Array)
		{
			UTestClass_UFunction_Base.__SetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Array != null)
			{
				InI64Array.CopyTo(&ptr->InI64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x00106178 File Offset: 0x00104378
		[SkipLocalsInit]
		public unsafe void SetI64(long InI64)
		{
			UTestClass_UFunction_Base.__SetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x001061C0 File Offset: 0x001043C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Set(TSet<int> InI32Set)
		{
			UTestClass_UFunction_Base.__SetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Set != null)
			{
				InI32Set.CopyTo(&ptr->InI32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x0010622C File Offset: 0x0010442C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Map(TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Base.__SetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Map != null)
			{
				InI32Map.CopyTo(&ptr->InI32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x00106298 File Offset: 0x00104498
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Array(TArray<int> InI32Array)
		{
			UTestClass_UFunction_Base.__SetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Array != null)
			{
				InI32Array.CopyTo(&ptr->InI32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x00106304 File Offset: 0x00104504
		[SkipLocalsInit]
		public unsafe void SetI32(int InI32)
		{
			UTestClass_UFunction_Base.__SetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x0010634C File Offset: 0x0010454C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Set(TSet<short> InI16Set)
		{
			UTestClass_UFunction_Base.__SetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Set != null)
			{
				InI16Set.CopyTo(&ptr->InI16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x001063B8 File Offset: 0x001045B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Map(TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Base.__SetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Map != null)
			{
				InI16Map.CopyTo(&ptr->InI16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x00106424 File Offset: 0x00104624
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Array(TArray<short> InI16Array)
		{
			UTestClass_UFunction_Base.__SetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Array != null)
			{
				InI16Array.CopyTo(&ptr->InI16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x00106490 File Offset: 0x00104690
		[SkipLocalsInit]
		public unsafe void SetI16(short InI16)
		{
			UTestClass_UFunction_Base.__SetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetI16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x001064D8 File Offset: 0x001046D8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Set(TSet<double> InF64Set)
		{
			UTestClass_UFunction_Base.__SetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Set != null)
			{
				InF64Set.CopyTo(&ptr->InF64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x00106544 File Offset: 0x00104744
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Map(TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Base.__SetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Map != null)
			{
				InF64Map.CopyTo(&ptr->InF64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x001065B0 File Offset: 0x001047B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Array(TArray<double> InF64Array)
		{
			UTestClass_UFunction_Base.__SetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Array != null)
			{
				InF64Array.CopyTo(&ptr->InF64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x0010661C File Offset: 0x0010481C
		[SkipLocalsInit]
		public unsafe void SetF64(double InF64)
		{
			UTestClass_UFunction_Base.__SetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x00106664 File Offset: 0x00104864
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Set(TSet<float> InF32Set)
		{
			UTestClass_UFunction_Base.__SetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Set != null)
			{
				InF32Set.CopyTo(&ptr->InF32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x001066D0 File Offset: 0x001048D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Map(TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Base.__SetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Map != null)
			{
				InF32Map.CopyTo(&ptr->InF32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x0010673C File Offset: 0x0010493C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Array(TArray<float> InF32Array)
		{
			UTestClass_UFunction_Base.__SetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Array != null)
			{
				InF32Array.CopyTo(&ptr->InF32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x001067A8 File Offset: 0x001049A8
		[SkipLocalsInit]
		public unsafe void SetF32(float InF32)
		{
			UTestClass_UFunction_Base.__SetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetF32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x001067F0 File Offset: 0x001049F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolSet(TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Base.__SetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolSet != null)
			{
				InBoolSet.CopyTo(&ptr->InBoolSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x0010685C File Offset: 0x00104A5C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolMap(TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Base.__SetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolMap != null)
			{
				InBoolMap.CopyTo(&ptr->InBoolMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x001068C8 File Offset: 0x00104AC8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolArray(TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Base.__SetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolArray != null)
			{
				InBoolArray.CopyTo(&ptr->InBoolArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x00106934 File Offset: 0x00104B34
		[SkipLocalsInit]
		public unsafe void SetBool(bool InBool)
		{
			UTestClass_UFunction_Base.__SetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__SetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__SetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__SetBool_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x0010697C File Offset: 0x00104B7C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Set(ref TSet<byte> OutU8Set)
		{
			UTestClass_UFunction_Base.__OutU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = OutU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> tset2 = OutU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x001069F4 File Offset: 0x00104BF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Map(ref TMap<byte, int> OutU8Map)
		{
			UTestClass_UFunction_Base.__OutU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = OutU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> tmap2 = OutU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF4 RID: 45044 RVA: 0x00106A6C File Offset: 0x00104C6C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Array(ref TArray<byte> OutU8Array)
		{
			UTestClass_UFunction_Base.__OutU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = OutU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> tarray2 = OutU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF5 RID: 45045 RVA: 0x00106AE4 File Offset: 0x00104CE4
		[SkipLocalsInit]
		public unsafe void OutU8(ref byte OutU8)
		{
			UTestClass_UFunction_Base.__OutU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU8 = OutU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU8_NativeFunctionPtr, (void*)ptr);
			OutU8 = ptr->OutU8;
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x00106B34 File Offset: 0x00104D34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Set(ref TSet<ulong> OutU64Set)
		{
			UTestClass_UFunction_Base.__OutU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = OutU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> tset2 = OutU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x00106BAC File Offset: 0x00104DAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Map(ref TMap<ulong, int> OutU64Map)
		{
			UTestClass_UFunction_Base.__OutU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = OutU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> tmap2 = OutU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x00106C24 File Offset: 0x00104E24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Array(ref TArray<ulong> OutU64Array)
		{
			UTestClass_UFunction_Base.__OutU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = OutU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> tarray2 = OutU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x00106C9C File Offset: 0x00104E9C
		[SkipLocalsInit]
		public unsafe void OutU64(ref ulong OutU64)
		{
			UTestClass_UFunction_Base.__OutU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU64 = OutU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU64_NativeFunctionPtr, (void*)ptr);
			OutU64 = ptr->OutU64;
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x00106CEC File Offset: 0x00104EEC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Set(ref TSet<uint> OutU32Set)
		{
			UTestClass_UFunction_Base.__OutU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = OutU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> tset2 = OutU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFFB RID: 45051 RVA: 0x00106D64 File Offset: 0x00104F64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Map(ref TMap<uint, int> OutU32Map)
		{
			UTestClass_UFunction_Base.__OutU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = OutU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> tmap2 = OutU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x00106DDC File Offset: 0x00104FDC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Array(ref TArray<uint> OutU32Array)
		{
			UTestClass_UFunction_Base.__OutU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = OutU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> tarray2 = OutU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x00106E54 File Offset: 0x00105054
		[SkipLocalsInit]
		public unsafe void OutU32(ref uint OutU32)
		{
			UTestClass_UFunction_Base.__OutU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU32 = OutU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU32_NativeFunctionPtr, (void*)ptr);
			OutU32 = ptr->OutU32;
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x00106EA4 File Offset: 0x001050A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Set(ref TSet<ushort> OutU16Set)
		{
			UTestClass_UFunction_Base.__OutU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = OutU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> tset2 = OutU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x00106F1C File Offset: 0x0010511C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Map(ref TMap<ushort, int> OutU16Map)
		{
			UTestClass_UFunction_Base.__OutU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = OutU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> tmap2 = OutU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x00106F94 File Offset: 0x00105194
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Array(ref TArray<ushort> OutU16Array)
		{
			UTestClass_UFunction_Base.__OutU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = OutU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> tarray2 = OutU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x0010700C File Offset: 0x0010520C
		[SkipLocalsInit]
		public unsafe void OutU16(ref ushort OutU16)
		{
			UTestClass_UFunction_Base.__OutU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU16 = OutU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutU16_NativeFunctionPtr, (void*)ptr);
			OutU16 = ptr->OutU16;
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x0010705C File Offset: 0x0010525C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Set(ref TSet<sbyte> OutI8Set)
		{
			UTestClass_UFunction_Base.__OutI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = OutI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> tset2 = OutI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x001070D4 File Offset: 0x001052D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Map(ref TMap<sbyte, int> OutI8Map)
		{
			UTestClass_UFunction_Base.__OutI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = OutI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> tmap2 = OutI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B004 RID: 45060 RVA: 0x0010714C File Offset: 0x0010534C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Array(ref TArray<sbyte> OutI8Array)
		{
			UTestClass_UFunction_Base.__OutI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = OutI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> tarray2 = OutI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B005 RID: 45061 RVA: 0x001071C4 File Offset: 0x001053C4
		[SkipLocalsInit]
		public unsafe void OutI8(ref sbyte OutI8)
		{
			UTestClass_UFunction_Base.__OutI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI8 = OutI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI8_NativeFunctionPtr, (void*)ptr);
			OutI8 = ptr->OutI8;
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x00107214 File Offset: 0x00105414
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Set(ref TSet<long> OutI64Set)
		{
			UTestClass_UFunction_Base.__OutI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = OutI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> tset2 = OutI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B007 RID: 45063 RVA: 0x0010728C File Offset: 0x0010548C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Map(ref TMap<long, int> OutI64Map)
		{
			UTestClass_UFunction_Base.__OutI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = OutI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> tmap2 = OutI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x00107304 File Offset: 0x00105504
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Array(ref TArray<long> OutI64Array)
		{
			UTestClass_UFunction_Base.__OutI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = OutI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = OutI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x0010737C File Offset: 0x0010557C
		[SkipLocalsInit]
		public unsafe void OutI64(ref long OutI64)
		{
			UTestClass_UFunction_Base.__OutI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI64 = OutI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI64_NativeFunctionPtr, (void*)ptr);
			OutI64 = ptr->OutI64;
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x001073CC File Offset: 0x001055CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Set(ref TSet<int> OutI32Set)
		{
			UTestClass_UFunction_Base.__OutI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = OutI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> tset2 = OutI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B00B RID: 45067 RVA: 0x00107444 File Offset: 0x00105644
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Map(ref TMap<int, int> OutI32Map)
		{
			UTestClass_UFunction_Base.__OutI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = OutI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = OutI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x001074BC File Offset: 0x001056BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Array(ref TArray<int> OutI32Array)
		{
			UTestClass_UFunction_Base.__OutI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = OutI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x00107534 File Offset: 0x00105734
		[SkipLocalsInit]
		public unsafe void OutI32(ref int OutI32)
		{
			UTestClass_UFunction_Base.__OutI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI32 = OutI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI32_NativeFunctionPtr, (void*)ptr);
			OutI32 = ptr->OutI32;
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x00107584 File Offset: 0x00105784
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Set(ref TSet<short> OutI16Set)
		{
			UTestClass_UFunction_Base.__OutI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = OutI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> tset2 = OutI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x001075FC File Offset: 0x001057FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Map(ref TMap<short, int> OutI16Map)
		{
			UTestClass_UFunction_Base.__OutI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = OutI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> tmap2 = OutI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B010 RID: 45072 RVA: 0x00107674 File Offset: 0x00105874
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Array(ref TArray<short> OutI16Array)
		{
			UTestClass_UFunction_Base.__OutI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = OutI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> tarray2 = OutI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B011 RID: 45073 RVA: 0x001076EC File Offset: 0x001058EC
		[SkipLocalsInit]
		public unsafe void OutI16(ref short OutI16)
		{
			UTestClass_UFunction_Base.__OutI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI16 = OutI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutI16_NativeFunctionPtr, (void*)ptr);
			OutI16 = ptr->OutI16;
		}

		// Token: 0x0600B012 RID: 45074 RVA: 0x0010773C File Offset: 0x0010593C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Set(ref TSet<double> OutF64Set)
		{
			UTestClass_UFunction_Base.__OutF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = OutF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> tset2 = OutF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x001077B4 File Offset: 0x001059B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Map(ref TMap<double, int> OutF64Map)
		{
			UTestClass_UFunction_Base.__OutF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = OutF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> tmap2 = OutF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x0010782C File Offset: 0x00105A2C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Array(ref TArray<double> OutF64Array)
		{
			UTestClass_UFunction_Base.__OutF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = OutF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> tarray2 = OutF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x001078A4 File Offset: 0x00105AA4
		[SkipLocalsInit]
		public unsafe void OutF64(ref double OutF64)
		{
			UTestClass_UFunction_Base.__OutF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF64 = OutF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF64_NativeFunctionPtr, (void*)ptr);
			OutF64 = ptr->OutF64;
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x001078F4 File Offset: 0x00105AF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Set(ref TSet<float> OutF32Set)
		{
			UTestClass_UFunction_Base.__OutF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = OutF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> tset2 = OutF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x0010796C File Offset: 0x00105B6C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Map(ref TMap<float, int> OutF32Map)
		{
			UTestClass_UFunction_Base.__OutF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = OutF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> tmap2 = OutF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x001079E4 File Offset: 0x00105BE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Array(ref TArray<float> OutF32Array)
		{
			UTestClass_UFunction_Base.__OutF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = OutF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> tarray2 = OutF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x00107A5C File Offset: 0x00105C5C
		[SkipLocalsInit]
		public unsafe void OutF32(ref float OutF32)
		{
			UTestClass_UFunction_Base.__OutF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF32 = OutF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutF32_NativeFunctionPtr, (void*)ptr);
			OutF32 = ptr->OutF32;
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x00107AAC File Offset: 0x00105CAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolSet(ref TSet<bool> OutBoolSet)
		{
			UTestClass_UFunction_Base.__OutBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = OutBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> tset2 = OutBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x00107B24 File Offset: 0x00105D24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolMap(ref TMap<bool, int> OutBoolMap)
		{
			UTestClass_UFunction_Base.__OutBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = OutBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> tmap2 = OutBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x00107B9C File Offset: 0x00105D9C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolArray(ref TArray<bool> OutBoolArray)
		{
			UTestClass_UFunction_Base.__OutBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = OutBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = OutBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x00107C14 File Offset: 0x00105E14
		[SkipLocalsInit]
		public unsafe void OutBool(ref bool OutBool)
		{
			UTestClass_UFunction_Base.__OutBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__OutBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__OutBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutBool = OutBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__OutBool_NativeFunctionPtr, (void*)ptr);
			OutBool = ptr->OutBool;
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x00107C64 File Offset: 0x00105E64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Set(in TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Base.__InU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = InU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> tset2 = InU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x00107CDC File Offset: 0x00105EDC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Map(in TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Base.__InU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = InU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> tmap2 = InU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x00107D54 File Offset: 0x00105F54
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Array(in TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Base.__InU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = InU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> tarray2 = InU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x00107DCC File Offset: 0x00105FCC
		[SkipLocalsInit]
		public unsafe void InU8(in byte InU8)
		{
			UTestClass_UFunction_Base.__InU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x00107E14 File Offset: 0x00106014
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Set(in TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Base.__InU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = InU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> tset2 = InU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x00107E8C File Offset: 0x0010608C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Map(in TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Base.__InU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = InU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> tmap2 = InU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x00107F04 File Offset: 0x00106104
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Array(in TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Base.__InU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = InU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> tarray2 = InU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x00107F7C File Offset: 0x0010617C
		[SkipLocalsInit]
		public unsafe void InU64(in ulong InU64)
		{
			UTestClass_UFunction_Base.__InU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x00107FC4 File Offset: 0x001061C4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Set(in TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Base.__InU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = InU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> tset2 = InU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x0010803C File Offset: 0x0010623C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Map(in TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Base.__InU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = InU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> tmap2 = InU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x001080B4 File Offset: 0x001062B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Array(in TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Base.__InU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = InU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> tarray2 = InU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x0010812C File Offset: 0x0010632C
		[SkipLocalsInit]
		public unsafe void InU32(in uint InU32)
		{
			UTestClass_UFunction_Base.__InU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x00108174 File Offset: 0x00106374
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Set(in TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Base.__InU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = InU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> tset2 = InU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x001081EC File Offset: 0x001063EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Map(in TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Base.__InU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = InU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> tmap2 = InU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B02C RID: 45100 RVA: 0x00108264 File Offset: 0x00106464
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Array(in TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Base.__InU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = InU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> tarray2 = InU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x001082DC File Offset: 0x001064DC
		[SkipLocalsInit]
		public unsafe void InU16(in ushort InU16)
		{
			UTestClass_UFunction_Base.__InU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InU16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B02E RID: 45102 RVA: 0x00108324 File Offset: 0x00106524
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Set(in TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Base.__InI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = InI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> tset2 = InI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B02F RID: 45103 RVA: 0x0010839C File Offset: 0x0010659C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Map(in TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Base.__InI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = InI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> tmap2 = InI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B030 RID: 45104 RVA: 0x00108414 File Offset: 0x00106614
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Array(in TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Base.__InI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = InI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> tarray2 = InI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B031 RID: 45105 RVA: 0x0010848C File Offset: 0x0010668C
		[SkipLocalsInit]
		public unsafe void InI8(in sbyte InI8)
		{
			UTestClass_UFunction_Base.__InI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B032 RID: 45106 RVA: 0x001084D4 File Offset: 0x001066D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Set(in TSet<long> InI64Set)
		{
			UTestClass_UFunction_Base.__InI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = InI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> tset2 = InI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B033 RID: 45107 RVA: 0x0010854C File Offset: 0x0010674C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Map(in TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Base.__InI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = InI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> tmap2 = InI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B034 RID: 45108 RVA: 0x001085C4 File Offset: 0x001067C4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Array(in TArray<long> InI64Array)
		{
			UTestClass_UFunction_Base.__InI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = InI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = InI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B035 RID: 45109 RVA: 0x0010863C File Offset: 0x0010683C
		[SkipLocalsInit]
		public unsafe void InI64(in long InI64)
		{
			UTestClass_UFunction_Base.__InI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x00108684 File Offset: 0x00106884
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Set(in TSet<int> InI32Set)
		{
			UTestClass_UFunction_Base.__InI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = InI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> tset2 = InI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B037 RID: 45111 RVA: 0x001086FC File Offset: 0x001068FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Map(in TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Base.__InI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = InI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = InI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B038 RID: 45112 RVA: 0x00108774 File Offset: 0x00106974
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Array(in TArray<int> InI32Array)
		{
			UTestClass_UFunction_Base.__InI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = InI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = InI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B039 RID: 45113 RVA: 0x001087EC File Offset: 0x001069EC
		[SkipLocalsInit]
		public unsafe void InI32(in int InI32)
		{
			UTestClass_UFunction_Base.__InI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x00108834 File Offset: 0x00106A34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Set(in TSet<short> InI16Set)
		{
			UTestClass_UFunction_Base.__InI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = InI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> tset2 = InI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x001088AC File Offset: 0x00106AAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Map(in TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Base.__InI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = InI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> tmap2 = InI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x00108924 File Offset: 0x00106B24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Array(in TArray<short> InI16Array)
		{
			UTestClass_UFunction_Base.__InI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = InI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> tarray2 = InI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x0010899C File Offset: 0x00106B9C
		[SkipLocalsInit]
		public unsafe void InI16(in short InI16)
		{
			UTestClass_UFunction_Base.__InI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InI16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x001089E4 File Offset: 0x00106BE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Set(in TSet<double> InF64Set)
		{
			UTestClass_UFunction_Base.__InF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = InF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> tset2 = InF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x00108A5C File Offset: 0x00106C5C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Map(in TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Base.__InF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = InF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> tmap2 = InF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x00108AD4 File Offset: 0x00106CD4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Array(in TArray<double> InF64Array)
		{
			UTestClass_UFunction_Base.__InF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = InF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> tarray2 = InF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x00108B4C File Offset: 0x00106D4C
		[SkipLocalsInit]
		public unsafe void InF64(in double InF64)
		{
			UTestClass_UFunction_Base.__InF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x00108B94 File Offset: 0x00106D94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Set(in TSet<float> InF32Set)
		{
			UTestClass_UFunction_Base.__InF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = InF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> tset2 = InF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x00108C0C File Offset: 0x00106E0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Map(in TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Base.__InF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = InF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> tmap2 = InF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x00108C84 File Offset: 0x00106E84
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Array(in TArray<float> InF32Array)
		{
			UTestClass_UFunction_Base.__InF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = InF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> tarray2 = InF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x00108CFC File Offset: 0x00106EFC
		[SkipLocalsInit]
		public unsafe void InF32(in float InF32)
		{
			UTestClass_UFunction_Base.__InF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InF32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x00108D44 File Offset: 0x00106F44
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolSet(in TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Base.__InBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = InBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> tset2 = InBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x00108DBC File Offset: 0x00106FBC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolMap(in TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Base.__InBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = InBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> tmap2 = InBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x00108E34 File Offset: 0x00107034
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolArray(in TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Base.__InBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = InBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = InBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x00108EAC File Offset: 0x001070AC
		[SkipLocalsInit]
		public unsafe void InBool(in bool InBool)
		{
			UTestClass_UFunction_Base.__InBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__InBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__InBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__InBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__InBool_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x00108EF4 File Offset: 0x001070F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<byte> GetU8Set()
		{
			UTestClass_UFunction_Base.__GetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> result = new TSet<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x00108F54 File Offset: 0x00107154
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<byte, int> GetU8Map()
		{
			UTestClass_UFunction_Base.__GetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> result = new TMap<byte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x00108FB4 File Offset: 0x001071B4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<byte> GetU8Array()
		{
			UTestClass_UFunction_Base.__GetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> result = new TArray<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x00109014 File Offset: 0x00107214
		[SkipLocalsInit]
		public unsafe byte GetU8()
		{
			UTestClass_UFunction_Base.__GetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU8_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x0010905C File Offset: 0x0010725C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<ulong> GetU64Set()
		{
			UTestClass_UFunction_Base.__GetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> result = new TSet<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x001090BC File Offset: 0x001072BC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<ulong, int> GetU64Map()
		{
			UTestClass_UFunction_Base.__GetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> result = new TMap<ulong, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x0010911C File Offset: 0x0010731C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ulong> GetU64Array()
		{
			UTestClass_UFunction_Base.__GetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> result = new TArray<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x0010917C File Offset: 0x0010737C
		[SkipLocalsInit]
		public unsafe ulong GetU64()
		{
			UTestClass_UFunction_Base.__GetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x001091C4 File Offset: 0x001073C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<uint> GetU32Set()
		{
			UTestClass_UFunction_Base.__GetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> result = new TSet<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x00109224 File Offset: 0x00107424
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<uint, int> GetU32Map()
		{
			UTestClass_UFunction_Base.__GetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> result = new TMap<uint, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x00109284 File Offset: 0x00107484
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<uint> GetU32Array()
		{
			UTestClass_UFunction_Base.__GetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> result = new TArray<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x001092E4 File Offset: 0x001074E4
		[SkipLocalsInit]
		public unsafe uint GetU32()
		{
			UTestClass_UFunction_Base.__GetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x0010932C File Offset: 0x0010752C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<ushort> GetU16Set()
		{
			UTestClass_UFunction_Base.__GetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> result = new TSet<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x0010938C File Offset: 0x0010758C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<ushort, int> GetU16Map()
		{
			UTestClass_UFunction_Base.__GetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> result = new TMap<ushort, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x001093EC File Offset: 0x001075EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ushort> GetU16Array()
		{
			UTestClass_UFunction_Base.__GetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> result = new TArray<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x0010944C File Offset: 0x0010764C
		[SkipLocalsInit]
		public unsafe ushort GetU16()
		{
			UTestClass_UFunction_Base.__GetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetU16_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x00109494 File Offset: 0x00107694
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<sbyte> GetI8Set()
		{
			UTestClass_UFunction_Base.__GetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> result = new TSet<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x001094F4 File Offset: 0x001076F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<sbyte, int> GetI8Map()
		{
			UTestClass_UFunction_Base.__GetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> result = new TMap<sbyte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x00109554 File Offset: 0x00107754
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<sbyte> GetI8Array()
		{
			UTestClass_UFunction_Base.__GetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> result = new TArray<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x001095B4 File Offset: 0x001077B4
		[SkipLocalsInit]
		public unsafe sbyte GetI8()
		{
			UTestClass_UFunction_Base.__GetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI8_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x001095FC File Offset: 0x001077FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<long> GetI64Set()
		{
			UTestClass_UFunction_Base.__GetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> result = new TSet<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B05F RID: 45151 RVA: 0x0010965C File Offset: 0x0010785C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<long, int> GetI64Map()
		{
			UTestClass_UFunction_Base.__GetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> result = new TMap<long, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B060 RID: 45152 RVA: 0x001096BC File Offset: 0x001078BC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<long> GetI64Array()
		{
			UTestClass_UFunction_Base.__GetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> result = new TArray<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B061 RID: 45153 RVA: 0x0010971C File Offset: 0x0010791C
		[SkipLocalsInit]
		public unsafe long GetI64()
		{
			UTestClass_UFunction_Base.__GetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x00109764 File Offset: 0x00107964
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<int> GetI32Set()
		{
			UTestClass_UFunction_Base.__GetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> result = new TSet<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x001097C4 File Offset: 0x001079C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<int, int> GetI32Map()
		{
			UTestClass_UFunction_Base.__GetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> result = new TMap<int, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x00109824 File Offset: 0x00107A24
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<int> GetI32Array()
		{
			UTestClass_UFunction_Base.__GetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> result = new TArray<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x00109884 File Offset: 0x00107A84
		[SkipLocalsInit]
		public unsafe int GetI32()
		{
			UTestClass_UFunction_Base.__GetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x001098CC File Offset: 0x00107ACC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<short> GetI16Set()
		{
			UTestClass_UFunction_Base.__GetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> result = new TSet<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x0010992C File Offset: 0x00107B2C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<short, int> GetI16Map()
		{
			UTestClass_UFunction_Base.__GetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> result = new TMap<short, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x0010998C File Offset: 0x00107B8C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<short> GetI16Array()
		{
			UTestClass_UFunction_Base.__GetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> result = new TArray<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x001099EC File Offset: 0x00107BEC
		[SkipLocalsInit]
		public unsafe short GetI16()
		{
			UTestClass_UFunction_Base.__GetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetI16_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x00109A34 File Offset: 0x00107C34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<double> GetF64Set()
		{
			UTestClass_UFunction_Base.__GetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> result = new TSet<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B06B RID: 45163 RVA: 0x00109A94 File Offset: 0x00107C94
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<double, int> GetF64Map()
		{
			UTestClass_UFunction_Base.__GetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> result = new TMap<double, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x00109AF4 File Offset: 0x00107CF4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<double> GetF64Array()
		{
			UTestClass_UFunction_Base.__GetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> result = new TArray<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x00109B54 File Offset: 0x00107D54
		[SkipLocalsInit]
		public unsafe double GetF64()
		{
			UTestClass_UFunction_Base.__GetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x00109B9C File Offset: 0x00107D9C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<float> GetF32Set()
		{
			UTestClass_UFunction_Base.__GetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> result = new TSet<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x00109BFC File Offset: 0x00107DFC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<float, int> GetF32Map()
		{
			UTestClass_UFunction_Base.__GetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> result = new TMap<float, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x00109C5C File Offset: 0x00107E5C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<float> GetF32Array()
		{
			UTestClass_UFunction_Base.__GetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> result = new TArray<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x00109CBC File Offset: 0x00107EBC
		[SkipLocalsInit]
		public unsafe float GetF32()
		{
			UTestClass_UFunction_Base.__GetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetF32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x00109D04 File Offset: 0x00107F04
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<bool> GetBoolSet()
		{
			UTestClass_UFunction_Base.__GetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> result = new TSet<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x00109D64 File Offset: 0x00107F64
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<bool, int> GetBoolMap()
		{
			UTestClass_UFunction_Base.__GetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> result = new TMap<bool, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x00109DC4 File Offset: 0x00107FC4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<bool> GetBoolArray()
		{
			UTestClass_UFunction_Base.__GetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> result = new TArray<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B075 RID: 45173 RVA: 0x00109E24 File Offset: 0x00108024
		[SkipLocalsInit]
		public unsafe bool GetBool()
		{
			UTestClass_UFunction_Base.__GetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Base.__GetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Base.__GetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Base.__GetBool_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B076 RID: 45174 RVA: 0x00109E69 File Offset: 0x00108069
		static UTestClass_UFunction_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Base");
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x00109E77 File Offset: 0x00108077
		protected UTestClass_UFunction_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004C50 RID: 19536
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Base";

		// Token: 0x04004C51 RID: 19537
		private static IntPtr _ClassPtr;

		// Token: 0x04004C52 RID: 19538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004C53 RID: 19539
		internal static int __PropertyOffset_Bool;

		// Token: 0x04004C54 RID: 19540
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x04004C55 RID: 19541
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x04004C56 RID: 19542
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x04004C57 RID: 19543
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x04004C58 RID: 19544
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x04004C59 RID: 19545
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x04004C5A RID: 19546
		internal static int __PropertyOffset_I8;

		// Token: 0x04004C5B RID: 19547
		internal static int __PropertyOffset_I8Array;

		// Token: 0x04004C5C RID: 19548
		[Nullable(2)]
		private TArray<sbyte> _I8Array;

		// Token: 0x04004C5D RID: 19549
		internal static int __PropertyOffset_I8Set;

		// Token: 0x04004C5E RID: 19550
		[Nullable(2)]
		private TSet<sbyte> _I8Set;

		// Token: 0x04004C5F RID: 19551
		internal static int __PropertyOffset_I8Map;

		// Token: 0x04004C60 RID: 19552
		[Nullable(2)]
		private TMap<sbyte, int> _I8Map;

		// Token: 0x04004C61 RID: 19553
		internal static int __PropertyOffset_U8;

		// Token: 0x04004C62 RID: 19554
		internal static int __PropertyOffset_U8Array;

		// Token: 0x04004C63 RID: 19555
		[Nullable(2)]
		private TArray<byte> _U8Array;

		// Token: 0x04004C64 RID: 19556
		internal static int __PropertyOffset_U8Set;

		// Token: 0x04004C65 RID: 19557
		[Nullable(2)]
		private TSet<byte> _U8Set;

		// Token: 0x04004C66 RID: 19558
		internal static int __PropertyOffset_U8Map;

		// Token: 0x04004C67 RID: 19559
		[Nullable(2)]
		private TMap<byte, int> _U8Map;

		// Token: 0x04004C68 RID: 19560
		internal static int __PropertyOffset_I16;

		// Token: 0x04004C69 RID: 19561
		internal static int __PropertyOffset_I16Array;

		// Token: 0x04004C6A RID: 19562
		[Nullable(2)]
		private TArray<short> _I16Array;

		// Token: 0x04004C6B RID: 19563
		internal static int __PropertyOffset_I16Set;

		// Token: 0x04004C6C RID: 19564
		[Nullable(2)]
		private TSet<short> _I16Set;

		// Token: 0x04004C6D RID: 19565
		internal static int __PropertyOffset_I16Map;

		// Token: 0x04004C6E RID: 19566
		[Nullable(2)]
		private TMap<short, int> _I16Map;

		// Token: 0x04004C6F RID: 19567
		internal static int __PropertyOffset_U16;

		// Token: 0x04004C70 RID: 19568
		internal static int __PropertyOffset_U16Array;

		// Token: 0x04004C71 RID: 19569
		[Nullable(2)]
		private TArray<ushort> _U16Array;

		// Token: 0x04004C72 RID: 19570
		internal static int __PropertyOffset_U16Set;

		// Token: 0x04004C73 RID: 19571
		[Nullable(2)]
		private TSet<ushort> _U16Set;

		// Token: 0x04004C74 RID: 19572
		internal static int __PropertyOffset_U16Map;

		// Token: 0x04004C75 RID: 19573
		[Nullable(2)]
		private TMap<ushort, int> _U16Map;

		// Token: 0x04004C76 RID: 19574
		internal static int __PropertyOffset_I32;

		// Token: 0x04004C77 RID: 19575
		internal static int __PropertyOffset_I32Array;

		// Token: 0x04004C78 RID: 19576
		[Nullable(2)]
		private TArray<int> _I32Array;

		// Token: 0x04004C79 RID: 19577
		internal static int __PropertyOffset_I32Set;

		// Token: 0x04004C7A RID: 19578
		[Nullable(2)]
		private TSet<int> _I32Set;

		// Token: 0x04004C7B RID: 19579
		internal static int __PropertyOffset_I32Map;

		// Token: 0x04004C7C RID: 19580
		[Nullable(2)]
		private TMap<int, int> _I32Map;

		// Token: 0x04004C7D RID: 19581
		internal static int __PropertyOffset_U32;

		// Token: 0x04004C7E RID: 19582
		internal static int __PropertyOffset_U32Array;

		// Token: 0x04004C7F RID: 19583
		[Nullable(2)]
		private TArray<uint> _U32Array;

		// Token: 0x04004C80 RID: 19584
		internal static int __PropertyOffset_U32Set;

		// Token: 0x04004C81 RID: 19585
		[Nullable(2)]
		private TSet<uint> _U32Set;

		// Token: 0x04004C82 RID: 19586
		internal static int __PropertyOffset_U32Map;

		// Token: 0x04004C83 RID: 19587
		[Nullable(2)]
		private TMap<uint, int> _U32Map;

		// Token: 0x04004C84 RID: 19588
		internal static int __PropertyOffset_I64;

		// Token: 0x04004C85 RID: 19589
		internal static int __PropertyOffset_I64Array;

		// Token: 0x04004C86 RID: 19590
		[Nullable(2)]
		private TArray<long> _I64Array;

		// Token: 0x04004C87 RID: 19591
		internal static int __PropertyOffset_I64Set;

		// Token: 0x04004C88 RID: 19592
		[Nullable(2)]
		private TSet<long> _I64Set;

		// Token: 0x04004C89 RID: 19593
		internal static int __PropertyOffset_I64Map;

		// Token: 0x04004C8A RID: 19594
		[Nullable(2)]
		private TMap<long, int> _I64Map;

		// Token: 0x04004C8B RID: 19595
		internal static int __PropertyOffset_U64;

		// Token: 0x04004C8C RID: 19596
		internal static int __PropertyOffset_U64Array;

		// Token: 0x04004C8D RID: 19597
		[Nullable(2)]
		private TArray<ulong> _U64Array;

		// Token: 0x04004C8E RID: 19598
		internal static int __PropertyOffset_U64Set;

		// Token: 0x04004C8F RID: 19599
		[Nullable(2)]
		private TSet<ulong> _U64Set;

		// Token: 0x04004C90 RID: 19600
		internal static int __PropertyOffset_U64Map;

		// Token: 0x04004C91 RID: 19601
		[Nullable(2)]
		private TMap<ulong, int> _U64Map;

		// Token: 0x04004C92 RID: 19602
		internal static int __PropertyOffset_F32;

		// Token: 0x04004C93 RID: 19603
		internal static int __PropertyOffset_F32Array;

		// Token: 0x04004C94 RID: 19604
		[Nullable(2)]
		private TArray<float> _F32Array;

		// Token: 0x04004C95 RID: 19605
		internal static int __PropertyOffset_F32Set;

		// Token: 0x04004C96 RID: 19606
		[Nullable(2)]
		private TSet<float> _F32Set;

		// Token: 0x04004C97 RID: 19607
		internal static int __PropertyOffset_F32Map;

		// Token: 0x04004C98 RID: 19608
		[Nullable(2)]
		private TMap<float, int> _F32Map;

		// Token: 0x04004C99 RID: 19609
		internal static int __PropertyOffset_F64;

		// Token: 0x04004C9A RID: 19610
		internal static int __PropertyOffset_F64Array;

		// Token: 0x04004C9B RID: 19611
		[Nullable(2)]
		private TArray<double> _F64Array;

		// Token: 0x04004C9C RID: 19612
		internal static int __PropertyOffset_F64Set;

		// Token: 0x04004C9D RID: 19613
		[Nullable(2)]
		private TSet<double> _F64Set;

		// Token: 0x04004C9E RID: 19614
		internal static int __PropertyOffset_F64Map;

		// Token: 0x04004C9F RID: 19615
		[Nullable(2)]
		private TMap<double, int> _F64Map;

		// Token: 0x04004CA0 RID: 19616
		private static IntPtr __SetU8Set_NativeFunctionPtr;

		// Token: 0x04004CA1 RID: 19617
		private static IntPtr __SetU8Map_NativeFunctionPtr;

		// Token: 0x04004CA2 RID: 19618
		private static IntPtr __SetU8Array_NativeFunctionPtr;

		// Token: 0x04004CA3 RID: 19619
		private static IntPtr __SetU8_NativeFunctionPtr;

		// Token: 0x04004CA4 RID: 19620
		private static IntPtr __SetU64Set_NativeFunctionPtr;

		// Token: 0x04004CA5 RID: 19621
		private static IntPtr __SetU64Map_NativeFunctionPtr;

		// Token: 0x04004CA6 RID: 19622
		private static IntPtr __SetU64Array_NativeFunctionPtr;

		// Token: 0x04004CA7 RID: 19623
		private static IntPtr __SetU64_NativeFunctionPtr;

		// Token: 0x04004CA8 RID: 19624
		private static IntPtr __SetU32Set_NativeFunctionPtr;

		// Token: 0x04004CA9 RID: 19625
		private static IntPtr __SetU32Map_NativeFunctionPtr;

		// Token: 0x04004CAA RID: 19626
		private static IntPtr __SetU32Array_NativeFunctionPtr;

		// Token: 0x04004CAB RID: 19627
		private static IntPtr __SetU32_NativeFunctionPtr;

		// Token: 0x04004CAC RID: 19628
		private static IntPtr __SetU16Set_NativeFunctionPtr;

		// Token: 0x04004CAD RID: 19629
		private static IntPtr __SetU16Map_NativeFunctionPtr;

		// Token: 0x04004CAE RID: 19630
		private static IntPtr __SetU16Array_NativeFunctionPtr;

		// Token: 0x04004CAF RID: 19631
		private static IntPtr __SetU16_NativeFunctionPtr;

		// Token: 0x04004CB0 RID: 19632
		private static IntPtr __SetI8Set_NativeFunctionPtr;

		// Token: 0x04004CB1 RID: 19633
		private static IntPtr __SetI8Map_NativeFunctionPtr;

		// Token: 0x04004CB2 RID: 19634
		private static IntPtr __SetI8Array_NativeFunctionPtr;

		// Token: 0x04004CB3 RID: 19635
		private static IntPtr __SetI8_NativeFunctionPtr;

		// Token: 0x04004CB4 RID: 19636
		private static IntPtr __SetI64Set_NativeFunctionPtr;

		// Token: 0x04004CB5 RID: 19637
		private static IntPtr __SetI64Map_NativeFunctionPtr;

		// Token: 0x04004CB6 RID: 19638
		private static IntPtr __SetI64Array_NativeFunctionPtr;

		// Token: 0x04004CB7 RID: 19639
		private static IntPtr __SetI64_NativeFunctionPtr;

		// Token: 0x04004CB8 RID: 19640
		private static IntPtr __SetI32Set_NativeFunctionPtr;

		// Token: 0x04004CB9 RID: 19641
		private static IntPtr __SetI32Map_NativeFunctionPtr;

		// Token: 0x04004CBA RID: 19642
		private static IntPtr __SetI32Array_NativeFunctionPtr;

		// Token: 0x04004CBB RID: 19643
		private static IntPtr __SetI32_NativeFunctionPtr;

		// Token: 0x04004CBC RID: 19644
		private static IntPtr __SetI16Set_NativeFunctionPtr;

		// Token: 0x04004CBD RID: 19645
		private static IntPtr __SetI16Map_NativeFunctionPtr;

		// Token: 0x04004CBE RID: 19646
		private static IntPtr __SetI16Array_NativeFunctionPtr;

		// Token: 0x04004CBF RID: 19647
		private static IntPtr __SetI16_NativeFunctionPtr;

		// Token: 0x04004CC0 RID: 19648
		private static IntPtr __SetF64Set_NativeFunctionPtr;

		// Token: 0x04004CC1 RID: 19649
		private static IntPtr __SetF64Map_NativeFunctionPtr;

		// Token: 0x04004CC2 RID: 19650
		private static IntPtr __SetF64Array_NativeFunctionPtr;

		// Token: 0x04004CC3 RID: 19651
		private static IntPtr __SetF64_NativeFunctionPtr;

		// Token: 0x04004CC4 RID: 19652
		private static IntPtr __SetF32Set_NativeFunctionPtr;

		// Token: 0x04004CC5 RID: 19653
		private static IntPtr __SetF32Map_NativeFunctionPtr;

		// Token: 0x04004CC6 RID: 19654
		private static IntPtr __SetF32Array_NativeFunctionPtr;

		// Token: 0x04004CC7 RID: 19655
		private static IntPtr __SetF32_NativeFunctionPtr;

		// Token: 0x04004CC8 RID: 19656
		private static IntPtr __SetBoolSet_NativeFunctionPtr;

		// Token: 0x04004CC9 RID: 19657
		private static IntPtr __SetBoolMap_NativeFunctionPtr;

		// Token: 0x04004CCA RID: 19658
		private static IntPtr __SetBoolArray_NativeFunctionPtr;

		// Token: 0x04004CCB RID: 19659
		private static IntPtr __SetBool_NativeFunctionPtr;

		// Token: 0x04004CCC RID: 19660
		private static IntPtr __OutU8Set_NativeFunctionPtr;

		// Token: 0x04004CCD RID: 19661
		private static IntPtr __OutU8Map_NativeFunctionPtr;

		// Token: 0x04004CCE RID: 19662
		private static IntPtr __OutU8Array_NativeFunctionPtr;

		// Token: 0x04004CCF RID: 19663
		private static IntPtr __OutU8_NativeFunctionPtr;

		// Token: 0x04004CD0 RID: 19664
		private static IntPtr __OutU64Set_NativeFunctionPtr;

		// Token: 0x04004CD1 RID: 19665
		private static IntPtr __OutU64Map_NativeFunctionPtr;

		// Token: 0x04004CD2 RID: 19666
		private static IntPtr __OutU64Array_NativeFunctionPtr;

		// Token: 0x04004CD3 RID: 19667
		private static IntPtr __OutU64_NativeFunctionPtr;

		// Token: 0x04004CD4 RID: 19668
		private static IntPtr __OutU32Set_NativeFunctionPtr;

		// Token: 0x04004CD5 RID: 19669
		private static IntPtr __OutU32Map_NativeFunctionPtr;

		// Token: 0x04004CD6 RID: 19670
		private static IntPtr __OutU32Array_NativeFunctionPtr;

		// Token: 0x04004CD7 RID: 19671
		private static IntPtr __OutU32_NativeFunctionPtr;

		// Token: 0x04004CD8 RID: 19672
		private static IntPtr __OutU16Set_NativeFunctionPtr;

		// Token: 0x04004CD9 RID: 19673
		private static IntPtr __OutU16Map_NativeFunctionPtr;

		// Token: 0x04004CDA RID: 19674
		private static IntPtr __OutU16Array_NativeFunctionPtr;

		// Token: 0x04004CDB RID: 19675
		private static IntPtr __OutU16_NativeFunctionPtr;

		// Token: 0x04004CDC RID: 19676
		private static IntPtr __OutI8Set_NativeFunctionPtr;

		// Token: 0x04004CDD RID: 19677
		private static IntPtr __OutI8Map_NativeFunctionPtr;

		// Token: 0x04004CDE RID: 19678
		private static IntPtr __OutI8Array_NativeFunctionPtr;

		// Token: 0x04004CDF RID: 19679
		private static IntPtr __OutI8_NativeFunctionPtr;

		// Token: 0x04004CE0 RID: 19680
		private static IntPtr __OutI64Set_NativeFunctionPtr;

		// Token: 0x04004CE1 RID: 19681
		private static IntPtr __OutI64Map_NativeFunctionPtr;

		// Token: 0x04004CE2 RID: 19682
		private static IntPtr __OutI64Array_NativeFunctionPtr;

		// Token: 0x04004CE3 RID: 19683
		private static IntPtr __OutI64_NativeFunctionPtr;

		// Token: 0x04004CE4 RID: 19684
		private static IntPtr __OutI32Set_NativeFunctionPtr;

		// Token: 0x04004CE5 RID: 19685
		private static IntPtr __OutI32Map_NativeFunctionPtr;

		// Token: 0x04004CE6 RID: 19686
		private static IntPtr __OutI32Array_NativeFunctionPtr;

		// Token: 0x04004CE7 RID: 19687
		private static IntPtr __OutI32_NativeFunctionPtr;

		// Token: 0x04004CE8 RID: 19688
		private static IntPtr __OutI16Set_NativeFunctionPtr;

		// Token: 0x04004CE9 RID: 19689
		private static IntPtr __OutI16Map_NativeFunctionPtr;

		// Token: 0x04004CEA RID: 19690
		private static IntPtr __OutI16Array_NativeFunctionPtr;

		// Token: 0x04004CEB RID: 19691
		private static IntPtr __OutI16_NativeFunctionPtr;

		// Token: 0x04004CEC RID: 19692
		private static IntPtr __OutF64Set_NativeFunctionPtr;

		// Token: 0x04004CED RID: 19693
		private static IntPtr __OutF64Map_NativeFunctionPtr;

		// Token: 0x04004CEE RID: 19694
		private static IntPtr __OutF64Array_NativeFunctionPtr;

		// Token: 0x04004CEF RID: 19695
		private static IntPtr __OutF64_NativeFunctionPtr;

		// Token: 0x04004CF0 RID: 19696
		private static IntPtr __OutF32Set_NativeFunctionPtr;

		// Token: 0x04004CF1 RID: 19697
		private static IntPtr __OutF32Map_NativeFunctionPtr;

		// Token: 0x04004CF2 RID: 19698
		private static IntPtr __OutF32Array_NativeFunctionPtr;

		// Token: 0x04004CF3 RID: 19699
		private static IntPtr __OutF32_NativeFunctionPtr;

		// Token: 0x04004CF4 RID: 19700
		private static IntPtr __OutBoolSet_NativeFunctionPtr;

		// Token: 0x04004CF5 RID: 19701
		private static IntPtr __OutBoolMap_NativeFunctionPtr;

		// Token: 0x04004CF6 RID: 19702
		private static IntPtr __OutBoolArray_NativeFunctionPtr;

		// Token: 0x04004CF7 RID: 19703
		private static IntPtr __OutBool_NativeFunctionPtr;

		// Token: 0x04004CF8 RID: 19704
		private static IntPtr __InU8Set_NativeFunctionPtr;

		// Token: 0x04004CF9 RID: 19705
		private static IntPtr __InU8Map_NativeFunctionPtr;

		// Token: 0x04004CFA RID: 19706
		private static IntPtr __InU8Array_NativeFunctionPtr;

		// Token: 0x04004CFB RID: 19707
		private static IntPtr __InU8_NativeFunctionPtr;

		// Token: 0x04004CFC RID: 19708
		private static IntPtr __InU64Set_NativeFunctionPtr;

		// Token: 0x04004CFD RID: 19709
		private static IntPtr __InU64Map_NativeFunctionPtr;

		// Token: 0x04004CFE RID: 19710
		private static IntPtr __InU64Array_NativeFunctionPtr;

		// Token: 0x04004CFF RID: 19711
		private static IntPtr __InU64_NativeFunctionPtr;

		// Token: 0x04004D00 RID: 19712
		private static IntPtr __InU32Set_NativeFunctionPtr;

		// Token: 0x04004D01 RID: 19713
		private static IntPtr __InU32Map_NativeFunctionPtr;

		// Token: 0x04004D02 RID: 19714
		private static IntPtr __InU32Array_NativeFunctionPtr;

		// Token: 0x04004D03 RID: 19715
		private static IntPtr __InU32_NativeFunctionPtr;

		// Token: 0x04004D04 RID: 19716
		private static IntPtr __InU16Set_NativeFunctionPtr;

		// Token: 0x04004D05 RID: 19717
		private static IntPtr __InU16Map_NativeFunctionPtr;

		// Token: 0x04004D06 RID: 19718
		private static IntPtr __InU16Array_NativeFunctionPtr;

		// Token: 0x04004D07 RID: 19719
		private static IntPtr __InU16_NativeFunctionPtr;

		// Token: 0x04004D08 RID: 19720
		private static IntPtr __InI8Set_NativeFunctionPtr;

		// Token: 0x04004D09 RID: 19721
		private static IntPtr __InI8Map_NativeFunctionPtr;

		// Token: 0x04004D0A RID: 19722
		private static IntPtr __InI8Array_NativeFunctionPtr;

		// Token: 0x04004D0B RID: 19723
		private static IntPtr __InI8_NativeFunctionPtr;

		// Token: 0x04004D0C RID: 19724
		private static IntPtr __InI64Set_NativeFunctionPtr;

		// Token: 0x04004D0D RID: 19725
		private static IntPtr __InI64Map_NativeFunctionPtr;

		// Token: 0x04004D0E RID: 19726
		private static IntPtr __InI64Array_NativeFunctionPtr;

		// Token: 0x04004D0F RID: 19727
		private static IntPtr __InI64_NativeFunctionPtr;

		// Token: 0x04004D10 RID: 19728
		private static IntPtr __InI32Set_NativeFunctionPtr;

		// Token: 0x04004D11 RID: 19729
		private static IntPtr __InI32Map_NativeFunctionPtr;

		// Token: 0x04004D12 RID: 19730
		private static IntPtr __InI32Array_NativeFunctionPtr;

		// Token: 0x04004D13 RID: 19731
		private static IntPtr __InI32_NativeFunctionPtr;

		// Token: 0x04004D14 RID: 19732
		private static IntPtr __InI16Set_NativeFunctionPtr;

		// Token: 0x04004D15 RID: 19733
		private static IntPtr __InI16Map_NativeFunctionPtr;

		// Token: 0x04004D16 RID: 19734
		private static IntPtr __InI16Array_NativeFunctionPtr;

		// Token: 0x04004D17 RID: 19735
		private static IntPtr __InI16_NativeFunctionPtr;

		// Token: 0x04004D18 RID: 19736
		private static IntPtr __InF64Set_NativeFunctionPtr;

		// Token: 0x04004D19 RID: 19737
		private static IntPtr __InF64Map_NativeFunctionPtr;

		// Token: 0x04004D1A RID: 19738
		private static IntPtr __InF64Array_NativeFunctionPtr;

		// Token: 0x04004D1B RID: 19739
		private static IntPtr __InF64_NativeFunctionPtr;

		// Token: 0x04004D1C RID: 19740
		private static IntPtr __InF32Set_NativeFunctionPtr;

		// Token: 0x04004D1D RID: 19741
		private static IntPtr __InF32Map_NativeFunctionPtr;

		// Token: 0x04004D1E RID: 19742
		private static IntPtr __InF32Array_NativeFunctionPtr;

		// Token: 0x04004D1F RID: 19743
		private static IntPtr __InF32_NativeFunctionPtr;

		// Token: 0x04004D20 RID: 19744
		private static IntPtr __InBoolSet_NativeFunctionPtr;

		// Token: 0x04004D21 RID: 19745
		private static IntPtr __InBoolMap_NativeFunctionPtr;

		// Token: 0x04004D22 RID: 19746
		private static IntPtr __InBoolArray_NativeFunctionPtr;

		// Token: 0x04004D23 RID: 19747
		private static IntPtr __InBool_NativeFunctionPtr;

		// Token: 0x04004D24 RID: 19748
		private static IntPtr __GetU8Set_NativeFunctionPtr;

		// Token: 0x04004D25 RID: 19749
		private static IntPtr __GetU8Map_NativeFunctionPtr;

		// Token: 0x04004D26 RID: 19750
		private static IntPtr __GetU8Array_NativeFunctionPtr;

		// Token: 0x04004D27 RID: 19751
		private static IntPtr __GetU8_NativeFunctionPtr;

		// Token: 0x04004D28 RID: 19752
		private static IntPtr __GetU64Set_NativeFunctionPtr;

		// Token: 0x04004D29 RID: 19753
		private static IntPtr __GetU64Map_NativeFunctionPtr;

		// Token: 0x04004D2A RID: 19754
		private static IntPtr __GetU64Array_NativeFunctionPtr;

		// Token: 0x04004D2B RID: 19755
		private static IntPtr __GetU64_NativeFunctionPtr;

		// Token: 0x04004D2C RID: 19756
		private static IntPtr __GetU32Set_NativeFunctionPtr;

		// Token: 0x04004D2D RID: 19757
		private static IntPtr __GetU32Map_NativeFunctionPtr;

		// Token: 0x04004D2E RID: 19758
		private static IntPtr __GetU32Array_NativeFunctionPtr;

		// Token: 0x04004D2F RID: 19759
		private static IntPtr __GetU32_NativeFunctionPtr;

		// Token: 0x04004D30 RID: 19760
		private static IntPtr __GetU16Set_NativeFunctionPtr;

		// Token: 0x04004D31 RID: 19761
		private static IntPtr __GetU16Map_NativeFunctionPtr;

		// Token: 0x04004D32 RID: 19762
		private static IntPtr __GetU16Array_NativeFunctionPtr;

		// Token: 0x04004D33 RID: 19763
		private static IntPtr __GetU16_NativeFunctionPtr;

		// Token: 0x04004D34 RID: 19764
		private static IntPtr __GetI8Set_NativeFunctionPtr;

		// Token: 0x04004D35 RID: 19765
		private static IntPtr __GetI8Map_NativeFunctionPtr;

		// Token: 0x04004D36 RID: 19766
		private static IntPtr __GetI8Array_NativeFunctionPtr;

		// Token: 0x04004D37 RID: 19767
		private static IntPtr __GetI8_NativeFunctionPtr;

		// Token: 0x04004D38 RID: 19768
		private static IntPtr __GetI64Set_NativeFunctionPtr;

		// Token: 0x04004D39 RID: 19769
		private static IntPtr __GetI64Map_NativeFunctionPtr;

		// Token: 0x04004D3A RID: 19770
		private static IntPtr __GetI64Array_NativeFunctionPtr;

		// Token: 0x04004D3B RID: 19771
		private static IntPtr __GetI64_NativeFunctionPtr;

		// Token: 0x04004D3C RID: 19772
		private static IntPtr __GetI32Set_NativeFunctionPtr;

		// Token: 0x04004D3D RID: 19773
		private static IntPtr __GetI32Map_NativeFunctionPtr;

		// Token: 0x04004D3E RID: 19774
		private static IntPtr __GetI32Array_NativeFunctionPtr;

		// Token: 0x04004D3F RID: 19775
		private static IntPtr __GetI32_NativeFunctionPtr;

		// Token: 0x04004D40 RID: 19776
		private static IntPtr __GetI16Set_NativeFunctionPtr;

		// Token: 0x04004D41 RID: 19777
		private static IntPtr __GetI16Map_NativeFunctionPtr;

		// Token: 0x04004D42 RID: 19778
		private static IntPtr __GetI16Array_NativeFunctionPtr;

		// Token: 0x04004D43 RID: 19779
		private static IntPtr __GetI16_NativeFunctionPtr;

		// Token: 0x04004D44 RID: 19780
		private static IntPtr __GetF64Set_NativeFunctionPtr;

		// Token: 0x04004D45 RID: 19781
		private static IntPtr __GetF64Map_NativeFunctionPtr;

		// Token: 0x04004D46 RID: 19782
		private static IntPtr __GetF64Array_NativeFunctionPtr;

		// Token: 0x04004D47 RID: 19783
		private static IntPtr __GetF64_NativeFunctionPtr;

		// Token: 0x04004D48 RID: 19784
		private static IntPtr __GetF32Set_NativeFunctionPtr;

		// Token: 0x04004D49 RID: 19785
		private static IntPtr __GetF32Map_NativeFunctionPtr;

		// Token: 0x04004D4A RID: 19786
		private static IntPtr __GetF32Array_NativeFunctionPtr;

		// Token: 0x04004D4B RID: 19787
		private static IntPtr __GetF32_NativeFunctionPtr;

		// Token: 0x04004D4C RID: 19788
		private static IntPtr __GetBoolSet_NativeFunctionPtr;

		// Token: 0x04004D4D RID: 19789
		private static IntPtr __GetBoolMap_NativeFunctionPtr;

		// Token: 0x04004D4E RID: 19790
		private static IntPtr __GetBoolArray_NativeFunctionPtr;

		// Token: 0x04004D4F RID: 19791
		private static IntPtr __GetBool_NativeFunctionPtr;

		// Token: 0x02000FA5 RID: 4005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Set_FunctionParams
		{
			// Token: 0x040063AD RID: 25517
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x02000FA6 RID: 4006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Map_FunctionParams
		{
			// Token: 0x040063AE RID: 25518
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x02000FA7 RID: 4007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU8Array_FunctionParams
		{
			// Token: 0x040063AF RID: 25519
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x02000FA8 RID: 4008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetU8_FunctionParams
		{
			// Token: 0x040063B0 RID: 25520
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x02000FA9 RID: 4009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Set_FunctionParams
		{
			// Token: 0x040063B1 RID: 25521
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x02000FAA RID: 4010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Map_FunctionParams
		{
			// Token: 0x040063B2 RID: 25522
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x02000FAB RID: 4011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU64Array_FunctionParams
		{
			// Token: 0x040063B3 RID: 25523
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x02000FAC RID: 4012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetU64_FunctionParams
		{
			// Token: 0x040063B4 RID: 25524
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x02000FAD RID: 4013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Set_FunctionParams
		{
			// Token: 0x040063B5 RID: 25525
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x02000FAE RID: 4014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Map_FunctionParams
		{
			// Token: 0x040063B6 RID: 25526
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x02000FAF RID: 4015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU32Array_FunctionParams
		{
			// Token: 0x040063B7 RID: 25527
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x02000FB0 RID: 4016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetU32_FunctionParams
		{
			// Token: 0x040063B8 RID: 25528
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x02000FB1 RID: 4017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Set_FunctionParams
		{
			// Token: 0x040063B9 RID: 25529
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x02000FB2 RID: 4018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Map_FunctionParams
		{
			// Token: 0x040063BA RID: 25530
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x02000FB3 RID: 4019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU16Array_FunctionParams
		{
			// Token: 0x040063BB RID: 25531
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x02000FB4 RID: 4020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetU16_FunctionParams
		{
			// Token: 0x040063BC RID: 25532
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x02000FB5 RID: 4021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Set_FunctionParams
		{
			// Token: 0x040063BD RID: 25533
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x02000FB6 RID: 4022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Map_FunctionParams
		{
			// Token: 0x040063BE RID: 25534
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x02000FB7 RID: 4023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI8Array_FunctionParams
		{
			// Token: 0x040063BF RID: 25535
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x02000FB8 RID: 4024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetI8_FunctionParams
		{
			// Token: 0x040063C0 RID: 25536
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x02000FB9 RID: 4025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Set_FunctionParams
		{
			// Token: 0x040063C1 RID: 25537
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x02000FBA RID: 4026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Map_FunctionParams
		{
			// Token: 0x040063C2 RID: 25538
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x02000FBB RID: 4027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI64Array_FunctionParams
		{
			// Token: 0x040063C3 RID: 25539
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x02000FBC RID: 4028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetI64_FunctionParams
		{
			// Token: 0x040063C4 RID: 25540
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x02000FBD RID: 4029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Set_FunctionParams
		{
			// Token: 0x040063C5 RID: 25541
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x02000FBE RID: 4030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Map_FunctionParams
		{
			// Token: 0x040063C6 RID: 25542
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x02000FBF RID: 4031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI32Array_FunctionParams
		{
			// Token: 0x040063C7 RID: 25543
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x02000FC0 RID: 4032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetI32_FunctionParams
		{
			// Token: 0x040063C8 RID: 25544
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x02000FC1 RID: 4033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Set_FunctionParams
		{
			// Token: 0x040063C9 RID: 25545
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x02000FC2 RID: 4034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Map_FunctionParams
		{
			// Token: 0x040063CA RID: 25546
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x02000FC3 RID: 4035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI16Array_FunctionParams
		{
			// Token: 0x040063CB RID: 25547
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x02000FC4 RID: 4036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetI16_FunctionParams
		{
			// Token: 0x040063CC RID: 25548
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x02000FC5 RID: 4037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Set_FunctionParams
		{
			// Token: 0x040063CD RID: 25549
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x02000FC6 RID: 4038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Map_FunctionParams
		{
			// Token: 0x040063CE RID: 25550
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x02000FC7 RID: 4039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF64Array_FunctionParams
		{
			// Token: 0x040063CF RID: 25551
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x02000FC8 RID: 4040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetF64_FunctionParams
		{
			// Token: 0x040063D0 RID: 25552
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x02000FC9 RID: 4041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Set_FunctionParams
		{
			// Token: 0x040063D1 RID: 25553
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x02000FCA RID: 4042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Map_FunctionParams
		{
			// Token: 0x040063D2 RID: 25554
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x02000FCB RID: 4043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF32Array_FunctionParams
		{
			// Token: 0x040063D3 RID: 25555
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x02000FCC RID: 4044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetF32_FunctionParams
		{
			// Token: 0x040063D4 RID: 25556
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x02000FCD RID: 4045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolSet_FunctionParams
		{
			// Token: 0x040063D5 RID: 25557
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x02000FCE RID: 4046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolMap_FunctionParams
		{
			// Token: 0x040063D6 RID: 25558
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x02000FCF RID: 4047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBoolArray_FunctionParams
		{
			// Token: 0x040063D7 RID: 25559
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x02000FD0 RID: 4048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetBool_FunctionParams
		{
			// Token: 0x040063D8 RID: 25560
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02000FD1 RID: 4049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Set_FunctionParams
		{
			// Token: 0x040063D9 RID: 25561
			[FieldOffset(0)]
			public byte OutU8Set;
		}

		// Token: 0x02000FD2 RID: 4050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Map_FunctionParams
		{
			// Token: 0x040063DA RID: 25562
			[FieldOffset(0)]
			public byte OutU8Map;
		}

		// Token: 0x02000FD3 RID: 4051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU8Array_FunctionParams
		{
			// Token: 0x040063DB RID: 25563
			[FieldOffset(0)]
			public byte OutU8Array;
		}

		// Token: 0x02000FD4 RID: 4052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutU8_FunctionParams
		{
			// Token: 0x040063DC RID: 25564
			[FieldOffset(0)]
			public byte OutU8;
		}

		// Token: 0x02000FD5 RID: 4053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Set_FunctionParams
		{
			// Token: 0x040063DD RID: 25565
			[FieldOffset(0)]
			public byte OutU64Set;
		}

		// Token: 0x02000FD6 RID: 4054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Map_FunctionParams
		{
			// Token: 0x040063DE RID: 25566
			[FieldOffset(0)]
			public byte OutU64Map;
		}

		// Token: 0x02000FD7 RID: 4055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU64Array_FunctionParams
		{
			// Token: 0x040063DF RID: 25567
			[FieldOffset(0)]
			public byte OutU64Array;
		}

		// Token: 0x02000FD8 RID: 4056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutU64_FunctionParams
		{
			// Token: 0x040063E0 RID: 25568
			[FieldOffset(0)]
			public ulong OutU64;
		}

		// Token: 0x02000FD9 RID: 4057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Set_FunctionParams
		{
			// Token: 0x040063E1 RID: 25569
			[FieldOffset(0)]
			public byte OutU32Set;
		}

		// Token: 0x02000FDA RID: 4058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Map_FunctionParams
		{
			// Token: 0x040063E2 RID: 25570
			[FieldOffset(0)]
			public byte OutU32Map;
		}

		// Token: 0x02000FDB RID: 4059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU32Array_FunctionParams
		{
			// Token: 0x040063E3 RID: 25571
			[FieldOffset(0)]
			public byte OutU32Array;
		}

		// Token: 0x02000FDC RID: 4060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutU32_FunctionParams
		{
			// Token: 0x040063E4 RID: 25572
			[FieldOffset(0)]
			public uint OutU32;
		}

		// Token: 0x02000FDD RID: 4061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Set_FunctionParams
		{
			// Token: 0x040063E5 RID: 25573
			[FieldOffset(0)]
			public byte OutU16Set;
		}

		// Token: 0x02000FDE RID: 4062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Map_FunctionParams
		{
			// Token: 0x040063E6 RID: 25574
			[FieldOffset(0)]
			public byte OutU16Map;
		}

		// Token: 0x02000FDF RID: 4063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU16Array_FunctionParams
		{
			// Token: 0x040063E7 RID: 25575
			[FieldOffset(0)]
			public byte OutU16Array;
		}

		// Token: 0x02000FE0 RID: 4064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutU16_FunctionParams
		{
			// Token: 0x040063E8 RID: 25576
			[FieldOffset(0)]
			public ushort OutU16;
		}

		// Token: 0x02000FE1 RID: 4065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Set_FunctionParams
		{
			// Token: 0x040063E9 RID: 25577
			[FieldOffset(0)]
			public byte OutI8Set;
		}

		// Token: 0x02000FE2 RID: 4066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Map_FunctionParams
		{
			// Token: 0x040063EA RID: 25578
			[FieldOffset(0)]
			public byte OutI8Map;
		}

		// Token: 0x02000FE3 RID: 4067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI8Array_FunctionParams
		{
			// Token: 0x040063EB RID: 25579
			[FieldOffset(0)]
			public byte OutI8Array;
		}

		// Token: 0x02000FE4 RID: 4068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutI8_FunctionParams
		{
			// Token: 0x040063EC RID: 25580
			[FieldOffset(0)]
			public sbyte OutI8;
		}

		// Token: 0x02000FE5 RID: 4069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Set_FunctionParams
		{
			// Token: 0x040063ED RID: 25581
			[FieldOffset(0)]
			public byte OutI64Set;
		}

		// Token: 0x02000FE6 RID: 4070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Map_FunctionParams
		{
			// Token: 0x040063EE RID: 25582
			[FieldOffset(0)]
			public byte OutI64Map;
		}

		// Token: 0x02000FE7 RID: 4071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI64Array_FunctionParams
		{
			// Token: 0x040063EF RID: 25583
			[FieldOffset(0)]
			public byte OutI64Array;
		}

		// Token: 0x02000FE8 RID: 4072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutI64_FunctionParams
		{
			// Token: 0x040063F0 RID: 25584
			[FieldOffset(0)]
			public long OutI64;
		}

		// Token: 0x02000FE9 RID: 4073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Set_FunctionParams
		{
			// Token: 0x040063F1 RID: 25585
			[FieldOffset(0)]
			public byte OutI32Set;
		}

		// Token: 0x02000FEA RID: 4074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Map_FunctionParams
		{
			// Token: 0x040063F2 RID: 25586
			[FieldOffset(0)]
			public byte OutI32Map;
		}

		// Token: 0x02000FEB RID: 4075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI32Array_FunctionParams
		{
			// Token: 0x040063F3 RID: 25587
			[FieldOffset(0)]
			public byte OutI32Array;
		}

		// Token: 0x02000FEC RID: 4076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutI32_FunctionParams
		{
			// Token: 0x040063F4 RID: 25588
			[FieldOffset(0)]
			public int OutI32;
		}

		// Token: 0x02000FED RID: 4077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Set_FunctionParams
		{
			// Token: 0x040063F5 RID: 25589
			[FieldOffset(0)]
			public byte OutI16Set;
		}

		// Token: 0x02000FEE RID: 4078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Map_FunctionParams
		{
			// Token: 0x040063F6 RID: 25590
			[FieldOffset(0)]
			public byte OutI16Map;
		}

		// Token: 0x02000FEF RID: 4079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI16Array_FunctionParams
		{
			// Token: 0x040063F7 RID: 25591
			[FieldOffset(0)]
			public byte OutI16Array;
		}

		// Token: 0x02000FF0 RID: 4080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutI16_FunctionParams
		{
			// Token: 0x040063F8 RID: 25592
			[FieldOffset(0)]
			public short OutI16;
		}

		// Token: 0x02000FF1 RID: 4081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Set_FunctionParams
		{
			// Token: 0x040063F9 RID: 25593
			[FieldOffset(0)]
			public byte OutF64Set;
		}

		// Token: 0x02000FF2 RID: 4082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Map_FunctionParams
		{
			// Token: 0x040063FA RID: 25594
			[FieldOffset(0)]
			public byte OutF64Map;
		}

		// Token: 0x02000FF3 RID: 4083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF64Array_FunctionParams
		{
			// Token: 0x040063FB RID: 25595
			[FieldOffset(0)]
			public byte OutF64Array;
		}

		// Token: 0x02000FF4 RID: 4084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutF64_FunctionParams
		{
			// Token: 0x040063FC RID: 25596
			[FieldOffset(0)]
			public double OutF64;
		}

		// Token: 0x02000FF5 RID: 4085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Set_FunctionParams
		{
			// Token: 0x040063FD RID: 25597
			[FieldOffset(0)]
			public byte OutF32Set;
		}

		// Token: 0x02000FF6 RID: 4086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Map_FunctionParams
		{
			// Token: 0x040063FE RID: 25598
			[FieldOffset(0)]
			public byte OutF32Map;
		}

		// Token: 0x02000FF7 RID: 4087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF32Array_FunctionParams
		{
			// Token: 0x040063FF RID: 25599
			[FieldOffset(0)]
			public byte OutF32Array;
		}

		// Token: 0x02000FF8 RID: 4088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutF32_FunctionParams
		{
			// Token: 0x04006400 RID: 25600
			[FieldOffset(0)]
			public float OutF32;
		}

		// Token: 0x02000FF9 RID: 4089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolSet_FunctionParams
		{
			// Token: 0x04006401 RID: 25601
			[FieldOffset(0)]
			public byte OutBoolSet;
		}

		// Token: 0x02000FFA RID: 4090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolMap_FunctionParams
		{
			// Token: 0x04006402 RID: 25602
			[FieldOffset(0)]
			public byte OutBoolMap;
		}

		// Token: 0x02000FFB RID: 4091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutBoolArray_FunctionParams
		{
			// Token: 0x04006403 RID: 25603
			[FieldOffset(0)]
			public byte OutBoolArray;
		}

		// Token: 0x02000FFC RID: 4092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutBool_FunctionParams
		{
			// Token: 0x04006404 RID: 25604
			[FieldOffset(0)]
			public bool OutBool;
		}

		// Token: 0x02000FFD RID: 4093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Set_FunctionParams
		{
			// Token: 0x04006405 RID: 25605
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x02000FFE RID: 4094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Map_FunctionParams
		{
			// Token: 0x04006406 RID: 25606
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x02000FFF RID: 4095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU8Array_FunctionParams
		{
			// Token: 0x04006407 RID: 25607
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x02001000 RID: 4096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InU8_FunctionParams
		{
			// Token: 0x04006408 RID: 25608
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x02001001 RID: 4097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Set_FunctionParams
		{
			// Token: 0x04006409 RID: 25609
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x02001002 RID: 4098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Map_FunctionParams
		{
			// Token: 0x0400640A RID: 25610
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x02001003 RID: 4099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU64Array_FunctionParams
		{
			// Token: 0x0400640B RID: 25611
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x02001004 RID: 4100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InU64_FunctionParams
		{
			// Token: 0x0400640C RID: 25612
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x02001005 RID: 4101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Set_FunctionParams
		{
			// Token: 0x0400640D RID: 25613
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x02001006 RID: 4102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Map_FunctionParams
		{
			// Token: 0x0400640E RID: 25614
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x02001007 RID: 4103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU32Array_FunctionParams
		{
			// Token: 0x0400640F RID: 25615
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x02001008 RID: 4104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InU32_FunctionParams
		{
			// Token: 0x04006410 RID: 25616
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x02001009 RID: 4105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Set_FunctionParams
		{
			// Token: 0x04006411 RID: 25617
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x0200100A RID: 4106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Map_FunctionParams
		{
			// Token: 0x04006412 RID: 25618
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x0200100B RID: 4107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU16Array_FunctionParams
		{
			// Token: 0x04006413 RID: 25619
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x0200100C RID: 4108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InU16_FunctionParams
		{
			// Token: 0x04006414 RID: 25620
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x0200100D RID: 4109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Set_FunctionParams
		{
			// Token: 0x04006415 RID: 25621
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x0200100E RID: 4110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Map_FunctionParams
		{
			// Token: 0x04006416 RID: 25622
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x0200100F RID: 4111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI8Array_FunctionParams
		{
			// Token: 0x04006417 RID: 25623
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x02001010 RID: 4112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InI8_FunctionParams
		{
			// Token: 0x04006418 RID: 25624
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x02001011 RID: 4113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Set_FunctionParams
		{
			// Token: 0x04006419 RID: 25625
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x02001012 RID: 4114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Map_FunctionParams
		{
			// Token: 0x0400641A RID: 25626
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x02001013 RID: 4115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI64Array_FunctionParams
		{
			// Token: 0x0400641B RID: 25627
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x02001014 RID: 4116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InI64_FunctionParams
		{
			// Token: 0x0400641C RID: 25628
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x02001015 RID: 4117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Set_FunctionParams
		{
			// Token: 0x0400641D RID: 25629
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x02001016 RID: 4118
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Map_FunctionParams
		{
			// Token: 0x0400641E RID: 25630
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x02001017 RID: 4119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI32Array_FunctionParams
		{
			// Token: 0x0400641F RID: 25631
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x02001018 RID: 4120
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InI32_FunctionParams
		{
			// Token: 0x04006420 RID: 25632
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x02001019 RID: 4121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Set_FunctionParams
		{
			// Token: 0x04006421 RID: 25633
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x0200101A RID: 4122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Map_FunctionParams
		{
			// Token: 0x04006422 RID: 25634
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x0200101B RID: 4123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI16Array_FunctionParams
		{
			// Token: 0x04006423 RID: 25635
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x0200101C RID: 4124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InI16_FunctionParams
		{
			// Token: 0x04006424 RID: 25636
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x0200101D RID: 4125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Set_FunctionParams
		{
			// Token: 0x04006425 RID: 25637
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x0200101E RID: 4126
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Map_FunctionParams
		{
			// Token: 0x04006426 RID: 25638
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x0200101F RID: 4127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF64Array_FunctionParams
		{
			// Token: 0x04006427 RID: 25639
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x02001020 RID: 4128
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InF64_FunctionParams
		{
			// Token: 0x04006428 RID: 25640
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x02001021 RID: 4129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Set_FunctionParams
		{
			// Token: 0x04006429 RID: 25641
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x02001022 RID: 4130
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Map_FunctionParams
		{
			// Token: 0x0400642A RID: 25642
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x02001023 RID: 4131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF32Array_FunctionParams
		{
			// Token: 0x0400642B RID: 25643
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x02001024 RID: 4132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InF32_FunctionParams
		{
			// Token: 0x0400642C RID: 25644
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x02001025 RID: 4133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolSet_FunctionParams
		{
			// Token: 0x0400642D RID: 25645
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x02001026 RID: 4134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolMap_FunctionParams
		{
			// Token: 0x0400642E RID: 25646
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x02001027 RID: 4135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InBoolArray_FunctionParams
		{
			// Token: 0x0400642F RID: 25647
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x02001028 RID: 4136
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InBool_FunctionParams
		{
			// Token: 0x04006430 RID: 25648
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02001029 RID: 4137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Set_FunctionParams
		{
			// Token: 0x04006431 RID: 25649
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102A RID: 4138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Map_FunctionParams
		{
			// Token: 0x04006432 RID: 25650
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102B RID: 4139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU8Array_FunctionParams
		{
			// Token: 0x04006433 RID: 25651
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102C RID: 4140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetU8_FunctionParams
		{
			// Token: 0x04006434 RID: 25652
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102D RID: 4141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Set_FunctionParams
		{
			// Token: 0x04006435 RID: 25653
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102E RID: 4142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Map_FunctionParams
		{
			// Token: 0x04006436 RID: 25654
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200102F RID: 4143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU64Array_FunctionParams
		{
			// Token: 0x04006437 RID: 25655
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001030 RID: 4144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetU64_FunctionParams
		{
			// Token: 0x04006438 RID: 25656
			[FieldOffset(0)]
			public ulong __Result;
		}

		// Token: 0x02001031 RID: 4145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Set_FunctionParams
		{
			// Token: 0x04006439 RID: 25657
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001032 RID: 4146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Map_FunctionParams
		{
			// Token: 0x0400643A RID: 25658
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001033 RID: 4147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU32Array_FunctionParams
		{
			// Token: 0x0400643B RID: 25659
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001034 RID: 4148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetU32_FunctionParams
		{
			// Token: 0x0400643C RID: 25660
			[FieldOffset(0)]
			public uint __Result;
		}

		// Token: 0x02001035 RID: 4149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Set_FunctionParams
		{
			// Token: 0x0400643D RID: 25661
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001036 RID: 4150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Map_FunctionParams
		{
			// Token: 0x0400643E RID: 25662
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001037 RID: 4151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU16Array_FunctionParams
		{
			// Token: 0x0400643F RID: 25663
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001038 RID: 4152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetU16_FunctionParams
		{
			// Token: 0x04006440 RID: 25664
			[FieldOffset(0)]
			public ushort __Result;
		}

		// Token: 0x02001039 RID: 4153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Set_FunctionParams
		{
			// Token: 0x04006441 RID: 25665
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200103A RID: 4154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Map_FunctionParams
		{
			// Token: 0x04006442 RID: 25666
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200103B RID: 4155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI8Array_FunctionParams
		{
			// Token: 0x04006443 RID: 25667
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200103C RID: 4156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetI8_FunctionParams
		{
			// Token: 0x04006444 RID: 25668
			[FieldOffset(0)]
			public sbyte __Result;
		}

		// Token: 0x0200103D RID: 4157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Set_FunctionParams
		{
			// Token: 0x04006445 RID: 25669
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200103E RID: 4158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Map_FunctionParams
		{
			// Token: 0x04006446 RID: 25670
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200103F RID: 4159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI64Array_FunctionParams
		{
			// Token: 0x04006447 RID: 25671
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001040 RID: 4160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetI64_FunctionParams
		{
			// Token: 0x04006448 RID: 25672
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x02001041 RID: 4161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Set_FunctionParams
		{
			// Token: 0x04006449 RID: 25673
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001042 RID: 4162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Map_FunctionParams
		{
			// Token: 0x0400644A RID: 25674
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001043 RID: 4163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI32Array_FunctionParams
		{
			// Token: 0x0400644B RID: 25675
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001044 RID: 4164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetI32_FunctionParams
		{
			// Token: 0x0400644C RID: 25676
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02001045 RID: 4165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Set_FunctionParams
		{
			// Token: 0x0400644D RID: 25677
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001046 RID: 4166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Map_FunctionParams
		{
			// Token: 0x0400644E RID: 25678
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001047 RID: 4167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI16Array_FunctionParams
		{
			// Token: 0x0400644F RID: 25679
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001048 RID: 4168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetI16_FunctionParams
		{
			// Token: 0x04006450 RID: 25680
			[FieldOffset(0)]
			public short __Result;
		}

		// Token: 0x02001049 RID: 4169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Set_FunctionParams
		{
			// Token: 0x04006451 RID: 25681
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200104A RID: 4170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Map_FunctionParams
		{
			// Token: 0x04006452 RID: 25682
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200104B RID: 4171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF64Array_FunctionParams
		{
			// Token: 0x04006453 RID: 25683
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200104C RID: 4172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetF64_FunctionParams
		{
			// Token: 0x04006454 RID: 25684
			[FieldOffset(0)]
			public double __Result;
		}

		// Token: 0x0200104D RID: 4173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Set_FunctionParams
		{
			// Token: 0x04006455 RID: 25685
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200104E RID: 4174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Map_FunctionParams
		{
			// Token: 0x04006456 RID: 25686
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200104F RID: 4175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF32Array_FunctionParams
		{
			// Token: 0x04006457 RID: 25687
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001050 RID: 4176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetF32_FunctionParams
		{
			// Token: 0x04006458 RID: 25688
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02001051 RID: 4177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolSet_FunctionParams
		{
			// Token: 0x04006459 RID: 25689
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001052 RID: 4178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolMap_FunctionParams
		{
			// Token: 0x0400645A RID: 25690
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001053 RID: 4179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoolArray_FunctionParams
		{
			// Token: 0x0400645B RID: 25691
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001054 RID: 4180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetBool_FunctionParams
		{
			// Token: 0x0400645C RID: 25692
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
