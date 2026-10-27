using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C29 RID: 7209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterNode")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FSimpleShatterNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BE0E RID: 114190 RVA: 0x00290353 File Offset: 0x0028E553
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleShatterNode._ScriptStructPtr != 0) ? FSimpleShatterNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterNode", ref FSimpleShatterNode._ScriptStructPtr);
		}

		// Token: 0x17007068 RID: 28776
		// (get) Token: 0x0601BE0F RID: 114191 RVA: 0x00290377 File Offset: 0x0028E577
		// (set) Token: 0x0601BE10 RID: 114192 RVA: 0x00290387 File Offset: 0x0028E587
		public unsafe int NodeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_NodeID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_NodeID) = value;
			}
		}

		// Token: 0x17007069 RID: 28777
		// (get) Token: 0x0601BE11 RID: 114193 RVA: 0x00290398 File Offset: 0x0028E598
		// (set) Token: 0x0601BE12 RID: 114194 RVA: 0x002903AC File Offset: 0x0028E5AC
		public unsafe string NodeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSimpleShatterNode.__PropertyOffset_NodeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSimpleShatterNode.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x1700706A RID: 28778
		// (get) Token: 0x0601BE13 RID: 114195 RVA: 0x002903C1 File Offset: 0x0028E5C1
		// (set) Token: 0x0601BE14 RID: 114196 RVA: 0x002903D1 File Offset: 0x0028E5D1
		public unsafe bool bIsDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsDestroyed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsDestroyed) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700706B RID: 28779
		// (get) Token: 0x0601BE15 RID: 114197 RVA: 0x002903E2 File Offset: 0x0028E5E2
		// (set) Token: 0x0601BE16 RID: 114198 RVA: 0x002903F2 File Offset: 0x0028E5F2
		public unsafe bool bIsShattered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsShattered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsShattered) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700706C RID: 28780
		// (get) Token: 0x0601BE17 RID: 114199 RVA: 0x00290403 File Offset: 0x0028E603
		// (set) Token: 0x0601BE18 RID: 114200 RVA: 0x00290413 File Offset: 0x0028E613
		public unsafe bool bAutoShatterOnDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bAutoShatterOnDestroy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bAutoShatterOnDestroy) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700706D RID: 28781
		// (get) Token: 0x0601BE19 RID: 114201 RVA: 0x00290424 File Offset: 0x0028E624
		// (set) Token: 0x0601BE1A RID: 114202 RVA: 0x00290467 File Offset: 0x0028E667
		public TArray<int> ParentNodeIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ParentNodeIDs) == null)
				{
					result = (this._ParentNodeIDs = new TArray<int>(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_ParentNodeIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParentNodeIDs.CopyAssign(value);
			}
		}

		// Token: 0x1700706E RID: 28782
		// (get) Token: 0x0601BE1B RID: 114203 RVA: 0x00290478 File Offset: 0x0028E678
		// (set) Token: 0x0601BE1C RID: 114204 RVA: 0x002904BB File Offset: 0x0028E6BB
		public TMap<int, float> ParentWeights
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._ParentWeights) == null)
				{
					result = (this._ParentWeights = new TMap<int, float>(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_ParentWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParentWeights.CopyAssign(value);
			}
		}

		// Token: 0x1700706F RID: 28783
		// (get) Token: 0x0601BE1D RID: 114205 RVA: 0x002904CC File Offset: 0x0028E6CC
		// (set) Token: 0x0601BE1E RID: 114206 RVA: 0x0029050F File Offset: 0x0028E70F
		public TArray<int> ChildNodeIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ChildNodeIDs) == null)
				{
					result = (this._ChildNodeIDs = new TArray<int>(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_ChildNodeIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildNodeIDs.CopyAssign(value);
			}
		}

		// Token: 0x17007070 RID: 28784
		// (get) Token: 0x0601BE1F RID: 114207 RVA: 0x0029051D File Offset: 0x0028E71D
		// (set) Token: 0x0601BE20 RID: 114208 RVA: 0x00290531 File Offset: 0x0028E731
		[Nullable(2)]
		public unsafe UStaticMeshComponent OwnerComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleShatterNode.__PropertyOffset_OwnerComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleShatterNode.__PropertyOffset_OwnerComponent, value);
			}
		}

		// Token: 0x17007071 RID: 28785
		// (get) Token: 0x0601BE21 RID: 114209 RVA: 0x00290546 File Offset: 0x0028E746
		// (set) Token: 0x0601BE22 RID: 114210 RVA: 0x0029055A File Offset: 0x0028E75A
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x17007072 RID: 28786
		// (get) Token: 0x0601BE23 RID: 114211 RVA: 0x00290570 File Offset: 0x0028E770
		// (set) Token: 0x0601BE24 RID: 114212 RVA: 0x002905B3 File Offset: 0x0028E7B3
		public TArray<UStaticMesh> AfterDestroyed
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._AfterDestroyed) == null)
				{
					result = (this._AfterDestroyed = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_AfterDestroyed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AfterDestroyed.CopyAssign(value);
			}
		}

		// Token: 0x17007073 RID: 28787
		// (get) Token: 0x0601BE25 RID: 114213 RVA: 0x002905C4 File Offset: 0x0028E7C4
		// (set) Token: 0x0601BE26 RID: 114214 RVA: 0x00290607 File Offset: 0x0028E807
		public TArray<AStaticMeshActor> AfterDestroyedActor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._AfterDestroyedActor) == null)
				{
					result = (this._AfterDestroyedActor = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_AfterDestroyedActor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AfterDestroyedActor.CopyAssign(value);
			}
		}

		// Token: 0x17007074 RID: 28788
		// (get) Token: 0x0601BE27 RID: 114215 RVA: 0x00290615 File Offset: 0x0028E815
		// (set) Token: 0x0601BE28 RID: 114216 RVA: 0x00290629 File Offset: 0x0028E829
		public unsafe FTransform LastFrameWorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_LastFrameWorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_LastFrameWorldTransform) = value;
			}
		}

		// Token: 0x17007075 RID: 28789
		// (get) Token: 0x0601BE29 RID: 114217 RVA: 0x0029063E File Offset: 0x0028E83E
		// (set) Token: 0x0601BE2A RID: 114218 RVA: 0x00290652 File Offset: 0x0028E852
		public unsafe FVector CurSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_CurSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_CurSpeed) = value;
			}
		}

		// Token: 0x17007076 RID: 28790
		// (get) Token: 0x0601BE2B RID: 114219 RVA: 0x00290667 File Offset: 0x0028E867
		// (set) Token: 0x0601BE2C RID: 114220 RVA: 0x0029067B File Offset: 0x0028E87B
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleShatterNode.__PropertyOffset_NiagaraSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleShatterNode.__PropertyOffset_NiagaraSystem, value);
			}
		}

		// Token: 0x17007077 RID: 28791
		// (get) Token: 0x0601BE2D RID: 114221 RVA: 0x00290690 File Offset: 0x0028E890
		// (set) Token: 0x0601BE2E RID: 114222 RVA: 0x002906A0 File Offset: 0x0028E8A0
		public unsafe bool bEnableDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bEnableDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bEnableDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007078 RID: 28792
		// (get) Token: 0x0601BE2F RID: 114223 RVA: 0x002906B1 File Offset: 0x0028E8B1
		// (set) Token: 0x0601BE30 RID: 114224 RVA: 0x002906C1 File Offset: 0x0028E8C1
		public unsafe float WaitingDitherTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_WaitingDitherTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_WaitingDitherTime) = value;
			}
		}

		// Token: 0x17007079 RID: 28793
		// (get) Token: 0x0601BE31 RID: 114225 RVA: 0x002906D2 File Offset: 0x0028E8D2
		// (set) Token: 0x0601BE32 RID: 114226 RVA: 0x002906E2 File Offset: 0x0028E8E2
		public unsafe float Dither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_Dither);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_Dither) = value;
			}
		}

		// Token: 0x1700707A RID: 28794
		// (get) Token: 0x0601BE33 RID: 114227 RVA: 0x002906F3 File Offset: 0x0028E8F3
		// (set) Token: 0x0601BE34 RID: 114228 RVA: 0x00290703 File Offset: 0x0028E903
		public unsafe bool bIsDithering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsDithering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleShatterNode.__PropertyOffset_bIsDithering) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601BE35 RID: 114229 RVA: 0x00290714 File Offset: 0x0028E914
		public FSimpleShatterNode()
		{
		}

		// Token: 0x0601BE36 RID: 114230 RVA: 0x0029071C File Offset: 0x0028E91C
		public FSimpleShatterNode(int NodeID, string NodeName, bool bIsDestroyed, bool bIsShattered, bool bAutoShatterOnDestroy, TArray<int> ParentNodeIDs, TMap<int, float> ParentWeights, TArray<int> ChildNodeIDs, UStaticMeshComponent OwnerComponent, FTransform InitialTransform, TArray<UStaticMesh> AfterDestroyed, TArray<AStaticMeshActor> AfterDestroyedActor, FTransform LastFrameWorldTransform, FVector CurSpeed, UNiagaraSystem NiagaraSystem, bool bEnableDissolve, float WaitingDitherTime, float Dither, bool bIsDithering)
		{
			this.NodeID = NodeID;
			this.NodeName = NodeName;
			this.bIsDestroyed = bIsDestroyed;
			this.bIsShattered = bIsShattered;
			this.bAutoShatterOnDestroy = bAutoShatterOnDestroy;
			this.ParentNodeIDs = ParentNodeIDs;
			this.ParentWeights = ParentWeights;
			this.ChildNodeIDs = ChildNodeIDs;
			this.OwnerComponent = OwnerComponent;
			this.InitialTransform = InitialTransform;
			this.AfterDestroyed = AfterDestroyed;
			this.AfterDestroyedActor = AfterDestroyedActor;
			this.LastFrameWorldTransform = LastFrameWorldTransform;
			this.CurSpeed = CurSpeed;
			this.NiagaraSystem = NiagaraSystem;
			this.bEnableDissolve = bEnableDissolve;
			this.WaitingDitherTime = WaitingDitherTime;
			this.Dither = Dither;
			this.bIsDithering = bIsDithering;
		}

		// Token: 0x0601BE37 RID: 114231 RVA: 0x002907C4 File Offset: 0x0028E9C4
		protected override IntPtr GetUStructPtr()
		{
			return FSimpleShatterNode.StaticStruct();
		}

		// Token: 0x0601BE38 RID: 114232 RVA: 0x002907D0 File Offset: 0x0028E9D0
		[NullableContext(2)]
		public FSimpleShatterNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BE39 RID: 114233 RVA: 0x002907DA File Offset: 0x0028E9DA
		public FSimpleShatterNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BE3A RID: 114234 RVA: 0x002907E5 File Offset: 0x0028E9E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimpleShatterNode(Pointer, false, true);
		}

		// Token: 0x0601BE3B RID: 114235 RVA: 0x002907EF File Offset: 0x0028E9EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimpleShatterNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF7B RID: 61307
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterNode";

		// Token: 0x0400EF7C RID: 61308
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF7D RID: 61309
		internal static int __PropertyOffset_NodeID;

		// Token: 0x0400EF7E RID: 61310
		internal static int __PropertyOffset_NodeName;

		// Token: 0x0400EF7F RID: 61311
		internal static int __PropertyOffset_bIsDestroyed;

		// Token: 0x0400EF80 RID: 61312
		internal static int __PropertyOffset_bIsShattered;

		// Token: 0x0400EF81 RID: 61313
		internal static int __PropertyOffset_bAutoShatterOnDestroy;

		// Token: 0x0400EF82 RID: 61314
		internal static int __PropertyOffset_ParentNodeIDs;

		// Token: 0x0400EF83 RID: 61315
		[Nullable(2)]
		private TArray<int> _ParentNodeIDs;

		// Token: 0x0400EF84 RID: 61316
		internal static int __PropertyOffset_ParentWeights;

		// Token: 0x0400EF85 RID: 61317
		[Nullable(2)]
		private TMap<int, float> _ParentWeights;

		// Token: 0x0400EF86 RID: 61318
		internal static int __PropertyOffset_ChildNodeIDs;

		// Token: 0x0400EF87 RID: 61319
		[Nullable(2)]
		private TArray<int> _ChildNodeIDs;

		// Token: 0x0400EF88 RID: 61320
		internal static int __PropertyOffset_OwnerComponent;

		// Token: 0x0400EF89 RID: 61321
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x0400EF8A RID: 61322
		internal static int __PropertyOffset_AfterDestroyed;

		// Token: 0x0400EF8B RID: 61323
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _AfterDestroyed;

		// Token: 0x0400EF8C RID: 61324
		internal static int __PropertyOffset_AfterDestroyedActor;

		// Token: 0x0400EF8D RID: 61325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _AfterDestroyedActor;

		// Token: 0x0400EF8E RID: 61326
		internal static int __PropertyOffset_LastFrameWorldTransform;

		// Token: 0x0400EF8F RID: 61327
		internal static int __PropertyOffset_CurSpeed;

		// Token: 0x0400EF90 RID: 61328
		internal static int __PropertyOffset_NiagaraSystem;

		// Token: 0x0400EF91 RID: 61329
		internal static int __PropertyOffset_bEnableDissolve;

		// Token: 0x0400EF92 RID: 61330
		internal static int __PropertyOffset_WaitingDitherTime;

		// Token: 0x0400EF93 RID: 61331
		internal static int __PropertyOffset_Dither;

		// Token: 0x0400EF94 RID: 61332
		internal static int __PropertyOffset_bIsDithering;
	}
}
