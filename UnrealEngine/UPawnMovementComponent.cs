using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FD0 RID: 4048
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PawnMovementComponent")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public abstract class UPawnMovementComponent : UNavMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DAAA RID: 55978 RVA: 0x00142726 File Offset: 0x00140926
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnMovementComponent._ClassPtr;
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x00142732 File Offset: 0x00140932
		// (set) Token: 0x0600DAAC RID: 55980 RVA: 0x00142746 File Offset: 0x00140946
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

		// Token: 0x0600DAAD RID: 55981 RVA: 0x0014275B File Offset: 0x0014095B
		public FVector K2_GetInputVector()
		{
			return UPawnMovementComponent.__K2_GetInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00142768 File Offset: 0x00140968
		public bool IsMoveInputIgnored()
		{
			return UPawnMovementComponent.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00142775 File Offset: 0x00140975
		public FVector GetPendingInputVector()
		{
			return UPawnMovementComponent.__GetPendingInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00142782 File Offset: 0x00140982
		public APawn GetPawnOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UPawnMovementComponent.__GetPawnOwner_Internal(base.NativePtr));
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x00142794 File Offset: 0x00140994
		public FVector GetLastInputVector()
		{
			return UPawnMovementComponent.__GetLastInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x001427A1 File Offset: 0x001409A1
		public FVector ConsumeInputVector()
		{
			return UPawnMovementComponent.__ConsumeInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DAB3 RID: 55987 RVA: 0x001427AE File Offset: 0x001409AE
		public void AddInputVector(FVector WorldVector, bool bForce = false)
		{
			UPawnMovementComponent.__AddInputVector_Internal(base.NativePtr, WorldVector, bForce);
		}

		// Token: 0x0600DAB4 RID: 55988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetInputVector_Internal(IntPtr @this);

		// Token: 0x0600DAB5 RID: 55989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x0600DAB6 RID: 55990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPendingInputVector_Internal(IntPtr @this);

		// Token: 0x0600DAB7 RID: 55991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPawnOwner_Internal(IntPtr @this);

		// Token: 0x0600DAB8 RID: 55992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastInputVector_Internal(IntPtr @this);

		// Token: 0x0600DAB9 RID: 55993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConsumeInputVector_Internal(IntPtr @this);

		// Token: 0x0600DABA RID: 55994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInputVector_Internal(IntPtr @this, FVector WorldVector, bool bForce);

		// Token: 0x0600DABB RID: 55995 RVA: 0x001427BD File Offset: 0x001409BD
		static UPawnMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PawnMovementComponent");
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x001427CC File Offset: 0x001409CC
		protected UPawnMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UPawnMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x001427F4 File Offset: 0x001409F4
		protected UPawnMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400766C RID: 30316
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PawnMovementComponent";

		// Token: 0x0400766D RID: 30317
		private static IntPtr _ClassPtr;

		// Token: 0x0400766E RID: 30318
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400766F RID: 30319
		internal static int __PropertyOffset_PawnOwner;
	}
}
