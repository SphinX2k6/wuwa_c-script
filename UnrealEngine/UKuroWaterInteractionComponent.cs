using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191A RID: 6426
	[UnrealObjectPath("/Script/KuroGameplay.KuroWaterInteractionComponent")]
	[UnrealStructLayout(2032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class UKuroWaterInteractionComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject, IKuroWaterDetectedReceiverInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06017D8C RID: 97676 RVA: 0x0022EBF4 File Offset: 0x0022CDF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWaterInteractionComponent._ClassPtr;
		}

		// Token: 0x06017D8D RID: 97677 RVA: 0x0022EC00 File Offset: 0x0022CE00
		int IKuroWaterDetectedReceiverInterface.InterfaceOffset()
		{
			return UKuroWaterInteractionComponent.__InterfaceOffset_IKuroWaterDetectedReceiverInterface;
		}

		// Token: 0x06017D8E RID: 97678 RVA: 0x0022EC08 File Offset: 0x0022CE08
		public UKuroWaterInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroWaterInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D8F RID: 97679 RVA: 0x0022EC30 File Offset: 0x0022CE30
		[NullableContext(1)]
		public UKuroWaterInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWaterInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x06017D90 RID: 97680 RVA: 0x0022EC63 File Offset: 0x0022CE63
		// (set) Token: 0x06017D91 RID: 97681 RVA: 0x0022EC77 File Offset: 0x0022CE77
		[Nullable(2)]
		public unsafe AActor Invoker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWaterInteractionComponent.__PropertyOffset_Invoker);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWaterInteractionComponent.__PropertyOffset_Invoker, value);
			}
		}

		// Token: 0x06017D92 RID: 97682 RVA: 0x0022EC8C File Offset: 0x0022CE8C
		public virtual void HandleWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedTick_Internal(base.NativePtr, DeltaTime, WaterSurface, Location);
		}

		// Token: 0x06017D93 RID: 97683 RVA: 0x0022EC9C File Offset: 0x0022CE9C
		public virtual void HandleWaterDetectedStart()
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedStart_Internal(base.NativePtr);
		}

		// Token: 0x06017D94 RID: 97684 RVA: 0x0022ECA9 File Offset: 0x0022CEA9
		public virtual void HandleWaterDetectedEnd()
		{
			UKuroWaterInteractionComponent.__HandleWaterDetectedEnd_Internal(base.NativePtr);
		}

		// Token: 0x06017D95 RID: 97685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedTick_Internal(IntPtr @this, float DeltaTime, float WaterSurface, in FVectorDouble Location);

		// Token: 0x06017D96 RID: 97686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedStart_Internal(IntPtr @this);

		// Token: 0x06017D97 RID: 97687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleWaterDetectedEnd_Internal(IntPtr @this);

		// Token: 0x06017D98 RID: 97688 RVA: 0x0022ECB6 File Offset: 0x0022CEB6
		static UKuroWaterInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroWaterInteractionComponent");
		}

		// Token: 0x06017D99 RID: 97689 RVA: 0x0022ECC4 File Offset: 0x0022CEC4
		protected UKuroWaterInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEBD RID: 52925
		internal static int __InterfaceOffset_IKuroWaterDetectedReceiverInterface;

		// Token: 0x0400CEBE RID: 52926
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroWaterInteractionComponent";

		// Token: 0x0400CEBF RID: 52927
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEC0 RID: 52928
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEC1 RID: 52929
		internal static int __PropertyOffset_Invoker;

		// Token: 0x02002FDE RID: 12254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __HandleWaterDetectedTick_FunctionParams
		{
			// Token: 0x04016BD5 RID: 93141
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016BD6 RID: 93142
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x04016BD7 RID: 93143
			[FieldOffset(8)]
			public FVectorDouble Location;
		}
	}
}
