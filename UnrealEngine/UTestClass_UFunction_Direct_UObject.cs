using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274D RID: 10061
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_UObject")]
	[UnrealStructLayout(992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class UTestClass_UFunction_Direct_UObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257F2 RID: 153586 RVA: 0x00385BC6 File Offset: 0x00383DC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_UObject._ClassPtr;
		}

		// Token: 0x060257F3 RID: 153587 RVA: 0x00385BD4 File Offset: 0x00383DD4
		public UTestClass_UFunction_Direct_UObject() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257F4 RID: 153588 RVA: 0x00385BFC File Offset: 0x00383DFC
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_UObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090A4 RID: 37028
		// (get) Token: 0x060257F5 RID: 153589 RVA: 0x00385C2F File Offset: 0x00383E2F
		// (set) Token: 0x060257F6 RID: 153590 RVA: 0x00385C43 File Offset: 0x00383E43
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass ObjectBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectBase, value);
			}
		}

		// Token: 0x170090A5 RID: 37029
		// (get) Token: 0x060257F7 RID: 153591 RVA: 0x00385C58 File Offset: 0x00383E58
		// (set) Token: 0x060257F8 RID: 153592 RVA: 0x00385C6C File Offset: 0x00383E6C
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass ObjectCmp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectCmp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectCmp, value);
			}
		}

		// Token: 0x170090A6 RID: 37030
		// (get) Token: 0x060257F9 RID: 153593 RVA: 0x00385C81 File Offset: 0x00383E81
		// (set) Token: 0x060257FA RID: 153594 RVA: 0x00385C95 File Offset: 0x00383E95
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObjectBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectBase, value);
			}
		}

		// Token: 0x170090A7 RID: 37031
		// (get) Token: 0x060257FB RID: 153595 RVA: 0x00385CAA File Offset: 0x00383EAA
		// (set) Token: 0x060257FC RID: 153596 RVA: 0x00385CBE File Offset: 0x00383EBE
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObjectCmp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectCmp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectCmp, value);
			}
		}

		// Token: 0x170090A8 RID: 37032
		// (get) Token: 0x060257FD RID: 153597 RVA: 0x00385CD3 File Offset: 0x00383ED3
		// (set) Token: 0x060257FE RID: 153598 RVA: 0x00385CE7 File Offset: 0x00383EE7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USharpherealTestSimpleClass> WeakObjectBase
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectBase);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectBase) = value;
			}
		}

		// Token: 0x170090A9 RID: 37033
		// (get) Token: 0x060257FF RID: 153599 RVA: 0x00385CFC File Offset: 0x00383EFC
		// (set) Token: 0x06025800 RID: 153600 RVA: 0x00385D10 File Offset: 0x00383F10
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USharpherealTestSimpleClass> WeakObjectSame
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectSame);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectSame) = value;
			}
		}

		// Token: 0x170090AA RID: 37034
		// (get) Token: 0x06025801 RID: 153601 RVA: 0x00385D25 File Offset: 0x00383F25
		// (set) Token: 0x06025802 RID: 153602 RVA: 0x00385D39 File Offset: 0x00383F39
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USharpherealTestSimpleClass> WeakObjectCmp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectCmp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_WeakObjectCmp) = value;
			}
		}

		// Token: 0x170090AB RID: 37035
		// (get) Token: 0x06025803 RID: 153603 RVA: 0x00385D4E File Offset: 0x00383F4E
		// (set) Token: 0x06025804 RID: 153604 RVA: 0x00385D62 File Offset: 0x00383F62
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<USharpherealTestSimpleClass> LazyObjectBase
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectBase);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectBase) = value;
			}
		}

		// Token: 0x170090AC RID: 37036
		// (get) Token: 0x06025805 RID: 153605 RVA: 0x00385D77 File Offset: 0x00383F77
		// (set) Token: 0x06025806 RID: 153606 RVA: 0x00385D8B File Offset: 0x00383F8B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<USharpherealTestSimpleClass> LazyObjectSame
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectSame);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectSame) = value;
			}
		}

		// Token: 0x170090AD RID: 37037
		// (get) Token: 0x06025807 RID: 153607 RVA: 0x00385DA0 File Offset: 0x00383FA0
		// (set) Token: 0x06025808 RID: 153608 RVA: 0x00385DB4 File Offset: 0x00383FB4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<USharpherealTestSimpleClass> LazyObjectCmp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectCmp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_LazyObjectCmp) = value;
			}
		}

		// Token: 0x170090AE RID: 37038
		// (get) Token: 0x06025809 RID: 153609 RVA: 0x00385DC9 File Offset: 0x00383FC9
		// (set) Token: 0x0602580A RID: 153610 RVA: 0x00385DDD File Offset: 0x00383FDD
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x170090AF RID: 37039
		// (get) Token: 0x0602580B RID: 153611 RVA: 0x00385DF4 File Offset: 0x00383FF4
		// (set) Token: 0x0602580C RID: 153612 RVA: 0x00385E2D File Offset: 0x0038402D
		[Nullable(1)]
		public TArray<UObject> ObjectArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjectArray) == null)
				{
					result = (this._ObjectArray = new TArray<UObject>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170090B0 RID: 37040
		// (get) Token: 0x0602580D RID: 153613 RVA: 0x00385E3C File Offset: 0x0038403C
		// (set) Token: 0x0602580E RID: 153614 RVA: 0x00385E75 File Offset: 0x00384075
		[Nullable(1)]
		public TSet<UObject> ObjectSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._ObjectSet) == null)
				{
					result = (this._ObjectSet = new TSet<UObject>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x170090B1 RID: 37041
		// (get) Token: 0x0602580F RID: 153615 RVA: 0x00385E84 File Offset: 0x00384084
		// (set) Token: 0x06025810 RID: 153616 RVA: 0x00385EBD File Offset: 0x003840BD
		[Nullable(1)]
		public TMap<UObject, int> ObjectMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, int> result;
				if ((result = this._ObjectMap) == null)
				{
					result = (this._ObjectMap = new TMap<UObject, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x170090B2 RID: 37042
		// (get) Token: 0x06025811 RID: 153617 RVA: 0x00385ECB File Offset: 0x003840CB
		// (set) Token: 0x06025812 RID: 153618 RVA: 0x00385EDF File Offset: 0x003840DF
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObject, value);
			}
		}

		// Token: 0x170090B3 RID: 37043
		// (get) Token: 0x06025813 RID: 153619 RVA: 0x00385EF4 File Offset: 0x003840F4
		// (set) Token: 0x06025814 RID: 153620 RVA: 0x00385F2D File Offset: 0x0038412D
		[Nullable(1)]
		public TArray<USharpherealTestSimpleClass> SimpleObjectArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USharpherealTestSimpleClass> result;
				if ((result = this._SimpleObjectArray) == null)
				{
					result = (this._SimpleObjectArray = new TArray<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170090B4 RID: 37044
		// (get) Token: 0x06025815 RID: 153621 RVA: 0x00385F3C File Offset: 0x0038413C
		// (set) Token: 0x06025816 RID: 153622 RVA: 0x00385F75 File Offset: 0x00384175
		[Nullable(1)]
		public TSet<USharpherealTestSimpleClass> SimpleObjectSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<USharpherealTestSimpleClass> result;
				if ((result = this._SimpleObjectSet) == null)
				{
					result = (this._SimpleObjectSet = new TSet<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x170090B5 RID: 37045
		// (get) Token: 0x06025817 RID: 153623 RVA: 0x00385F84 File Offset: 0x00384184
		// (set) Token: 0x06025818 RID: 153624 RVA: 0x00385FBD File Offset: 0x003841BD
		[Nullable(1)]
		public TMap<USharpherealTestSimpleClass, int> SimpleObjectMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<USharpherealTestSimpleClass, int> result;
				if ((result = this._SimpleObjectMap) == null)
				{
					result = (this._SimpleObjectMap = new TMap<USharpherealTestSimpleClass, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SimpleObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x170090B6 RID: 37046
		// (get) Token: 0x06025819 RID: 153625 RVA: 0x00385FCB File Offset: 0x003841CB
		// (set) Token: 0x0602581A RID: 153626 RVA: 0x00385FE0 File Offset: 0x003841E0
		[Nullable(1)]
		public TSoftObjectPtr<USharpherealTestSimpleClass> SoftObject
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SoftObject, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SoftObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170090B7 RID: 37047
		// (get) Token: 0x0602581B RID: 153627 RVA: 0x00386008 File Offset: 0x00384208
		// (set) Token: 0x0602581C RID: 153628 RVA: 0x00386041 File Offset: 0x00384241
		[Nullable(1)]
		public TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftObjectArray) == null)
				{
					result = (this._SoftObjectArray = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SoftObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170090B8 RID: 37048
		// (get) Token: 0x0602581D RID: 153629 RVA: 0x00386050 File Offset: 0x00384250
		// (set) Token: 0x0602581E RID: 153630 RVA: 0x00386089 File Offset: 0x00384289
		[Nullable(1)]
		public TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> SoftObjectSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftObjectSet) == null)
				{
					result = (this._SoftObjectSet = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SoftObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x170090B9 RID: 37049
		// (get) Token: 0x0602581F RID: 153631 RVA: 0x00386098 File Offset: 0x00384298
		// (set) Token: 0x06025820 RID: 153632 RVA: 0x003860D1 File Offset: 0x003842D1
		[Nullable(1)]
		public TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> SoftObjectMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SoftObjectMap) == null)
				{
					result = (this._SoftObjectMap = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_SoftObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x170090BA RID: 37050
		// (get) Token: 0x06025821 RID: 153633 RVA: 0x003860E0 File Offset: 0x003842E0
		// (set) Token: 0x06025822 RID: 153634 RVA: 0x00386119 File Offset: 0x00384319
		[Nullable(1)]
		public FSoftObjectPath ObjectPath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ObjectPath) == null)
				{
					result = (this._ObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170090BB RID: 37051
		// (get) Token: 0x06025823 RID: 153635 RVA: 0x0038613C File Offset: 0x0038433C
		// (set) Token: 0x06025824 RID: 153636 RVA: 0x00386175 File Offset: 0x00384375
		[Nullable(1)]
		public TArray<FSoftObjectPath> ObjectPathArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._ObjectPathArray) == null)
				{
					result = (this._ObjectPathArray = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectPathArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathArray.CopyAssign(value);
			}
		}

		// Token: 0x170090BC RID: 37052
		// (get) Token: 0x06025825 RID: 153637 RVA: 0x00386184 File Offset: 0x00384384
		// (set) Token: 0x06025826 RID: 153638 RVA: 0x003861BD File Offset: 0x003843BD
		[Nullable(1)]
		public TSet<FSoftObjectPath> ObjectPathSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<FSoftObjectPath> result;
				if ((result = this._ObjectPathSet) == null)
				{
					result = (this._ObjectPathSet = new TSet<FSoftObjectPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectPathSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathSet.CopyAssign(value);
			}
		}

		// Token: 0x170090BD RID: 37053
		// (get) Token: 0x06025827 RID: 153639 RVA: 0x003861CC File Offset: 0x003843CC
		// (set) Token: 0x06025828 RID: 153640 RVA: 0x00386205 File Offset: 0x00384405
		[Nullable(1)]
		public TMap<FSoftObjectPath, int> ObjectPathMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, int> result;
				if ((result = this._ObjectPathMap) == null)
				{
					result = (this._ObjectPathMap = new TMap<FSoftObjectPath, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UObject.__PropertyOffset_ObjectPathMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathMap.CopyAssign(value);
			}
		}

		// Token: 0x06025829 RID: 153641 RVA: 0x00386214 File Offset: 0x00384414
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSubPathString(ref TSoftObjectPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_Direct_UObject._ClassDefaultObjectPtr, UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 0);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582A RID: 153642 RVA: 0x003862B0 File Offset: 0x003844B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectSet != null)
			{
				InSoftObjectSet.CopyTo(&ptr->InSoftObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582B RID: 153643 RVA: 0x0038631C File Offset: 0x0038451C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> InSoftObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectMap != null)
			{
				InSoftObjectMap.CopyTo(&ptr->InSoftObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582C RID: 153644 RVA: 0x00386388 File Offset: 0x00384588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectArray != null)
			{
				InSoftObjectArray.CopyTo(&ptr->InSoftObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582D RID: 153645 RVA: 0x003863F4 File Offset: 0x003845F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObject(TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582E RID: 153646 RVA: 0x00386464 File Offset: 0x00384664
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<USharpherealTestSimpleClass> InSimpleObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectSet != null)
			{
				InSimpleObjectSet.CopyTo(&ptr->InSimpleObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602582F RID: 153647 RVA: 0x003864D0 File Offset: 0x003846D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<USharpherealTestSimpleClass, int> InSimpleObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectMap != null)
			{
				InSimpleObjectMap.CopyTo(&ptr->InSimpleObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025830 RID: 153648 RVA: 0x0038653C File Offset: 0x0038473C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<USharpherealTestSimpleClass> InSimpleObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectArray != null)
			{
				InSimpleObjectArray.CopyTo(&ptr->InSimpleObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025831 RID: 153649 RVA: 0x003865A8 File Offset: 0x003847A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObject(USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSimpleObject = ((InSimpleObject != null) ? InSimpleObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025832 RID: 153650 RVA: 0x00386600 File Offset: 0x00384800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<UObject> InObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectSet != null)
			{
				InObjectSet.CopyTo(&ptr->InObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025833 RID: 153651 RVA: 0x0038666C File Offset: 0x0038486C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSoftObjectPath> InObjectPathSet)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathSet != null)
			{
				InObjectPathSet.CopyTo(&ptr->InObjectPathSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025834 RID: 153652 RVA: 0x003866D8 File Offset: 0x003848D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSoftObjectPath, int> InObjectPathMap)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathMap != null)
			{
				InObjectPathMap.CopyTo(&ptr->InObjectPathMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025835 RID: 153653 RVA: 0x00386744 File Offset: 0x00384944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSoftObjectPath> InObjectPathArray)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathArray != null)
			{
				InObjectPathArray.CopyTo(&ptr->InObjectPathArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025836 RID: 153654 RVA: 0x003867B0 File Offset: 0x003849B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPath(FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025837 RID: 153655 RVA: 0x00386824 File Offset: 0x00384A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<UObject, int> InObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectMap != null)
			{
				InObjectMap.CopyTo(&ptr->InObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025838 RID: 153656 RVA: 0x00386890 File Offset: 0x00384A90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<UObject> InObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectArray != null)
			{
				InObjectArray.CopyTo(&ptr->InObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025839 RID: 153657 RVA: 0x003868FC File Offset: 0x00384AFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObject(UObject InObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InObject = ((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602583A RID: 153658 RVA: 0x00386954 File Offset: 0x00384B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> OutSoftObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset = OutSoftObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = OutSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602583B RID: 153659 RVA: 0x003869D0 File Offset: 0x00384BD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> OutSoftObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap = OutSoftObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602583C RID: 153660 RVA: 0x00386A4C File Offset: 0x00384C4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> OutSoftObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray = OutSoftObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602583D RID: 153661 RVA: 0x00386AC8 File Offset: 0x00384CC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObject(ref TSoftObjectPtr<USharpherealTestSimpleClass> OutSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftObject, OutSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftObject.NativePtr, &ptr->OutSoftObject, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602583E RID: 153662 RVA: 0x00386B58 File Offset: 0x00384D58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<USharpherealTestSimpleClass> OutSimpleObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<USharpherealTestSimpleClass> tset = OutSimpleObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> tset2 = OutSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602583F RID: 153663 RVA: 0x00386BD4 File Offset: 0x00384DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<USharpherealTestSimpleClass, int> OutSimpleObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<USharpherealTestSimpleClass, int> tmap = OutSimpleObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> tmap2 = OutSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025840 RID: 153664 RVA: 0x00386C50 File Offset: 0x00384E50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USharpherealTestSimpleClass> OutSimpleObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USharpherealTestSimpleClass> tarray = OutSimpleObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> tarray2 = OutSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025841 RID: 153665 RVA: 0x00386CCC File Offset: 0x00384ECC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObject(ref USharpherealTestSimpleClass OutSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = OutSimpleObject;
			ptr2.OutSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
			OutSimpleObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->OutSimpleObject);
		}

		// Token: 0x06025842 RID: 153666 RVA: 0x00386D34 File Offset: 0x00384F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UObject> OutObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UObject> tset = OutObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> tset2 = OutObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025843 RID: 153667 RVA: 0x00386DB0 File Offset: 0x00384FB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSoftObjectPath> OutObjectPathSet)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftObjectPath> tset = OutObjectPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> tset2 = OutObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025844 RID: 153668 RVA: 0x00386E2C File Offset: 0x0038502C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSoftObjectPath, int> OutObjectPathMap)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftObjectPath, int> tmap = OutObjectPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> tmap2 = OutObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025845 RID: 153669 RVA: 0x00386EA8 File Offset: 0x003850A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoftObjectPath> OutObjectPathArray)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftObjectPath> tarray = OutObjectPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> tarray2 = OutObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025846 RID: 153670 RVA: 0x00386F24 File Offset: 0x00385124
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPath(ref FSoftObjectPath OutObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->OutObjectPath, OutObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), OutObjectPath.NativePtr, &ptr->OutObjectPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025847 RID: 153671 RVA: 0x00386FC0 File Offset: 0x003851C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UObject, int> OutObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UObject, int> tmap = OutObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> tmap2 = OutObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025848 RID: 153672 RVA: 0x0038703C File Offset: 0x0038523C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OutObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UObject> tarray = OutObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> tarray2 = OutObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025849 RID: 153673 RVA: 0x003870B8 File Offset: 0x003852B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObject(ref UObject OutObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = OutObject;
			ptr2.OutObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 0);
			OutObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->OutObject);
		}

		// Token: 0x0602584A RID: 153674 RVA: 0x00387120 File Offset: 0x00385320
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset = InSoftObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = InSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602584B RID: 153675 RVA: 0x0038719C File Offset: 0x0038539C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> InSoftObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap = InSoftObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602584C RID: 153676 RVA: 0x00387218 File Offset: 0x00385418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray = InSoftObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = InSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602584D RID: 153677 RVA: 0x00387294 File Offset: 0x00385494
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObject(in TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602584E RID: 153678 RVA: 0x00387304 File Offset: 0x00385504
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<USharpherealTestSimpleClass> InSimpleObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<USharpherealTestSimpleClass> tset = InSimpleObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> tset2 = InSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602584F RID: 153679 RVA: 0x00387380 File Offset: 0x00385580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<USharpherealTestSimpleClass, int> InSimpleObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<USharpherealTestSimpleClass, int> tmap = InSimpleObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> tmap2 = InSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025850 RID: 153680 RVA: 0x003873FC File Offset: 0x003855FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USharpherealTestSimpleClass> InSimpleObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USharpherealTestSimpleClass> tarray = InSimpleObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> tarray2 = InSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025851 RID: 153681 RVA: 0x00387478 File Offset: 0x00385678
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObject(in USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = InSimpleObject;
			ptr2.InSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025852 RID: 153682 RVA: 0x003874D0 File Offset: 0x003856D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<UObject> InObjectSet)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UObject> tset = InObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> tset2 = InObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025853 RID: 153683 RVA: 0x0038754C File Offset: 0x0038574C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSoftObjectPath> InObjectPathSet)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftObjectPath> tset = InObjectPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> tset2 = InObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025854 RID: 153684 RVA: 0x003875C8 File Offset: 0x003857C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSoftObjectPath, int> InObjectPathMap)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftObjectPath, int> tmap = InObjectPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> tmap2 = InObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025855 RID: 153685 RVA: 0x00387644 File Offset: 0x00385844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftObjectPath> InObjectPathArray)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftObjectPath> tarray = InObjectPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> tarray2 = InObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025856 RID: 153686 RVA: 0x003876C0 File Offset: 0x003858C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPath(in FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025857 RID: 153687 RVA: 0x00387738 File Offset: 0x00385938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<UObject, int> InObjectMap)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UObject, int> tmap = InObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> tmap2 = InObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025858 RID: 153688 RVA: 0x003877B4 File Offset: 0x003859B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> InObjectArray)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UObject> tarray = InObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> tarray2 = InObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025859 RID: 153689 RVA: 0x00387830 File Offset: 0x00385A30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObject(in UObject InObject)
		{
			UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = InObject;
			ptr2.InObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602585A RID: 153690 RVA: 0x00387888 File Offset: 0x00385A88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602585B RID: 153691 RVA: 0x003878E8 File Offset: 0x00385AE8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> GetSoftObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x00387948 File Offset: 0x00385B48
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x003879A8 File Offset: 0x00385BA8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSoftObjectPtr<USharpherealTestSimpleClass> GetSoftObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			TSoftObjectPtr<USharpherealTestSimpleClass> result = new TSoftObjectPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602585E RID: 153694 RVA: 0x00387A08 File Offset: 0x00385C08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<USharpherealTestSimpleClass> GetSimpleObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> result = new TSet<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x00387A68 File Offset: 0x00385C68
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<USharpherealTestSimpleClass, int> GetSimpleObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> result = new TMap<USharpherealTestSimpleClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x00387AC8 File Offset: 0x00385CC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<USharpherealTestSimpleClass> GetSimpleObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> result = new TArray<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x00387B28 File Offset: 0x00385D28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USharpherealTestSimpleClass GetSimpleObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->__Result);
		}

		// Token: 0x06025862 RID: 153698 RVA: 0x00387B74 File Offset: 0x00385D74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<UObject> GetObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> result = new TSet<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025863 RID: 153699 RVA: 0x00387BD4 File Offset: 0x00385DD4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSoftObjectPath> GetObjectPathSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> result = new TSet<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025864 RID: 153700 RVA: 0x00387C34 File Offset: 0x00385E34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSoftObjectPath, int> GetObjectPathMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> result = new TMap<FSoftObjectPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025865 RID: 153701 RVA: 0x00387C94 File Offset: 0x00385E94
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSoftObjectPath> GetObjectPathArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> result = new TArray<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025866 RID: 153702 RVA: 0x00387CF4 File Offset: 0x00385EF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSoftObjectPath GetObjectPath()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025867 RID: 153703 RVA: 0x00387D54 File Offset: 0x00385F54
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<UObject, int> GetObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> result = new TMap<UObject, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025868 RID: 153704 RVA: 0x00387DB4 File Offset: 0x00385FB4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<UObject> GetObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> result = new TArray<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025869 RID: 153705 RVA: 0x00387E14 File Offset: 0x00386014
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UObject GetObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0602586A RID: 153706 RVA: 0x00387E5F File Offset: 0x0038605F
		static UTestClass_UFunction_Direct_UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_UObject");
		}

		// Token: 0x0602586B RID: 153707 RVA: 0x00387E6D File Offset: 0x0038606D
		protected UTestClass_UFunction_Direct_UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014523 RID: 83235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_UObject";

		// Token: 0x04014524 RID: 83236
		private static IntPtr _ClassPtr;

		// Token: 0x04014525 RID: 83237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014526 RID: 83238
		internal static int __PropertyOffset_ObjectBase;

		// Token: 0x04014527 RID: 83239
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x04014528 RID: 83240
		internal static int __PropertyOffset_SimpleObjectBase;

		// Token: 0x04014529 RID: 83241
		internal static int __PropertyOffset_SimpleObjectCmp;

		// Token: 0x0401452A RID: 83242
		internal static int __PropertyOffset_WeakObjectBase;

		// Token: 0x0401452B RID: 83243
		internal static int __PropertyOffset_WeakObjectSame;

		// Token: 0x0401452C RID: 83244
		internal static int __PropertyOffset_WeakObjectCmp;

		// Token: 0x0401452D RID: 83245
		internal static int __PropertyOffset_LazyObjectBase;

		// Token: 0x0401452E RID: 83246
		internal static int __PropertyOffset_LazyObjectSame;

		// Token: 0x0401452F RID: 83247
		internal static int __PropertyOffset_LazyObjectCmp;

		// Token: 0x04014530 RID: 83248
		internal static int __PropertyOffset_Object;

		// Token: 0x04014531 RID: 83249
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x04014532 RID: 83250
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x04014533 RID: 83251
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x04014534 RID: 83252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x04014535 RID: 83253
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x04014536 RID: 83254
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x04014537 RID: 83255
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x04014538 RID: 83256
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x04014539 RID: 83257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x0401453A RID: 83258
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x0401453B RID: 83259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x0401453C RID: 83260
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x0401453D RID: 83261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x0401453E RID: 83262
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x0401453F RID: 83263
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x04014540 RID: 83264
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x04014541 RID: 83265
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x04014542 RID: 83266
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x04014543 RID: 83267
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x04014544 RID: 83268
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x04014545 RID: 83269
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04014546 RID: 83270
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x04014547 RID: 83271
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x04014548 RID: 83272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x04014549 RID: 83273
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x0401454A RID: 83274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x0401454B RID: 83275
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x0401454C RID: 83276
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;

		// Token: 0x0401454D RID: 83277
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x0401454E RID: 83278
		private static IntPtr __SetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401454F RID: 83279
		private static IntPtr __SetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04014550 RID: 83280
		private static IntPtr __SetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04014551 RID: 83281
		private static IntPtr __SetSoftObject_NativeFunctionPtr;

		// Token: 0x04014552 RID: 83282
		private static IntPtr __SetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014553 RID: 83283
		private static IntPtr __SetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014554 RID: 83284
		private static IntPtr __SetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014555 RID: 83285
		private static IntPtr __SetSimpleObject_NativeFunctionPtr;

		// Token: 0x04014556 RID: 83286
		private static IntPtr __SetObjectSet_NativeFunctionPtr;

		// Token: 0x04014557 RID: 83287
		private static IntPtr __SetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014558 RID: 83288
		private static IntPtr __SetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014559 RID: 83289
		private static IntPtr __SetObjectPathArray_NativeFunctionPtr;

		// Token: 0x0401455A RID: 83290
		private static IntPtr __SetObjectPath_NativeFunctionPtr;

		// Token: 0x0401455B RID: 83291
		private static IntPtr __SetObjectMap_NativeFunctionPtr;

		// Token: 0x0401455C RID: 83292
		private static IntPtr __SetObjectArray_NativeFunctionPtr;

		// Token: 0x0401455D RID: 83293
		private static IntPtr __SetObject_NativeFunctionPtr;

		// Token: 0x0401455E RID: 83294
		private static IntPtr __OutSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401455F RID: 83295
		private static IntPtr __OutSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04014560 RID: 83296
		private static IntPtr __OutSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04014561 RID: 83297
		private static IntPtr __OutSoftObject_NativeFunctionPtr;

		// Token: 0x04014562 RID: 83298
		private static IntPtr __OutSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014563 RID: 83299
		private static IntPtr __OutSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014564 RID: 83300
		private static IntPtr __OutSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014565 RID: 83301
		private static IntPtr __OutSimpleObject_NativeFunctionPtr;

		// Token: 0x04014566 RID: 83302
		private static IntPtr __OutObjectSet_NativeFunctionPtr;

		// Token: 0x04014567 RID: 83303
		private static IntPtr __OutObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014568 RID: 83304
		private static IntPtr __OutObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014569 RID: 83305
		private static IntPtr __OutObjectPathArray_NativeFunctionPtr;

		// Token: 0x0401456A RID: 83306
		private static IntPtr __OutObjectPath_NativeFunctionPtr;

		// Token: 0x0401456B RID: 83307
		private static IntPtr __OutObjectMap_NativeFunctionPtr;

		// Token: 0x0401456C RID: 83308
		private static IntPtr __OutObjectArray_NativeFunctionPtr;

		// Token: 0x0401456D RID: 83309
		private static IntPtr __OutObject_NativeFunctionPtr;

		// Token: 0x0401456E RID: 83310
		private static IntPtr __InSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401456F RID: 83311
		private static IntPtr __InSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04014570 RID: 83312
		private static IntPtr __InSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04014571 RID: 83313
		private static IntPtr __InSoftObject_NativeFunctionPtr;

		// Token: 0x04014572 RID: 83314
		private static IntPtr __InSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014573 RID: 83315
		private static IntPtr __InSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014574 RID: 83316
		private static IntPtr __InSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014575 RID: 83317
		private static IntPtr __InSimpleObject_NativeFunctionPtr;

		// Token: 0x04014576 RID: 83318
		private static IntPtr __InObjectSet_NativeFunctionPtr;

		// Token: 0x04014577 RID: 83319
		private static IntPtr __InObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014578 RID: 83320
		private static IntPtr __InObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014579 RID: 83321
		private static IntPtr __InObjectPathArray_NativeFunctionPtr;

		// Token: 0x0401457A RID: 83322
		private static IntPtr __InObjectPath_NativeFunctionPtr;

		// Token: 0x0401457B RID: 83323
		private static IntPtr __InObjectMap_NativeFunctionPtr;

		// Token: 0x0401457C RID: 83324
		private static IntPtr __InObjectArray_NativeFunctionPtr;

		// Token: 0x0401457D RID: 83325
		private static IntPtr __InObject_NativeFunctionPtr;

		// Token: 0x0401457E RID: 83326
		private static IntPtr __GetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401457F RID: 83327
		private static IntPtr __GetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04014580 RID: 83328
		private static IntPtr __GetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04014581 RID: 83329
		private static IntPtr __GetSoftObject_NativeFunctionPtr;

		// Token: 0x04014582 RID: 83330
		private static IntPtr __GetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014583 RID: 83331
		private static IntPtr __GetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014584 RID: 83332
		private static IntPtr __GetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014585 RID: 83333
		private static IntPtr __GetSimpleObject_NativeFunctionPtr;

		// Token: 0x04014586 RID: 83334
		private static IntPtr __GetObjectSet_NativeFunctionPtr;

		// Token: 0x04014587 RID: 83335
		private static IntPtr __GetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014588 RID: 83336
		private static IntPtr __GetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014589 RID: 83337
		private static IntPtr __GetObjectPathArray_NativeFunctionPtr;

		// Token: 0x0401458A RID: 83338
		private static IntPtr __GetObjectPath_NativeFunctionPtr;

		// Token: 0x0401458B RID: 83339
		private static IntPtr __GetObjectMap_NativeFunctionPtr;

		// Token: 0x0401458C RID: 83340
		private static IntPtr __GetObjectArray_NativeFunctionPtr;

		// Token: 0x0401458D RID: 83341
		private static IntPtr __GetObject_NativeFunctionPtr;

		// Token: 0x020038FC RID: 14588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x04017A24 RID: 96804
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x04017A25 RID: 96805
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x020038FD RID: 14589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectSet_FunctionParams
		{
			// Token: 0x04017A26 RID: 96806
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x020038FE RID: 14590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectMap_FunctionParams
		{
			// Token: 0x04017A27 RID: 96807
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x020038FF RID: 14591
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftObjectArray_FunctionParams
		{
			// Token: 0x04017A28 RID: 96808
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x02003900 RID: 14592
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftObject_FunctionParams
		{
			// Token: 0x04017A29 RID: 96809
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x02003901 RID: 14593
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017A2A RID: 96810
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x02003902 RID: 14594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017A2B RID: 96811
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x02003903 RID: 14595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017A2C RID: 96812
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x02003904 RID: 14596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSimpleObject_FunctionParams
		{
			// Token: 0x04017A2D RID: 96813
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x02003905 RID: 14597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectSet_FunctionParams
		{
			// Token: 0x04017A2E RID: 96814
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x02003906 RID: 14598
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathSet_FunctionParams
		{
			// Token: 0x04017A2F RID: 96815
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x02003907 RID: 14599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathMap_FunctionParams
		{
			// Token: 0x04017A30 RID: 96816
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x02003908 RID: 14600
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectPathArray_FunctionParams
		{
			// Token: 0x04017A31 RID: 96817
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x02003909 RID: 14601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetObjectPath_FunctionParams
		{
			// Token: 0x04017A32 RID: 96818
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x0200390A RID: 14602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectMap_FunctionParams
		{
			// Token: 0x04017A33 RID: 96819
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x0200390B RID: 14603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectArray_FunctionParams
		{
			// Token: 0x04017A34 RID: 96820
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x0200390C RID: 14604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetObject_FunctionParams
		{
			// Token: 0x04017A35 RID: 96821
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x0200390D RID: 14605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectSet_FunctionParams
		{
			// Token: 0x04017A36 RID: 96822
			[FieldOffset(0)]
			public byte OutSoftObjectSet;
		}

		// Token: 0x0200390E RID: 14606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectMap_FunctionParams
		{
			// Token: 0x04017A37 RID: 96823
			[FieldOffset(0)]
			public byte OutSoftObjectMap;
		}

		// Token: 0x0200390F RID: 14607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftObjectArray_FunctionParams
		{
			// Token: 0x04017A38 RID: 96824
			[FieldOffset(0)]
			public byte OutSoftObjectArray;
		}

		// Token: 0x02003910 RID: 14608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftObject_FunctionParams
		{
			// Token: 0x04017A39 RID: 96825
			[FieldOffset(0)]
			public byte OutSoftObject;
		}

		// Token: 0x02003911 RID: 14609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017A3A RID: 96826
			[FieldOffset(0)]
			public byte OutSimpleObjectSet;
		}

		// Token: 0x02003912 RID: 14610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017A3B RID: 96827
			[FieldOffset(0)]
			public byte OutSimpleObjectMap;
		}

		// Token: 0x02003913 RID: 14611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017A3C RID: 96828
			[FieldOffset(0)]
			public byte OutSimpleObjectArray;
		}

		// Token: 0x02003914 RID: 14612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSimpleObject_FunctionParams
		{
			// Token: 0x04017A3D RID: 96829
			[FieldOffset(0)]
			public IntPtr OutSimpleObject;
		}

		// Token: 0x02003915 RID: 14613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectSet_FunctionParams
		{
			// Token: 0x04017A3E RID: 96830
			[FieldOffset(0)]
			public byte OutObjectSet;
		}

		// Token: 0x02003916 RID: 14614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathSet_FunctionParams
		{
			// Token: 0x04017A3F RID: 96831
			[FieldOffset(0)]
			public byte OutObjectPathSet;
		}

		// Token: 0x02003917 RID: 14615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathMap_FunctionParams
		{
			// Token: 0x04017A40 RID: 96832
			[FieldOffset(0)]
			public byte OutObjectPathMap;
		}

		// Token: 0x02003918 RID: 14616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectPathArray_FunctionParams
		{
			// Token: 0x04017A41 RID: 96833
			[FieldOffset(0)]
			public byte OutObjectPathArray;
		}

		// Token: 0x02003919 RID: 14617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutObjectPath_FunctionParams
		{
			// Token: 0x04017A42 RID: 96834
			[FieldOffset(0)]
			public byte OutObjectPath;
		}

		// Token: 0x0200391A RID: 14618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectMap_FunctionParams
		{
			// Token: 0x04017A43 RID: 96835
			[FieldOffset(0)]
			public byte OutObjectMap;
		}

		// Token: 0x0200391B RID: 14619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectArray_FunctionParams
		{
			// Token: 0x04017A44 RID: 96836
			[FieldOffset(0)]
			public byte OutObjectArray;
		}

		// Token: 0x0200391C RID: 14620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutObject_FunctionParams
		{
			// Token: 0x04017A45 RID: 96837
			[FieldOffset(0)]
			public IntPtr OutObject;
		}

		// Token: 0x0200391D RID: 14621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectSet_FunctionParams
		{
			// Token: 0x04017A46 RID: 96838
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x0200391E RID: 14622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectMap_FunctionParams
		{
			// Token: 0x04017A47 RID: 96839
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x0200391F RID: 14623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftObjectArray_FunctionParams
		{
			// Token: 0x04017A48 RID: 96840
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x02003920 RID: 14624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftObject_FunctionParams
		{
			// Token: 0x04017A49 RID: 96841
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x02003921 RID: 14625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017A4A RID: 96842
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x02003922 RID: 14626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017A4B RID: 96843
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x02003923 RID: 14627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017A4C RID: 96844
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x02003924 RID: 14628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSimpleObject_FunctionParams
		{
			// Token: 0x04017A4D RID: 96845
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x02003925 RID: 14629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectSet_FunctionParams
		{
			// Token: 0x04017A4E RID: 96846
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x02003926 RID: 14630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathSet_FunctionParams
		{
			// Token: 0x04017A4F RID: 96847
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x02003927 RID: 14631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathMap_FunctionParams
		{
			// Token: 0x04017A50 RID: 96848
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x02003928 RID: 14632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectPathArray_FunctionParams
		{
			// Token: 0x04017A51 RID: 96849
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x02003929 RID: 14633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InObjectPath_FunctionParams
		{
			// Token: 0x04017A52 RID: 96850
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x0200392A RID: 14634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectMap_FunctionParams
		{
			// Token: 0x04017A53 RID: 96851
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x0200392B RID: 14635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectArray_FunctionParams
		{
			// Token: 0x04017A54 RID: 96852
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x0200392C RID: 14636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InObject_FunctionParams
		{
			// Token: 0x04017A55 RID: 96853
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x0200392D RID: 14637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectSet_FunctionParams
		{
			// Token: 0x04017A56 RID: 96854
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200392E RID: 14638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectMap_FunctionParams
		{
			// Token: 0x04017A57 RID: 96855
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200392F RID: 14639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftObjectArray_FunctionParams
		{
			// Token: 0x04017A58 RID: 96856
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003930 RID: 14640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftObject_FunctionParams
		{
			// Token: 0x04017A59 RID: 96857
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003931 RID: 14641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017A5A RID: 96858
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003932 RID: 14642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017A5B RID: 96859
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003933 RID: 14643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017A5C RID: 96860
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003934 RID: 14644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSimpleObject_FunctionParams
		{
			// Token: 0x04017A5D RID: 96861
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003935 RID: 14645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectSet_FunctionParams
		{
			// Token: 0x04017A5E RID: 96862
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003936 RID: 14646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathSet_FunctionParams
		{
			// Token: 0x04017A5F RID: 96863
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003937 RID: 14647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathMap_FunctionParams
		{
			// Token: 0x04017A60 RID: 96864
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003938 RID: 14648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectPathArray_FunctionParams
		{
			// Token: 0x04017A61 RID: 96865
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003939 RID: 14649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetObjectPath_FunctionParams
		{
			// Token: 0x04017A62 RID: 96866
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200393A RID: 14650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectMap_FunctionParams
		{
			// Token: 0x04017A63 RID: 96867
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200393B RID: 14651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectArray_FunctionParams
		{
			// Token: 0x04017A64 RID: 96868
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200393C RID: 14652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetObject_FunctionParams
		{
			// Token: 0x04017A65 RID: 96869
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
