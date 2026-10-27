using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002753 RID: 10067
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_UObject")]
	[UnrealStructLayout(992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class UTestClass_UFunction_UObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060259B6 RID: 154038 RVA: 0x0038E21E File Offset: 0x0038C41E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_UObject._ClassPtr;
		}

		// Token: 0x060259B7 RID: 154039 RVA: 0x0038E22C File Offset: 0x0038C42C
		public UTestClass_UFunction_UObject() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060259B8 RID: 154040 RVA: 0x0038E254 File Offset: 0x0038C454
		[NullableContext(1)]
		public UTestClass_UFunction_UObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090F2 RID: 37106
		// (get) Token: 0x060259B9 RID: 154041 RVA: 0x0038E287 File Offset: 0x0038C487
		// (set) Token: 0x060259BA RID: 154042 RVA: 0x0038E29B File Offset: 0x0038C49B
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass ObjectBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_ObjectBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_ObjectBase, value);
			}
		}

		// Token: 0x170090F3 RID: 37107
		// (get) Token: 0x060259BB RID: 154043 RVA: 0x0038E2B0 File Offset: 0x0038C4B0
		// (set) Token: 0x060259BC RID: 154044 RVA: 0x0038E2C4 File Offset: 0x0038C4C4
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass ObjectCmp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_ObjectCmp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_ObjectCmp, value);
			}
		}

		// Token: 0x170090F4 RID: 37108
		// (get) Token: 0x060259BD RID: 154045 RVA: 0x0038E2D9 File Offset: 0x0038C4D9
		// (set) Token: 0x060259BE RID: 154046 RVA: 0x0038E2ED File Offset: 0x0038C4ED
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObjectBase
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectBase);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectBase, value);
			}
		}

		// Token: 0x170090F5 RID: 37109
		// (get) Token: 0x060259BF RID: 154047 RVA: 0x0038E302 File Offset: 0x0038C502
		// (set) Token: 0x060259C0 RID: 154048 RVA: 0x0038E316 File Offset: 0x0038C516
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObjectCmp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectCmp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectCmp, value);
			}
		}

		// Token: 0x170090F6 RID: 37110
		// (get) Token: 0x060259C1 RID: 154049 RVA: 0x0038E32B File Offset: 0x0038C52B
		// (set) Token: 0x060259C2 RID: 154050 RVA: 0x0038E33F File Offset: 0x0038C53F
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectBase);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectBase) = value;
			}
		}

		// Token: 0x170090F7 RID: 37111
		// (get) Token: 0x060259C3 RID: 154051 RVA: 0x0038E354 File Offset: 0x0038C554
		// (set) Token: 0x060259C4 RID: 154052 RVA: 0x0038E368 File Offset: 0x0038C568
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectSame);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectSame) = value;
			}
		}

		// Token: 0x170090F8 RID: 37112
		// (get) Token: 0x060259C5 RID: 154053 RVA: 0x0038E37D File Offset: 0x0038C57D
		// (set) Token: 0x060259C6 RID: 154054 RVA: 0x0038E391 File Offset: 0x0038C591
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectCmp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_WeakObjectCmp) = value;
			}
		}

		// Token: 0x170090F9 RID: 37113
		// (get) Token: 0x060259C7 RID: 154055 RVA: 0x0038E3A6 File Offset: 0x0038C5A6
		// (set) Token: 0x060259C8 RID: 154056 RVA: 0x0038E3BA File Offset: 0x0038C5BA
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectBase);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectBase) = value;
			}
		}

		// Token: 0x170090FA RID: 37114
		// (get) Token: 0x060259C9 RID: 154057 RVA: 0x0038E3CF File Offset: 0x0038C5CF
		// (set) Token: 0x060259CA RID: 154058 RVA: 0x0038E3E3 File Offset: 0x0038C5E3
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectSame);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectSame) = value;
			}
		}

		// Token: 0x170090FB RID: 37115
		// (get) Token: 0x060259CB RID: 154059 RVA: 0x0038E3F8 File Offset: 0x0038C5F8
		// (set) Token: 0x060259CC RID: 154060 RVA: 0x0038E40C File Offset: 0x0038C60C
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectCmp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_LazyObjectCmp) = value;
			}
		}

		// Token: 0x170090FC RID: 37116
		// (get) Token: 0x060259CD RID: 154061 RVA: 0x0038E421 File Offset: 0x0038C621
		// (set) Token: 0x060259CE RID: 154062 RVA: 0x0038E435 File Offset: 0x0038C635
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x170090FD RID: 37117
		// (get) Token: 0x060259CF RID: 154063 RVA: 0x0038E44C File Offset: 0x0038C64C
		// (set) Token: 0x060259D0 RID: 154064 RVA: 0x0038E485 File Offset: 0x0038C685
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
					result = (this._ObjectArray = new TArray<UObject>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170090FE RID: 37118
		// (get) Token: 0x060259D1 RID: 154065 RVA: 0x0038E494 File Offset: 0x0038C694
		// (set) Token: 0x060259D2 RID: 154066 RVA: 0x0038E4CD File Offset: 0x0038C6CD
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
					result = (this._ObjectSet = new TSet<UObject>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x170090FF RID: 37119
		// (get) Token: 0x060259D3 RID: 154067 RVA: 0x0038E4DC File Offset: 0x0038C6DC
		// (set) Token: 0x060259D4 RID: 154068 RVA: 0x0038E515 File Offset: 0x0038C715
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
					result = (this._ObjectMap = new TMap<UObject, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009100 RID: 37120
		// (get) Token: 0x060259D5 RID: 154069 RVA: 0x0038E523 File Offset: 0x0038C723
		// (set) Token: 0x060259D6 RID: 154070 RVA: 0x0038E537 File Offset: 0x0038C737
		[Nullable(2)]
		public unsafe USharpherealTestSimpleClass SimpleObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_UObject.__PropertyOffset_SimpleObject, value);
			}
		}

		// Token: 0x17009101 RID: 37121
		// (get) Token: 0x060259D7 RID: 154071 RVA: 0x0038E54C File Offset: 0x0038C74C
		// (set) Token: 0x060259D8 RID: 154072 RVA: 0x0038E585 File Offset: 0x0038C785
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
					result = (this._SimpleObjectArray = new TArray<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009102 RID: 37122
		// (get) Token: 0x060259D9 RID: 154073 RVA: 0x0038E594 File Offset: 0x0038C794
		// (set) Token: 0x060259DA RID: 154074 RVA: 0x0038E5CD File Offset: 0x0038C7CD
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
					result = (this._SimpleObjectSet = new TSet<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x17009103 RID: 37123
		// (get) Token: 0x060259DB RID: 154075 RVA: 0x0038E5DC File Offset: 0x0038C7DC
		// (set) Token: 0x060259DC RID: 154076 RVA: 0x0038E615 File Offset: 0x0038C815
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
					result = (this._SimpleObjectMap = new TMap<USharpherealTestSimpleClass, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SimpleObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009104 RID: 37124
		// (get) Token: 0x060259DD RID: 154077 RVA: 0x0038E623 File Offset: 0x0038C823
		// (set) Token: 0x060259DE RID: 154078 RVA: 0x0038E638 File Offset: 0x0038C838
		[Nullable(1)]
		public TSoftObjectPtr<USharpherealTestSimpleClass> SoftObject
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SoftObject, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SoftObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17009105 RID: 37125
		// (get) Token: 0x060259DF RID: 154079 RVA: 0x0038E660 File Offset: 0x0038C860
		// (set) Token: 0x060259E0 RID: 154080 RVA: 0x0038E699 File Offset: 0x0038C899
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
					result = (this._SoftObjectArray = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SoftObjectArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x17009106 RID: 37126
		// (get) Token: 0x060259E1 RID: 154081 RVA: 0x0038E6A8 File Offset: 0x0038C8A8
		// (set) Token: 0x060259E2 RID: 154082 RVA: 0x0038E6E1 File Offset: 0x0038C8E1
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
					result = (this._SoftObjectSet = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SoftObjectSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectSet.CopyAssign(value);
			}
		}

		// Token: 0x17009107 RID: 37127
		// (get) Token: 0x060259E3 RID: 154083 RVA: 0x0038E6F0 File Offset: 0x0038C8F0
		// (set) Token: 0x060259E4 RID: 154084 RVA: 0x0038E729 File Offset: 0x0038C929
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
					result = (this._SoftObjectMap = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_SoftObjectMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftObjectMap.CopyAssign(value);
			}
		}

		// Token: 0x17009108 RID: 37128
		// (get) Token: 0x060259E5 RID: 154085 RVA: 0x0038E738 File Offset: 0x0038C938
		// (set) Token: 0x060259E6 RID: 154086 RVA: 0x0038E771 File Offset: 0x0038C971
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
					result = (this._ObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009109 RID: 37129
		// (get) Token: 0x060259E7 RID: 154087 RVA: 0x0038E794 File Offset: 0x0038C994
		// (set) Token: 0x060259E8 RID: 154088 RVA: 0x0038E7CD File Offset: 0x0038C9CD
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
					result = (this._ObjectPathArray = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectPathArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathArray.CopyAssign(value);
			}
		}

		// Token: 0x1700910A RID: 37130
		// (get) Token: 0x060259E9 RID: 154089 RVA: 0x0038E7DC File Offset: 0x0038C9DC
		// (set) Token: 0x060259EA RID: 154090 RVA: 0x0038E815 File Offset: 0x0038CA15
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
					result = (this._ObjectPathSet = new TSet<FSoftObjectPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectPathSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathSet.CopyAssign(value);
			}
		}

		// Token: 0x1700910B RID: 37131
		// (get) Token: 0x060259EB RID: 154091 RVA: 0x0038E824 File Offset: 0x0038CA24
		// (set) Token: 0x060259EC RID: 154092 RVA: 0x0038E85D File Offset: 0x0038CA5D
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
					result = (this._ObjectPathMap = new TMap<FSoftObjectPath, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UObject.__PropertyOffset_ObjectPathMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObjectPathMap.CopyAssign(value);
			}
		}

		// Token: 0x060259ED RID: 154093 RVA: 0x0038E86C File Offset: 0x0038CA6C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSubPathString(ref TSoftObjectPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_UObject._ClassDefaultObjectPtr, UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 0);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259EE RID: 154094 RVA: 0x0038E908 File Offset: 0x0038CB08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectSet)
		{
			UTestClass_UFunction_UObject.__SetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectSet != null)
			{
				InSoftObjectSet.CopyTo(&ptr->InSoftObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259EF RID: 154095 RVA: 0x0038E974 File Offset: 0x0038CB74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> InSoftObjectMap)
		{
			UTestClass_UFunction_UObject.__SetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectMap != null)
			{
				InSoftObjectMap.CopyTo(&ptr->InSoftObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F0 RID: 154096 RVA: 0x0038E9E0 File Offset: 0x0038CBE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectArray)
		{
			UTestClass_UFunction_UObject.__SetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObjectArray != null)
			{
				InSoftObjectArray.CopyTo(&ptr->InSoftObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F1 RID: 154097 RVA: 0x0038EA4C File Offset: 0x0038CC4C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftObject(TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F2 RID: 154098 RVA: 0x0038EABC File Offset: 0x0038CCBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<USharpherealTestSimpleClass> InSimpleObjectSet)
		{
			UTestClass_UFunction_UObject.__SetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectSet != null)
			{
				InSimpleObjectSet.CopyTo(&ptr->InSimpleObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F3 RID: 154099 RVA: 0x0038EB28 File Offset: 0x0038CD28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<USharpherealTestSimpleClass, int> InSimpleObjectMap)
		{
			UTestClass_UFunction_UObject.__SetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectMap != null)
			{
				InSimpleObjectMap.CopyTo(&ptr->InSimpleObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F4 RID: 154100 RVA: 0x0038EB94 File Offset: 0x0038CD94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<USharpherealTestSimpleClass> InSimpleObjectArray)
		{
			UTestClass_UFunction_UObject.__SetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleObjectArray != null)
			{
				InSimpleObjectArray.CopyTo(&ptr->InSimpleObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F5 RID: 154101 RVA: 0x0038EC00 File Offset: 0x0038CE00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleObject(USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSimpleObject = ((InSimpleObject != null) ? InSimpleObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060259F6 RID: 154102 RVA: 0x0038EC58 File Offset: 0x0038CE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<UObject> InObjectSet)
		{
			UTestClass_UFunction_UObject.__SetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectSet != null)
			{
				InObjectSet.CopyTo(&ptr->InObjectSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F7 RID: 154103 RVA: 0x0038ECC4 File Offset: 0x0038CEC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSoftObjectPath> InObjectPathSet)
		{
			UTestClass_UFunction_UObject.__SetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathSet != null)
			{
				InObjectPathSet.CopyTo(&ptr->InObjectPathSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F8 RID: 154104 RVA: 0x0038ED30 File Offset: 0x0038CF30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSoftObjectPath, int> InObjectPathMap)
		{
			UTestClass_UFunction_UObject.__SetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathMap != null)
			{
				InObjectPathMap.CopyTo(&ptr->InObjectPathMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259F9 RID: 154105 RVA: 0x0038ED9C File Offset: 0x0038CF9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSoftObjectPath> InObjectPathArray)
		{
			UTestClass_UFunction_UObject.__SetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPathArray != null)
			{
				InObjectPathArray.CopyTo(&ptr->InObjectPathArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259FA RID: 154106 RVA: 0x0038EE08 File Offset: 0x0038D008
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectPath(FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259FB RID: 154107 RVA: 0x0038EE7C File Offset: 0x0038D07C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<UObject, int> InObjectMap)
		{
			UTestClass_UFunction_UObject.__SetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectMap != null)
			{
				InObjectMap.CopyTo(&ptr->InObjectMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259FC RID: 154108 RVA: 0x0038EEE8 File Offset: 0x0038D0E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<UObject> InObjectArray)
		{
			UTestClass_UFunction_UObject.__SetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectArray != null)
			{
				InObjectArray.CopyTo(&ptr->InObjectArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259FD RID: 154109 RVA: 0x0038EF54 File Offset: 0x0038D154
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetObject(UObject InObject)
		{
			UTestClass_UFunction_UObject.__SetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InObject = ((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060259FE RID: 154110 RVA: 0x0038EFAC File Offset: 0x0038D1AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> OutSoftObjectSet)
		{
			UTestClass_UFunction_UObject.__OutSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset = OutSoftObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = OutSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259FF RID: 154111 RVA: 0x0038F028 File Offset: 0x0038D228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> OutSoftObjectMap)
		{
			UTestClass_UFunction_UObject.__OutSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap = OutSoftObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A00 RID: 154112 RVA: 0x0038F0A4 File Offset: 0x0038D2A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> OutSoftObjectArray)
		{
			UTestClass_UFunction_UObject.__OutSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray = OutSoftObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A01 RID: 154113 RVA: 0x0038F120 File Offset: 0x0038D320
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftObject(ref TSoftObjectPtr<USharpherealTestSimpleClass> OutSoftObject)
		{
			UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftObject, OutSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftObject.NativePtr, &ptr->OutSoftObject, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A02 RID: 154114 RVA: 0x0038F1B0 File Offset: 0x0038D3B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<USharpherealTestSimpleClass> OutSimpleObjectSet)
		{
			UTestClass_UFunction_UObject.__OutSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<USharpherealTestSimpleClass> tset = OutSimpleObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> tset2 = OutSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A03 RID: 154115 RVA: 0x0038F22C File Offset: 0x0038D42C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<USharpherealTestSimpleClass, int> OutSimpleObjectMap)
		{
			UTestClass_UFunction_UObject.__OutSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<USharpherealTestSimpleClass, int> tmap = OutSimpleObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> tmap2 = OutSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A04 RID: 154116 RVA: 0x0038F2A8 File Offset: 0x0038D4A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USharpherealTestSimpleClass> OutSimpleObjectArray)
		{
			UTestClass_UFunction_UObject.__OutSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USharpherealTestSimpleClass> tarray = OutSimpleObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> tarray2 = OutSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A05 RID: 154117 RVA: 0x0038F324 File Offset: 0x0038D524
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleObject(ref USharpherealTestSimpleClass OutSimpleObject)
		{
			UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = OutSimpleObject;
			ptr2.OutSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
			OutSimpleObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->OutSimpleObject);
		}

		// Token: 0x06025A06 RID: 154118 RVA: 0x0038F38C File Offset: 0x0038D58C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UObject> OutObjectSet)
		{
			UTestClass_UFunction_UObject.__OutObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UObject> tset = OutObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> tset2 = OutObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A07 RID: 154119 RVA: 0x0038F408 File Offset: 0x0038D608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSoftObjectPath> OutObjectPathSet)
		{
			UTestClass_UFunction_UObject.__OutObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftObjectPath> tset = OutObjectPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> tset2 = OutObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A08 RID: 154120 RVA: 0x0038F484 File Offset: 0x0038D684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSoftObjectPath, int> OutObjectPathMap)
		{
			UTestClass_UFunction_UObject.__OutObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftObjectPath, int> tmap = OutObjectPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> tmap2 = OutObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A09 RID: 154121 RVA: 0x0038F500 File Offset: 0x0038D700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoftObjectPath> OutObjectPathArray)
		{
			UTestClass_UFunction_UObject.__OutObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftObjectPath> tarray = OutObjectPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> tarray2 = OutObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A0A RID: 154122 RVA: 0x0038F57C File Offset: 0x0038D77C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectPath(ref FSoftObjectPath OutObjectPath)
		{
			UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->OutObjectPath, OutObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), OutObjectPath.NativePtr, &ptr->OutObjectPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A0B RID: 154123 RVA: 0x0038F618 File Offset: 0x0038D818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UObject, int> OutObjectMap)
		{
			UTestClass_UFunction_UObject.__OutObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UObject, int> tmap = OutObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> tmap2 = OutObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A0C RID: 154124 RVA: 0x0038F694 File Offset: 0x0038D894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OutObjectArray)
		{
			UTestClass_UFunction_UObject.__OutObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UObject> tarray = OutObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> tarray2 = OutObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A0D RID: 154125 RVA: 0x0038F710 File Offset: 0x0038D910
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutObject(ref UObject OutObject)
		{
			UTestClass_UFunction_UObject.__OutObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__OutObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = OutObject;
			ptr2.OutObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 0);
			OutObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->OutObject);
		}

		// Token: 0x06025A0E RID: 154126 RVA: 0x0038F778 File Offset: 0x0038D978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectSet)
		{
			UTestClass_UFunction_UObject.__InSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset = InSoftObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = InSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A0F RID: 154127 RVA: 0x0038F7F4 File Offset: 0x0038D9F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> InSoftObjectMap)
		{
			UTestClass_UFunction_UObject.__InSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap = InSoftObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A10 RID: 154128 RVA: 0x0038F870 File Offset: 0x0038DA70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObjectArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> InSoftObjectArray)
		{
			UTestClass_UFunction_UObject.__InSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray = InSoftObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = InSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A11 RID: 154129 RVA: 0x0038F8EC File Offset: 0x0038DAEC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftObject(in TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_UObject.__InSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A12 RID: 154130 RVA: 0x0038F95C File Offset: 0x0038DB5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<USharpherealTestSimpleClass> InSimpleObjectSet)
		{
			UTestClass_UFunction_UObject.__InSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<USharpherealTestSimpleClass> tset = InSimpleObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> tset2 = InSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A13 RID: 154131 RVA: 0x0038F9D8 File Offset: 0x0038DBD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<USharpherealTestSimpleClass, int> InSimpleObjectMap)
		{
			UTestClass_UFunction_UObject.__InSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<USharpherealTestSimpleClass, int> tmap = InSimpleObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> tmap2 = InSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A14 RID: 154132 RVA: 0x0038FA54 File Offset: 0x0038DC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USharpherealTestSimpleClass> InSimpleObjectArray)
		{
			UTestClass_UFunction_UObject.__InSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USharpherealTestSimpleClass> tarray = InSimpleObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> tarray2 = InSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A15 RID: 154133 RVA: 0x0038FAD0 File Offset: 0x0038DCD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleObject(in USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = InSimpleObject;
			ptr2.InSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A16 RID: 154134 RVA: 0x0038FB28 File Offset: 0x0038DD28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<UObject> InObjectSet)
		{
			UTestClass_UFunction_UObject.__InObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UObject> tset = InObjectSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> tset2 = InObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A17 RID: 154135 RVA: 0x0038FBA4 File Offset: 0x0038DDA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSoftObjectPath> InObjectPathSet)
		{
			UTestClass_UFunction_UObject.__InObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftObjectPath> tset = InObjectPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> tset2 = InObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A18 RID: 154136 RVA: 0x0038FC20 File Offset: 0x0038DE20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSoftObjectPath, int> InObjectPathMap)
		{
			UTestClass_UFunction_UObject.__InObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftObjectPath, int> tmap = InObjectPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> tmap2 = InObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A19 RID: 154137 RVA: 0x0038FC9C File Offset: 0x0038DE9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPathArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftObjectPath> InObjectPathArray)
		{
			UTestClass_UFunction_UObject.__InObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftObjectPath> tarray = InObjectPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> tarray2 = InObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A1A RID: 154138 RVA: 0x0038FD18 File Offset: 0x0038DF18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectPath(in FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_UObject.__InObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A1B RID: 154139 RVA: 0x0038FD90 File Offset: 0x0038DF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<UObject, int> InObjectMap)
		{
			UTestClass_UFunction_UObject.__InObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UObject, int> tmap = InObjectMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> tmap2 = InObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A1C RID: 154140 RVA: 0x0038FE0C File Offset: 0x0038E00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObjectArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> InObjectArray)
		{
			UTestClass_UFunction_UObject.__InObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UObject> tarray = InObjectArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> tarray2 = InObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A1D RID: 154141 RVA: 0x0038FE88 File Offset: 0x0038E088
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InObject(in UObject InObject)
		{
			UTestClass_UFunction_UObject.__InObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__InObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = InObject;
			ptr2.InObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A1E RID: 154142 RVA: 0x0038FEE0 File Offset: 0x0038E0E0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectSet()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A1F RID: 154143 RVA: 0x0038FF40 File Offset: 0x0038E140
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> GetSoftObjectMap()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A20 RID: 154144 RVA: 0x0038FFA0 File Offset: 0x0038E1A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectArray()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A21 RID: 154145 RVA: 0x00390000 File Offset: 0x0038E200
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSoftObjectPtr<USharpherealTestSimpleClass> GetSoftObject()
		{
			UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 0);
			TSoftObjectPtr<USharpherealTestSimpleClass> result = new TSoftObjectPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A22 RID: 154146 RVA: 0x00390060 File Offset: 0x0038E260
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<USharpherealTestSimpleClass> GetSimpleObjectSet()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<USharpherealTestSimpleClass> result = new TSet<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A23 RID: 154147 RVA: 0x003900C0 File Offset: 0x0038E2C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<USharpherealTestSimpleClass, int> GetSimpleObjectMap()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<USharpherealTestSimpleClass, int> result = new TMap<USharpherealTestSimpleClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A24 RID: 154148 RVA: 0x00390120 File Offset: 0x0038E320
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<USharpherealTestSimpleClass> GetSimpleObjectArray()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USharpherealTestSimpleClass> result = new TArray<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A25 RID: 154149 RVA: 0x00390180 File Offset: 0x0038E380
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USharpherealTestSimpleClass GetSimpleObject()
		{
			UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->__Result);
		}

		// Token: 0x06025A26 RID: 154150 RVA: 0x003901CC File Offset: 0x0038E3CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<UObject> GetObjectSet()
		{
			UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UObject> result = new TSet<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A27 RID: 154151 RVA: 0x0039022C File Offset: 0x0038E42C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSoftObjectPath> GetObjectPathSet()
		{
			UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftObjectPath> result = new TSet<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A28 RID: 154152 RVA: 0x0039028C File Offset: 0x0038E48C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSoftObjectPath, int> GetObjectPathMap()
		{
			UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftObjectPath, int> result = new TMap<FSoftObjectPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A29 RID: 154153 RVA: 0x003902EC File Offset: 0x0038E4EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSoftObjectPath> GetObjectPathArray()
		{
			UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftObjectPath> result = new TArray<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A2A RID: 154154 RVA: 0x0039034C File Offset: 0x0038E54C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSoftObjectPath GetObjectPath()
		{
			UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A2B RID: 154155 RVA: 0x003903AC File Offset: 0x0038E5AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<UObject, int> GetObjectMap()
		{
			UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UObject, int> result = new TMap<UObject, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A2C RID: 154156 RVA: 0x0039040C File Offset: 0x0038E60C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<UObject> GetObjectArray()
		{
			UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UObject> result = new TArray<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025A2D RID: 154157 RVA: 0x0039046C File Offset: 0x0038E66C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UObject GetObject()
		{
			UTestClass_UFunction_UObject.__GetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x06025A2E RID: 154158 RVA: 0x003904B7 File Offset: 0x0038E6B7
		static UTestClass_UFunction_UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_UObject");
		}

		// Token: 0x06025A2F RID: 154159 RVA: 0x003904C5 File Offset: 0x0038E6C5
		protected UTestClass_UFunction_UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146C0 RID: 83648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_UObject";

		// Token: 0x040146C1 RID: 83649
		private static IntPtr _ClassPtr;

		// Token: 0x040146C2 RID: 83650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146C3 RID: 83651
		internal static int __PropertyOffset_ObjectBase;

		// Token: 0x040146C4 RID: 83652
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x040146C5 RID: 83653
		internal static int __PropertyOffset_SimpleObjectBase;

		// Token: 0x040146C6 RID: 83654
		internal static int __PropertyOffset_SimpleObjectCmp;

		// Token: 0x040146C7 RID: 83655
		internal static int __PropertyOffset_WeakObjectBase;

		// Token: 0x040146C8 RID: 83656
		internal static int __PropertyOffset_WeakObjectSame;

		// Token: 0x040146C9 RID: 83657
		internal static int __PropertyOffset_WeakObjectCmp;

		// Token: 0x040146CA RID: 83658
		internal static int __PropertyOffset_LazyObjectBase;

		// Token: 0x040146CB RID: 83659
		internal static int __PropertyOffset_LazyObjectSame;

		// Token: 0x040146CC RID: 83660
		internal static int __PropertyOffset_LazyObjectCmp;

		// Token: 0x040146CD RID: 83661
		internal static int __PropertyOffset_Object;

		// Token: 0x040146CE RID: 83662
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x040146CF RID: 83663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x040146D0 RID: 83664
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x040146D1 RID: 83665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x040146D2 RID: 83666
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x040146D3 RID: 83667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x040146D4 RID: 83668
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x040146D5 RID: 83669
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x040146D6 RID: 83670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x040146D7 RID: 83671
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x040146D8 RID: 83672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x040146D9 RID: 83673
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x040146DA RID: 83674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x040146DB RID: 83675
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x040146DC RID: 83676
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x040146DD RID: 83677
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x040146DE RID: 83678
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x040146DF RID: 83679
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x040146E0 RID: 83680
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x040146E1 RID: 83681
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x040146E2 RID: 83682
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x040146E3 RID: 83683
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x040146E4 RID: 83684
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x040146E5 RID: 83685
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x040146E6 RID: 83686
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x040146E7 RID: 83687
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x040146E8 RID: 83688
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x040146E9 RID: 83689
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;

		// Token: 0x040146EA RID: 83690
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x040146EB RID: 83691
		private static IntPtr __SetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x040146EC RID: 83692
		private static IntPtr __SetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x040146ED RID: 83693
		private static IntPtr __SetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x040146EE RID: 83694
		private static IntPtr __SetSoftObject_NativeFunctionPtr;

		// Token: 0x040146EF RID: 83695
		private static IntPtr __SetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x040146F0 RID: 83696
		private static IntPtr __SetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x040146F1 RID: 83697
		private static IntPtr __SetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x040146F2 RID: 83698
		private static IntPtr __SetSimpleObject_NativeFunctionPtr;

		// Token: 0x040146F3 RID: 83699
		private static IntPtr __SetObjectSet_NativeFunctionPtr;

		// Token: 0x040146F4 RID: 83700
		private static IntPtr __SetObjectPathSet_NativeFunctionPtr;

		// Token: 0x040146F5 RID: 83701
		private static IntPtr __SetObjectPathMap_NativeFunctionPtr;

		// Token: 0x040146F6 RID: 83702
		private static IntPtr __SetObjectPathArray_NativeFunctionPtr;

		// Token: 0x040146F7 RID: 83703
		private static IntPtr __SetObjectPath_NativeFunctionPtr;

		// Token: 0x040146F8 RID: 83704
		private static IntPtr __SetObjectMap_NativeFunctionPtr;

		// Token: 0x040146F9 RID: 83705
		private static IntPtr __SetObjectArray_NativeFunctionPtr;

		// Token: 0x040146FA RID: 83706
		private static IntPtr __SetObject_NativeFunctionPtr;

		// Token: 0x040146FB RID: 83707
		private static IntPtr __OutSoftObjectSet_NativeFunctionPtr;

		// Token: 0x040146FC RID: 83708
		private static IntPtr __OutSoftObjectMap_NativeFunctionPtr;

		// Token: 0x040146FD RID: 83709
		private static IntPtr __OutSoftObjectArray_NativeFunctionPtr;

		// Token: 0x040146FE RID: 83710
		private static IntPtr __OutSoftObject_NativeFunctionPtr;

		// Token: 0x040146FF RID: 83711
		private static IntPtr __OutSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014700 RID: 83712
		private static IntPtr __OutSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014701 RID: 83713
		private static IntPtr __OutSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014702 RID: 83714
		private static IntPtr __OutSimpleObject_NativeFunctionPtr;

		// Token: 0x04014703 RID: 83715
		private static IntPtr __OutObjectSet_NativeFunctionPtr;

		// Token: 0x04014704 RID: 83716
		private static IntPtr __OutObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014705 RID: 83717
		private static IntPtr __OutObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014706 RID: 83718
		private static IntPtr __OutObjectPathArray_NativeFunctionPtr;

		// Token: 0x04014707 RID: 83719
		private static IntPtr __OutObjectPath_NativeFunctionPtr;

		// Token: 0x04014708 RID: 83720
		private static IntPtr __OutObjectMap_NativeFunctionPtr;

		// Token: 0x04014709 RID: 83721
		private static IntPtr __OutObjectArray_NativeFunctionPtr;

		// Token: 0x0401470A RID: 83722
		private static IntPtr __OutObject_NativeFunctionPtr;

		// Token: 0x0401470B RID: 83723
		private static IntPtr __InSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401470C RID: 83724
		private static IntPtr __InSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0401470D RID: 83725
		private static IntPtr __InSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0401470E RID: 83726
		private static IntPtr __InSoftObject_NativeFunctionPtr;

		// Token: 0x0401470F RID: 83727
		private static IntPtr __InSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014710 RID: 83728
		private static IntPtr __InSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014711 RID: 83729
		private static IntPtr __InSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014712 RID: 83730
		private static IntPtr __InSimpleObject_NativeFunctionPtr;

		// Token: 0x04014713 RID: 83731
		private static IntPtr __InObjectSet_NativeFunctionPtr;

		// Token: 0x04014714 RID: 83732
		private static IntPtr __InObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014715 RID: 83733
		private static IntPtr __InObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014716 RID: 83734
		private static IntPtr __InObjectPathArray_NativeFunctionPtr;

		// Token: 0x04014717 RID: 83735
		private static IntPtr __InObjectPath_NativeFunctionPtr;

		// Token: 0x04014718 RID: 83736
		private static IntPtr __InObjectMap_NativeFunctionPtr;

		// Token: 0x04014719 RID: 83737
		private static IntPtr __InObjectArray_NativeFunctionPtr;

		// Token: 0x0401471A RID: 83738
		private static IntPtr __InObject_NativeFunctionPtr;

		// Token: 0x0401471B RID: 83739
		private static IntPtr __GetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0401471C RID: 83740
		private static IntPtr __GetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0401471D RID: 83741
		private static IntPtr __GetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0401471E RID: 83742
		private static IntPtr __GetSoftObject_NativeFunctionPtr;

		// Token: 0x0401471F RID: 83743
		private static IntPtr __GetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x04014720 RID: 83744
		private static IntPtr __GetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04014721 RID: 83745
		private static IntPtr __GetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04014722 RID: 83746
		private static IntPtr __GetSimpleObject_NativeFunctionPtr;

		// Token: 0x04014723 RID: 83747
		private static IntPtr __GetObjectSet_NativeFunctionPtr;

		// Token: 0x04014724 RID: 83748
		private static IntPtr __GetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04014725 RID: 83749
		private static IntPtr __GetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04014726 RID: 83750
		private static IntPtr __GetObjectPathArray_NativeFunctionPtr;

		// Token: 0x04014727 RID: 83751
		private static IntPtr __GetObjectPath_NativeFunctionPtr;

		// Token: 0x04014728 RID: 83752
		private static IntPtr __GetObjectMap_NativeFunctionPtr;

		// Token: 0x04014729 RID: 83753
		private static IntPtr __GetObjectArray_NativeFunctionPtr;

		// Token: 0x0401472A RID: 83754
		private static IntPtr __GetObject_NativeFunctionPtr;

		// Token: 0x02003A06 RID: 14854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x04017B30 RID: 97072
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x04017B31 RID: 97073
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x02003A07 RID: 14855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectSet_FunctionParams
		{
			// Token: 0x04017B32 RID: 97074
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x02003A08 RID: 14856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectMap_FunctionParams
		{
			// Token: 0x04017B33 RID: 97075
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x02003A09 RID: 14857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftObjectArray_FunctionParams
		{
			// Token: 0x04017B34 RID: 97076
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x02003A0A RID: 14858
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftObject_FunctionParams
		{
			// Token: 0x04017B35 RID: 97077
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x02003A0B RID: 14859
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017B36 RID: 97078
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x02003A0C RID: 14860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017B37 RID: 97079
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x02003A0D RID: 14861
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017B38 RID: 97080
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x02003A0E RID: 14862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSimpleObject_FunctionParams
		{
			// Token: 0x04017B39 RID: 97081
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x02003A0F RID: 14863
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectSet_FunctionParams
		{
			// Token: 0x04017B3A RID: 97082
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x02003A10 RID: 14864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathSet_FunctionParams
		{
			// Token: 0x04017B3B RID: 97083
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x02003A11 RID: 14865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathMap_FunctionParams
		{
			// Token: 0x04017B3C RID: 97084
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x02003A12 RID: 14866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectPathArray_FunctionParams
		{
			// Token: 0x04017B3D RID: 97085
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x02003A13 RID: 14867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetObjectPath_FunctionParams
		{
			// Token: 0x04017B3E RID: 97086
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x02003A14 RID: 14868
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectMap_FunctionParams
		{
			// Token: 0x04017B3F RID: 97087
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x02003A15 RID: 14869
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectArray_FunctionParams
		{
			// Token: 0x04017B40 RID: 97088
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x02003A16 RID: 14870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetObject_FunctionParams
		{
			// Token: 0x04017B41 RID: 97089
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x02003A17 RID: 14871
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectSet_FunctionParams
		{
			// Token: 0x04017B42 RID: 97090
			[FieldOffset(0)]
			public byte OutSoftObjectSet;
		}

		// Token: 0x02003A18 RID: 14872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectMap_FunctionParams
		{
			// Token: 0x04017B43 RID: 97091
			[FieldOffset(0)]
			public byte OutSoftObjectMap;
		}

		// Token: 0x02003A19 RID: 14873
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftObjectArray_FunctionParams
		{
			// Token: 0x04017B44 RID: 97092
			[FieldOffset(0)]
			public byte OutSoftObjectArray;
		}

		// Token: 0x02003A1A RID: 14874
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftObject_FunctionParams
		{
			// Token: 0x04017B45 RID: 97093
			[FieldOffset(0)]
			public byte OutSoftObject;
		}

		// Token: 0x02003A1B RID: 14875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017B46 RID: 97094
			[FieldOffset(0)]
			public byte OutSimpleObjectSet;
		}

		// Token: 0x02003A1C RID: 14876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017B47 RID: 97095
			[FieldOffset(0)]
			public byte OutSimpleObjectMap;
		}

		// Token: 0x02003A1D RID: 14877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017B48 RID: 97096
			[FieldOffset(0)]
			public byte OutSimpleObjectArray;
		}

		// Token: 0x02003A1E RID: 14878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSimpleObject_FunctionParams
		{
			// Token: 0x04017B49 RID: 97097
			[FieldOffset(0)]
			public IntPtr OutSimpleObject;
		}

		// Token: 0x02003A1F RID: 14879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectSet_FunctionParams
		{
			// Token: 0x04017B4A RID: 97098
			[FieldOffset(0)]
			public byte OutObjectSet;
		}

		// Token: 0x02003A20 RID: 14880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathSet_FunctionParams
		{
			// Token: 0x04017B4B RID: 97099
			[FieldOffset(0)]
			public byte OutObjectPathSet;
		}

		// Token: 0x02003A21 RID: 14881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathMap_FunctionParams
		{
			// Token: 0x04017B4C RID: 97100
			[FieldOffset(0)]
			public byte OutObjectPathMap;
		}

		// Token: 0x02003A22 RID: 14882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectPathArray_FunctionParams
		{
			// Token: 0x04017B4D RID: 97101
			[FieldOffset(0)]
			public byte OutObjectPathArray;
		}

		// Token: 0x02003A23 RID: 14883
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutObjectPath_FunctionParams
		{
			// Token: 0x04017B4E RID: 97102
			[FieldOffset(0)]
			public byte OutObjectPath;
		}

		// Token: 0x02003A24 RID: 14884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectMap_FunctionParams
		{
			// Token: 0x04017B4F RID: 97103
			[FieldOffset(0)]
			public byte OutObjectMap;
		}

		// Token: 0x02003A25 RID: 14885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectArray_FunctionParams
		{
			// Token: 0x04017B50 RID: 97104
			[FieldOffset(0)]
			public byte OutObjectArray;
		}

		// Token: 0x02003A26 RID: 14886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutObject_FunctionParams
		{
			// Token: 0x04017B51 RID: 97105
			[FieldOffset(0)]
			public IntPtr OutObject;
		}

		// Token: 0x02003A27 RID: 14887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectSet_FunctionParams
		{
			// Token: 0x04017B52 RID: 97106
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x02003A28 RID: 14888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectMap_FunctionParams
		{
			// Token: 0x04017B53 RID: 97107
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x02003A29 RID: 14889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftObjectArray_FunctionParams
		{
			// Token: 0x04017B54 RID: 97108
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x02003A2A RID: 14890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftObject_FunctionParams
		{
			// Token: 0x04017B55 RID: 97109
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x02003A2B RID: 14891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017B56 RID: 97110
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x02003A2C RID: 14892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017B57 RID: 97111
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x02003A2D RID: 14893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017B58 RID: 97112
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x02003A2E RID: 14894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSimpleObject_FunctionParams
		{
			// Token: 0x04017B59 RID: 97113
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x02003A2F RID: 14895
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectSet_FunctionParams
		{
			// Token: 0x04017B5A RID: 97114
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x02003A30 RID: 14896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathSet_FunctionParams
		{
			// Token: 0x04017B5B RID: 97115
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x02003A31 RID: 14897
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathMap_FunctionParams
		{
			// Token: 0x04017B5C RID: 97116
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x02003A32 RID: 14898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectPathArray_FunctionParams
		{
			// Token: 0x04017B5D RID: 97117
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x02003A33 RID: 14899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InObjectPath_FunctionParams
		{
			// Token: 0x04017B5E RID: 97118
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x02003A34 RID: 14900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectMap_FunctionParams
		{
			// Token: 0x04017B5F RID: 97119
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x02003A35 RID: 14901
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectArray_FunctionParams
		{
			// Token: 0x04017B60 RID: 97120
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x02003A36 RID: 14902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InObject_FunctionParams
		{
			// Token: 0x04017B61 RID: 97121
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x02003A37 RID: 14903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectSet_FunctionParams
		{
			// Token: 0x04017B62 RID: 97122
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A38 RID: 14904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectMap_FunctionParams
		{
			// Token: 0x04017B63 RID: 97123
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A39 RID: 14905
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftObjectArray_FunctionParams
		{
			// Token: 0x04017B64 RID: 97124
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A3A RID: 14906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftObject_FunctionParams
		{
			// Token: 0x04017B65 RID: 97125
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A3B RID: 14907
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectSet_FunctionParams
		{
			// Token: 0x04017B66 RID: 97126
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A3C RID: 14908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectMap_FunctionParams
		{
			// Token: 0x04017B67 RID: 97127
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A3D RID: 14909
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleObjectArray_FunctionParams
		{
			// Token: 0x04017B68 RID: 97128
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A3E RID: 14910
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSimpleObject_FunctionParams
		{
			// Token: 0x04017B69 RID: 97129
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003A3F RID: 14911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectSet_FunctionParams
		{
			// Token: 0x04017B6A RID: 97130
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A40 RID: 14912
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathSet_FunctionParams
		{
			// Token: 0x04017B6B RID: 97131
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A41 RID: 14913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathMap_FunctionParams
		{
			// Token: 0x04017B6C RID: 97132
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A42 RID: 14914
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectPathArray_FunctionParams
		{
			// Token: 0x04017B6D RID: 97133
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A43 RID: 14915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetObjectPath_FunctionParams
		{
			// Token: 0x04017B6E RID: 97134
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A44 RID: 14916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectMap_FunctionParams
		{
			// Token: 0x04017B6F RID: 97135
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A45 RID: 14917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectArray_FunctionParams
		{
			// Token: 0x04017B70 RID: 97136
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A46 RID: 14918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetObject_FunctionParams
		{
			// Token: 0x04017B71 RID: 97137
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
