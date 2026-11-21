using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003E8 RID: 1000
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroEffectRuntimeGhostEffectContext : FKuroSkeletalMeshEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061EB RID: 25067 RVA: 0x0008C0EA File Offset: 0x0008A2EA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr != 0) ? FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext", ref FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr);
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060061EC RID: 25068 RVA: 0x0008C10E File Offset: 0x0008A30E
		// (set) Token: 0x060061ED RID: 25069 RVA: 0x0008C11E File Offset: 0x0008A31E
		public unsafe float SpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_SpawnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_SpawnRate) = value;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060061EE RID: 25070 RVA: 0x0008C12F File Offset: 0x0008A32F
		// (set) Token: 0x060061EF RID: 25071 RVA: 0x0008C13F File Offset: 0x0008A33F
		public unsafe bool UseSpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_UseSpawnRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_UseSpawnRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060061F0 RID: 25072 RVA: 0x0008C150 File Offset: 0x0008A350
		// (set) Token: 0x060061F1 RID: 25073 RVA: 0x0008C160 File Offset: 0x0008A360
		public unsafe float SpawnInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_SpawnInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_SpawnInterval) = value;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060061F2 RID: 25074 RVA: 0x0008C171 File Offset: 0x0008A371
		// (set) Token: 0x060061F3 RID: 25075 RVA: 0x0008C181 File Offset: 0x0008A381
		public unsafe float GhostLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_GhostLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_GhostLifeTime) = value;
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060061F4 RID: 25076 RVA: 0x0008C192 File Offset: 0x0008A392
		// (set) Token: 0x060061F5 RID: 25077 RVA: 0x0008C1A2 File Offset: 0x0008A3A2
		public unsafe bool UseBaseColorTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_UseBaseColorTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectRuntimeGhostEffectContext.__PropertyOffset_UseBaseColorTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x0008C1B3 File Offset: 0x0008A3B3
		public FKuroEffectRuntimeGhostEffectContext()
		{
		}

		// Token: 0x060061F7 RID: 25079 RVA: 0x0008C1BB File Offset: 0x0008A3BB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectRuntimeGhostEffectContext.StaticStruct();
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x0008C1C7 File Offset: 0x0008A3C7
		[NullableContext(2)]
		public FKuroEffectRuntimeGhostEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061F9 RID: 25081 RVA: 0x0008C1D1 File Offset: 0x0008A3D1
		public FKuroEffectRuntimeGhostEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x0008C1DC File Offset: 0x0008A3DC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectRuntimeGhostEffectContext(Pointer, false, true);
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x0008C1E6 File Offset: 0x0008A3E6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectRuntimeGhostEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x040029B3 RID: 10675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext";

		// Token: 0x040029B4 RID: 10676
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029B5 RID: 10677
		internal static int __PropertyOffset_SpawnRate;

		// Token: 0x040029B6 RID: 10678
		internal static int __PropertyOffset_UseSpawnRate;

		// Token: 0x040029B7 RID: 10679
		internal static int __PropertyOffset_SpawnInterval;

		// Token: 0x040029B8 RID: 10680
		internal static int __PropertyOffset_GhostLifeTime;

		// Token: 0x040029B9 RID: 10681
		internal static int __PropertyOffset_UseBaseColorTex;
	}
}
