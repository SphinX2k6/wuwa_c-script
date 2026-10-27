using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B32 RID: 6962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceSubsystem")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroLevelSequenceSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A47E RID: 107646 RVA: 0x0026C773 File Offset: 0x0026A973
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelSequenceSubsystem._ClassPtr;
		}

		// Token: 0x0601A47F RID: 107647 RVA: 0x0026C780 File Offset: 0x0026A980
		public UKuroLevelSequenceSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSequenceSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A480 RID: 107648 RVA: 0x0026C7A8 File Offset: 0x0026A9A8
		public UKuroLevelSequenceSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelSequenceSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069AF RID: 27055
		// (get) Token: 0x0601A481 RID: 107649 RVA: 0x0026C7DC File Offset: 0x0026A9DC
		// (set) Token: 0x0601A482 RID: 107650 RVA: 0x0026C815 File Offset: 0x0026AA15
		public FRegisterLevelSequence OnLevelSequenceRegister
		{
			get
			{
				base.FastCheckIsValid();
				FRegisterLevelSequence result;
				if ((result = this._OnLevelSequenceRegister) == null)
				{
					result = (this._OnLevelSequenceRegister = new FRegisterLevelSequence(base.NativePtr + (IntPtr)UKuroLevelSequenceSubsystem.__PropertyOffset_OnLevelSequenceRegister, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelSequenceSubsystem.__PropertyOffset_OnLevelSequenceRegister, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170069B0 RID: 27056
		// (get) Token: 0x0601A483 RID: 107651 RVA: 0x0026C838 File Offset: 0x0026AA38
		// (set) Token: 0x0601A484 RID: 107652 RVA: 0x0026C871 File Offset: 0x0026AA71
		public FUnRegisterLevelSequence OnLevelSequenceUnRegister
		{
			get
			{
				base.FastCheckIsValid();
				FUnRegisterLevelSequence result;
				if ((result = this._OnLevelSequenceUnRegister) == null)
				{
					result = (this._OnLevelSequenceUnRegister = new FUnRegisterLevelSequence(base.NativePtr + (IntPtr)UKuroLevelSequenceSubsystem.__PropertyOffset_OnLevelSequenceUnRegister, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelSequenceSubsystem.__PropertyOffset_OnLevelSequenceUnRegister, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601A485 RID: 107653 RVA: 0x0026C894 File Offset: 0x0026AA94
		[NullableContext(2)]
		public unsafe AKuroLevelSequenceActor GetLevelSequence(in FName Key)
		{
			fixed (FName* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroLevelSequenceActor>(UKuroLevelSequenceSubsystem.__GetLevelSequence_Internal(base.NativePtr, Key));
			}
		}

		// Token: 0x0601A486 RID: 107654 RVA: 0x0026C8B7 File Offset: 0x0026AAB7
		public void GetAllLevelSequences([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AKuroLevelSequenceActor> InAllLevelSequences)
		{
			UKuroLevelSequenceSubsystem.__GetAllLevelSequences_Internal(base.NativePtr, (InAllLevelSequences ?? new TArray<AKuroLevelSequenceActor>()).NativePtr);
		}

		// Token: 0x0601A487 RID: 107655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelSequence_Internal(IntPtr @this, in FName Key);

		// Token: 0x0601A488 RID: 107656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllLevelSequences_Internal(IntPtr @this, IntPtr InAllLevelSequences);

		// Token: 0x0601A489 RID: 107657 RVA: 0x0026C8D4 File Offset: 0x0026AAD4
		static UKuroLevelSequenceSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceSubsystem");
		}

		// Token: 0x0601A48A RID: 107658 RVA: 0x0026C8E2 File Offset: 0x0026AAE2
		protected UKuroLevelSequenceSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E432 RID: 58418
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceSubsystem";

		// Token: 0x0400E433 RID: 58419
		private static IntPtr _ClassPtr;

		// Token: 0x0400E434 RID: 58420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E435 RID: 58421
		internal static int __PropertyOffset_OnLevelSequenceRegister;

		// Token: 0x0400E436 RID: 58422
		[Nullable(2)]
		private FRegisterLevelSequence _OnLevelSequenceRegister;

		// Token: 0x0400E437 RID: 58423
		internal static int __PropertyOffset_OnLevelSequenceUnRegister;

		// Token: 0x0400E438 RID: 58424
		[Nullable(2)]
		private FUnRegisterLevelSequence _OnLevelSequenceUnRegister;
	}
}
