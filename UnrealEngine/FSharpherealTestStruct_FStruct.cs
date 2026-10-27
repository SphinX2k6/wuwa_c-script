using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002741 RID: 10049
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_FStruct")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 720)]
	public class FSharpherealTestStruct_FStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060253B6 RID: 152502 RVA: 0x00373417 File Offset: 0x00371617
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_FStruct._ScriptStructPtr != 0) ? FSharpherealTestStruct_FStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_FStruct", ref FSharpherealTestStruct_FStruct._ScriptStructPtr);
		}

		// Token: 0x17008FC0 RID: 36800
		// (get) Token: 0x060253B7 RID: 152503 RVA: 0x0037343B File Offset: 0x0037163B
		// (set) Token: 0x060253B8 RID: 152504 RVA: 0x0037344F File Offset: 0x0037164F
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17008FC1 RID: 36801
		// (get) Token: 0x060253B9 RID: 152505 RVA: 0x00373464 File Offset: 0x00371664
		// (set) Token: 0x060253BA RID: 152506 RVA: 0x00373478 File Offset: 0x00371678
		public unsafe FVector4 Vector4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4) = value;
			}
		}

		// Token: 0x17008FC2 RID: 36802
		// (get) Token: 0x060253BB RID: 152507 RVA: 0x00373490 File Offset: 0x00371690
		// (set) Token: 0x060253BC RID: 152508 RVA: 0x003734D3 File Offset: 0x003716D3
		public FSharpherealTestSimpleStruct SimpleStruct
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestSimpleStruct result;
				if ((result = this._SimpleStruct) == null)
				{
					result = (this._SimpleStruct = new FSharpherealTestSimpleStruct(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStruct, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStruct, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008FC3 RID: 36803
		// (get) Token: 0x060253BD RID: 152509 RVA: 0x003734F4 File Offset: 0x003716F4
		// (set) Token: 0x060253BE RID: 152510 RVA: 0x00373537 File Offset: 0x00371737
		public TArray<FVector> VectorArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VectorArray) == null)
				{
					result = (this._VectorArray = new TArray<FVector>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_VectorArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FC4 RID: 36804
		// (get) Token: 0x060253BF RID: 152511 RVA: 0x00373548 File Offset: 0x00371748
		// (set) Token: 0x060253C0 RID: 152512 RVA: 0x0037358B File Offset: 0x0037178B
		public TArray<FVector4> Vector4Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._Vector4Array) == null)
				{
					result = (this._Vector4Array = new TArray<FVector4>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector4Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FC5 RID: 36805
		// (get) Token: 0x060253C1 RID: 152513 RVA: 0x0037359C File Offset: 0x0037179C
		// (set) Token: 0x060253C2 RID: 152514 RVA: 0x003735DF File Offset: 0x003717DF
		public TArray<FSharpherealTestSimpleStruct> SimpleStructArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestSimpleStruct> result;
				if ((result = this._SimpleStructArray) == null)
				{
					result = (this._SimpleStructArray = new TArray<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStructArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleStructArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FC6 RID: 36806
		// (get) Token: 0x060253C3 RID: 152515 RVA: 0x003735F0 File Offset: 0x003717F0
		// (set) Token: 0x060253C4 RID: 152516 RVA: 0x00373634 File Offset: 0x00371834
		public TFixedArray<FVector> VectorFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FVector> result;
				if ((result = this._VectorFixedArray) == null)
				{
					result = (this._VectorFixedArray = new TFixedArray<FVector>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_VectorFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FC7 RID: 36807
		// (get) Token: 0x060253C5 RID: 152517 RVA: 0x00373644 File Offset: 0x00371844
		// (set) Token: 0x060253C6 RID: 152518 RVA: 0x00373688 File Offset: 0x00371888
		public TFixedArray<FVector4> Vector4FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FVector4> result;
				if ((result = this._Vector4FixedArray) == null)
				{
					result = (this._Vector4FixedArray = new TFixedArray<FVector4>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector4FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FC8 RID: 36808
		// (get) Token: 0x060253C7 RID: 152519 RVA: 0x00373698 File Offset: 0x00371898
		// (set) Token: 0x060253C8 RID: 152520 RVA: 0x003736DC File Offset: 0x003718DC
		public TFixedArray<FSharpherealTestSimpleStruct> SimpleStructFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSharpherealTestSimpleStruct> result;
				if ((result = this._SimpleStructFixedArray) == null)
				{
					result = (this._SimpleStructFixedArray = new TFixedArray<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStructFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleStructFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FC9 RID: 36809
		// (get) Token: 0x060253C9 RID: 152521 RVA: 0x003736EC File Offset: 0x003718EC
		// (set) Token: 0x060253CA RID: 152522 RVA: 0x0037372F File Offset: 0x0037192F
		public TSet<FVector> VectorSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FVector> result;
				if ((result = this._VectorSet) == null)
				{
					result = (this._VectorSet = new TSet<FVector>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_VectorSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FCA RID: 36810
		// (get) Token: 0x060253CB RID: 152523 RVA: 0x00373740 File Offset: 0x00371940
		// (set) Token: 0x060253CC RID: 152524 RVA: 0x00373783 File Offset: 0x00371983
		public TSet<FVector4> Vector4Set
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FVector4> result;
				if ((result = this._Vector4Set) == null)
				{
					result = (this._Vector4Set = new TSet<FVector4>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4Set, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector4Set.CopyAssign(value);
			}
		}

		// Token: 0x17008FCB RID: 36811
		// (get) Token: 0x060253CD RID: 152525 RVA: 0x00373794 File Offset: 0x00371994
		// (set) Token: 0x060253CE RID: 152526 RVA: 0x003737D7 File Offset: 0x003719D7
		public TSet<FSharpherealTestSimpleStruct> SimpleStructSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSharpherealTestSimpleStruct> result;
				if ((result = this._SimpleStructSet) == null)
				{
					result = (this._SimpleStructSet = new TSet<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStructSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleStructSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FCC RID: 36812
		// (get) Token: 0x060253CF RID: 152527 RVA: 0x003737E8 File Offset: 0x003719E8
		// (set) Token: 0x060253D0 RID: 152528 RVA: 0x0037382B File Offset: 0x00371A2B
		public TMap<FVector, int> VectorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FVector, int> result;
				if ((result = this._VectorMap) == null)
				{
					result = (this._VectorMap = new TMap<FVector, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_VectorMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FCD RID: 36813
		// (get) Token: 0x060253D1 RID: 152529 RVA: 0x0037383C File Offset: 0x00371A3C
		// (set) Token: 0x060253D2 RID: 152530 RVA: 0x0037387F File Offset: 0x00371A7F
		public TMap<FVector4, int> Vector4Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FVector4, int> result;
				if ((result = this._Vector4Map) == null)
				{
					result = (this._Vector4Map = new TMap<FVector4, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_Vector4Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector4Map.CopyAssign(value);
			}
		}

		// Token: 0x17008FCE RID: 36814
		// (get) Token: 0x060253D3 RID: 152531 RVA: 0x00373890 File Offset: 0x00371A90
		// (set) Token: 0x060253D4 RID: 152532 RVA: 0x003738D3 File Offset: 0x00371AD3
		public TMap<FSharpherealTestSimpleStruct, int> SimpleStructMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSharpherealTestSimpleStruct, int> result;
				if ((result = this._SimpleStructMap) == null)
				{
					result = (this._SimpleStructMap = new TMap<FSharpherealTestSimpleStruct, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_FStruct.__PropertyOffset_SimpleStructMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleStructMap.CopyAssign(value);
			}
		}

		// Token: 0x060253D5 RID: 152533 RVA: 0x003738E1 File Offset: 0x00371AE1
		public FSharpherealTestStruct_FStruct()
		{
		}

		// Token: 0x060253D6 RID: 152534 RVA: 0x003738EC File Offset: 0x00371AEC
		public FSharpherealTestStruct_FStruct(FVector Vector, FVector4 Vector4, FSharpherealTestSimpleStruct SimpleStruct, TArray<FVector> VectorArray, TArray<FVector4> Vector4Array, TArray<FSharpherealTestSimpleStruct> SimpleStructArray, TFixedArray<FVector> VectorFixedArray, TFixedArray<FVector4> Vector4FixedArray, TFixedArray<FSharpherealTestSimpleStruct> SimpleStructFixedArray, TSet<FVector> VectorSet, TSet<FVector4> Vector4Set, TSet<FSharpherealTestSimpleStruct> SimpleStructSet, TMap<FVector, int> VectorMap, TMap<FVector4, int> Vector4Map, TMap<FSharpherealTestSimpleStruct, int> SimpleStructMap)
		{
			this.Vector = Vector;
			this.Vector4 = Vector4;
			this.SimpleStruct = SimpleStruct;
			this.VectorArray = VectorArray;
			this.Vector4Array = Vector4Array;
			this.SimpleStructArray = SimpleStructArray;
			this.VectorFixedArray = VectorFixedArray;
			this.Vector4FixedArray = Vector4FixedArray;
			this.SimpleStructFixedArray = SimpleStructFixedArray;
			this.VectorSet = VectorSet;
			this.Vector4Set = Vector4Set;
			this.SimpleStructSet = SimpleStructSet;
			this.VectorMap = VectorMap;
			this.Vector4Map = Vector4Map;
			this.SimpleStructMap = SimpleStructMap;
		}

		// Token: 0x060253D7 RID: 152535 RVA: 0x00373974 File Offset: 0x00371B74
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_FStruct.StaticStruct();
		}

		// Token: 0x060253D8 RID: 152536 RVA: 0x00373980 File Offset: 0x00371B80
		[NullableContext(2)]
		public FSharpherealTestStruct_FStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060253D9 RID: 152537 RVA: 0x0037398A File Offset: 0x00371B8A
		public FSharpherealTestStruct_FStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060253DA RID: 152538 RVA: 0x00373995 File Offset: 0x00371B95
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_FStruct(Pointer, false, true);
		}

		// Token: 0x060253DB RID: 152539 RVA: 0x0037399F File Offset: 0x00371B9F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_FStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014147 RID: 82247
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_FStruct";

		// Token: 0x04014148 RID: 82248
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014149 RID: 82249
		internal static int __PropertyOffset_Vector;

		// Token: 0x0401414A RID: 82250
		internal static int __PropertyOffset_Vector4;

		// Token: 0x0401414B RID: 82251
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x0401414C RID: 82252
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x0401414D RID: 82253
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x0401414E RID: 82254
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x0401414F RID: 82255
		internal static int __PropertyOffset_Vector4Array;

		// Token: 0x04014150 RID: 82256
		[Nullable(2)]
		private TArray<FVector4> _Vector4Array;

		// Token: 0x04014151 RID: 82257
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x04014152 RID: 82258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x04014153 RID: 82259
		internal static int __PropertyOffset_VectorFixedArray;

		// Token: 0x04014154 RID: 82260
		[Nullable(2)]
		private TFixedArray<FVector> _VectorFixedArray;

		// Token: 0x04014155 RID: 82261
		internal static int __PropertyOffset_Vector4FixedArray;

		// Token: 0x04014156 RID: 82262
		[Nullable(2)]
		private TFixedArray<FVector4> _Vector4FixedArray;

		// Token: 0x04014157 RID: 82263
		internal static int __PropertyOffset_SimpleStructFixedArray;

		// Token: 0x04014158 RID: 82264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSharpherealTestSimpleStruct> _SimpleStructFixedArray;

		// Token: 0x04014159 RID: 82265
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x0401415A RID: 82266
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x0401415B RID: 82267
		internal static int __PropertyOffset_Vector4Set;

		// Token: 0x0401415C RID: 82268
		[Nullable(2)]
		private TSet<FVector4> _Vector4Set;

		// Token: 0x0401415D RID: 82269
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x0401415E RID: 82270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x0401415F RID: 82271
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x04014160 RID: 82272
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x04014161 RID: 82273
		internal static int __PropertyOffset_Vector4Map;

		// Token: 0x04014162 RID: 82274
		[Nullable(2)]
		private TMap<FVector4, int> _Vector4Map;

		// Token: 0x04014163 RID: 82275
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x04014164 RID: 82276
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;
	}
}
