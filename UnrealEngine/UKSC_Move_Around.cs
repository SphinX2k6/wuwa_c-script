using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E03 RID: 7683
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Around")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UKSC_Move_Around : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D581 RID: 120193 RVA: 0x002B51AB File Offset: 0x002B33AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Around._ClassPtr;
		}

		// Token: 0x0601D582 RID: 120194 RVA: 0x002B51B8 File Offset: 0x002B33B8
		public UKSC_Move_Around() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Around.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D583 RID: 120195 RVA: 0x002B51E0 File Offset: 0x002B33E0
		[NullableContext(1)]
		public UKSC_Move_Around(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Around.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D584 RID: 120196 RVA: 0x002B5213 File Offset: 0x002B3413
		public void SetIndexInfo(int InTotalCount, int InAroundIndex)
		{
			UKSC_Move_Around.__SetIndexInfo_Internal(base.NativePtr, InTotalCount, InAroundIndex);
		}

		// Token: 0x0601D585 RID: 120197 RVA: 0x002B5224 File Offset: 0x002B3424
		public void SetBasis(in FVector? InBasisX = null, in FVector? InBasisY = null, in FVector? InBasisZ = null)
		{
			IntPtr nativePtr = base.NativePtr;
			FVector fvector = InBasisX ?? new FVector(1f, 0f, 0f);
			FVector fvector2 = InBasisY ?? new FVector(0f, 1f, 0f);
			FVector fvector3 = InBasisZ ?? new FVector(0f, 0f, 1f);
			UKSC_Move_Around.__SetBasis_Internal(nativePtr, fvector, fvector2, fvector3);
		}

		// Token: 0x0601D586 RID: 120198 RVA: 0x002B52CE File Offset: 0x002B34CE
		[NullableContext(2)]
		public void SetAroundTarget(AKSC_Entity InTargetEntity)
		{
			UKSC_Move_Around.__SetAroundTarget_Internal(base.NativePtr, (InTargetEntity != null) ? InTargetEntity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D587 RID: 120199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndexInfo_Internal(IntPtr @this, int InTotalCount, int InAroundIndex);

		// Token: 0x0601D588 RID: 120200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBasis_Internal(IntPtr @this, in FVector InBasisX, in FVector InBasisY, in FVector InBasisZ);

		// Token: 0x0601D589 RID: 120201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAroundTarget_Internal(IntPtr @this, IntPtr InTargetEntity);

		// Token: 0x0601D58A RID: 120202 RVA: 0x002B52EB File Offset: 0x002B34EB
		static UKSC_Move_Around()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Around");
		}

		// Token: 0x0601D58B RID: 120203 RVA: 0x002B52F9 File Offset: 0x002B34F9
		protected UKSC_Move_Around(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEB0 RID: 65200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Around";

		// Token: 0x0400FEB1 RID: 65201
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEB2 RID: 65202
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
