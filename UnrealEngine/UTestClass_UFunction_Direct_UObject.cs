using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000801 RID: 2049
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_UObject")]
	[UnrealStructLayout(992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class UTestClass_UFunction_Direct_UObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B2CF RID: 45775 RVA: 0x001151ED File Offset: 0x001133ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_UObject._ClassPtr;
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x001151FC File Offset: 0x001133FC
		public UTestClass_UFunction_Direct_UObject() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x00115224 File Offset: 0x00113424
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_UObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x00115257 File Offset: 0x00113457
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x0011526B File Offset: 0x0011346B
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

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x00115280 File Offset: 0x00113480
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x00115294 File Offset: 0x00113494
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

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x001152A9 File Offset: 0x001134A9
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x001152BD File Offset: 0x001134BD
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

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x001152D2 File Offset: 0x001134D2
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x001152E6 File Offset: 0x001134E6
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

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x001152FB File Offset: 0x001134FB
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x0011530F File Offset: 0x0011350F
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

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x00115324 File Offset: 0x00113524
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x00115338 File Offset: 0x00113538
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

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x0011534D File Offset: 0x0011354D
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x00115361 File Offset: 0x00113561
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

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x0600B2E0 RID: 45792 RVA: 0x00115376 File Offset: 0x00113576
		// (set) Token: 0x0600B2E1 RID: 45793 RVA: 0x0011538A File Offset: 0x0011358A
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

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x0011539F File Offset: 0x0011359F
		// (set) Token: 0x0600B2E3 RID: 45795 RVA: 0x001153B3 File Offset: 0x001135B3
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

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x0600B2E4 RID: 45796 RVA: 0x001153C8 File Offset: 0x001135C8
		// (set) Token: 0x0600B2E5 RID: 45797 RVA: 0x001153DC File Offset: 0x001135DC
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

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x001153F1 File Offset: 0x001135F1
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x00115405 File Offset: 0x00113605
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

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x0011541C File Offset: 0x0011361C
		// (set) Token: 0x0600B2E9 RID: 45801 RVA: 0x00115455 File Offset: 0x00113655
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

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x00115464 File Offset: 0x00113664
		// (set) Token: 0x0600B2EB RID: 45803 RVA: 0x0011549D File Offset: 0x0011369D
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

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600B2EC RID: 45804 RVA: 0x001154AC File Offset: 0x001136AC
		// (set) Token: 0x0600B2ED RID: 45805 RVA: 0x001154E5 File Offset: 0x001136E5
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

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x001154F3 File Offset: 0x001136F3
		// (set) Token: 0x0600B2EF RID: 45807 RVA: 0x00115507 File Offset: 0x00113707
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

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600B2F0 RID: 45808 RVA: 0x0011551C File Offset: 0x0011371C
		// (set) Token: 0x0600B2F1 RID: 45809 RVA: 0x00115555 File Offset: 0x00113755
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

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x00115564 File Offset: 0x00113764
		// (set) Token: 0x0600B2F3 RID: 45811 RVA: 0x0011559D File Offset: 0x0011379D
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

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x001155AC File Offset: 0x001137AC
		// (set) Token: 0x0600B2F5 RID: 45813 RVA: 0x001155E5 File Offset: 0x001137E5
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

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x001155F3 File Offset: 0x001137F3
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x00115608 File Offset: 0x00113808
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

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x0600B2F8 RID: 45816 RVA: 0x00115630 File Offset: 0x00113830
		// (set) Token: 0x0600B2F9 RID: 45817 RVA: 0x00115669 File Offset: 0x00113869
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

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x0600B2FA RID: 45818 RVA: 0x00115678 File Offset: 0x00113878
		// (set) Token: 0x0600B2FB RID: 45819 RVA: 0x001156B1 File Offset: 0x001138B1
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

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x001156C0 File Offset: 0x001138C0
		// (set) Token: 0x0600B2FD RID: 45821 RVA: 0x001156F9 File Offset: 0x001138F9
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

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x00115708 File Offset: 0x00113908
		// (set) Token: 0x0600B2FF RID: 45823 RVA: 0x00115741 File Offset: 0x00113941
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

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x00115764 File Offset: 0x00113964
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x0011579D File Offset: 0x0011399D
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

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x001157AC File Offset: 0x001139AC
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x001157E5 File Offset: 0x001139E5
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

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x001157F4 File Offset: 0x001139F4
		// (set) Token: 0x0600B305 RID: 45829 RVA: 0x0011582D File Offset: 0x00113A2D
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

		// Token: 0x0600B306 RID: 45830 RVA: 0x0011583C File Offset: 0x00113A3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSubPathString(ref TSoftObjectPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_Direct_UObject._ClassDefaultObjectPtr, UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x001158D4 File Offset: 0x00113AD4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x00115940 File Offset: 0x00113B40
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x001159AC File Offset: 0x00113BAC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x00115A18 File Offset: 0x00113C18
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void SetSoftObject(TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x00115A84 File Offset: 0x00113C84
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x00115AF0 File Offset: 0x00113CF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x00115B5C File Offset: 0x00113D5C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x00115BC8 File Offset: 0x00113DC8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetSimpleObject(USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSimpleObject = ((InSimpleObject != null) ? InSimpleObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x00115C20 File Offset: 0x00113E20
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x00115C8C File Offset: 0x00113E8C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x00115CF8 File Offset: 0x00113EF8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x00115D64 File Offset: 0x00113F64
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x00115DD0 File Offset: 0x00113FD0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetObjectPath(FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x00115E44 File Offset: 0x00114044
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x00115EB0 File Offset: 0x001140B0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x00115F1C File Offset: 0x0011411C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetObject(UObject InObject)
		{
			UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__SetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InObject = ((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__SetObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x00115F74 File Offset: 0x00114174
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = OutSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x00115FEC File Offset: 0x001141EC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x00116064 File Offset: 0x00114264
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x001160DC File Offset: 0x001142DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void OutSoftObject(ref TSoftObjectPtr<USharpherealTestSimpleClass> OutSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftObject, OutSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftObject.NativePtr, &ptr->OutSoftObject, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x00116168 File Offset: 0x00114368
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> tset2 = OutSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x001161E0 File Offset: 0x001143E0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> tmap2 = OutSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x00116258 File Offset: 0x00114458
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> tarray2 = OutSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x001162D0 File Offset: 0x001144D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutSimpleObject(ref USharpherealTestSimpleClass OutSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__OutSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = OutSimpleObject;
			ptr2.OutSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr);
			OutSimpleObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->OutSimpleObject);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x00116334 File Offset: 0x00114534
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> tset2 = OutObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x001163AC File Offset: 0x001145AC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> tset2 = OutObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x00116424 File Offset: 0x00114624
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> tmap2 = OutObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x0011649C File Offset: 0x0011469C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> tarray2 = OutObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x00116514 File Offset: 0x00114714
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutObjectPath(ref FSoftObjectPath OutObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->OutObjectPath, OutObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), OutObjectPath.NativePtr, &ptr->OutObjectPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x001165AC File Offset: 0x001147AC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> tmap2 = OutObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x00116624 File Offset: 0x00114824
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> tarray2 = OutObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x0011669C File Offset: 0x0011489C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutObject(ref UObject OutObject)
		{
			UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__OutObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = OutObject;
			ptr2.OutObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__OutObject_NativeFunctionPtr, (void*)ptr);
			OutObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->OutObject);
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x00116700 File Offset: 0x00114900
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = InSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x00116778 File Offset: 0x00114978
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x001167F0 File Offset: 0x001149F0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = InSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x00116868 File Offset: 0x00114A68
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void InSoftObject(in TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x001168D8 File Offset: 0x00114AD8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> tset2 = InSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x00116950 File Offset: 0x00114B50
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> tmap2 = InSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B32D RID: 45869 RVA: 0x001169C8 File Offset: 0x00114BC8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> tarray2 = InSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x00116A40 File Offset: 0x00114C40
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InSimpleObject(in USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__InSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = InSimpleObject;
			ptr2.InSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x00116A98 File Offset: 0x00114C98
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> tset2 = InObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x00116B10 File Offset: 0x00114D10
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> tset2 = InObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x00116B88 File Offset: 0x00114D88
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> tmap2 = InObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x00116C00 File Offset: 0x00114E00
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> tarray2 = InObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x00116C78 File Offset: 0x00114E78
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InObjectPath(in FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x00116CEC File Offset: 0x00114EEC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> tmap2 = InObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x00116D64 File Offset: 0x00114F64
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> tarray2 = InObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x00116DDC File Offset: 0x00114FDC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InObject(in UObject InObject)
		{
			UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_UObject.__InObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = InObject;
			ptr2.InObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__InObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x00116E34 File Offset: 0x00115034
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x00116E94 File Offset: 0x00115094
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> GetSoftObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x00116EF4 File Offset: 0x001150F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x00116F54 File Offset: 0x00115154
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSoftObjectPtr<USharpherealTestSimpleClass> GetSoftObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr);
			TSoftObjectPtr<USharpherealTestSimpleClass> result = new TSoftObjectPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x00116FB4 File Offset: 0x001151B4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<USharpherealTestSimpleClass> GetSimpleObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> result = new TSet<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x00117014 File Offset: 0x00115214
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<USharpherealTestSimpleClass, int> GetSimpleObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> result = new TMap<USharpherealTestSimpleClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x00117074 File Offset: 0x00115274
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<USharpherealTestSimpleClass> GetSimpleObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> result = new TArray<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x001170D4 File Offset: 0x001152D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USharpherealTestSimpleClass GetSimpleObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->__Result);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x00117120 File Offset: 0x00115320
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<UObject> GetObjectSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> result = new TSet<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x00117180 File Offset: 0x00115380
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSoftObjectPath> GetObjectPathSet()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> result = new TSet<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x001171E0 File Offset: 0x001153E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSoftObjectPath, int> GetObjectPathMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> result = new TMap<FSoftObjectPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x00117240 File Offset: 0x00115440
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSoftObjectPath> GetObjectPathArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> result = new TArray<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x001172A0 File Offset: 0x001154A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSoftObjectPath GetObjectPath()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x00117300 File Offset: 0x00115500
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<UObject, int> GetObjectMap()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> result = new TMap<UObject, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x00117360 File Offset: 0x00115560
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<UObject> GetObjectArray()
		{
			UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> result = new TArray<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x001173C0 File Offset: 0x001155C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UObject GetObject()
		{
			UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UObject.__GetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UObject.__GetObject_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0600B347 RID: 45895 RVA: 0x0011740A File Offset: 0x0011560A
		static UTestClass_UFunction_Direct_UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_UObject");
		}

		// Token: 0x0600B348 RID: 45896 RVA: 0x00117418 File Offset: 0x00115618
		protected UTestClass_UFunction_Direct_UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004F82 RID: 20354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_UObject";

		// Token: 0x04004F83 RID: 20355
		private static IntPtr _ClassPtr;

		// Token: 0x04004F84 RID: 20356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004F85 RID: 20357
		internal static int __PropertyOffset_ObjectBase;

		// Token: 0x04004F86 RID: 20358
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x04004F87 RID: 20359
		internal static int __PropertyOffset_SimpleObjectBase;

		// Token: 0x04004F88 RID: 20360
		internal static int __PropertyOffset_SimpleObjectCmp;

		// Token: 0x04004F89 RID: 20361
		internal static int __PropertyOffset_WeakObjectBase;

		// Token: 0x04004F8A RID: 20362
		internal static int __PropertyOffset_WeakObjectSame;

		// Token: 0x04004F8B RID: 20363
		internal static int __PropertyOffset_WeakObjectCmp;

		// Token: 0x04004F8C RID: 20364
		internal static int __PropertyOffset_LazyObjectBase;

		// Token: 0x04004F8D RID: 20365
		internal static int __PropertyOffset_LazyObjectSame;

		// Token: 0x04004F8E RID: 20366
		internal static int __PropertyOffset_LazyObjectCmp;

		// Token: 0x04004F8F RID: 20367
		internal static int __PropertyOffset_Object;

		// Token: 0x04004F90 RID: 20368
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x04004F91 RID: 20369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x04004F92 RID: 20370
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x04004F93 RID: 20371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x04004F94 RID: 20372
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x04004F95 RID: 20373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x04004F96 RID: 20374
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x04004F97 RID: 20375
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x04004F98 RID: 20376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x04004F99 RID: 20377
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x04004F9A RID: 20378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x04004F9B RID: 20379
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x04004F9C RID: 20380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x04004F9D RID: 20381
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x04004F9E RID: 20382
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x04004F9F RID: 20383
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x04004FA0 RID: 20384
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x04004FA1 RID: 20385
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x04004FA2 RID: 20386
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x04004FA3 RID: 20387
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x04004FA4 RID: 20388
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04004FA5 RID: 20389
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x04004FA6 RID: 20390
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x04004FA7 RID: 20391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x04004FA8 RID: 20392
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x04004FA9 RID: 20393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x04004FAA RID: 20394
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x04004FAB RID: 20395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;

		// Token: 0x04004FAC RID: 20396
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x04004FAD RID: 20397
		private static IntPtr __SetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x04004FAE RID: 20398
		private static IntPtr __SetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04004FAF RID: 20399
		private static IntPtr __SetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04004FB0 RID: 20400
		private static IntPtr __SetSoftObject_NativeFunctionPtr;

		// Token: 0x04004FB1 RID: 20401
		private static IntPtr __SetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04004FB2 RID: 20402
		private static IntPtr __SetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04004FB3 RID: 20403
		private static IntPtr __SetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04004FB4 RID: 20404
		private static IntPtr __SetSimpleObject_NativeFunctionPtr;

		// Token: 0x04004FB5 RID: 20405
		private static IntPtr __SetObjectSet_NativeFunctionPtr;

		// Token: 0x04004FB6 RID: 20406
		private static IntPtr __SetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04004FB7 RID: 20407
		private static IntPtr __SetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04004FB8 RID: 20408
		private static IntPtr __SetObjectPathArray_NativeFunctionPtr;

		// Token: 0x04004FB9 RID: 20409
		private static IntPtr __SetObjectPath_NativeFunctionPtr;

		// Token: 0x04004FBA RID: 20410
		private static IntPtr __SetObjectMap_NativeFunctionPtr;

		// Token: 0x04004FBB RID: 20411
		private static IntPtr __SetObjectArray_NativeFunctionPtr;

		// Token: 0x04004FBC RID: 20412
		private static IntPtr __SetObject_NativeFunctionPtr;

		// Token: 0x04004FBD RID: 20413
		private static IntPtr __OutSoftObjectSet_NativeFunctionPtr;

		// Token: 0x04004FBE RID: 20414
		private static IntPtr __OutSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04004FBF RID: 20415
		private static IntPtr __OutSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04004FC0 RID: 20416
		private static IntPtr __OutSoftObject_NativeFunctionPtr;

		// Token: 0x04004FC1 RID: 20417
		private static IntPtr __OutSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04004FC2 RID: 20418
		private static IntPtr __OutSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04004FC3 RID: 20419
		private static IntPtr __OutSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04004FC4 RID: 20420
		private static IntPtr __OutSimpleObject_NativeFunctionPtr;

		// Token: 0x04004FC5 RID: 20421
		private static IntPtr __OutObjectSet_NativeFunctionPtr;

		// Token: 0x04004FC6 RID: 20422
		private static IntPtr __OutObjectPathSet_NativeFunctionPtr;

		// Token: 0x04004FC7 RID: 20423
		private static IntPtr __OutObjectPathMap_NativeFunctionPtr;

		// Token: 0x04004FC8 RID: 20424
		private static IntPtr __OutObjectPathArray_NativeFunctionPtr;

		// Token: 0x04004FC9 RID: 20425
		private static IntPtr __OutObjectPath_NativeFunctionPtr;

		// Token: 0x04004FCA RID: 20426
		private static IntPtr __OutObjectMap_NativeFunctionPtr;

		// Token: 0x04004FCB RID: 20427
		private static IntPtr __OutObjectArray_NativeFunctionPtr;

		// Token: 0x04004FCC RID: 20428
		private static IntPtr __OutObject_NativeFunctionPtr;

		// Token: 0x04004FCD RID: 20429
		private static IntPtr __InSoftObjectSet_NativeFunctionPtr;

		// Token: 0x04004FCE RID: 20430
		private static IntPtr __InSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04004FCF RID: 20431
		private static IntPtr __InSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04004FD0 RID: 20432
		private static IntPtr __InSoftObject_NativeFunctionPtr;

		// Token: 0x04004FD1 RID: 20433
		private static IntPtr __InSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04004FD2 RID: 20434
		private static IntPtr __InSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04004FD3 RID: 20435
		private static IntPtr __InSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04004FD4 RID: 20436
		private static IntPtr __InSimpleObject_NativeFunctionPtr;

		// Token: 0x04004FD5 RID: 20437
		private static IntPtr __InObjectSet_NativeFunctionPtr;

		// Token: 0x04004FD6 RID: 20438
		private static IntPtr __InObjectPathSet_NativeFunctionPtr;

		// Token: 0x04004FD7 RID: 20439
		private static IntPtr __InObjectPathMap_NativeFunctionPtr;

		// Token: 0x04004FD8 RID: 20440
		private static IntPtr __InObjectPathArray_NativeFunctionPtr;

		// Token: 0x04004FD9 RID: 20441
		private static IntPtr __InObjectPath_NativeFunctionPtr;

		// Token: 0x04004FDA RID: 20442
		private static IntPtr __InObjectMap_NativeFunctionPtr;

		// Token: 0x04004FDB RID: 20443
		private static IntPtr __InObjectArray_NativeFunctionPtr;

		// Token: 0x04004FDC RID: 20444
		private static IntPtr __InObject_NativeFunctionPtr;

		// Token: 0x04004FDD RID: 20445
		private static IntPtr __GetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x04004FDE RID: 20446
		private static IntPtr __GetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x04004FDF RID: 20447
		private static IntPtr __GetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x04004FE0 RID: 20448
		private static IntPtr __GetSoftObject_NativeFunctionPtr;

		// Token: 0x04004FE1 RID: 20449
		private static IntPtr __GetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04004FE2 RID: 20450
		private static IntPtr __GetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04004FE3 RID: 20451
		private static IntPtr __GetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04004FE4 RID: 20452
		private static IntPtr __GetSimpleObject_NativeFunctionPtr;

		// Token: 0x04004FE5 RID: 20453
		private static IntPtr __GetObjectSet_NativeFunctionPtr;

		// Token: 0x04004FE6 RID: 20454
		private static IntPtr __GetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04004FE7 RID: 20455
		private static IntPtr __GetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04004FE8 RID: 20456
		private static IntPtr __GetObjectPathArray_NativeFunctionPtr;

		// Token: 0x04004FE9 RID: 20457
		private static IntPtr __GetObjectPath_NativeFunctionPtr;

		// Token: 0x04004FEA RID: 20458
		private static IntPtr __GetObjectMap_NativeFunctionPtr;

		// Token: 0x04004FEB RID: 20459
		private static IntPtr __GetObjectArray_NativeFunctionPtr;

		// Token: 0x04004FEC RID: 20460
		private static IntPtr __GetObject_NativeFunctionPtr;

		// Token: 0x020011CE RID: 4558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x040065D7 RID: 26071
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x040065D8 RID: 26072
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x020011CF RID: 4559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectSet_FunctionParams
		{
			// Token: 0x040065D9 RID: 26073
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x020011D0 RID: 4560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectMap_FunctionParams
		{
			// Token: 0x040065DA RID: 26074
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x020011D1 RID: 4561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftObjectArray_FunctionParams
		{
			// Token: 0x040065DB RID: 26075
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x020011D2 RID: 4562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftObject_FunctionParams
		{
			// Token: 0x040065DC RID: 26076
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x020011D3 RID: 4563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectSet_FunctionParams
		{
			// Token: 0x040065DD RID: 26077
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x020011D4 RID: 4564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectMap_FunctionParams
		{
			// Token: 0x040065DE RID: 26078
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x020011D5 RID: 4565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleObjectArray_FunctionParams
		{
			// Token: 0x040065DF RID: 26079
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x020011D6 RID: 4566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSimpleObject_FunctionParams
		{
			// Token: 0x040065E0 RID: 26080
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x020011D7 RID: 4567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectSet_FunctionParams
		{
			// Token: 0x040065E1 RID: 26081
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x020011D8 RID: 4568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathSet_FunctionParams
		{
			// Token: 0x040065E2 RID: 26082
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x020011D9 RID: 4569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathMap_FunctionParams
		{
			// Token: 0x040065E3 RID: 26083
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x020011DA RID: 4570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectPathArray_FunctionParams
		{
			// Token: 0x040065E4 RID: 26084
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x020011DB RID: 4571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetObjectPath_FunctionParams
		{
			// Token: 0x040065E5 RID: 26085
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x020011DC RID: 4572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectMap_FunctionParams
		{
			// Token: 0x040065E6 RID: 26086
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x020011DD RID: 4573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectArray_FunctionParams
		{
			// Token: 0x040065E7 RID: 26087
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x020011DE RID: 4574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetObject_FunctionParams
		{
			// Token: 0x040065E8 RID: 26088
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x020011DF RID: 4575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectSet_FunctionParams
		{
			// Token: 0x040065E9 RID: 26089
			[FieldOffset(0)]
			public byte OutSoftObjectSet;
		}

		// Token: 0x020011E0 RID: 4576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectMap_FunctionParams
		{
			// Token: 0x040065EA RID: 26090
			[FieldOffset(0)]
			public byte OutSoftObjectMap;
		}

		// Token: 0x020011E1 RID: 4577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftObjectArray_FunctionParams
		{
			// Token: 0x040065EB RID: 26091
			[FieldOffset(0)]
			public byte OutSoftObjectArray;
		}

		// Token: 0x020011E2 RID: 4578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftObject_FunctionParams
		{
			// Token: 0x040065EC RID: 26092
			[FieldOffset(0)]
			public byte OutSoftObject;
		}

		// Token: 0x020011E3 RID: 4579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectSet_FunctionParams
		{
			// Token: 0x040065ED RID: 26093
			[FieldOffset(0)]
			public byte OutSimpleObjectSet;
		}

		// Token: 0x020011E4 RID: 4580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectMap_FunctionParams
		{
			// Token: 0x040065EE RID: 26094
			[FieldOffset(0)]
			public byte OutSimpleObjectMap;
		}

		// Token: 0x020011E5 RID: 4581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleObjectArray_FunctionParams
		{
			// Token: 0x040065EF RID: 26095
			[FieldOffset(0)]
			public byte OutSimpleObjectArray;
		}

		// Token: 0x020011E6 RID: 4582
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSimpleObject_FunctionParams
		{
			// Token: 0x040065F0 RID: 26096
			[FieldOffset(0)]
			public IntPtr OutSimpleObject;
		}

		// Token: 0x020011E7 RID: 4583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectSet_FunctionParams
		{
			// Token: 0x040065F1 RID: 26097
			[FieldOffset(0)]
			public byte OutObjectSet;
		}

		// Token: 0x020011E8 RID: 4584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathSet_FunctionParams
		{
			// Token: 0x040065F2 RID: 26098
			[FieldOffset(0)]
			public byte OutObjectPathSet;
		}

		// Token: 0x020011E9 RID: 4585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathMap_FunctionParams
		{
			// Token: 0x040065F3 RID: 26099
			[FieldOffset(0)]
			public byte OutObjectPathMap;
		}

		// Token: 0x020011EA RID: 4586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectPathArray_FunctionParams
		{
			// Token: 0x040065F4 RID: 26100
			[FieldOffset(0)]
			public byte OutObjectPathArray;
		}

		// Token: 0x020011EB RID: 4587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutObjectPath_FunctionParams
		{
			// Token: 0x040065F5 RID: 26101
			[FieldOffset(0)]
			public byte OutObjectPath;
		}

		// Token: 0x020011EC RID: 4588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectMap_FunctionParams
		{
			// Token: 0x040065F6 RID: 26102
			[FieldOffset(0)]
			public byte OutObjectMap;
		}

		// Token: 0x020011ED RID: 4589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectArray_FunctionParams
		{
			// Token: 0x040065F7 RID: 26103
			[FieldOffset(0)]
			public byte OutObjectArray;
		}

		// Token: 0x020011EE RID: 4590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutObject_FunctionParams
		{
			// Token: 0x040065F8 RID: 26104
			[FieldOffset(0)]
			public IntPtr OutObject;
		}

		// Token: 0x020011EF RID: 4591
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectSet_FunctionParams
		{
			// Token: 0x040065F9 RID: 26105
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x020011F0 RID: 4592
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectMap_FunctionParams
		{
			// Token: 0x040065FA RID: 26106
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x020011F1 RID: 4593
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftObjectArray_FunctionParams
		{
			// Token: 0x040065FB RID: 26107
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x020011F2 RID: 4594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftObject_FunctionParams
		{
			// Token: 0x040065FC RID: 26108
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x020011F3 RID: 4595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectSet_FunctionParams
		{
			// Token: 0x040065FD RID: 26109
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x020011F4 RID: 4596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectMap_FunctionParams
		{
			// Token: 0x040065FE RID: 26110
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x020011F5 RID: 4597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleObjectArray_FunctionParams
		{
			// Token: 0x040065FF RID: 26111
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x020011F6 RID: 4598
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSimpleObject_FunctionParams
		{
			// Token: 0x04006600 RID: 26112
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x020011F7 RID: 4599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectSet_FunctionParams
		{
			// Token: 0x04006601 RID: 26113
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x020011F8 RID: 4600
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathSet_FunctionParams
		{
			// Token: 0x04006602 RID: 26114
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x020011F9 RID: 4601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathMap_FunctionParams
		{
			// Token: 0x04006603 RID: 26115
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x020011FA RID: 4602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectPathArray_FunctionParams
		{
			// Token: 0x04006604 RID: 26116
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x020011FB RID: 4603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InObjectPath_FunctionParams
		{
			// Token: 0x04006605 RID: 26117
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x020011FC RID: 4604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectMap_FunctionParams
		{
			// Token: 0x04006606 RID: 26118
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x020011FD RID: 4605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectArray_FunctionParams
		{
			// Token: 0x04006607 RID: 26119
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x020011FE RID: 4606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InObject_FunctionParams
		{
			// Token: 0x04006608 RID: 26120
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x020011FF RID: 4607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectSet_FunctionParams
		{
			// Token: 0x04006609 RID: 26121
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001200 RID: 4608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectMap_FunctionParams
		{
			// Token: 0x0400660A RID: 26122
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001201 RID: 4609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftObjectArray_FunctionParams
		{
			// Token: 0x0400660B RID: 26123
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001202 RID: 4610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftObject_FunctionParams
		{
			// Token: 0x0400660C RID: 26124
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001203 RID: 4611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectSet_FunctionParams
		{
			// Token: 0x0400660D RID: 26125
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001204 RID: 4612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectMap_FunctionParams
		{
			// Token: 0x0400660E RID: 26126
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001205 RID: 4613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleObjectArray_FunctionParams
		{
			// Token: 0x0400660F RID: 26127
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001206 RID: 4614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSimpleObject_FunctionParams
		{
			// Token: 0x04006610 RID: 26128
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001207 RID: 4615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectSet_FunctionParams
		{
			// Token: 0x04006611 RID: 26129
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001208 RID: 4616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathSet_FunctionParams
		{
			// Token: 0x04006612 RID: 26130
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001209 RID: 4617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathMap_FunctionParams
		{
			// Token: 0x04006613 RID: 26131
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200120A RID: 4618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectPathArray_FunctionParams
		{
			// Token: 0x04006614 RID: 26132
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200120B RID: 4619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetObjectPath_FunctionParams
		{
			// Token: 0x04006615 RID: 26133
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200120C RID: 4620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectMap_FunctionParams
		{
			// Token: 0x04006616 RID: 26134
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200120D RID: 4621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectArray_FunctionParams
		{
			// Token: 0x04006617 RID: 26135
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200120E RID: 4622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetObject_FunctionParams
		{
			// Token: 0x04006618 RID: 26136
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
