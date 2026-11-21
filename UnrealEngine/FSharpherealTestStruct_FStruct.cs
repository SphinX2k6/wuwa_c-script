using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F5 RID: 2037
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_FStruct")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 720)]
	public class FSharpherealTestStruct_FStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE98 RID: 44696 RVA: 0x001030C6 File Offset: 0x001012C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_FStruct._ScriptStructPtr != 0) ? FSharpherealTestStruct_FStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_FStruct", ref FSharpherealTestStruct_FStruct._ScriptStructPtr);
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x001030EA File Offset: 0x001012EA
		// (set) Token: 0x0600AE9A RID: 44698 RVA: 0x001030FE File Offset: 0x001012FE
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

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x00103113 File Offset: 0x00101313
		// (set) Token: 0x0600AE9C RID: 44700 RVA: 0x00103127 File Offset: 0x00101327
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

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600AE9D RID: 44701 RVA: 0x0010313C File Offset: 0x0010133C
		// (set) Token: 0x0600AE9E RID: 44702 RVA: 0x0010317F File Offset: 0x0010137F
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

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x001031A0 File Offset: 0x001013A0
		// (set) Token: 0x0600AEA0 RID: 44704 RVA: 0x001031E3 File Offset: 0x001013E3
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

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x001031F4 File Offset: 0x001013F4
		// (set) Token: 0x0600AEA2 RID: 44706 RVA: 0x00103237 File Offset: 0x00101437
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

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x00103248 File Offset: 0x00101448
		// (set) Token: 0x0600AEA4 RID: 44708 RVA: 0x0010328B File Offset: 0x0010148B
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600AEA5 RID: 44709 RVA: 0x0010329C File Offset: 0x0010149C
		// (set) Token: 0x0600AEA6 RID: 44710 RVA: 0x001032E0 File Offset: 0x001014E0
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

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x001032F0 File Offset: 0x001014F0
		// (set) Token: 0x0600AEA8 RID: 44712 RVA: 0x00103334 File Offset: 0x00101534
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

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x00103344 File Offset: 0x00101544
		// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x00103388 File Offset: 0x00101588
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

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x00103398 File Offset: 0x00101598
		// (set) Token: 0x0600AEAC RID: 44716 RVA: 0x001033DB File Offset: 0x001015DB
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

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x001033EC File Offset: 0x001015EC
		// (set) Token: 0x0600AEAE RID: 44718 RVA: 0x0010342F File Offset: 0x0010162F
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

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x00103440 File Offset: 0x00101640
		// (set) Token: 0x0600AEB0 RID: 44720 RVA: 0x00103483 File Offset: 0x00101683
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

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x00103494 File Offset: 0x00101694
		// (set) Token: 0x0600AEB2 RID: 44722 RVA: 0x001034D7 File Offset: 0x001016D7
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

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x001034E8 File Offset: 0x001016E8
		// (set) Token: 0x0600AEB4 RID: 44724 RVA: 0x0010352B File Offset: 0x0010172B
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

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600AEB5 RID: 44725 RVA: 0x0010353C File Offset: 0x0010173C
		// (set) Token: 0x0600AEB6 RID: 44726 RVA: 0x0010357F File Offset: 0x0010177F
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

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x0010358D File Offset: 0x0010178D
		public FSharpherealTestStruct_FStruct()
		{
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x00103595 File Offset: 0x00101795
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_FStruct.StaticStruct();
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x001035A1 File Offset: 0x001017A1
		[NullableContext(2)]
		public FSharpherealTestStruct_FStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x001035AB File Offset: 0x001017AB
		public FSharpherealTestStruct_FStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AEBB RID: 44731 RVA: 0x001035B6 File Offset: 0x001017B6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_FStruct(Pointer, false, true);
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x001035C0 File Offset: 0x001017C0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_FStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04004BA6 RID: 19366
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_FStruct";

		// Token: 0x04004BA7 RID: 19367
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004BA8 RID: 19368
		internal static int __PropertyOffset_Vector;

		// Token: 0x04004BA9 RID: 19369
		internal static int __PropertyOffset_Vector4;

		// Token: 0x04004BAA RID: 19370
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x04004BAB RID: 19371
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x04004BAC RID: 19372
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x04004BAD RID: 19373
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x04004BAE RID: 19374
		internal static int __PropertyOffset_Vector4Array;

		// Token: 0x04004BAF RID: 19375
		[Nullable(2)]
		private TArray<FVector4> _Vector4Array;

		// Token: 0x04004BB0 RID: 19376
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x04004BB1 RID: 19377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x04004BB2 RID: 19378
		internal static int __PropertyOffset_VectorFixedArray;

		// Token: 0x04004BB3 RID: 19379
		[Nullable(2)]
		private TFixedArray<FVector> _VectorFixedArray;

		// Token: 0x04004BB4 RID: 19380
		internal static int __PropertyOffset_Vector4FixedArray;

		// Token: 0x04004BB5 RID: 19381
		[Nullable(2)]
		private TFixedArray<FVector4> _Vector4FixedArray;

		// Token: 0x04004BB6 RID: 19382
		internal static int __PropertyOffset_SimpleStructFixedArray;

		// Token: 0x04004BB7 RID: 19383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSharpherealTestSimpleStruct> _SimpleStructFixedArray;

		// Token: 0x04004BB8 RID: 19384
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x04004BB9 RID: 19385
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x04004BBA RID: 19386
		internal static int __PropertyOffset_Vector4Set;

		// Token: 0x04004BBB RID: 19387
		[Nullable(2)]
		private TSet<FVector4> _Vector4Set;

		// Token: 0x04004BBC RID: 19388
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x04004BBD RID: 19389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x04004BBE RID: 19390
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x04004BBF RID: 19391
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x04004BC0 RID: 19392
		internal static int __PropertyOffset_Vector4Map;

		// Token: 0x04004BC1 RID: 19393
		[Nullable(2)]
		private TMap<FVector4, int> _Vector4Map;

		// Token: 0x04004BC2 RID: 19394
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x04004BC3 RID: 19395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;
	}
}
