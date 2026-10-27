using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A9 RID: 4265
	[UnrealObjectPath("/Script/Engine.RotatingMovementComponent")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class URotatingMovementComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F3DE RID: 62430 RVA: 0x00169B21 File Offset: 0x00167D21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URotatingMovementComponent._ClassPtr;
		}

		// Token: 0x0600F3DF RID: 62431 RVA: 0x00169B30 File Offset: 0x00167D30
		public URotatingMovementComponent() : this(BuiltinUtils.AllocNativeUObject(URotatingMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00169B58 File Offset: 0x00167D58
		[NullableContext(1)]
		public URotatingMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URotatingMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x0600F3E1 RID: 62433 RVA: 0x00169B8B File Offset: 0x00167D8B
		// (set) Token: 0x0600F3E2 RID: 62434 RVA: 0x00169B9F File Offset: 0x00167D9F
		public unsafe FRotator RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x0600F3E3 RID: 62435 RVA: 0x00169BB4 File Offset: 0x00167DB4
		// (set) Token: 0x0600F3E4 RID: 62436 RVA: 0x00169BC8 File Offset: 0x00167DC8
		public unsafe FVector PivotTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_PivotTranslation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_PivotTranslation) = value;
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600F3E5 RID: 62437 RVA: 0x00169BDD File Offset: 0x00167DDD
		// (set) Token: 0x0600F3E6 RID: 62438 RVA: 0x00169BF6 File Offset: 0x00167DF6
		public unsafe bool bRotationInLocalSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_bRotationInLocalSpace) & URotatingMovementComponent.__PropertyMask_bRotationInLocalSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_bRotationInLocalSpace) = ((*(base.NativePtr + (IntPtr)URotatingMovementComponent.__PropertyOffset_bRotationInLocalSpace) & ~URotatingMovementComponent.__PropertyMask_bRotationInLocalSpace) | (value ? URotatingMovementComponent.__PropertyMask_bRotationInLocalSpace : 0));
			}
		}

		// Token: 0x0600F3E7 RID: 62439 RVA: 0x00169C26 File Offset: 0x00167E26
		static URotatingMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RotatingMovementComponent");
		}

		// Token: 0x0600F3E8 RID: 62440 RVA: 0x00169C34 File Offset: 0x00167E34
		protected URotatingMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400842E RID: 33838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RotatingMovementComponent";

		// Token: 0x0400842F RID: 33839
		private static IntPtr _ClassPtr;

		// Token: 0x04008430 RID: 33840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008431 RID: 33841
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x04008432 RID: 33842
		internal static int __PropertyOffset_PivotTranslation;

		// Token: 0x04008433 RID: 33843
		internal static int __PropertyOffset_bRotationInLocalSpace;

		// Token: 0x04008434 RID: 33844
		internal static byte __PropertyMask_bRotationInLocalSpace;
	}
}
