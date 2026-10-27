using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018CE RID: 6350
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroEffectRuntimeGhostEffectContext : FKuroSkeletalMeshEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060177E3 RID: 96227 RVA: 0x002265AC File Offset: 0x002247AC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr != 0) ? FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext", ref FKuroEffectRuntimeGhostEffectContext._ScriptStructPtr);
		}

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x060177E4 RID: 96228 RVA: 0x002265D0 File Offset: 0x002247D0
		// (set) Token: 0x060177E5 RID: 96229 RVA: 0x002265E0 File Offset: 0x002247E0
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

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x060177E6 RID: 96230 RVA: 0x002265F1 File Offset: 0x002247F1
		// (set) Token: 0x060177E7 RID: 96231 RVA: 0x00226601 File Offset: 0x00224801
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

		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x060177E8 RID: 96232 RVA: 0x00226612 File Offset: 0x00224812
		// (set) Token: 0x060177E9 RID: 96233 RVA: 0x00226622 File Offset: 0x00224822
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

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x060177EA RID: 96234 RVA: 0x00226633 File Offset: 0x00224833
		// (set) Token: 0x060177EB RID: 96235 RVA: 0x00226643 File Offset: 0x00224843
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

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x060177EC RID: 96236 RVA: 0x00226654 File Offset: 0x00224854
		// (set) Token: 0x060177ED RID: 96237 RVA: 0x00226664 File Offset: 0x00224864
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

		// Token: 0x060177EE RID: 96238 RVA: 0x00226675 File Offset: 0x00224875
		public FKuroEffectRuntimeGhostEffectContext()
		{
		}

		// Token: 0x060177EF RID: 96239 RVA: 0x00226680 File Offset: 0x00224880
		[NullableContext(1)]
		public FKuroEffectRuntimeGhostEffectContext(float SpawnRate, bool UseSpawnRate, float SpawnInterval, float GhostLifeTime, bool UseBaseColorTex, USkeletalMeshComponent SkeletalMeshComponent, bool IsSyncTimeDilation, bool IsSyncEventTimeToEffectTime, int EntityId, UObject SourceObject, bool DisablePostProcess, int CreateFromType, int PlayFlag, bool CreateFromBpEffectActor, byte ContextType, int HitEffectType, FName AnsSlotName)
		{
			this.SpawnRate = SpawnRate;
			this.UseSpawnRate = UseSpawnRate;
			this.SpawnInterval = SpawnInterval;
			this.GhostLifeTime = GhostLifeTime;
			this.UseBaseColorTex = UseBaseColorTex;
			base.SkeletalMeshComponent = SkeletalMeshComponent;
			base.IsSyncTimeDilation = IsSyncTimeDilation;
			base.IsSyncEventTimeToEffectTime = IsSyncEventTimeToEffectTime;
			base.EntityId = EntityId;
			base.SourceObject = SourceObject;
			base.DisablePostProcess = DisablePostProcess;
			base.CreateFromType = CreateFromType;
			base.PlayFlag = PlayFlag;
			base.CreateFromBpEffectActor = CreateFromBpEffectActor;
			base.ContextType = ContextType;
			base.HitEffectType = HitEffectType;
			base.AnsSlotName = AnsSlotName;
		}

		// Token: 0x060177F0 RID: 96240 RVA: 0x00226718 File Offset: 0x00224918
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectRuntimeGhostEffectContext.StaticStruct();
		}

		// Token: 0x060177F1 RID: 96241 RVA: 0x00226724 File Offset: 0x00224924
		[NullableContext(2)]
		public FKuroEffectRuntimeGhostEffectContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060177F2 RID: 96242 RVA: 0x0022672E File Offset: 0x0022492E
		public FKuroEffectRuntimeGhostEffectContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060177F3 RID: 96243 RVA: 0x00226739 File Offset: 0x00224939
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectRuntimeGhostEffectContext(Pointer, false, true);
		}

		// Token: 0x060177F4 RID: 96244 RVA: 0x00226743 File Offset: 0x00224943
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectRuntimeGhostEffectContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC7A RID: 52346
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectRuntimeGhostEffectContext";

		// Token: 0x0400CC7B RID: 52347
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CC7C RID: 52348
		internal static int __PropertyOffset_SpawnRate;

		// Token: 0x0400CC7D RID: 52349
		internal static int __PropertyOffset_UseSpawnRate;

		// Token: 0x0400CC7E RID: 52350
		internal static int __PropertyOffset_SpawnInterval;

		// Token: 0x0400CC7F RID: 52351
		internal static int __PropertyOffset_GhostLifeTime;

		// Token: 0x0400CC80 RID: 52352
		internal static int __PropertyOffset_UseBaseColorTex;
	}
}
