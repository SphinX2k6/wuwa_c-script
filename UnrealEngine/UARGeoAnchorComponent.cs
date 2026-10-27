using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A5 RID: 933
	[UnrealObjectPath("/Script/AugmentedReality.ARGeoAnchorComponent")]
	[UnrealStructLayout(816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UARGeoAnchorComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033BF RID: 13247 RVA: 0x0004F20A File Offset: 0x0004D40A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARGeoAnchorComponent._ClassPtr;
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x0004F218 File Offset: 0x0004D418
		public UARGeoAnchorComponent() : this(BuiltinUtils.AllocNativeUObject(UARGeoAnchorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x0004F240 File Offset: 0x0004D440
		[NullableContext(1)]
		public UARGeoAnchorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARGeoAnchorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x0004F274 File Offset: 0x0004D474
		// (set) Token: 0x060033C3 RID: 13251 RVA: 0x0004F2AD File Offset: 0x0004D4AD
		[Nullable(1)]
		public FARGeoAnchorUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARGeoAnchorUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARGeoAnchorUpdatePayload(base.NativePtr + (IntPtr)UARGeoAnchorComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARGeoAnchorUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARGeoAnchorComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060033C4 RID: 13252
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGeoAnchorComponentDebugMode(EGeoAnchorComponentDebugMode NewDebugMode);

		// Token: 0x060033C5 RID: 13253 RVA: 0x0004F2CE File Offset: 0x0004D4CE
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARGeoAnchorUpdatePayload NewPayload)
		{
			UARGeoAnchorComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARGeoAnchorUpdatePayload()).NativePtr);
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x0004F2EB File Offset: 0x0004D4EB
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARGeoAnchorUpdatePayload Payload)
		{
			UARGeoAnchorComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARGeoAnchorUpdatePayload()).NativePtr);
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0004F308 File Offset: 0x0004D508
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARGeoAnchorUpdatePayload Payload)
		{
			UARGeoAnchorComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARGeoAnchorUpdatePayload()).NativePtr);
		}

		// Token: 0x060033C8 RID: 13256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x060033C9 RID: 13257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x060033CA RID: 13258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x060033CB RID: 13259 RVA: 0x0004F325 File Offset: 0x0004D525
		static UARGeoAnchorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARGeoAnchorComponent");
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x0004F333 File Offset: 0x0004D533
		protected UARGeoAnchorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001676 RID: 5750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARGeoAnchorComponent";

		// Token: 0x04001677 RID: 5751
		private static IntPtr _ClassPtr;

		// Token: 0x04001678 RID: 5752
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001679 RID: 5753
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x0400167A RID: 5754
		[Nullable(2)]
		private FARGeoAnchorUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C07 RID: 11271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016508 RID: 91400
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C08 RID: 11272
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016509 RID: 91401
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
