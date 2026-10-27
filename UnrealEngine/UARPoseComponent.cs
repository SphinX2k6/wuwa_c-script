using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BC RID: 956
	[UnrealObjectPath("/Script/AugmentedReality.ARPoseComponent")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UARPoseComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x00050EC3 File Offset: 0x0004F0C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARPoseComponent._ClassPtr;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00050ED0 File Offset: 0x0004F0D0
		public UARPoseComponent() : this(BuiltinUtils.AllocNativeUObject(UARPoseComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[NullableContext(1)]
		public UARPoseComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARPoseComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x00050F2C File Offset: 0x0004F12C
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x00050F65 File Offset: 0x0004F165
		[Nullable(1)]
		public FARPoseUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARPoseUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARPoseUpdatePayload(base.NativePtr + (IntPtr)UARPoseComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARPoseUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARPoseComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600350A RID: 13578
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPoseComponentDebugMode(EPoseComponentDebugMode NewDebugMode);

		// Token: 0x0600350B RID: 13579 RVA: 0x00050F86 File Offset: 0x0004F186
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARPoseUpdatePayload NewPayload)
		{
			UARPoseComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARPoseUpdatePayload()).NativePtr);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00050FA3 File Offset: 0x0004F1A3
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARPoseUpdatePayload Payload)
		{
			UARPoseComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARPoseUpdatePayload()).NativePtr);
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARPoseUpdatePayload Payload)
		{
			UARPoseComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARPoseUpdatePayload()).NativePtr);
		}

		// Token: 0x0600350E RID: 13582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x0600350F RID: 13583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003510 RID: 13584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003511 RID: 13585 RVA: 0x00050FDD File Offset: 0x0004F1DD
		static UARPoseComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARPoseComponent");
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x00050FEB File Offset: 0x0004F1EB
		protected UARPoseComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016FF RID: 5887
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARPoseComponent";

		// Token: 0x04001700 RID: 5888
		private static IntPtr _ClassPtr;

		// Token: 0x04001701 RID: 5889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001702 RID: 5890
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x04001703 RID: 5891
		[Nullable(2)]
		private FARPoseUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C16 RID: 11286
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x0401651A RID: 91418
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C17 RID: 11287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x0401651B RID: 91419
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
