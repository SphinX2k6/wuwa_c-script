using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B5 RID: 949
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPlaneComponent")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UARPlaneComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003496 RID: 13462 RVA: 0x00050536 File Offset: 0x0004E736
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARPlaneComponent._ClassPtr;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00050544 File Offset: 0x0004E744
		public UARPlaneComponent() : this(BuiltinUtils.AllocNativeUObject(UARPlaneComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x0005056C File Offset: 0x0004E76C
		public UARPlaneComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARPlaneComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000505A0 File Offset: 0x0004E7A0
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x000505D9 File Offset: 0x0004E7D9
		public FARPlaneUpdatePayload ReplicatedPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARPlaneUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARPlaneUpdatePayload(base.NativePtr + (IntPtr)UARPlaneComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARPlaneUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARPlaneComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600349B RID: 13467
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPlaneComponentDebugMode(EPlaneComponentDebugMode NewDebugMode);

		// Token: 0x0600349C RID: 13468 RVA: 0x000505FA File Offset: 0x0004E7FA
		[NullableContext(2)]
		public static void SetObjectClassificationDebugColors(in TMap<EARObjectClassification, FLinearColor> InColors)
		{
			UARPlaneComponent.__SetObjectClassificationDebugColors_Internal((InColors ?? new TMap<EARObjectClassification, FLinearColor>()).NativeMapPtr);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00050611 File Offset: 0x0004E811
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARPlaneUpdatePayload NewPayload)
		{
			UARPlaneComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARPlaneUpdatePayload()).NativePtr);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x0005062E File Offset: 0x0004E82E
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARPlaneUpdatePayload Payload)
		{
			UARPlaneComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARPlaneUpdatePayload()).NativePtr);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x0005064B File Offset: 0x0004E84B
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARPlaneUpdatePayload Payload)
		{
			UARPlaneComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARPlaneUpdatePayload()).NativePtr);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00050668 File Offset: 0x0004E868
		public static TMap<EARObjectClassification, FLinearColor> GetObjectClassificationDebugColors()
		{
			return new TMap<EARObjectClassification, FLinearColor>(UARPlaneComponent.__GetObjectClassificationDebugColors_Internal(), null);
		}

		// Token: 0x060034A1 RID: 13473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetObjectClassificationDebugColors_Internal(IntPtr InColors);

		// Token: 0x060034A2 RID: 13474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x060034A3 RID: 13475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x060034A4 RID: 13476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x060034A5 RID: 13477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectClassificationDebugColors_Internal();

		// Token: 0x060034A6 RID: 13478 RVA: 0x00050675 File Offset: 0x0004E875
		static UARPlaneComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARPlaneComponent");
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00050683 File Offset: 0x0004E883
		protected UARPlaneComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016D0 RID: 5840
		public new const string __ObjectPath = "/Script/AugmentedReality.ARPlaneComponent";

		// Token: 0x040016D1 RID: 5841
		private static IntPtr _ClassPtr;

		// Token: 0x040016D2 RID: 5842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016D3 RID: 5843
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x040016D4 RID: 5844
		[Nullable(2)]
		private FARPlaneUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C12 RID: 11282
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016516 RID: 91414
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C13 RID: 11283
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016517 RID: 91415
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
