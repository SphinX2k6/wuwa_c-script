using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A5 RID: 421
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ChildActorComponent")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UChildActorComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F6A RID: 8042 RVA: 0x0002D739 File Offset: 0x0002B939
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChildActorComponent._ClassPtr;
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0002D748 File Offset: 0x0002B948
		public UChildActorComponent() : this(BuiltinUtils.AllocNativeUObject(UChildActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0002D770 File Offset: 0x0002B970
		[NullableContext(1)]
		public UChildActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChildActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0002D7A3 File Offset: 0x0002B9A3
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x0002D7B7 File Offset: 0x0002B9B7
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x0002D7CC File Offset: 0x0002B9CC
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0002D7F5 File Offset: 0x0002B9F5
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0002D809 File Offset: 0x0002BA09
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

		// Token: 0x06001F73 RID: 8051 RVA: 0x0002D81E File Offset: 0x0002BA1E
		public void SetChildActorClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> InClass)
		{
			UChildActorComponent.__SetChildActorClass_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x06001F74 RID: 8052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChildActorClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06001F75 RID: 8053 RVA: 0x0002D831 File Offset: 0x0002BA31
		static UChildActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ChildActorComponent");
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0002D83F File Offset: 0x0002BA3F
		protected UChildActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A63 RID: 2659
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ChildActorComponent";

		// Token: 0x04000A64 RID: 2660
		private static IntPtr _ClassPtr;

		// Token: 0x04000A65 RID: 2661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A66 RID: 2662
		internal static int __PropertyOffset_ChildActorClass;

		// Token: 0x04000A67 RID: 2663
		internal static int __PropertyOffset_ChildActor;

		// Token: 0x04000A68 RID: 2664
		internal static int __PropertyOffset_ChildActorTemplate;
	}
}
