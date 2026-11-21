using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F9 RID: 2041
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_UObject")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1456)]
	public class FSharpherealTestStruct_UObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF28 RID: 44840 RVA: 0x001043D9 File Offset: 0x001025D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_UObject._ScriptStructPtr != 0) ? FSharpherealTestStruct_UObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_UObject", ref FSharpherealTestStruct_UObject._ScriptStructPtr);
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600AF29 RID: 44841 RVA: 0x001043FD File Offset: 0x001025FD
		// (set) Token: 0x0600AF2A RID: 44842 RVA: 0x00104411 File Offset: 0x00102611
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

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600AF2B RID: 44843 RVA: 0x00104426 File Offset: 0x00102626
		// (set) Token: 0x0600AF2C RID: 44844 RVA: 0x0010443A File Offset: 0x0010263A
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

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600AF2D RID: 44845 RVA: 0x0010444F File Offset: 0x0010264F
		// (set) Token: 0x0600AF2E RID: 44846 RVA: 0x00104463 File Offset: 0x00102663
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

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600AF2F RID: 44847 RVA: 0x00104478 File Offset: 0x00102678
		// (set) Token: 0x0600AF30 RID: 44848 RVA: 0x00104497 File Offset: 0x00102697
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

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600AF31 RID: 44849 RVA: 0x001044BC File Offset: 0x001026BC
		// (set) Token: 0x0600AF32 RID: 44850 RVA: 0x001044D0 File Offset: 0x001026D0
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

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600AF33 RID: 44851 RVA: 0x001044E8 File Offset: 0x001026E8
		// (set) Token: 0x0600AF34 RID: 44852 RVA: 0x0010452B File Offset: 0x0010272B
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

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x0010454C File Offset: 0x0010274C
		// (set) Token: 0x0600AF36 RID: 44854 RVA: 0x0010458F File Offset: 0x0010278F
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

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600AF37 RID: 44855 RVA: 0x001045A0 File Offset: 0x001027A0
		// (set) Token: 0x0600AF38 RID: 44856 RVA: 0x001045E3 File Offset: 0x001027E3
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

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600AF39 RID: 44857 RVA: 0x001045F4 File Offset: 0x001027F4
		// (set) Token: 0x0600AF3A RID: 44858 RVA: 0x00104637 File Offset: 0x00102837
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

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x00104648 File Offset: 0x00102848
		// (set) Token: 0x0600AF3C RID: 44860 RVA: 0x0010468B File Offset: 0x0010288B
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

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600AF3D RID: 44861 RVA: 0x0010469C File Offset: 0x0010289C
		// (set) Token: 0x0600AF3E RID: 44862 RVA: 0x001046DF File Offset: 0x001028DF
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

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x001046F0 File Offset: 0x001028F0
		// (set) Token: 0x0600AF40 RID: 44864 RVA: 0x00104733 File Offset: 0x00102933
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

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x00104744 File Offset: 0x00102944
		// (set) Token: 0x0600AF42 RID: 44866 RVA: 0x00104788 File Offset: 0x00102988
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

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600AF43 RID: 44867 RVA: 0x00104798 File Offset: 0x00102998
		// (set) Token: 0x0600AF44 RID: 44868 RVA: 0x001047DC File Offset: 0x001029DC
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

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x001047EC File Offset: 0x001029EC
		// (set) Token: 0x0600AF46 RID: 44870 RVA: 0x00104830 File Offset: 0x00102A30
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x00104840 File Offset: 0x00102A40
		// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x00104884 File Offset: 0x00102A84
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

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x00104894 File Offset: 0x00102A94
		// (set) Token: 0x0600AF4A RID: 44874 RVA: 0x001048D8 File Offset: 0x00102AD8
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

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600AF4B RID: 44875 RVA: 0x001048E8 File Offset: 0x00102AE8
		// (set) Token: 0x0600AF4C RID: 44876 RVA: 0x0010492C File Offset: 0x00102B2C
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

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600AF4D RID: 44877 RVA: 0x0010493C File Offset: 0x00102B3C
		// (set) Token: 0x0600AF4E RID: 44878 RVA: 0x0010497F File Offset: 0x00102B7F
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

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600AF4F RID: 44879 RVA: 0x00104990 File Offset: 0x00102B90
		// (set) Token: 0x0600AF50 RID: 44880 RVA: 0x001049D3 File Offset: 0x00102BD3
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

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600AF51 RID: 44881 RVA: 0x001049E4 File Offset: 0x00102BE4
		// (set) Token: 0x0600AF52 RID: 44882 RVA: 0x00104A27 File Offset: 0x00102C27
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

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600AF53 RID: 44883 RVA: 0x00104A38 File Offset: 0x00102C38
		// (set) Token: 0x0600AF54 RID: 44884 RVA: 0x00104A7B File Offset: 0x00102C7B
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

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600AF55 RID: 44885 RVA: 0x00104A8C File Offset: 0x00102C8C
		// (set) Token: 0x0600AF56 RID: 44886 RVA: 0x00104ACF File Offset: 0x00102CCF
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

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600AF57 RID: 44887 RVA: 0x00104AE0 File Offset: 0x00102CE0
		// (set) Token: 0x0600AF58 RID: 44888 RVA: 0x00104B23 File Offset: 0x00102D23
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

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600AF59 RID: 44889 RVA: 0x00104B34 File Offset: 0x00102D34
		// (set) Token: 0x0600AF5A RID: 44890 RVA: 0x00104B77 File Offset: 0x00102D77
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

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600AF5B RID: 44891 RVA: 0x00104B88 File Offset: 0x00102D88
		// (set) Token: 0x0600AF5C RID: 44892 RVA: 0x00104BCB File Offset: 0x00102DCB
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

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x00104BDC File Offset: 0x00102DDC
		// (set) Token: 0x0600AF5E RID: 44894 RVA: 0x00104C1F File Offset: 0x00102E1F
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

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x0600AF5F RID: 44895 RVA: 0x00104C30 File Offset: 0x00102E30
		// (set) Token: 0x0600AF60 RID: 44896 RVA: 0x00104C73 File Offset: 0x00102E73
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

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600AF61 RID: 44897 RVA: 0x00104C84 File Offset: 0x00102E84
		// (set) Token: 0x0600AF62 RID: 44898 RVA: 0x00104CC7 File Offset: 0x00102EC7
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

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600AF63 RID: 44899 RVA: 0x00104CD8 File Offset: 0x00102ED8
		// (set) Token: 0x0600AF64 RID: 44900 RVA: 0x00104D1B File Offset: 0x00102F1B
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

		// Token: 0x0600AF65 RID: 44901 RVA: 0x00104D29 File Offset: 0x00102F29
		public FSharpherealTestStruct_UObject()
		{
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x00104D31 File Offset: 0x00102F31
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_UObject.StaticStruct();
		}

		// Token: 0x0600AF67 RID: 44903 RVA: 0x00104D3D File Offset: 0x00102F3D
		[NullableContext(2)]
		public FSharpherealTestStruct_UObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x00104D47 File Offset: 0x00102F47
		public FSharpherealTestStruct_UObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x00104D52 File Offset: 0x00102F52
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_UObject(Pointer, false, true);
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x00104D5C File Offset: 0x00102F5C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_UObject(Pointer, MemoryOwner);
		}

		// Token: 0x04004C17 RID: 19479
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_UObject";

		// Token: 0x04004C18 RID: 19480
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004C19 RID: 19481
		internal static int __PropertyOffset_Object;

		// Token: 0x04004C1A RID: 19482
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x04004C1B RID: 19483
		internal static int __PropertyOffset_WeakObject;

		// Token: 0x04004C1C RID: 19484
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x04004C1D RID: 19485
		internal static int __PropertyOffset_LazyObject;

		// Token: 0x04004C1E RID: 19486
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04004C1F RID: 19487
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x04004C20 RID: 19488
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x04004C21 RID: 19489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x04004C22 RID: 19490
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x04004C23 RID: 19491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x04004C24 RID: 19492
		internal static int __PropertyOffset_WeakObjectArray;

		// Token: 0x04004C25 RID: 19493
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectArray;

		// Token: 0x04004C26 RID: 19494
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x04004C27 RID: 19495
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x04004C28 RID: 19496
		internal static int __PropertyOffset_LazyObjectArray;

		// Token: 0x04004C29 RID: 19497
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectArray;

		// Token: 0x04004C2A RID: 19498
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x04004C2B RID: 19499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x04004C2C RID: 19500
		internal static int __PropertyOffset_ObjectFixedArray;

		// Token: 0x04004C2D RID: 19501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UObject> _ObjectFixedArray;

		// Token: 0x04004C2E RID: 19502
		internal static int __PropertyOffset_SimpleObjectFixedArray;

		// Token: 0x04004C2F RID: 19503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<USharpherealTestSimpleClass> _SimpleObjectFixedArray;

		// Token: 0x04004C30 RID: 19504
		internal static int __PropertyOffset_WeakObjectFixedArray;

		// Token: 0x04004C31 RID: 19505
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectFixedArray;

		// Token: 0x04004C32 RID: 19506
		internal static int __PropertyOffset_SoftObjectFixedArray;

		// Token: 0x04004C33 RID: 19507
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TFixedArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectFixedArray;

		// Token: 0x04004C34 RID: 19508
		internal static int __PropertyOffset_LazyObjectFixedArray;

		// Token: 0x04004C35 RID: 19509
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TFixedArray<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectFixedArray;

		// Token: 0x04004C36 RID: 19510
		internal static int __PropertyOffset_ObjectPathFixedArray;

		// Token: 0x04004C37 RID: 19511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSoftObjectPath> _ObjectPathFixedArray;

		// Token: 0x04004C38 RID: 19512
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x04004C39 RID: 19513
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x04004C3A RID: 19514
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x04004C3B RID: 19515
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x04004C3C RID: 19516
		internal static int __PropertyOffset_WeakObjectSet;

		// Token: 0x04004C3D RID: 19517
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TWeakObjectPtr<USharpherealTestSimpleClass>> _WeakObjectSet;

		// Token: 0x04004C3E RID: 19518
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x04004C3F RID: 19519
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x04004C40 RID: 19520
		internal static int __PropertyOffset_LazyObjectSet;

		// Token: 0x04004C41 RID: 19521
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TLazyObjectPtr<USharpherealTestSimpleClass>> _LazyObjectSet;

		// Token: 0x04004C42 RID: 19522
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x04004C43 RID: 19523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x04004C44 RID: 19524
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x04004C45 RID: 19525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x04004C46 RID: 19526
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x04004C47 RID: 19527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x04004C48 RID: 19528
		internal static int __PropertyOffset_WeakObjectMap;

		// Token: 0x04004C49 RID: 19529
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<USharpherealTestSimpleClass>, int> _WeakObjectMap;

		// Token: 0x04004C4A RID: 19530
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x04004C4B RID: 19531
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x04004C4C RID: 19532
		internal static int __PropertyOffset_LazyObjectMap;

		// Token: 0x04004C4D RID: 19533
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TLazyObjectPtr<USharpherealTestSimpleClass>, int> _LazyObjectMap;

		// Token: 0x04004C4E RID: 19534
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x04004C4F RID: 19535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;
	}
}
