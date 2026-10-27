using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000930 RID: 2352
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ChildActorComponent")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UChildActorComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084EF RID: 34031 RVA: 0x000BD961 File Offset: 0x000BBB61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChildActorComponent._ClassPtr;
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x000BD970 File Offset: 0x000BBB70
		public UChildActorComponent() : this(BuiltinUtils.AllocNativeUObject(UChildActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x000BD998 File Offset: 0x000BBB98
		[NullableContext(1)]
		public UChildActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChildActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x060084F2 RID: 34034 RVA: 0x000BD9CB File Offset: 0x000BBBCB
		// (set) Token: 0x060084F3 RID: 34035 RVA: 0x000BD9DF File Offset: 0x000BBBDF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ChildActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UChildActorComponent.__PropertyOffset_ChildActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UChildActorComponent.__PropertyOffset_ChildActorClass) = value;
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x060084F4 RID: 34036 RVA: 0x000BD9F4 File Offset: 0x000BBBF4
		// (set) Token: 0x060084F5 RID: 34037 RVA: 0x000BDA08 File Offset: 0x000BBC08
		public unsafe AActor ChildActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UChildActorComponent.__PropertyOffset_ChildActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UChildActorComponent.__PropertyOffset_ChildActor, value);
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x060084F6 RID: 34038 RVA: 0x000BDA1D File Offset: 0x000BBC1D
		// (set) Token: 0x060084F7 RID: 34039 RVA: 0x000BDA31 File Offset: 0x000BBC31
		public unsafe AActor ChildActorTemplate
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UChildActorComponent.__PropertyOffset_ChildActorTemplate);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UChildActorComponent.__PropertyOffset_ChildActorTemplate, value);
			}
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x000BDA46 File Offset: 0x000BBC46
		public void SetChildActorClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> InClass)
		{
			UChildActorComponent.__SetChildActorClass_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x060084F9 RID: 34041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChildActorClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x060084FA RID: 34042 RVA: 0x000BDA59 File Offset: 0x000BBC59
		static UChildActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ChildActorComponent");
		}

		// Token: 0x060084FB RID: 34043 RVA: 0x000BDA67 File Offset: 0x000BBC67
		protected UChildActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F43 RID: 16195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ChildActorComponent";

		// Token: 0x04003F44 RID: 16196
		private static IntPtr _ClassPtr;

		// Token: 0x04003F45 RID: 16197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F46 RID: 16198
		internal static int __PropertyOffset_ChildActorClass;

		// Token: 0x04003F47 RID: 16199
		internal static int __PropertyOffset_ChildActor;

		// Token: 0x04003F48 RID: 16200
		internal static int __PropertyOffset_ChildActorTemplate;
	}
}
