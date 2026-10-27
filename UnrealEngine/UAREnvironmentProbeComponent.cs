using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039F RID: 927
	[UnrealObjectPath("/Script/AugmentedReality.AREnvironmentProbeComponent")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UAREnvironmentProbeComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003360 RID: 13152 RVA: 0x0004EAF1 File Offset: 0x0004CCF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAREnvironmentProbeComponent._ClassPtr;
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x0004EB00 File Offset: 0x0004CD00
		public UAREnvironmentProbeComponent() : this(BuiltinUtils.AllocNativeUObject(UAREnvironmentProbeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x0004EB28 File Offset: 0x0004CD28
		[NullableContext(1)]
		public UAREnvironmentProbeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAREnvironmentProbeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x0004EB5C File Offset: 0x0004CD5C
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x0004EB95 File Offset: 0x0004CD95
		[Nullable(1)]
		public FAREnvironmentProbeUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAREnvironmentProbeUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FAREnvironmentProbeUpdatePayload(base.NativePtr + (IntPtr)UAREnvironmentProbeComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAREnvironmentProbeUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UAREnvironmentProbeComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x0004EBB6 File Offset: 0x0004CDB6
		[NullableContext(2)]
		public void ServerUpdatePayload(in FAREnvironmentProbeUpdatePayload NewPayload)
		{
			UAREnvironmentProbeComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FAREnvironmentProbeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x0004EBD3 File Offset: 0x0004CDD3
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FAREnvironmentProbeUpdatePayload Payload)
		{
			UAREnvironmentProbeComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FAREnvironmentProbeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0004EBF0 File Offset: 0x0004CDF0
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FAREnvironmentProbeUpdatePayload Payload)
		{
			UAREnvironmentProbeComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FAREnvironmentProbeUpdatePayload()).NativePtr);
		}

		// Token: 0x06003368 RID: 13160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003369 RID: 13161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x0600336A RID: 13162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x0600336B RID: 13163 RVA: 0x0004EC0D File Offset: 0x0004CE0D
		static UAREnvironmentProbeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.AREnvironmentProbeComponent");
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x0004EC1B File Offset: 0x0004CE1B
		protected UAREnvironmentProbeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001653 RID: 5715
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.AREnvironmentProbeComponent";

		// Token: 0x04001654 RID: 5716
		private static IntPtr _ClassPtr;

		// Token: 0x04001655 RID: 5717
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001656 RID: 5718
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x04001657 RID: 5719
		[Nullable(2)]
		private FAREnvironmentProbeUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C03 RID: 11267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016504 RID: 91396
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C04 RID: 11268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016505 RID: 91397
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
