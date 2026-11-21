using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037D RID: 893
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionAlgorithm")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroFastCollisionAlgorithm : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060059FB RID: 23035 RVA: 0x0007F2E0 File Offset: 0x0007D4E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionAlgorithm._ClassPtr;
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x0007F2EC File Offset: 0x0007D4EC
		public UKuroFastCollisionAlgorithm() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x0007F314 File Offset: 0x0007D514
		[NullableContext(1)]
		public UKuroFastCollisionAlgorithm(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionAlgorithm.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x0007F347 File Offset: 0x0007D547
		[NullableContext(2)]
		public void SetAgentChannelAndMask(UObject Agent, ECollisionChannel NewChannel, int NewQueryMask)
		{
			UKuroFastCollisionAlgorithm.__SetAgentChannelAndMask_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero, NewChannel, NewQueryMask);
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0007F36B File Offset: 0x0007D56B
		[NullableContext(2)]
		public void Remove(UObject Agent)
		{
			UKuroFastCollisionAlgorithm.__Remove_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x0007F388 File Offset: 0x0007D588
		[NullableContext(2)]
		public void GetOverlappingAgents(UObject Agent, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OverlappingAgents)
		{
			UKuroFastCollisionAlgorithm.__GetOverlappingAgents_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero, (OverlappingAgents ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0007F3B5 File Offset: 0x0007D5B5
		public void Clear()
		{
			UKuroFastCollisionAlgorithm.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x0007F3C2 File Offset: 0x0007D5C2
		[NullableContext(2)]
		public void Add(UObject Agent)
		{
			UKuroFastCollisionAlgorithm.__Add_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005A03 RID: 23043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAgentChannelAndMask_Internal(IntPtr @this, IntPtr Agent, TEnumAsByte<ECollisionChannel> NewChannel, int NewQueryMask);

		// Token: 0x06005A04 RID: 23044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Remove_Internal(IntPtr @this, IntPtr Agent);

		// Token: 0x06005A05 RID: 23045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingAgents_Internal(IntPtr @this, IntPtr Agent, IntPtr OverlappingAgents);

		// Token: 0x06005A06 RID: 23046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06005A07 RID: 23047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Add_Internal(IntPtr @this, IntPtr Agent);

		// Token: 0x06005A08 RID: 23048 RVA: 0x0007F3DF File Offset: 0x0007D5DF
		static UKuroFastCollisionAlgorithm()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionAlgorithm");
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x0007F3ED File Offset: 0x0007D5ED
		protected UKuroFastCollisionAlgorithm(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002560 RID: 9568
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionAlgorithm";

		// Token: 0x04002561 RID: 9569
		private static IntPtr _ClassPtr;

		// Token: 0x04002562 RID: 9570
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
