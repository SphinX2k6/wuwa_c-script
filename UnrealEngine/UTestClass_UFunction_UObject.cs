using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000807 RID: 2055
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_UObject")]
	[UnrealStructLayout(992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 992)]
	public class UTestClass_UFunction_UObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B493 RID: 46227 RVA: 0x0011D679 File Offset: 0x0011B879
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_UObject._ClassPtr;
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x0011D688 File Offset: 0x0011B888
		public UTestClass_UFunction_UObject() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x0011D6B0 File Offset: 0x0011B8B0
		[NullableContext(1)]
		public UTestClass_UFunction_UObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600B496 RID: 46230 RVA: 0x0011D6E3 File Offset: 0x0011B8E3
		// (set) Token: 0x0600B497 RID: 46231 RVA: 0x0011D6F7 File Offset: 0x0011B8F7
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

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x0600B498 RID: 46232 RVA: 0x0011D70C File Offset: 0x0011B90C
		// (set) Token: 0x0600B499 RID: 46233 RVA: 0x0011D720 File Offset: 0x0011B920
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

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x0011D735 File Offset: 0x0011B935
		// (set) Token: 0x0600B49B RID: 46235 RVA: 0x0011D749 File Offset: 0x0011B949
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

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600B49C RID: 46236 RVA: 0x0011D75E File Offset: 0x0011B95E
		// (set) Token: 0x0600B49D RID: 46237 RVA: 0x0011D772 File Offset: 0x0011B972
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

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600B49E RID: 46238 RVA: 0x0011D787 File Offset: 0x0011B987
		// (set) Token: 0x0600B49F RID: 46239 RVA: 0x0011D79B File Offset: 0x0011B99B
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

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600B4A0 RID: 46240 RVA: 0x0011D7B0 File Offset: 0x0011B9B0
		// (set) Token: 0x0600B4A1 RID: 46241 RVA: 0x0011D7C4 File Offset: 0x0011B9C4
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

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x0011D7D9 File Offset: 0x0011B9D9
		// (set) Token: 0x0600B4A3 RID: 46243 RVA: 0x0011D7ED File Offset: 0x0011B9ED
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

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x0011D802 File Offset: 0x0011BA02
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x0011D816 File Offset: 0x0011BA16
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

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x0011D82B File Offset: 0x0011BA2B
		// (set) Token: 0x0600B4A7 RID: 46247 RVA: 0x0011D83F File Offset: 0x0011BA3F
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

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x0011D854 File Offset: 0x0011BA54
		// (set) Token: 0x0600B4A9 RID: 46249 RVA: 0x0011D868 File Offset: 0x0011BA68
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

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600B4AA RID: 46250 RVA: 0x0011D87D File Offset: 0x0011BA7D
		// (set) Token: 0x0600B4AB RID: 46251 RVA: 0x0011D891 File Offset: 0x0011BA91
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

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600B4AC RID: 46252 RVA: 0x0011D8A8 File Offset: 0x0011BAA8
		// (set) Token: 0x0600B4AD RID: 46253 RVA: 0x0011D8E1 File Offset: 0x0011BAE1
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

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x0600B4AE RID: 46254 RVA: 0x0011D8F0 File Offset: 0x0011BAF0
		// (set) Token: 0x0600B4AF RID: 46255 RVA: 0x0011D929 File Offset: 0x0011BB29
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

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x0600B4B0 RID: 46256 RVA: 0x0011D938 File Offset: 0x0011BB38
		// (set) Token: 0x0600B4B1 RID: 46257 RVA: 0x0011D971 File Offset: 0x0011BB71
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

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x0011D97F File Offset: 0x0011BB7F
		// (set) Token: 0x0600B4B3 RID: 46259 RVA: 0x0011D993 File Offset: 0x0011BB93
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

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600B4B4 RID: 46260 RVA: 0x0011D9A8 File Offset: 0x0011BBA8
		// (set) Token: 0x0600B4B5 RID: 46261 RVA: 0x0011D9E1 File Offset: 0x0011BBE1
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

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x0011D9F0 File Offset: 0x0011BBF0
		// (set) Token: 0x0600B4B7 RID: 46263 RVA: 0x0011DA29 File Offset: 0x0011BC29
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

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600B4B8 RID: 46264 RVA: 0x0011DA38 File Offset: 0x0011BC38
		// (set) Token: 0x0600B4B9 RID: 46265 RVA: 0x0011DA71 File Offset: 0x0011BC71
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

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600B4BA RID: 46266 RVA: 0x0011DA7F File Offset: 0x0011BC7F
		// (set) Token: 0x0600B4BB RID: 46267 RVA: 0x0011DA94 File Offset: 0x0011BC94
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

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x0011DABC File Offset: 0x0011BCBC
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x0011DAF5 File Offset: 0x0011BCF5
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

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x0011DB04 File Offset: 0x0011BD04
		// (set) Token: 0x0600B4BF RID: 46271 RVA: 0x0011DB3D File Offset: 0x0011BD3D
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

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600B4C0 RID: 46272 RVA: 0x0011DB4C File Offset: 0x0011BD4C
		// (set) Token: 0x0600B4C1 RID: 46273 RVA: 0x0011DB85 File Offset: 0x0011BD85
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

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x0600B4C2 RID: 46274 RVA: 0x0011DB94 File Offset: 0x0011BD94
		// (set) Token: 0x0600B4C3 RID: 46275 RVA: 0x0011DBCD File Offset: 0x0011BDCD
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

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600B4C4 RID: 46276 RVA: 0x0011DBF0 File Offset: 0x0011BDF0
		// (set) Token: 0x0600B4C5 RID: 46277 RVA: 0x0011DC29 File Offset: 0x0011BE29
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

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600B4C6 RID: 46278 RVA: 0x0011DC38 File Offset: 0x0011BE38
		// (set) Token: 0x0600B4C7 RID: 46279 RVA: 0x0011DC71 File Offset: 0x0011BE71
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

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x0011DC80 File Offset: 0x0011BE80
		// (set) Token: 0x0600B4C9 RID: 46281 RVA: 0x0011DCB9 File Offset: 0x0011BEB9
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

		// Token: 0x0600B4CA RID: 46282 RVA: 0x0011DCC8 File Offset: 0x0011BEC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSubPathString(ref TSoftObjectPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_UObject._ClassDefaultObjectPtr, UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x0011DD60 File Offset: 0x0011BF60
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4CC RID: 46284 RVA: 0x0011DDCC File Offset: 0x0011BFCC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4CD RID: 46285 RVA: 0x0011DE38 File Offset: 0x0011C038
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x0011DEA4 File Offset: 0x0011C0A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void SetSoftObject(TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x0011DF10 File Offset: 0x0011C110
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x0011DF7C File Offset: 0x0011C17C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x0011E054 File Offset: 0x0011C254
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetSimpleObject(USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSimpleObject = ((InSimpleObject != null) ? InSimpleObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetSimpleObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x0011E0AC File Offset: 0x0011C2AC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x0011E118 File Offset: 0x0011C318
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x0011E184 File Offset: 0x0011C384
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x0011E1F0 File Offset: 0x0011C3F0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x0011E25C File Offset: 0x0011C45C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetObjectPath(FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x0011E2D0 File Offset: 0x0011C4D0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x0011E33C File Offset: 0x0011C53C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__SetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x0011E3A8 File Offset: 0x0011C5A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetObject(UObject InObject)
		{
			UTestClass_UFunction_UObject.__SetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__SetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__SetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__SetObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InObject = ((InObject != null) ? InObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__SetObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x0011E400 File Offset: 0x0011C600
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = OutSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x0011E478 File Offset: 0x0011C678
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x0011E4F0 File Offset: 0x0011C6F0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x0011E568 File Offset: 0x0011C768
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void OutSoftObject(ref TSoftObjectPtr<USharpherealTestSimpleClass> OutSoftObject)
		{
			UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftObject, OutSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr);
			if (OutSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftObject.NativePtr, &ptr->OutSoftObject, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x0011E5F4 File Offset: 0x0011C7F4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> tset2 = OutSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x0011E66C File Offset: 0x0011C86C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> tmap2 = OutSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x0011E6E4 File Offset: 0x0011C8E4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> tarray2 = OutSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x0011E75C File Offset: 0x0011C95C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutSimpleObject(ref USharpherealTestSimpleClass OutSimpleObject)
		{
			UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__OutSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = OutSimpleObject;
			ptr2.OutSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutSimpleObject_NativeFunctionPtr, (void*)ptr);
			OutSimpleObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->OutSimpleObject);
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x0011E7C0 File Offset: 0x0011C9C0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> tset2 = OutObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x0011E838 File Offset: 0x0011CA38
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> tset2 = OutObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x0011E8B0 File Offset: 0x0011CAB0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> tmap2 = OutObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x0011E928 File Offset: 0x0011CB28
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> tarray2 = OutObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x0011E9A0 File Offset: 0x0011CBA0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutObjectPath(ref FSoftObjectPath OutObjectPath)
		{
			UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->OutObjectPath, OutObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr);
			if (OutObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), OutObjectPath.NativePtr, &ptr->OutObjectPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x0011EA38 File Offset: 0x0011CC38
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> tmap2 = OutObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x0011EAB0 File Offset: 0x0011CCB0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> tarray2 = OutObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__OutObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x0011EB28 File Offset: 0x0011CD28
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutObject(ref UObject OutObject)
		{
			UTestClass_UFunction_UObject.__OutObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__OutObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__OutObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__OutObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__OutObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = OutObject;
			ptr2.OutObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__OutObject_NativeFunctionPtr, (void*)ptr);
			OutObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->OutObject);
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x0011EB8C File Offset: 0x0011CD8C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> tset2 = InSoftObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x0011EC04 File Offset: 0x0011CE04
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x0011EC7C File Offset: 0x0011CE7C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> tarray2 = InSoftObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x0011ECF4 File Offset: 0x0011CEF4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void InSoftObject(in TSoftObjectPtr<USharpherealTestSimpleClass> InSoftObject)
		{
			UTestClass_UFunction_UObject.__InSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftObject != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftObject, InSoftObject.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSoftObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x0011ED64 File Offset: 0x0011CF64
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> tset2 = InSimpleObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x0011EDDC File Offset: 0x0011CFDC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> tmap2 = InSimpleObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x0011EE54 File Offset: 0x0011D054
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> tarray2 = InSimpleObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x0011EECC File Offset: 0x0011D0CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InSimpleObject(in USharpherealTestSimpleClass InSimpleObject)
		{
			UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__InSimpleObject_FunctionParams ptr2 = ref *ptr;
			USharpherealTestSimpleClass usharpherealTestSimpleClass = InSimpleObject;
			ptr2.InSimpleObject = ((usharpherealTestSimpleClass != null) ? usharpherealTestSimpleClass.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InSimpleObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x0011EF24 File Offset: 0x0011D124
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> tset2 = InObjectSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x0011EF9C File Offset: 0x0011D19C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> tset2 = InObjectPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InObjectPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x0011F014 File Offset: 0x0011D214
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> tmap2 = InObjectPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x0011F08C File Offset: 0x0011D28C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> tarray2 = InObjectPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x0011F104 File Offset: 0x0011D304
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InObjectPath(in FSoftObjectPath InObjectPath)
		{
			UTestClass_UFunction_UObject.__InObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InObjectPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), &ptr->InObjectPath, InObjectPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x0011F178 File Offset: 0x0011D378
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> tmap2 = InObjectMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InObjectMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x0011F1F0 File Offset: 0x0011D3F0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> tarray2 = InObjectArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InObjectArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__InObjectArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B4FA RID: 46330 RVA: 0x0011F268 File Offset: 0x0011D468
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InObject(in UObject InObject)
		{
			UTestClass_UFunction_UObject.__InObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__InObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__InObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__InObject_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_UObject.__InObject_FunctionParams ptr2 = ref *ptr;
			UObject uobject = InObject;
			ptr2.InObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__InObject_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x0011F2C0 File Offset: 0x0011D4C0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectSet()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x0011F320 File Offset: 0x0011D520
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> GetSoftObjectMap()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x0011F380 File Offset: 0x0011D580
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> GetSoftObjectArray()
		{
			UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftObjectPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x0011F3E0 File Offset: 0x0011D5E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSoftObjectPtr<USharpherealTestSimpleClass> GetSoftObject()
		{
			UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSoftObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr);
			TSoftObjectPtr<USharpherealTestSimpleClass> result = new TSoftObjectPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSoftObject_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x0011F440 File Offset: 0x0011D640
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<USharpherealTestSimpleClass> GetSimpleObjectSet()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<USharpherealTestSimpleClass> result = new TSet<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x0011F4A0 File Offset: 0x0011D6A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<USharpherealTestSimpleClass, int> GetSimpleObjectMap()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<USharpherealTestSimpleClass, int> result = new TMap<USharpherealTestSimpleClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x0011F500 File Offset: 0x0011D700
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<USharpherealTestSimpleClass> GetSimpleObjectArray()
		{
			UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<USharpherealTestSimpleClass> result = new TArray<USharpherealTestSimpleClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetSimpleObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x0011F560 File Offset: 0x0011D760
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USharpherealTestSimpleClass GetSimpleObject()
		{
			UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetSimpleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetSimpleObject_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USharpherealTestSimpleClass>(ptr->__Result);
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x0011F5AC File Offset: 0x0011D7AC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<UObject> GetObjectSet()
		{
			UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr);
			TSet<UObject> result = new TSet<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x0011F60C File Offset: 0x0011D80C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSoftObjectPath> GetObjectPathSet()
		{
			UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftObjectPath> result = new TSet<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x0011F66C File Offset: 0x0011D86C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSoftObjectPath, int> GetObjectPathMap()
		{
			UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftObjectPath, int> result = new TMap<FSoftObjectPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x0011F6CC File Offset: 0x0011D8CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSoftObjectPath> GetObjectPathArray()
		{
			UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftObjectPath> result = new TArray<FSoftObjectPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x0011F72C File Offset: 0x0011D92C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSoftObjectPath GetObjectPath()
		{
			UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x0011F78C File Offset: 0x0011D98C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<UObject, int> GetObjectMap()
		{
			UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr);
			TMap<UObject, int> result = new TMap<UObject, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x0011F7EC File Offset: 0x0011D9EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<UObject> GetObjectArray()
		{
			UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObjectArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> result = new TArray<UObject>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UObject.__GetObjectArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x0011F84C File Offset: 0x0011DA4C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UObject GetObject()
		{
			UTestClass_UFunction_UObject.__GetObject_FunctionParams* ptr = stackalloc UTestClass_UFunction_UObject.__GetObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UObject.__GetObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UObject.__GetObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UObject.__GetObject_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x0011F896 File Offset: 0x0011DA96
		static UTestClass_UFunction_UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_UObject");
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x0011F8A4 File Offset: 0x0011DAA4
		protected UTestClass_UFunction_UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400511F RID: 20767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_UObject";

		// Token: 0x04005120 RID: 20768
		private static IntPtr _ClassPtr;

		// Token: 0x04005121 RID: 20769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005122 RID: 20770
		internal static int __PropertyOffset_ObjectBase;

		// Token: 0x04005123 RID: 20771
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x04005124 RID: 20772
		internal static int __PropertyOffset_SimpleObjectBase;

		// Token: 0x04005125 RID: 20773
		internal static int __PropertyOffset_SimpleObjectCmp;

		// Token: 0x04005126 RID: 20774
		internal static int __PropertyOffset_WeakObjectBase;

		// Token: 0x04005127 RID: 20775
		internal static int __PropertyOffset_WeakObjectSame;

		// Token: 0x04005128 RID: 20776
		internal static int __PropertyOffset_WeakObjectCmp;

		// Token: 0x04005129 RID: 20777
		internal static int __PropertyOffset_LazyObjectBase;

		// Token: 0x0400512A RID: 20778
		internal static int __PropertyOffset_LazyObjectSame;

		// Token: 0x0400512B RID: 20779
		internal static int __PropertyOffset_LazyObjectCmp;

		// Token: 0x0400512C RID: 20780
		internal static int __PropertyOffset_Object;

		// Token: 0x0400512D RID: 20781
		internal static int __PropertyOffset_ObjectArray;

		// Token: 0x0400512E RID: 20782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectArray;

		// Token: 0x0400512F RID: 20783
		internal static int __PropertyOffset_ObjectSet;

		// Token: 0x04005130 RID: 20784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ObjectSet;

		// Token: 0x04005131 RID: 20785
		internal static int __PropertyOffset_ObjectMap;

		// Token: 0x04005132 RID: 20786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _ObjectMap;

		// Token: 0x04005133 RID: 20787
		internal static int __PropertyOffset_SimpleObject;

		// Token: 0x04005134 RID: 20788
		internal static int __PropertyOffset_SimpleObjectArray;

		// Token: 0x04005135 RID: 20789
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USharpherealTestSimpleClass> _SimpleObjectArray;

		// Token: 0x04005136 RID: 20790
		internal static int __PropertyOffset_SimpleObjectSet;

		// Token: 0x04005137 RID: 20791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USharpherealTestSimpleClass> _SimpleObjectSet;

		// Token: 0x04005138 RID: 20792
		internal static int __PropertyOffset_SimpleObjectMap;

		// Token: 0x04005139 RID: 20793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USharpherealTestSimpleClass, int> _SimpleObjectMap;

		// Token: 0x0400513A RID: 20794
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x0400513B RID: 20795
		internal static int __PropertyOffset_SoftObjectArray;

		// Token: 0x0400513C RID: 20796
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectArray;

		// Token: 0x0400513D RID: 20797
		internal static int __PropertyOffset_SoftObjectSet;

		// Token: 0x0400513E RID: 20798
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<USharpherealTestSimpleClass>> _SoftObjectSet;

		// Token: 0x0400513F RID: 20799
		internal static int __PropertyOffset_SoftObjectMap;

		// Token: 0x04005140 RID: 20800
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<USharpherealTestSimpleClass>, int> _SoftObjectMap;

		// Token: 0x04005141 RID: 20801
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04005142 RID: 20802
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;

		// Token: 0x04005143 RID: 20803
		internal static int __PropertyOffset_ObjectPathArray;

		// Token: 0x04005144 RID: 20804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _ObjectPathArray;

		// Token: 0x04005145 RID: 20805
		internal static int __PropertyOffset_ObjectPathSet;

		// Token: 0x04005146 RID: 20806
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ObjectPathSet;

		// Token: 0x04005147 RID: 20807
		internal static int __PropertyOffset_ObjectPathMap;

		// Token: 0x04005148 RID: 20808
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftObjectPath, int> _ObjectPathMap;

		// Token: 0x04005149 RID: 20809
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x0400514A RID: 20810
		private static IntPtr __SetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0400514B RID: 20811
		private static IntPtr __SetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0400514C RID: 20812
		private static IntPtr __SetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0400514D RID: 20813
		private static IntPtr __SetSoftObject_NativeFunctionPtr;

		// Token: 0x0400514E RID: 20814
		private static IntPtr __SetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x0400514F RID: 20815
		private static IntPtr __SetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04005150 RID: 20816
		private static IntPtr __SetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04005151 RID: 20817
		private static IntPtr __SetSimpleObject_NativeFunctionPtr;

		// Token: 0x04005152 RID: 20818
		private static IntPtr __SetObjectSet_NativeFunctionPtr;

		// Token: 0x04005153 RID: 20819
		private static IntPtr __SetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04005154 RID: 20820
		private static IntPtr __SetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04005155 RID: 20821
		private static IntPtr __SetObjectPathArray_NativeFunctionPtr;

		// Token: 0x04005156 RID: 20822
		private static IntPtr __SetObjectPath_NativeFunctionPtr;

		// Token: 0x04005157 RID: 20823
		private static IntPtr __SetObjectMap_NativeFunctionPtr;

		// Token: 0x04005158 RID: 20824
		private static IntPtr __SetObjectArray_NativeFunctionPtr;

		// Token: 0x04005159 RID: 20825
		private static IntPtr __SetObject_NativeFunctionPtr;

		// Token: 0x0400515A RID: 20826
		private static IntPtr __OutSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0400515B RID: 20827
		private static IntPtr __OutSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0400515C RID: 20828
		private static IntPtr __OutSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0400515D RID: 20829
		private static IntPtr __OutSoftObject_NativeFunctionPtr;

		// Token: 0x0400515E RID: 20830
		private static IntPtr __OutSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x0400515F RID: 20831
		private static IntPtr __OutSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04005160 RID: 20832
		private static IntPtr __OutSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04005161 RID: 20833
		private static IntPtr __OutSimpleObject_NativeFunctionPtr;

		// Token: 0x04005162 RID: 20834
		private static IntPtr __OutObjectSet_NativeFunctionPtr;

		// Token: 0x04005163 RID: 20835
		private static IntPtr __OutObjectPathSet_NativeFunctionPtr;

		// Token: 0x04005164 RID: 20836
		private static IntPtr __OutObjectPathMap_NativeFunctionPtr;

		// Token: 0x04005165 RID: 20837
		private static IntPtr __OutObjectPathArray_NativeFunctionPtr;

		// Token: 0x04005166 RID: 20838
		private static IntPtr __OutObjectPath_NativeFunctionPtr;

		// Token: 0x04005167 RID: 20839
		private static IntPtr __OutObjectMap_NativeFunctionPtr;

		// Token: 0x04005168 RID: 20840
		private static IntPtr __OutObjectArray_NativeFunctionPtr;

		// Token: 0x04005169 RID: 20841
		private static IntPtr __OutObject_NativeFunctionPtr;

		// Token: 0x0400516A RID: 20842
		private static IntPtr __InSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0400516B RID: 20843
		private static IntPtr __InSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0400516C RID: 20844
		private static IntPtr __InSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0400516D RID: 20845
		private static IntPtr __InSoftObject_NativeFunctionPtr;

		// Token: 0x0400516E RID: 20846
		private static IntPtr __InSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x0400516F RID: 20847
		private static IntPtr __InSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04005170 RID: 20848
		private static IntPtr __InSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04005171 RID: 20849
		private static IntPtr __InSimpleObject_NativeFunctionPtr;

		// Token: 0x04005172 RID: 20850
		private static IntPtr __InObjectSet_NativeFunctionPtr;

		// Token: 0x04005173 RID: 20851
		private static IntPtr __InObjectPathSet_NativeFunctionPtr;

		// Token: 0x04005174 RID: 20852
		private static IntPtr __InObjectPathMap_NativeFunctionPtr;

		// Token: 0x04005175 RID: 20853
		private static IntPtr __InObjectPathArray_NativeFunctionPtr;

		// Token: 0x04005176 RID: 20854
		private static IntPtr __InObjectPath_NativeFunctionPtr;

		// Token: 0x04005177 RID: 20855
		private static IntPtr __InObjectMap_NativeFunctionPtr;

		// Token: 0x04005178 RID: 20856
		private static IntPtr __InObjectArray_NativeFunctionPtr;

		// Token: 0x04005179 RID: 20857
		private static IntPtr __InObject_NativeFunctionPtr;

		// Token: 0x0400517A RID: 20858
		private static IntPtr __GetSoftObjectSet_NativeFunctionPtr;

		// Token: 0x0400517B RID: 20859
		private static IntPtr __GetSoftObjectMap_NativeFunctionPtr;

		// Token: 0x0400517C RID: 20860
		private static IntPtr __GetSoftObjectArray_NativeFunctionPtr;

		// Token: 0x0400517D RID: 20861
		private static IntPtr __GetSoftObject_NativeFunctionPtr;

		// Token: 0x0400517E RID: 20862
		private static IntPtr __GetSimpleObjectSet_NativeFunctionPtr;

		// Token: 0x0400517F RID: 20863
		private static IntPtr __GetSimpleObjectMap_NativeFunctionPtr;

		// Token: 0x04005180 RID: 20864
		private static IntPtr __GetSimpleObjectArray_NativeFunctionPtr;

		// Token: 0x04005181 RID: 20865
		private static IntPtr __GetSimpleObject_NativeFunctionPtr;

		// Token: 0x04005182 RID: 20866
		private static IntPtr __GetObjectSet_NativeFunctionPtr;

		// Token: 0x04005183 RID: 20867
		private static IntPtr __GetObjectPathSet_NativeFunctionPtr;

		// Token: 0x04005184 RID: 20868
		private static IntPtr __GetObjectPathMap_NativeFunctionPtr;

		// Token: 0x04005185 RID: 20869
		private static IntPtr __GetObjectPathArray_NativeFunctionPtr;

		// Token: 0x04005186 RID: 20870
		private static IntPtr __GetObjectPath_NativeFunctionPtr;

		// Token: 0x04005187 RID: 20871
		private static IntPtr __GetObjectMap_NativeFunctionPtr;

		// Token: 0x04005188 RID: 20872
		private static IntPtr __GetObjectArray_NativeFunctionPtr;

		// Token: 0x04005189 RID: 20873
		private static IntPtr __GetObject_NativeFunctionPtr;

		// Token: 0x020012D8 RID: 4824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x040066E3 RID: 26339
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x040066E4 RID: 26340
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x020012D9 RID: 4825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectSet_FunctionParams
		{
			// Token: 0x040066E5 RID: 26341
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x020012DA RID: 4826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftObjectMap_FunctionParams
		{
			// Token: 0x040066E6 RID: 26342
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x020012DB RID: 4827
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftObjectArray_FunctionParams
		{
			// Token: 0x040066E7 RID: 26343
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x020012DC RID: 4828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftObject_FunctionParams
		{
			// Token: 0x040066E8 RID: 26344
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x020012DD RID: 4829
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectSet_FunctionParams
		{
			// Token: 0x040066E9 RID: 26345
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x020012DE RID: 4830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleObjectMap_FunctionParams
		{
			// Token: 0x040066EA RID: 26346
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x020012DF RID: 4831
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleObjectArray_FunctionParams
		{
			// Token: 0x040066EB RID: 26347
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x020012E0 RID: 4832
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSimpleObject_FunctionParams
		{
			// Token: 0x040066EC RID: 26348
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x020012E1 RID: 4833
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectSet_FunctionParams
		{
			// Token: 0x040066ED RID: 26349
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x020012E2 RID: 4834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathSet_FunctionParams
		{
			// Token: 0x040066EE RID: 26350
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x020012E3 RID: 4835
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectPathMap_FunctionParams
		{
			// Token: 0x040066EF RID: 26351
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x020012E4 RID: 4836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectPathArray_FunctionParams
		{
			// Token: 0x040066F0 RID: 26352
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x020012E5 RID: 4837
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetObjectPath_FunctionParams
		{
			// Token: 0x040066F1 RID: 26353
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x020012E6 RID: 4838
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetObjectMap_FunctionParams
		{
			// Token: 0x040066F2 RID: 26354
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x020012E7 RID: 4839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetObjectArray_FunctionParams
		{
			// Token: 0x040066F3 RID: 26355
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x020012E8 RID: 4840
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetObject_FunctionParams
		{
			// Token: 0x040066F4 RID: 26356
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x020012E9 RID: 4841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectSet_FunctionParams
		{
			// Token: 0x040066F5 RID: 26357
			[FieldOffset(0)]
			public byte OutSoftObjectSet;
		}

		// Token: 0x020012EA RID: 4842
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftObjectMap_FunctionParams
		{
			// Token: 0x040066F6 RID: 26358
			[FieldOffset(0)]
			public byte OutSoftObjectMap;
		}

		// Token: 0x020012EB RID: 4843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftObjectArray_FunctionParams
		{
			// Token: 0x040066F7 RID: 26359
			[FieldOffset(0)]
			public byte OutSoftObjectArray;
		}

		// Token: 0x020012EC RID: 4844
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftObject_FunctionParams
		{
			// Token: 0x040066F8 RID: 26360
			[FieldOffset(0)]
			public byte OutSoftObject;
		}

		// Token: 0x020012ED RID: 4845
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectSet_FunctionParams
		{
			// Token: 0x040066F9 RID: 26361
			[FieldOffset(0)]
			public byte OutSimpleObjectSet;
		}

		// Token: 0x020012EE RID: 4846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleObjectMap_FunctionParams
		{
			// Token: 0x040066FA RID: 26362
			[FieldOffset(0)]
			public byte OutSimpleObjectMap;
		}

		// Token: 0x020012EF RID: 4847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleObjectArray_FunctionParams
		{
			// Token: 0x040066FB RID: 26363
			[FieldOffset(0)]
			public byte OutSimpleObjectArray;
		}

		// Token: 0x020012F0 RID: 4848
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSimpleObject_FunctionParams
		{
			// Token: 0x040066FC RID: 26364
			[FieldOffset(0)]
			public IntPtr OutSimpleObject;
		}

		// Token: 0x020012F1 RID: 4849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectSet_FunctionParams
		{
			// Token: 0x040066FD RID: 26365
			[FieldOffset(0)]
			public byte OutObjectSet;
		}

		// Token: 0x020012F2 RID: 4850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathSet_FunctionParams
		{
			// Token: 0x040066FE RID: 26366
			[FieldOffset(0)]
			public byte OutObjectPathSet;
		}

		// Token: 0x020012F3 RID: 4851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectPathMap_FunctionParams
		{
			// Token: 0x040066FF RID: 26367
			[FieldOffset(0)]
			public byte OutObjectPathMap;
		}

		// Token: 0x020012F4 RID: 4852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectPathArray_FunctionParams
		{
			// Token: 0x04006700 RID: 26368
			[FieldOffset(0)]
			public byte OutObjectPathArray;
		}

		// Token: 0x020012F5 RID: 4853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutObjectPath_FunctionParams
		{
			// Token: 0x04006701 RID: 26369
			[FieldOffset(0)]
			public byte OutObjectPath;
		}

		// Token: 0x020012F6 RID: 4854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutObjectMap_FunctionParams
		{
			// Token: 0x04006702 RID: 26370
			[FieldOffset(0)]
			public byte OutObjectMap;
		}

		// Token: 0x020012F7 RID: 4855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutObjectArray_FunctionParams
		{
			// Token: 0x04006703 RID: 26371
			[FieldOffset(0)]
			public byte OutObjectArray;
		}

		// Token: 0x020012F8 RID: 4856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutObject_FunctionParams
		{
			// Token: 0x04006704 RID: 26372
			[FieldOffset(0)]
			public IntPtr OutObject;
		}

		// Token: 0x020012F9 RID: 4857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectSet_FunctionParams
		{
			// Token: 0x04006705 RID: 26373
			[FieldOffset(0)]
			public byte InSoftObjectSet;
		}

		// Token: 0x020012FA RID: 4858
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftObjectMap_FunctionParams
		{
			// Token: 0x04006706 RID: 26374
			[FieldOffset(0)]
			public byte InSoftObjectMap;
		}

		// Token: 0x020012FB RID: 4859
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftObjectArray_FunctionParams
		{
			// Token: 0x04006707 RID: 26375
			[FieldOffset(0)]
			public byte InSoftObjectArray;
		}

		// Token: 0x020012FC RID: 4860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftObject_FunctionParams
		{
			// Token: 0x04006708 RID: 26376
			[FieldOffset(0)]
			public byte InSoftObject;
		}

		// Token: 0x020012FD RID: 4861
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectSet_FunctionParams
		{
			// Token: 0x04006709 RID: 26377
			[FieldOffset(0)]
			public byte InSimpleObjectSet;
		}

		// Token: 0x020012FE RID: 4862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleObjectMap_FunctionParams
		{
			// Token: 0x0400670A RID: 26378
			[FieldOffset(0)]
			public byte InSimpleObjectMap;
		}

		// Token: 0x020012FF RID: 4863
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleObjectArray_FunctionParams
		{
			// Token: 0x0400670B RID: 26379
			[FieldOffset(0)]
			public byte InSimpleObjectArray;
		}

		// Token: 0x02001300 RID: 4864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSimpleObject_FunctionParams
		{
			// Token: 0x0400670C RID: 26380
			[FieldOffset(0)]
			public IntPtr InSimpleObject;
		}

		// Token: 0x02001301 RID: 4865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectSet_FunctionParams
		{
			// Token: 0x0400670D RID: 26381
			[FieldOffset(0)]
			public byte InObjectSet;
		}

		// Token: 0x02001302 RID: 4866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathSet_FunctionParams
		{
			// Token: 0x0400670E RID: 26382
			[FieldOffset(0)]
			public byte InObjectPathSet;
		}

		// Token: 0x02001303 RID: 4867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectPathMap_FunctionParams
		{
			// Token: 0x0400670F RID: 26383
			[FieldOffset(0)]
			public byte InObjectPathMap;
		}

		// Token: 0x02001304 RID: 4868
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectPathArray_FunctionParams
		{
			// Token: 0x04006710 RID: 26384
			[FieldOffset(0)]
			public byte InObjectPathArray;
		}

		// Token: 0x02001305 RID: 4869
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InObjectPath_FunctionParams
		{
			// Token: 0x04006711 RID: 26385
			[FieldOffset(0)]
			public byte InObjectPath;
		}

		// Token: 0x02001306 RID: 4870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InObjectMap_FunctionParams
		{
			// Token: 0x04006712 RID: 26386
			[FieldOffset(0)]
			public byte InObjectMap;
		}

		// Token: 0x02001307 RID: 4871
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InObjectArray_FunctionParams
		{
			// Token: 0x04006713 RID: 26387
			[FieldOffset(0)]
			public byte InObjectArray;
		}

		// Token: 0x02001308 RID: 4872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InObject_FunctionParams
		{
			// Token: 0x04006714 RID: 26388
			[FieldOffset(0)]
			public IntPtr InObject;
		}

		// Token: 0x02001309 RID: 4873
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectSet_FunctionParams
		{
			// Token: 0x04006715 RID: 26389
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130A RID: 4874
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftObjectMap_FunctionParams
		{
			// Token: 0x04006716 RID: 26390
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130B RID: 4875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftObjectArray_FunctionParams
		{
			// Token: 0x04006717 RID: 26391
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130C RID: 4876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftObject_FunctionParams
		{
			// Token: 0x04006718 RID: 26392
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130D RID: 4877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectSet_FunctionParams
		{
			// Token: 0x04006719 RID: 26393
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130E RID: 4878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleObjectMap_FunctionParams
		{
			// Token: 0x0400671A RID: 26394
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200130F RID: 4879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleObjectArray_FunctionParams
		{
			// Token: 0x0400671B RID: 26395
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001310 RID: 4880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSimpleObject_FunctionParams
		{
			// Token: 0x0400671C RID: 26396
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001311 RID: 4881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectSet_FunctionParams
		{
			// Token: 0x0400671D RID: 26397
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001312 RID: 4882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathSet_FunctionParams
		{
			// Token: 0x0400671E RID: 26398
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001313 RID: 4883
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectPathMap_FunctionParams
		{
			// Token: 0x0400671F RID: 26399
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001314 RID: 4884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectPathArray_FunctionParams
		{
			// Token: 0x04006720 RID: 26400
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001315 RID: 4885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetObjectPath_FunctionParams
		{
			// Token: 0x04006721 RID: 26401
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001316 RID: 4886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetObjectMap_FunctionParams
		{
			// Token: 0x04006722 RID: 26402
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001317 RID: 4887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetObjectArray_FunctionParams
		{
			// Token: 0x04006723 RID: 26403
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001318 RID: 4888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetObject_FunctionParams
		{
			// Token: 0x04006724 RID: 26404
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
