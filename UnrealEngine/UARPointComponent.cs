using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B8 RID: 952
	[UnrealObjectPath("/Script/AugmentedReality.ARPointComponent")]
	[UnrealStructLayout(704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UARPointComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060034D5 RID: 13525 RVA: 0x00050A23 File Offset: 0x0004EC23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARPointComponent._ClassPtr;
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00050A30 File Offset: 0x0004EC30
		public UARPointComponent() : this(BuiltinUtils.AllocNativeUObject(UARPointComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00050A58 File Offset: 0x0004EC58
		[NullableContext(1)]
		public UARPointComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARPointComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x00050A8B File Offset: 0x0004EC8B
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x00050A9F File Offset: 0x0004EC9F
		public unsafe FARPointUpdatePayload ReplicatedPayload
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARPointComponent.__PropertyOffset_ReplicatedPayload);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPointComponent.__PropertyOffset_ReplicatedPayload) = value;
			}
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00050AB4 File Offset: 0x0004ECB4
		public void ServerUpdatePayload(in FARPointUpdatePayload NewPayload)
		{
			UARPointComponent.__ServerUpdatePayload_Internal(base.NativePtr, NewPayload);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00050AC2 File Offset: 0x0004ECC2
		public virtual void ReceiveUpdate(in FARPointUpdatePayload Payload)
		{
			UARPointComponent.__ReceiveUpdate_Internal(base.NativePtr, Payload);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00050AD0 File Offset: 0x0004ECD0
		public virtual void ReceiveAdd(in FARPointUpdatePayload Payload)
		{
			UARPointComponent.__ReceiveAdd_Internal(base.NativePtr, Payload);
		}

		// Token: 0x060034DD RID: 13533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, in FARPointUpdatePayload NewPayload);

		// Token: 0x060034DE RID: 13534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, in FARPointUpdatePayload Payload);

		// Token: 0x060034DF RID: 13535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, in FARPointUpdatePayload Payload);

		// Token: 0x060034E0 RID: 13536 RVA: 0x00050ADE File Offset: 0x0004ECDE
		static UARPointComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARPointComponent");
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00050AEC File Offset: 0x0004ECEC
		protected UARPointComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016E8 RID: 5864
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARPointComponent";

		// Token: 0x040016E9 RID: 5865
		private static IntPtr _ClassPtr;

		// Token: 0x040016EA RID: 5866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016EB RID: 5867
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x02002C14 RID: 11284
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016518 RID: 91416
			[FieldOffset(0)]
			public FARPointUpdatePayload Payload;
		}

		// Token: 0x02002C15 RID: 11285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016519 RID: 91417
			[FieldOffset(0)]
			public FARPointUpdatePayload Payload;
		}
	}
}
