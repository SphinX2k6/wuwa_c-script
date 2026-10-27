using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002745 RID: 10053
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_UObject")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1456)]
	public class FSharpherealTestStruct_UObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602544A RID: 152650 RVA: 0x0037494C File Offset: 0x00372B4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_UObject._ScriptStructPtr != 0) ? FSharpherealTestStruct_UObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_UObject", ref FSharpherealTestStruct_UObject._ScriptStructPtr);
		}

		// Token: 0x17008FFA RID: 36858
		// (get) Token: 0x0602544B RID: 152651 RVA: 0x00374970 File Offset: 0x00372B70
		// (set) Token: 0x0602544C RID: 152652 RVA: 0x00374984 File Offset: 0x00372B84
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSharpherealTestStruct_UObject.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSharpherealTestStruct_UObject.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x17008FFB RID: 36859
		// (get) Token: 0x0602544D RID: 152653 RVA: 0x00374999 File Offset: 0x00372B99
		// (set) Token: 0x0602544E RID: 152654 RVA: 0x003749AD File Offset: 0x00372BAD
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObject, value);
			}
		}

		// Token: 0x17008FFC RID: 36860
		// (get) Token: 0x0602544F RID: 152655 RVA: 0x003749C2 File Offset: 0x00372BC2
		// (set) Token: 0x06025450 RID: 152656 RVA: 0x003749D6 File Offset: 0x00372BD6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USharpherealTestSimpleClass> WeakObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObject) = value;
			}
		}

		// Token: 0x17008FFD RID: 36861
		// (get) Token: 0x06025451 RID: 152657 RVA: 0x003749EB File Offset: 0x00372BEB
		// (set) Token: 0x06025452 RID: 152658 RVA: 0x00374A0A File Offset: 0x00372C0A
		public TSoftObjectPtr<USharpherealTestSimpleClass> SoftObject
		{
			get
			{
				return new TSoftObjectPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObject, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008FFE RID: 36862
		// (get) Token: 0x06025453 RID: 152659 RVA: 0x00374A2F File Offset: 0x00372C2F
		// (set) Token: 0x06025454 RID: 152660 RVA: 0x00374A43 File Offset: 0x00372C43
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<USharpherealTestSimpleClass> LazyObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObject) = value;
			}
		}

		// Token: 0x17008FFF RID: 36863
		// (get) Token: 0x06025455 RID: 152661 RVA: 0x00374A58 File Offset: 0x00372C58
		// (set) Token: 0x06025456 RID: 152662 RVA: 0x00374A9B File Offset: 0x00372C9B
		public FSoftObjectPath ObjectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ObjectPath) == null)
				{
					result = (this._ObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009000 RID: 36864
		// (get) Token: 0x06025457 RID: 152663 RVA: 0x00374ABC File Offset: 0x00372CBC
		// (set) Token: 0x06025458 RID: 152664 RVA: 0x00374AFF File Offset: 0x00372CFF
		public TArray<UObject> ObjectArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjectArray) == null)
				{
					result = (this._ObjectArray = new TArray<UObject>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009001 RID: 36865
		// (get) Token: 0x06025459 RID: 152665 RVA: 0x00374B10 File Offset: 0x00372D10
		// (set) Token: 0x0602545A RID: 152666 RVA: 0x00374B53 File Offset: 0x00372D53
		public TArray<USharpherealTestSimpleClass> SimpleObjectArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USharpherealTestSimpleClass> result;
				if ((result = this._SimpleObjectArray) == null)
				{
					result = (this._SimpleObjectArray = new TArray<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObjectArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009002 RID: 36866
		// (get) Token: 0x0602545B RID: 152667 RVA: 0x00374B64 File Offset: 0x00372D64
		// (set) Token: 0x0602545C RID: 152668 RVA: 0x00374BA7 File Offset: 0x00372DA7
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectArray
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
				TArray<TWeakObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._WeakObjectArray) == null)
				{
					result = (this._WeakObjectArray = new TArray<TWeakObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObjectArray, base.MemoryOwner ?? this));
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
				this.WeakObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009003 RID: 36867
		// (get) Token: 0x0602545D RID: 152669 RVA: 0x00374BB8 File Offset: 0x00372DB8
		// (set) Token: 0x0602545E RID: 152670 RVA: 0x00374BFB File Offset: 0x00372DFB
		public TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftObjectArray) == null)
				{
					result = (this._SoftObjectArray = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObjectArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009004 RID: 36868
		// (get) Token: 0x0602545F RID: 152671 RVA: 0x00374C0C File Offset: 0x00372E0C
		// (set) Token: 0x06025460 RID: 152672 RVA: 0x00374C4F File Offset: 0x00372E4F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectArray
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
				TArray<TLazyObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._LazyObjectArray) == null)
				{
					result = (this._LazyObjectArray = new TArray<TLazyObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObjectArray, base.MemoryOwner ?? this));
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
				this.LazyObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009005 RID: 36869
		// (get) Token: 0x06025461 RID: 152673 RVA: 0x00374C60 File Offset: 0x00372E60
		// (set) Token: 0x06025462 RID: 152674 RVA: 0x00374CA3 File Offset: 0x00372EA3
		public TArray<FSoftObjectPath> ObjectPathArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ObjectPathArray) == null)
				{
					result = (this._ObjectPathArray = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPathArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectPathArray.CopyAssign(value);
			}
		}

		// Token: 0x17009006 RID: 36870
		// (get) Token: 0x06025463 RID: 152675 RVA: 0x00374CB4 File Offset: 0x00372EB4
		// (set) Token: 0x06025464 RID: 152676 RVA: 0x00374CF8 File Offset: 0x00372EF8
		public TFixedArray<UObject> ObjectFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UObject> result;
				if ((result = this._ObjectFixedArray) == null)
				{
					result = (this._ObjectFixedArray = new TFixedArray<UObject>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17009007 RID: 36871
		// (get) Token: 0x06025465 RID: 152677 RVA: 0x00374D08 File Offset: 0x00372F08
		// (set) Token: 0x06025466 RID: 152678 RVA: 0x00374D4C File Offset: 0x00372F4C
		public TFixedArray<USharpherealTestSimpleClass> SimpleObjectFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<USharpherealTestSimpleClass> result;
				if ((result = this._SimpleObjectFixedArray) == null)
				{
					result = (this._SimpleObjectFixedArray = new TFixedArray<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObjectFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleObjectFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17009008 RID: 36872
		// (get) Token: 0x06025467 RID: 152679 RVA: 0x00374D5C File Offset: 0x00372F5C
		// (set) Token: 0x06025468 RID: 152680 RVA: 0x00374DA0 File Offset: 0x00372FA0
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectFixedArray
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
				TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._WeakObjectFixedArray) == null)
				{
					result = (this._WeakObjectFixedArray = new TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObjectFixedArray, 2, base.MemoryOwner ?? this));
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
				this.WeakObjectFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17009009 RID: 36873
		// (get) Token: 0x06025469 RID: 152681 RVA: 0x00374DB0 File Offset: 0x00372FB0
		// (set) Token: 0x0602546A RID: 152682 RVA: 0x00374DF4 File Offset: 0x00372FF4
		public TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftObjectFixedArray) == null)
				{
					result = (this._SoftObjectFixedArray = new TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObjectFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftObjectFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x1700900A RID: 36874
		// (get) Token: 0x0602546B RID: 152683 RVA: 0x00374E04 File Offset: 0x00373004
		// (set) Token: 0x0602546C RID: 152684 RVA: 0x00374E48 File Offset: 0x00373048
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectFixedArray
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
				TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._LazyObjectFixedArray) == null)
				{
					result = (this._LazyObjectFixedArray = new TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObjectFixedArray, 2, base.MemoryOwner ?? this));
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
				this.LazyObjectFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x1700900B RID: 36875
		// (get) Token: 0x0602546D RID: 152685 RVA: 0x00374E58 File Offset: 0x00373058
		// (set) Token: 0x0602546E RID: 152686 RVA: 0x00374E9C File Offset: 0x0037309C
		public TFixedArray<FSoftObjectPath> ObjectPathFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSoftObjectPath> result;
				if ((result = this._ObjectPathFixedArray) == null)
				{
					result = (this._ObjectPathFixedArray = new TFixedArray<FSoftObjectPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPathFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectPathFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x1700900C RID: 36876
		// (get) Token: 0x0602546F RID: 152687 RVA: 0x00374EAC File Offset: 0x003730AC
		// (set) Token: 0x06025470 RID: 152688 RVA: 0x00374EEF File Offset: 0x003730EF
		public TSet<UObject> ObjectSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._ObjectSet) == null)
				{
					result = (this._ObjectSet = new TSet<UObject>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x1700900D RID: 36877
		// (get) Token: 0x06025471 RID: 152689 RVA: 0x00374F00 File Offset: 0x00373100
		// (set) Token: 0x06025472 RID: 152690 RVA: 0x00374F43 File Offset: 0x00373143
		public TSet<USharpherealTestSimpleClass> SimpleObjectSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<USharpherealTestSimpleClass> result;
				if ((result = this._SimpleObjectSet) == null)
				{
					result = (this._SimpleObjectSet = new TSet<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObjectSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x1700900E RID: 36878
		// (get) Token: 0x06025473 RID: 152691 RVA: 0x00374F54 File Offset: 0x00373154
		// (set) Token: 0x06025474 RID: 152692 RVA: 0x00374F97 File Offset: 0x00373197
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectSet
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
				TSet<TWeakObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._WeakObjectSet) == null)
				{
					result = (this._WeakObjectSet = new TSet<TWeakObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObjectSet, base.MemoryOwner ?? this));
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
				this.WeakObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x1700900F RID: 36879
		// (get) Token: 0x06025475 RID: 152693 RVA: 0x00374FA8 File Offset: 0x003731A8
		// (set) Token: 0x06025476 RID: 152694 RVA: 0x00374FEB File Offset: 0x003731EB
		public TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftObjectSet) == null)
				{
					result = (this._SoftObjectSet = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObjectSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x17009010 RID: 36880
		// (get) Token: 0x06025477 RID: 152695 RVA: 0x00374FFC File Offset: 0x003731FC
		// (set) Token: 0x06025478 RID: 152696 RVA: 0x0037503F File Offset: 0x0037323F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectSet
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
				TSet<TLazyObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._LazyObjectSet) == null)
				{
					result = (this._LazyObjectSet = new TSet<TLazyObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObjectSet, base.MemoryOwner ?? this));
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
				this.LazyObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x17009011 RID: 36881
		// (get) Token: 0x06025479 RID: 152697 RVA: 0x00375050 File Offset: 0x00373250
		// (set) Token: 0x0602547A RID: 152698 RVA: 0x00375093 File Offset: 0x00373293
		public TSet<FSoftObjectPath> ObjectPathSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSoftObjectPath> result;
				if ((result = this._ObjectPathSet) == null)
				{
					result = (this._ObjectPathSet = new TSet<FSoftObjectPath>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPathSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectPathSet.CopyAssign(value);
			}
		}

		// Token: 0x17009012 RID: 36882
		// (get) Token: 0x0602547B RID: 152699 RVA: 0x003750A4 File Offset: 0x003732A4
		// (set) Token: 0x0602547C RID: 152700 RVA: 0x003750E7 File Offset: 0x003732E7
		public TMap<UObject, int> ObjectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, int> result;
				if ((result = this._ObjectMap) == null)
				{
					result = (this._ObjectMap = new TMap<UObject, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009013 RID: 36883
		// (get) Token: 0x0602547D RID: 152701 RVA: 0x003750F8 File Offset: 0x003732F8
		// (set) Token: 0x0602547E RID: 152702 RVA: 0x0037513B File Offset: 0x0037333B
		public TMap<USharpherealTestSimpleClass, int> SimpleObjectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<USharpherealTestSimpleClass, int> result;
				if ((result = this._SimpleObjectMap) == null)
				{
					result = (this._SimpleObjectMap = new TMap<USharpherealTestSimpleClass, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SimpleObjectMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimpleObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009014 RID: 36884
		// (get) Token: 0x0602547F RID: 152703 RVA: 0x0037514C File Offset: 0x0037334C
		// (set) Token: 0x06025480 RID: 152704 RVA: 0x0037518F File Offset: 0x0037338F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int> WeakObjectMap
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
				TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._WeakObjectMap) == null)
				{
					result = (this._WeakObjectMap = new TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_WeakObjectMap, base.MemoryOwner ?? this));
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
				this.WeakObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009015 RID: 36885
		// (get) Token: 0x06025481 RID: 152705 RVA: 0x003751A0 File Offset: 0x003733A0
		// (set) Token: 0x06025482 RID: 152706 RVA: 0x003751E3 File Offset: 0x003733E3
		public TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> SoftObjectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SoftObjectMap) == null)
				{
					result = (this._SoftObjectMap = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_SoftObjectMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoftObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009016 RID: 36886
		// (get) Token: 0x06025483 RID: 152707 RVA: 0x003751F4 File Offset: 0x003733F4
		// (set) Token: 0x06025484 RID: 152708 RVA: 0x00375237 File Offset: 0x00373437
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int> LazyObjectMap
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
				TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._LazyObjectMap) == null)
				{
					result = (this._LazyObjectMap = new TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_LazyObjectMap, base.MemoryOwner ?? this));
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
				this.LazyObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009017 RID: 36887
		// (get) Token: 0x06025485 RID: 152709 RVA: 0x00375248 File Offset: 0x00373448
		// (set) Token: 0x06025486 RID: 152710 RVA: 0x0037528B File Offset: 0x0037348B
		public TMap<FSoftObjectPath, int> ObjectPathMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, int> result;
				if ((result = this._ObjectPathMap) == null)
				{
					result = (this._ObjectPathMap = new TMap<FSoftObjectPath, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_UObject.__PropertyOffset_ObjectPathMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectPathMap.CopyAssign(value);
			}
		}

		// Token: 0x06025487 RID: 152711 RVA: 0x00375299 File Offset: 0x00373499
		public FSharpherealTestStruct_UObject()
		{
		}

		// Token: 0x06025488 RID: 152712 RVA: 0x003752A4 File Offset: 0x003734A4
		public FSharpherealTestStruct_UObject(UObject Object, USharpherealTestSimpleClass SimpleObject, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<USharpherealTestSimpleClass> WeakObject, TSoftObjectPtr<USharpherealTestSimpleClass> SoftObject, [Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<USharpherealTestSimpleClass> LazyObject, FSoftObjectPath ObjectPath, TArray<UObject> ObjectArray, TArray<USharpherealTestSimpleClass> SimpleObjectArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectArray, TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectArray, TArray<FSoftObjectPath> ObjectPathArray, TFixedArray<UObject> ObjectFixedArray, TFixedArray<USharpherealTestSimpleClass> SimpleObjectFixedArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectFixedArray, TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectFixedArray, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectFixedArray, TFixedArray<FSoftObjectPath> ObjectPathFixedArray, TSet<UObject> ObjectSet, TSet<USharpherealTestSimpleClass> SimpleObjectSet, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TSet<TWeakObjectPtr<USharpherealTestSimpleClass>> WeakObjectSet, TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectSet, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TSet<TLazyObjectPtr<USharpherealTestSimpleClass>> LazyObjectSet, TSet<FSoftObjectPath> ObjectPathSet, TMap<UObject, int> ObjectMap, TMap<USharpherealTestSimpleClass, int> SimpleObjectMap, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int> WeakObjectMap, TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> SoftObjectMap, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int> LazyObjectMap, TMap<FSoftObjectPath, int> ObjectPathMap)
		{
			this.Object = Object;
			this.SimpleObject = SimpleObject;
			this.WeakObject = WeakObject;
			this.SoftObject = SoftObject;
			this.LazyObject = LazyObject;
			this.ObjectPath = ObjectPath;
			this.ObjectArray = ObjectArray;
			this.SimpleObjectArray = SimpleObjectArray;
			this.WeakObjectArray = WeakObjectArray;
			this.SoftObjectArray = SoftObjectArray;
			this.LazyObjectArray = LazyObjectArray;
			this.ObjectPathArray = ObjectPathArray;
			this.ObjectFixedArray = ObjectFixedArray;
			this.SimpleObjectFixedArray = SimpleObjectFixedArray;
			this.WeakObjectFixedArray = WeakObjectFixedArray;
			this.SoftObjectFixedArray = SoftObjectFixedArray;
			this.LazyObjectFixedArray = LazyObjectFixedArray;
			this.ObjectPathFixedArray = ObjectPathFixedArray;
			this.ObjectSet = ObjectSet;
			this.SimpleObjectSet = SimpleObjectSet;
			this.WeakObjectSet = WeakObjectSet;
			this.SoftObjectSet = SoftObjectSet;
			this.LazyObjectSet = LazyObjectSet;
			this.ObjectPathSet = ObjectPathSet;
			this.ObjectMap = ObjectMap;
			this.SimpleObjectMap = SimpleObjectMap;
			this.WeakObjectMap = WeakObjectMap;
			this.SoftObjectMap = SoftObjectMap;
			this.LazyObjectMap = LazyObjectMap;
			this.ObjectPathMap = ObjectPathMap;
		}

		// Token: 0x06025489 RID: 152713 RVA: 0x003753A4 File Offset: 0x003735A4
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_UObject.StaticStruct();
		}

		// Token: 0x0602548A RID: 152714 RVA: 0x003753B0 File Offset: 0x003735B0
		[NullableContext(2)]
		public FSharpherealTestStruct_UObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602548B RID: 152715 RVA: 0x003753BA File Offset: 0x003735BA
		public FSharpherealTestStruct_UObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602548C RID: 152716 RVA: 0x003753C5 File Offset: 0x003735C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_UObject(Pointer, false, true);
		}

		// Token: 0x0602548D RID: 152717 RVA: 0x003753CF File Offset: 0x003735CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_UObject(Pointer, MemoryOwner);
		}

		// Token: 0x040141B8 RID: 82360
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_UObject";

		// Token: 0x040141B9 RID: 82361
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040141BA RID: 82362
		internal static int __PropertyOffset_Object;

		// Token: 0x040141BB RID: 82363
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x040141BC RID: 82364
		internal static int __PropertyOffset_WeakObject;

		// Token: 0x040141BD RID: 82365
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x040141BE RID: 82366
		internal static int __PropertyOffset_LazyObject;

		// Token: 0x040141BF RID: 82367
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x040141C0 RID: 82368
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x040141C1 RID: 82369
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x040141C2 RID: 82370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x040141C3 RID: 82371
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x040141C4 RID: 82372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x040141C5 RID: 82373
		internal static int __PropertyOffset_WeakObjectArray;

		// Token: 0x040141C6 RID: 82374
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectArray;

		// Token: 0x040141C7 RID: 82375
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x040141C8 RID: 82376
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x040141C9 RID: 82377
		internal static int __PropertyOffset_LazyObjectArray;

		// Token: 0x040141CA RID: 82378
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectArray;

		// Token: 0x040141CB RID: 82379
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x040141CC RID: 82380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x040141CD RID: 82381
		internal static int __PropertyOffset_ObjectFixedArray;

		// Token: 0x040141CE RID: 82382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UObject> _ObjectFixedArray;

		// Token: 0x040141CF RID: 82383
		internal static int __PropertyOffset_SimpleObjectFixedArray;

		// Token: 0x040141D0 RID: 82384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<USharpherealTestSimpleClass> _SimpleObjectFixedArray;

		// Token: 0x040141D1 RID: 82385
		internal static int __PropertyOffset_WeakObjectFixedArray;

		// Token: 0x040141D2 RID: 82386
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectFixedArray;

		// Token: 0x040141D3 RID: 82387
		internal static int __PropertyOffset_SoftObjectFixedArray;

		// Token: 0x040141D4 RID: 82388
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectFixedArray;

		// Token: 0x040141D5 RID: 82389
		internal static int __PropertyOffset_LazyObjectFixedArray;

		// Token: 0x040141D6 RID: 82390
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectFixedArray;

		// Token: 0x040141D7 RID: 82391
		internal static int __PropertyOffset_ObjectPathFixedArray;

		// Token: 0x040141D8 RID: 82392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSoftObjectPath> _ObjectPathFixedArray;

		// Token: 0x040141D9 RID: 82393
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x040141DA RID: 82394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x040141DB RID: 82395
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x040141DC RID: 82396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x040141DD RID: 82397
		internal static int __PropertyOffset_WeakObjectSet;

		// Token: 0x040141DE RID: 82398
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectSet;

		// Token: 0x040141DF RID: 82399
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x040141E0 RID: 82400
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x040141E1 RID: 82401
		internal static int __PropertyOffset_LazyObjectSet;

		// Token: 0x040141E2 RID: 82402
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectSet;

		// Token: 0x040141E3 RID: 82403
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x040141E4 RID: 82404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x040141E5 RID: 82405
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x040141E6 RID: 82406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x040141E7 RID: 82407
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x040141E8 RID: 82408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x040141E9 RID: 82409
		internal static int __PropertyOffset_WeakObjectMap;

		// Token: 0x040141EA RID: 82410
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int> _WeakObjectMap;

		// Token: 0x040141EB RID: 82411
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x040141EC RID: 82412
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x040141ED RID: 82413
		internal static int __PropertyOffset_LazyObjectMap;

		// Token: 0x040141EE RID: 82414
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int> _LazyObjectMap;

		// Token: 0x040141EF RID: 82415
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x040141F0 RID: 82416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;
	}
}
