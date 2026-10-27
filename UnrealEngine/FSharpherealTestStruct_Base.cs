using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200273C RID: 10044
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2072)]
	public class FSharpherealTestStruct_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060252DE RID: 152286 RVA: 0x0037142A File Offset: 0x0036F62A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Base._ScriptStructPtr != 0) ? FSharpherealTestStruct_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Base", ref FSharpherealTestStruct_Base._ScriptStructPtr);
		}

		// Token: 0x17008F6C RID: 36716
		// (get) Token: 0x060252DF RID: 152287 RVA: 0x0037144E File Offset: 0x0036F64E
		// (set) Token: 0x060252E0 RID: 152288 RVA: 0x0037145E File Offset: 0x0036F65E
		public unsafe bool Bool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008F6D RID: 36717
		// (get) Token: 0x060252E1 RID: 152289 RVA: 0x0037146F File Offset: 0x0036F66F
		// (set) Token: 0x060252E2 RID: 152290 RVA: 0x00371488 File Offset: 0x0036F688
		public unsafe bool Bool1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool1) & FSharpherealTestStruct_Base.__PropertyMask_Bool1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool1) = ((*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool1) & ~FSharpherealTestStruct_Base.__PropertyMask_Bool1) | (value ? FSharpherealTestStruct_Base.__PropertyMask_Bool1 : 0));
			}
		}

		// Token: 0x17008F6E RID: 36718
		// (get) Token: 0x060252E3 RID: 152291 RVA: 0x003714B8 File Offset: 0x0036F6B8
		// (set) Token: 0x060252E4 RID: 152292 RVA: 0x003714D1 File Offset: 0x0036F6D1
		public unsafe bool Bool2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool2) & FSharpherealTestStruct_Base.__PropertyMask_Bool2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool2) = ((*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Bool2) & ~FSharpherealTestStruct_Base.__PropertyMask_Bool2) | (value ? FSharpherealTestStruct_Base.__PropertyMask_Bool2 : 0));
			}
		}

		// Token: 0x17008F6F RID: 36719
		// (get) Token: 0x060252E5 RID: 152293 RVA: 0x00371501 File Offset: 0x0036F701
		// (set) Token: 0x060252E6 RID: 152294 RVA: 0x00371511 File Offset: 0x0036F711
		public unsafe sbyte I8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I8) = (byte)value;
			}
		}

		// Token: 0x17008F70 RID: 36720
		// (get) Token: 0x060252E7 RID: 152295 RVA: 0x00371522 File Offset: 0x0036F722
		// (set) Token: 0x060252E8 RID: 152296 RVA: 0x00371532 File Offset: 0x0036F732
		public unsafe byte U8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U8) = value;
			}
		}

		// Token: 0x17008F71 RID: 36721
		// (get) Token: 0x060252E9 RID: 152297 RVA: 0x00371543 File Offset: 0x0036F743
		// (set) Token: 0x060252EA RID: 152298 RVA: 0x00371553 File Offset: 0x0036F753
		public unsafe short I16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I16) = value;
			}
		}

		// Token: 0x17008F72 RID: 36722
		// (get) Token: 0x060252EB RID: 152299 RVA: 0x00371564 File Offset: 0x0036F764
		// (set) Token: 0x060252EC RID: 152300 RVA: 0x00371574 File Offset: 0x0036F774
		public unsafe ushort U16
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U16) = (short)value;
			}
		}

		// Token: 0x17008F73 RID: 36723
		// (get) Token: 0x060252ED RID: 152301 RVA: 0x00371585 File Offset: 0x0036F785
		// (set) Token: 0x060252EE RID: 152302 RVA: 0x00371595 File Offset: 0x0036F795
		public unsafe int I32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I32) = value;
			}
		}

		// Token: 0x17008F74 RID: 36724
		// (get) Token: 0x060252EF RID: 152303 RVA: 0x003715A6 File Offset: 0x0036F7A6
		// (set) Token: 0x060252F0 RID: 152304 RVA: 0x003715B6 File Offset: 0x0036F7B6
		public unsafe uint U32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U32) = (int)value;
			}
		}

		// Token: 0x17008F75 RID: 36725
		// (get) Token: 0x060252F1 RID: 152305 RVA: 0x003715C7 File Offset: 0x0036F7C7
		// (set) Token: 0x060252F2 RID: 152306 RVA: 0x003715D7 File Offset: 0x0036F7D7
		public unsafe long I64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_I64) = value;
			}
		}

		// Token: 0x17008F76 RID: 36726
		// (get) Token: 0x060252F3 RID: 152307 RVA: 0x003715E8 File Offset: 0x0036F7E8
		// (set) Token: 0x060252F4 RID: 152308 RVA: 0x003715F8 File Offset: 0x0036F7F8
		public unsafe ulong U64
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U64));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_U64) = (long)value;
			}
		}

		// Token: 0x17008F77 RID: 36727
		// (get) Token: 0x060252F5 RID: 152309 RVA: 0x00371609 File Offset: 0x0036F809
		// (set) Token: 0x060252F6 RID: 152310 RVA: 0x00371619 File Offset: 0x0036F819
		public unsafe float F32
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_F32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_F32) = value;
			}
		}

		// Token: 0x17008F78 RID: 36728
		// (get) Token: 0x060252F7 RID: 152311 RVA: 0x0037162A File Offset: 0x0036F82A
		// (set) Token: 0x060252F8 RID: 152312 RVA: 0x0037163A File Offset: 0x0036F83A
		public unsafe double F64
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_F64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_F64) = value;
			}
		}

		// Token: 0x17008F79 RID: 36729
		// (get) Token: 0x060252F9 RID: 152313 RVA: 0x0037164C File Offset: 0x0036F84C
		// (set) Token: 0x060252FA RID: 152314 RVA: 0x0037168F File Offset: 0x0036F88F
		public TArray<bool> BoolArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._BoolArray) == null)
				{
					result = (this._BoolArray = new TArray<bool>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_BoolArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoolArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F7A RID: 36730
		// (get) Token: 0x060252FB RID: 152315 RVA: 0x003716A0 File Offset: 0x0036F8A0
		// (set) Token: 0x060252FC RID: 152316 RVA: 0x003716E3 File Offset: 0x0036F8E3
		public TArray<sbyte> Int8Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._Int8Array) == null)
				{
					result = (this._Int8Array = new TArray<sbyte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int8Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int8Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F7B RID: 36731
		// (get) Token: 0x060252FD RID: 152317 RVA: 0x003716F4 File Offset: 0x0036F8F4
		// (set) Token: 0x060252FE RID: 152318 RVA: 0x00371737 File Offset: 0x0036F937
		public TArray<byte> Uint8Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Uint8Array) == null)
				{
					result = (this._Uint8Array = new TArray<byte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint8Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint8Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F7C RID: 36732
		// (get) Token: 0x060252FF RID: 152319 RVA: 0x00371748 File Offset: 0x0036F948
		// (set) Token: 0x06025300 RID: 152320 RVA: 0x0037178B File Offset: 0x0036F98B
		public TArray<short> Int16Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<short> result;
				if ((result = this._Int16Array) == null)
				{
					result = (this._Int16Array = new TArray<short>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int16Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int16Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F7D RID: 36733
		// (get) Token: 0x06025301 RID: 152321 RVA: 0x0037179C File Offset: 0x0036F99C
		// (set) Token: 0x06025302 RID: 152322 RVA: 0x003717DF File Offset: 0x0036F9DF
		public TArray<ushort> Uint16Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._Uint16Array) == null)
				{
					result = (this._Uint16Array = new TArray<ushort>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint16Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint16Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F7E RID: 36734
		// (get) Token: 0x06025303 RID: 152323 RVA: 0x003717F0 File Offset: 0x0036F9F0
		// (set) Token: 0x06025304 RID: 152324 RVA: 0x00371833 File Offset: 0x0036FA33
		public TArray<int> Int32Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Int32Array) == null)
				{
					result = (this._Int32Array = new TArray<int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int32Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F7F RID: 36735
		// (get) Token: 0x06025305 RID: 152325 RVA: 0x00371844 File Offset: 0x0036FA44
		// (set) Token: 0x06025306 RID: 152326 RVA: 0x00371887 File Offset: 0x0036FA87
		public TArray<uint> Uint32Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Uint32Array) == null)
				{
					result = (this._Uint32Array = new TArray<uint>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint32Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint32Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F80 RID: 36736
		// (get) Token: 0x06025307 RID: 152327 RVA: 0x00371898 File Offset: 0x0036FA98
		// (set) Token: 0x06025308 RID: 152328 RVA: 0x003718DB File Offset: 0x0036FADB
		public TArray<long> Int64Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Int64Array) == null)
				{
					result = (this._Int64Array = new TArray<long>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int64Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int64Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F81 RID: 36737
		// (get) Token: 0x06025309 RID: 152329 RVA: 0x003718EC File Offset: 0x0036FAEC
		// (set) Token: 0x0602530A RID: 152330 RVA: 0x0037192F File Offset: 0x0036FB2F
		public TArray<ulong> Uint64Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ulong> result;
				if ((result = this._Uint64Array) == null)
				{
					result = (this._Uint64Array = new TArray<ulong>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint64Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint64Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F82 RID: 36738
		// (get) Token: 0x0602530B RID: 152331 RVA: 0x00371940 File Offset: 0x0036FB40
		// (set) Token: 0x0602530C RID: 152332 RVA: 0x00371983 File Offset: 0x0036FB83
		public TArray<float> FloatArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FloatArray) == null)
				{
					result = (this._FloatArray = new TArray<float>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_FloatArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F83 RID: 36739
		// (get) Token: 0x0602530D RID: 152333 RVA: 0x00371994 File Offset: 0x0036FB94
		// (set) Token: 0x0602530E RID: 152334 RVA: 0x003719D7 File Offset: 0x0036FBD7
		public TArray<double> DoubleArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<double> result;
				if ((result = this._DoubleArray) == null)
				{
					result = (this._DoubleArray = new TArray<double>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_DoubleArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DoubleArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F84 RID: 36740
		// (get) Token: 0x0602530F RID: 152335 RVA: 0x003719E8 File Offset: 0x0036FBE8
		// (set) Token: 0x06025310 RID: 152336 RVA: 0x00371A2C File Offset: 0x0036FC2C
		public TFixedArray<sbyte> Int8FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<sbyte> result;
				if ((result = this._Int8FixedArray) == null)
				{
					result = (this._Int8FixedArray = new TFixedArray<sbyte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int8FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int8FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F85 RID: 36741
		// (get) Token: 0x06025311 RID: 152337 RVA: 0x00371A3C File Offset: 0x0036FC3C
		// (set) Token: 0x06025312 RID: 152338 RVA: 0x00371A80 File Offset: 0x0036FC80
		public TFixedArray<byte> Uint8FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<byte> result;
				if ((result = this._Uint8FixedArray) == null)
				{
					result = (this._Uint8FixedArray = new TFixedArray<byte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint8FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint8FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F86 RID: 36742
		// (get) Token: 0x06025313 RID: 152339 RVA: 0x00371A90 File Offset: 0x0036FC90
		// (set) Token: 0x06025314 RID: 152340 RVA: 0x00371AD4 File Offset: 0x0036FCD4
		public TFixedArray<short> Int16FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<short> result;
				if ((result = this._Int16FixedArray) == null)
				{
					result = (this._Int16FixedArray = new TFixedArray<short>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int16FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int16FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F87 RID: 36743
		// (get) Token: 0x06025315 RID: 152341 RVA: 0x00371AE4 File Offset: 0x0036FCE4
		// (set) Token: 0x06025316 RID: 152342 RVA: 0x00371B28 File Offset: 0x0036FD28
		public TFixedArray<ushort> Uint16FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ushort> result;
				if ((result = this._Uint16FixedArray) == null)
				{
					result = (this._Uint16FixedArray = new TFixedArray<ushort>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint16FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint16FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F88 RID: 36744
		// (get) Token: 0x06025317 RID: 152343 RVA: 0x00371B38 File Offset: 0x0036FD38
		// (set) Token: 0x06025318 RID: 152344 RVA: 0x00371B7C File Offset: 0x0036FD7C
		public TFixedArray<int> Int32FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._Int32FixedArray) == null)
				{
					result = (this._Int32FixedArray = new TFixedArray<int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int32FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F89 RID: 36745
		// (get) Token: 0x06025319 RID: 152345 RVA: 0x00371B8C File Offset: 0x0036FD8C
		// (set) Token: 0x0602531A RID: 152346 RVA: 0x00371BD0 File Offset: 0x0036FDD0
		public TFixedArray<uint> Uint32FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<uint> result;
				if ((result = this._Uint32FixedArray) == null)
				{
					result = (this._Uint32FixedArray = new TFixedArray<uint>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint32FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint32FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F8A RID: 36746
		// (get) Token: 0x0602531B RID: 152347 RVA: 0x00371BE0 File Offset: 0x0036FDE0
		// (set) Token: 0x0602531C RID: 152348 RVA: 0x00371C24 File Offset: 0x0036FE24
		public TFixedArray<long> Int64FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<long> result;
				if ((result = this._Int64FixedArray) == null)
				{
					result = (this._Int64FixedArray = new TFixedArray<long>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int64FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int64FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F8B RID: 36747
		// (get) Token: 0x0602531D RID: 152349 RVA: 0x00371C34 File Offset: 0x0036FE34
		// (set) Token: 0x0602531E RID: 152350 RVA: 0x00371C78 File Offset: 0x0036FE78
		public TFixedArray<ulong> Uint64FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ulong> result;
				if ((result = this._Uint64FixedArray) == null)
				{
					result = (this._Uint64FixedArray = new TFixedArray<ulong>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint64FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint64FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F8C RID: 36748
		// (get) Token: 0x0602531F RID: 152351 RVA: 0x00371C88 File Offset: 0x0036FE88
		// (set) Token: 0x06025320 RID: 152352 RVA: 0x00371CCC File Offset: 0x0036FECC
		public TFixedArray<float> FloatFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._FloatFixedArray) == null)
				{
					result = (this._FloatFixedArray = new TFixedArray<float>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_FloatFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F8D RID: 36749
		// (get) Token: 0x06025321 RID: 152353 RVA: 0x00371CDC File Offset: 0x0036FEDC
		// (set) Token: 0x06025322 RID: 152354 RVA: 0x00371D20 File Offset: 0x0036FF20
		public TFixedArray<double> DoubleFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<double> result;
				if ((result = this._DoubleFixedArray) == null)
				{
					result = (this._DoubleFixedArray = new TFixedArray<double>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_DoubleFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DoubleFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F8E RID: 36750
		// (get) Token: 0x06025323 RID: 152355 RVA: 0x00371D30 File Offset: 0x0036FF30
		// (set) Token: 0x06025324 RID: 152356 RVA: 0x00371D73 File Offset: 0x0036FF73
		public TSet<bool> BoolSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<bool> result;
				if ((result = this._BoolSet) == null)
				{
					result = (this._BoolSet = new TSet<bool>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_BoolSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoolSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F8F RID: 36751
		// (get) Token: 0x06025325 RID: 152357 RVA: 0x00371D84 File Offset: 0x0036FF84
		// (set) Token: 0x06025326 RID: 152358 RVA: 0x00371DC7 File Offset: 0x0036FFC7
		public TSet<sbyte> Int8Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<sbyte> result;
				if ((result = this._Int8Set) == null)
				{
					result = (this._Int8Set = new TSet<sbyte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int8Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int8Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F90 RID: 36752
		// (get) Token: 0x06025327 RID: 152359 RVA: 0x00371DD8 File Offset: 0x0036FFD8
		// (set) Token: 0x06025328 RID: 152360 RVA: 0x00371E1B File Offset: 0x0037001B
		public TSet<byte> Uint8Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<byte> result;
				if ((result = this._Uint8Set) == null)
				{
					result = (this._Uint8Set = new TSet<byte>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint8Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint8Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F91 RID: 36753
		// (get) Token: 0x06025329 RID: 152361 RVA: 0x00371E2C File Offset: 0x0037002C
		// (set) Token: 0x0602532A RID: 152362 RVA: 0x00371E6F File Offset: 0x0037006F
		public TSet<short> Int16Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<short> result;
				if ((result = this._Int16Set) == null)
				{
					result = (this._Int16Set = new TSet<short>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int16Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int16Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F92 RID: 36754
		// (get) Token: 0x0602532B RID: 152363 RVA: 0x00371E80 File Offset: 0x00370080
		// (set) Token: 0x0602532C RID: 152364 RVA: 0x00371EC3 File Offset: 0x003700C3
		public TSet<ushort> Uint16Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<ushort> result;
				if ((result = this._Uint16Set) == null)
				{
					result = (this._Uint16Set = new TSet<ushort>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint16Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint16Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F93 RID: 36755
		// (get) Token: 0x0602532D RID: 152365 RVA: 0x00371ED4 File Offset: 0x003700D4
		// (set) Token: 0x0602532E RID: 152366 RVA: 0x00371F17 File Offset: 0x00370117
		public TSet<int> Int32Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._Int32Set) == null)
				{
					result = (this._Int32Set = new TSet<int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int32Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F94 RID: 36756
		// (get) Token: 0x0602532F RID: 152367 RVA: 0x00371F28 File Offset: 0x00370128
		// (set) Token: 0x06025330 RID: 152368 RVA: 0x00371F6B File Offset: 0x0037016B
		public TSet<uint> Uint32Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<uint> result;
				if ((result = this._Uint32Set) == null)
				{
					result = (this._Uint32Set = new TSet<uint>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint32Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint32Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F95 RID: 36757
		// (get) Token: 0x06025331 RID: 152369 RVA: 0x00371F7C File Offset: 0x0037017C
		// (set) Token: 0x06025332 RID: 152370 RVA: 0x00371FBF File Offset: 0x003701BF
		public TSet<long> Int64Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<long> result;
				if ((result = this._Int64Set) == null)
				{
					result = (this._Int64Set = new TSet<long>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int64Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int64Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F96 RID: 36758
		// (get) Token: 0x06025333 RID: 152371 RVA: 0x00371FD0 File Offset: 0x003701D0
		// (set) Token: 0x06025334 RID: 152372 RVA: 0x00372013 File Offset: 0x00370213
		public TSet<ulong> Uint64Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<ulong> result;
				if ((result = this._Uint64Set) == null)
				{
					result = (this._Uint64Set = new TSet<ulong>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint64Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint64Set.CopyAssign(value);
			}
		}

		// Token: 0x17008F97 RID: 36759
		// (get) Token: 0x06025335 RID: 152373 RVA: 0x00372024 File Offset: 0x00370224
		// (set) Token: 0x06025336 RID: 152374 RVA: 0x00372067 File Offset: 0x00370267
		public TSet<float> FloatSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<float> result;
				if ((result = this._FloatSet) == null)
				{
					result = (this._FloatSet = new TSet<float>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_FloatSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F98 RID: 36760
		// (get) Token: 0x06025337 RID: 152375 RVA: 0x00372078 File Offset: 0x00370278
		// (set) Token: 0x06025338 RID: 152376 RVA: 0x003720BB File Offset: 0x003702BB
		public TSet<double> DoubleSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<double> result;
				if ((result = this._DoubleSet) == null)
				{
					result = (this._DoubleSet = new TSet<double>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_DoubleSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DoubleSet.CopyAssign(value);
			}
		}

		// Token: 0x17008F99 RID: 36761
		// (get) Token: 0x06025339 RID: 152377 RVA: 0x003720CC File Offset: 0x003702CC
		// (set) Token: 0x0602533A RID: 152378 RVA: 0x0037210F File Offset: 0x0037030F
		public TMap<bool, int> BoolMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<bool, int> result;
				if ((result = this._BoolMap) == null)
				{
					result = (this._BoolMap = new TMap<bool, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_BoolMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoolMap.CopyAssign(value);
			}
		}

		// Token: 0x17008F9A RID: 36762
		// (get) Token: 0x0602533B RID: 152379 RVA: 0x00372120 File Offset: 0x00370320
		// (set) Token: 0x0602533C RID: 152380 RVA: 0x00372163 File Offset: 0x00370363
		public TMap<sbyte, int> Int8Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<sbyte, int> result;
				if ((result = this._Int8Map) == null)
				{
					result = (this._Int8Map = new TMap<sbyte, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int8Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int8Map.CopyAssign(value);
			}
		}

		// Token: 0x17008F9B RID: 36763
		// (get) Token: 0x0602533D RID: 152381 RVA: 0x00372174 File Offset: 0x00370374
		// (set) Token: 0x0602533E RID: 152382 RVA: 0x003721B7 File Offset: 0x003703B7
		public TMap<byte, int> Uint8Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<byte, int> result;
				if ((result = this._Uint8Map) == null)
				{
					result = (this._Uint8Map = new TMap<byte, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint8Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint8Map.CopyAssign(value);
			}
		}

		// Token: 0x17008F9C RID: 36764
		// (get) Token: 0x0602533F RID: 152383 RVA: 0x003721C8 File Offset: 0x003703C8
		// (set) Token: 0x06025340 RID: 152384 RVA: 0x0037220B File Offset: 0x0037040B
		public TMap<short, int> Int16Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<short, int> result;
				if ((result = this._Int16Map) == null)
				{
					result = (this._Int16Map = new TMap<short, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int16Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int16Map.CopyAssign(value);
			}
		}

		// Token: 0x17008F9D RID: 36765
		// (get) Token: 0x06025341 RID: 152385 RVA: 0x0037221C File Offset: 0x0037041C
		// (set) Token: 0x06025342 RID: 152386 RVA: 0x0037225F File Offset: 0x0037045F
		public TMap<ushort, int> Uint16Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ushort, int> result;
				if ((result = this._Uint16Map) == null)
				{
					result = (this._Uint16Map = new TMap<ushort, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint16Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint16Map.CopyAssign(value);
			}
		}

		// Token: 0x17008F9E RID: 36766
		// (get) Token: 0x06025343 RID: 152387 RVA: 0x00372270 File Offset: 0x00370470
		// (set) Token: 0x06025344 RID: 152388 RVA: 0x003722B3 File Offset: 0x003704B3
		public TMap<int, int> Int32Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._Int32Map) == null)
				{
					result = (this._Int32Map = new TMap<int, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int32Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32Map.CopyAssign(value);
			}
		}

		// Token: 0x17008F9F RID: 36767
		// (get) Token: 0x06025345 RID: 152389 RVA: 0x003722C4 File Offset: 0x003704C4
		// (set) Token: 0x06025346 RID: 152390 RVA: 0x00372307 File Offset: 0x00370507
		public TMap<uint, int> Uint32Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, int> result;
				if ((result = this._Uint32Map) == null)
				{
					result = (this._Uint32Map = new TMap<uint, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint32Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint32Map.CopyAssign(value);
			}
		}

		// Token: 0x17008FA0 RID: 36768
		// (get) Token: 0x06025347 RID: 152391 RVA: 0x00372318 File Offset: 0x00370518
		// (set) Token: 0x06025348 RID: 152392 RVA: 0x0037235B File Offset: 0x0037055B
		public TMap<long, int> Int64Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, int> result;
				if ((result = this._Int64Map) == null)
				{
					result = (this._Int64Map = new TMap<long, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Int64Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int64Map.CopyAssign(value);
			}
		}

		// Token: 0x17008FA1 RID: 36769
		// (get) Token: 0x06025349 RID: 152393 RVA: 0x0037236C File Offset: 0x0037056C
		// (set) Token: 0x0602534A RID: 152394 RVA: 0x003723AF File Offset: 0x003705AF
		public TMap<ulong, int> Uint64Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ulong, int> result;
				if ((result = this._Uint64Map) == null)
				{
					result = (this._Uint64Map = new TMap<ulong, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_Uint64Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Uint64Map.CopyAssign(value);
			}
		}

		// Token: 0x17008FA2 RID: 36770
		// (get) Token: 0x0602534B RID: 152395 RVA: 0x003723C0 File Offset: 0x003705C0
		// (set) Token: 0x0602534C RID: 152396 RVA: 0x00372403 File Offset: 0x00370603
		public TMap<float, int> FloatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<float, int> result;
				if ((result = this._FloatMap) == null)
				{
					result = (this._FloatMap = new TMap<float, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_FloatMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FA3 RID: 36771
		// (get) Token: 0x0602534D RID: 152397 RVA: 0x00372414 File Offset: 0x00370614
		// (set) Token: 0x0602534E RID: 152398 RVA: 0x00372457 File Offset: 0x00370657
		public TMap<double, int> DoubleMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<double, int> result;
				if ((result = this._DoubleMap) == null)
				{
					result = (this._DoubleMap = new TMap<double, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Base.__PropertyOffset_DoubleMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DoubleMap.CopyAssign(value);
			}
		}

		// Token: 0x0602534F RID: 152399 RVA: 0x00372465 File Offset: 0x00370665
		public FSharpherealTestStruct_Base()
		{
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x00372470 File Offset: 0x00370670
		public FSharpherealTestStruct_Base(bool Bool, bool Bool1, bool Bool2, sbyte I8, byte U8, short I16, ushort U16, int I32, uint U32, long I64, ulong U64, float F32, double F64, TArray<bool> BoolArray, TArray<sbyte> Int8Array, TArray<byte> Uint8Array, TArray<short> Int16Array, TArray<ushort> Uint16Array, TArray<int> Int32Array, TArray<uint> Uint32Array, TArray<long> Int64Array, TArray<ulong> Uint64Array, TArray<float> FloatArray, TArray<double> DoubleArray, TFixedArray<sbyte> Int8FixedArray, TFixedArray<byte> Uint8FixedArray, TFixedArray<short> Int16FixedArray, TFixedArray<ushort> Uint16FixedArray, TFixedArray<int> Int32FixedArray, TFixedArray<uint> Uint32FixedArray, TFixedArray<long> Int64FixedArray, TFixedArray<ulong> Uint64FixedArray, TFixedArray<float> FloatFixedArray, TFixedArray<double> DoubleFixedArray, TSet<bool> BoolSet, TSet<sbyte> Int8Set, TSet<byte> Uint8Set, TSet<short> Int16Set, TSet<ushort> Uint16Set, TSet<int> Int32Set, TSet<uint> Uint32Set, TSet<long> Int64Set, TSet<ulong> Uint64Set, TSet<float> FloatSet, TSet<double> DoubleSet, TMap<bool, int> BoolMap, TMap<sbyte, int> Int8Map, TMap<byte, int> Uint8Map, TMap<short, int> Int16Map, TMap<ushort, int> Uint16Map, TMap<int, int> Int32Map, TMap<uint, int> Uint32Map, TMap<long, int> Int64Map, TMap<ulong, int> Uint64Map, TMap<float, int> FloatMap, TMap<double, int> DoubleMap)
		{
			this.Bool = Bool;
			this.Bool1 = Bool1;
			this.Bool2 = Bool2;
			this.I8 = I8;
			this.U8 = U8;
			this.I16 = I16;
			this.U16 = U16;
			this.I32 = I32;
			this.U32 = U32;
			this.I64 = I64;
			this.U64 = U64;
			this.F32 = F32;
			this.F64 = F64;
			this.BoolArray = BoolArray;
			this.Int8Array = Int8Array;
			this.Uint8Array = Uint8Array;
			this.Int16Array = Int16Array;
			this.Uint16Array = Uint16Array;
			this.Int32Array = Int32Array;
			this.Uint32Array = Uint32Array;
			this.Int64Array = Int64Array;
			this.Uint64Array = Uint64Array;
			this.FloatArray = FloatArray;
			this.DoubleArray = DoubleArray;
			this.Int8FixedArray = Int8FixedArray;
			this.Uint8FixedArray = Uint8FixedArray;
			this.Int16FixedArray = Int16FixedArray;
			this.Uint16FixedArray = Uint16FixedArray;
			this.Int32FixedArray = Int32FixedArray;
			this.Uint32FixedArray = Uint32FixedArray;
			this.Int64FixedArray = Int64FixedArray;
			this.Uint64FixedArray = Uint64FixedArray;
			this.FloatFixedArray = FloatFixedArray;
			this.DoubleFixedArray = DoubleFixedArray;
			this.BoolSet = BoolSet;
			this.Int8Set = Int8Set;
			this.Uint8Set = Uint8Set;
			this.Int16Set = Int16Set;
			this.Uint16Set = Uint16Set;
			this.Int32Set = Int32Set;
			this.Uint32Set = Uint32Set;
			this.Int64Set = Int64Set;
			this.Uint64Set = Uint64Set;
			this.FloatSet = FloatSet;
			this.DoubleSet = DoubleSet;
			this.BoolMap = BoolMap;
			this.Int8Map = Int8Map;
			this.Uint8Map = Uint8Map;
			this.Int16Map = Int16Map;
			this.Uint16Map = Uint16Map;
			this.Int32Map = Int32Map;
			this.Uint32Map = Uint32Map;
			this.Int64Map = Int64Map;
			this.Uint64Map = Uint64Map;
			this.FloatMap = FloatMap;
			this.DoubleMap = DoubleMap;
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x00372640 File Offset: 0x00370840
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Base.StaticStruct();
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x0037264C File Offset: 0x0037084C
		[NullableContext(2)]
		public FSharpherealTestStruct_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025353 RID: 152403 RVA: 0x00372656 File Offset: 0x00370856
		public FSharpherealTestStruct_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025354 RID: 152404 RVA: 0x00372661 File Offset: 0x00370861
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Base(Pointer, false, true);
		}

		// Token: 0x06025355 RID: 152405 RVA: 0x0037266B File Offset: 0x0037086B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Base(Pointer, MemoryOwner);
		}

		// Token: 0x04014099 RID: 82073
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Base";

		// Token: 0x0401409A RID: 82074
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401409B RID: 82075
		internal static int __PropertyOffset_Bool;

		// Token: 0x0401409C RID: 82076
		internal static int __PropertyOffset_Bool1;

		// Token: 0x0401409D RID: 82077
		internal static byte __PropertyMask_Bool1;

		// Token: 0x0401409E RID: 82078
		internal static int __PropertyOffset_Bool2;

		// Token: 0x0401409F RID: 82079
		internal static byte __PropertyMask_Bool2;

		// Token: 0x040140A0 RID: 82080
		internal static int __PropertyOffset_I8;

		// Token: 0x040140A1 RID: 82081
		internal static int __PropertyOffset_U8;

		// Token: 0x040140A2 RID: 82082
		internal static int __PropertyOffset_I16;

		// Token: 0x040140A3 RID: 82083
		internal static int __PropertyOffset_U16;

		// Token: 0x040140A4 RID: 82084
		internal static int __PropertyOffset_I32;

		// Token: 0x040140A5 RID: 82085
		internal static int __PropertyOffset_U32;

		// Token: 0x040140A6 RID: 82086
		internal static int __PropertyOffset_I64;

		// Token: 0x040140A7 RID: 82087
		internal static int __PropertyOffset_U64;

		// Token: 0x040140A8 RID: 82088
		internal static int __PropertyOffset_F32;

		// Token: 0x040140A9 RID: 82089
		internal static int __PropertyOffset_F64;

		// Token: 0x040140AA RID: 82090
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x040140AB RID: 82091
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x040140AC RID: 82092
		internal static int __PropertyOffset_Int8Array;

		// Token: 0x040140AD RID: 82093
		[Nullable(2)]
		private TArray<sbyte> _Int8Array;

		// Token: 0x040140AE RID: 82094
		internal static int __PropertyOffset_Uint8Array;

		// Token: 0x040140AF RID: 82095
		[Nullable(2)]
		private TArray<byte> _Uint8Array;

		// Token: 0x040140B0 RID: 82096
		internal static int __PropertyOffset_Int16Array;

		// Token: 0x040140B1 RID: 82097
		[Nullable(2)]
		private TArray<short> _Int16Array;

		// Token: 0x040140B2 RID: 82098
		internal static int __PropertyOffset_Uint16Array;

		// Token: 0x040140B3 RID: 82099
		[Nullable(2)]
		private TArray<ushort> _Uint16Array;

		// Token: 0x040140B4 RID: 82100
		internal static int __PropertyOffset_Int32Array;

		// Token: 0x040140B5 RID: 82101
		[Nullable(2)]
		private TArray<int> _Int32Array;

		// Token: 0x040140B6 RID: 82102
		internal static int __PropertyOffset_Uint32Array;

		// Token: 0x040140B7 RID: 82103
		[Nullable(2)]
		private TArray<uint> _Uint32Array;

		// Token: 0x040140B8 RID: 82104
		internal static int __PropertyOffset_Int64Array;

		// Token: 0x040140B9 RID: 82105
		[Nullable(2)]
		private TArray<long> _Int64Array;

		// Token: 0x040140BA RID: 82106
		internal static int __PropertyOffset_Uint64Array;

		// Token: 0x040140BB RID: 82107
		[Nullable(2)]
		private TArray<ulong> _Uint64Array;

		// Token: 0x040140BC RID: 82108
		internal static int __PropertyOffset_FloatArray;

		// Token: 0x040140BD RID: 82109
		[Nullable(2)]
		private TArray<float> _FloatArray;

		// Token: 0x040140BE RID: 82110
		internal static int __PropertyOffset_DoubleArray;

		// Token: 0x040140BF RID: 82111
		[Nullable(2)]
		private TArray<double> _DoubleArray;

		// Token: 0x040140C0 RID: 82112
		internal static int __PropertyOffset_Int8FixedArray;

		// Token: 0x040140C1 RID: 82113
		[Nullable(2)]
		private TFixedArray<sbyte> _Int8FixedArray;

		// Token: 0x040140C2 RID: 82114
		internal static int __PropertyOffset_Uint8FixedArray;

		// Token: 0x040140C3 RID: 82115
		[Nullable(2)]
		private TFixedArray<byte> _Uint8FixedArray;

		// Token: 0x040140C4 RID: 82116
		internal static int __PropertyOffset_Int16FixedArray;

		// Token: 0x040140C5 RID: 82117
		[Nullable(2)]
		private TFixedArray<short> _Int16FixedArray;

		// Token: 0x040140C6 RID: 82118
		internal static int __PropertyOffset_Uint16FixedArray;

		// Token: 0x040140C7 RID: 82119
		[Nullable(2)]
		private TFixedArray<ushort> _Uint16FixedArray;

		// Token: 0x040140C8 RID: 82120
		internal static int __PropertyOffset_Int32FixedArray;

		// Token: 0x040140C9 RID: 82121
		[Nullable(2)]
		private TFixedArray<int> _Int32FixedArray;

		// Token: 0x040140CA RID: 82122
		internal static int __PropertyOffset_Uint32FixedArray;

		// Token: 0x040140CB RID: 82123
		[Nullable(2)]
		private TFixedArray<uint> _Uint32FixedArray;

		// Token: 0x040140CC RID: 82124
		internal static int __PropertyOffset_Int64FixedArray;

		// Token: 0x040140CD RID: 82125
		[Nullable(2)]
		private TFixedArray<long> _Int64FixedArray;

		// Token: 0x040140CE RID: 82126
		internal static int __PropertyOffset_Uint64FixedArray;

		// Token: 0x040140CF RID: 82127
		[Nullable(2)]
		private TFixedArray<ulong> _Uint64FixedArray;

		// Token: 0x040140D0 RID: 82128
		internal static int __PropertyOffset_FloatFixedArray;

		// Token: 0x040140D1 RID: 82129
		[Nullable(2)]
		private TFixedArray<float> _FloatFixedArray;

		// Token: 0x040140D2 RID: 82130
		internal static int __PropertyOffset_DoubleFixedArray;

		// Token: 0x040140D3 RID: 82131
		[Nullable(2)]
		private TFixedArray<double> _DoubleFixedArray;

		// Token: 0x040140D4 RID: 82132
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x040140D5 RID: 82133
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x040140D6 RID: 82134
		internal static int __PropertyOffset_Int8Set;

		// Token: 0x040140D7 RID: 82135
		[Nullable(2)]
		private TSet<sbyte> _Int8Set;

		// Token: 0x040140D8 RID: 82136
		internal static int __PropertyOffset_Uint8Set;

		// Token: 0x040140D9 RID: 82137
		[Nullable(2)]
		private TSet<byte> _Uint8Set;

		// Token: 0x040140DA RID: 82138
		internal static int __PropertyOffset_Int16Set;

		// Token: 0x040140DB RID: 82139
		[Nullable(2)]
		private TSet<short> _Int16Set;

		// Token: 0x040140DC RID: 82140
		internal static int __PropertyOffset_Uint16Set;

		// Token: 0x040140DD RID: 82141
		[Nullable(2)]
		private TSet<ushort> _Uint16Set;

		// Token: 0x040140DE RID: 82142
		internal static int __PropertyOffset_Int32Set;

		// Token: 0x040140DF RID: 82143
		[Nullable(2)]
		private TSet<int> _Int32Set;

		// Token: 0x040140E0 RID: 82144
		internal static int __PropertyOffset_Uint32Set;

		// Token: 0x040140E1 RID: 82145
		[Nullable(2)]
		private TSet<uint> _Uint32Set;

		// Token: 0x040140E2 RID: 82146
		internal static int __PropertyOffset_Int64Set;

		// Token: 0x040140E3 RID: 82147
		[Nullable(2)]
		private TSet<long> _Int64Set;

		// Token: 0x040140E4 RID: 82148
		internal static int __PropertyOffset_Uint64Set;

		// Token: 0x040140E5 RID: 82149
		[Nullable(2)]
		private TSet<ulong> _Uint64Set;

		// Token: 0x040140E6 RID: 82150
		internal static int __PropertyOffset_FloatSet;

		// Token: 0x040140E7 RID: 82151
		[Nullable(2)]
		private TSet<float> _FloatSet;

		// Token: 0x040140E8 RID: 82152
		internal static int __PropertyOffset_DoubleSet;

		// Token: 0x040140E9 RID: 82153
		[Nullable(2)]
		private TSet<double> _DoubleSet;

		// Token: 0x040140EA RID: 82154
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x040140EB RID: 82155
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x040140EC RID: 82156
		internal static int __PropertyOffset_Int8Map;

		// Token: 0x040140ED RID: 82157
		[Nullable(2)]
		private TMap<sbyte, int> _Int8Map;

		// Token: 0x040140EE RID: 82158
		internal static int __PropertyOffset_Uint8Map;

		// Token: 0x040140EF RID: 82159
		[Nullable(2)]
		private TMap<byte, int> _Uint8Map;

		// Token: 0x040140F0 RID: 82160
		internal static int __PropertyOffset_Int16Map;

		// Token: 0x040140F1 RID: 82161
		[Nullable(2)]
		private TMap<short, int> _Int16Map;

		// Token: 0x040140F2 RID: 82162
		internal static int __PropertyOffset_Uint16Map;

		// Token: 0x040140F3 RID: 82163
		[Nullable(2)]
		private TMap<ushort, int> _Uint16Map;

		// Token: 0x040140F4 RID: 82164
		internal static int __PropertyOffset_Int32Map;

		// Token: 0x040140F5 RID: 82165
		[Nullable(2)]
		private TMap<int, int> _Int32Map;

		// Token: 0x040140F6 RID: 82166
		internal static int __PropertyOffset_Uint32Map;

		// Token: 0x040140F7 RID: 82167
		[Nullable(2)]
		private TMap<uint, int> _Uint32Map;

		// Token: 0x040140F8 RID: 82168
		internal static int __PropertyOffset_Int64Map;

		// Token: 0x040140F9 RID: 82169
		[Nullable(2)]
		private TMap<long, int> _Int64Map;

		// Token: 0x040140FA RID: 82170
		internal static int __PropertyOffset_Uint64Map;

		// Token: 0x040140FB RID: 82171
		[Nullable(2)]
		private TMap<ulong, int> _Uint64Map;

		// Token: 0x040140FC RID: 82172
		internal static int __PropertyOffset_FloatMap;

		// Token: 0x040140FD RID: 82173
		[Nullable(2)]
		private TMap<float, int> _FloatMap;

		// Token: 0x040140FE RID: 82174
		internal static int __PropertyOffset_DoubleMap;

		// Token: 0x040140FF RID: 82175
		[Nullable(2)]
		private TMap<double, int> _DoubleMap;
	}
}
