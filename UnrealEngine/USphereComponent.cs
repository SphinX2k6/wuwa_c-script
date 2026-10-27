using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001173 RID: 4467
	[UnrealObjectPath("/Script/Engine.SphereComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class USphereComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010517 RID: 66839 RVA: 0x001809EB File Offset: 0x0017EBEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USphereComponent._ClassPtr;
		}

		// Token: 0x06010518 RID: 66840 RVA: 0x001809F8 File Offset: 0x0017EBF8
		public USphereComponent() : this(BuiltinUtils.AllocNativeUObject(USphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010519 RID: 66841 RVA: 0x00180A20 File Offset: 0x0017EC20
		[NullableContext(1)]
		public USphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x0601051A RID: 66842 RVA: 0x00180A53 File Offset: 0x0017EC53
		// (set) Token: 0x0601051B RID: 66843 RVA: 0x00180A63 File Offset: 0x0017EC63
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

		// Token: 0x0601051C RID: 66844 RVA: 0x00180A74 File Offset: 0x0017EC74
		public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
		{
			USphereComponent.__SetSphereRadius_Internal(base.NativePtr, InSphereRadius, bUpdateOverlaps);
		}

		// Token: 0x0601051D RID: 66845 RVA: 0x00180A83 File Offset: 0x0017EC83
		public float GetUnscaledSphereRadius()
		{
			return USphereComponent.__GetUnscaledSphereRadius_Internal(base.NativePtr);
		}

		// Token: 0x0601051E RID: 66846 RVA: 0x00180A90 File Offset: 0x0017EC90
		public float GetShapeScale()
		{
			return USphereComponent.__GetShapeScale_Internal(base.NativePtr);
		}

		// Token: 0x0601051F RID: 66847 RVA: 0x00180A9D File Offset: 0x0017EC9D
		public float GetScaledSphereRadius()
		{
			return USphereComponent.__GetScaledSphereRadius_Internal(base.NativePtr);
		}

		// Token: 0x06010520 RID: 66848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSphereRadius_Internal(IntPtr @this, float InSphereRadius, bool bUpdateOverlaps);

		// Token: 0x06010521 RID: 66849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledSphereRadius_Internal(IntPtr @this);

		// Token: 0x06010522 RID: 66850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetShapeScale_Internal(IntPtr @this);

		// Token: 0x06010523 RID: 66851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledSphereRadius_Internal(IntPtr @this);

		// Token: 0x06010524 RID: 66852 RVA: 0x00180AAA File Offset: 0x0017ECAA
		static USphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SphereComponent");
		}

		// Token: 0x06010525 RID: 66853 RVA: 0x00180AB8 File Offset: 0x0017ECB8
		protected USphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C6D RID: 35949
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SphereComponent";

		// Token: 0x04008C6E RID: 35950
		private static IntPtr _ClassPtr;

		// Token: 0x04008C6F RID: 35951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C70 RID: 35952
		internal static int __PropertyOffset_SphereRadius;
	}
}
