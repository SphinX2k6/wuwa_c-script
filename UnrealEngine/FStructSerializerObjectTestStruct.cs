using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002722 RID: 10018
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerObjectTestStruct")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FStructSerializerObjectTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060251F0 RID: 152048 RVA: 0x0036F928 File Offset: 0x0036DB28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerObjectTestStruct._ScriptStructPtr != 0) ? FStructSerializerObjectTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerObjectTestStruct", ref FStructSerializerObjectTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F41 RID: 36673
		// (get) Token: 0x060251F1 RID: 152049 RVA: 0x0036F94C File Offset: 0x0036DB4C
		// (set) Token: 0x060251F2 RID: 152050 RVA: 0x0036F960 File Offset: 0x0036DB60
		public unsafe UClassStackOnlyPtr Class
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_Class);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_Class) = value;
			}
		}

		// Token: 0x17008F42 RID: 36674
		// (get) Token: 0x060251F3 RID: 152051 RVA: 0x0036F975 File Offset: 0x0036DB75
		// (set) Token: 0x060251F4 RID: 152052 RVA: 0x0036F989 File Offset: 0x0036DB89
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMetaData> SubClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SubClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SubClass) = value;
			}
		}

		// Token: 0x17008F43 RID: 36675
		// (get) Token: 0x060251F5 RID: 152053 RVA: 0x0036F99E File Offset: 0x0036DB9E
		// (set) Token: 0x060251F6 RID: 152054 RVA: 0x0036F9BD File Offset: 0x0036DBBD
		public TSoftClassPtr<UMetaData> SoftClass
		{
			get
			{
				return new TSoftClassPtr<UMetaData>(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SoftClass, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SoftClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008F44 RID: 36676
		// (get) Token: 0x060251F7 RID: 152055 RVA: 0x0036F9E2 File Offset: 0x0036DBE2
		// (set) Token: 0x060251F8 RID: 152056 RVA: 0x0036F9F6 File Offset: 0x0036DBF6
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FStructSerializerObjectTestStruct.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStructSerializerObjectTestStruct.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x17008F45 RID: 36677
		// (get) Token: 0x060251F9 RID: 152057 RVA: 0x0036FA0B File Offset: 0x0036DC0B
		// (set) Token: 0x060251FA RID: 152058 RVA: 0x0036FA1F File Offset: 0x0036DC1F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMetaData> WeakObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_WeakObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_WeakObject) = value;
			}
		}

		// Token: 0x17008F46 RID: 36678
		// (get) Token: 0x060251FB RID: 152059 RVA: 0x0036FA34 File Offset: 0x0036DC34
		// (set) Token: 0x060251FC RID: 152060 RVA: 0x0036FA53 File Offset: 0x0036DC53
		public TSoftObjectPtr<UMetaData> SoftObject
		{
			get
			{
				return new TSoftObjectPtr<UMetaData>(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SoftObject, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_SoftObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008F47 RID: 36679
		// (get) Token: 0x060251FD RID: 152061 RVA: 0x0036FA78 File Offset: 0x0036DC78
		// (set) Token: 0x060251FE RID: 152062 RVA: 0x0036FABB File Offset: 0x0036DCBB
		public FSoftClassPath ClassPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ClassPath) == null)
				{
					result = (this._ClassPath = new FSoftClassPath(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_ClassPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_ClassPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F48 RID: 36680
		// (get) Token: 0x060251FF RID: 152063 RVA: 0x0036FADC File Offset: 0x0036DCDC
		// (set) Token: 0x06025200 RID: 152064 RVA: 0x0036FB1F File Offset: 0x0036DD1F
		public FSoftObjectPath ObjectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ObjectPath) == null)
				{
					result = (this._ObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_ObjectPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerObjectTestStruct.__PropertyOffset_ObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025201 RID: 152065 RVA: 0x0036FB40 File Offset: 0x0036DD40
		public FStructSerializerObjectTestStruct()
		{
		}

		// Token: 0x06025202 RID: 152066 RVA: 0x0036FB48 File Offset: 0x0036DD48
		public FStructSerializerObjectTestStruct(UClassStackOnlyPtr Class, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMetaData> SubClass, TSoftClassPtr<UMetaData> SoftClass, UObject Object, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMetaData> WeakObject, TSoftObjectPtr<UMetaData> SoftObject, FSoftClassPath ClassPath, FSoftObjectPath ObjectPath)
		{
			this.Class = Class;
			this.SubClass = SubClass;
			this.SoftClass = SoftClass;
			this.Object = Object;
			this.WeakObject = WeakObject;
			this.SoftObject = SoftObject;
			this.ClassPath = ClassPath;
			this.ObjectPath = ObjectPath;
		}

		// Token: 0x06025203 RID: 152067 RVA: 0x0036FB98 File Offset: 0x0036DD98
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerObjectTestStruct.StaticStruct();
		}

		// Token: 0x06025204 RID: 152068 RVA: 0x0036FBA4 File Offset: 0x0036DDA4
		[NullableContext(2)]
		public FStructSerializerObjectTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025205 RID: 152069 RVA: 0x0036FBAE File Offset: 0x0036DDAE
		public FStructSerializerObjectTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025206 RID: 152070 RVA: 0x0036FBB9 File Offset: 0x0036DDB9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerObjectTestStruct(Pointer, false, true);
		}

		// Token: 0x06025207 RID: 152071 RVA: 0x0036FBC3 File Offset: 0x0036DDC3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerObjectTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0401400E RID: 81934
		public const string __ObjectPath = "/Script/Serialization.StructSerializerObjectTestStruct";

		// Token: 0x0401400F RID: 81935
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014010 RID: 81936
		internal static int __PropertyOffset_Class;

		// Token: 0x04014011 RID: 81937
		internal static int __PropertyOffset_SubClass;

		// Token: 0x04014012 RID: 81938
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x04014013 RID: 81939
		internal static int __PropertyOffset_Object;

		// Token: 0x04014014 RID: 81940
		internal static int __PropertyOffset_WeakObject;

		// Token: 0x04014015 RID: 81941
		internal static int __PropertyOffset_SoftObject;

		// Token: 0x04014016 RID: 81942
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x04014017 RID: 81943
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x04014018 RID: 81944
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04014019 RID: 81945
		[Nullable(2)]
		private FSoftObjectPath _ObjectPath;
	}
}
