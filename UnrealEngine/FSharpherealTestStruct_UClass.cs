using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F8 RID: 2040
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_UClass")]
	[UnrealStructLayout(1000, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1000)]
	public class FSharpherealTestStruct_UClass : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AEF7 RID: 44791 RVA: 0x00103D21 File Offset: 0x00101F21
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_UClass._ScriptStructPtr != 0) ? FSharpherealTestStruct_UClass._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_UClass", ref FSharpherealTestStruct_UClass._ScriptStructPtr);
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x00103D45 File Offset: 0x00101F45
		// (set) Token: 0x0600AEF9 RID: 44793 RVA: 0x00103D55 File Offset: 0x00101F55
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

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x00103D66 File Offset: 0x00101F66
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x00103D7A File Offset: 0x00101F7A
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

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x00103D8F File Offset: 0x00101F8F
		// (set) Token: 0x0600AEFD RID: 44797 RVA: 0x00103DAE File Offset: 0x00101FAE
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

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x00103DD3 File Offset: 0x00101FD3
		// (set) Token: 0x0600AEFF RID: 44799 RVA: 0x00103DE7 File Offset: 0x00101FE7
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

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x00103DFC File Offset: 0x00101FFC
		// (set) Token: 0x0600AF01 RID: 44801 RVA: 0x00103E3F File Offset: 0x0010203F
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

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x00103E60 File Offset: 0x00102060
		// (set) Token: 0x0600AF03 RID: 44803 RVA: 0x00103EA3 File Offset: 0x001020A3
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

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x00103EB4 File Offset: 0x001020B4
		// (set) Token: 0x0600AF05 RID: 44805 RVA: 0x00103EF7 File Offset: 0x001020F7
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

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x00103F08 File Offset: 0x00102108
		// (set) Token: 0x0600AF07 RID: 44807 RVA: 0x00103F4B File Offset: 0x0010214B
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

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x00103F5C File Offset: 0x0010215C
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x00103F9F File Offset: 0x0010219F
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

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600AF0A RID: 44810 RVA: 0x00103FB0 File Offset: 0x001021B0
		// (set) Token: 0x0600AF0B RID: 44811 RVA: 0x00103FF4 File Offset: 0x001021F4
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

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x00104004 File Offset: 0x00102204
		// (set) Token: 0x0600AF0D RID: 44813 RVA: 0x00104048 File Offset: 0x00102248
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

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x00104058 File Offset: 0x00102258
		// (set) Token: 0x0600AF0F RID: 44815 RVA: 0x0010409C File Offset: 0x0010229C
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

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x001040AC File Offset: 0x001022AC
		// (set) Token: 0x0600AF11 RID: 44817 RVA: 0x001040F0 File Offset: 0x001022F0
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

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x00104100 File Offset: 0x00102300
		// (set) Token: 0x0600AF13 RID: 44819 RVA: 0x00104143 File Offset: 0x00102343
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

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x00104154 File Offset: 0x00102354
		// (set) Token: 0x0600AF15 RID: 44821 RVA: 0x00104197 File Offset: 0x00102397
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

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x001041A8 File Offset: 0x001023A8
		// (set) Token: 0x0600AF17 RID: 44823 RVA: 0x001041EB File Offset: 0x001023EB
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

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x001041FC File Offset: 0x001023FC
		// (set) Token: 0x0600AF19 RID: 44825 RVA: 0x0010423F File Offset: 0x0010243F
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

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600AF1A RID: 44826 RVA: 0x00104250 File Offset: 0x00102450
		// (set) Token: 0x0600AF1B RID: 44827 RVA: 0x00104293 File Offset: 0x00102493
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

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x001042A4 File Offset: 0x001024A4
		// (set) Token: 0x0600AF1D RID: 44829 RVA: 0x001042E7 File Offset: 0x001024E7
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

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600AF1E RID: 44830 RVA: 0x001042F8 File Offset: 0x001024F8
		// (set) Token: 0x0600AF1F RID: 44831 RVA: 0x0010433B File Offset: 0x0010253B
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x0010434C File Offset: 0x0010254C
		// (set) Token: 0x0600AF21 RID: 44833 RVA: 0x0010438F File Offset: 0x0010258F
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

		// Token: 0x0600AF22 RID: 44834 RVA: 0x0010439D File Offset: 0x0010259D
		public FSharpherealTestStruct_UClass()
		{
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x001043A5 File Offset: 0x001025A5
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_UClass.StaticStruct();
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x001043B1 File Offset: 0x001025B1
		[NullableContext(2)]
		public FSharpherealTestStruct_UClass(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x001043BB File Offset: 0x001025BB
		public FSharpherealTestStruct_UClass(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x001043C6 File Offset: 0x001025C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_UClass(Pointer, false, true);
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x001043D0 File Offset: 0x001025D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_UClass(Pointer, MemoryOwner);
		}

		// Token: 0x04004BEF RID: 19439
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_UClass";

		// Token: 0x04004BF0 RID: 19440
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004BF1 RID: 19441
		internal static int __PropertyOffset_DiffKey;

		// Token: 0x04004BF2 RID: 19442
		internal static int __PropertyOffset_Class;

		// Token: 0x04004BF3 RID: 19443
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x04004BF4 RID: 19444
		internal static int __PropertyOffset_SubClass;

		// Token: 0x04004BF5 RID: 19445
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x04004BF6 RID: 19446
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x04004BF7 RID: 19447
		internal static int __PropertyOffset_ClassArray;

		// Token: 0x04004BF8 RID: 19448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ClassArray;

		// Token: 0x04004BF9 RID: 19449
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x04004BFA RID: 19450
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x04004BFB RID: 19451
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x04004BFC RID: 19452
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x04004BFD RID: 19453
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x04004BFE RID: 19454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x04004BFF RID: 19455
		internal static int __PropertyOffset_ClassFixedArray;

		// Token: 0x04004C00 RID: 19456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UClass> _ClassFixedArray;

		// Token: 0x04004C01 RID: 19457
		internal static int __PropertyOffset_SoftClassFixedArray;

		// Token: 0x04004C02 RID: 19458
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TFixedArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassFixedArray;

		// Token: 0x04004C03 RID: 19459
		internal static int __PropertyOffset_SubClassFixedArray;

		// Token: 0x04004C04 RID: 19460
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassFixedArray;

		// Token: 0x04004C05 RID: 19461
		internal static int __PropertyOffset_ClassPathFixedArray;

		// Token: 0x04004C06 RID: 19462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSoftClassPath> _ClassPathFixedArray;

		// Token: 0x04004C07 RID: 19463
		internal static int __PropertyOffset_ClassSet;

		// Token: 0x04004C08 RID: 19464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _ClassSet;

		// Token: 0x04004C09 RID: 19465
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x04004C0A RID: 19466
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x04004C0B RID: 19467
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x04004C0C RID: 19468
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x04004C0D RID: 19469
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x04004C0E RID: 19470
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x04004C0F RID: 19471
		internal static int __PropertyOffset_ClassMap;

		// Token: 0x04004C10 RID: 19472
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _ClassMap;

		// Token: 0x04004C11 RID: 19473
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x04004C12 RID: 19474
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x04004C13 RID: 19475
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x04004C14 RID: 19476
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x04004C15 RID: 19477
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x04004C16 RID: 19478
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;
	}
}
