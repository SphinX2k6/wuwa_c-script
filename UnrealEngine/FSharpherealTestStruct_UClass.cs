using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002744 RID: 10052
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_UClass")]
	[UnrealStructLayout(1000, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1000)]
	public class FSharpherealTestStruct_UClass : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025418 RID: 152600 RVA: 0x003741D8 File Offset: 0x003723D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_UClass._ScriptStructPtr != 0) ? FSharpherealTestStruct_UClass._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_UClass", ref FSharpherealTestStruct_UClass._ScriptStructPtr);
		}

		// Token: 0x17008FE5 RID: 36837
		// (get) Token: 0x06025419 RID: 152601 RVA: 0x003741FC File Offset: 0x003723FC
		// (set) Token: 0x0602541A RID: 152602 RVA: 0x0037420C File Offset: 0x0037240C
		public unsafe int DiffKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_DiffKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_DiffKey) = value;
			}
		}

		// Token: 0x17008FE6 RID: 36838
		// (get) Token: 0x0602541B RID: 152603 RVA: 0x0037421D File Offset: 0x0037241D
		// (set) Token: 0x0602541C RID: 152604 RVA: 0x00374231 File Offset: 0x00372431
		public unsafe UClassStackOnlyPtr Class
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_Class);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_Class) = value;
			}
		}

		// Token: 0x17008FE7 RID: 36839
		// (get) Token: 0x0602541D RID: 152605 RVA: 0x00374246 File Offset: 0x00372446
		// (set) Token: 0x0602541E RID: 152606 RVA: 0x00374265 File Offset: 0x00372465
		public TSoftClassPtr<USharpherealTestSimpleClass> SoftClass
		{
			get
			{
				return new TSoftClassPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClass, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008FE8 RID: 36840
		// (get) Token: 0x0602541F RID: 152607 RVA: 0x0037428A File Offset: 0x0037248A
		// (set) Token: 0x06025420 RID: 152608 RVA: 0x0037429E File Offset: 0x0037249E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> SubClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClass) = value;
			}
		}

		// Token: 0x17008FE9 RID: 36841
		// (get) Token: 0x06025421 RID: 152609 RVA: 0x003742B4 File Offset: 0x003724B4
		// (set) Token: 0x06025422 RID: 152610 RVA: 0x003742F7 File Offset: 0x003724F7
		public FSoftClassPath ClassPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ClassPath) == null)
				{
					result = (this._ClassPath = new FSoftClassPath(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008FEA RID: 36842
		// (get) Token: 0x06025423 RID: 152611 RVA: 0x00374318 File Offset: 0x00372518
		// (set) Token: 0x06025424 RID: 152612 RVA: 0x0037435B File Offset: 0x0037255B
		public TArray<UClass> ClassArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._ClassArray) == null)
				{
					result = (this._ClassArray = new TArray<UClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FEB RID: 36843
		// (get) Token: 0x06025425 RID: 152613 RVA: 0x0037436C File Offset: 0x0037256C
		// (set) Token: 0x06025426 RID: 152614 RVA: 0x003743AF File Offset: 0x003725AF
		public TArray<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftClassArray) == null)
				{
					result = (this._SoftClassArray = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClassArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftClassArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FEC RID: 36844
		// (get) Token: 0x06025427 RID: 152615 RVA: 0x003743C0 File Offset: 0x003725C0
		// (set) Token: 0x06025428 RID: 152616 RVA: 0x00374403 File Offset: 0x00372603
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<USharpherealTestSimpleClass>> SubClassArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<USharpherealTestSimpleClass>> result;
				if ((result = this._SubClassArray) == null)
				{
					result = (this._SubClassArray = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClassArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FED RID: 36845
		// (get) Token: 0x06025429 RID: 152617 RVA: 0x00374414 File Offset: 0x00372614
		// (set) Token: 0x0602542A RID: 152618 RVA: 0x00374457 File Offset: 0x00372657
		public TArray<FSoftClassPath> ClassPathArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftClassPath> result;
				if ((result = this._ClassPathArray) == null)
				{
					result = (this._ClassPathArray = new TArray<FSoftClassPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPathArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassPathArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FEE RID: 36846
		// (get) Token: 0x0602542B RID: 152619 RVA: 0x00374468 File Offset: 0x00372668
		// (set) Token: 0x0602542C RID: 152620 RVA: 0x003744AC File Offset: 0x003726AC
		public TFixedArray<UClass> ClassFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UClass> result;
				if ((result = this._ClassFixedArray) == null)
				{
					result = (this._ClassFixedArray = new TFixedArray<UClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FEF RID: 36847
		// (get) Token: 0x0602542D RID: 152621 RVA: 0x003744BC File Offset: 0x003726BC
		// (set) Token: 0x0602542E RID: 152622 RVA: 0x00374500 File Offset: 0x00372700
		public TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftClassFixedArray) == null)
				{
					result = (this._SoftClassFixedArray = new TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClassFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftClassFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FF0 RID: 36848
		// (get) Token: 0x0602542F RID: 152623 RVA: 0x00374510 File Offset: 0x00372710
		// (set) Token: 0x06025430 RID: 152624 RVA: 0x00374554 File Offset: 0x00372754
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TFixedArray<TSubclassOf<USharpherealTestSimpleClass>> SubClassFixedArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TSubclassOf<USharpherealTestSimpleClass>> result;
				if ((result = this._SubClassFixedArray) == null)
				{
					result = (this._SubClassFixedArray = new TFixedArray<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClassFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FF1 RID: 36849
		// (get) Token: 0x06025431 RID: 152625 RVA: 0x00374564 File Offset: 0x00372764
		// (set) Token: 0x06025432 RID: 152626 RVA: 0x003745A8 File Offset: 0x003727A8
		public TFixedArray<FSoftClassPath> ClassPathFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSoftClassPath> result;
				if ((result = this._ClassPathFixedArray) == null)
				{
					result = (this._ClassPathFixedArray = new TFixedArray<FSoftClassPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPathFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassPathFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FF2 RID: 36850
		// (get) Token: 0x06025433 RID: 152627 RVA: 0x003745B8 File Offset: 0x003727B8
		// (set) Token: 0x06025434 RID: 152628 RVA: 0x003745FB File Offset: 0x003727FB
		public TSet<UClass> ClassSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UClass> result;
				if ((result = this._ClassSet) == null)
				{
					result = (this._ClassSet = new TSet<UClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FF3 RID: 36851
		// (get) Token: 0x06025435 RID: 152629 RVA: 0x0037460C File Offset: 0x0037280C
		// (set) Token: 0x06025436 RID: 152630 RVA: 0x0037464F File Offset: 0x0037284F
		public TSet<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftClassSet) == null)
				{
					result = (this._SoftClassSet = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClassSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftClassSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FF4 RID: 36852
		// (get) Token: 0x06025437 RID: 152631 RVA: 0x00374660 File Offset: 0x00372860
		// (set) Token: 0x06025438 RID: 152632 RVA: 0x003746A3 File Offset: 0x003728A3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TSubclassOf<USharpherealTestSimpleClass>> SubClassSet
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TSubclassOf<USharpherealTestSimpleClass>> result;
				if ((result = this._SubClassSet) == null)
				{
					result = (this._SubClassSet = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClassSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FF5 RID: 36853
		// (get) Token: 0x06025439 RID: 152633 RVA: 0x003746B4 File Offset: 0x003728B4
		// (set) Token: 0x0602543A RID: 152634 RVA: 0x003746F7 File Offset: 0x003728F7
		public TSet<FSoftClassPath> ClassPathSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSoftClassPath> result;
				if ((result = this._ClassPathSet) == null)
				{
					result = (this._ClassPathSet = new TSet<FSoftClassPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPathSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassPathSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FF6 RID: 36854
		// (get) Token: 0x0602543B RID: 152635 RVA: 0x00374708 File Offset: 0x00372908
		// (set) Token: 0x0602543C RID: 152636 RVA: 0x0037474B File Offset: 0x0037294B
		public TMap<UClass, int> ClassMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UClass, int> result;
				if ((result = this._ClassMap) == null)
				{
					result = (this._ClassMap = new TMap<UClass, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FF7 RID: 36855
		// (get) Token: 0x0602543D RID: 152637 RVA: 0x0037475C File Offset: 0x0037295C
		// (set) Token: 0x0602543E RID: 152638 RVA: 0x0037479F File Offset: 0x0037299F
		public TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> SoftClassMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SoftClassMap) == null)
				{
					result = (this._SoftClassMap = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SoftClassMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftClassMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FF8 RID: 36856
		// (get) Token: 0x0602543F RID: 152639 RVA: 0x003747B0 File Offset: 0x003729B0
		// (set) Token: 0x06025440 RID: 152640 RVA: 0x003747F3 File Offset: 0x003729F3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TSubclassOf<USharpherealTestSimpleClass>, int> SubClassMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SubClassMap) == null)
				{
					result = (this._SubClassMap = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_SubClassMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FF9 RID: 36857
		// (get) Token: 0x06025441 RID: 152641 RVA: 0x00374804 File Offset: 0x00372A04
		// (set) Token: 0x06025442 RID: 152642 RVA: 0x00374847 File Offset: 0x00372A47
		public TMap<FSoftClassPath, int> ClassPathMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftClassPath, int> result;
				if ((result = this._ClassPathMap) == null)
				{
					result = (this._ClassPathMap = new TMap<FSoftClassPath, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UClass.__PropertyOffset_ClassPathMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassPathMap.CopyAssign(value);
			}
		}

		// Token: 0x06025443 RID: 152643 RVA: 0x00374855 File Offset: 0x00372A55
		public FSharpherealTestStruct_UClass()
		{
		}

		// Token: 0x06025444 RID: 152644 RVA: 0x00374860 File Offset: 0x00372A60
		public FSharpherealTestStruct_UClass(int DiffKey, UClassStackOnlyPtr Class, TSoftClassPtr<USharpherealTestSimpleClass> SoftClass, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USharpherealTestSimpleClass> SubClass, FSoftClassPath ClassPath, TArray<UClass> ClassArray, TArray<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TSubclassOf<USharpherealTestSimpleClass>> SubClassArray, TArray<FSoftClassPath> ClassPathArray, TFixedArray<UClass> ClassFixedArray, TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassFixedArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TFixedArray<TSubclassOf<USharpherealTestSimpleClass>> SubClassFixedArray, TFixedArray<FSoftClassPath> ClassPathFixedArray, TSet<UClass> ClassSet, TSet<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassSet, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TSet<TSubclassOf<USharpherealTestSimpleClass>> SubClassSet, TSet<FSoftClassPath> ClassPathSet, TMap<UClass, int> ClassMap, TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> SoftClassMap, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TSubclassOf<USharpherealTestSimpleClass>, int> SubClassMap, TMap<FSoftClassPath, int> ClassPathMap)
		{
			this.DiffKey = DiffKey;
			this.Class = Class;
			this.SoftClass = SoftClass;
			this.SubClass = SubClass;
			this.ClassPath = ClassPath;
			this.ClassArray = ClassArray;
			this.SoftClassArray = SoftClassArray;
			this.SubClassArray = SubClassArray;
			this.ClassPathArray = ClassPathArray;
			this.ClassFixedArray = ClassFixedArray;
			this.SoftClassFixedArray = SoftClassFixedArray;
			this.SubClassFixedArray = SubClassFixedArray;
			this.ClassPathFixedArray = ClassPathFixedArray;
			this.ClassSet = ClassSet;
			this.SoftClassSet = SoftClassSet;
			this.SubClassSet = SubClassSet;
			this.ClassPathSet = ClassPathSet;
			this.ClassMap = ClassMap;
			this.SoftClassMap = SoftClassMap;
			this.SubClassMap = SubClassMap;
			this.ClassPathMap = ClassPathMap;
		}

		// Token: 0x06025445 RID: 152645 RVA: 0x00374918 File Offset: 0x00372B18
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_UClass.StaticStruct();
		}

		// Token: 0x06025446 RID: 152646 RVA: 0x00374924 File Offset: 0x00372B24
		[NullableContext(2)]
		public FSharpherealTestStruct_UClass(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025447 RID: 152647 RVA: 0x0037492E File Offset: 0x00372B2E
		public FSharpherealTestStruct_UClass(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025448 RID: 152648 RVA: 0x00374939 File Offset: 0x00372B39
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_UClass(Pointer, false, true);
		}

		// Token: 0x06025449 RID: 152649 RVA: 0x00374943 File Offset: 0x00372B43
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_UClass(Pointer, MemoryOwner);
		}

		// Token: 0x04014190 RID: 82320
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_UClass";

		// Token: 0x04014191 RID: 82321
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014192 RID: 82322
		internal static int __PropertyOffset_DiffKey;

		// Token: 0x04014193 RID: 82323
		internal static int __PropertyOffset_Class;

		// Token: 0x04014194 RID: 82324
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x04014195 RID: 82325
		internal static int __PropertyOffset_SubClass;

		// Token: 0x04014196 RID: 82326
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x04014197 RID: 82327
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x04014198 RID: 82328
		internal static int __PropertyOffset_ClassArray;

		// Token: 0x04014199 RID: 82329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ClassArray;

		// Token: 0x0401419A RID: 82330
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x0401419B RID: 82331
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x0401419C RID: 82332
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x0401419D RID: 82333
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x0401419E RID: 82334
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x0401419F RID: 82335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x040141A0 RID: 82336
		internal static int __PropertyOffset_ClassFixedArray;

		// Token: 0x040141A1 RID: 82337
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UClass> _ClassFixedArray;

		// Token: 0x040141A2 RID: 82338
		internal static int __PropertyOffset_SoftClassFixedArray;

		// Token: 0x040141A3 RID: 82339
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassFixedArray;

		// Token: 0x040141A4 RID: 82340
		internal static int __PropertyOffset_SubClassFixedArray;

		// Token: 0x040141A5 RID: 82341
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassFixedArray;

		// Token: 0x040141A6 RID: 82342
		internal static int __PropertyOffset_ClassPathFixedArray;

		// Token: 0x040141A7 RID: 82343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSoftClassPath> _ClassPathFixedArray;

		// Token: 0x040141A8 RID: 82344
		internal static int __PropertyOffset_ClassSet;

		// Token: 0x040141A9 RID: 82345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _ClassSet;

		// Token: 0x040141AA RID: 82346
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x040141AB RID: 82347
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x040141AC RID: 82348
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x040141AD RID: 82349
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x040141AE RID: 82350
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x040141AF RID: 82351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x040141B0 RID: 82352
		internal static int __PropertyOffset_ClassMap;

		// Token: 0x040141B1 RID: 82353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _ClassMap;

		// Token: 0x040141B2 RID: 82354
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x040141B3 RID: 82355
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x040141B4 RID: 82356
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x040141B5 RID: 82357
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x040141B6 RID: 82358
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x040141B7 RID: 82359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;
	}
}
