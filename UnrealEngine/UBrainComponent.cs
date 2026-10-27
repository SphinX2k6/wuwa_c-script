using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000131 RID: 305
	[UnrealObjectPath("/Script/AIModule.BrainComponent")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UBrainComponent : UActorComponent, IUnrealUObject, IUnrealObject, IAIResourceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x0001FDC6 File Offset: 0x0001DFC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrainComponent._ClassPtr;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0001FDD2 File Offset: 0x0001DFD2
		int IAIResourceInterface.InterfaceOffset()
		{
			return UBrainComponent.__InterfaceOffset_IAIResourceInterface;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0001FDDC File Offset: 0x0001DFDC
		public UBrainComponent() : this(BuiltinUtils.AllocNativeUObject(UBrainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0001FE04 File Offset: 0x0001E004
		[NullableContext(1)]
		public UBrainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0001FE37 File Offset: 0x0001E037
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0001FE4B File Offset: 0x0001E04B
		[Nullable(2)]
		public unsafe UBlackboardComponent BlackboardComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_BlackboardComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_BlackboardComp, value);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0001FE60 File Offset: 0x0001E060
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x0001FE74 File Offset: 0x0001E074
		[Nullable(2)]
		public unsafe AAIController AIOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_AIOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBrainComponent.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0001FE8C File Offset: 0x0001E08C
		[NullableContext(1)]
		public unsafe void StopLogic(string Reason)
		{
			FString fstring = FString.AllocTemp(Reason);
			UBrainComponent.__StopLogic_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0001FEB6 File Offset: 0x0001E0B6
		public void StartLogic()
		{
			UBrainComponent.__StartLogic_Internal(base.NativePtr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0001FEC3 File Offset: 0x0001E0C3
		public void RestartLogic()
		{
			UBrainComponent.__RestartLogic_Internal(base.NativePtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0001FED0 File Offset: 0x0001E0D0
		public bool IsRunning()
		{
			return UBrainComponent.__IsRunning_Internal(base.NativePtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0001FEDD File Offset: 0x0001E0DD
		public bool IsPaused()
		{
			return UBrainComponent.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x060015B8 RID: 5560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopLogic_Internal(IntPtr @this, in FString Reason);

		// Token: 0x060015B9 RID: 5561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartLogic_Internal(IntPtr @this);

		// Token: 0x060015BA RID: 5562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartLogic_Internal(IntPtr @this);

		// Token: 0x060015BB RID: 5563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRunning_Internal(IntPtr @this);

		// Token: 0x060015BC RID: 5564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x060015BD RID: 5565 RVA: 0x0001FEEA File Offset: 0x0001E0EA
		static UBrainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BrainComponent");
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		protected UBrainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004AD RID: 1197
		internal static int __InterfaceOffset_IAIResourceInterface;

		// Token: 0x040004AE RID: 1198
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BrainComponent";

		// Token: 0x040004AF RID: 1199
		private static IntPtr _ClassPtr;

		// Token: 0x040004B0 RID: 1200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004B1 RID: 1201
		internal static int __PropertyOffset_BlackboardComp;

		// Token: 0x040004B2 RID: 1202
		internal static int __PropertyOffset_AIOwner;
	}
}
