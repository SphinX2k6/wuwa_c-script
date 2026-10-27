using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F7 RID: 6391
	[UnrealObjectPath("/Script/KuroGameplay.KuroLockAxisCollisionComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UKuroLockAxisCollisionComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017B4C RID: 97100 RVA: 0x0022BDA2 File Offset: 0x00229FA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLockAxisCollisionComponent._ClassPtr;
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x0022BDB0 File Offset: 0x00229FB0
		public UKuroLockAxisCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLockAxisCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017B4E RID: 97102 RVA: 0x0022BDD8 File Offset: 0x00229FD8
		[NullableContext(1)]
		public UKuroLockAxisCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLockAxisCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x06017B4F RID: 97103 RVA: 0x0022BE0B File Offset: 0x0022A00B
		// (set) Token: 0x06017B50 RID: 97104 RVA: 0x0022BE1F File Offset: 0x0022A01F
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLockAxisCollisionComponent.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLockAxisCollisionComponent.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x06017B51 RID: 97105 RVA: 0x0022BE34 File Offset: 0x0022A034
		// (set) Token: 0x06017B52 RID: 97106 RVA: 0x0022BE44 File Offset: 0x0022A044
		public unsafe ELockAxis LockAxis
		{
			get
			{
				return (ELockAxis)(*(base.NativePtr + (IntPtr)UKuroLockAxisCollisionComponent.__PropertyOffset_LockAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLockAxisCollisionComponent.__PropertyOffset_LockAxis) = (byte)value;
			}
		}

		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x06017B53 RID: 97107 RVA: 0x0022BE55 File Offset: 0x0022A055
		// (set) Token: 0x06017B54 RID: 97108 RVA: 0x0022BE65 File Offset: 0x0022A065
		public unsafe float AxisValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLockAxisCollisionComponent.__PropertyOffset_AxisValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLockAxisCollisionComponent.__PropertyOffset_AxisValue) = value;
			}
		}

		// Token: 0x06017B55 RID: 97109 RVA: 0x0022BE76 File Offset: 0x0022A076
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UpdateCollisionTransform()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroLockAxisCollisionComponent.__UpdateCollisionTransform_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017B56 RID: 97110 RVA: 0x0022BE8C File Offset: 0x0022A08C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetLockAxis(ELockAxis InLockAxis)
		{
			UKuroLockAxisCollisionComponent.__SetLockAxis_FunctionParams* ptr = stackalloc UKuroLockAxisCollisionComponent.__SetLockAxis_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroLockAxisCollisionComponent.__SetLockAxis_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroLockAxisCollisionComponent.__SetLockAxis_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InLockAxis = InLockAxis;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroLockAxisCollisionComponent.__SetLockAxis_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017B57 RID: 97111 RVA: 0x0022BED4 File Offset: 0x0022A0D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAxisValue(float InAxisValue)
		{
			UKuroLockAxisCollisionComponent.__SetAxisValue_FunctionParams* ptr = stackalloc UKuroLockAxisCollisionComponent.__SetAxisValue_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroLockAxisCollisionComponent.__SetAxisValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroLockAxisCollisionComponent.__SetAxisValue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InAxisValue = InAxisValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroLockAxisCollisionComponent.__SetAxisValue_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017B58 RID: 97112 RVA: 0x0022BF1B File Offset: 0x0022A11B
		static UKuroLockAxisCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLockAxisCollisionComponent");
		}

		// Token: 0x06017B59 RID: 97113 RVA: 0x0022BF29 File Offset: 0x0022A129
		protected UKuroLockAxisCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDED RID: 52717
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLockAxisCollisionComponent";

		// Token: 0x0400CDEE RID: 52718
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDEF RID: 52719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDF0 RID: 52720
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400CDF1 RID: 52721
		internal static int __PropertyOffset_LockAxis;

		// Token: 0x0400CDF2 RID: 52722
		internal static int __PropertyOffset_AxisValue;

		// Token: 0x0400CDF3 RID: 52723
		private static IntPtr __UpdateCollisionTransform_NativeFunctionPtr;

		// Token: 0x0400CDF4 RID: 52724
		private static IntPtr __SetLockAxis_NativeFunctionPtr;

		// Token: 0x0400CDF5 RID: 52725
		private static IntPtr __SetAxisValue_NativeFunctionPtr;

		// Token: 0x02002FD7 RID: 12247
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetLockAxis_FunctionParams
		{
			// Token: 0x04016BC7 RID: 93127
			[FieldOffset(0)]
			public ELockAxis InLockAxis;
		}

		// Token: 0x02002FD8 RID: 12248
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAxisValue_FunctionParams
		{
			// Token: 0x04016BC8 RID: 93128
			[FieldOffset(0)]
			public float InAxisValue;
		}
	}
}
