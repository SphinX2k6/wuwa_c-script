using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000286 RID: 646
	[UnrealObjectPath("/Script/Engine.SphereComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class USphereComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600459C RID: 17820 RVA: 0x0006290C File Offset: 0x00060B0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USphereComponent._ClassPtr;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00062918 File Offset: 0x00060B18
		public USphereComponent() : this(BuiltinUtils.AllocNativeUObject(USphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00062940 File Offset: 0x00060B40
		[NullableContext(1)]
		public USphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x00062973 File Offset: 0x00060B73
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x00062983 File Offset: 0x00060B83
		public unsafe float SphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USphereComponent.__PropertyOffset_SphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USphereComponent.__PropertyOffset_SphereRadius) = value;
			}
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00062994 File Offset: 0x00060B94
		public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
		{
			USphereComponent.__SetSphereRadius_Internal(base.NativePtr, InSphereRadius, bUpdateOverlaps);
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x000629A3 File Offset: 0x00060BA3
		public float GetUnscaledSphereRadius()
		{
			return USphereComponent.__GetUnscaledSphereRadius_Internal(base.NativePtr);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x000629B0 File Offset: 0x00060BB0
		public float GetShapeScale()
		{
			return USphereComponent.__GetShapeScale_Internal(base.NativePtr);
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x000629BD File Offset: 0x00060BBD
		public float GetScaledSphereRadius()
		{
			return USphereComponent.__GetScaledSphereRadius_Internal(base.NativePtr);
		}

		// Token: 0x060045A5 RID: 17829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSphereRadius_Internal(IntPtr @this, float InSphereRadius, bool bUpdateOverlaps);

		// Token: 0x060045A6 RID: 17830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledSphereRadius_Internal(IntPtr @this);

		// Token: 0x060045A7 RID: 17831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetShapeScale_Internal(IntPtr @this);

		// Token: 0x060045A8 RID: 17832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledSphereRadius_Internal(IntPtr @this);

		// Token: 0x060045A9 RID: 17833 RVA: 0x000629CA File Offset: 0x00060BCA
		static USphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SphereComponent");
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x000629D8 File Offset: 0x00060BD8
		protected USphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B3E RID: 6974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SphereComponent";

		// Token: 0x04001B3F RID: 6975
		private static IntPtr _ClassPtr;

		// Token: 0x04001B40 RID: 6976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B41 RID: 6977
		internal static int __PropertyOffset_SphereRadius;
	}
}
