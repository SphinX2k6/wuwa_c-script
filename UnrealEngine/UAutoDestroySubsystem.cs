using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000874 RID: 2164
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AutoDestroySubsystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAutoDestroySubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600759E RID: 30110 RVA: 0x000A8A07 File Offset: 0x000A6C07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAutoDestroySubsystem._ClassPtr;
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x000A8A14 File Offset: 0x000A6C14
		public UAutoDestroySubsystem() : this(BuiltinUtils.AllocNativeUObject(UAutoDestroySubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x000A8A3C File Offset: 0x000A6C3C
		public UAutoDestroySubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAutoDestroySubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060075A1 RID: 30113 RVA: 0x000A8A70 File Offset: 0x000A6C70
		// (set) Token: 0x060075A2 RID: 30114 RVA: 0x000A8AA9 File Offset: 0x000A6CA9
		public TArray<AActor> ActorsToPoll
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorsToPoll) == null)
				{
					result = (this._ActorsToPoll = new TArray<AActor>(base.NativePtr + (IntPtr)UAutoDestroySubsystem.__PropertyOffset_ActorsToPoll, this));
				}
				return result;
			}
			set
			{
				this.ActorsToPoll.CopyAssign(value);
			}
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x000A8AB8 File Offset: 0x000A6CB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnActorEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			UAutoDestroySubsystem.__OnActorEndPlay_FunctionParams* ptr = stackalloc UAutoDestroySubsystem.__OnActorEndPlay_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAutoDestroySubsystem.__OnActorEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAutoDestroySubsystem.__OnActorEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAutoDestroySubsystem.__OnActorEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x000A8B1A File Offset: 0x000A6D1A
		static UAutoDestroySubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AutoDestroySubsystem");
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x000A8B28 File Offset: 0x000A6D28
		protected UAutoDestroySubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003892 RID: 14482
		public new const string __ObjectPath = "/Script/Engine.AutoDestroySubsystem";

		// Token: 0x04003893 RID: 14483
		private static IntPtr _ClassPtr;

		// Token: 0x04003894 RID: 14484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003895 RID: 14485
		internal static int __PropertyOffset_ActorsToPoll;

		// Token: 0x04003896 RID: 14486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorsToPoll;

		// Token: 0x04003897 RID: 14487
		private static IntPtr __OnActorEndPlay_NativeFunctionPtr;

		// Token: 0x02002C96 RID: 11414
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnActorEndPlay_FunctionParams
		{
			// Token: 0x040165ED RID: 91629
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040165EE RID: 91630
			[FieldOffset(8)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
