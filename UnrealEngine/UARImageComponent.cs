using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AA RID: 938
	[UnrealObjectPath("/Script/AugmentedReality.ARImageComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UARImageComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003407 RID: 13319 RVA: 0x0004F8F9 File Offset: 0x0004DAF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARImageComponent._ClassPtr;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x0004F908 File Offset: 0x0004DB08
		public UARImageComponent() : this(BuiltinUtils.AllocNativeUObject(UARImageComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x0004F930 File Offset: 0x0004DB30
		[NullableContext(1)]
		public UARImageComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARImageComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x0004F964 File Offset: 0x0004DB64
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x0004F99D File Offset: 0x0004DB9D
		[Nullable(1)]
		public FARImageUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARImageUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARImageUpdatePayload(base.NativePtr + (IntPtr)UARImageComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARImageUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARImageComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600340C RID: 13324
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetImageComponentDebugMode(EImageComponentDebugMode NewDebugMode);

		// Token: 0x0600340D RID: 13325 RVA: 0x0004F9BE File Offset: 0x0004DBBE
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARImageUpdatePayload NewPayload)
		{
			UARImageComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARImageUpdatePayload()).NativePtr);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x0004F9DB File Offset: 0x0004DBDB
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARImageUpdatePayload Payload)
		{
			UARImageComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARImageUpdatePayload()).NativePtr);
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARImageUpdatePayload Payload)
		{
			UARImageComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARImageUpdatePayload()).NativePtr);
		}

		// Token: 0x06003410 RID: 13328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003411 RID: 13329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003412 RID: 13330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003413 RID: 13331 RVA: 0x0004FA15 File Offset: 0x0004DC15
		static UARImageComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARImageComponent");
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x0004FA23 File Offset: 0x0004DC23
		protected UARImageComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001693 RID: 5779
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARImageComponent";

		// Token: 0x04001694 RID: 5780
		private static IntPtr _ClassPtr;

		// Token: 0x04001695 RID: 5781
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001696 RID: 5782
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x04001697 RID: 5783
		[Nullable(2)]
		private FARImageUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C0C RID: 11276
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016510 RID: 91408
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C0D RID: 11277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016511 RID: 91409
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
