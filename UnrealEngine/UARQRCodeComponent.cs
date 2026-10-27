using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BE RID: 958
	[UnrealObjectPath("/Script/AugmentedReality.ARQRCodeComponent")]
	[UnrealStructLayout(816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UARQRCodeComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600351F RID: 13599 RVA: 0x000510E7 File Offset: 0x0004F2E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARQRCodeComponent._ClassPtr;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000510F4 File Offset: 0x0004F2F4
		public UARQRCodeComponent() : this(BuiltinUtils.AllocNativeUObject(UARQRCodeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0005111C File Offset: 0x0004F31C
		[NullableContext(1)]
		public UARQRCodeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARQRCodeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x00051150 File Offset: 0x0004F350
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x00051189 File Offset: 0x0004F389
		[Nullable(1)]
		public FARQRCodeUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARQRCodeUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARQRCodeUpdatePayload(base.NativePtr + (IntPtr)UARQRCodeComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARQRCodeUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARQRCodeComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003524 RID: 13604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQRCodeComponentDebugMode(EQRCodeComponentDebugMode NewDebugMode);

		// Token: 0x06003525 RID: 13605 RVA: 0x000511AA File Offset: 0x0004F3AA
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARQRCodeUpdatePayload NewPayload)
		{
			UARQRCodeComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARQRCodeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x000511C7 File Offset: 0x0004F3C7
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARQRCodeUpdatePayload Payload)
		{
			UARQRCodeComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARQRCodeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x000511E4 File Offset: 0x0004F3E4
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARQRCodeUpdatePayload Payload)
		{
			UARQRCodeComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARQRCodeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003528 RID: 13608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003529 RID: 13609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x0600352A RID: 13610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x0600352B RID: 13611 RVA: 0x00051201 File Offset: 0x0004F401
		static UARQRCodeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARQRCodeComponent");
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0005120F File Offset: 0x0004F40F
		protected UARQRCodeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001709 RID: 5897
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARQRCodeComponent";

		// Token: 0x0400170A RID: 5898
		private static IntPtr _ClassPtr;

		// Token: 0x0400170B RID: 5899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400170C RID: 5900
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x0400170D RID: 5901
		[Nullable(2)]
		private FARQRCodeUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C18 RID: 11288
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x0401651C RID: 91420
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C19 RID: 11289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x0401651D RID: 91421
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
