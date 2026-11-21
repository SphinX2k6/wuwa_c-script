using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FB RID: 2043
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2072)]
	public class UTestClass_UFunction_Direct_Base : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B078 RID: 45176 RVA: 0x00109E80 File Offset: 0x00108080
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Base._ClassPtr;
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x00109E8C File Offset: 0x0010808C
		public UTestClass_UFunction_Direct_Base() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Base.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x00109EB4 File Offset: 0x001080B4
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Base(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Base.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x00109EE7 File Offset: 0x001080E7
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x00109EF7 File Offset: 0x001080F7
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

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x00109F08 File Offset: 0x00108108
		// (set) Token: 0x0600B07E RID: 45182 RVA: 0x00109F41 File Offset: 0x00108141
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

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x0600B07F RID: 45183 RVA: 0x00109F50 File Offset: 0x00108150
		// (set) Token: 0x0600B080 RID: 45184 RVA: 0x00109F89 File Offset: 0x00108189
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

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600B081 RID: 45185 RVA: 0x00109F98 File Offset: 0x00108198
		// (set) Token: 0x0600B082 RID: 45186 RVA: 0x00109FD1 File Offset: 0x001081D1
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

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x00109FDF File Offset: 0x001081DF
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x00109FEF File Offset: 0x001081EF
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

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x0010A000 File Offset: 0x00108200
		// (set) Token: 0x0600B086 RID: 45190 RVA: 0x0010A039 File Offset: 0x00108239
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

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600B087 RID: 45191 RVA: 0x0010A048 File Offset: 0x00108248
		// (set) Token: 0x0600B088 RID: 45192 RVA: 0x0010A081 File Offset: 0x00108281
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

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600B089 RID: 45193 RVA: 0x0010A090 File Offset: 0x00108290
		// (set) Token: 0x0600B08A RID: 45194 RVA: 0x0010A0C9 File Offset: 0x001082C9
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

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600B08B RID: 45195 RVA: 0x0010A0D7 File Offset: 0x001082D7
		// (set) Token: 0x0600B08C RID: 45196 RVA: 0x0010A0E7 File Offset: 0x001082E7
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

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x0010A0F8 File Offset: 0x001082F8
		// (set) Token: 0x0600B08E RID: 45198 RVA: 0x0010A131 File Offset: 0x00108331
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

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600B08F RID: 45199 RVA: 0x0010A140 File Offset: 0x00108340
		// (set) Token: 0x0600B090 RID: 45200 RVA: 0x0010A179 File Offset: 0x00108379
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

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x0010A188 File Offset: 0x00108388
		// (set) Token: 0x0600B092 RID: 45202 RVA: 0x0010A1C1 File Offset: 0x001083C1
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

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x0010A1CF File Offset: 0x001083CF
		// (set) Token: 0x0600B094 RID: 45204 RVA: 0x0010A1DF File Offset: 0x001083DF
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

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600B095 RID: 45205 RVA: 0x0010A1F0 File Offset: 0x001083F0
		// (set) Token: 0x0600B096 RID: 45206 RVA: 0x0010A229 File Offset: 0x00108429
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

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600B097 RID: 45207 RVA: 0x0010A238 File Offset: 0x00108438
		// (set) Token: 0x0600B098 RID: 45208 RVA: 0x0010A271 File Offset: 0x00108471
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

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x0010A280 File Offset: 0x00108480
		// (set) Token: 0x0600B09A RID: 45210 RVA: 0x0010A2B9 File Offset: 0x001084B9
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

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x0010A2C7 File Offset: 0x001084C7
		// (set) Token: 0x0600B09C RID: 45212 RVA: 0x0010A2D7 File Offset: 0x001084D7
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

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600B09D RID: 45213 RVA: 0x0010A2E8 File Offset: 0x001084E8
		// (set) Token: 0x0600B09E RID: 45214 RVA: 0x0010A321 File Offset: 0x00108521
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

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600B09F RID: 45215 RVA: 0x0010A330 File Offset: 0x00108530
		// (set) Token: 0x0600B0A0 RID: 45216 RVA: 0x0010A369 File Offset: 0x00108569
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

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600B0A1 RID: 45217 RVA: 0x0010A378 File Offset: 0x00108578
		// (set) Token: 0x0600B0A2 RID: 45218 RVA: 0x0010A3B1 File Offset: 0x001085B1
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

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x0010A3BF File Offset: 0x001085BF
		// (set) Token: 0x0600B0A4 RID: 45220 RVA: 0x0010A3CF File Offset: 0x001085CF
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

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x0010A3E0 File Offset: 0x001085E0
		// (set) Token: 0x0600B0A6 RID: 45222 RVA: 0x0010A419 File Offset: 0x00108619
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

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x0010A428 File Offset: 0x00108628
		// (set) Token: 0x0600B0A8 RID: 45224 RVA: 0x0010A461 File Offset: 0x00108661
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

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600B0A9 RID: 45225 RVA: 0x0010A470 File Offset: 0x00108670
		// (set) Token: 0x0600B0AA RID: 45226 RVA: 0x0010A4A9 File Offset: 0x001086A9
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

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600B0AB RID: 45227 RVA: 0x0010A4B7 File Offset: 0x001086B7
		// (set) Token: 0x0600B0AC RID: 45228 RVA: 0x0010A4C7 File Offset: 0x001086C7
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

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600B0AD RID: 45229 RVA: 0x0010A4D8 File Offset: 0x001086D8
		// (set) Token: 0x0600B0AE RID: 45230 RVA: 0x0010A511 File Offset: 0x00108711
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

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600B0AF RID: 45231 RVA: 0x0010A520 File Offset: 0x00108720
		// (set) Token: 0x0600B0B0 RID: 45232 RVA: 0x0010A559 File Offset: 0x00108759
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

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600B0B1 RID: 45233 RVA: 0x0010A568 File Offset: 0x00108768
		// (set) Token: 0x0600B0B2 RID: 45234 RVA: 0x0010A5A1 File Offset: 0x001087A1
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

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x0600B0B3 RID: 45235 RVA: 0x0010A5AF File Offset: 0x001087AF
		// (set) Token: 0x0600B0B4 RID: 45236 RVA: 0x0010A5BF File Offset: 0x001087BF
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

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x0600B0B5 RID: 45237 RVA: 0x0010A5D0 File Offset: 0x001087D0
		// (set) Token: 0x0600B0B6 RID: 45238 RVA: 0x0010A609 File Offset: 0x00108809
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

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x0010A618 File Offset: 0x00108818
		// (set) Token: 0x0600B0B8 RID: 45240 RVA: 0x0010A651 File Offset: 0x00108851
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

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x0010A660 File Offset: 0x00108860
		// (set) Token: 0x0600B0BA RID: 45242 RVA: 0x0010A699 File Offset: 0x00108899
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

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600B0BB RID: 45243 RVA: 0x0010A6A7 File Offset: 0x001088A7
		// (set) Token: 0x0600B0BC RID: 45244 RVA: 0x0010A6B7 File Offset: 0x001088B7
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

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x0010A6C8 File Offset: 0x001088C8
		// (set) Token: 0x0600B0BE RID: 45246 RVA: 0x0010A701 File Offset: 0x00108901
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

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600B0BF RID: 45247 RVA: 0x0010A710 File Offset: 0x00108910
		// (set) Token: 0x0600B0C0 RID: 45248 RVA: 0x0010A749 File Offset: 0x00108949
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

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600B0C1 RID: 45249 RVA: 0x0010A758 File Offset: 0x00108958
		// (set) Token: 0x0600B0C2 RID: 45250 RVA: 0x0010A791 File Offset: 0x00108991
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

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600B0C3 RID: 45251 RVA: 0x0010A79F File Offset: 0x0010899F
		// (set) Token: 0x0600B0C4 RID: 45252 RVA: 0x0010A7AF File Offset: 0x001089AF
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

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600B0C5 RID: 45253 RVA: 0x0010A7C0 File Offset: 0x001089C0
		// (set) Token: 0x0600B0C6 RID: 45254 RVA: 0x0010A7F9 File Offset: 0x001089F9
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

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600B0C7 RID: 45255 RVA: 0x0010A808 File Offset: 0x00108A08
		// (set) Token: 0x0600B0C8 RID: 45256 RVA: 0x0010A841 File Offset: 0x00108A41
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

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x0010A850 File Offset: 0x00108A50
		// (set) Token: 0x0600B0CA RID: 45258 RVA: 0x0010A889 File Offset: 0x00108A89
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

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600B0CB RID: 45259 RVA: 0x0010A897 File Offset: 0x00108A97
		// (set) Token: 0x0600B0CC RID: 45260 RVA: 0x0010A8A7 File Offset: 0x00108AA7
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

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600B0CD RID: 45261 RVA: 0x0010A8B8 File Offset: 0x00108AB8
		// (set) Token: 0x0600B0CE RID: 45262 RVA: 0x0010A8F1 File Offset: 0x00108AF1
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

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600B0CF RID: 45263 RVA: 0x0010A900 File Offset: 0x00108B00
		// (set) Token: 0x0600B0D0 RID: 45264 RVA: 0x0010A939 File Offset: 0x00108B39
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

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x0010A948 File Offset: 0x00108B48
		// (set) Token: 0x0600B0D2 RID: 45266 RVA: 0x0010A981 File Offset: 0x00108B81
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

		// Token: 0x0600B0D3 RID: 45267 RVA: 0x0010A990 File Offset: 0x00108B90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Set(TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Set != null)
			{
				InU8Set.CopyTo(&ptr->InU8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x0010A9FC File Offset: 0x00108BFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Map(TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Map != null)
			{
				InU8Map.CopyTo(&ptr->InU8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x0010AA68 File Offset: 0x00108C68
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU8Array(TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU8Array != null)
			{
				InU8Array.CopyTo(&ptr->InU8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x0010AAD4 File Offset: 0x00108CD4
		[SkipLocalsInit]
		public unsafe void SetU8(byte InU8)
		{
			UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x0010AB1C File Offset: 0x00108D1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Set(TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Set != null)
			{
				InU64Set.CopyTo(&ptr->InU64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x0010AB88 File Offset: 0x00108D88
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Map(TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Map != null)
			{
				InU64Map.CopyTo(&ptr->InU64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0D9 RID: 45273 RVA: 0x0010ABF4 File Offset: 0x00108DF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU64Array(TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU64Array != null)
			{
				InU64Array.CopyTo(&ptr->InU64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x0010AC60 File Offset: 0x00108E60
		[SkipLocalsInit]
		public unsafe void SetU64(ulong InU64)
		{
			UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x0010ACA8 File Offset: 0x00108EA8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Set(TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Set != null)
			{
				InU32Set.CopyTo(&ptr->InU32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x0010AD14 File Offset: 0x00108F14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Map(TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Map != null)
			{
				InU32Map.CopyTo(&ptr->InU32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x0010AD80 File Offset: 0x00108F80
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU32Array(TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU32Array != null)
			{
				InU32Array.CopyTo(&ptr->InU32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x0010ADEC File Offset: 0x00108FEC
		[SkipLocalsInit]
		public unsafe void SetU32(uint InU32)
		{
			UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x0010AE34 File Offset: 0x00109034
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Set(TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Set != null)
			{
				InU16Set.CopyTo(&ptr->InU16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x0010AEA0 File Offset: 0x001090A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Map(TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Map != null)
			{
				InU16Map.CopyTo(&ptr->InU16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x0010AF0C File Offset: 0x0010910C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetU16Array(TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InU16Array != null)
			{
				InU16Array.CopyTo(&ptr->InU16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x0010AF78 File Offset: 0x00109178
		[SkipLocalsInit]
		public unsafe void SetU16(ushort InU16)
		{
			UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetU16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x0010AFC0 File Offset: 0x001091C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Set(TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Set != null)
			{
				InI8Set.CopyTo(&ptr->InI8Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x0010B02C File Offset: 0x0010922C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Map(TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Map != null)
			{
				InI8Map.CopyTo(&ptr->InI8Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x0010B098 File Offset: 0x00109298
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI8Array(TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI8Array != null)
			{
				InI8Array.CopyTo(&ptr->InI8Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x0010B104 File Offset: 0x00109304
		[SkipLocalsInit]
		public unsafe void SetI8(sbyte InI8)
		{
			UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x0010B14C File Offset: 0x0010934C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Set(TSet<long> InI64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Set != null)
			{
				InI64Set.CopyTo(&ptr->InI64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x0010B1B8 File Offset: 0x001093B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Map(TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Map != null)
			{
				InI64Map.CopyTo(&ptr->InI64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x0010B224 File Offset: 0x00109424
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI64Array(TArray<long> InI64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI64Array != null)
			{
				InI64Array.CopyTo(&ptr->InI64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0EA RID: 45290 RVA: 0x0010B290 File Offset: 0x00109490
		[SkipLocalsInit]
		public unsafe void SetI64(long InI64)
		{
			UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x0010B2D8 File Offset: 0x001094D8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Set(TSet<int> InI32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Set != null)
			{
				InI32Set.CopyTo(&ptr->InI32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x0010B344 File Offset: 0x00109544
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Map(TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Map != null)
			{
				InI32Map.CopyTo(&ptr->InI32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x0010B3B0 File Offset: 0x001095B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI32Array(TArray<int> InI32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI32Array != null)
			{
				InI32Array.CopyTo(&ptr->InI32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x0010B41C File Offset: 0x0010961C
		[SkipLocalsInit]
		public unsafe void SetI32(int InI32)
		{
			UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x0010B464 File Offset: 0x00109664
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Set(TSet<short> InI16Set)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Set != null)
			{
				InI16Set.CopyTo(&ptr->InI16Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x0010B4D0 File Offset: 0x001096D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Map(TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Map != null)
			{
				InI16Map.CopyTo(&ptr->InI16Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F1 RID: 45297 RVA: 0x0010B53C File Offset: 0x0010973C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetI16Array(TArray<short> InI16Array)
		{
			UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InI16Array != null)
			{
				InI16Array.CopyTo(&ptr->InI16Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x0010B5A8 File Offset: 0x001097A8
		[SkipLocalsInit]
		public unsafe void SetI16(short InI16)
		{
			UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetI16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x0010B5F0 File Offset: 0x001097F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Set(TSet<double> InF64Set)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Set != null)
			{
				InF64Set.CopyTo(&ptr->InF64Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F4 RID: 45300 RVA: 0x0010B65C File Offset: 0x0010985C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Map(TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Map != null)
			{
				InF64Map.CopyTo(&ptr->InF64Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x0010B6C8 File Offset: 0x001098C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF64Array(TArray<double> InF64Array)
		{
			UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF64Array != null)
			{
				InF64Array.CopyTo(&ptr->InF64Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x0010B734 File Offset: 0x00109934
		[SkipLocalsInit]
		public unsafe void SetF64(double InF64)
		{
			UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x0010B77C File Offset: 0x0010997C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Set(TSet<float> InF32Set)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Set != null)
			{
				InF32Set.CopyTo(&ptr->InF32Set, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x0010B7E8 File Offset: 0x001099E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Map(TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Map != null)
			{
				InF32Map.CopyTo(&ptr->InF32Map, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x0010B854 File Offset: 0x00109A54
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetF32Array(TArray<float> InF32Array)
		{
			UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InF32Array != null)
			{
				InF32Array.CopyTo(&ptr->InF32Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0FA RID: 45306 RVA: 0x0010B8C0 File Offset: 0x00109AC0
		[SkipLocalsInit]
		public unsafe void SetF32(float InF32)
		{
			UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetF32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x0010B908 File Offset: 0x00109B08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolSet(TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolSet != null)
			{
				InBoolSet.CopyTo(&ptr->InBoolSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x0010B974 File Offset: 0x00109B74
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolMap(TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolMap != null)
			{
				InBoolMap.CopyTo(&ptr->InBoolMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0FD RID: 45309 RVA: 0x0010B9E0 File Offset: 0x00109BE0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetBoolArray(TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InBoolArray != null)
			{
				InBoolArray.CopyTo(&ptr->InBoolArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__SetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x0010BA4C File Offset: 0x00109C4C
		[SkipLocalsInit]
		public unsafe void SetBool(bool InBool)
		{
			UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__SetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__SetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__SetBool_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x0010BA94 File Offset: 0x00109C94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Set(ref TSet<byte> OutU8Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = OutU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> tset2 = OutU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x0010BB0C File Offset: 0x00109D0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Map(ref TMap<byte, int> OutU8Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = OutU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> tmap2 = OutU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x0010BB84 File Offset: 0x00109D84
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU8Array(ref TArray<byte> OutU8Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = OutU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> tarray2 = OutU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x0010BBFC File Offset: 0x00109DFC
		[SkipLocalsInit]
		public unsafe void OutU8(ref byte OutU8)
		{
			UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU8 = OutU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU8_NativeFunctionPtr, (void*)ptr);
			OutU8 = ptr->OutU8;
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x0010BC4C File Offset: 0x00109E4C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Set(ref TSet<ulong> OutU64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = OutU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> tset2 = OutU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x0010BCC4 File Offset: 0x00109EC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Map(ref TMap<ulong, int> OutU64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = OutU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> tmap2 = OutU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x0010BD3C File Offset: 0x00109F3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU64Array(ref TArray<ulong> OutU64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = OutU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> tarray2 = OutU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B106 RID: 45318 RVA: 0x0010BDB4 File Offset: 0x00109FB4
		[SkipLocalsInit]
		public unsafe void OutU64(ref ulong OutU64)
		{
			UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU64 = OutU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU64_NativeFunctionPtr, (void*)ptr);
			OutU64 = ptr->OutU64;
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x0010BE04 File Offset: 0x0010A004
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Set(ref TSet<uint> OutU32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = OutU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> tset2 = OutU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x0010BE7C File Offset: 0x0010A07C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Map(ref TMap<uint, int> OutU32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = OutU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> tmap2 = OutU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x0010BEF4 File Offset: 0x0010A0F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU32Array(ref TArray<uint> OutU32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = OutU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> tarray2 = OutU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x0010BF6C File Offset: 0x0010A16C
		[SkipLocalsInit]
		public unsafe void OutU32(ref uint OutU32)
		{
			UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU32 = OutU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU32_NativeFunctionPtr, (void*)ptr);
			OutU32 = ptr->OutU32;
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x0010BFBC File Offset: 0x0010A1BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Set(ref TSet<ushort> OutU16Set)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = OutU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> tset2 = OutU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x0010C034 File Offset: 0x0010A234
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Map(ref TMap<ushort, int> OutU16Map)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = OutU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> tmap2 = OutU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x0010C0AC File Offset: 0x0010A2AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutU16Array(ref TArray<ushort> OutU16Array)
		{
			UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = OutU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> tarray2 = OutU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x0010C124 File Offset: 0x0010A324
		[SkipLocalsInit]
		public unsafe void OutU16(ref ushort OutU16)
		{
			UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutU16 = OutU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutU16_NativeFunctionPtr, (void*)ptr);
			OutU16 = ptr->OutU16;
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x0010C174 File Offset: 0x0010A374
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Set(ref TSet<sbyte> OutI8Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = OutI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> tset2 = OutI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x0010C1EC File Offset: 0x0010A3EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Map(ref TMap<sbyte, int> OutI8Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = OutI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> tmap2 = OutI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x0010C264 File Offset: 0x0010A464
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI8Array(ref TArray<sbyte> OutI8Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = OutI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> tarray2 = OutI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x0010C2DC File Offset: 0x0010A4DC
		[SkipLocalsInit]
		public unsafe void OutI8(ref sbyte OutI8)
		{
			UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI8 = OutI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI8_NativeFunctionPtr, (void*)ptr);
			OutI8 = ptr->OutI8;
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x0010C32C File Offset: 0x0010A52C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Set(ref TSet<long> OutI64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = OutI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> tset2 = OutI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x0010C3A4 File Offset: 0x0010A5A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Map(ref TMap<long, int> OutI64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = OutI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> tmap2 = OutI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x0010C41C File Offset: 0x0010A61C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI64Array(ref TArray<long> OutI64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = OutI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = OutI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x0010C494 File Offset: 0x0010A694
		[SkipLocalsInit]
		public unsafe void OutI64(ref long OutI64)
		{
			UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI64 = OutI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI64_NativeFunctionPtr, (void*)ptr);
			OutI64 = ptr->OutI64;
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x0010C4E4 File Offset: 0x0010A6E4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Set(ref TSet<int> OutI32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = OutI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> tset2 = OutI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x0010C55C File Offset: 0x0010A75C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Map(ref TMap<int, int> OutI32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = OutI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = OutI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x0010C5D4 File Offset: 0x0010A7D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI32Array(ref TArray<int> OutI32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = OutI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x0010C64C File Offset: 0x0010A84C
		[SkipLocalsInit]
		public unsafe void OutI32(ref int OutI32)
		{
			UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI32 = OutI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI32_NativeFunctionPtr, (void*)ptr);
			OutI32 = ptr->OutI32;
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x0010C69C File Offset: 0x0010A89C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Set(ref TSet<short> OutI16Set)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = OutI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> tset2 = OutI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x0010C714 File Offset: 0x0010A914
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Map(ref TMap<short, int> OutI16Map)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = OutI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> tmap2 = OutI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x0010C78C File Offset: 0x0010A98C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutI16Array(ref TArray<short> OutI16Array)
		{
			UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = OutI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> tarray2 = OutI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x0010C804 File Offset: 0x0010AA04
		[SkipLocalsInit]
		public unsafe void OutI16(ref short OutI16)
		{
			UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutI16 = OutI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutI16_NativeFunctionPtr, (void*)ptr);
			OutI16 = ptr->OutI16;
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x0010C854 File Offset: 0x0010AA54
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Set(ref TSet<double> OutF64Set)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = OutF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> tset2 = OutF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x0010C8CC File Offset: 0x0010AACC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Map(ref TMap<double, int> OutF64Map)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = OutF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> tmap2 = OutF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x0010C944 File Offset: 0x0010AB44
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF64Array(ref TArray<double> OutF64Array)
		{
			UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = OutF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> tarray2 = OutF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x0010C9BC File Offset: 0x0010ABBC
		[SkipLocalsInit]
		public unsafe void OutF64(ref double OutF64)
		{
			UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF64 = OutF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF64_NativeFunctionPtr, (void*)ptr);
			OutF64 = ptr->OutF64;
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x0010CA0C File Offset: 0x0010AC0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Set(ref TSet<float> OutF32Set)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = OutF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> tset2 = OutF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B124 RID: 45348 RVA: 0x0010CA84 File Offset: 0x0010AC84
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Map(ref TMap<float, int> OutF32Map)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = OutF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> tmap2 = OutF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B125 RID: 45349 RVA: 0x0010CAFC File Offset: 0x0010ACFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutF32Array(ref TArray<float> OutF32Array)
		{
			UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = OutF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> tarray2 = OutF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B126 RID: 45350 RVA: 0x0010CB74 File Offset: 0x0010AD74
		[SkipLocalsInit]
		public unsafe void OutF32(ref float OutF32)
		{
			UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutF32 = OutF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutF32_NativeFunctionPtr, (void*)ptr);
			OutF32 = ptr->OutF32;
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x0010CBC4 File Offset: 0x0010ADC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolSet(ref TSet<bool> OutBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = OutBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> tset2 = OutBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x0010CC3C File Offset: 0x0010AE3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolMap(ref TMap<bool, int> OutBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = OutBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> tmap2 = OutBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x0010CCB4 File Offset: 0x0010AEB4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutBoolArray(ref TArray<bool> OutBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = OutBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = OutBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__OutBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		[SkipLocalsInit]
		public unsafe void OutBool(ref bool OutBool)
		{
			UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__OutBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__OutBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutBool = OutBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__OutBool_NativeFunctionPtr, (void*)ptr);
			OutBool = ptr->OutBool;
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x0010CD7C File Offset: 0x0010AF7C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Set(in TSet<byte> InU8Set)
		{
			UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<byte> tset = InU8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> tset2 = InU8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x0010CDF4 File Offset: 0x0010AFF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Map(in TMap<byte, int> InU8Map)
		{
			UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<byte, int> tmap = InU8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> tmap2 = InU8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x0010CE6C File Offset: 0x0010B06C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU8Array(in TArray<byte> InU8Array)
		{
			UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = InU8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> tarray2 = InU8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x0010CEE4 File Offset: 0x0010B0E4
		[SkipLocalsInit]
		public unsafe void InU8(in byte InU8)
		{
			UTestClass_UFunction_Direct_Base.__InU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU8 = InU8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x0010CF2C File Offset: 0x0010B12C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Set(in TSet<ulong> InU64Set)
		{
			UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ulong> tset = InU64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> tset2 = InU64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x0010CFA4 File Offset: 0x0010B1A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Map(in TMap<ulong, int> InU64Map)
		{
			UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ulong, int> tmap = InU64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> tmap2 = InU64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x0010D01C File Offset: 0x0010B21C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU64Array(in TArray<ulong> InU64Array)
		{
			UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ulong> tarray = InU64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> tarray2 = InU64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x0010D094 File Offset: 0x0010B294
		[SkipLocalsInit]
		public unsafe void InU64(in ulong InU64)
		{
			UTestClass_UFunction_Direct_Base.__InU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU64 = InU64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x0010D0DC File Offset: 0x0010B2DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Set(in TSet<uint> InU32Set)
		{
			UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<uint> tset = InU32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> tset2 = InU32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x0010D154 File Offset: 0x0010B354
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Map(in TMap<uint, int> InU32Map)
		{
			UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<uint, int> tmap = InU32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> tmap2 = InU32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x0010D1CC File Offset: 0x0010B3CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU32Array(in TArray<uint> InU32Array)
		{
			UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<uint> tarray = InU32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> tarray2 = InU32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x0010D244 File Offset: 0x0010B444
		[SkipLocalsInit]
		public unsafe void InU32(in uint InU32)
		{
			UTestClass_UFunction_Direct_Base.__InU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU32 = InU32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x0010D28C File Offset: 0x0010B48C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Set(in TSet<ushort> InU16Set)
		{
			UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<ushort> tset = InU16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InU16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> tset2 = InU16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InU16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x0010D304 File Offset: 0x0010B504
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Map(in TMap<ushort, int> InU16Map)
		{
			UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<ushort, int> tmap = InU16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InU16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> tmap2 = InU16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InU16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x0010D37C File Offset: 0x0010B57C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InU16Array(in TArray<ushort> InU16Array)
		{
			UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ushort> tarray = InU16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InU16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> tarray2 = InU16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InU16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InU16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x0010D3F4 File Offset: 0x0010B5F4
		[SkipLocalsInit]
		public unsafe void InU16(in ushort InU16)
		{
			UTestClass_UFunction_Direct_Base.__InU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InU16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InU16 = InU16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InU16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x0010D43C File Offset: 0x0010B63C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Set(in TSet<sbyte> InI8Set)
		{
			UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<sbyte> tset = InI8Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI8Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> tset2 = InI8Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI8Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x0010D4B4 File Offset: 0x0010B6B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Map(in TMap<sbyte, int> InI8Map)
		{
			UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<sbyte, int> tmap = InI8Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI8Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> tmap2 = InI8Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI8Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x0010D52C File Offset: 0x0010B72C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI8Array(in TArray<sbyte> InI8Array)
		{
			UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<sbyte> tarray = InI8Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI8Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> tarray2 = InI8Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI8Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI8Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x0010D5A4 File Offset: 0x0010B7A4
		[SkipLocalsInit]
		public unsafe void InI8(in sbyte InI8)
		{
			UTestClass_UFunction_Direct_Base.__InI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI8_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI8 = InI8;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI8_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x0010D5EC File Offset: 0x0010B7EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Set(in TSet<long> InI64Set)
		{
			UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<long> tset = InI64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> tset2 = InI64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x0010D664 File Offset: 0x0010B864
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Map(in TMap<long, int> InI64Map)
		{
			UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<long, int> tmap = InI64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> tmap2 = InI64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x0010D6DC File Offset: 0x0010B8DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI64Array(in TArray<long> InI64Array)
		{
			UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<long> tarray = InI64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = InI64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x0010D754 File Offset: 0x0010B954
		[SkipLocalsInit]
		public unsafe void InI64(in long InI64)
		{
			UTestClass_UFunction_Direct_Base.__InI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI64 = InI64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x0010D79C File Offset: 0x0010B99C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Set(in TSet<int> InI32Set)
		{
			UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<int> tset = InI32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> tset2 = InI32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x0010D814 File Offset: 0x0010BA14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Map(in TMap<int, int> InI32Map)
		{
			UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<int, int> tmap = InI32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = InI32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x0010D88C File Offset: 0x0010BA8C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI32Array(in TArray<int> InI32Array)
		{
			UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = InI32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = InI32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x0010D904 File Offset: 0x0010BB04
		[SkipLocalsInit]
		public unsafe void InI32(in int InI32)
		{
			UTestClass_UFunction_Direct_Base.__InI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI32 = InI32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x0010D94C File Offset: 0x0010BB4C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Set(in TSet<short> InI16Set)
		{
			UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<short> tset = InI16Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InI16Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> tset2 = InI16Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InI16Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x0010D9C4 File Offset: 0x0010BBC4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Map(in TMap<short, int> InI16Map)
		{
			UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<short, int> tmap = InI16Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InI16Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> tmap2 = InI16Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InI16Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x0010DA3C File Offset: 0x0010BC3C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InI16Array(in TArray<short> InI16Array)
		{
			UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<short> tarray = InI16Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InI16Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> tarray2 = InI16Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InI16Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InI16Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x0010DAB4 File Offset: 0x0010BCB4
		[SkipLocalsInit]
		public unsafe void InI16(in short InI16)
		{
			UTestClass_UFunction_Direct_Base.__InI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InI16_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InI16 = InI16;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InI16_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x0010DAFC File Offset: 0x0010BCFC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Set(in TSet<double> InF64Set)
		{
			UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<double> tset = InF64Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF64Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> tset2 = InF64Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF64Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x0010DB74 File Offset: 0x0010BD74
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Map(in TMap<double, int> InF64Map)
		{
			UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<double, int> tmap = InF64Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF64Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> tmap2 = InF64Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF64Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x0010DBEC File Offset: 0x0010BDEC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF64Array(in TArray<double> InF64Array)
		{
			UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<double> tarray = InF64Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF64Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> tarray2 = InF64Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF64Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF64Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x0010DC64 File Offset: 0x0010BE64
		[SkipLocalsInit]
		public unsafe void InF64(in double InF64)
		{
			UTestClass_UFunction_Direct_Base.__InF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF64 = InF64;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF64_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x0010DCAC File Offset: 0x0010BEAC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Set(in TSet<float> InF32Set)
		{
			UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
			TSet<float> tset = InF32Set;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InF32Set);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> tset2 = InF32Set;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InF32Set);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Set_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x0010DD24 File Offset: 0x0010BF24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Map(in TMap<float, int> InF32Map)
		{
			UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
			TMap<float, int> tmap = InF32Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InF32Map);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> tmap2 = InF32Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InF32Map);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B151 RID: 45393 RVA: 0x0010DD9C File Offset: 0x0010BF9C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InF32Array(in TArray<float> InF32Array)
		{
			UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<float> tarray = InF32Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InF32Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> tarray2 = InF32Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InF32Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InF32Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x0010DE14 File Offset: 0x0010C014
		[SkipLocalsInit]
		public unsafe void InF32(in float InF32)
		{
			UTestClass_UFunction_Direct_Base.__InF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InF32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InF32 = InF32;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InF32_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x0010DE5C File Offset: 0x0010C05C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolSet(in TSet<bool> InBoolSet)
		{
			UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<bool> tset = InBoolSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> tset2 = InBoolSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InBoolSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x0010DED4 File Offset: 0x0010C0D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolMap(in TMap<bool, int> InBoolMap)
		{
			UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<bool, int> tmap = InBoolMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> tmap2 = InBoolMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InBoolMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x0010DF4C File Offset: 0x0010C14C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InBoolArray(in TArray<bool> InBoolArray)
		{
			UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<bool> tarray = InBoolArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> tarray2 = InBoolArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InBoolArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__InBoolArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x0010DFC4 File Offset: 0x0010C1C4
		[SkipLocalsInit]
		public unsafe void InBool(in bool InBool)
		{
			UTestClass_UFunction_Direct_Base.__InBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__InBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__InBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__InBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InBool = InBool;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__InBool_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x0010E00C File Offset: 0x0010C20C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<byte> GetU8Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr);
			TSet<byte> result = new TSet<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x0010E06C File Offset: 0x0010C26C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<byte, int> GetU8Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr);
			TMap<byte, int> result = new TMap<byte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x0010E0CC File Offset: 0x0010C2CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<byte> GetU8Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr);
			TArray<byte> result = new TArray<byte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x0010E12C File Offset: 0x0010C32C
		[SkipLocalsInit]
		public unsafe byte GetU8()
		{
			UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU8_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x0010E174 File Offset: 0x0010C374
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<ulong> GetU64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr);
			TSet<ulong> result = new TSet<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x0010E1D4 File Offset: 0x0010C3D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<ulong, int> GetU64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr);
			TMap<ulong, int> result = new TMap<ulong, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x0010E234 File Offset: 0x0010C434
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ulong> GetU64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr);
			TArray<ulong> result = new TArray<ulong>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x0010E294 File Offset: 0x0010C494
		[SkipLocalsInit]
		public unsafe ulong GetU64()
		{
			UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x0010E2DC File Offset: 0x0010C4DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<uint> GetU32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr);
			TSet<uint> result = new TSet<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x0010E33C File Offset: 0x0010C53C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<uint, int> GetU32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr);
			TMap<uint, int> result = new TMap<uint, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x0010E39C File Offset: 0x0010C59C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<uint> GetU32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr);
			TArray<uint> result = new TArray<uint>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x0010E3FC File Offset: 0x0010C5FC
		[SkipLocalsInit]
		public unsafe uint GetU32()
		{
			UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x0010E444 File Offset: 0x0010C644
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<ushort> GetU16Set()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr);
			TSet<ushort> result = new TSet<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x0010E4A4 File Offset: 0x0010C6A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<ushort, int> GetU16Map()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr);
			TMap<ushort, int> result = new TMap<ushort, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x0010E504 File Offset: 0x0010C704
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ushort> GetU16Array()
		{
			UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr);
			TArray<ushort> result = new TArray<ushort>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetU16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x0010E564 File Offset: 0x0010C764
		[SkipLocalsInit]
		public unsafe ushort GetU16()
		{
			UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetU16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetU16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetU16_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x0010E5AC File Offset: 0x0010C7AC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<sbyte> GetI8Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr);
			TSet<sbyte> result = new TSet<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x0010E60C File Offset: 0x0010C80C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<sbyte, int> GetI8Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr);
			TMap<sbyte, int> result = new TMap<sbyte, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x0010E66C File Offset: 0x0010C86C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<sbyte> GetI8Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr);
			TArray<sbyte> result = new TArray<sbyte>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI8Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x0010E6CC File Offset: 0x0010C8CC
		[SkipLocalsInit]
		public unsafe sbyte GetI8()
		{
			UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI8_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI8_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI8_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x0010E714 File Offset: 0x0010C914
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<long> GetI64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr);
			TSet<long> result = new TSet<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x0010E774 File Offset: 0x0010C974
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<long, int> GetI64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr);
			TMap<long, int> result = new TMap<long, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x0010E7D4 File Offset: 0x0010C9D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<long> GetI64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr);
			TArray<long> result = new TArray<long>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x0010E834 File Offset: 0x0010CA34
		[SkipLocalsInit]
		public unsafe long GetI64()
		{
			UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x0010E87C File Offset: 0x0010CA7C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<int> GetI32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr);
			TSet<int> result = new TSet<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x0010E8DC File Offset: 0x0010CADC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<int, int> GetI32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> result = new TMap<int, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x0010E93C File Offset: 0x0010CB3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<int> GetI32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr);
			TArray<int> result = new TArray<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x0010E99C File Offset: 0x0010CB9C
		[SkipLocalsInit]
		public unsafe int GetI32()
		{
			UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x0010E9E4 File Offset: 0x0010CBE4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<short> GetI16Set()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr);
			TSet<short> result = new TSet<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x0010EA44 File Offset: 0x0010CC44
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<short, int> GetI16Map()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr);
			TMap<short, int> result = new TMap<short, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x0010EAA4 File Offset: 0x0010CCA4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<short> GetI16Array()
		{
			UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr);
			TArray<short> result = new TArray<short>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetI16Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x0010EB04 File Offset: 0x0010CD04
		[SkipLocalsInit]
		public unsafe short GetI16()
		{
			UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetI16_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetI16_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetI16_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x0010EB4C File Offset: 0x0010CD4C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<double> GetF64Set()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr);
			TSet<double> result = new TSet<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x0010EBAC File Offset: 0x0010CDAC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<double, int> GetF64Map()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr);
			TMap<double, int> result = new TMap<double, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x0010EC0C File Offset: 0x0010CE0C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<double> GetF64Array()
		{
			UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr);
			TArray<double> result = new TArray<double>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF64Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x0010EC6C File Offset: 0x0010CE6C
		[SkipLocalsInit]
		public unsafe double GetF64()
		{
			UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF64_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF64_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x0010ECB4 File Offset: 0x0010CEB4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<float> GetF32Set()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Set_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr);
			TSet<float> result = new TSet<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Set_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x0010ED14 File Offset: 0x0010CF14
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<float, int> GetF32Map()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr);
			TMap<float, int> result = new TMap<float, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Map_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x0010ED74 File Offset: 0x0010CF74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<float> GetF32Array()
		{
			UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr);
			TArray<float> result = new TArray<float>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetF32Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B17E RID: 45438 RVA: 0x0010EDD4 File Offset: 0x0010CFD4
		[SkipLocalsInit]
		public unsafe float GetF32()
		{
			UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetF32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetF32_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetF32_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x0010EE1C File Offset: 0x0010D01C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<bool> GetBoolSet()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr);
			TSet<bool> result = new TSet<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x0010EE7C File Offset: 0x0010D07C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<bool, int> GetBoolMap()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr);
			TMap<bool, int> result = new TMap<bool, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x0010EEDC File Offset: 0x0010D0DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<bool> GetBoolArray()
		{
			UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBoolArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr);
			TArray<bool> result = new TArray<bool>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Base.__GetBoolArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x0010EF3C File Offset: 0x0010D13C
		[SkipLocalsInit]
		public unsafe bool GetBool()
		{
			UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Base.__GetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Base.__GetBool_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Base.__GetBool_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x0010EF81 File Offset: 0x0010D181
		static UTestClass_UFunction_Direct_Base()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Base");
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x0010EF8F File Offset: 0x0010D18F
		protected UTestClass_UFunction_Direct_Base(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004D50 RID: 19792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Base";

		// Token: 0x04004D51 RID: 19793
		private static IntPtr _ClassPtr;

		// Token: 0x04004D52 RID: 19794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004D53 RID: 19795
		internal static int __PropertyOffset_Bool;

		// Token: 0x04004D54 RID: 19796
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x04004D55 RID: 19797
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x04004D56 RID: 19798
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x04004D57 RID: 19799
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x04004D58 RID: 19800
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x04004D59 RID: 19801
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x04004D5A RID: 19802
		internal static int __PropertyOffset_I8;

		// Token: 0x04004D5B RID: 19803
		internal static int __PropertyOffset_I8Array;

		// Token: 0x04004D5C RID: 19804
		[Nullable(2)]
		private TArray<sbyte> _I8Array;

		// Token: 0x04004D5D RID: 19805
		internal static int __PropertyOffset_I8Set;

		// Token: 0x04004D5E RID: 19806
		[Nullable(2)]
		private TSet<sbyte> _I8Set;

		// Token: 0x04004D5F RID: 19807
		internal static int __PropertyOffset_I8Map;

		// Token: 0x04004D60 RID: 19808
		[Nullable(2)]
		private TMap<sbyte, int> _I8Map;

		// Token: 0x04004D61 RID: 19809
		internal static int __PropertyOffset_U8;

		// Token: 0x04004D62 RID: 19810
		internal static int __PropertyOffset_U8Array;

		// Token: 0x04004D63 RID: 19811
		[Nullable(2)]
		private TArray<byte> _U8Array;

		// Token: 0x04004D64 RID: 19812
		internal static int __PropertyOffset_U8Set;

		// Token: 0x04004D65 RID: 19813
		[Nullable(2)]
		private TSet<byte> _U8Set;

		// Token: 0x04004D66 RID: 19814
		internal static int __PropertyOffset_U8Map;

		// Token: 0x04004D67 RID: 19815
		[Nullable(2)]
		private TMap<byte, int> _U8Map;

		// Token: 0x04004D68 RID: 19816
		internal static int __PropertyOffset_I16;

		// Token: 0x04004D69 RID: 19817
		internal static int __PropertyOffset_I16Array;

		// Token: 0x04004D6A RID: 19818
		[Nullable(2)]
		private TArray<short> _I16Array;

		// Token: 0x04004D6B RID: 19819
		internal static int __PropertyOffset_I16Set;

		// Token: 0x04004D6C RID: 19820
		[Nullable(2)]
		private TSet<short> _I16Set;

		// Token: 0x04004D6D RID: 19821
		internal static int __PropertyOffset_I16Map;

		// Token: 0x04004D6E RID: 19822
		[Nullable(2)]
		private TMap<short, int> _I16Map;

		// Token: 0x04004D6F RID: 19823
		internal static int __PropertyOffset_U16;

		// Token: 0x04004D70 RID: 19824
		internal static int __PropertyOffset_U16Array;

		// Token: 0x04004D71 RID: 19825
		[Nullable(2)]
		private TArray<ushort> _U16Array;

		// Token: 0x04004D72 RID: 19826
		internal static int __PropertyOffset_U16Set;

		// Token: 0x04004D73 RID: 19827
		[Nullable(2)]
		private TSet<ushort> _U16Set;

		// Token: 0x04004D74 RID: 19828
		internal static int __PropertyOffset_U16Map;

		// Token: 0x04004D75 RID: 19829
		[Nullable(2)]
		private TMap<ushort, int> _U16Map;

		// Token: 0x04004D76 RID: 19830
		internal static int __PropertyOffset_I32;

		// Token: 0x04004D77 RID: 19831
		internal static int __PropertyOffset_I32Array;

		// Token: 0x04004D78 RID: 19832
		[Nullable(2)]
		private TArray<int> _I32Array;

		// Token: 0x04004D79 RID: 19833
		internal static int __PropertyOffset_I32Set;

		// Token: 0x04004D7A RID: 19834
		[Nullable(2)]
		private TSet<int> _I32Set;

		// Token: 0x04004D7B RID: 19835
		internal static int __PropertyOffset_I32Map;

		// Token: 0x04004D7C RID: 19836
		[Nullable(2)]
		private TMap<int, int> _I32Map;

		// Token: 0x04004D7D RID: 19837
		internal static int __PropertyOffset_U32;

		// Token: 0x04004D7E RID: 19838
		internal static int __PropertyOffset_U32Array;

		// Token: 0x04004D7F RID: 19839
		[Nullable(2)]
		private TArray<uint> _U32Array;

		// Token: 0x04004D80 RID: 19840
		internal static int __PropertyOffset_U32Set;

		// Token: 0x04004D81 RID: 19841
		[Nullable(2)]
		private TSet<uint> _U32Set;

		// Token: 0x04004D82 RID: 19842
		internal static int __PropertyOffset_U32Map;

		// Token: 0x04004D83 RID: 19843
		[Nullable(2)]
		private TMap<uint, int> _U32Map;

		// Token: 0x04004D84 RID: 19844
		internal static int __PropertyOffset_I64;

		// Token: 0x04004D85 RID: 19845
		internal static int __PropertyOffset_I64Array;

		// Token: 0x04004D86 RID: 19846
		[Nullable(2)]
		private TArray<long> _I64Array;

		// Token: 0x04004D87 RID: 19847
		internal static int __PropertyOffset_I64Set;

		// Token: 0x04004D88 RID: 19848
		[Nullable(2)]
		private TSet<long> _I64Set;

		// Token: 0x04004D89 RID: 19849
		internal static int __PropertyOffset_I64Map;

		// Token: 0x04004D8A RID: 19850
		[Nullable(2)]
		private TMap<long, int> _I64Map;

		// Token: 0x04004D8B RID: 19851
		internal static int __PropertyOffset_U64;

		// Token: 0x04004D8C RID: 19852
		internal static int __PropertyOffset_U64Array;

		// Token: 0x04004D8D RID: 19853
		[Nullable(2)]
		private TArray<ulong> _U64Array;

		// Token: 0x04004D8E RID: 19854
		internal static int __PropertyOffset_U64Set;

		// Token: 0x04004D8F RID: 19855
		[Nullable(2)]
		private TSet<ulong> _U64Set;

		// Token: 0x04004D90 RID: 19856
		internal static int __PropertyOffset_U64Map;

		// Token: 0x04004D91 RID: 19857
		[Nullable(2)]
		private TMap<ulong, int> _U64Map;

		// Token: 0x04004D92 RID: 19858
		internal static int __PropertyOffset_F32;

		// Token: 0x04004D93 RID: 19859
		internal static int __PropertyOffset_F32Array;

		// Token: 0x04004D94 RID: 19860
		[Nullable(2)]
		private TArray<float> _F32Array;

		// Token: 0x04004D95 RID: 19861
		internal static int __PropertyOffset_F32Set;

		// Token: 0x04004D96 RID: 19862
		[Nullable(2)]
		private TSet<float> _F32Set;

		// Token: 0x04004D97 RID: 19863
		internal static int __PropertyOffset_F32Map;

		// Token: 0x04004D98 RID: 19864
		[Nullable(2)]
		private TMap<float, int> _F32Map;

		// Token: 0x04004D99 RID: 19865
		internal static int __PropertyOffset_F64;

		// Token: 0x04004D9A RID: 19866
		internal static int __PropertyOffset_F64Array;

		// Token: 0x04004D9B RID: 19867
		[Nullable(2)]
		private TArray<double> _F64Array;

		// Token: 0x04004D9C RID: 19868
		internal static int __PropertyOffset_F64Set;

		// Token: 0x04004D9D RID: 19869
		[Nullable(2)]
		private TSet<double> _F64Set;

		// Token: 0x04004D9E RID: 19870
		internal static int __PropertyOffset_F64Map;

		// Token: 0x04004D9F RID: 19871
		[Nullable(2)]
		private TMap<double, int> _F64Map;

		// Token: 0x04004DA0 RID: 19872
		private static IntPtr __SetU8Set_NativeFunctionPtr;

		// Token: 0x04004DA1 RID: 19873
		private static IntPtr __SetU8Map_NativeFunctionPtr;

		// Token: 0x04004DA2 RID: 19874
		private static IntPtr __SetU8Array_NativeFunctionPtr;

		// Token: 0x04004DA3 RID: 19875
		private static IntPtr __SetU8_NativeFunctionPtr;

		// Token: 0x04004DA4 RID: 19876
		private static IntPtr __SetU64Set_NativeFunctionPtr;

		// Token: 0x04004DA5 RID: 19877
		private static IntPtr __SetU64Map_NativeFunctionPtr;

		// Token: 0x04004DA6 RID: 19878
		private static IntPtr __SetU64Array_NativeFunctionPtr;

		// Token: 0x04004DA7 RID: 19879
		private static IntPtr __SetU64_NativeFunctionPtr;

		// Token: 0x04004DA8 RID: 19880
		private static IntPtr __SetU32Set_NativeFunctionPtr;

		// Token: 0x04004DA9 RID: 19881
		private static IntPtr __SetU32Map_NativeFunctionPtr;

		// Token: 0x04004DAA RID: 19882
		private static IntPtr __SetU32Array_NativeFunctionPtr;

		// Token: 0x04004DAB RID: 19883
		private static IntPtr __SetU32_NativeFunctionPtr;

		// Token: 0x04004DAC RID: 19884
		private static IntPtr __SetU16Set_NativeFunctionPtr;

		// Token: 0x04004DAD RID: 19885
		private static IntPtr __SetU16Map_NativeFunctionPtr;

		// Token: 0x04004DAE RID: 19886
		private static IntPtr __SetU16Array_NativeFunctionPtr;

		// Token: 0x04004DAF RID: 19887
		private static IntPtr __SetU16_NativeFunctionPtr;

		// Token: 0x04004DB0 RID: 19888
		private static IntPtr __SetI8Set_NativeFunctionPtr;

		// Token: 0x04004DB1 RID: 19889
		private static IntPtr __SetI8Map_NativeFunctionPtr;

		// Token: 0x04004DB2 RID: 19890
		private static IntPtr __SetI8Array_NativeFunctionPtr;

		// Token: 0x04004DB3 RID: 19891
		private static IntPtr __SetI8_NativeFunctionPtr;

		// Token: 0x04004DB4 RID: 19892
		private static IntPtr __SetI64Set_NativeFunctionPtr;

		// Token: 0x04004DB5 RID: 19893
		private static IntPtr __SetI64Map_NativeFunctionPtr;

		// Token: 0x04004DB6 RID: 19894
		private static IntPtr __SetI64Array_NativeFunctionPtr;

		// Token: 0x04004DB7 RID: 19895
		private static IntPtr __SetI64_NativeFunctionPtr;

		// Token: 0x04004DB8 RID: 19896
		private static IntPtr __SetI32Set_NativeFunctionPtr;

		// Token: 0x04004DB9 RID: 19897
		private static IntPtr __SetI32Map_NativeFunctionPtr;

		// Token: 0x04004DBA RID: 19898
		private static IntPtr __SetI32Array_NativeFunctionPtr;

		// Token: 0x04004DBB RID: 19899
		private static IntPtr __SetI32_NativeFunctionPtr;

		// Token: 0x04004DBC RID: 19900
		private static IntPtr __SetI16Set_NativeFunctionPtr;

		// Token: 0x04004DBD RID: 19901
		private static IntPtr __SetI16Map_NativeFunctionPtr;

		// Token: 0x04004DBE RID: 19902
		private static IntPtr __SetI16Array_NativeFunctionPtr;

		// Token: 0x04004DBF RID: 19903
		private static IntPtr __SetI16_NativeFunctionPtr;

		// Token: 0x04004DC0 RID: 19904
		private static IntPtr __SetF64Set_NativeFunctionPtr;

		// Token: 0x04004DC1 RID: 19905
		private static IntPtr __SetF64Map_NativeFunctionPtr;

		// Token: 0x04004DC2 RID: 19906
		private static IntPtr __SetF64Array_NativeFunctionPtr;

		// Token: 0x04004DC3 RID: 19907
		private static IntPtr __SetF64_NativeFunctionPtr;

		// Token: 0x04004DC4 RID: 19908
		private static IntPtr __SetF32Set_NativeFunctionPtr;

		// Token: 0x04004DC5 RID: 19909
		private static IntPtr __SetF32Map_NativeFunctionPtr;

		// Token: 0x04004DC6 RID: 19910
		private static IntPtr __SetF32Array_NativeFunctionPtr;

		// Token: 0x04004DC7 RID: 19911
		private static IntPtr __SetF32_NativeFunctionPtr;

		// Token: 0x04004DC8 RID: 19912
		private static IntPtr __SetBoolSet_NativeFunctionPtr;

		// Token: 0x04004DC9 RID: 19913
		private static IntPtr __SetBoolMap_NativeFunctionPtr;

		// Token: 0x04004DCA RID: 19914
		private static IntPtr __SetBoolArray_NativeFunctionPtr;

		// Token: 0x04004DCB RID: 19915
		private static IntPtr __SetBool_NativeFunctionPtr;

		// Token: 0x04004DCC RID: 19916
		private static IntPtr __OutU8Set_NativeFunctionPtr;

		// Token: 0x04004DCD RID: 19917
		private static IntPtr __OutU8Map_NativeFunctionPtr;

		// Token: 0x04004DCE RID: 19918
		private static IntPtr __OutU8Array_NativeFunctionPtr;

		// Token: 0x04004DCF RID: 19919
		private static IntPtr __OutU8_NativeFunctionPtr;

		// Token: 0x04004DD0 RID: 19920
		private static IntPtr __OutU64Set_NativeFunctionPtr;

		// Token: 0x04004DD1 RID: 19921
		private static IntPtr __OutU64Map_NativeFunctionPtr;

		// Token: 0x04004DD2 RID: 19922
		private static IntPtr __OutU64Array_NativeFunctionPtr;

		// Token: 0x04004DD3 RID: 19923
		private static IntPtr __OutU64_NativeFunctionPtr;

		// Token: 0x04004DD4 RID: 19924
		private static IntPtr __OutU32Set_NativeFunctionPtr;

		// Token: 0x04004DD5 RID: 19925
		private static IntPtr __OutU32Map_NativeFunctionPtr;

		// Token: 0x04004DD6 RID: 19926
		private static IntPtr __OutU32Array_NativeFunctionPtr;

		// Token: 0x04004DD7 RID: 19927
		private static IntPtr __OutU32_NativeFunctionPtr;

		// Token: 0x04004DD8 RID: 19928
		private static IntPtr __OutU16Set_NativeFunctionPtr;

		// Token: 0x04004DD9 RID: 19929
		private static IntPtr __OutU16Map_NativeFunctionPtr;

		// Token: 0x04004DDA RID: 19930
		private static IntPtr __OutU16Array_NativeFunctionPtr;

		// Token: 0x04004DDB RID: 19931
		private static IntPtr __OutU16_NativeFunctionPtr;

		// Token: 0x04004DDC RID: 19932
		private static IntPtr __OutI8Set_NativeFunctionPtr;

		// Token: 0x04004DDD RID: 19933
		private static IntPtr __OutI8Map_NativeFunctionPtr;

		// Token: 0x04004DDE RID: 19934
		private static IntPtr __OutI8Array_NativeFunctionPtr;

		// Token: 0x04004DDF RID: 19935
		private static IntPtr __OutI8_NativeFunctionPtr;

		// Token: 0x04004DE0 RID: 19936
		private static IntPtr __OutI64Set_NativeFunctionPtr;

		// Token: 0x04004DE1 RID: 19937
		private static IntPtr __OutI64Map_NativeFunctionPtr;

		// Token: 0x04004DE2 RID: 19938
		private static IntPtr __OutI64Array_NativeFunctionPtr;

		// Token: 0x04004DE3 RID: 19939
		private static IntPtr __OutI64_NativeFunctionPtr;

		// Token: 0x04004DE4 RID: 19940
		private static IntPtr __OutI32Set_NativeFunctionPtr;

		// Token: 0x04004DE5 RID: 19941
		private static IntPtr __OutI32Map_NativeFunctionPtr;

		// Token: 0x04004DE6 RID: 19942
		private static IntPtr __OutI32Array_NativeFunctionPtr;

		// Token: 0x04004DE7 RID: 19943
		private static IntPtr __OutI32_NativeFunctionPtr;

		// Token: 0x04004DE8 RID: 19944
		private static IntPtr __OutI16Set_NativeFunctionPtr;

		// Token: 0x04004DE9 RID: 19945
		private static IntPtr __OutI16Map_NativeFunctionPtr;

		// Token: 0x04004DEA RID: 19946
		private static IntPtr __OutI16Array_NativeFunctionPtr;

		// Token: 0x04004DEB RID: 19947
		private static IntPtr __OutI16_NativeFunctionPtr;

		// Token: 0x04004DEC RID: 19948
		private static IntPtr __OutF64Set_NativeFunctionPtr;

		// Token: 0x04004DED RID: 19949
		private static IntPtr __OutF64Map_NativeFunctionPtr;

		// Token: 0x04004DEE RID: 19950
		private static IntPtr __OutF64Array_NativeFunctionPtr;

		// Token: 0x04004DEF RID: 19951
		private static IntPtr __OutF64_NativeFunctionPtr;

		// Token: 0x04004DF0 RID: 19952
		private static IntPtr __OutF32Set_NativeFunctionPtr;

		// Token: 0x04004DF1 RID: 19953
		private static IntPtr __OutF32Map_NativeFunctionPtr;

		// Token: 0x04004DF2 RID: 19954
		private static IntPtr __OutF32Array_NativeFunctionPtr;

		// Token: 0x04004DF3 RID: 19955
		private static IntPtr __OutF32_NativeFunctionPtr;

		// Token: 0x04004DF4 RID: 19956
		private static IntPtr __OutBoolSet_NativeFunctionPtr;

		// Token: 0x04004DF5 RID: 19957
		private static IntPtr __OutBoolMap_NativeFunctionPtr;

		// Token: 0x04004DF6 RID: 19958
		private static IntPtr __OutBoolArray_NativeFunctionPtr;

		// Token: 0x04004DF7 RID: 19959
		private static IntPtr __OutBool_NativeFunctionPtr;

		// Token: 0x04004DF8 RID: 19960
		private static IntPtr __InU8Set_NativeFunctionPtr;

		// Token: 0x04004DF9 RID: 19961
		private static IntPtr __InU8Map_NativeFunctionPtr;

		// Token: 0x04004DFA RID: 19962
		private static IntPtr __InU8Array_NativeFunctionPtr;

		// Token: 0x04004DFB RID: 19963
		private static IntPtr __InU8_NativeFunctionPtr;

		// Token: 0x04004DFC RID: 19964
		private static IntPtr __InU64Set_NativeFunctionPtr;

		// Token: 0x04004DFD RID: 19965
		private static IntPtr __InU64Map_NativeFunctionPtr;

		// Token: 0x04004DFE RID: 19966
		private static IntPtr __InU64Array_NativeFunctionPtr;

		// Token: 0x04004DFF RID: 19967
		private static IntPtr __InU64_NativeFunctionPtr;

		// Token: 0x04004E00 RID: 19968
		private static IntPtr __InU32Set_NativeFunctionPtr;

		// Token: 0x04004E01 RID: 19969
		private static IntPtr __InU32Map_NativeFunctionPtr;

		// Token: 0x04004E02 RID: 19970
		private static IntPtr __InU32Array_NativeFunctionPtr;

		// Token: 0x04004E03 RID: 19971
		private static IntPtr __InU32_NativeFunctionPtr;

		// Token: 0x04004E04 RID: 19972
		private static IntPtr __InU16Set_NativeFunctionPtr;

		// Token: 0x04004E05 RID: 19973
		private static IntPtr __InU16Map_NativeFunctionPtr;

		// Token: 0x04004E06 RID: 19974
		private static IntPtr __InU16Array_NativeFunctionPtr;

		// Token: 0x04004E07 RID: 19975
		private static IntPtr __InU16_NativeFunctionPtr;

		// Token: 0x04004E08 RID: 19976
		private static IntPtr __InI8Set_NativeFunctionPtr;

		// Token: 0x04004E09 RID: 19977
		private static IntPtr __InI8Map_NativeFunctionPtr;

		// Token: 0x04004E0A RID: 19978
		private static IntPtr __InI8Array_NativeFunctionPtr;

		// Token: 0x04004E0B RID: 19979
		private static IntPtr __InI8_NativeFunctionPtr;

		// Token: 0x04004E0C RID: 19980
		private static IntPtr __InI64Set_NativeFunctionPtr;

		// Token: 0x04004E0D RID: 19981
		private static IntPtr __InI64Map_NativeFunctionPtr;

		// Token: 0x04004E0E RID: 19982
		private static IntPtr __InI64Array_NativeFunctionPtr;

		// Token: 0x04004E0F RID: 19983
		private static IntPtr __InI64_NativeFunctionPtr;

		// Token: 0x04004E10 RID: 19984
		private static IntPtr __InI32Set_NativeFunctionPtr;

		// Token: 0x04004E11 RID: 19985
		private static IntPtr __InI32Map_NativeFunctionPtr;

		// Token: 0x04004E12 RID: 19986
		private static IntPtr __InI32Array_NativeFunctionPtr;

		// Token: 0x04004E13 RID: 19987
		private static IntPtr __InI32_NativeFunctionPtr;

		// Token: 0x04004E14 RID: 19988
		private static IntPtr __InI16Set_NativeFunctionPtr;

		// Token: 0x04004E15 RID: 19989
		private static IntPtr __InI16Map_NativeFunctionPtr;

		// Token: 0x04004E16 RID: 19990
		private static IntPtr __InI16Array_NativeFunctionPtr;

		// Token: 0x04004E17 RID: 19991
		private static IntPtr __InI16_NativeFunctionPtr;

		// Token: 0x04004E18 RID: 19992
		private static IntPtr __InF64Set_NativeFunctionPtr;

		// Token: 0x04004E19 RID: 19993
		private static IntPtr __InF64Map_NativeFunctionPtr;

		// Token: 0x04004E1A RID: 19994
		private static IntPtr __InF64Array_NativeFunctionPtr;

		// Token: 0x04004E1B RID: 19995
		private static IntPtr __InF64_NativeFunctionPtr;

		// Token: 0x04004E1C RID: 19996
		private static IntPtr __InF32Set_NativeFunctionPtr;

		// Token: 0x04004E1D RID: 19997
		private static IntPtr __InF32Map_NativeFunctionPtr;

		// Token: 0x04004E1E RID: 19998
		private static IntPtr __InF32Array_NativeFunctionPtr;

		// Token: 0x04004E1F RID: 19999
		private static IntPtr __InF32_NativeFunctionPtr;

		// Token: 0x04004E20 RID: 20000
		private static IntPtr __InBoolSet_NativeFunctionPtr;

		// Token: 0x04004E21 RID: 20001
		private static IntPtr __InBoolMap_NativeFunctionPtr;

		// Token: 0x04004E22 RID: 20002
		private static IntPtr __InBoolArray_NativeFunctionPtr;

		// Token: 0x04004E23 RID: 20003
		private static IntPtr __InBool_NativeFunctionPtr;

		// Token: 0x04004E24 RID: 20004
		private static IntPtr __GetU8Set_NativeFunctionPtr;

		// Token: 0x04004E25 RID: 20005
		private static IntPtr __GetU8Map_NativeFunctionPtr;

		// Token: 0x04004E26 RID: 20006
		private static IntPtr __GetU8Array_NativeFunctionPtr;

		// Token: 0x04004E27 RID: 20007
		private static IntPtr __GetU8_NativeFunctionPtr;

		// Token: 0x04004E28 RID: 20008
		private static IntPtr __GetU64Set_NativeFunctionPtr;

		// Token: 0x04004E29 RID: 20009
		private static IntPtr __GetU64Map_NativeFunctionPtr;

		// Token: 0x04004E2A RID: 20010
		private static IntPtr __GetU64Array_NativeFunctionPtr;

		// Token: 0x04004E2B RID: 20011
		private static IntPtr __GetU64_NativeFunctionPtr;

		// Token: 0x04004E2C RID: 20012
		private static IntPtr __GetU32Set_NativeFunctionPtr;

		// Token: 0x04004E2D RID: 20013
		private static IntPtr __GetU32Map_NativeFunctionPtr;

		// Token: 0x04004E2E RID: 20014
		private static IntPtr __GetU32Array_NativeFunctionPtr;

		// Token: 0x04004E2F RID: 20015
		private static IntPtr __GetU32_NativeFunctionPtr;

		// Token: 0x04004E30 RID: 20016
		private static IntPtr __GetU16Set_NativeFunctionPtr;

		// Token: 0x04004E31 RID: 20017
		private static IntPtr __GetU16Map_NativeFunctionPtr;

		// Token: 0x04004E32 RID: 20018
		private static IntPtr __GetU16Array_NativeFunctionPtr;

		// Token: 0x04004E33 RID: 20019
		private static IntPtr __GetU16_NativeFunctionPtr;

		// Token: 0x04004E34 RID: 20020
		private static IntPtr __GetI8Set_NativeFunctionPtr;

		// Token: 0x04004E35 RID: 20021
		private static IntPtr __GetI8Map_NativeFunctionPtr;

		// Token: 0x04004E36 RID: 20022
		private static IntPtr __GetI8Array_NativeFunctionPtr;

		// Token: 0x04004E37 RID: 20023
		private static IntPtr __GetI8_NativeFunctionPtr;

		// Token: 0x04004E38 RID: 20024
		private static IntPtr __GetI64Set_NativeFunctionPtr;

		// Token: 0x04004E39 RID: 20025
		private static IntPtr __GetI64Map_NativeFunctionPtr;

		// Token: 0x04004E3A RID: 20026
		private static IntPtr __GetI64Array_NativeFunctionPtr;

		// Token: 0x04004E3B RID: 20027
		private static IntPtr __GetI64_NativeFunctionPtr;

		// Token: 0x04004E3C RID: 20028
		private static IntPtr __GetI32Set_NativeFunctionPtr;

		// Token: 0x04004E3D RID: 20029
		private static IntPtr __GetI32Map_NativeFunctionPtr;

		// Token: 0x04004E3E RID: 20030
		private static IntPtr __GetI32Array_NativeFunctionPtr;

		// Token: 0x04004E3F RID: 20031
		private static IntPtr __GetI32_NativeFunctionPtr;

		// Token: 0x04004E40 RID: 20032
		private static IntPtr __GetI16Set_NativeFunctionPtr;

		// Token: 0x04004E41 RID: 20033
		private static IntPtr __GetI16Map_NativeFunctionPtr;

		// Token: 0x04004E42 RID: 20034
		private static IntPtr __GetI16Array_NativeFunctionPtr;

		// Token: 0x04004E43 RID: 20035
		private static IntPtr __GetI16_NativeFunctionPtr;

		// Token: 0x04004E44 RID: 20036
		private static IntPtr __GetF64Set_NativeFunctionPtr;

		// Token: 0x04004E45 RID: 20037
		private static IntPtr __GetF64Map_NativeFunctionPtr;

		// Token: 0x04004E46 RID: 20038
		private static IntPtr __GetF64Array_NativeFunctionPtr;

		// Token: 0x04004E47 RID: 20039
		private static IntPtr __GetF64_NativeFunctionPtr;

		// Token: 0x04004E48 RID: 20040
		private static IntPtr __GetF32Set_NativeFunctionPtr;

		// Token: 0x04004E49 RID: 20041
		private static IntPtr __GetF32Map_NativeFunctionPtr;

		// Token: 0x04004E4A RID: 20042
		private static IntPtr __GetF32Array_NativeFunctionPtr;

		// Token: 0x04004E4B RID: 20043
		private static IntPtr __GetF32_NativeFunctionPtr;

		// Token: 0x04004E4C RID: 20044
		private static IntPtr __GetBoolSet_NativeFunctionPtr;

		// Token: 0x04004E4D RID: 20045
		private static IntPtr __GetBoolMap_NativeFunctionPtr;

		// Token: 0x04004E4E RID: 20046
		private static IntPtr __GetBoolArray_NativeFunctionPtr;

		// Token: 0x04004E4F RID: 20047
		private static IntPtr __GetBool_NativeFunctionPtr;

		// Token: 0x02001055 RID: 4181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Set_FunctionParams
		{
			// Token: 0x0400645D RID: 25693
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x02001056 RID: 4182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU8Map_FunctionParams
		{
			// Token: 0x0400645E RID: 25694
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x02001057 RID: 4183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU8Array_FunctionParams
		{
			// Token: 0x0400645F RID: 25695
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x02001058 RID: 4184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetU8_FunctionParams
		{
			// Token: 0x04006460 RID: 25696
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x02001059 RID: 4185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Set_FunctionParams
		{
			// Token: 0x04006461 RID: 25697
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x0200105A RID: 4186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU64Map_FunctionParams
		{
			// Token: 0x04006462 RID: 25698
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x0200105B RID: 4187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU64Array_FunctionParams
		{
			// Token: 0x04006463 RID: 25699
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x0200105C RID: 4188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetU64_FunctionParams
		{
			// Token: 0x04006464 RID: 25700
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x0200105D RID: 4189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Set_FunctionParams
		{
			// Token: 0x04006465 RID: 25701
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x0200105E RID: 4190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU32Map_FunctionParams
		{
			// Token: 0x04006466 RID: 25702
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x0200105F RID: 4191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU32Array_FunctionParams
		{
			// Token: 0x04006467 RID: 25703
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x02001060 RID: 4192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetU32_FunctionParams
		{
			// Token: 0x04006468 RID: 25704
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x02001061 RID: 4193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Set_FunctionParams
		{
			// Token: 0x04006469 RID: 25705
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x02001062 RID: 4194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetU16Map_FunctionParams
		{
			// Token: 0x0400646A RID: 25706
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x02001063 RID: 4195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetU16Array_FunctionParams
		{
			// Token: 0x0400646B RID: 25707
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x02001064 RID: 4196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetU16_FunctionParams
		{
			// Token: 0x0400646C RID: 25708
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x02001065 RID: 4197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Set_FunctionParams
		{
			// Token: 0x0400646D RID: 25709
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x02001066 RID: 4198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI8Map_FunctionParams
		{
			// Token: 0x0400646E RID: 25710
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x02001067 RID: 4199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI8Array_FunctionParams
		{
			// Token: 0x0400646F RID: 25711
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x02001068 RID: 4200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetI8_FunctionParams
		{
			// Token: 0x04006470 RID: 25712
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x02001069 RID: 4201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Set_FunctionParams
		{
			// Token: 0x04006471 RID: 25713
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x0200106A RID: 4202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI64Map_FunctionParams
		{
			// Token: 0x04006472 RID: 25714
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x0200106B RID: 4203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI64Array_FunctionParams
		{
			// Token: 0x04006473 RID: 25715
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x0200106C RID: 4204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetI64_FunctionParams
		{
			// Token: 0x04006474 RID: 25716
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x0200106D RID: 4205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Set_FunctionParams
		{
			// Token: 0x04006475 RID: 25717
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x0200106E RID: 4206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI32Map_FunctionParams
		{
			// Token: 0x04006476 RID: 25718
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x0200106F RID: 4207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI32Array_FunctionParams
		{
			// Token: 0x04006477 RID: 25719
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x02001070 RID: 4208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetI32_FunctionParams
		{
			// Token: 0x04006478 RID: 25720
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x02001071 RID: 4209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Set_FunctionParams
		{
			// Token: 0x04006479 RID: 25721
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x02001072 RID: 4210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetI16Map_FunctionParams
		{
			// Token: 0x0400647A RID: 25722
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x02001073 RID: 4211
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetI16Array_FunctionParams
		{
			// Token: 0x0400647B RID: 25723
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x02001074 RID: 4212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetI16_FunctionParams
		{
			// Token: 0x0400647C RID: 25724
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x02001075 RID: 4213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Set_FunctionParams
		{
			// Token: 0x0400647D RID: 25725
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x02001076 RID: 4214
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF64Map_FunctionParams
		{
			// Token: 0x0400647E RID: 25726
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x02001077 RID: 4215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF64Array_FunctionParams
		{
			// Token: 0x0400647F RID: 25727
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x02001078 RID: 4216
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetF64_FunctionParams
		{
			// Token: 0x04006480 RID: 25728
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x02001079 RID: 4217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Set_FunctionParams
		{
			// Token: 0x04006481 RID: 25729
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x0200107A RID: 4218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetF32Map_FunctionParams
		{
			// Token: 0x04006482 RID: 25730
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x0200107B RID: 4219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetF32Array_FunctionParams
		{
			// Token: 0x04006483 RID: 25731
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x0200107C RID: 4220
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetF32_FunctionParams
		{
			// Token: 0x04006484 RID: 25732
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x0200107D RID: 4221
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolSet_FunctionParams
		{
			// Token: 0x04006485 RID: 25733
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x0200107E RID: 4222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoolMap_FunctionParams
		{
			// Token: 0x04006486 RID: 25734
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x0200107F RID: 4223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBoolArray_FunctionParams
		{
			// Token: 0x04006487 RID: 25735
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x02001080 RID: 4224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetBool_FunctionParams
		{
			// Token: 0x04006488 RID: 25736
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x02001081 RID: 4225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Set_FunctionParams
		{
			// Token: 0x04006489 RID: 25737
			[FieldOffset(0)]
			public byte OutU8Set;
		}

		// Token: 0x02001082 RID: 4226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU8Map_FunctionParams
		{
			// Token: 0x0400648A RID: 25738
			[FieldOffset(0)]
			public byte OutU8Map;
		}

		// Token: 0x02001083 RID: 4227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU8Array_FunctionParams
		{
			// Token: 0x0400648B RID: 25739
			[FieldOffset(0)]
			public byte OutU8Array;
		}

		// Token: 0x02001084 RID: 4228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutU8_FunctionParams
		{
			// Token: 0x0400648C RID: 25740
			[FieldOffset(0)]
			public byte OutU8;
		}

		// Token: 0x02001085 RID: 4229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Set_FunctionParams
		{
			// Token: 0x0400648D RID: 25741
			[FieldOffset(0)]
			public byte OutU64Set;
		}

		// Token: 0x02001086 RID: 4230
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU64Map_FunctionParams
		{
			// Token: 0x0400648E RID: 25742
			[FieldOffset(0)]
			public byte OutU64Map;
		}

		// Token: 0x02001087 RID: 4231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU64Array_FunctionParams
		{
			// Token: 0x0400648F RID: 25743
			[FieldOffset(0)]
			public byte OutU64Array;
		}

		// Token: 0x02001088 RID: 4232
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutU64_FunctionParams
		{
			// Token: 0x04006490 RID: 25744
			[FieldOffset(0)]
			public ulong OutU64;
		}

		// Token: 0x02001089 RID: 4233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Set_FunctionParams
		{
			// Token: 0x04006491 RID: 25745
			[FieldOffset(0)]
			public byte OutU32Set;
		}

		// Token: 0x0200108A RID: 4234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU32Map_FunctionParams
		{
			// Token: 0x04006492 RID: 25746
			[FieldOffset(0)]
			public byte OutU32Map;
		}

		// Token: 0x0200108B RID: 4235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU32Array_FunctionParams
		{
			// Token: 0x04006493 RID: 25747
			[FieldOffset(0)]
			public byte OutU32Array;
		}

		// Token: 0x0200108C RID: 4236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutU32_FunctionParams
		{
			// Token: 0x04006494 RID: 25748
			[FieldOffset(0)]
			public uint OutU32;
		}

		// Token: 0x0200108D RID: 4237
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Set_FunctionParams
		{
			// Token: 0x04006495 RID: 25749
			[FieldOffset(0)]
			public byte OutU16Set;
		}

		// Token: 0x0200108E RID: 4238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutU16Map_FunctionParams
		{
			// Token: 0x04006496 RID: 25750
			[FieldOffset(0)]
			public byte OutU16Map;
		}

		// Token: 0x0200108F RID: 4239
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutU16Array_FunctionParams
		{
			// Token: 0x04006497 RID: 25751
			[FieldOffset(0)]
			public byte OutU16Array;
		}

		// Token: 0x02001090 RID: 4240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutU16_FunctionParams
		{
			// Token: 0x04006498 RID: 25752
			[FieldOffset(0)]
			public ushort OutU16;
		}

		// Token: 0x02001091 RID: 4241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Set_FunctionParams
		{
			// Token: 0x04006499 RID: 25753
			[FieldOffset(0)]
			public byte OutI8Set;
		}

		// Token: 0x02001092 RID: 4242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI8Map_FunctionParams
		{
			// Token: 0x0400649A RID: 25754
			[FieldOffset(0)]
			public byte OutI8Map;
		}

		// Token: 0x02001093 RID: 4243
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI8Array_FunctionParams
		{
			// Token: 0x0400649B RID: 25755
			[FieldOffset(0)]
			public byte OutI8Array;
		}

		// Token: 0x02001094 RID: 4244
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutI8_FunctionParams
		{
			// Token: 0x0400649C RID: 25756
			[FieldOffset(0)]
			public sbyte OutI8;
		}

		// Token: 0x02001095 RID: 4245
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Set_FunctionParams
		{
			// Token: 0x0400649D RID: 25757
			[FieldOffset(0)]
			public byte OutI64Set;
		}

		// Token: 0x02001096 RID: 4246
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI64Map_FunctionParams
		{
			// Token: 0x0400649E RID: 25758
			[FieldOffset(0)]
			public byte OutI64Map;
		}

		// Token: 0x02001097 RID: 4247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI64Array_FunctionParams
		{
			// Token: 0x0400649F RID: 25759
			[FieldOffset(0)]
			public byte OutI64Array;
		}

		// Token: 0x02001098 RID: 4248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutI64_FunctionParams
		{
			// Token: 0x040064A0 RID: 25760
			[FieldOffset(0)]
			public long OutI64;
		}

		// Token: 0x02001099 RID: 4249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Set_FunctionParams
		{
			// Token: 0x040064A1 RID: 25761
			[FieldOffset(0)]
			public byte OutI32Set;
		}

		// Token: 0x0200109A RID: 4250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI32Map_FunctionParams
		{
			// Token: 0x040064A2 RID: 25762
			[FieldOffset(0)]
			public byte OutI32Map;
		}

		// Token: 0x0200109B RID: 4251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI32Array_FunctionParams
		{
			// Token: 0x040064A3 RID: 25763
			[FieldOffset(0)]
			public byte OutI32Array;
		}

		// Token: 0x0200109C RID: 4252
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutI32_FunctionParams
		{
			// Token: 0x040064A4 RID: 25764
			[FieldOffset(0)]
			public int OutI32;
		}

		// Token: 0x0200109D RID: 4253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Set_FunctionParams
		{
			// Token: 0x040064A5 RID: 25765
			[FieldOffset(0)]
			public byte OutI16Set;
		}

		// Token: 0x0200109E RID: 4254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutI16Map_FunctionParams
		{
			// Token: 0x040064A6 RID: 25766
			[FieldOffset(0)]
			public byte OutI16Map;
		}

		// Token: 0x0200109F RID: 4255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutI16Array_FunctionParams
		{
			// Token: 0x040064A7 RID: 25767
			[FieldOffset(0)]
			public byte OutI16Array;
		}

		// Token: 0x020010A0 RID: 4256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OutI16_FunctionParams
		{
			// Token: 0x040064A8 RID: 25768
			[FieldOffset(0)]
			public short OutI16;
		}

		// Token: 0x020010A1 RID: 4257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Set_FunctionParams
		{
			// Token: 0x040064A9 RID: 25769
			[FieldOffset(0)]
			public byte OutF64Set;
		}

		// Token: 0x020010A2 RID: 4258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF64Map_FunctionParams
		{
			// Token: 0x040064AA RID: 25770
			[FieldOffset(0)]
			public byte OutF64Map;
		}

		// Token: 0x020010A3 RID: 4259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF64Array_FunctionParams
		{
			// Token: 0x040064AB RID: 25771
			[FieldOffset(0)]
			public byte OutF64Array;
		}

		// Token: 0x020010A4 RID: 4260
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutF64_FunctionParams
		{
			// Token: 0x040064AC RID: 25772
			[FieldOffset(0)]
			public double OutF64;
		}

		// Token: 0x020010A5 RID: 4261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Set_FunctionParams
		{
			// Token: 0x040064AD RID: 25773
			[FieldOffset(0)]
			public byte OutF32Set;
		}

		// Token: 0x020010A6 RID: 4262
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutF32Map_FunctionParams
		{
			// Token: 0x040064AE RID: 25774
			[FieldOffset(0)]
			public byte OutF32Map;
		}

		// Token: 0x020010A7 RID: 4263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutF32Array_FunctionParams
		{
			// Token: 0x040064AF RID: 25775
			[FieldOffset(0)]
			public byte OutF32Array;
		}

		// Token: 0x020010A8 RID: 4264
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OutF32_FunctionParams
		{
			// Token: 0x040064B0 RID: 25776
			[FieldOffset(0)]
			public float OutF32;
		}

		// Token: 0x020010A9 RID: 4265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolSet_FunctionParams
		{
			// Token: 0x040064B1 RID: 25777
			[FieldOffset(0)]
			public byte OutBoolSet;
		}

		// Token: 0x020010AA RID: 4266
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutBoolMap_FunctionParams
		{
			// Token: 0x040064B2 RID: 25778
			[FieldOffset(0)]
			public byte OutBoolMap;
		}

		// Token: 0x020010AB RID: 4267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutBoolArray_FunctionParams
		{
			// Token: 0x040064B3 RID: 25779
			[FieldOffset(0)]
			public byte OutBoolArray;
		}

		// Token: 0x020010AC RID: 4268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutBool_FunctionParams
		{
			// Token: 0x040064B4 RID: 25780
			[FieldOffset(0)]
			public bool OutBool;
		}

		// Token: 0x020010AD RID: 4269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Set_FunctionParams
		{
			// Token: 0x040064B5 RID: 25781
			[FieldOffset(0)]
			public byte InU8Set;
		}

		// Token: 0x020010AE RID: 4270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU8Map_FunctionParams
		{
			// Token: 0x040064B6 RID: 25782
			[FieldOffset(0)]
			public byte InU8Map;
		}

		// Token: 0x020010AF RID: 4271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU8Array_FunctionParams
		{
			// Token: 0x040064B7 RID: 25783
			[FieldOffset(0)]
			public byte InU8Array;
		}

		// Token: 0x020010B0 RID: 4272
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InU8_FunctionParams
		{
			// Token: 0x040064B8 RID: 25784
			[FieldOffset(0)]
			public byte InU8;
		}

		// Token: 0x020010B1 RID: 4273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Set_FunctionParams
		{
			// Token: 0x040064B9 RID: 25785
			[FieldOffset(0)]
			public byte InU64Set;
		}

		// Token: 0x020010B2 RID: 4274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU64Map_FunctionParams
		{
			// Token: 0x040064BA RID: 25786
			[FieldOffset(0)]
			public byte InU64Map;
		}

		// Token: 0x020010B3 RID: 4275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU64Array_FunctionParams
		{
			// Token: 0x040064BB RID: 25787
			[FieldOffset(0)]
			public byte InU64Array;
		}

		// Token: 0x020010B4 RID: 4276
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InU64_FunctionParams
		{
			// Token: 0x040064BC RID: 25788
			[FieldOffset(0)]
			public ulong InU64;
		}

		// Token: 0x020010B5 RID: 4277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Set_FunctionParams
		{
			// Token: 0x040064BD RID: 25789
			[FieldOffset(0)]
			public byte InU32Set;
		}

		// Token: 0x020010B6 RID: 4278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU32Map_FunctionParams
		{
			// Token: 0x040064BE RID: 25790
			[FieldOffset(0)]
			public byte InU32Map;
		}

		// Token: 0x020010B7 RID: 4279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU32Array_FunctionParams
		{
			// Token: 0x040064BF RID: 25791
			[FieldOffset(0)]
			public byte InU32Array;
		}

		// Token: 0x020010B8 RID: 4280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InU32_FunctionParams
		{
			// Token: 0x040064C0 RID: 25792
			[FieldOffset(0)]
			public uint InU32;
		}

		// Token: 0x020010B9 RID: 4281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Set_FunctionParams
		{
			// Token: 0x040064C1 RID: 25793
			[FieldOffset(0)]
			public byte InU16Set;
		}

		// Token: 0x020010BA RID: 4282
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InU16Map_FunctionParams
		{
			// Token: 0x040064C2 RID: 25794
			[FieldOffset(0)]
			public byte InU16Map;
		}

		// Token: 0x020010BB RID: 4283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InU16Array_FunctionParams
		{
			// Token: 0x040064C3 RID: 25795
			[FieldOffset(0)]
			public byte InU16Array;
		}

		// Token: 0x020010BC RID: 4284
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InU16_FunctionParams
		{
			// Token: 0x040064C4 RID: 25796
			[FieldOffset(0)]
			public ushort InU16;
		}

		// Token: 0x020010BD RID: 4285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Set_FunctionParams
		{
			// Token: 0x040064C5 RID: 25797
			[FieldOffset(0)]
			public byte InI8Set;
		}

		// Token: 0x020010BE RID: 4286
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI8Map_FunctionParams
		{
			// Token: 0x040064C6 RID: 25798
			[FieldOffset(0)]
			public byte InI8Map;
		}

		// Token: 0x020010BF RID: 4287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI8Array_FunctionParams
		{
			// Token: 0x040064C7 RID: 25799
			[FieldOffset(0)]
			public byte InI8Array;
		}

		// Token: 0x020010C0 RID: 4288
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InI8_FunctionParams
		{
			// Token: 0x040064C8 RID: 25800
			[FieldOffset(0)]
			public sbyte InI8;
		}

		// Token: 0x020010C1 RID: 4289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Set_FunctionParams
		{
			// Token: 0x040064C9 RID: 25801
			[FieldOffset(0)]
			public byte InI64Set;
		}

		// Token: 0x020010C2 RID: 4290
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI64Map_FunctionParams
		{
			// Token: 0x040064CA RID: 25802
			[FieldOffset(0)]
			public byte InI64Map;
		}

		// Token: 0x020010C3 RID: 4291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI64Array_FunctionParams
		{
			// Token: 0x040064CB RID: 25803
			[FieldOffset(0)]
			public byte InI64Array;
		}

		// Token: 0x020010C4 RID: 4292
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InI64_FunctionParams
		{
			// Token: 0x040064CC RID: 25804
			[FieldOffset(0)]
			public long InI64;
		}

		// Token: 0x020010C5 RID: 4293
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Set_FunctionParams
		{
			// Token: 0x040064CD RID: 25805
			[FieldOffset(0)]
			public byte InI32Set;
		}

		// Token: 0x020010C6 RID: 4294
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI32Map_FunctionParams
		{
			// Token: 0x040064CE RID: 25806
			[FieldOffset(0)]
			public byte InI32Map;
		}

		// Token: 0x020010C7 RID: 4295
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI32Array_FunctionParams
		{
			// Token: 0x040064CF RID: 25807
			[FieldOffset(0)]
			public byte InI32Array;
		}

		// Token: 0x020010C8 RID: 4296
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InI32_FunctionParams
		{
			// Token: 0x040064D0 RID: 25808
			[FieldOffset(0)]
			public int InI32;
		}

		// Token: 0x020010C9 RID: 4297
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Set_FunctionParams
		{
			// Token: 0x040064D1 RID: 25809
			[FieldOffset(0)]
			public byte InI16Set;
		}

		// Token: 0x020010CA RID: 4298
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InI16Map_FunctionParams
		{
			// Token: 0x040064D2 RID: 25810
			[FieldOffset(0)]
			public byte InI16Map;
		}

		// Token: 0x020010CB RID: 4299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InI16Array_FunctionParams
		{
			// Token: 0x040064D3 RID: 25811
			[FieldOffset(0)]
			public byte InI16Array;
		}

		// Token: 0x020010CC RID: 4300
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __InI16_FunctionParams
		{
			// Token: 0x040064D4 RID: 25812
			[FieldOffset(0)]
			public short InI16;
		}

		// Token: 0x020010CD RID: 4301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Set_FunctionParams
		{
			// Token: 0x040064D5 RID: 25813
			[FieldOffset(0)]
			public byte InF64Set;
		}

		// Token: 0x020010CE RID: 4302
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF64Map_FunctionParams
		{
			// Token: 0x040064D6 RID: 25814
			[FieldOffset(0)]
			public byte InF64Map;
		}

		// Token: 0x020010CF RID: 4303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF64Array_FunctionParams
		{
			// Token: 0x040064D7 RID: 25815
			[FieldOffset(0)]
			public byte InF64Array;
		}

		// Token: 0x020010D0 RID: 4304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InF64_FunctionParams
		{
			// Token: 0x040064D8 RID: 25816
			[FieldOffset(0)]
			public double InF64;
		}

		// Token: 0x020010D1 RID: 4305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Set_FunctionParams
		{
			// Token: 0x040064D9 RID: 25817
			[FieldOffset(0)]
			public byte InF32Set;
		}

		// Token: 0x020010D2 RID: 4306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InF32Map_FunctionParams
		{
			// Token: 0x040064DA RID: 25818
			[FieldOffset(0)]
			public byte InF32Map;
		}

		// Token: 0x020010D3 RID: 4307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InF32Array_FunctionParams
		{
			// Token: 0x040064DB RID: 25819
			[FieldOffset(0)]
			public byte InF32Array;
		}

		// Token: 0x020010D4 RID: 4308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InF32_FunctionParams
		{
			// Token: 0x040064DC RID: 25820
			[FieldOffset(0)]
			public float InF32;
		}

		// Token: 0x020010D5 RID: 4309
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolSet_FunctionParams
		{
			// Token: 0x040064DD RID: 25821
			[FieldOffset(0)]
			public byte InBoolSet;
		}

		// Token: 0x020010D6 RID: 4310
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InBoolMap_FunctionParams
		{
			// Token: 0x040064DE RID: 25822
			[FieldOffset(0)]
			public byte InBoolMap;
		}

		// Token: 0x020010D7 RID: 4311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InBoolArray_FunctionParams
		{
			// Token: 0x040064DF RID: 25823
			[FieldOffset(0)]
			public byte InBoolArray;
		}

		// Token: 0x020010D8 RID: 4312
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InBool_FunctionParams
		{
			// Token: 0x040064E0 RID: 25824
			[FieldOffset(0)]
			public bool InBool;
		}

		// Token: 0x020010D9 RID: 4313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Set_FunctionParams
		{
			// Token: 0x040064E1 RID: 25825
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DA RID: 4314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU8Map_FunctionParams
		{
			// Token: 0x040064E2 RID: 25826
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DB RID: 4315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU8Array_FunctionParams
		{
			// Token: 0x040064E3 RID: 25827
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DC RID: 4316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetU8_FunctionParams
		{
			// Token: 0x040064E4 RID: 25828
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DD RID: 4317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Set_FunctionParams
		{
			// Token: 0x040064E5 RID: 25829
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DE RID: 4318
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU64Map_FunctionParams
		{
			// Token: 0x040064E6 RID: 25830
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010DF RID: 4319
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU64Array_FunctionParams
		{
			// Token: 0x040064E7 RID: 25831
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E0 RID: 4320
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetU64_FunctionParams
		{
			// Token: 0x040064E8 RID: 25832
			[FieldOffset(0)]
			public ulong __Result;
		}

		// Token: 0x020010E1 RID: 4321
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Set_FunctionParams
		{
			// Token: 0x040064E9 RID: 25833
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E2 RID: 4322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU32Map_FunctionParams
		{
			// Token: 0x040064EA RID: 25834
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E3 RID: 4323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU32Array_FunctionParams
		{
			// Token: 0x040064EB RID: 25835
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E4 RID: 4324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetU32_FunctionParams
		{
			// Token: 0x040064EC RID: 25836
			[FieldOffset(0)]
			public uint __Result;
		}

		// Token: 0x020010E5 RID: 4325
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Set_FunctionParams
		{
			// Token: 0x040064ED RID: 25837
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E6 RID: 4326
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetU16Map_FunctionParams
		{
			// Token: 0x040064EE RID: 25838
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E7 RID: 4327
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetU16Array_FunctionParams
		{
			// Token: 0x040064EF RID: 25839
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010E8 RID: 4328
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetU16_FunctionParams
		{
			// Token: 0x040064F0 RID: 25840
			[FieldOffset(0)]
			public ushort __Result;
		}

		// Token: 0x020010E9 RID: 4329
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Set_FunctionParams
		{
			// Token: 0x040064F1 RID: 25841
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010EA RID: 4330
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI8Map_FunctionParams
		{
			// Token: 0x040064F2 RID: 25842
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010EB RID: 4331
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI8Array_FunctionParams
		{
			// Token: 0x040064F3 RID: 25843
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010EC RID: 4332
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetI8_FunctionParams
		{
			// Token: 0x040064F4 RID: 25844
			[FieldOffset(0)]
			public sbyte __Result;
		}

		// Token: 0x020010ED RID: 4333
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Set_FunctionParams
		{
			// Token: 0x040064F5 RID: 25845
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010EE RID: 4334
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI64Map_FunctionParams
		{
			// Token: 0x040064F6 RID: 25846
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010EF RID: 4335
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI64Array_FunctionParams
		{
			// Token: 0x040064F7 RID: 25847
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F0 RID: 4336
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetI64_FunctionParams
		{
			// Token: 0x040064F8 RID: 25848
			[FieldOffset(0)]
			public long __Result;
		}

		// Token: 0x020010F1 RID: 4337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Set_FunctionParams
		{
			// Token: 0x040064F9 RID: 25849
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F2 RID: 4338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI32Map_FunctionParams
		{
			// Token: 0x040064FA RID: 25850
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F3 RID: 4339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI32Array_FunctionParams
		{
			// Token: 0x040064FB RID: 25851
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F4 RID: 4340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetI32_FunctionParams
		{
			// Token: 0x040064FC RID: 25852
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020010F5 RID: 4341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Set_FunctionParams
		{
			// Token: 0x040064FD RID: 25853
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F6 RID: 4342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetI16Map_FunctionParams
		{
			// Token: 0x040064FE RID: 25854
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F7 RID: 4343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetI16Array_FunctionParams
		{
			// Token: 0x040064FF RID: 25855
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010F8 RID: 4344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetI16_FunctionParams
		{
			// Token: 0x04006500 RID: 25856
			[FieldOffset(0)]
			public short __Result;
		}

		// Token: 0x020010F9 RID: 4345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Set_FunctionParams
		{
			// Token: 0x04006501 RID: 25857
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010FA RID: 4346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF64Map_FunctionParams
		{
			// Token: 0x04006502 RID: 25858
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010FB RID: 4347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF64Array_FunctionParams
		{
			// Token: 0x04006503 RID: 25859
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010FC RID: 4348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetF64_FunctionParams
		{
			// Token: 0x04006504 RID: 25860
			[FieldOffset(0)]
			public double __Result;
		}

		// Token: 0x020010FD RID: 4349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Set_FunctionParams
		{
			// Token: 0x04006505 RID: 25861
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010FE RID: 4350
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetF32Map_FunctionParams
		{
			// Token: 0x04006506 RID: 25862
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020010FF RID: 4351
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetF32Array_FunctionParams
		{
			// Token: 0x04006507 RID: 25863
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001100 RID: 4352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetF32_FunctionParams
		{
			// Token: 0x04006508 RID: 25864
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02001101 RID: 4353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolSet_FunctionParams
		{
			// Token: 0x04006509 RID: 25865
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001102 RID: 4354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetBoolMap_FunctionParams
		{
			// Token: 0x0400650A RID: 25866
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001103 RID: 4355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoolArray_FunctionParams
		{
			// Token: 0x0400650B RID: 25867
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001104 RID: 4356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetBool_FunctionParams
		{
			// Token: 0x0400650C RID: 25868
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
