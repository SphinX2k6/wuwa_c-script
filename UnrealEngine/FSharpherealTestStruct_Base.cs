using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007F1 RID: 2033
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Base")]
	[UnrealStructLayout(2072, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2072)]
	public class FSharpherealTestStruct_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ADCD RID: 44493 RVA: 0x001013FA File Offset: 0x000FF5FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Base._ScriptStructPtr != 0) ? FSharpherealTestStruct_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Base", ref FSharpherealTestStruct_Base._ScriptStructPtr);
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600ADCE RID: 44494 RVA: 0x0010141E File Offset: 0x000FF61E
		// (set) Token: 0x0600ADCF RID: 44495 RVA: 0x0010142E File Offset: 0x000FF62E
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

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x0010143F File Offset: 0x000FF63F
		// (set) Token: 0x0600ADD1 RID: 44497 RVA: 0x00101458 File Offset: 0x000FF658
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

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x00101488 File Offset: 0x000FF688
		// (set) Token: 0x0600ADD3 RID: 44499 RVA: 0x001014A1 File Offset: 0x000FF6A1
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

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x001014D1 File Offset: 0x000FF6D1
		// (set) Token: 0x0600ADD5 RID: 44501 RVA: 0x001014E1 File Offset: 0x000FF6E1
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

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600ADD6 RID: 44502 RVA: 0x001014F2 File Offset: 0x000FF6F2
		// (set) Token: 0x0600ADD7 RID: 44503 RVA: 0x00101502 File Offset: 0x000FF702
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

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600ADD8 RID: 44504 RVA: 0x00101513 File Offset: 0x000FF713
		// (set) Token: 0x0600ADD9 RID: 44505 RVA: 0x00101523 File Offset: 0x000FF723
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

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x00101534 File Offset: 0x000FF734
		// (set) Token: 0x0600ADDB RID: 44507 RVA: 0x00101544 File Offset: 0x000FF744
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

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x00101555 File Offset: 0x000FF755
		// (set) Token: 0x0600ADDD RID: 44509 RVA: 0x00101565 File Offset: 0x000FF765
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

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x00101576 File Offset: 0x000FF776
		// (set) Token: 0x0600ADDF RID: 44511 RVA: 0x00101586 File Offset: 0x000FF786
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

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x00101597 File Offset: 0x000FF797
		// (set) Token: 0x0600ADE1 RID: 44513 RVA: 0x001015A7 File Offset: 0x000FF7A7
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

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x001015B8 File Offset: 0x000FF7B8
		// (set) Token: 0x0600ADE3 RID: 44515 RVA: 0x001015C8 File Offset: 0x000FF7C8
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

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600ADE4 RID: 44516 RVA: 0x001015D9 File Offset: 0x000FF7D9
		// (set) Token: 0x0600ADE5 RID: 44517 RVA: 0x001015E9 File Offset: 0x000FF7E9
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

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600ADE6 RID: 44518 RVA: 0x001015FA File Offset: 0x000FF7FA
		// (set) Token: 0x0600ADE7 RID: 44519 RVA: 0x0010160A File Offset: 0x000FF80A
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

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x0010161C File Offset: 0x000FF81C
		// (set) Token: 0x0600ADE9 RID: 44521 RVA: 0x0010165F File Offset: 0x000FF85F
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

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x00101670 File Offset: 0x000FF870
		// (set) Token: 0x0600ADEB RID: 44523 RVA: 0x001016B3 File Offset: 0x000FF8B3
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

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x001016C4 File Offset: 0x000FF8C4
		// (set) Token: 0x0600ADED RID: 44525 RVA: 0x00101707 File Offset: 0x000FF907
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

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x00101718 File Offset: 0x000FF918
		// (set) Token: 0x0600ADEF RID: 44527 RVA: 0x0010175B File Offset: 0x000FF95B
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

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x0010176C File Offset: 0x000FF96C
		// (set) Token: 0x0600ADF1 RID: 44529 RVA: 0x001017AF File Offset: 0x000FF9AF
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

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x001017C0 File Offset: 0x000FF9C0
		// (set) Token: 0x0600ADF3 RID: 44531 RVA: 0x00101803 File Offset: 0x000FFA03
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

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x00101814 File Offset: 0x000FFA14
		// (set) Token: 0x0600ADF5 RID: 44533 RVA: 0x00101857 File Offset: 0x000FFA57
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

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x00101868 File Offset: 0x000FFA68
		// (set) Token: 0x0600ADF7 RID: 44535 RVA: 0x001018AB File Offset: 0x000FFAAB
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

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x001018BC File Offset: 0x000FFABC
		// (set) Token: 0x0600ADF9 RID: 44537 RVA: 0x001018FF File Offset: 0x000FFAFF
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

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x00101910 File Offset: 0x000FFB10
		// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x00101953 File Offset: 0x000FFB53
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

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x00101964 File Offset: 0x000FFB64
		// (set) Token: 0x0600ADFD RID: 44541 RVA: 0x001019A7 File Offset: 0x000FFBA7
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

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x001019B8 File Offset: 0x000FFBB8
		// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x001019FC File Offset: 0x000FFBFC
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

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x00101A0C File Offset: 0x000FFC0C
		// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x00101A50 File Offset: 0x000FFC50
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

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x00101A60 File Offset: 0x000FFC60
		// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x00101AA4 File Offset: 0x000FFCA4
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

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600AE04 RID: 44548 RVA: 0x00101AB4 File Offset: 0x000FFCB4
		// (set) Token: 0x0600AE05 RID: 44549 RVA: 0x00101AF8 File Offset: 0x000FFCF8
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

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600AE06 RID: 44550 RVA: 0x00101B08 File Offset: 0x000FFD08
		// (set) Token: 0x0600AE07 RID: 44551 RVA: 0x00101B4C File Offset: 0x000FFD4C
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

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x00101B5C File Offset: 0x000FFD5C
		// (set) Token: 0x0600AE09 RID: 44553 RVA: 0x00101BA0 File Offset: 0x000FFDA0
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

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x0600AE0A RID: 44554 RVA: 0x00101BB0 File Offset: 0x000FFDB0
		// (set) Token: 0x0600AE0B RID: 44555 RVA: 0x00101BF4 File Offset: 0x000FFDF4
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

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600AE0C RID: 44556 RVA: 0x00101C04 File Offset: 0x000FFE04
		// (set) Token: 0x0600AE0D RID: 44557 RVA: 0x00101C48 File Offset: 0x000FFE48
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

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x00101C58 File Offset: 0x000FFE58
		// (set) Token: 0x0600AE0F RID: 44559 RVA: 0x00101C9C File Offset: 0x000FFE9C
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

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x00101CAC File Offset: 0x000FFEAC
		// (set) Token: 0x0600AE11 RID: 44561 RVA: 0x00101CF0 File Offset: 0x000FFEF0
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

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600AE12 RID: 44562 RVA: 0x00101D00 File Offset: 0x000FFF00
		// (set) Token: 0x0600AE13 RID: 44563 RVA: 0x00101D43 File Offset: 0x000FFF43
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

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x00101D54 File Offset: 0x000FFF54
		// (set) Token: 0x0600AE15 RID: 44565 RVA: 0x00101D97 File Offset: 0x000FFF97
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

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600AE16 RID: 44566 RVA: 0x00101DA8 File Offset: 0x000FFFA8
		// (set) Token: 0x0600AE17 RID: 44567 RVA: 0x00101DEB File Offset: 0x000FFFEB
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

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600AE18 RID: 44568 RVA: 0x00101DFC File Offset: 0x000FFFFC
		// (set) Token: 0x0600AE19 RID: 44569 RVA: 0x00101E3F File Offset: 0x0010003F
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

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600AE1A RID: 44570 RVA: 0x00101E50 File Offset: 0x00100050
		// (set) Token: 0x0600AE1B RID: 44571 RVA: 0x00101E93 File Offset: 0x00100093
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

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600AE1C RID: 44572 RVA: 0x00101EA4 File Offset: 0x001000A4
		// (set) Token: 0x0600AE1D RID: 44573 RVA: 0x00101EE7 File Offset: 0x001000E7
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

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x00101EF8 File Offset: 0x001000F8
		// (set) Token: 0x0600AE1F RID: 44575 RVA: 0x00101F3B File Offset: 0x0010013B
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

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600AE20 RID: 44576 RVA: 0x00101F4C File Offset: 0x0010014C
		// (set) Token: 0x0600AE21 RID: 44577 RVA: 0x00101F8F File Offset: 0x0010018F
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

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600AE22 RID: 44578 RVA: 0x00101FA0 File Offset: 0x001001A0
		// (set) Token: 0x0600AE23 RID: 44579 RVA: 0x00101FE3 File Offset: 0x001001E3
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

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600AE24 RID: 44580 RVA: 0x00101FF4 File Offset: 0x001001F4
		// (set) Token: 0x0600AE25 RID: 44581 RVA: 0x00102037 File Offset: 0x00100237
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

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600AE26 RID: 44582 RVA: 0x00102048 File Offset: 0x00100248
		// (set) Token: 0x0600AE27 RID: 44583 RVA: 0x0010208B File Offset: 0x0010028B
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

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600AE28 RID: 44584 RVA: 0x0010209C File Offset: 0x0010029C
		// (set) Token: 0x0600AE29 RID: 44585 RVA: 0x001020DF File Offset: 0x001002DF
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

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x0600AE2A RID: 44586 RVA: 0x001020F0 File Offset: 0x001002F0
		// (set) Token: 0x0600AE2B RID: 44587 RVA: 0x00102133 File Offset: 0x00100333
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

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600AE2C RID: 44588 RVA: 0x00102144 File Offset: 0x00100344
		// (set) Token: 0x0600AE2D RID: 44589 RVA: 0x00102187 File Offset: 0x00100387
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

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600AE2E RID: 44590 RVA: 0x00102198 File Offset: 0x00100398
		// (set) Token: 0x0600AE2F RID: 44591 RVA: 0x001021DB File Offset: 0x001003DB
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

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600AE30 RID: 44592 RVA: 0x001021EC File Offset: 0x001003EC
		// (set) Token: 0x0600AE31 RID: 44593 RVA: 0x0010222F File Offset: 0x0010042F
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

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600AE32 RID: 44594 RVA: 0x00102240 File Offset: 0x00100440
		// (set) Token: 0x0600AE33 RID: 44595 RVA: 0x00102283 File Offset: 0x00100483
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

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600AE34 RID: 44596 RVA: 0x00102294 File Offset: 0x00100494
		// (set) Token: 0x0600AE35 RID: 44597 RVA: 0x001022D7 File Offset: 0x001004D7
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

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x001022E8 File Offset: 0x001004E8
		// (set) Token: 0x0600AE37 RID: 44599 RVA: 0x0010232B File Offset: 0x0010052B
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

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600AE38 RID: 44600 RVA: 0x0010233C File Offset: 0x0010053C
		// (set) Token: 0x0600AE39 RID: 44601 RVA: 0x0010237F File Offset: 0x0010057F
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

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600AE3A RID: 44602 RVA: 0x00102390 File Offset: 0x00100590
		// (set) Token: 0x0600AE3B RID: 44603 RVA: 0x001023D3 File Offset: 0x001005D3
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

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600AE3C RID: 44604 RVA: 0x001023E4 File Offset: 0x001005E4
		// (set) Token: 0x0600AE3D RID: 44605 RVA: 0x00102427 File Offset: 0x00100627
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

		// Token: 0x0600AE3E RID: 44606 RVA: 0x00102435 File Offset: 0x00100635
		public FSharpherealTestStruct_Base()
		{
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x0010243D File Offset: 0x0010063D
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Base.StaticStruct();
		}

		// Token: 0x0600AE40 RID: 44608 RVA: 0x00102449 File Offset: 0x00100649
		[NullableContext(2)]
		public FSharpherealTestStruct_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x00102453 File Offset: 0x00100653
		public FSharpherealTestStruct_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE42 RID: 44610 RVA: 0x0010245E File Offset: 0x0010065E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Base(Pointer, false, true);
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x00102468 File Offset: 0x00100668
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Base(Pointer, MemoryOwner);
		}

		// Token: 0x04004AFC RID: 19196
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Base";

		// Token: 0x04004AFD RID: 19197
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004AFE RID: 19198
		internal static int __PropertyOffset_Bool;

		// Token: 0x04004AFF RID: 19199
		internal static int __PropertyOffset_Bool1;

		// Token: 0x04004B00 RID: 19200
		internal static byte __PropertyMask_Bool1;

		// Token: 0x04004B01 RID: 19201
		internal static int __PropertyOffset_Bool2;

		// Token: 0x04004B02 RID: 19202
		internal static byte __PropertyMask_Bool2;

		// Token: 0x04004B03 RID: 19203
		internal static int __PropertyOffset_I8;

		// Token: 0x04004B04 RID: 19204
		internal static int __PropertyOffset_U8;

		// Token: 0x04004B05 RID: 19205
		internal static int __PropertyOffset_I16;

		// Token: 0x04004B06 RID: 19206
		internal static int __PropertyOffset_U16;

		// Token: 0x04004B07 RID: 19207
		internal static int __PropertyOffset_I32;

		// Token: 0x04004B08 RID: 19208
		internal static int __PropertyOffset_U32;

		// Token: 0x04004B09 RID: 19209
		internal static int __PropertyOffset_I64;

		// Token: 0x04004B0A RID: 19210
		internal static int __PropertyOffset_U64;

		// Token: 0x04004B0B RID: 19211
		internal static int __PropertyOffset_F32;

		// Token: 0x04004B0C RID: 19212
		internal static int __PropertyOffset_F64;

		// Token: 0x04004B0D RID: 19213
		internal static int __PropertyOffset_BoolArray;

		// Token: 0x04004B0E RID: 19214
		[Nullable(2)]
		private TArray<bool> _BoolArray;

		// Token: 0x04004B0F RID: 19215
		internal static int __PropertyOffset_Int8Array;

		// Token: 0x04004B10 RID: 19216
		[Nullable(2)]
		private TArray<sbyte> _Int8Array;

		// Token: 0x04004B11 RID: 19217
		internal static int __PropertyOffset_Uint8Array;

		// Token: 0x04004B12 RID: 19218
		[Nullable(2)]
		private TArray<byte> _Uint8Array;

		// Token: 0x04004B13 RID: 19219
		internal static int __PropertyOffset_Int16Array;

		// Token: 0x04004B14 RID: 19220
		[Nullable(2)]
		private TArray<short> _Int16Array;

		// Token: 0x04004B15 RID: 19221
		internal static int __PropertyOffset_Uint16Array;

		// Token: 0x04004B16 RID: 19222
		[Nullable(2)]
		private TArray<ushort> _Uint16Array;

		// Token: 0x04004B17 RID: 19223
		internal static int __PropertyOffset_Int32Array;

		// Token: 0x04004B18 RID: 19224
		[Nullable(2)]
		private TArray<int> _Int32Array;

		// Token: 0x04004B19 RID: 19225
		internal static int __PropertyOffset_Uint32Array;

		// Token: 0x04004B1A RID: 19226
		[Nullable(2)]
		private TArray<uint> _Uint32Array;

		// Token: 0x04004B1B RID: 19227
		internal static int __PropertyOffset_Int64Array;

		// Token: 0x04004B1C RID: 19228
		[Nullable(2)]
		private TArray<long> _Int64Array;

		// Token: 0x04004B1D RID: 19229
		internal static int __PropertyOffset_Uint64Array;

		// Token: 0x04004B1E RID: 19230
		[Nullable(2)]
		private TArray<ulong> _Uint64Array;

		// Token: 0x04004B1F RID: 19231
		internal static int __PropertyOffset_FloatArray;

		// Token: 0x04004B20 RID: 19232
		[Nullable(2)]
		private TArray<float> _FloatArray;

		// Token: 0x04004B21 RID: 19233
		internal static int __PropertyOffset_DoubleArray;

		// Token: 0x04004B22 RID: 19234
		[Nullable(2)]
		private TArray<double> _DoubleArray;

		// Token: 0x04004B23 RID: 19235
		internal static int __PropertyOffset_Int8FixedArray;

		// Token: 0x04004B24 RID: 19236
		[Nullable(2)]
		private TFixedArray<sbyte> _Int8FixedArray;

		// Token: 0x04004B25 RID: 19237
		internal static int __PropertyOffset_Uint8FixedArray;

		// Token: 0x04004B26 RID: 19238
		[Nullable(2)]
		private TFixedArray<byte> _Uint8FixedArray;

		// Token: 0x04004B27 RID: 19239
		internal static int __PropertyOffset_Int16FixedArray;

		// Token: 0x04004B28 RID: 19240
		[Nullable(2)]
		private TFixedArray<short> _Int16FixedArray;

		// Token: 0x04004B29 RID: 19241
		internal static int __PropertyOffset_Uint16FixedArray;

		// Token: 0x04004B2A RID: 19242
		[Nullable(2)]
		private TFixedArray<ushort> _Uint16FixedArray;

		// Token: 0x04004B2B RID: 19243
		internal static int __PropertyOffset_Int32FixedArray;

		// Token: 0x04004B2C RID: 19244
		[Nullable(2)]
		private TFixedArray<int> _Int32FixedArray;

		// Token: 0x04004B2D RID: 19245
		internal static int __PropertyOffset_Uint32FixedArray;

		// Token: 0x04004B2E RID: 19246
		[Nullable(2)]
		private TFixedArray<uint> _Uint32FixedArray;

		// Token: 0x04004B2F RID: 19247
		internal static int __PropertyOffset_Int64FixedArray;

		// Token: 0x04004B30 RID: 19248
		[Nullable(2)]
		private TFixedArray<long> _Int64FixedArray;

		// Token: 0x04004B31 RID: 19249
		internal static int __PropertyOffset_Uint64FixedArray;

		// Token: 0x04004B32 RID: 19250
		[Nullable(2)]
		private TFixedArray<ulong> _Uint64FixedArray;

		// Token: 0x04004B33 RID: 19251
		internal static int __PropertyOffset_FloatFixedArray;

		// Token: 0x04004B34 RID: 19252
		[Nullable(2)]
		private TFixedArray<float> _FloatFixedArray;

		// Token: 0x04004B35 RID: 19253
		internal static int __PropertyOffset_DoubleFixedArray;

		// Token: 0x04004B36 RID: 19254
		[Nullable(2)]
		private TFixedArray<double> _DoubleFixedArray;

		// Token: 0x04004B37 RID: 19255
		internal static int __PropertyOffset_BoolSet;

		// Token: 0x04004B38 RID: 19256
		[Nullable(2)]
		private TSet<bool> _BoolSet;

		// Token: 0x04004B39 RID: 19257
		internal static int __PropertyOffset_Int8Set;

		// Token: 0x04004B3A RID: 19258
		[Nullable(2)]
		private TSet<sbyte> _Int8Set;

		// Token: 0x04004B3B RID: 19259
		internal static int __PropertyOffset_Uint8Set;

		// Token: 0x04004B3C RID: 19260
		[Nullable(2)]
		private TSet<byte> _Uint8Set;

		// Token: 0x04004B3D RID: 19261
		internal static int __PropertyOffset_Int16Set;

		// Token: 0x04004B3E RID: 19262
		[Nullable(2)]
		private TSet<short> _Int16Set;

		// Token: 0x04004B3F RID: 19263
		internal static int __PropertyOffset_Uint16Set;

		// Token: 0x04004B40 RID: 19264
		[Nullable(2)]
		private TSet<ushort> _Uint16Set;

		// Token: 0x04004B41 RID: 19265
		internal static int __PropertyOffset_Int32Set;

		// Token: 0x04004B42 RID: 19266
		[Nullable(2)]
		private TSet<int> _Int32Set;

		// Token: 0x04004B43 RID: 19267
		internal static int __PropertyOffset_Uint32Set;

		// Token: 0x04004B44 RID: 19268
		[Nullable(2)]
		private TSet<uint> _Uint32Set;

		// Token: 0x04004B45 RID: 19269
		internal static int __PropertyOffset_Int64Set;

		// Token: 0x04004B46 RID: 19270
		[Nullable(2)]
		private TSet<long> _Int64Set;

		// Token: 0x04004B47 RID: 19271
		internal static int __PropertyOffset_Uint64Set;

		// Token: 0x04004B48 RID: 19272
		[Nullable(2)]
		private TSet<ulong> _Uint64Set;

		// Token: 0x04004B49 RID: 19273
		internal static int __PropertyOffset_FloatSet;

		// Token: 0x04004B4A RID: 19274
		[Nullable(2)]
		private TSet<float> _FloatSet;

		// Token: 0x04004B4B RID: 19275
		internal static int __PropertyOffset_DoubleSet;

		// Token: 0x04004B4C RID: 19276
		[Nullable(2)]
		private TSet<double> _DoubleSet;

		// Token: 0x04004B4D RID: 19277
		internal static int __PropertyOffset_BoolMap;

		// Token: 0x04004B4E RID: 19278
		[Nullable(2)]
		private TMap<bool, int> _BoolMap;

		// Token: 0x04004B4F RID: 19279
		internal static int __PropertyOffset_Int8Map;

		// Token: 0x04004B50 RID: 19280
		[Nullable(2)]
		private TMap<sbyte, int> _Int8Map;

		// Token: 0x04004B51 RID: 19281
		internal static int __PropertyOffset_Uint8Map;

		// Token: 0x04004B52 RID: 19282
		[Nullable(2)]
		private TMap<byte, int> _Uint8Map;

		// Token: 0x04004B53 RID: 19283
		internal static int __PropertyOffset_Int16Map;

		// Token: 0x04004B54 RID: 19284
		[Nullable(2)]
		private TMap<short, int> _Int16Map;

		// Token: 0x04004B55 RID: 19285
		internal static int __PropertyOffset_Uint16Map;

		// Token: 0x04004B56 RID: 19286
		[Nullable(2)]
		private TMap<ushort, int> _Uint16Map;

		// Token: 0x04004B57 RID: 19287
		internal static int __PropertyOffset_Int32Map;

		// Token: 0x04004B58 RID: 19288
		[Nullable(2)]
		private TMap<int, int> _Int32Map;

		// Token: 0x04004B59 RID: 19289
		internal static int __PropertyOffset_Uint32Map;

		// Token: 0x04004B5A RID: 19290
		[Nullable(2)]
		private TMap<uint, int> _Uint32Map;

		// Token: 0x04004B5B RID: 19291
		internal static int __PropertyOffset_Int64Map;

		// Token: 0x04004B5C RID: 19292
		[Nullable(2)]
		private TMap<long, int> _Int64Map;

		// Token: 0x04004B5D RID: 19293
		internal static int __PropertyOffset_Uint64Map;

		// Token: 0x04004B5E RID: 19294
		[Nullable(2)]
		private TMap<ulong, int> _Uint64Map;

		// Token: 0x04004B5F RID: 19295
		internal static int __PropertyOffset_FloatMap;

		// Token: 0x04004B60 RID: 19296
		[Nullable(2)]
		private TMap<float, int> _FloatMap;

		// Token: 0x04004B61 RID: 19297
		internal static int __PropertyOffset_DoubleMap;

		// Token: 0x04004B62 RID: 19298
		[Nullable(2)]
		private TMap<double, int> _DoubleMap;
	}
}
