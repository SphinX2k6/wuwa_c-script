using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FC9 RID: 4041
	[UnrealObjectPath("/Script/Engine.ParticleSystemReplayFrame")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FParticleSystemReplayFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DA0A RID: 55818 RVA: 0x00141D83 File Offset: 0x0013FF83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleSystemReplayFrame._ScriptStructPtr != 0) ? FParticleSystemReplayFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleSystemReplayFrame", ref FParticleSystemReplayFrame._ScriptStructPtr);
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x00141DA7 File Offset: 0x0013FFA7
		public FParticleSystemReplayFrame()
		{
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x00141DAF File Offset: 0x0013FFAF
		protected override IntPtr GetUStructPtr()
		{
			return FParticleSystemReplayFrame.StaticStruct();
		}

		// Token: 0x0600DA0D RID: 55821 RVA: 0x00141DBB File Offset: 0x0013FFBB
		[NullableContext(2)]
		public FParticleSystemReplayFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DA0E RID: 55822 RVA: 0x00141DC5 File Offset: 0x0013FFC5
		public FParticleSystemReplayFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x00141DD0 File Offset: 0x0013FFD0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleSystemReplayFrame(Pointer, false, true);
		}

		// Token: 0x0600DA10 RID: 55824 RVA: 0x00141DDA File Offset: 0x0013FFDA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleSystemReplayFrame(Pointer, MemoryOwner);
		}

		// Token: 0x0400763B RID: 30267
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleSystemReplayFrame";

		// Token: 0x0400763C RID: 30268
		private static IntPtr _ScriptStructPtr;
	}
}
