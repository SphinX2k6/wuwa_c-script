using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F46 RID: 3910
	[UnrealObjectPath("/Script/Engine.ParticleEmitterReplayFrame")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FParticleEmitterReplayFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D2EB RID: 53995 RVA: 0x001352ED File Offset: 0x001334ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleEmitterReplayFrame._ScriptStructPtr != 0) ? FParticleEmitterReplayFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleEmitterReplayFrame", ref FParticleEmitterReplayFrame._ScriptStructPtr);
		}

		// Token: 0x0600D2EC RID: 53996 RVA: 0x00135311 File Offset: 0x00133511
		public FParticleEmitterReplayFrame()
		{
		}

		// Token: 0x0600D2ED RID: 53997 RVA: 0x00135319 File Offset: 0x00133519
		protected override IntPtr GetUStructPtr()
		{
			return FParticleEmitterReplayFrame.StaticStruct();
		}

		// Token: 0x0600D2EE RID: 53998 RVA: 0x00135325 File Offset: 0x00133525
		[NullableContext(2)]
		public FParticleEmitterReplayFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D2EF RID: 53999 RVA: 0x0013532F File Offset: 0x0013352F
		public FParticleEmitterReplayFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D2F0 RID: 54000 RVA: 0x0013533A File Offset: 0x0013353A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleEmitterReplayFrame(Pointer, false, true);
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x00135344 File Offset: 0x00133544
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleEmitterReplayFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04007127 RID: 28967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleEmitterReplayFrame";

		// Token: 0x04007128 RID: 28968
		private static IntPtr _ScriptStructPtr;
	}
}
