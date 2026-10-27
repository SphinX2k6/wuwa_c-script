using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FBF RID: 4031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleRandomSeedInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FParticleRandomSeedInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D8EC RID: 55532 RVA: 0x00140329 File Offset: 0x0013E529
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleRandomSeedInfo._ScriptStructPtr != 0) ? FParticleRandomSeedInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleRandomSeedInfo", ref FParticleRandomSeedInfo._ScriptStructPtr);
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600D8ED RID: 55533 RVA: 0x0014034D File Offset: 0x0013E54D
		// (set) Token: 0x0600D8EE RID: 55534 RVA: 0x00140361 File Offset: 0x0013E561
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x00140376 File Offset: 0x0013E576
		// (set) Token: 0x0600D8F0 RID: 55536 RVA: 0x0014038F File Offset: 0x0013E58F
		public unsafe bool bGetSeedFromInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bGetSeedFromInstance) & FParticleRandomSeedInfo.__PropertyMask_bGetSeedFromInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bGetSeedFromInstance) = ((*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bGetSeedFromInstance) & ~FParticleRandomSeedInfo.__PropertyMask_bGetSeedFromInstance) | (value ? FParticleRandomSeedInfo.__PropertyMask_bGetSeedFromInstance : 0));
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x001403BF File Offset: 0x0013E5BF
		// (set) Token: 0x0600D8F2 RID: 55538 RVA: 0x001403D8 File Offset: 0x0013E5D8
		public unsafe bool bInstanceSeedIsIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bInstanceSeedIsIndex) & FParticleRandomSeedInfo.__PropertyMask_bInstanceSeedIsIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bInstanceSeedIsIndex) = ((*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bInstanceSeedIsIndex) & ~FParticleRandomSeedInfo.__PropertyMask_bInstanceSeedIsIndex) | (value ? FParticleRandomSeedInfo.__PropertyMask_bInstanceSeedIsIndex : 0));
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600D8F3 RID: 55539 RVA: 0x00140408 File Offset: 0x0013E608
		// (set) Token: 0x0600D8F4 RID: 55540 RVA: 0x00140421 File Offset: 0x0013E621
		public unsafe bool bResetSeedOnEmitterLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bResetSeedOnEmitterLooping) & FParticleRandomSeedInfo.__PropertyMask_bResetSeedOnEmitterLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bResetSeedOnEmitterLooping) = ((*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bResetSeedOnEmitterLooping) & ~FParticleRandomSeedInfo.__PropertyMask_bResetSeedOnEmitterLooping) | (value ? FParticleRandomSeedInfo.__PropertyMask_bResetSeedOnEmitterLooping : 0));
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600D8F5 RID: 55541 RVA: 0x00140451 File Offset: 0x0013E651
		// (set) Token: 0x0600D8F6 RID: 55542 RVA: 0x0014046A File Offset: 0x0013E66A
		public unsafe bool bRandomlySelectSeedArray
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bRandomlySelectSeedArray) & FParticleRandomSeedInfo.__PropertyMask_bRandomlySelectSeedArray) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bRandomlySelectSeedArray) = ((*(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_bRandomlySelectSeedArray) & ~FParticleRandomSeedInfo.__PropertyMask_bRandomlySelectSeedArray) | (value ? FParticleRandomSeedInfo.__PropertyMask_bRandomlySelectSeedArray : 0));
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600D8F7 RID: 55543 RVA: 0x0014049C File Offset: 0x0013E69C
		// (set) Token: 0x0600D8F8 RID: 55544 RVA: 0x001404DF File Offset: 0x0013E6DF
		public TArray<int> RandomSeeds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RandomSeeds) == null)
				{
					result = (this._RandomSeeds = new TArray<int>(base.NativePtr + (IntPtr)FParticleRandomSeedInfo.__PropertyOffset_RandomSeeds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RandomSeeds.CopyAssign(value);
			}
		}

		// Token: 0x0600D8F9 RID: 55545 RVA: 0x001404ED File Offset: 0x0013E6ED
		public FParticleRandomSeedInfo()
		{
		}

		// Token: 0x0600D8FA RID: 55546 RVA: 0x001404F5 File Offset: 0x0013E6F5
		public FParticleRandomSeedInfo(FName ParameterName, bool bGetSeedFromInstance, bool bInstanceSeedIsIndex, bool bResetSeedOnEmitterLooping, bool bRandomlySelectSeedArray, TArray<int> RandomSeeds)
		{
			this.ParameterName = ParameterName;
			this.bGetSeedFromInstance = bGetSeedFromInstance;
			this.bInstanceSeedIsIndex = bInstanceSeedIsIndex;
			this.bResetSeedOnEmitterLooping = bResetSeedOnEmitterLooping;
			this.bRandomlySelectSeedArray = bRandomlySelectSeedArray;
			this.RandomSeeds = RandomSeeds;
		}

		// Token: 0x0600D8FB RID: 55547 RVA: 0x0014052A File Offset: 0x0013E72A
		protected override IntPtr GetUStructPtr()
		{
			return FParticleRandomSeedInfo.StaticStruct();
		}

		// Token: 0x0600D8FC RID: 55548 RVA: 0x00140536 File Offset: 0x0013E736
		[NullableContext(2)]
		public FParticleRandomSeedInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D8FD RID: 55549 RVA: 0x00140540 File Offset: 0x0013E740
		public FParticleRandomSeedInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D8FE RID: 55550 RVA: 0x0014054B File Offset: 0x0013E74B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleRandomSeedInfo(Pointer, false, true);
		}

		// Token: 0x0600D8FF RID: 55551 RVA: 0x00140555 File Offset: 0x0013E755
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleRandomSeedInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040075A1 RID: 30113
		public const string __ObjectPath = "/Script/Engine.ParticleRandomSeedInfo";

		// Token: 0x040075A2 RID: 30114
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040075A3 RID: 30115
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040075A4 RID: 30116
		internal static int __PropertyOffset_bGetSeedFromInstance;

		// Token: 0x040075A5 RID: 30117
		internal static byte __PropertyMask_bGetSeedFromInstance;

		// Token: 0x040075A6 RID: 30118
		internal static int __PropertyOffset_bInstanceSeedIsIndex;

		// Token: 0x040075A7 RID: 30119
		internal static byte __PropertyMask_bInstanceSeedIsIndex;

		// Token: 0x040075A8 RID: 30120
		internal static int __PropertyOffset_bResetSeedOnEmitterLooping;

		// Token: 0x040075A9 RID: 30121
		internal static byte __PropertyMask_bResetSeedOnEmitterLooping;

		// Token: 0x040075AA RID: 30122
		internal static int __PropertyOffset_bRandomlySelectSeedArray;

		// Token: 0x040075AB RID: 30123
		internal static byte __PropertyMask_bRandomlySelectSeedArray;

		// Token: 0x040075AC RID: 30124
		internal static int __PropertyOffset_RandomSeeds;

		// Token: 0x040075AD RID: 30125
		[Nullable(2)]
		private TArray<int> _RandomSeeds;
	}
}
