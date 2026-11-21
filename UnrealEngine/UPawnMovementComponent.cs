using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025B RID: 603
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PawnMovementComponent")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public abstract class UPawnMovementComponent : UNavMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003394 RID: 13204 RVA: 0x00049C8C File Offset: 0x00047E8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnMovementComponent._ClassPtr;
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x00049C98 File Offset: 0x00047E98
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x00049CAC File Offset: 0x00047EAC
		public unsafe APawn PawnOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnMovementComponent.__PropertyOffset_PawnOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnMovementComponent.__PropertyOffset_PawnOwner, value);
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00049CC1 File Offset: 0x00047EC1
		public FVector K2_GetInputVector()
		{
			return UPawnMovementComponent.__K2_GetInputVector_Internal(base.NativePtr);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00049CCE File Offset: 0x00047ECE
		public bool IsMoveInputIgnored()
		{
			return UPawnMovementComponent.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00049CDB File Offset: 0x00047EDB
		public FVector GetPendingInputVector()
		{
			return UPawnMovementComponent.__GetPendingInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00049CE8 File Offset: 0x00047EE8
		public APawn GetPawnOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UPawnMovementComponent.__GetPawnOwner_Internal(base.NativePtr));
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00049CFA File Offset: 0x00047EFA
		public FVector GetLastInputVector()
		{
			return UPawnMovementComponent.__GetLastInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00049D07 File Offset: 0x00047F07
		public FVector ConsumeInputVector()
		{
			return UPawnMovementComponent.__ConsumeInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00049D14 File Offset: 0x00047F14
		public void AddInputVector(FVector WorldVector, bool bForce = false)
		{
			UPawnMovementComponent.__AddInputVector_Internal(base.NativePtr, WorldVector, bForce);
		}

		// Token: 0x0600339E RID: 13214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetInputVector_Internal(IntPtr @this);

		// Token: 0x0600339F RID: 13215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x060033A0 RID: 13216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPendingInputVector_Internal(IntPtr @this);

		// Token: 0x060033A1 RID: 13217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPawnOwner_Internal(IntPtr @this);

		// Token: 0x060033A2 RID: 13218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastInputVector_Internal(IntPtr @this);

		// Token: 0x060033A3 RID: 13219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConsumeInputVector_Internal(IntPtr @this);

		// Token: 0x060033A4 RID: 13220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInputVector_Internal(IntPtr @this, FVector WorldVector, bool bForce);

		// Token: 0x060033A5 RID: 13221 RVA: 0x00049D23 File Offset: 0x00047F23
		static UPawnMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PawnMovementComponent");
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00049D34 File Offset: 0x00047F34
		protected UPawnMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UPawnMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00049D5C File Offset: 0x00047F5C
		protected UPawnMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011ED RID: 4589
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PawnMovementComponent";

		// Token: 0x040011EE RID: 4590
		private static IntPtr _ClassPtr;

		// Token: 0x040011EF RID: 4591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040011F0 RID: 4592
		internal static int __PropertyOffset_PawnOwner;
	}
}
