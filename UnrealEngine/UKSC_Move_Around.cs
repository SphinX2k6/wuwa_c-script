using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000580 RID: 1408
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Around")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UKSC_Move_Around : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FE0 RID: 32736 RVA: 0x000BD14B File Offset: 0x000BB34B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Around._ClassPtr;
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x000BD158 File Offset: 0x000BB358
		public UKSC_Move_Around() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Around.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x000BD180 File Offset: 0x000BB380
		[NullableContext(1)]
		public UKSC_Move_Around(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Around.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x000BD1B3 File Offset: 0x000BB3B3
		public void SetIndexInfo(int InTotalCount, int InAroundIndex)
		{
			UKSC_Move_Around.__SetIndexInfo_Internal(base.NativePtr, InTotalCount, InAroundIndex);
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x000BD1C4 File Offset: 0x000BB3C4
		public void SetBasis(in FVector? InBasisX = null, in FVector? InBasisY = null, in FVector? InBasisZ = null)
		{
			IntPtr nativePtr = base.NativePtr;
			FVector fvector = InBasisX ?? new FVector(1f, 0f, 0f);
			FVector fvector2 = InBasisY ?? new FVector(0f, 1f, 0f);
			FVector fvector3 = InBasisZ ?? new FVector(0f, 0f, 1f);
			UKSC_Move_Around.__SetBasis_Internal(nativePtr, fvector, fvector2, fvector3);
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x000BD26E File Offset: 0x000BB46E
		[NullableContext(2)]
		public void SetAroundTarget(AKSC_Entity InTargetEntity)
		{
			UKSC_Move_Around.__SetAroundTarget_Internal(base.NativePtr, (InTargetEntity != null) ? InTargetEntity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007FE6 RID: 32742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndexInfo_Internal(IntPtr @this, int InTotalCount, int InAroundIndex);

		// Token: 0x06007FE7 RID: 32743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBasis_Internal(IntPtr @this, in FVector InBasisX, in FVector InBasisY, in FVector InBasisZ);

		// Token: 0x06007FE8 RID: 32744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAroundTarget_Internal(IntPtr @this, IntPtr InTargetEntity);

		// Token: 0x06007FE9 RID: 32745 RVA: 0x000BD28B File Offset: 0x000BB48B
		static UKSC_Move_Around()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Around");
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x000BD299 File Offset: 0x000BB499
		protected UKSC_Move_Around(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037D9 RID: 14297
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Around";

		// Token: 0x040037DA RID: 14298
		private static IntPtr _ClassPtr;

		// Token: 0x040037DB RID: 14299
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
