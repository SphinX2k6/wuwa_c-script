using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B8E RID: 7054
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPoseSequence")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroPoseSequence : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AC41 RID: 109633 RVA: 0x0027716A File Offset: 0x0027536A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPoseSequence._ScriptStructPtr != 0) ? FKuroPoseSequence._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroPoseSequence", ref FKuroPoseSequence._ScriptStructPtr);
		}

		// Token: 0x17006BA2 RID: 27554
		// (get) Token: 0x0601AC42 RID: 109634 RVA: 0x00277190 File Offset: 0x00275390
		// (set) Token: 0x0601AC43 RID: 109635 RVA: 0x002771D3 File Offset: 0x002753D3
		public TArray<UPoseableMeshComponent> PoseableMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPoseableMeshComponent> result;
				if ((result = this._PoseableMeshComponents) == null)
				{
					result = (this._PoseableMeshComponents = new TArray<UPoseableMeshComponent>(base.NativePtr + (IntPtr)FKuroPoseSequence.__PropertyOffset_PoseableMeshComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseableMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x17006BA3 RID: 27555
		// (get) Token: 0x0601AC44 RID: 109636 RVA: 0x002771E1 File Offset: 0x002753E1
		// (set) Token: 0x0601AC45 RID: 109637 RVA: 0x002771F5 File Offset: 0x002753F5
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPoseSequence.__PropertyOffset_SkeletalMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPoseSequence.__PropertyOffset_SkeletalMeshComponent, value);
			}
		}

		// Token: 0x0601AC46 RID: 109638 RVA: 0x0027720A File Offset: 0x0027540A
		public FKuroPoseSequence()
		{
		}

		// Token: 0x0601AC47 RID: 109639 RVA: 0x00277212 File Offset: 0x00275412
		public FKuroPoseSequence(TArray<UPoseableMeshComponent> PoseableMeshComponents, USkeletalMeshComponent SkeletalMeshComponent)
		{
			this.PoseableMeshComponents = PoseableMeshComponents;
			this.SkeletalMeshComponent = SkeletalMeshComponent;
		}

		// Token: 0x0601AC48 RID: 109640 RVA: 0x00277228 File Offset: 0x00275428
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPoseSequence.StaticStruct();
		}

		// Token: 0x0601AC49 RID: 109641 RVA: 0x00277234 File Offset: 0x00275434
		[NullableContext(2)]
		public FKuroPoseSequence(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x0027723E File Offset: 0x0027543E
		public FKuroPoseSequence(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AC4B RID: 109643 RVA: 0x00277249 File Offset: 0x00275449
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPoseSequence(Pointer, false, true);
		}

		// Token: 0x0601AC4C RID: 109644 RVA: 0x00277253 File Offset: 0x00275453
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPoseSequence(Pointer, MemoryOwner);
		}

		// Token: 0x0400E7A6 RID: 59302
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPoseSequence";

		// Token: 0x0400E7A7 RID: 59303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E7A8 RID: 59304
		internal static int __PropertyOffset_PoseableMeshComponents;

		// Token: 0x0400E7A9 RID: 59305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPoseableMeshComponent> _PoseableMeshComponents;

		// Token: 0x0400E7AA RID: 59306
		internal static int __PropertyOffset_SkeletalMeshComponent;
	}
}
