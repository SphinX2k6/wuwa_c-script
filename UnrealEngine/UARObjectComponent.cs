using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B1 RID: 945
	[UnrealObjectPath("/Script/AugmentedReality.ARObjectComponent")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UARObjectComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003459 RID: 13401 RVA: 0x0005007B File Offset: 0x0004E27B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARObjectComponent._ClassPtr;
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00050088 File Offset: 0x0004E288
		public UARObjectComponent() : this(BuiltinUtils.AllocNativeUObject(UARObjectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000500B0 File Offset: 0x0004E2B0
		[NullableContext(1)]
		public UARObjectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARObjectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x000500E4 File Offset: 0x0004E2E4
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x0005011D File Offset: 0x0004E31D
		[Nullable(1)]
		public FARObjectUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARObjectUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARObjectUpdatePayload(base.NativePtr + (IntPtr)UARObjectComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARObjectUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARObjectComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x0005013E File Offset: 0x0004E33E
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARObjectUpdatePayload NewPayload)
		{
			UARObjectComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARObjectUpdatePayload()).NativePtr);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0005015B File Offset: 0x0004E35B
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARObjectUpdatePayload Payload)
		{
			UARObjectComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARObjectUpdatePayload()).NativePtr);
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00050178 File Offset: 0x0004E378
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARObjectUpdatePayload Payload)
		{
			UARObjectComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARObjectUpdatePayload()).NativePtr);
		}

		// Token: 0x06003461 RID: 13409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003462 RID: 13410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003463 RID: 13411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003464 RID: 13412 RVA: 0x00050195 File Offset: 0x0004E395
		static UARObjectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARObjectComponent");
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x000501A3 File Offset: 0x0004E3A3
		protected UARObjectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016B9 RID: 5817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARObjectComponent";

		// Token: 0x040016BA RID: 5818
		private static IntPtr _ClassPtr;

		// Token: 0x040016BB RID: 5819
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016BC RID: 5820
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x040016BD RID: 5821
		[Nullable(2)]
		private FARObjectUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C10 RID: 11280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016514 RID: 91412
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C11 RID: 11281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016515 RID: 91413
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
