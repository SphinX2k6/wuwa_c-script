using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AE RID: 942
	[UnrealObjectPath("/Script/AugmentedReality.ARMeshComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UARMeshComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x0004FD76 File Offset: 0x0004DF76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARMeshComponent._ClassPtr;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x0004FD84 File Offset: 0x0004DF84
		public UARMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UARMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		[NullableContext(1)]
		public UARMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x0004FE19 File Offset: 0x0004E019
		[Nullable(1)]
		public FARMeshUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARMeshUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARMeshUpdatePayload(base.NativePtr + (IntPtr)UARMeshComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARMeshUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARMeshComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x0004FE3A File Offset: 0x0004E03A
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARMeshUpdatePayload NewPayload)
		{
			UARMeshComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARMeshUpdatePayload()).NativePtr);
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x0004FE57 File Offset: 0x0004E057
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARMeshUpdatePayload Payload)
		{
			UARMeshComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARMeshUpdatePayload()).NativePtr);
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x0004FE74 File Offset: 0x0004E074
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARMeshUpdatePayload Payload)
		{
			UARMeshComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARMeshUpdatePayload()).NativePtr);
		}

		// Token: 0x0600343F RID: 13375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003440 RID: 13376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003441 RID: 13377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003442 RID: 13378 RVA: 0x0004FE91 File Offset: 0x0004E091
		static UARMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARMeshComponent");
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x0004FE9F File Offset: 0x0004E09F
		protected UARMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016AB RID: 5803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARMeshComponent";

		// Token: 0x040016AC RID: 5804
		private static IntPtr _ClassPtr;

		// Token: 0x040016AD RID: 5805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016AE RID: 5806
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x040016AF RID: 5807
		[Nullable(2)]
		private FARMeshUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C0E RID: 11278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016512 RID: 91410
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C0F RID: 11279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016513 RID: 91411
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
