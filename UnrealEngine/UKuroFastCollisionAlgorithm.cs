using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200182F RID: 6191
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroFastCollisionAlgorithm : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016D4B RID: 93515 RVA: 0x0021552F File Offset: 0x0021372F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm._ClassPtr;
		}

		// Token: 0x06016D4C RID: 93516 RVA: 0x0021553C File Offset: 0x0021373C
		public UKuroFastCollisionAlgorithm() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016D4D RID: 93517 RVA: 0x00215564 File Offset: 0x00213764
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016D4E RID: 93518 RVA: 0x00215597 File Offset: 0x00213797
		[NullableContext(2)]
		public void SetAgentChannelAndMask(UObject Agent, ECollisionChannel NewChannel, int NewQueryMask)
		{
			UKuroFastCollisionAlgorithm.__SetAgentChannelAndMask_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero, NewChannel, NewQueryMask);
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x002155BB File Offset: 0x002137BB
		[NullableContext(2)]
		public void Remove(UObject Agent)
		{
			UKuroFastCollisionAlgorithm.__Remove_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x002155D8 File Offset: 0x002137D8
		[NullableContext(2)]
		public void GetOverlappingAgents(UObject Agent, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OverlappingAgents)
		{
			UKuroFastCollisionAlgorithm.__GetOverlappingAgents_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero, (OverlappingAgents ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x00215605 File Offset: 0x00213805
		public void Clear()
		{
			UKuroFastCollisionAlgorithm.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06016D52 RID: 93522 RVA: 0x00215612 File Offset: 0x00213812
		[NullableContext(2)]
		public void Add(UObject Agent)
		{
			UKuroFastCollisionAlgorithm.__Add_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016D53 RID: 93523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAgentChannelAndMask_Internal(IntPtr @this, IntPtr Agent, TEnumAsByte<ECollisionChannel> NewChannel, int NewQueryMask);

		// Token: 0x06016D54 RID: 93524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Remove_Internal(IntPtr @this, IntPtr Agent);

		// Token: 0x06016D55 RID: 93525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingAgents_Internal(IntPtr @this, IntPtr Agent, IntPtr OverlappingAgents);

		// Token: 0x06016D56 RID: 93526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06016D57 RID: 93527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Add_Internal(IntPtr @this, IntPtr Agent);

		// Token: 0x06016D58 RID: 93528 RVA: 0x0021562F File Offset: 0x0021382F
		static UKuroFastCollisionAlgorithm()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm");
		}

		// Token: 0x06016D59 RID: 93529 RVA: 0x0021563D File Offset: 0x0021383D
		protected UKuroFastCollisionAlgorithm(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C69B RID: 50843
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm";

		// Token: 0x0400C69C RID: 50844
		private static IntPtr _ClassPtr;

		// Token: 0x0400C69D RID: 50845
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
