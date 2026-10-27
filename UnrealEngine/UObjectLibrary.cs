using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EFA RID: 3834
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ObjectLibrary")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UObjectLibrary : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFB8 RID: 53176 RVA: 0x0012EF3E File Offset: 0x0012D13E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectLibrary._ClassPtr;
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x0012EF4C File Offset: 0x0012D14C
		public UObjectLibrary() : this(BuiltinUtils.AllocNativeUObject(UObjectLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x0012EF74 File Offset: 0x0012D174
		public UObjectLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600CFBB RID: 53179 RVA: 0x0012EFA7 File Offset: 0x0012D1A7
		// (set) Token: 0x0600CFBC RID: 53180 RVA: 0x0012EFBB File Offset: 0x0012D1BB
		public unsafe UClassStackOnlyPtr ObjectBaseClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_ObjectBaseClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_ObjectBaseClass) = value;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600CFBD RID: 53181 RVA: 0x0012EFD0 File Offset: 0x0012D1D0
		// (set) Token: 0x0600CFBE RID: 53182 RVA: 0x0012EFE0 File Offset: 0x0012D1E0
		public unsafe bool bHasBlueprintClasses
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bHasBlueprintClasses) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bHasBlueprintClasses) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600CFBF RID: 53183 RVA: 0x0012EFF4 File Offset: 0x0012D1F4
		// (set) Token: 0x0600CFC0 RID: 53184 RVA: 0x0012F02D File Offset: 0x0012D22D
		public TArray<UObject> Objects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Objects) == null)
				{
					result = (this._Objects = new TArray<UObject>(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_Objects, this));
				}
				return result;
			}
			set
			{
				this.Objects.CopyAssign(value);
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600CFC1 RID: 53185 RVA: 0x0012F03C File Offset: 0x0012D23C
		// (set) Token: 0x0600CFC2 RID: 53186 RVA: 0x0012F075 File Offset: 0x0012D275
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UObject>> WeakObjects
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
				TArray<TWeakObjectPtr<UObject>> result;
				if ((result = this._WeakObjects) == null)
				{
					result = (this._WeakObjects = new TArray<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_WeakObjects, this));
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
				this.WeakObjects.CopyAssign(value);
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600CFC3 RID: 53187 RVA: 0x0012F083 File Offset: 0x0012D283
		// (set) Token: 0x0600CFC4 RID: 53188 RVA: 0x0012F093 File Offset: 0x0012D293
		public unsafe bool bUseWeakReferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bUseWeakReferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bUseWeakReferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x0012F0A4 File Offset: 0x0012D2A4
		// (set) Token: 0x0600CFC6 RID: 53190 RVA: 0x0012F0B4 File Offset: 0x0012D2B4
		public unsafe bool bIsFullyLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bIsFullyLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectLibrary.__PropertyOffset_bIsFullyLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600CFC7 RID: 53191 RVA: 0x0012F0C5 File Offset: 0x0012D2C5
		static UObjectLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ObjectLibrary");
		}

		// Token: 0x0600CFC8 RID: 53192 RVA: 0x0012F0D3 File Offset: 0x0012D2D3
		protected UObjectLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FFA RID: 28666
		public new const string __ObjectPath = "/Script/Engine.ObjectLibrary";

		// Token: 0x04006FFB RID: 28667
		private static IntPtr _ClassPtr;

		// Token: 0x04006FFC RID: 28668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006FFD RID: 28669
		internal static int __PropertyOffset_ObjectBaseClass;

		// Token: 0x04006FFE RID: 28670
		internal static int __PropertyOffset_bHasBlueprintClasses;

		// Token: 0x04006FFF RID: 28671
		internal static int __PropertyOffset_Objects;

		// Token: 0x04007000 RID: 28672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Objects;

		// Token: 0x04007001 RID: 28673
		internal static int __PropertyOffset_WeakObjects;

		// Token: 0x04007002 RID: 28674
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _WeakObjects;

		// Token: 0x04007003 RID: 28675
		internal static int __PropertyOffset_bUseWeakReferences;

		// Token: 0x04007004 RID: 28676
		internal static int __PropertyOffset_bIsFullyLoaded;
	}
}
